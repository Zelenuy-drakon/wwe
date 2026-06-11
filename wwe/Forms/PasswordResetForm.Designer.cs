namespace OnlineStoreApp
{
    partial class PasswordResetForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnCheckUser;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.GroupBox gbAnswer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnVerifyAnswer;
        private System.Windows.Forms.GroupBox gbNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordResetForm));
            txtUsername = new System.Windows.Forms.TextBox();
            btnCheckUser = new System.Windows.Forms.Button();
            lblUsername = new System.Windows.Forms.Label();
            gbAnswer = new System.Windows.Forms.GroupBox();
            btnVerifyAnswer = new System.Windows.Forms.Button();
            txtAnswer = new System.Windows.Forms.TextBox();
            lblQuestion = new System.Windows.Forms.Label();
            gbNewPassword = new System.Windows.Forms.GroupBox();
            btnResetPassword = new System.Windows.Forms.Button();
            txtConfirmPassword = new System.Windows.Forms.TextBox();
            lblConfirmPassword = new System.Windows.Forms.Label();
            txtNewPassword = new System.Windows.Forms.TextBox();
            lblNewPassword = new System.Windows.Forms.Label();
            pnlHeader = new System.Windows.Forms.Panel();
            lblTitle = new System.Windows.Forms.Label();
            gbAnswer.SuspendLayout();
            gbNewPassword.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = System.Drawing.Color.FromArgb(245, 236, 215);
            txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtUsername.Location = new System.Drawing.Point(150, 87);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(250, 27);
            txtUsername.TabIndex = 2;
            // 
            // btnCheckUser
            // 
            btnCheckUser.BackColor = System.Drawing.Color.FromArgb(139, 105, 20);
            btnCheckUser.FlatAppearance.BorderSize = 0;
            btnCheckUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCheckUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnCheckUser.ForeColor = System.Drawing.Color.FromArgb(245, 236, 215);
            btnCheckUser.Location = new System.Drawing.Point(410, 86);
            btnCheckUser.Name = "btnCheckUser";
            btnCheckUser.Size = new System.Drawing.Size(100, 30);
            btnCheckUser.TabIndex = 3;
            btnCheckUser.Text = "Проверить";
            btnCheckUser.UseVisualStyleBackColor = false;
            btnCheckUser.Click += btnCheckUser_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblUsername.ForeColor = System.Drawing.Color.FromArgb(107, 66, 38);
            lblUsername.Location = new System.Drawing.Point(40, 90);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(115, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Пользователь:";
            // 
            // gbAnswer
            // 
            gbAnswer.BackColor = System.Drawing.Color.FromArgb(255, 249, 240);
            gbAnswer.Controls.Add(btnVerifyAnswer);
            gbAnswer.Controls.Add(txtAnswer);
            gbAnswer.Controls.Add(lblQuestion);
            gbAnswer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            gbAnswer.ForeColor = System.Drawing.Color.FromArgb(107, 66, 38);
            gbAnswer.Location = new System.Drawing.Point(30, 130);
            gbAnswer.Name = "gbAnswer";
            gbAnswer.Size = new System.Drawing.Size(490, 110);
            gbAnswer.TabIndex = 4;
            gbAnswer.TabStop = false;
            gbAnswer.Text = "Вопрос безопасности";
            // 
            // btnVerifyAnswer
            // 
            btnVerifyAnswer.BackColor = System.Drawing.Color.FromArgb(212, 196, 168);
            btnVerifyAnswer.FlatAppearance.BorderSize = 0;
            btnVerifyAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVerifyAnswer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnVerifyAnswer.ForeColor = System.Drawing.Color.FromArgb(107, 66, 38);
            btnVerifyAnswer.Location = new System.Drawing.Point(380, 54);
            btnVerifyAnswer.Name = "btnVerifyAnswer";
            btnVerifyAnswer.Size = new System.Drawing.Size(90, 27);
            btnVerifyAnswer.TabIndex = 2;
            btnVerifyAnswer.Text = "Подтвердить";
            btnVerifyAnswer.UseVisualStyleBackColor = false;
            btnVerifyAnswer.Click += btnVerifyAnswer_Click;
            // 
            // txtAnswer
            // 
            txtAnswer.BackColor = System.Drawing.Color.FromArgb(245, 236, 215);
            txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtAnswer.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtAnswer.Location = new System.Drawing.Point(20, 55);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new System.Drawing.Size(350, 25);
            txtAnswer.TabIndex = 1;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblQuestion.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            lblQuestion.Location = new System.Drawing.Point(20, 30);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new System.Drawing.Size(58, 19);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "Вопрос:";
            // 
            // gbNewPassword
            // 
            gbNewPassword.BackColor = System.Drawing.Color.FromArgb(255, 249, 240);
            gbNewPassword.Controls.Add(btnResetPassword);
            gbNewPassword.Controls.Add(txtConfirmPassword);
            gbNewPassword.Controls.Add(lblConfirmPassword);
            gbNewPassword.Controls.Add(txtNewPassword);
            gbNewPassword.Controls.Add(lblNewPassword);
            gbNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            gbNewPassword.ForeColor = System.Drawing.Color.FromArgb(107, 66, 38);
            gbNewPassword.Location = new System.Drawing.Point(30, 260);
            gbNewPassword.Name = "gbNewPassword";
            gbNewPassword.Size = new System.Drawing.Size(490, 150);
            gbNewPassword.TabIndex = 5;
            gbNewPassword.TabStop = false;
            gbNewPassword.Text = "Новый пароль";
            // 
            // btnResetPassword
            // 
            btnResetPassword.BackColor = System.Drawing.Color.FromArgb(45, 90, 39);
            btnResetPassword.FlatAppearance.BorderSize = 0;
            btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnResetPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnResetPassword.ForeColor = System.Drawing.Color.FromArgb(245, 236, 215);
            btnResetPassword.Location = new System.Drawing.Point(130, 105);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new System.Drawing.Size(250, 35);
            btnResetPassword.TabIndex = 4;
            btnResetPassword.Text = "Сбросить пароль";
            btnResetPassword.UseVisualStyleBackColor = false;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(245, 236, 215);
            txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtConfirmPassword.Location = new System.Drawing.Point(130, 67);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '●';
            txtConfirmPassword.Size = new System.Drawing.Size(250, 25);
            txtConfirmPassword.TabIndex = 3;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            lblConfirmPassword.Location = new System.Drawing.Point(20, 70);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new System.Drawing.Size(114, 19);
            lblConfirmPassword.TabIndex = 2;
            lblConfirmPassword.Text = "Подтверждение:";
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = System.Drawing.Color.FromArgb(245, 236, 215);
            txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtNewPassword.Location = new System.Drawing.Point(130, 32);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '●';
            txtNewPassword.Size = new System.Drawing.Size(250, 25);
            txtNewPassword.TabIndex = 1;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblNewPassword.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            lblNewPassword.Location = new System.Drawing.Point(20, 35);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new System.Drawing.Size(104, 19);
            lblNewPassword.TabIndex = 0;
            lblNewPassword.Text = "Новый пароль:";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(107, 66, 38);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(550, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(245, 236, 215);
            lblTitle.Location = new System.Drawing.Point(20, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(298, 27);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Восстановление пароля";
            // 
            // PasswordResetForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(212, 196, 168);
            ClientSize = new System.Drawing.Size(550, 440);
            Controls.Add(gbNewPassword);
            Controls.Add(gbAnswer);
            Controls.Add(btnCheckUser);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(pnlHeader);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "PasswordResetForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Восстановление - Винтажный Бутик";
            gbAnswer.ResumeLayout(false);
            gbAnswer.PerformLayout();
            gbNewPassword.ResumeLayout(false);
            gbNewPassword.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}