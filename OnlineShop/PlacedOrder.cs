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
    public partial class PlacedOrder : Form
    {
        string con = ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
        string userID = Login.retrieved_userID.ToString(); //To get the userID of the current user when he/she logs in.

        public PlacedOrder()
        {
            InitializeComponent();
        }

        private void lbl_login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void lbl_home_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            this.Hide();
            customer.Show();
        }

        private void lbl_cart_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            this.Hide();
            cart.Show();
        }

        private void lbl_wishlist_Click(object sender, EventArgs e)
        {
            Wishlist wishlist = new Wishlist();
            this.Hide();
            wishlist.Show();
        }

        private void PlacedOrder_Load(object sender, EventArgs e)
        {
            //Getting the current order/s of the customer.
            MySqlConnection conn = new MySqlConnection(con);
            string select_currentOrders = "SELECT Id AS 'Order ID', GrandTotal AS 'Grand Total', PaymentOption AS 'Payment Option', CheckoutDate AS 'Checkout Date', Status" +
                " FROM Orders WHERE UserID=" + userID + "";
            MySqlDataAdapter da1 = new MySqlDataAdapter(select_currentOrders, conn);
            DataSet ds = new DataSet();
            da1.Fill(ds, "CurrentOrders");

            //Displays the current orders of the customer in which order status is not set to delivered.
            dgv_order_list.DataSource = ds.Tables["CurrentOrders"].DefaultView;

        }

        private void dgv_order_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string orderID = dgv_order_list.SelectedRows[0].Cells[0].Value.ToString();

            MySqlConnection conn = new MySqlConnection(con);

            //Retrieves all item included in the order.
            string querySelectItem = "SELECT Name, SellingPrice, Size, Color, Quantity, Subtotal" +
                " FROM Item, OrderLine" +
                " WHERE OrderLine.ItemID=Item.ID && OrderLine.OrderID=" + orderID + "";

            MySqlDataAdapter da = new MySqlDataAdapter(querySelectItem, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "OrderLine");

            //Displays all item on a data grid view.
            dgv_item_list.DataSource = ds.Tables["OrderLine"].DefaultView;
        }
    }
}
