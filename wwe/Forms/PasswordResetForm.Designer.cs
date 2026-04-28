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
            this.gbAnswer.SuspendLayout();
            this.gbNewPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(30, 25);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Имя пользователя:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(130, 22);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // btnCheckUser
            // 
            this.btnCheckUser.Location = new System.Drawing.Point(340, 20);
            this.btnCheckUser.Name = "btnCheckUser";
            this.btnCheckUser.Size = new System.Drawing.Size(100, 23);
            this.btnCheckUser.TabIndex = 2;
            this.btnCheckUser.Text = "Проверить";
            this.btnCheckUser.UseVisualStyleBackColor = true;
            this.btnCheckUser.Click += new System.EventHandler(this.btnCheckUser_Click);
            // 
            // gbAnswer
            // 
            this.gbAnswer.Controls.Add(this.btnVerifyAnswer);
            this.gbAnswer.Controls.Add(this.txtAnswer);
            this.gbAnswer.Controls.Add(this.lblQuestion);
            this.gbAnswer.Location = new System.Drawing.Point(20, 60);
            this.gbAnswer.Name = "gbAnswer";
            this.gbAnswer.Size = new System.Drawing.Size(430, 100);
            this.gbAnswer.TabIndex = 3;
            this.gbAnswer.TabStop = false;
            this.gbAnswer.Text = "Вопрос безопасности";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(15, 25);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(50, 13);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Вопрос:";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(18, 45);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(300, 20);
            this.txtAnswer.TabIndex = 1;
            // 
            // btnVerifyAnswer
            // 
            this.btnVerifyAnswer.Location = new System.Drawing.Point(325, 43);
            this.btnVerifyAnswer.Name = "btnVerifyAnswer";
            this.btnVerifyAnswer.Size = new System.Drawing.Size(90, 23);
            this.btnVerifyAnswer.TabIndex = 2;
            this.btnVerifyAnswer.Text = "Подтвердить";
            this.btnVerifyAnswer.UseVisualStyleBackColor = true;
            this.btnVerifyAnswer.Click += new System.EventHandler(this.btnVerifyAnswer_Click);
            // 
            // gbNewPassword
            // 
            this.gbNewPassword.Controls.Add(this.btnResetPassword);
            this.gbNewPassword.Controls.Add(this.txtConfirmPassword);
            this.gbNewPassword.Controls.Add(this.lblConfirmPassword);
            this.gbNewPassword.Controls.Add(this.txtNewPassword);
            this.gbNewPassword.Controls.Add(this.lblNewPassword);
            this.gbNewPassword.Location = new System.Drawing.Point(20, 170);
            this.gbNewPassword.Name = "gbNewPassword";
            this.gbNewPassword.Size = new System.Drawing.Size(430, 130);
            this.gbNewPassword.TabIndex = 4;
            this.gbNewPassword.TabStop = false;
            this.gbNewPassword.Text = "Новый пароль";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(15, 30);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(76, 13);
            this.lblNewPassword.TabIndex = 0;
            this.lblNewPassword.Text = "Новый пароль:";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(110, 27);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(200, 20);
            this.txtNewPassword.TabIndex = 1;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(15, 60);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(88, 13);
            this.lblConfirmPassword.TabIndex = 2;
            this.lblConfirmPassword.Text = "Подтверждение:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(110, 57);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(200, 20);
            this.txtConfirmPassword.TabIndex = 3;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.Color.DarkOrange;
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Location = new System.Drawing.Point(110, 90);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(200, 30);
            this.btnResetPassword.TabIndex = 4;
            this.btnResetPassword.Text = "Сбросить пароль";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // PasswordResetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 321);
            this.Controls.Add(this.gbNewPassword);
            this.Controls.Add(this.gbAnswer);
            this.Controls.Add(this.btnCheckUser);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PasswordResetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Восстановление пароля";
            this.gbAnswer.ResumeLayout(false);
            this.gbAnswer.PerformLayout();
            this.gbNewPassword.ResumeLayout(false);
            this.gbNewPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}