using System.Drawing;
using System.Windows.Forms;

namespace OnlineStoreApp
{
    partial class FavoritesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvFavorites;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFavCircle;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavoritesForm));
            dgvFavorites = new DataGridView();
            btnRemove = new Button();
            btnAddToCart = new Button();
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlFavCircle = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvFavorites).BeginInit();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // dgvFavorites
            // 
            dgvFavorites.AllowUserToAddRows = false;
            dgvFavorites.AllowUserToDeleteRows = false;
            dgvFavorites.BackgroundColor = Color.FromArgb(255, 249, 240);
            dgvFavorites.BorderStyle = BorderStyle.None;
            dgvFavorites.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvFavorites.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(107, 66, 38);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(245, 236, 215);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(139, 105, 20);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvFavorites.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFavorites.ColumnHeadersHeight = 40;
            dgvFavorites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 249, 240);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(212, 196, 168);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvFavorites.DefaultCellStyle = dataGridViewCellStyle2;
            dgvFavorites.EnableHeadersVisualStyles = false;
            dgvFavorites.GridColor = Color.FromArgb(212, 196, 168);
            dgvFavorites.Location = new Point(20, 80);
            dgvFavorites.Name = "dgvFavorites";
            dgvFavorites.ReadOnly = true;
            dgvFavorites.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvFavorites.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 249, 240);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(212, 196, 168);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(51, 51, 51);
            dgvFavorites.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvFavorites.RowTemplate.Height = 35;
            dgvFavorites.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFavorites.Size = new Size(500, 350);
            dgvFavorites.TabIndex = 1;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(139, 58, 58);
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnRemove.ForeColor = Color.FromArgb(245, 236, 215);
            btnRemove.Location = new Point(540, 90);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(180, 40);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "🗑️ Удалить";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = Color.FromArgb(139, 105, 20);
            btnAddToCart.FlatAppearance.BorderSize = 0;
            btnAddToCart.FlatStyle = FlatStyle.Flat;
            btnAddToCart.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnAddToCart.ForeColor = Color.FromArgb(245, 236, 215);
            btnAddToCart.Location = new Point(540, 145);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(180, 40);
            btnAddToCart.TabIndex = 3;
            btnAddToCart.Text = "\U0001f6d2 В корзину";
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(107, 66, 38);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(pnlFavCircle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(750, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Monotype Corsiva", 20F, FontStyle.Italic);
            lblTitle.ForeColor = Color.FromArgb(245, 236, 215);
            lblTitle.Location = new Point(20, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(121, 33);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Избранное";
            // 
            // pnlFavCircle
            // 
            pnlFavCircle.BackColor = Color.Transparent;
            pnlFavCircle.Location = new Point(690, 12);
            pnlFavCircle.Name = "pnlFavCircle";
            pnlFavCircle.Size = new Size(35, 35);
            pnlFavCircle.TabIndex = 1;
            pnlFavCircle.Paint += DrawFavCircle;
            // 
            // FavoritesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 236, 215);
            ClientSize = new Size(750, 460);
            Controls.Add(btnAddToCart);
            Controls.Add(btnRemove);
            Controls.Add(dgvFavorites);
            Controls.Add(pnlHeader);
            Font = new Font("Microsoft Sans Serif", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FavoritesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Избранное - Винтажный Бутик";
            ((System.ComponentModel.ISupportInitialize)dgvFavorites).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        private void DrawFavCircle(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.FromArgb(218, 165, 32), 1.5f))
            {
                e.Graphics.DrawEllipse(pen, 0, 0, 33, 33);
            }
            using (Pen pen2 = new Pen(Color.FromArgb(245, 236, 215), 1))
            {
                e.Graphics.DrawEllipse(pen2, 5, 5, 23, 23);
            }
        }
    }
}