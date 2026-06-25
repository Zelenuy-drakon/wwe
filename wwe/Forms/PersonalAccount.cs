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
        public PersonalAccount (int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }
        private void btnForgot_Click(object sender, EventArgs e)
        {
            var resetForm = new PasswordResetForm();
            resetForm.ShowDialog();
        }
    }
}
