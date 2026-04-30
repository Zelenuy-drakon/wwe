using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineStoreApp
{
    public partial class FavoritesForm : Form
    {
        private readonly int userId;
        private readonly DatabaseHelper db = new DatabaseHelper();

        public FavoritesForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            SetupDataGridViewColumns();
            LoadFavorites();
        }

        private void SetupDataGridViewColumns()
        {
            dgvFavorites.Columns.Clear();

            dgvFavorites.Columns.Add("FavoriteId", "ID");
            dgvFavorites.Columns["FavoriteId"].Visible = false;

            dgvFavorites.Columns.Add("ProductId", "ProductID");
            dgvFavorites.Columns["ProductId"].Visible = false;

            dgvFavorites.Columns.Add("Name", "Товар");
            dgvFavorites.Columns["Name"].Width = 250;

            dgvFavorites.Columns.Add("Price", "Цена");
            dgvFavorites.Columns["Price"].DefaultCellStyle.Format = "C";
        }

        private void LoadFavorites()
        {
            dgvFavorites.Rows.Clear();

            string query = @"
                SELECT f.FavoriteId, p.ProductId, p.Name, p.Price
                FROM Favorites f
                JOIN Products p ON f.ProductId = p.ProductId
                WHERE f.UserId = @uid";

            SqlParameter[] p = { new SqlParameter("@uid", userId) };
            DataTable dt = db.ExecuteQuery(query, p);

            foreach (DataRow row in dt.Rows)
            {
                dgvFavorites.Rows.Add(
                    row["FavoriteId"],
                    row["ProductId"],
                    row["Name"],
                    row["Price"]
                );
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvFavorites.CurrentRow == null) return;

            int favoriteId = Convert.ToInt32(dgvFavorites.CurrentRow.Cells["FavoriteId"].Value);
            string productName = dgvFavorites.CurrentRow.Cells["Name"].Value.ToString();

            DialogResult result = MessageBox.Show($"Удалить \"{productName}\" из избранного?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                db.ExecuteNonQuery("DELETE FROM Favorites WHERE FavoriteId = @id", new SqlParameter("@id", favoriteId));
                LoadFavorites();
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvFavorites.CurrentRow == null) return;

            int productId = Convert.ToInt32(dgvFavorites.CurrentRow.Cells["ProductId"].Value);
            string productName = dgvFavorites.CurrentRow.Cells["Name"].Value.ToString();

            string checkQuery = "SELECT COUNT(*) FROM Cart WHERE UserId = @uid AND ProductId = @pid";
            SqlParameter[] checkParams = {
                new SqlParameter("@uid", userId),
                new SqlParameter("@pid", productId)
            };

            DataTable dt = db.ExecuteQuery(checkQuery, checkParams);
            int count = Convert.ToInt32(dt.Rows[0][0]);

            if (count > 0)
            {
                string updateQuery = "UPDATE Cart SET Quantity = Quantity + 1 WHERE UserId = @uid AND ProductId = @pid";
                db.ExecuteNonQuery(updateQuery, checkParams);
            }
            else
            {
                string insertQuery = "INSERT INTO Cart (UserId, ProductId, Quantity) VALUES (@uid, @pid, 1)";
                db.ExecuteNonQuery(insertQuery, checkParams);
            }

            MessageBox.Show($"Товар \"{productName}\" добавлен в корзину", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}