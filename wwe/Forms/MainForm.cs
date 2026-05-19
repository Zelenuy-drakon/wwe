using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStoreApp
{
    public  partial class MainForm : Form
    {
        private readonly int userId;
        private readonly DatabaseHelper db = new DatabaseHelper();

        public MainForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            this.Load += async (s, e) => await LoadDataAsync();
        }
        private async Task LoadDataAsync()
        {
            await LoadCategoriesAsync();
            await LoadProductsAsync();
        }

        private async Task LoadCategoriesAsync()
        {
            DataTable dt = await db.ExecuteQueryAsync("SELECT * FROM Categories");
            cmbCategories.DataSource = dt;
            cmbCategories.DisplayMember = "Name";
            cmbCategories.ValueMember = "CategoryId";
            cmbCategories.SelectedIndex = -1;
        }

        private async Task LoadProductsAsync(string search = "", int? categoryId = null)
        {
            string query = @"
                SELECT p.ProductId, p.Name, p.Price, p.Stock, c.Name as CategoryName 
                FROM Products p 
                JOIN Categories c ON p.CategoryId = c.CategoryId
                WHERE (p.Name LIKE CONCAT('%', @search, '%') OR @search = '')
            ";

            var parameters = new List<MySqlParameter>();
            parameters.Add(new MySqlParameter("@search", search));

            if (categoryId.HasValue)
            {
                query += " AND p.CategoryId = @categoryId";
                parameters.Add(new MySqlParameter("@categoryId", categoryId.Value));
            }

            DataTable dt = await db.ExecuteQueryAsync(query, parameters.ToArray());
            dgvProducts.DataSource = dt;

            if (dgvProducts.Columns.Contains("ProductId"))
                dgvProducts.Columns["ProductId"].Visible = false;

            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private async void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            int? catId = null;
            if (cmbCategories.SelectedValue != null && cmbCategories.SelectedValue is int)
                catId = (int)cmbCategories.SelectedValue;
           await LoadProductsAsync(txtSearch.Text, catId);
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            int? catId = null;
            if (cmbCategories.SelectedValue != null && cmbCategories.SelectedValue is int)
                catId = (int)cmbCategories.SelectedValue;
            await LoadProductsAsync(txtSearch.Text, catId);
        }

        private async void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;

            int productId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["ProductId"].Value);
            string productName = dgvProducts.CurrentRow.Cells["Name"].Value.ToString();

            string checkQuery = "SELECT COUNT(*) FROM Cart WHERE UserId = @uid AND ProductId = @pid";
            MySqlParameter[] checkParams = {
                new MySqlParameter("@uid", userId),
                new MySqlParameter("@pid", productId)
            };
            DataTable dt = await db.ExecuteQueryAsync(checkQuery, checkParams);
            int count = Convert.ToInt32(dt.Rows[0][0]);

            if (count > 0)
            {
                string updateQuery = "UPDATE Cart SET Quantity = Quantity + 1 WHERE UserId = @uid AND ProductId = @pid";
                
                await db.ExecuteNonQueryAsync(updateQuery, checkParams);
            }
            else
            {
                string insertQuery = "INSERT INTO Cart (UserId, ProductId, Quantity) VALUES (@uid, @pid, 1)";
                await db.ExecuteNonQueryAsync(insertQuery, checkParams);
            }

            MessageBox.Show($"Товар \"{productName}\" добавлен в корзину", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btnAddToFavorites_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;

            int productId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["ProductId"].Value);
            string productName = dgvProducts.CurrentRow.Cells["Name"].Value.ToString();

            string checkQuery = "SELECT COUNT(*) FROM Favorites WHERE UserId = @uid AND ProductId = @pid";
            MySqlParameter[] checkParams = {
                new MySqlParameter("@uid", userId),
                new MySqlParameter("@pid", productId)
            };
            DataTable dt = await db.ExecuteQueryAsync(checkQuery, checkParams);
            int count = Convert.ToInt32(dt.Rows[0][0]);

            if (count > 0)
            {
                MessageBox.Show("Товар уже в избранном", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string insertQuery = "INSERT INTO Favorites (UserId, ProductId) VALUES (@uid, @pid)";
            await db.ExecuteNonQueryAsync(insertQuery, checkParams);
            MessageBox.Show($"Товар \"{productName}\" добавлен в избранное", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            var cartForm = new CartForm(userId);
            cartForm.ShowDialog();
        }

        private void btnFavorites_Click(object sender, EventArgs e)
        {
            var favForm = new FavoritesForm(userId);
            favForm.ShowDialog();
        }
    }
}