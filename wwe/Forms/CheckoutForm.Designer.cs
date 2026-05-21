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
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.pnlCheckoutCircle = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(107, 66, 38);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.pnlCheckoutCircle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(550, 60);
            this.pnlHeader.TabIndex = 0;

            // 
            // lblTitle (шрифт Monotype Corsiva)
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(245, 236, 215);
            this.lblTitle.Location = new System.Drawing.Point(20, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(199, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Оформление заказа";

            // 
            // pnlCheckoutCircle (декоративный элемент, уменьшен)
            // 
            this.pnlCheckoutCircle.BackColor = System.Drawing.Color.Transparent;
            this.pnlCheckoutCircle.Location = new System.Drawing.Point(500, 12);
            this.pnlCheckoutCircle.Name = "pnlCheckoutCircle";
            this.pnlCheckoutCircle.Size = new System.Drawing.Size(30, 30);
            this.pnlCheckoutCircle.TabIndex = 1;
            this.pnlCheckoutCircle.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCheckoutCircle);

            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(255, 249, 240);
            this.pnlContent.Controls.Add(this.lblAddress);
            this.pnlContent.Controls.Add(this.txtAddress);
            this.pnlContent.Controls.Add(this.lblPhone);
            this.pnlContent.Controls.Add(this.txtPhone);
            this.pnlContent.Controls.Add(this.pnlTotal);
            this.pnlContent.Controls.Add(this.btnConfirmOrder);
            this.pnlContent.Location = new System.Drawing.Point(20, 80);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(510, 370);
            this.pnlContent.TabIndex = 1;

            // 
            // lblAddress (шрифт Unbounded)
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Unbounded", 10F, System.Drawing.FontStyle.Bold);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(107, 66, 38);
            this.lblAddress.Location = new System.Drawing.Point(30, 25);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(120, 18);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Адрес доставки:";

            // 
            // txtAddress (шрифт Unbounded)
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(245, 236, 215);
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Unbounded", 9F);
            this.txtAddress.Location = new System.Drawing.Point(30, 48);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(450, 55);
            this.txtAddress.TabIndex = 1;

            // 
            // lblPhone (шрифт Unbounded)
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Unbounded", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(107, 66, 38);
            this.lblPhone.Location = new System.Drawing.Point(30, 118);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(129, 18);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Номер телефона:";

            // 
            // txtPhone (шрифт Unbounded)
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(245, 236, 215);
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Unbounded", 9F);
            this.txtPhone.Location = new System.Drawing.Point(30, 140);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(300, 26);
            this.txtPhone.TabIndex = 3;

            // 
            // pnlTotal
            // 
            this.pnlTotal.BackColor = System.Drawing.Color.FromArgb(212, 196, 168);
            this.pnlTotal.Controls.Add(this.lblTotal);
            this.pnlTotal.Controls.Add(this.lblTotalAmount);
            this.pnlTotal.Location = new System.Drawing.Point(30, 190);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(450, 60);
            this.pnlTotal.TabIndex = 4;

            // 
            // lblTotal (шрифт Unbounded)
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Unbounded", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(107, 66, 38);
            this.lblTotal.Location = new System.Drawing.Point(20, 18);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(63, 22);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Итого:";

            // 
            // lblTotalAmount (ЗЕЛЕНЫЙ ЦВЕТ, шрифт Unbounded)
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Unbounded", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.lblTotalAmount.Location = new System.Drawing.Point(95, 16);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(51, 26);
            this.lblTotalAmount.TabIndex = 1;
            this.lblTotalAmount.Text = "0 ₽";

            // 
            // btnConfirmOrder (шрифт Unbounded)
            // 
            this.btnConfirmOrder.BackColor = System.Drawing.Color.FromArgb(45, 90, 39);
            this.btnConfirmOrder.FlatAppearance.BorderSize = 0;
            this.btnConfirmOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmOrder.Font = new System.Drawing.Font("Unbounded", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirmOrder.ForeColor = System.Drawing.Color.FromArgb(245, 236, 215);
            this.btnConfirmOrder.Location = new System.Drawing.Point(120, 275);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(270, 50);
            this.btnConfirmOrder.TabIndex = 5;
            this.btnConfirmOrder.Text = "Подтвердить заказ";
            this.btnConfirmOrder.UseVisualStyleBackColor = false;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);

            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(212, 196, 168);
            this.ClientSize = new System.Drawing.Size(550, 480);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Unbounded", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CheckoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформление - Винтажный Бутик";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.ResumeLayout(false);
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