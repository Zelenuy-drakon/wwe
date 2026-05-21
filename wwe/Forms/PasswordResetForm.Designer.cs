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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnCheckUser = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.gbAnswer = new System.Windows.Forms.GroupBox();
            this.btnVerifyAnswer = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.gbNewPassword = new System.Windows.Forms.GroupBox();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbAnswer.SuspendLayout();
            this.gbNewPassword.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(107, 66, 38);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(550, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(245, 236, 215);
            this.lblTitle.Location = new System.Drawing.Point(20, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Восстановление пароля";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(107, 66, 38);
            this.lblUsername.Location = new System.Drawing.Point(40, 90);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(102, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Пользователь:";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(245, 236, 215);
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsername.Location = new System.Drawing.Point(150, 87);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(250, 27);
            this.txtUsername.TabIndex = 2;
            // 
            // btnCheckUser
            // 
            this.btnCheckUser.BackColor = System.Drawing.Color.FromArgb(139, 105, 20);
            this.btnCheckUser.FlatAppearance.BorderSize = 0;
            this.btnCheckUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCheckUser.ForeColor = System.Drawing.Color.FromArgb(245, 236, 215);
            this.btnCheckUser.Location = new System.Drawing.Point(410, 86);
            this.btnCheckUser.Name = "btnCheckUser";
            this.btnCheckUser.Size = new System.Drawing.Size(100, 30);
            this.btnCheckUser.TabIndex = 3;
            this.btnCheckUser.Text = "Проверить";
            this.btnCheckUser.UseVisualStyleBackColor = false;
            this.btnCheckUser.Click += new System.EventHandler(this.btnCheckUser_Click);
            // 
            // gbAnswer
            // 
            this.gbAnswer.BackColor = System.Drawing.Color.FromArgb(255, 249, 240);
            this.gbAnswer.Controls.Add(this.btnVerifyAnswer);
            this.gbAnswer.Controls.Add(this.txtAnswer);
            this.gbAnswer.Controls.Add(this.lblQuestion);
            this.gbAnswer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbAnswer.ForeColor = System.Drawing.Color.FromArgb(107, 66, 38);
            this.gbAnswer.Location = new System.Drawing.Point(30, 130);
            this.gbAnswer.Name = "gbAnswer";
            this.gbAnswer.Size = new System.Drawing.Size(490, 110);
            this.gbAnswer.TabIndex = 4;
            this.gbAnswer.TabStop = false;
            this.gbAnswer.Text = "Вопрос безопасности";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblQuestion.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblQuestion.Location = new System.Drawing.Point(20, 30);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(62, 19);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Вопрос:";
            // 
            // txtAnswer
            // 
            this.txtAnswer.BackColor = System.Drawing.Color.FromArgb(245, 236, 215);
            this.txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnswer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAnswer.Location = new System.Drawing.Point(20, 55);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(350, 25);
            this.txtAnswer.TabIndex = 1;
            // 
            // btnVerifyAnswer
            // 
            this.btnVerifyAnswer.BackColor = System.Drawing.Color.FromArgb(212, 196, 168);
            this.btnVerifyAnswer.FlatAppearance.BorderSize = 0;
            this.btnVerifyAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyAnswer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnVerifyAnswer.ForeColor = System.Drawing.Color.FromArgb(107, 66, 38);
            this.btnVerifyAnswer.Location = new System.Drawing.Point(380, 54);
            this.btnVerifyAnswer.Name = "btnVerifyAnswer";
            this.btnVerifyAnswer.Size = new System.Drawing.Size(90, 27);
            this.btnVerifyAnswer.TabIndex = 2;
            this.btnVerifyAnswer.Text = "Подтвердить";
            this.btnVerifyAnswer.UseVisualStyleBackColor = false;
            this.btnVerifyAnswer.Click += new System.EventHandler(this.btnVerifyAnswer_Click);
            // 
            // gbNewPassword
            // 
            this.gbNewPassword.BackColor = System.Drawing.Color.FromArgb(255, 249, 240);
            this.gbNewPassword.Controls.Add(this.btnResetPassword);
            this.gbNewPassword.Controls.Add(this.txtConfirmPassword);
            this.gbNewPassword.Controls.Add(this.lblConfirmPassword);
            this.gbNewPassword.Controls.Add(this.txtNewPassword);
            this.gbNewPassword.Controls.Add(this.lblNewPassword);
            this.gbNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbNewPassword.ForeColor = System.Drawing.Color.FromArgb(107, 66, 38);
            this.gbNewPassword.Location = new System.Drawing.Point(30, 260);
            this.gbNewPassword.Name = "gbNewPassword";
            this.gbNewPassword.Size = new System.Drawing.Size(490, 150);
            this.gbNewPassword.TabIndex = 5;
            this.gbNewPassword.TabStop = false;
            this.gbNewPassword.Text = "Новый пароль";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNewPassword.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblNewPassword.Location = new System.Drawing.Point(20, 35);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(99, 19);
            this.lblNewPassword.TabIndex = 0;
            this.lblNewPassword.Text = "Новый пароль:";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.FromArgb(245, 236, 215);
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNewPassword.Location = new System.Drawing.Point(130, 32);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '●';
            this.txtNewPassword.Size = new System.Drawing.Size(250, 25);
            this.txtNewPassword.TabIndex = 1;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblConfirmPassword.Location = new System.Drawing.Point(20, 70);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(103, 19);
            this.lblConfirmPassword.TabIndex = 2;
            this.lblConfirmPassword.Text = "Подтверждение:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(245, 236, 215);
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(130, 67);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.Size = new System.Drawing.Size(250, 25);
            this.txtConfirmPassword.TabIndex = 3;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.Color.FromArgb(45, 90, 39);
            this.btnResetPassword.FlatAppearance.BorderSize = 0;
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnResetPassword.ForeColor = System.Drawing.Color.FromArgb(245, 236, 215);
            this.btnResetPassword.Location = new System.Drawing.Point(130, 105);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(250, 35);
            this.btnResetPassword.TabIndex = 4;
            this.btnResetPassword.Text = "Сбросить пароль";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // PasswordResetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(212, 196, 168);
            this.ClientSize = new System.Drawing.Size(550, 440);
            this.Controls.Add(this.gbNewPassword);
            this.Controls.Add(this.gbAnswer);
            this.Controls.Add(this.btnCheckUser);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PasswordResetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Восстановление - Винтажный Бутик";
            this.gbAnswer.ResumeLayout(false);
            this.gbAnswer.PerformLayout();
            this.gbNewPassword.ResumeLayout(false);
            this.gbNewPassword.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}