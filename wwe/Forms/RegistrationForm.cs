using MySql.Data.MySqlClient;
using OnlineStoreApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;
namespace wwe.Forms
{
    
        public partial class RegisterForm : Form
        {
            private readonly DatabaseHelper db = new DatabaseHelper();

            public RegisterForm()
            {
                InitializeComponent();
            }

            // Валидация email
            private bool IsValidEmail(string email)
            {
                if (string.IsNullOrWhiteSpace(email))
                    return false;

                try
                {
                    var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase);
                    return regex.IsMatch(email);
                }
                catch
                {
                    return false;
                }
            }
            
        private async void btnRegister_Click(object sender, EventArgs e)
            {
                string username = txtUsername.Text.Trim();
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text;
                string confirmPassword = txtConfirmPassword.Text;
                string securityQuestion = cmbSecurityQuestion.Text;
                string securityAnswer = txtSecurityAnswer.Text.Trim();

                // Валидация
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) ||
                    string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
                {
                    MessageBox.Show("Заполните все обязательные поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (username.Length < 3)
                {
                    MessageBox.Show("Имя пользователя должно содержать минимум 3 символа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsValidEmail(email))
                {
                    MessageBox.Show("Введите корректный email адрес", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (password.Length < 6)
                {
                    MessageBox.Show("Пароль должен содержать минимум 6 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (password != confirmPassword)
                {
                    MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(securityQuestion) || string.IsNullOrEmpty(securityAnswer))
                {
                    MessageBox.Show("Выберите вопрос безопасности и введите ответ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (IsOnlyCyrillic(securityAnswer) != true && securityAnswer.Length < 2)
                {
                    MessageBox.Show("Ответ должен быть на русском и содержать более двух букв", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Проверяем, что ответ на секретный вопрос не пустой, и все символы — русские буквы
             bool IsOnlyCyrillic(string input)
             {
                if (string.IsNullOrWhiteSpace(input)) return false;

            
                return input.All(c => char.IsLetter(c) && (c >= 'А' && c <= 'я' || c == 'Ё' || c == 'ё'));
             }

            // Проверка существования пользователя по логину
            string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @user";
                MySqlParameter[] checkParams = { new MySqlParameter("@user", username) };
                DataTable dt = await db.ExecuteQueryAsync(checkQuery, checkParams);
                int userExists = Convert.ToInt32(dt.Rows[0][0]);

                if (userExists > 0)
                {
                    MessageBox.Show("Пользователь с таким именем уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Проверка существования email
                string checkEmailQuery = "SELECT COUNT(*) FROM Users WHERE Email = @email";
                MySqlParameter[] emailParams = { new MySqlParameter("@email", email) };
                DataTable dtEmail = await db.ExecuteQueryAsync(checkEmailQuery, emailParams);
                int emailExists = Convert.ToInt32(dtEmail.Rows[0][0]);

                if (emailExists > 0)
                {
                    MessageBox.Show("Пользователь с таким email уже зарегистрирован", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Регистрация
                string insertQuery = @"
                INSERT INTO Users (Username, Email, PasswordHash, SecurityQuestion, SecurityAnswer) 
                VALUES (@user, @email, @pass, @question, @answer)";

                MySqlParameter[] parameters = {
                new MySqlParameter("@user", username),
                new MySqlParameter("@email", email),
                new MySqlParameter("@pass", password),
                new MySqlParameter("@question", securityQuestion),
                new MySqlParameter("@answer", securityAnswer)
            };

                try
                {
                    await db.ExecuteNonQueryAsync(insertQuery, parameters);
                    MessageBox.Show($"Регистрация успешно завершена!\n\nЛогин: {username}\nEmail: {email}\n\nТеперь вы можете войти в систему.",
                        "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при регистрации: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void btnBackToLogin_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        }
    }

