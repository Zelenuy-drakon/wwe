using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;

namespace OnlineStoreApp
{
    public partial class CheckoutForm : Form
    {
        private readonly int userId;
        private readonly DatabaseHelper db = new DatabaseHelper();

        public CheckoutForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            LoadTotal();
        }

        private void LoadTotal()
        {
            string query = @"SELECT ISNULL(SUM(p.Price * c.Quantity), 0) as Total
                             FROM Cart c
                             JOIN Products p ON c.ProductId = p.ProductId
                             WHERE c.UserId = @uid";

            SqlParameter[] p = { new SqlParameter("@uid", userId) };

            try
            {
                object result = db.ExecuteScalar(query, p);
                decimal total = result != null ? Convert.ToDecimal(result) : 0;
                lblTotal.Text = $"Итого к оплате: {total:C}";
            }
            catch (Exception ex)
            {
                lblTotal.Text = "Итого к оплате: 0 ₽";
                System.Diagnostics.Debug.WriteLine($"Ошибка загрузки суммы: {ex.Message}");
            }
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

            using (var conn = new SqlConnection(db.GetConnectionString()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        // Получаем товары из корзины
                        string cartSql = @"
                            SELECT p.ProductId, c.Quantity, p.Price, p.Stock
                            FROM Cart c 
                            JOIN Products p ON c.ProductId = p.ProductId
                            WHERE c.UserId = @uid";

                        using (var cmdCart = new SqlCommand(cartSql, conn, tran))
                        {
                            cmdCart.Parameters.AddWithValue("@uid", userId);
                            using (var dr = cmdCart.ExecuteReader())
                            {
                                var items = new List<(int productId, int quantity, decimal price)>();

                                while (dr.Read())
                                {
                                    int stock = dr.GetInt32(3);
                                    int quantity = dr.GetInt32(1);

                                    if (stock < quantity)
                                    {
                                        MessageBox.Show($"Недостаточно товара на складе. Доступно: {stock}", "Ошибка",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                    INSERT INTO Orders (UserId, TotalAmount, ShippingAddress, Phone, Status, OrderDate) 
                                    OUTPUT INSERTED.OrderId
                                    VALUES (@uid, @total, @addr, @phone, 'Pending', @orderDate)";

                                using (var cmdOrder = new SqlCommand(orderSql, conn, tran))
                                {
                                    cmdOrder.Parameters.AddWithValue("@uid", userId);
                                    cmdOrder.Parameters.AddWithValue("@total", total);
                                    cmdOrder.Parameters.AddWithValue("@addr", address);
                                    cmdOrder.Parameters.AddWithValue("@phone", phone);
                                    cmdOrder.Parameters.AddWithValue("@orderDate", DateTime.Now);

                                    int orderId = (int)cmdOrder.ExecuteScalar();

                                    // Добавляем товары в заказ и обновляем склад
                                    foreach (var item in items)
                                    {
                                        string itemSql = @"
                                            INSERT INTO OrderItems (OrderId, ProductId, Quantity, Price) 
                                            VALUES (@oid, @pid, @qty, @price)";

                                        using (var cmdItem = new SqlCommand(itemSql, conn, tran))
                                        {
                                            cmdItem.Parameters.AddWithValue("@oid", orderId);
                                            cmdItem.Parameters.AddWithValue("@pid", item.productId);
                                            cmdItem.Parameters.AddWithValue("@qty", item.quantity);
                                            cmdItem.Parameters.AddWithValue("@price", item.price);
                                            cmdItem.ExecuteNonQuery();
                                        }

                                        string updateStock = "UPDATE Products SET Stock = Stock - @qty WHERE ProductId = @pid";
                                        using (var cmdStock = new SqlCommand(updateStock, conn, tran))
                                        {
                                            cmdStock.Parameters.AddWithValue("@qty", item.quantity);
                                            cmdStock.Parameters.AddWithValue("@pid", item.productId);
                                            cmdStock.ExecuteNonQuery();
                                        }
                                    }

                                    // Очищаем корзину
                                    string clearCart = "DELETE FROM Cart WHERE UserId = @uid";
                                    using (var cmdClear = new SqlCommand(clearCart, conn, tran))
                                    {
                                        cmdClear.Parameters.AddWithValue("@uid", userId);
                                        cmdClear.ExecuteNonQuery();
                                    }

                                    tran.Commit();

                                    MessageBox.Show($"Заказ №{orderId} успешно оформлен!\nСумма: {total:C}\nДоставка по адресу: {address}",
                                        "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    this.Close();
                                }
                            }
                        }
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
}