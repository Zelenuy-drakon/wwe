using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace OnlineStoreApp
{
    public partial class PasswordResetForm : Form
    {
        private readonly DatabaseHelper db = new DatabaseHelper();
        private string? currentUsername; // Исправлено: nullable

        public PasswordResetForm()
        {
            InitializeComponent();
            gbAnswer.Visible = false;
            gbNewPassword.Visible = false;
        }

        private void btnCheckUser_Click(object sender, EventArgs e)
        {
            currentUsername = txtUsername.Text.Trim();

            if (string.IsNullOrEmpty(currentUsername))
            {
                MessageBox.Show("Введите имя пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "SELECT SecurityQuestion, SecurityAnswer FROM Users WHERE Username = @user";
            var parameter = new MySqlParameter("@user", currentUsername);
            DataTable dt = db.ExecuteQuery(query, parameter);

            if (dt.Rows.Count > 0)
            {
                var firstRow = dt.Rows[0];
                lblQuestion.Text = firstRow["SecurityQuestion"]?.ToString() ?? "Нет вопроса";
                string correctAnswer = firstRow["SecurityAnswer"]?.ToString() ?? string.Empty;

                this.Tag = correctAnswer;

                gbAnswer.Visible = true;
                btnCheckUser.Enabled = false;
                txtUsername.Enabled = false;
            }
            else
            {
                MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerifyAnswer_Click(object sender, EventArgs e)
        {
            string userAnswer = txtAnswer.Text.Trim();
            string? correctAnswer = this.Tag?.ToString();

            if (string.IsNullOrEmpty(userAnswer))
            {
                MessageBox.Show("Введите ответ на вопрос", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(correctAnswer) && userAnswer.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
            {
                gbNewPassword.Visible = true;
                btnVerifyAnswer.Enabled = false;
                txtAnswer.Enabled = false;
            }
            else
            {
                MessageBox.Show("Неверный ответ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Введите новый пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(currentUsername))
            {
                MessageBox.Show("Ошибка: пользователь не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string updateQuery = "UPDATE Users SET PasswordHash = @pass WHERE Username = @user";
            MySqlParameter[] p = {
                new MySqlParameter("@pass", newPassword),
                new MySqlParameter("@user", currentUsername)
            };
            db.ExecuteNonQuery(updateQuery, p);

            MessageBox.Show("Пароль успешно изменен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}