using System.Drawing;
using System.Windows.Forms;

namespace OnlineStoreApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnAddToFavorites;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnFavorites;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblTitle;
        // Декоративные элементы (уменьшенные)
        private System.Windows.Forms.Panel pnlCornerCircle;
        private System.Windows.Forms.Panel pnlTopCircle;
        private System.Windows.Forms.Panel pnlSideDiamond;
        private System.Windows.Forms.Panel pnlAccentLine;

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
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnAddToFavorites = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnFavorites = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            // Декоративные элементы
            this.pnlCornerCircle = new System.Windows.Forms.Panel();
            this.pnlTopCircle = new System.Windows.Forms.Panel();
            this.pnlSideDiamond = new System.Windows.Forms.Panel();
            this.pnlAccentLine = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();

            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(107, 66, 38);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.pnlAccentLine);
            this.pnlHeader.Controls.Add(this.pnlTopCircle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1050, 70);
            this.pnlHeader.TabIndex = 0;

            // 
            // lblTitle (шрифт Monotype Corsiva)
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(245, 236, 215);
            this.lblTitle.Location = new System.Drawing.Point(30, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(239, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Винтажный Бутик";

            // 
            // pnlAccentLine
            // 
            this.pnlAccentLine.BackColor = System.Drawing.Color.FromArgb(218, 165, 32);
            this.pnlAccentLine.Location = new System.Drawing.Point(0, 67);
            this.pnlAccentLine.Name = "pnlAccentLine";
            this.pnlAccentLine.Size = new System.Drawing.Size(1050, 2);
            this.pnlAccentLine.TabIndex = 1;

            // 
            // pnlTopCircle (уменьшен, не перекрывает кнопки)
            // 
            this.pnlTopCircle.BackColor = System.Drawing.Color.Transparent;
            this.pnlTopCircle.Location = new System.Drawing.Point(980, 15);
            this.pnlTopCircle.Name = "pnlTopCircle";
            this.pnlTopCircle.Size = new System.Drawing.Size(40, 40);
            this.pnlTopCircle.TabIndex = 2;
            this.pnlTopCircle.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawHeaderCircle);

            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(245, 236, 215);
            this.pnlSidebar.Controls.Add(this.btnFavorites);
            this.pnlSidebar.Controls.Add(this.btnCart);
            this.pnlSidebar.Controls.Add(this.btnAddToFavorites);
            this.pnlSidebar.Controls.Add(this.btnAddToCart);
            this.pnlSidebar.Controls.Add(this.pnlSideDiamond);
            this.pnlSidebar.Location = new System.Drawing.Point(0, 70);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 550);
            this.pnlSidebar.TabIndex = 1;

            // 
            // btnAddToCart (шрифт Unbounded)
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(139, 105, 20);
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Unbounded", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddToCart.ForeColor = System.Drawing.Color.FromArgb(245, 236, 215);
            this.btnAddToCart.Location = new System.Drawing.Point(15, 30);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(190, 45);
            this.btnAddToCart.TabIndex = 0;
            this.btnAddToCart.Text = "🛒 В корзину";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);

            // 
            // btnAddToFavorites (шрифт Unbounded)
            // 
            this.btnAddToFavorites.BackColor = System.Drawing.Color.FromArgb(212, 196, 168);
            this.btnAddToFavorites.FlatAppearance.BorderSize = 0;
            this.btnAddToFavorites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToFavorites.Font = new System.Drawing.Font("Unbounded", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddToFavorites.ForeColor = System.Drawing.Color.FromArgb(107, 66, 38);
            this.btnAddToFavorites.Location = new System.Drawing.Point(15, 90);
            this.btnAddToFavorites.Name = "btnAddToFavorites";
            this.btnAddToFavorites.Size = new System.Drawing.Size(190, 45);
            this.btnAddToFavorites.TabIndex = 1;
            this.btnAddToFavorites.Text = "❤️ В избранное";
            this.btnAddToFavorites.UseVisualStyleBackColor = false;
            this.btnAddToFavorites.Click += new System.EventHandler(this.btnAddToFavorites_Click);

            // 
            // btnCart (шрифт Unbounded)
            // 
            this.btnCart.BackColor = System.Drawing.Color.FromArgb(45, 90, 39);
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Unbounded", 9F, System.Drawing.FontStyle.Bold);
            this.btnCart.ForeColor = System.Drawing.Color.FromArgb(245, 236, 215);
            this.btnCart.Location = new System.Drawing.Point(15, 160);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(190, 45);
            this.btnCart.TabIndex = 2;
            this.btnCart.Text = "📦 Корзина";
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);

            // 
            // btnFavorites (шрифт Unbounded)
            // 
            this.btnFavorites.BackColor = System.Drawing.Color.FromArgb(139, 58, 58);
            this.btnFavorites.FlatAppearance.BorderSize = 0;
            this.btnFavorites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavorites.Font = new System.Drawing.Font("Unbounded", 9F, System.Drawing.FontStyle.Bold);
            this.btnFavorites.ForeColor = System.Drawing.Color.FromArgb(245, 236, 215);
            this.btnFavorites.Location = new System.Drawing.Point(15, 220);
            this.btnFavorites.Name = "btnFavorites";
            this.btnFavorites.Size = new System.Drawing.Size(190, 45);
            this.btnFavorites.TabIndex = 3;
            this.btnFavorites.Text = "⭐ Избранное";
            this.btnFavorites.UseVisualStyleBackColor = false;
            this.btnFavorites.Click += new System.EventHandler(this.btnFavorites_Click);

            // 
            // pnlSideDiamond (уменьшен, внизу панели)
            // 
            this.pnlSideDiamond.BackColor = System.Drawing.Color.Transparent;
            this.pnlSideDiamond.Location = new System.Drawing.Point(170, 500);
            this.pnlSideDiamond.Name = "pnlSideDiamond";
            this.pnlSideDiamond.Size = new System.Drawing.Size(25, 25);
            this.pnlSideDiamond.TabIndex = 4;
            this.pnlSideDiamond.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawSideDiamond);

            // 
            // lblSearch (шрифт Unbounded)
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Unbounded", 9F);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(107, 66, 38);
            this.lblSearch.Location = new System.Drawing.Point(240, 95);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(47, 18);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Поиск:";

            // 
            // txtSearch (шрифт Unbounded)
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(255, 249, 240);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Unbounded", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.txtSearch.Location = new System.Drawing.Point(300, 92);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 26);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            // 
            // lblCategory (шрифт Unbounded)
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Unbounded", 9F);
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(107, 66, 38);
            this.lblCategory.Location = new System.Drawing.Point(580, 95);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(71, 18);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Категория:";

            // 
            // cmbCategories (шрифт Unbounded)
            // 
            this.cmbCategories.BackColor = System.Drawing.Color.FromArgb(255, 249, 240);
            this.cmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategories.Font = new System.Drawing.Font("Unbounded", 9F);
            this.cmbCategories.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.cmbCategories.Location = new System.Drawing.Point(660, 92);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(200, 26);
            this.cmbCategories.TabIndex = 5;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);

            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.FromArgb(255, 249, 240);
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(107, 66, 38);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Unbounded", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(245, 236, 215);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(139, 105, 20);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.ColumnHeadersHeight = 40;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(255, 249, 240);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Unbounded", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(212, 196, 168);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(212, 196, 168);
            this.dgvProducts.Location = new System.Drawing.Point(240, 130);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProducts.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(255, 249, 240);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Unbounded", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(212, 196, 168);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducts.RowTemplate.Height = 35;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(780, 440);
            this.dgvProducts.TabIndex = 6;

            // 
            // pnlCornerCircle (уменьшен, в углу)
            // 
            this.pnlCornerCircle.BackColor = System.Drawing.Color.Transparent;
            this.pnlCornerCircle.Location = new System.Drawing.Point(1000, 560);
            this.pnlCornerCircle.Name = "pnlCornerCircle";
            this.pnlCornerCircle.Size = new System.Drawing.Size(30, 30);
            this.pnlCornerCircle.TabIndex = 7;
            this.pnlCornerCircle.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCornerCircle);

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 236, 215);
            this.ClientSize = new System.Drawing.Size(1050, 650);
            this.Controls.Add(this.pnlCornerCircle);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Unbounded", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Винтажный Бутик";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Методы для рисования фигур
        private void DrawHeaderCircle(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.FromArgb(218, 165, 32), 2))
            {
                e.Graphics.DrawEllipse(pen, 0, 0, 38, 38);
            }
            using (Pen pen2 = new Pen(Color.FromArgb(245, 236, 215), 1))
            {
                e.Graphics.DrawEllipse(pen2, 4, 4, 30, 30);
            }
        }

        private void DrawSideDiamond(object sender, PaintEventArgs e)
        {
            Point[] points = new Point[]
            {
                new Point(12, 0),
                new Point(24, 12),
                new Point(12, 24),
                new Point(0, 12)
            };
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(139, 105, 20)))
            {
                e.Graphics.FillPolygon(brush, points);
            }
        }

        private void DrawCornerCircle(object sender, PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(218, 165, 32)))
            {
                e.Graphics.FillEllipse(brush, 0, 0, 28, 28);
            }
            using (Pen pen = new Pen(Color.FromArgb(255, 249, 240), 1.5f))
            {
                e.Graphics.DrawEllipse(pen, 3, 3, 22, 22);
            }
        }
    }
}