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
    public partial class Order : Form
    {
        string con = ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
        string selected_orderID;

        public Order()
        {
            InitializeComponent();
        }

        private void LoadOrderGridView()
        {
            MySqlConnection conn = new MySqlConnection(con);

            string querySelect = "SELECT Id, UserID AS 'User Id', GrandTotal AS Total, PaymentOption AS 'Payment Method', CheckoutDate AS 'Checkout Date', Status FROM Orders";

            MySqlDataAdapter da = new MySqlDataAdapter(querySelect, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Orders");

            //Displays Orders table on the data grid view.
            dgv_order_list.DataSource = ds.Tables["Orders"].DefaultView;
        }
        private void getSelected_customer(string userID)
        {
            MySqlConnection conn = new MySqlConnection(con);

            //Retrieves the customer who placed the order.
            string querySelectCustomer = "SELECT Email, FirstName, LastName, ContactNumber, Barangay, Municipality, Province" +
                " FROM User" +
                " WHERE Id=" + userID + "";

            MySqlDataAdapter da = new MySqlDataAdapter(querySelectCustomer, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "User");

            //Displays the Customer Details and Delivery Address.
            string email = ds.Tables["User"].Rows[0][0].ToString();
            string fname = ds.Tables["User"].Rows[0][1].ToString();
            string lname = ds.Tables["User"].Rows[0][2].ToString();
            string contact = ds.Tables["User"].Rows[0][3].ToString();
            string barangay = ds.Tables["User"].Rows[0][4].ToString();
            string municipality = ds.Tables["User"].Rows[0][5].ToString();
            string province = ds.Tables["User"].Rows[0][6].ToString();

            string name = fname + " " + lname;

            lbl_name.Text = name;
            lbl_contact.Text = contact;
            lbl_email.Text = email;
            lbl_brgy.Text = barangay;
            lbl_municipality.Text = municipality;
            lbl_province.Text = province;
        }
        private void getSelected_item(string orderID)
        {
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

        private void clear()
        {
            //Clears all labels and the data grid view  for the items.
            lbl_name.Text = "";
            lbl_contact.Text = "";
            lbl_email.Text = "";
            lbl_brgy.Text = "";
            lbl_municipality.Text = "";
            lbl_province.Text = "";
            dgv_item_list.DataSource = null;
        }

        private void lbl_back_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Hide();
            admin.Show();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            //Loads Item table on the grid view.
            LoadOrderGridView();
        }

        private void dgv_order_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //To get the customer details of the order and its included item/s.
            selected_orderID = dgv_order_list.SelectedRows[0].Cells[0].Value.ToString();
            string selected_userID = dgv_order_list.SelectedRows[0].Cells[1].Value.ToString();
            string status = dgv_order_list.SelectedRows[0].Cells[5].Value.ToString();
            getSelected_customer(selected_userID);
            getSelected_item(selected_orderID);

            btn_packed.Enabled = false;
            btn_shipped.Enabled = false;
            btn_delivered.Enabled = false;

            btn_packed.BackColor = System.Drawing.Color.Snow;
            btn_shipped.BackColor = System.Drawing.Color.Snow;
            btn_delivered.BackColor = System.Drawing.Color.Snow;

            //Then checks the status of order to enable the appropriate button.
            if (status == "Placed")
            {
                btn_packed.Enabled = true;
                btn_packed.BackColor = System.Drawing.Color.PeachPuff;
            }
            else if (status == "Packed")
            {
                btn_shipped.Enabled = true;
                btn_shipped.BackColor = System.Drawing.Color.PeachPuff;
            }
            else if (status == "Shipped")
            {
                btn_delivered.Enabled = true;
                btn_delivered.BackColor = System.Drawing.Color.PeachPuff;
            }
        }

        private void btn_packed_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(con);
            string queryUpdate = "UPDATE Orders SET Status='Packed' WHERE Id = " + selected_orderID + "";

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(queryUpdate, conn);

            //Updates the status of the order to "Packed".
            cmd.ExecuteNonQuery();
            MessageBox.Show("Order is packed.");

            conn.Close();
            LoadOrderGridView(); //To update the status on the grid view.
            btn_packed.Enabled = false; //Disables the "Packed" button.
            btn_packed.BackColor = System.Drawing.Color.Snow;
            clear(); //Clears all textboxes and the list of items.
        }

        private void btn_shipped_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(con);
            string queryUpdate = "UPDATE Orders SET Status='Shipped' WHERE Id = " + selected_orderID + "";

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(queryUpdate, conn);

            //Updates the status of the order to "Shipped".
            cmd.ExecuteNonQuery();
            MessageBox.Show("Order is shipped.");

            conn.Close();
            LoadOrderGridView(); //To update the status on the grid view.
            btn_shipped.Enabled = false; //Disables the "Shipped" button.
            btn_shipped.BackColor = System.Drawing.Color.Snow;
            clear(); //Clears all textboxes and the list of items.
        }

        private void btn_delivered_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(con);
            string queryUpdate = "UPDATE Orders SET Status='Delivered' WHERE Id = " + selected_orderID + "";

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(queryUpdate, conn);

            //Updates the status of the order to "Delivered".
            cmd.ExecuteNonQuery();
            MessageBox.Show("Order is delivered.");

            conn.Close();
            LoadOrderGridView(); //To update the status on the grid view.
            btn_delivered.Enabled = false; //Disables the "Delivered" button.
            btn_delivered.BackColor = System.Drawing.Color.Snow;
            clear(); //Clears all textboxes and the list of items.
        }
    }
}
