using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using wwe.Forms;

namespace OnlineStoreApp
{
    public partial class LoginForm : Form
    {
        private DatabaseHelper db = new DatabaseHelper();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "SELECT UserId FROM Users WHERE Username = @user AND PasswordHash = @pass";
            SqlParameter[] p = {
                new SqlParameter("@user", username),
                new SqlParameter("@pass", password)
            };

            DataTable dt = db.ExecuteQuery(query, p);

            if (dt.Rows.Count > 0)
            {
                int userId = Convert.ToInt32(dt.Rows[0]["UserId"]);
                MainForm main = new MainForm(userId);
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnForgot_Click(object sender, EventArgs e)
        {
            PasswordResetForm resetForm = new PasswordResetForm();
            resetForm.ShowDialog();
        }
    }
}