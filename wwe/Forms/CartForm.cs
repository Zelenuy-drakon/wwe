using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using wwe.Forms;

namespace OnlineStoreApp
{
    public partial class CartForm : Form
    {
        private int userId;
        private DatabaseHelper db = new DatabaseHelper();

        public CartForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            LoadCart();
        }

        private void LoadCart()
        {
            dgvCart.Rows.Clear();

            string query = @"
                SELECT c.CartId, p.ProductId, p.Name, p.Price, c.Quantity, (p.Price * c.Quantity) as Total
                FROM Cart c
                JOIN Products p ON c.ProductId = p.ProductId
                WHERE c.UserId = @uid";

            SqlParameter[] p = { new SqlParameter("@uid", userId) };
            DataTable dt = db.ExecuteQuery(query, p);

            foreach (DataRow row in dt.Rows)
            {
                dgvCart.Rows.Add(
                    row["CartId"],
                    row["ProductId"],
                    row["Name"],
                    row["Price"],
                    row["Quantity"],
                    row["Total"]
                );
            }

            UpdateTotal();
        }

        private void UpdateTotal()
        {
            decimal total = 0;
            for (int i = 0; i < dgvCart.Rows.Count; i++)
            {
                total += Convert.ToDecimal(dgvCart.Rows[i].Cells["Total"].Value);
            }
            lblTotal.Text = $"Итого: {total:C}";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow == null) return;

            int cartId = Convert.ToInt32(dgvCart.CurrentRow.Cells["CartId"].Value);
            string productName = dgvCart.CurrentRow.Cells["Name"].Value.ToString();

            DialogResult result = MessageBox.Show($"Удалить \"{productName}\" из корзины?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                db.ExecuteNonQuery("DELETE FROM Cart WHERE CartId = @id", new SqlParameter("@id", cartId));
                LoadCart();
            }
        }

        private void btnUpdateQuantity_Click(object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow == null) return;

            int cartId = Convert.ToInt32(dgvCart.CurrentRow.Cells["CartId"].Value);
            int newQuantity = (int)nudQuantity.Value;

            if (newQuantity <= 0)
            {
                btnRemove_Click(sender, e);
                return;
            }

            string updateQuery = "UPDATE Cart SET Quantity = @qty WHERE CartId = @id";
            SqlParameter[] p = {
                new SqlParameter("@qty", newQuantity),
                new SqlParameter("@id", cartId)
            };
            db.ExecuteNonQuery(updateQuery, p);
            LoadCart();
        }

        private void dgvCart_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow != null)
            {
                nudQuantity.Value = Convert.ToInt32(dgvCart.CurrentRow.Cells["Quantity"].Value);
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count == 0)
            {
                MessageBox.Show("Корзина пуста", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CheckoutForm checkout = new CheckoutForm(userId);
            checkout.ShowDialog();
            LoadCart();
        }
    }
}