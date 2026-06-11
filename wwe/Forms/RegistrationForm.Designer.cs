using Org.BouncyCastle.Asn1.Crmf;
using System.Drawing;
using System.Windows.Forms;
using static MetroFramework.Drawing.MetroPaint;
using static System.Net.Mime.MediaTypeNames;

namespace wwe.Forms
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.ComboBox cmbSecurityQuestion;
        private System.Windows.Forms.TextBox txtSecurityAnswer;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBackToLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblSecurityQuestion;
        private System.Windows.Forms.Label lblSecurityAnswer;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Panel pnlCircle1;
        private System.Windows.Forms.Panel pnlCircle2;
        private System.Windows.Forms.Panel pnlDiamond1;
        private System.Windows.Forms.Panel pnlLeaf1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            cmbSecurityQuestion = new ComboBox();
            txtSecurityAnswer = new TextBox();
            btnRegister = new Button();
            btnBackToLogin = new Button();
            lblUsername = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            lblSecurityQuestion = new Label();
            lblSecurityAnswer = new Label();
            pnlForm = new Panel();
            lblTitle = new Label();
            pnlDivider = new Panel();
            pnlCircle1 = new Panel();
            pnlCircle2 = new Panel();
            pnlDiamond1 = new Panel();
            pnlLeaf1 = new Panel();
            pnlForm.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(245, 236, 215);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            txtUsername.Location = new Point(50, 112);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 21);
            txtUsername.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(245, 236, 215);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            txtEmail.Location = new Point(50, 162);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 21);
            txtEmail.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(245, 236, 215);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            txtPassword.Location = new Point(50, 212);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(300, 21);
            txtPassword.TabIndex = 6;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.FromArgb(245, 236, 215);
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            txtConfirmPassword.Location = new Point(50, 262);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '●';
            txtConfirmPassword.Size = new Size(300, 21);
            txtConfirmPassword.TabIndex = 8;
            // 
            // cmbSecurityQuestion
            // 
            cmbSecurityQuestion.BackColor = Color.FromArgb(245, 236, 215);
            cmbSecurityQuestion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSecurityQuestion.FlatStyle = FlatStyle.Flat;
            cmbSecurityQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            cmbSecurityQuestion.ForeColor = Color.FromArgb(51, 51, 51);
            cmbSecurityQuestion.Items.AddRange(new object[] { "Ваше любимое блюдо?", "Кличка вашего первого питомца?", "Название вашей первой школы?", "Город вашего рождения?", "Имя вашего любимого учителя?", "Марка вашего первого автомобиля?" });
            cmbSecurityQuestion.Location = new Point(50, 325);
            cmbSecurityQuestion.Name = "cmbSecurityQuestion";
            cmbSecurityQuestion.Size = new Size(300, 23);
            cmbSecurityQuestion.TabIndex = 10;
            // 
            // txtSecurityAnswer
            // 
            txtSecurityAnswer.BackColor = Color.FromArgb(245, 236, 215);
            txtSecurityAnswer.BorderStyle = BorderStyle.FixedSingle;
            txtSecurityAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            txtSecurityAnswer.Location = new Point(50, 380);
            txtSecurityAnswer.Name = "txtSecurityAnswer";
            txtSecurityAnswer.Size = new Size(300, 21);
            txtSecurityAnswer.TabIndex = 12;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(45, 90, 39);
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnRegister.ForeColor = Color.FromArgb(245, 236, 215);
            btnRegister.Location = new Point(100, 430);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(200, 40);
            btnRegister.TabIndex = 13;
            btnRegister.Text = "Зарегистрироваться";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.BackColor = Color.Transparent;
            btnBackToLogin.FlatAppearance.BorderSize = 0;
            btnBackToLogin.FlatStyle = FlatStyle.Flat;
            btnBackToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            btnBackToLogin.ForeColor = Color.FromArgb(139, 105, 20);
            btnBackToLogin.Location = new Point(130, 480);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(140, 25);
            btnBackToLogin.TabIndex = 14;
            btnBackToLogin.Text = "← Назад к входу";
            btnBackToLogin.UseVisualStyleBackColor = false;
            btnBackToLogin.Click += btnBackToLogin_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(107, 66, 38);
            lblUsername.Location = new Point(50, 94);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(138, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Имя пользователя:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(107, 66, 38);
            lblEmail.Location = new Point(50, 144);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(107, 66, 38);
            lblPassword.Location = new Point(50, 194);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(61, 15);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Пароль:";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblConfirmPassword.ForeColor = Color.FromArgb(107, 66, 38);
            lblConfirmPassword.Location = new Point(50, 244);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(119, 15);
            lblConfirmPassword.TabIndex = 7;
            lblConfirmPassword.Text = "Подтверждение:";
            // 
            // lblSecurityQuestion
            // 
            lblSecurityQuestion.AutoSize = true;
            lblSecurityQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblSecurityQuestion.ForeColor = Color.FromArgb(107, 66, 38);
            lblSecurityQuestion.Location = new Point(50, 307);
            lblSecurityQuestion.Name = "lblSecurityQuestion";
            lblSecurityQuestion.Size = new Size(136, 15);
            lblSecurityQuestion.TabIndex = 9;
            lblSecurityQuestion.Text = "Секретный вопрос:";
            // 
            // lblSecurityAnswer
            // 
            lblSecurityAnswer.AutoSize = true;
            lblSecurityAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblSecurityAnswer.ForeColor = Color.FromArgb(107, 66, 38);
            lblSecurityAnswer.Location = new Point(50, 362);
            lblSecurityAnswer.Name = "lblSecurityAnswer";
            lblSecurityAnswer.Size = new Size(124, 15);
            lblSecurityAnswer.TabIndex = 11;
            lblSecurityAnswer.Text = "Ответ на вопрос:";
            // 
            // pnlForm
            // 
            pnlForm.BackColor = Color.FromArgb(255, 249, 240);
            pnlForm.Controls.Add(lblTitle);
            pnlForm.Controls.Add(lblUsername);
            pnlForm.Controls.Add(txtUsername);
            pnlForm.Controls.Add(lblEmail);
            pnlForm.Controls.Add(txtEmail);
            pnlForm.Controls.Add(lblPassword);
            pnlForm.Controls.Add(txtPassword);
            pnlForm.Controls.Add(lblConfirmPassword);
            pnlForm.Controls.Add(txtConfirmPassword);
            pnlForm.Controls.Add(lblSecurityQuestion);
            pnlForm.Controls.Add(cmbSecurityQuestion);
            pnlForm.Controls.Add(lblSecurityAnswer);
            pnlForm.Controls.Add(txtSecurityAnswer);
            pnlForm.Controls.Add(btnRegister);
            pnlForm.Controls.Add(btnBackToLogin);
            pnlForm.Controls.Add(pnlDivider);
            pnlForm.Location = new Point(100, 60);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(400, 540);
            pnlForm.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, FontStyle.Italic);
            lblTitle.ForeColor = Color.FromArgb(107, 66, 38);
            lblTitle.Location = new Point(0, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Регистрация";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlDivider
            // 
            pnlDivider.BackColor = Color.FromArgb(212, 196, 168);
            pnlDivider.Location = new Point(50, 80);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(300, 2);
            pnlDivider.TabIndex = 15;
            // 
            // pnlCircle1
            // 
            pnlCircle1.BackColor = Color.Transparent;
            pnlCircle1.Location = new Point(25, 25);
            pnlCircle1.Name = "pnlCircle1";
            pnlCircle1.Size = new Size(30, 30);
            pnlCircle1.TabIndex = 10;
            pnlCircle1.Paint += DrawCircle;
            // 
            // pnlCircle2
            // 
            pnlCircle2.BackColor = Color.Transparent;
            pnlCircle2.Location = new Point(545, 20);
            pnlCircle2.Name = "pnlCircle2";
            pnlCircle2.Size = new Size(20, 20);
            pnlCircle2.TabIndex = 11;
            pnlCircle2.Paint += DrawAccentCircle;
            // 
            // pnlDiamond1
            // 
            pnlDiamond1.BackColor = Color.Transparent;
            pnlDiamond1.Location = new Point(30, 570);
            pnlDiamond1.Name = "pnlDiamond1";
            pnlDiamond1.Size = new Size(25, 25);
            pnlDiamond1.TabIndex = 14;
            pnlDiamond1.Paint += DrawDiamond;
            // 
            // pnlLeaf1
            // 
            pnlLeaf1.BackColor = Color.Transparent;
            pnlLeaf1.Location = new Point(595, 580);
            pnlLeaf1.Name = "pnlLeaf1";
            pnlLeaf1.Size = new Size(25, 20);
            pnlLeaf1.TabIndex = 20;
            pnlLeaf1.Paint += DrawLeaf;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(212, 196, 168);
            ClientSize = new Size(650, 640);
            Controls.Add(pnlLeaf1);
            Controls.Add(pnlDiamond1);
            Controls.Add(pnlCircle2);
            Controls.Add(pnlCircle1);
            Controls.Add(pnlForm);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация - Винтажный Бутик";
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ResumeLayout(false);
        }

        // Методы для рисования фигур (аналогичные LoginForm)
        private void DrawCircle(object sender, PaintEventArgs e)
        {
            Panel pnl = sender as Panel;
            using (Pen pen = new Pen(Color.FromArgb(218, 165, 32), 1.5f))
            {
                e.Graphics.DrawEllipse(pen, 0, 0, pnl.Width - 1, pnl.Height - 1);
            }
        }

        private void DrawAccentCircle(object sender, PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(218, 165, 32)))
            {
                e.Graphics.FillEllipse(brush, 0, 0, 18, 18);
            }
        }

        private void DrawDiamond(object sender, PaintEventArgs e)
        {
            Point[] points = new Point[]
            {
                new Point(12, 0),
                new Point(24, 12),
                new Point(12, 24),
                new Point(0, 12)
            };
            using (Pen pen = new Pen(Color.FromArgb(204, 102, 68), 1.5f))
            {
                e.Graphics.DrawPolygon(pen, points);
            }
        }

        private void DrawLeaf(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddBezier(0, 10, 5, 0, 20, 0, 24, 10);
            path.AddBezier(24, 10, 20, 19, 5, 19, 0, 10);
            using (Pen pen = new Pen(Color.FromArgb(85, 107, 47), 1.5f))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }
    }
}