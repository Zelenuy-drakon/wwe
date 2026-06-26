using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStoreApp.Forms
{
    public partial class PersonalAccount : Form
    {
        private readonly int userId;
        private readonly DatabaseHelper db = new DatabaseHelper();
        public PersonalAccount(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            this.Load += async (s, e) => await LoadName();
        }
        private void btnForgot_Click(object sender, EventArgs e)
        {
            var resetForm = new PasswordResetForm();
            resetForm.ShowDialog();
        }
        private async Task LoadName()
        {
            var parameters = new List<MySqlParameter>();
            parameters.Add(new MySqlParameter("@userId", userId));
            DataTable dt = await db.ExecuteQueryAsync("SELECT Username FROM Users WHERE UserId = @userId", parameters.ToArray());
            Console.WriteLine(dt);
            string name = Convert.ToString(dt.Rows[0][0]);
            txtUsername.Text = $"Ваш никнейм: {name}";
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            var m = new MainForm(userId);
            m.Show();
            this.Close();
            
        }
    }
}
