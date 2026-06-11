using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStoreApp
{
    public partial class CartForm : Form
    {
        private readonly int userId;
        private readonly DatabaseHelper db = new DatabaseHelper();
       
        public CartForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            SetupDataGridViewColumns();
            LoadCartAsync();
        }

        private void SetupDataGridViewColumns()
        {
            dgvCart.Columns.Clear();

            dgvCart.Columns.Add("CartId", "ID");
            if (dgvCart.Columns["CartId"] != null)
                dgvCart.Columns["CartId"].Visible = false;

            dgvCart.Columns.Add("ProductId", "ProductID");
            if (dgvCart.Columns["ProductId"] != null)
                dgvCart.Columns["ProductId"].Visible = false;

            dgvCart.Columns.Add("Name", "Товар");
            if (dgvCart.Columns["Name"] != null)
                dgvCart.Columns["Name"].Width = 200;

            dgvCart.Columns.Add("Price", "Цена");
            if (dgvCart.Columns["Price"] != null)
                dgvCart.Columns["Price"].DefaultCellStyle.Format = "C";

            dgvCart.Columns.Add("Quantity", "Кол-во");
            if (dgvCart.Columns["Quantity"] != null)
                dgvCart.Columns["Quantity"].Width = 80;

            dgvCart.Columns.Add("Total", "Сумма");
            if (dgvCart.Columns["Total"] != null)
                dgvCart.Columns["Total"].DefaultCellStyle.Format = "C";
        }

        private async Task LoadCartAsync()
        {
            dgvCart.Rows.Clear();

            string query = @"
                SELECT c.CartId, p.ProductId, p.Name, p.Price, c.Quantity, (p.Price * c.Quantity) as Total
                FROM Cart c
                JOIN Products p ON c.ProductId = p.ProductId
                WHERE c.UserId = @uid";

            var parameter = new MySqlParameter("@uid", userId);
            DataTable dt = await db.ExecuteQueryAsync(query, parameter);

            foreach (DataRow row in dt.Rows)
            {
                dgvCart.Rows.Add(
                    row["CartId"],
                    row["ProductId"],
                    row["Name"]?.ToString() ?? "Нет названия",
                    row["Price"] != DBNull.Value ? row["Price"] : 0,
                    row["Quantity"] != DBNull.Value ? row["Quantity"] : 0,
                    row["Total"] != DBNull.Value ? row["Total"] : 0
                );
            }

            UpdateTotal();
        }

        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.Cells["Total"].Value != null && row.Cells["Total"].Value != DBNull.Value)
                {
                    total += Convert.ToDecimal(row.Cells["Total"].Value);
                }
            }
            lblTotalAmount.Text = $"{total:C}";
        }

        private async void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow == null) return;

            var cartIdCell = dgvCart.CurrentRow.Cells["CartId"];
            var nameCell = dgvCart.CurrentRow.Cells["Name"];

            if (cartIdCell?.Value == null || nameCell?.Value == null) return;

            int cartId = Convert.ToInt32(cartIdCell.Value);
            string productName = nameCell.Value.ToString() ?? "товар";

            DialogResult result = MessageBox.Show($"Удалить \"{productName}\" из корзины?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var parameter = new MySqlParameter("@id", cartId);
                await db.ExecuteNonQueryAsync("DELETE FROM Cart WHERE CartId = @id", parameter);
                await LoadCartAsync();
            }
        }

        private async void btnUpdateQuantity_Click(object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow == null) return;

            var cartIdCell = dgvCart.CurrentRow.Cells["CartId"];
            if (cartIdCell?.Value == null) return;

            int cartId = Convert.ToInt32(cartIdCell.Value);
            int newQuantity = (int)nudQuantity.Value;

            if (newQuantity <= 0)
            {
                btnRemove_Click(sender, e);
                return;
            }

            string updateQuery = "UPDATE Cart SET Quantity = @qty WHERE CartId = @id";
            MySqlParameter[] p = {
                new MySqlParameter("@qty", newQuantity),
                new MySqlParameter("@id", cartId)
            };
            await db.ExecuteNonQueryAsync(updateQuery, p);
            await  LoadCartAsync();
        }

        private void dgvCart_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow != null && dgvCart.CurrentRow.Cells["Quantity"].Value != null)
            {
                nudQuantity.Value = Convert.ToInt32(dgvCart.CurrentRow.Cells["Quantity"].Value);
            }
        }

        private async void btnCheckout_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count == 0)
            {
                MessageBox.Show("Корзина пуста", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var checkout = new CheckoutForm(userId);
            checkout.ShowDialog();
            await LoadCartAsync();
        }
    }
}