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
            Category category = new Category();
            this.Hide();
            category.Show();
        }

        private void lbl_category1_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            this.Hide();
            category.Show();
        }

        private void lbl_category2_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            this.Hide();
            category.Show();
        }

        private void pnl_item_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            this.Hide();
            item.Show();
        }

        private void lbl_item1_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            this.Hide();
            item.Show();
        }

        private void lbl_item2_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            this.Hide();
            item.Show();
        }

        private void pnl_order_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            this.Hide();
            order.Show();
        }

        private void lbl_order1_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            this.Hide();
            order.Show();
        }

        private void lbl_order2_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            this.Hide();
            order.Show();
        }

        private void pnl_report_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
        }

        private void lbl_report1_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
        }

        private void lbl_report2_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
        }
    }
}
