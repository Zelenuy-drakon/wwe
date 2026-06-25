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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            cmbCategories = new ComboBox();
            txtSearch = new TextBox();
            dgvProducts = new DataGridView();
            btnAddToCart = new Button();
            btnAddToFavorites = new Button();
            btnCart = new Button();
            btnFavorites = new Button();
            lblSearch = new Label();
            lblCategory = new Label();
            pnlHeader = new Panel();
            btnProfile = new Button();
            lblTitle = new Label();
            pnlAccentLine = new Panel();
            pnlSidebar = new Panel();
            pnlSideDiamond = new Panel();
            pnlCornerCircle = new Panel();
            sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            cmsProfile = new ContextMenuStrip(components);
            личныйКабинетToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            pnlHeader.SuspendLayout();
            pnlSidebar.SuspendLayout();
            cmsProfile.SuspendLayout();
            SuspendLayout();
            // 
            // cmbCategories
            // 
            cmbCategories.BackColor = Color.FromArgb(255, 249, 240);
            cmbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategories.FlatStyle = FlatStyle.Flat;
            cmbCategories.Font = new Font("Microsoft Sans Serif", 9F);
            cmbCategories.ForeColor = Color.FromArgb(51, 51, 51);
            cmbCategories.Location = new Point(660, 92);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(200, 23);
            cmbCategories.TabIndex = 5;
            cmbCategories.SelectedIndexChanged += cmbCategories_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(255, 249, 240);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Microsoft Sans Serif", 9F);
            txtSearch.ForeColor = Color.FromArgb(51, 51, 51);
            txtSearch.Location = new Point(300, 92);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(250, 21);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.BackgroundColor = Color.FromArgb(255, 249, 240);
            dgvProducts.BorderStyle = BorderStyle.None;
            dgvProducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(107, 66, 38);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(245, 236, 215);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(139, 105, 20);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.ColumnHeadersHeight = 40;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 249, 240);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(212, 196, 168);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.GridColor = Color.FromArgb(212, 196, 168);
            dgvProducts.Location = new Point(240, 130);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProducts.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 249, 240);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(212, 196, 168);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(51, 51, 51);
            dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvProducts.RowTemplate.Height = 35;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(780, 440);
            dgvProducts.TabIndex = 6;
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = Color.FromArgb(139, 105, 20);
            btnAddToCart.FlatAppearance.BorderSize = 0;
            btnAddToCart.FlatStyle = FlatStyle.Flat;
            btnAddToCart.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnAddToCart.ForeColor = Color.FromArgb(245, 236, 215);
            btnAddToCart.Location = new Point(15, 30);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(190, 45);
            btnAddToCart.TabIndex = 0;
            btnAddToCart.Text = "\U0001f6d2 В корзину";
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // btnAddToFavorites
            // 
            btnAddToFavorites.BackColor = Color.FromArgb(212, 196, 168);
            btnAddToFavorites.FlatAppearance.BorderSize = 0;
            btnAddToFavorites.FlatStyle = FlatStyle.Flat;
            btnAddToFavorites.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnAddToFavorites.ForeColor = Color.FromArgb(107, 66, 38);
            btnAddToFavorites.Location = new Point(15, 90);
            btnAddToFavorites.Name = "btnAddToFavorites";
            btnAddToFavorites.Size = new Size(190, 45);
            btnAddToFavorites.TabIndex = 1;
            btnAddToFavorites.Text = "❤️ В избранное";
            btnAddToFavorites.UseVisualStyleBackColor = false;
            btnAddToFavorites.Click += btnAddToFavorites_Click;
            // 
            // btnCart
            // 
            btnCart.BackColor = Color.FromArgb(45, 90, 39);
            btnCart.FlatAppearance.BorderSize = 0;
            btnCart.FlatStyle = FlatStyle.Flat;
            btnCart.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnCart.ForeColor = Color.FromArgb(245, 236, 215);
            btnCart.Location = new Point(15, 160);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(190, 45);
            btnCart.TabIndex = 2;
            btnCart.Text = "📦 Корзина";
            btnCart.UseVisualStyleBackColor = false;
            btnCart.Click += btnCart_Click;
            // 
            // btnFavorites
            // 
            btnFavorites.BackColor = Color.FromArgb(139, 58, 58);
            btnFavorites.FlatAppearance.BorderSize = 0;
            btnFavorites.FlatStyle = FlatStyle.Flat;
            btnFavorites.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnFavorites.ForeColor = Color.FromArgb(245, 236, 215);
            btnFavorites.Location = new Point(15, 220);
            btnFavorites.Name = "btnFavorites";
            btnFavorites.Size = new Size(190, 45);
            btnFavorites.TabIndex = 3;
            btnFavorites.Text = "⭐ Избранное";
            btnFavorites.UseVisualStyleBackColor = false;
            btnFavorites.Click += btnFavorites_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Microsoft Sans Serif", 9F);
            lblSearch.ForeColor = Color.FromArgb(107, 66, 38);
            lblSearch.Location = new Point(240, 95);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(45, 15);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Поиск:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Microsoft Sans Serif", 9F);
            lblCategory.ForeColor = Color.FromArgb(107, 66, 38);
            lblCategory.Location = new Point(580, 95);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(72, 15);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Категория:";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(107, 66, 38);
            pnlHeader.Controls.Add(btnProfile);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(pnlAccentLine);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1050, 70);
            pnlHeader.TabIndex = 0;
            // 
            // btnProfile
            // 
            btnProfile.BackgroundImage = Properties.Resources.images__1_;
            btnProfile.Location = new Point(963, 3);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(62, 58);
            btnProfile.TabIndex = 2;
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic);
            lblTitle.ForeColor = Color.FromArgb(245, 236, 215);
            lblTitle.Location = new Point(30, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(256, 39);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Винтажный Бутик";
            // 
            // pnlAccentLine
            // 
            pnlAccentLine.BackColor = Color.FromArgb(218, 165, 32);
            pnlAccentLine.Location = new Point(0, 67);
            pnlAccentLine.Name = "pnlAccentLine";
            pnlAccentLine.Size = new Size(1050, 2);
            pnlAccentLine.TabIndex = 1;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(245, 236, 215);
            pnlSidebar.Controls.Add(btnFavorites);
            pnlSidebar.Controls.Add(btnCart);
            pnlSidebar.Controls.Add(btnAddToFavorites);
            pnlSidebar.Controls.Add(btnAddToCart);
            pnlSidebar.Controls.Add(pnlSideDiamond);
            pnlSidebar.Location = new Point(0, 70);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(220, 550);
            pnlSidebar.TabIndex = 1;
            // 
            // pnlSideDiamond
            // 
            pnlSideDiamond.BackColor = Color.Transparent;
            pnlSideDiamond.Location = new Point(170, 500);
            pnlSideDiamond.Name = "pnlSideDiamond";
            pnlSideDiamond.Size = new Size(25, 25);
            pnlSideDiamond.TabIndex = 4;
            pnlSideDiamond.Paint += DrawSideDiamond;
            // 
            // pnlCornerCircle
            // 
            pnlCornerCircle.BackColor = Color.Transparent;
            pnlCornerCircle.Location = new Point(1000, 560);
            pnlCornerCircle.Name = "pnlCornerCircle";
            pnlCornerCircle.Size = new Size(30, 30);
            pnlCornerCircle.TabIndex = 7;
            pnlCornerCircle.Paint += DrawCornerCircle;
            // 
            // cmsProfile
            // 
            cmsProfile.Items.AddRange(new ToolStripItem[] { личныйКабинетToolStripMenuItem, выходToolStripMenuItem });
            cmsProfile.Name = "cmsProfile";
            cmsProfile.RenderMode = ToolStripRenderMode.Professional;
            cmsProfile.Size = new Size(167, 48);
            // 
            // личныйКабинетToolStripMenuItem
            // 
            личныйКабинетToolStripMenuItem.Name = "личныйКабинетToolStripMenuItem";
            личныйКабинетToolStripMenuItem.Size = new Size(166, 22);
            личныйКабинетToolStripMenuItem.Text = "Личный кабинет";
            личныйКабинетToolStripMenuItem.Click += личныйКабинетToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(166, 22);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 236, 215);
            ClientSize = new Size(1050, 650);
            Controls.Add(pnlCornerCircle);
            Controls.Add(dgvProducts);
            Controls.Add(cmbCategories);
            Controls.Add(lblCategory);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlHeader);
            Font = new Font("Microsoft Sans Serif", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Винтажный Бутик";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            cmsProfile.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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

        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private ContextMenuStrip cmsProfile;
        private ToolStripMenuItem личныйКабинетToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private Button btnProfile;
    }
}