using System;
using System.Data;
using MySql.Data.MySqlClient;
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

        private async void LoadTotal()
        {
            string query = @"SELECT IFNULL(SUM(p.Price * c.Quantity), 0) as Total
                             FROM Cart c
                             JOIN Products p ON c.ProductId = p.ProductId
                             WHERE c.UserId = @uid";

            MySqlParameter[] p = { new MySqlParameter("@uid", userId) };

            try
            {
                object result = await db.ExecuteScalarAsync(query, p);
                decimal total = result != null ? Convert.ToDecimal(result) : 0;
                lblTotalAmount.Text = $"{total:C}";
            }
            catch (Exception ex)
            {
                lblTotalAmount.Text = "Ошибка";
                System.Diagnostics.Debug.WriteLine($"Ошибка загрузки суммы: {ex.Message}");
            }
        }

        private async void btnConfirmOrder_Click(object sender, EventArgs e)
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
            foreach (char ah in phone)
            {
                if (ah != '+' && ah != '1' && ah != '2' && ah != '3' && ah != '4' && ah != '5' && ah != '6' && ah != '7' && ah != '8' && ah != '9' && ah != '0')
                {
                    MessageBox.Show("Телефон не может содержать буквы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            DialogResult result = MessageBox.Show("Подтвердить заказ?", "Оформление",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            using (var conn = new MySqlConnection(db.GetConnectionString()))
            {
                conn.Open();
                using (var tran = await conn.BeginTransactionAsync())
                {
                    try
                    {
                        string cartSql = @"
                            SELECT p.ProductId, c.Quantity, p.Price, p.Stock
                            FROM Cart c 
                            JOIN Products p ON c.ProductId = p.ProductId
                            WHERE c.UserId = @uid";

                        using (var cmdCart = new MySqlCommand(cartSql, conn, tran))
                        {
                            cmdCart.Parameters.AddWithValue("@uid", userId);
                            using (var dr = await cmdCart.ExecuteReaderAsync())
                            {
                                var items = new List<(int productId, int quantity, decimal price)>();

                                while (await dr.ReadAsync())
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
                                await dr.CloseAsync();

                                decimal total = 0;
                                foreach (var item in items)
                                    total += item.price * item.quantity;

                                string orderSql = @"
                                    INSERT INTO Orders (UserId, TotalAmount, ShippingAddress, Phone, Status, OrderDate) 
                                    VALUES (@uid, @total, @addr, @phone, 'Pending', @orderDate);
                                    SELECT LAST_INSERT_ID()";

                                using (var cmdOrder = new MySqlCommand(orderSql, conn, tran))
                                {
                                    cmdOrder.Parameters.AddWithValue("@uid", userId);
                                    cmdOrder.Parameters.AddWithValue("@total", total);
                                    cmdOrder.Parameters.AddWithValue("@addr", address);
                                    cmdOrder.Parameters.AddWithValue("@phone", phone);
                                    cmdOrder.Parameters.AddWithValue("@orderDate", DateTime.Now);

                                    int orderId =  Convert.ToInt32(await cmdOrder.ExecuteScalarAsync());

                                    
                                    foreach (var item in items)
                                    {
                                        string itemSql = @"
                                            INSERT INTO OrderItems (OrderId, ProductId, Quantity, Price) 
                                            VALUES (@oid, @pid, @qty, @price)";

                                        using (var cmdItem = new MySqlCommand(itemSql, conn, tran))
                                        {
                                            cmdItem.Parameters.AddWithValue("@oid", orderId);
                                            cmdItem.Parameters.AddWithValue("@pid", item.productId);
                                            cmdItem.Parameters.AddWithValue("@qty", item.quantity);
                                            cmdItem.Parameters.AddWithValue("@price", item.price);
                                            await cmdItem.ExecuteNonQueryAsync();
                                        }

                                        string updateStock = "UPDATE Products SET Stock = Stock - @qty WHERE ProductId = @pid";
                                        using (var cmdStock = new MySqlCommand(updateStock, conn, tran))
                                        {
                                            cmdStock.Parameters.AddWithValue("@qty", item.quantity);
                                            cmdStock.Parameters.AddWithValue("@pid", item.productId);
                                            await cmdStock.ExecuteNonQueryAsync();
                                        }
                                    }

                                    
                                    string clearCart = "DELETE FROM Cart WHERE UserId = @uid";
                                    using (var cmdClear = new MySqlCommand(clearCart, conn, tran))
                                    {
                                        cmdClear.Parameters.AddWithValue("@uid", userId);
                                        await cmdClear.ExecuteScalarAsync();
                                    }

                                    await tran.CommitAsync();

                                    MessageBox.Show($"Заказ №{orderId} успешно оформлен!\nСумма: {total:C}\nДоставка по адресу: {address}",
                                        "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    this.Close();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        await tran.RollbackAsync();
                        MessageBox.Show($"Ошибка при оформлении заказа: {ex.Message}", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}