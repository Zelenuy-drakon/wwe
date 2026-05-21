using System.Drawing;
using System.Windows.Forms;

namespace OnlineStoreApp
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnForgot;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlDivider;
        // Декоративные фигуры (уменьшенные и смещенные)
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnForgot = new Button();
            lblUsername = new Label();
            lblPassword = new Label();
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
            txtUsername.Font = new Font("Microsoft Sans Serif", 9F);
            txtUsername.Location = new Point(50, 142);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 21);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(245, 236, 215);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Microsoft Sans Serif", 9F);
            txtPassword.Location = new Point(50, 207);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(300, 21);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(139, 105, 20);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnLogin.ForeColor = Color.FromArgb(245, 236, 215);
            btnLogin.Location = new Point(100, 260);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 40);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnForgot
            // 
            btnForgot.BackColor = Color.Transparent;
            btnForgot.FlatAppearance.BorderSize = 0;
            btnForgot.FlatStyle = FlatStyle.Flat;
            btnForgot.Font = new Font("Microsoft Sans Serif", 8F);
            btnForgot.ForeColor = Color.FromArgb(139, 105, 20);
            btnForgot.Location = new Point(120, 310);
            btnForgot.Name = "btnForgot";
            btnForgot.Size = new Size(160, 25);
            btnForgot.TabIndex = 6;
            btnForgot.Text = "Забыли пароль?";
            btnForgot.UseVisualStyleBackColor = false;
            btnForgot.Click += btnForgot_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(107, 66, 38);
            lblUsername.Location = new Point(50, 120);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(50, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Логин:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(107, 66, 38);
            lblPassword.Location = new Point(50, 185);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(61, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Пароль:";
            // 
            // pnlForm
            // 
            pnlForm.BackColor = Color.FromArgb(255, 249, 240);
            pnlForm.Controls.Add(lblTitle);
            pnlForm.Controls.Add(lblUsername);
            pnlForm.Controls.Add(txtUsername);
            pnlForm.Controls.Add(lblPassword);
            pnlForm.Controls.Add(txtPassword);
            pnlForm.Controls.Add(btnLogin);
            pnlForm.Controls.Add(btnForgot);
            pnlForm.Controls.Add(pnlDivider);
            pnlForm.Location = new Point(100, 60);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(400, 480);
            pnlForm.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Italic);
            lblTitle.ForeColor = Color.FromArgb(107, 66, 38);
            lblTitle.Location = new Point(0, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Винтажный Бутик";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlDivider
            // 
            pnlDivider.BackColor = Color.FromArgb(212, 196, 168);
            pnlDivider.Location = new Point(50, 95);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(300, 2);
            pnlDivider.TabIndex = 8;
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
            pnlDiamond1.Location = new Point(30, 520);
            pnlDiamond1.Name = "pnlDiamond1";
            pnlDiamond1.Size = new Size(25, 25);
            pnlDiamond1.TabIndex = 14;
            pnlDiamond1.Paint += DrawDiamond;
            // 
            // pnlLeaf1
            // 
            pnlLeaf1.BackColor = Color.Transparent;
            pnlLeaf1.Location = new Point(595, 530);
            pnlLeaf1.Name = "pnlLeaf1";
            pnlLeaf1.Size = new Size(25, 20);
            pnlLeaf1.TabIndex = 20;
            pnlLeaf1.Paint += DrawLeaf;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(212, 196, 168);
            ClientSize = new Size(650, 570);
            Controls.Add(pnlLeaf1);
            Controls.Add(pnlDiamond1);
            Controls.Add(pnlCircle2);
            Controls.Add(pnlCircle1);
            Controls.Add(pnlForm);
            Font = new Font("Microsoft Sans Serif", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ResumeLayout(false);
        }

        // Методы для рисования фигур
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