using System.Drawing;
using System.Windows.Forms;

namespace OnlineStoreApp
{
    partial class CheckoutForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Panel pnlCheckoutCircle;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutForm));
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            btnConfirmOrder = new Button();
            lblAddress = new Label();
            lblPhone = new Label();
            lblTotal = new Label();
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlCheckoutCircle = new Panel();
            pnlContent = new Panel();
            pnlTotal = new Panel();
            lblTotalAmount = new Label();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlTotal.SuspendLayout();
            SuspendLayout();
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.FromArgb(245, 236, 215);
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Microsoft Sans Serif", 9F);
            txtAddress.Location = new Point(30, 48);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(450, 55);
            txtAddress.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(245, 236, 215);
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Microsoft Sans Serif", 9F);
            txtPhone.Location = new Point(30, 140);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(300, 21);
            txtPhone.TabIndex = 3;
            // 
            // btnConfirmOrder
            // 
            btnConfirmOrder.BackColor = Color.FromArgb(45, 90, 39);
            btnConfirmOrder.FlatAppearance.BorderSize = 0;
            btnConfirmOrder.FlatStyle = FlatStyle.Flat;
            btnConfirmOrder.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnConfirmOrder.ForeColor = Color.FromArgb(245, 236, 215);
            btnConfirmOrder.Location = new Point(120, 275);
            btnConfirmOrder.Name = "btnConfirmOrder";
            btnConfirmOrder.Size = new Size(270, 50);
            btnConfirmOrder.TabIndex = 5;
            btnConfirmOrder.Text = "Подтвердить заказ";
            btnConfirmOrder.UseVisualStyleBackColor = false;
            btnConfirmOrder.Click += btnConfirmOrder_Click;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblAddress.ForeColor = Color.FromArgb(107, 66, 38);
            lblAddress.Location = new Point(30, 25);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(131, 17);
            lblAddress.TabIndex = 0;
            lblAddress.Text = "Адрес доставки:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblPhone.ForeColor = Color.FromArgb(107, 66, 38);
            lblPhone.Location = new Point(30, 118);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(140, 17);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Номер телефона:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(107, 66, 38);
            lblTotal.Location = new Point(20, 18);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(64, 20);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Итого:";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(107, 66, 38);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(pnlCheckoutCircle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(550, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Monotype Corsiva", 18F, FontStyle.Italic);
            lblTitle.ForeColor = Color.FromArgb(245, 236, 215);
            lblTitle.Location = new Point(20, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(188, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Оформление заказа";
            // 
            // pnlCheckoutCircle
            // 
            pnlCheckoutCircle.BackColor = Color.Transparent;
            pnlCheckoutCircle.Location = new Point(500, 12);
            pnlCheckoutCircle.Name = "pnlCheckoutCircle";
            pnlCheckoutCircle.Size = new Size(30, 30);
            pnlCheckoutCircle.TabIndex = 1;
            pnlCheckoutCircle.Paint += DrawCheckoutCircle;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(255, 249, 240);
            pnlContent.Controls.Add(lblAddress);
            pnlContent.Controls.Add(txtAddress);
            pnlContent.Controls.Add(lblPhone);
            pnlContent.Controls.Add(txtPhone);
            pnlContent.Controls.Add(pnlTotal);
            pnlContent.Controls.Add(btnConfirmOrder);
            pnlContent.Location = new Point(20, 80);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(510, 370);
            pnlContent.TabIndex = 1;
            // 
            // pnlTotal
            // 
            pnlTotal.BackColor = Color.FromArgb(212, 196, 168);
            pnlTotal.Controls.Add(lblTotal);
            pnlTotal.Controls.Add(lblTotalAmount);
            pnlTotal.Location = new Point(30, 190);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Size = new Size(450, 60);
            pnlTotal.TabIndex = 4;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblTotalAmount.ForeColor = Color.FromArgb(46, 125, 50);
            lblTotalAmount.Location = new Point(95, 16);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(39, 24);
            lblTotalAmount.TabIndex = 1;
            lblTotalAmount.Text = "0 ₽";
            // 
            // CheckoutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(212, 196, 168);
            ClientSize = new Size(550, 480);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Font = new Font("Microsoft Sans Serif", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CheckoutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Оформление - Винтажный Бутик";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            pnlTotal.ResumeLayout(false);
            pnlTotal.PerformLayout();
            ResumeLayout(false);
        }

        private void DrawCheckoutCircle(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.FromArgb(218, 165, 32), 1.5f))
            {
                e.Graphics.DrawEllipse(pen, 0, 0, 28, 28);
            }
        }
    }
}