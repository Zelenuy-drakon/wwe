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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFavorites = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFavCircle = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFavorites)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(107, 66, 38);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.pnlFavCircle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(750, 60);
            this.pnlHeader.TabIndex = 0;

            // 
            // lblTitle (шрифт Monotype Corsiva)
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Italic);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(245, 236, 215);
            this.lblTitle.Location = new System.Drawing.Point(20, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(129, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Избранное";

            // 
            // pnlFavCircle (декоративный элемент)
            // 
            this.pnlFavCircle.BackColor = System.Drawing.Color.Transparent;
            this.pnlFavCircle.Location = new System.Drawing.Point(690, 12);
            this.pnlFavCircle.Name = "pnlFavCircle";
            this.pnlFavCircle.Size = new System.Drawing.Size(35, 35);
            this.pnlFavCircle.TabIndex = 1;
            this.pnlFavCircle.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawFavCircle);

            // 
            // dgvFavorites
            // 
            this.dgvFavorites.AllowUserToAddRows = false;
            this.dgvFavorites.AllowUserToDeleteRows = false;
            this.dgvFavorites.BackgroundColor = System.Drawing.Color.FromArgb(255, 249, 240);
            this.dgvFavorites.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFavorites.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFavorites.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(107, 66, 38);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Unbounded", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(245, 236, 215);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(139, 105, 20);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFavorites.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFavorites.ColumnHeadersHeight = 40;
            this.dgvFavorites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(255, 249, 240);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Unbounded", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(212, 196, 168);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFavorites.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFavorites.EnableHeadersVisualStyles = false;
            this.dgvFavorites.GridColor = System.Drawing.Color.FromArgb(212, 196, 168);
            this.dgvFavorites.Location = new System.Drawing.Point(20, 80);
            this.dgvFavorites.Name = "dgvFavorites";
            this.dgvFavorites.ReadOnly = true;
            this.dgvFavorites.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFavorites.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(255, 249, 240);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Unbounded", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(212, 196, 168);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.dgvFavorites.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFavorites.RowTemplate.Height = 35;
            this.dgvFavorites.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFavorites.Size = new System.Drawing.Size(500, 350);
            this.dgvFavorites.TabIndex = 1;

            // 
            // btnRemove (шрифт Unbounded)
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(139, 58, 58);
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Unbounded", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(245, 236, 215);
            this.btnRemove.Location = new System.Drawing.Point(540, 90);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(180, 40);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "🗑️ Удалить";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);

            // 
            // btnAddToCart (шрифт Unbounded)
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(139, 105, 20);
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Unbounded", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddToCart.ForeColor = System.Drawing.Color.FromArgb(245, 236, 215);
            this.btnAddToCart.Location = new System.Drawing.Point(540, 145);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(180, 40);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "🛒 В корзину";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);

            // 
            // FavoritesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 236, 215);
            this.ClientSize = new System.Drawing.Size(750, 460);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgvFavorites);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Unbounded", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FavoritesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Избранное - Винтажный Бутик";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFavorites)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
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