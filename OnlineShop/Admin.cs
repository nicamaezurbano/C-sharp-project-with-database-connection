using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void lbl_login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void pnl_category_Click(object sender, EventArgs e)
        {
            //Category category = new Category();
            //this.Hide();
            //category.Show();
        }
    }
}
