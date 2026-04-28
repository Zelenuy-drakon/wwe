using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineStoreApp
{
    public partial class CheckoutForm : Form
    {
        private int userId;
        private DatabaseHelper db = new DatabaseHelper();

        public CheckoutForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            LoadTotal();
        }

        private void LoadTotal()
        {
            string query = @"SELECT SUM(p.Price * c.Quantity) as Total
                             FROM Cart c
                             JOIN Products p ON c.ProductId = p.ProductId
                             WHERE c.UserId = @uid";

            SqlParameter[] p = { new SqlParameter("@uid", userId) };
            DataTable dt = db.ExecuteQuery(query, p);

            decimal total = 0;
            if (dt.Rows[0]["Total"] != DBNull.Value)
                total = Convert.ToDecimal(dt.Rows[0]["Total"]);

            lblTotal.Text = $"Итого к оплате: {total:C}";
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            string address = txtAddress.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Введите адрес доставки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Введите номер телефона", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Подтвердить заказ?", "Оформление",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            using (SqlConnection conn = new SqlConnection(db.GetConnectionString()))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    // Получаем товары из корзины
                    string cartSql = @"
                        SELECT p.ProductId, c.Quantity, p.Price, p.Stock
                        FROM Cart c 
                        JOIN Products p ON c.ProductId = p.ProductId
                        WHERE c.UserId = @uid";

                    SqlCommand cmdCart = new SqlCommand(cartSql, conn, tran);
                    cmdCart.Parameters.AddWithValue("@uid", userId);
                    SqlDataReader dr = cmdCart.ExecuteReader();

                    var items = new System.Collections.Generic.List<(int productId, int quantity, decimal price)>();
                    while (dr.Read())
                    {
                        int stock = dr.GetInt32(3);
                        int quantity = dr.GetInt32(1);

                        if (stock < quantity)
                        {
                            dr.Close();
                            tran.Rollback();
                            MessageBox.Show($"Недостаточно товара на складе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        items.Add((
                            dr.GetInt32(0),
                            dr.GetInt32(1),
                            dr.GetDecimal(2)
                        ));
                    }
                    dr.Close();

                    // Вычисляем общую сумму
                    decimal total = 0;
                    foreach (var item in items)
                        total += item.price * item.quantity;

                    // Создаем заказ
                    string orderSql = @"
                        INSERT INTO Orders (UserId, TotalAmount, ShippingAddress, Phone, Status) 
                        OUTPUT INSERTED.OrderId
                        VALUES (@uid, @total, @addr, @phone, 'Pending')";

                    SqlCommand cmdOrder = new SqlCommand(orderSql, conn, tran);
                    cmdOrder.Parameters.AddWithValue("@uid", userId);
                    cmdOrder.Parameters.AddWithValue("@total", total);
                    cmdOrder.Parameters.AddWithValue("@addr", address);
                    cmdOrder.Parameters.AddWithValue("@phone", phone);
                    int orderId = (int)cmdOrder.ExecuteScalar();

                    // Добавляем товары в заказ и обновляем склад
                    foreach (var item in items)
                    {
                        string itemSql = @"
                            INSERT INTO OrderItems (OrderId, ProductId, Quantity, Price) 
                            VALUES (@oid, @pid, @qty, @price)";

                        SqlCommand cmdItem = new SqlCommand(itemSql, conn, tran);
                        cmdItem.Parameters.AddWithValue("@oid", orderId);
                        cmdItem.Parameters.AddWithValue("@pid", item.productId);
                        cmdItem.Parameters.AddWithValue("@qty", item.quantity);
                        cmdItem.Parameters.AddWithValue("@price", item.price);
                        cmdItem.ExecuteNonQuery();

                        string updateStock = "UPDATE Products SET Stock = Stock - @qty WHERE ProductId = @pid";
                        SqlCommand cmdStock = new SqlCommand(updateStock, conn, tran);
                        cmdStock.Parameters.AddWithValue("@qty", item.quantity);
                        cmdStock.Parameters.AddWithValue("@pid", item.productId);
                        cmdStock.ExecuteNonQuery();
                    }

                    // Очищаем корзину
                    string clearCart = "DELETE FROM Cart WHERE UserId = @uid";
                    SqlCommand cmdClear = new SqlCommand(clearCart, conn, tran);
                    cmdClear.Parameters.AddWithValue("@uid", userId);
                    cmdClear.ExecuteNonQuery();

                    tran.Commit();

                    MessageBox.Show($"Заказ №{orderId} успешно оформлен!\nСумма: {total:C}\nДоставка по адресу: {address}",
                        "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show($"Ошибка при оформлении заказа: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}