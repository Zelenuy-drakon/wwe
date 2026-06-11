using System.Drawing;
using System.Windows.Forms;

namespace OnlineStoreApp
{
    partial class CartForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnUpdateQuantity;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lblTotalAmount;
        // Декоративные элементы (уменьшенные)
        private System.Windows.Forms.Panel pnlCartCircle;
        private System.Windows.Forms.Panel pnlCartDiamond;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartForm));
            dgvCart = new DataGridView();
            btnRemove = new Button();
            btnCheckout = new Button();
            lblTotal = new Label();
            btnUpdateQuantity = new Button();
            nudQuantity = new NumericUpDown();
            lblQuantity = new Label();
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlCartCircle = new Panel();
            pnlTotal = new Panel();
            lblTotalAmount = new Label();
            pnlCartDiamond = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            pnlHeader.SuspendLayout();
            pnlTotal.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AllowUserToDeleteRows = false;
            dgvCart.BackgroundColor = Color.FromArgb(255, 249, 240);
            dgvCart.BorderStyle = BorderStyle.None;
            dgvCart.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCart.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(107, 66, 38);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(245, 236, 215);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(139, 105, 20);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCart.ColumnHeadersHeight = 40;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 249, 240);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(212, 196, 168);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCart.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCart.EnableHeadersVisualStyles = false;
            dgvCart.GridColor = Color.FromArgb(212, 196, 168);
            dgvCart.Location = new Point(20, 80);
            dgvCart.MultiSelect = false;
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCart.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 249, 240);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(212, 196, 168);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(51, 51, 51);
            dgvCart.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvCart.RowTemplate.Height = 35;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.Size = new Size(580, 350);
            dgvCart.TabIndex = 1;
            dgvCart.SelectionChanged += dgvCart_SelectionChanged;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(139, 58, 58);
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold);
            btnRemove.ForeColor = Color.FromArgb(245, 236, 215);
            btnRemove.Location = new Point(620, 200);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(100, 35);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "Удалить";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.FromArgb(45, 90, 39);
            btnCheckout.FlatAppearance.BorderSize = 0;
            btnCheckout.FlatStyle = FlatStyle.Flat;
            btnCheckout.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnCheckout.ForeColor = Color.FromArgb(245, 236, 215);
            btnCheckout.Location = new Point(620, 360);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(200, 50);
            btnCheckout.TabIndex = 7;
            btnCheckout.Text = "Оформить заказ";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(107, 66, 38);
            lblTotal.Location = new Point(15, 28);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(64, 20);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Итого:";
            // 
            // btnUpdateQuantity
            // 
            btnUpdateQuantity.BackColor = Color.FromArgb(212, 196, 168);
            btnUpdateQuantity.FlatAppearance.BorderSize = 0;
            btnUpdateQuantity.FlatStyle = FlatStyle.Flat;
            btnUpdateQuantity.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold);
            btnUpdateQuantity.ForeColor = Color.FromArgb(107, 66, 38);
            btnUpdateQuantity.Location = new Point(620, 150);
            btnUpdateQuantity.Name = "btnUpdateQuantity";
            btnUpdateQuantity.Size = new Size(100, 35);
            btnUpdateQuantity.TabIndex = 4;
            btnUpdateQuantity.Text = "Обновить";
            btnUpdateQuantity.UseVisualStyleBackColor = false;
            btnUpdateQuantity.Click += btnUpdateQuantity_Click;
            // 
            // nudQuantity
            // 
            nudQuantity.BackColor = Color.FromArgb(245, 236, 215);
            nudQuantity.BorderStyle = BorderStyle.FixedSingle;
            nudQuantity.Font = new Font("Microsoft Sans Serif", 9F);
            nudQuantity.Location = new Point(620, 115);
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(100, 21);
            nudQuantity.TabIndex = 3;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblQuantity.ForeColor = Color.FromArgb(107, 66, 38);
            lblQuantity.Location = new Point(620, 90);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(90, 15);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Количество:";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(107, 66, 38);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(pnlCartCircle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(850, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Monotype Corsiva", 20F, FontStyle.Italic);
            lblTitle.ForeColor = Color.FromArgb(245, 236, 215);
            lblTitle.Location = new Point(20, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(101, 33);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Корзина";
            // 
            // pnlCartCircle
            // 
            pnlCartCircle.BackColor = Color.Transparent;
            pnlCartCircle.Location = new Point(790, 12);
            pnlCartCircle.Name = "pnlCartCircle";
            pnlCartCircle.Size = new Size(35, 35);
            pnlCartCircle.TabIndex = 1;
            pnlCartCircle.Paint += DrawCartCircle;
            // 
            // pnlTotal
            // 
            pnlTotal.BackColor = Color.FromArgb(212, 196, 168);
            pnlTotal.Controls.Add(lblTotalAmount);
            pnlTotal.Controls.Add(lblTotal);
            pnlTotal.Location = new Point(620, 260);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Size = new Size(200, 80);
            pnlTotal.TabIndex = 6;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblTotalAmount.ForeColor = Color.FromArgb(46, 125, 50);
            lblTotalAmount.Location = new Point(85, 28);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(39, 24);
            lblTotalAmount.TabIndex = 1;
            lblTotalAmount.Text = "0 ₽";
            // 
            // pnlCartDiamond
            // 
            pnlCartDiamond.BackColor = Color.Transparent;
            pnlCartDiamond.Location = new Point(30, 440);
            pnlCartDiamond.Name = "pnlCartDiamond";
            pnlCartDiamond.Size = new Size(20, 20);
            pnlCartDiamond.TabIndex = 8;
            pnlCartDiamond.Paint += DrawCartDiamond;
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 236, 215);
            ClientSize = new Size(850, 480);
            Controls.Add(pnlCartDiamond);
            Controls.Add(btnCheckout);
            Controls.Add(pnlTotal);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdateQuantity);
            Controls.Add(nudQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(dgvCart);
            Controls.Add(pnlHeader);
            Font = new Font("Microsoft Sans Serif", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Корзина - Винтажный Бутик";
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlTotal.ResumeLayout(false);
            pnlTotal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void DrawCartCircle(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.FromArgb(218, 165, 32), 1.5f))
            {
                e.Graphics.DrawEllipse(pen, 0, 0, 33, 33);
            }
        }

        private void DrawCartDiamond(object sender, PaintEventArgs e)
        {
            Point[] points = new Point[]
            {
                new Point(10, 0),
                new Point(19, 10),
                new Point(10, 19),
                new Point(0, 10)
            };
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(139, 105, 20)))
            {
                e.Graphics.FillPolygon(brush, points);
            }
        }
    }
}