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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnUpdateQuantity = new System.Windows.Forms.Button();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            // Декоративные элементы
            this.pnlCartCircle = new System.Windows.Forms.Panel();
            this.pnlCartDiamond = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(107, 66, 38);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.pnlCartCircle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(850, 60);
            this.pnlHeader.TabIndex = 0;

            // 
            // lblTitle (шрифт Monotype Corsiva)
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Italic);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(245, 236, 215);
            this.lblTitle.Location = new System.Drawing.Point(20, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(101, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Корзина";

            // 
            // pnlCartCircle (уменьшен)
            // 
            this.pnlCartCircle.BackColor = System.Drawing.Color.Transparent;
            this.pnlCartCircle.Location = new System.Drawing.Point(790, 12);
            this.pnlCartCircle.Name = "pnlCartCircle";
            this.pnlCartCircle.Size = new System.Drawing.Size(35, 35);
            this.pnlCartCircle.TabIndex = 1;
            this.pnlCartCircle.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCartCircle);

            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.BackgroundColor = System.Drawing.Color.FromArgb(255, 249, 240);
            this.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(107, 66, 38);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Unbounded", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(245, 236, 215);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(139, 105, 20);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCart.ColumnHeadersHeight = 40;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Настройка стиля для ячеек (цена будет зеленой через событие CellFormatting)
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(255, 249, 240);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Unbounded", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(212, 196, 168);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCart.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCart.EnableHeadersVisualStyles = false;
            this.dgvCart.GridColor = System.Drawing.Color.FromArgb(212, 196, 168);
            this.dgvCart.Location = new System.Drawing.Point(20, 80);
            this.dgvCart.MultiSelect = false;
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCart.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(255, 249, 240);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Unbounded", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(212, 196, 168);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.dgvCart.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCart.RowTemplate.Height = 35;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(580, 350);
            this.dgvCart.TabIndex = 1;
            this.dgvCart.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCart_CellFormatting);
            this.dgvCart.SelectionChanged += new System.EventHandler(this.dgvCart_SelectionChanged);

            // 
            // lblQuantity (шрифт Unbounded)
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Unbounded", 9F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(107, 66, 38);
            this.lblQuantity.Location = new System.Drawing.Point(620, 90);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(82, 18);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Количество:";

            // 
            // nudQuantity (шрифт Unbounded)
            // 
            this.nudQuantity.BackColor = System.Drawing.Color.FromArgb(245, 236, 215);
            this.nudQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudQuantity.Font = new System.Drawing.Font("Unbounded", 9F);
            this.nudQuantity.Location = new System.Drawing.Point(620, 115);
            this.nudQuantity.Minimum = 1;
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(100, 26);
            this.nudQuantity.TabIndex = 3;
            this.nudQuantity.Value = 1;

            // 
            // btnUpdateQuantity (шрифт Unbounded)
            // 
            this.btnUpdateQuantity.BackColor = System.Drawing.Color.FromArgb(212, 196, 168);
            this.btnUpdateQuantity.FlatAppearance.BorderSize = 0;
            this.btnUpdateQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateQuantity.Font = new System.Drawing.Font("Unbounded", 8F, System.Drawing.FontStyle.Bold);
            this.btnUpdateQuantity.ForeColor = System.Drawing.Color.FromArgb(107, 66, 38);
            this.btnUpdateQuantity.Location = new System.Drawing.Point(620, 150);
            this.btnUpdateQuantity.Name = "btnUpdateQuantity";
            this.btnUpdateQuantity.Size = new System.Drawing.Size(100, 35);
            this.btnUpdateQuantity.TabIndex = 4;
            this.btnUpdateQuantity.Text = "Обновить";
            this.btnUpdateQuantity.UseVisualStyleBackColor = false;
            this.btnUpdateQuantity.Click += new System.EventHandler(this.btnUpdateQuantity_Click);

            // 
            // btnRemove (шрифт Unbounded)
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(139, 58, 58);
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Unbounded", 8F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(245, 236, 215);
            this.btnRemove.Location = new System.Drawing.Point(620, 200);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 35);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);

            // 
            // pnlTotal
            // 
            this.pnlTotal.BackColor = System.Drawing.Color.FromArgb(212, 196, 168);
            this.pnlTotal.Controls.Add(this.lblTotalAmount);
            this.pnlTotal.Controls.Add(this.lblTotal);
            this.pnlTotal.Location = new System.Drawing.Point(620, 260);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(200, 80);
            this.pnlTotal.TabIndex = 6;

            // 
            // lblTotal (шрифт Unbounded)
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Unbounded", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(107, 66, 38);
            this.lblTotal.Location = new System.Drawing.Point(15, 28);
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
            this.lblTotalAmount.Location = new System.Drawing.Point(85, 26);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(51, 26);
            this.lblTotalAmount.TabIndex = 1;
            this.lblTotalAmount.Text = "0 ₽";

            // 
            // btnCheckout (шрифт Unbounded)
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(45, 90, 39);
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Unbounded", 10F, System.Drawing.FontStyle.Bold);
            this.btnCheckout.ForeColor = System.Drawing.Color.FromArgb(245, 236, 215);
            this.btnCheckout.Location = new System.Drawing.Point(620, 360);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(200, 50);
            this.btnCheckout.TabIndex = 7;
            this.btnCheckout.Text = "Оформить заказ";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);

            // 
            // pnlCartDiamond (уменьшен, внизу)
            // 
            this.pnlCartDiamond.BackColor = System.Drawing.Color.Transparent;
            this.pnlCartDiamond.Location = new System.Drawing.Point(30, 440);
            this.pnlCartDiamond.Name = "pnlCartDiamond";
            this.pnlCartDiamond.Size = new System.Drawing.Size(20, 20);
            this.pnlCartDiamond.TabIndex = 8;
            this.pnlCartDiamond.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCartDiamond);

            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 236, 215);
            this.ClientSize = new System.Drawing.Size(850, 480);
            this.Controls.Add(this.pnlCartDiamond);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.pnlTotal);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdateQuantity);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Unbounded", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Корзина - Винтажный Бутик";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
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