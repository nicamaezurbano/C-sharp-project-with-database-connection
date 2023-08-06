using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace OnlineShop
{
    public partial class Report : Form
    {
        string con = ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;

        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(con);

            string querySelect = "SELECT Id, GrandTotal, CheckoutDate, Status FROM Orders";

            MySqlDataAdapter da = new MySqlDataAdapter(querySelect, conn);
            OnlineShop_DataSet ds = new OnlineShop_DataSet();
            da.Fill(ds.Tables["Orders"]);

            //Creating an instance of the created Crystal Report
            CrystalReport1 crpt1 = new CrystalReport1();
            crpt1.SetDataSource(ds.Tables["Orders"]);
            crpt_viewer.Refresh();
            crpt_viewer.ReportSource = crpt1;
        }
    }
}
