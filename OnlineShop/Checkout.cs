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
    public partial class Checkout : Form
    {
        string con = ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
        string userID = Login.retrieved_userID.ToString(); //To get the userID of the current user when he/she logs in.
        string grandTotal = Cart.grandTotal.ToString();  //To get the computed grand total.
        string date = DateTime.UtcNow.ToString("yyyy-MM-dd");  //To get the current date.


        public Checkout()
        {
            InitializeComponent();
        }

        private void LoadGridView()
        {
            MySqlConnection conn = new MySqlConnection(con);

            string cmd = "SELECT Cart.ItemID AS 'Item ID', Item.Name, Category.Name AS 'Category', Size, Color, SellingPrice AS Price, Quantity, Subtotal" +
                " FROM Cart, Item, Category" +
                " WHERE Cart.ItemID=Item.Id AND Item.CategoryId =Category.Id AND UserID=" + userID + "";

            MySqlDataAdapter da = new MySqlDataAdapter(cmd, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Cart");

            //Displays the cart of the current user.
            dgv_list.DataSource = ds.Tables["Cart"].DefaultView;
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            //Loads all item th user added to cart on the grid view.
            LoadGridView();

            MySqlConnection conn = new MySqlConnection(con);

            string cmd = "SELECT * FROM User WHERE Id=" + userID + "";

            MySqlDataAdapter da = new MySqlDataAdapter(cmd, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "User");

            //Displays the user's details.
            string fname = ds.Tables["User"].Rows[0][3].ToString();
            string lname = ds.Tables["User"].Rows[0][4].ToString();
            lbl_name.Text = fname + " " + lname;
            lbl_contact.Text = ds.Tables["User"].Rows[0][5].ToString();
            lbl_email.Text = ds.Tables["User"].Rows[0][1].ToString();
            lbl_barangay.Text = ds.Tables["User"].Rows[0][6].ToString();
            lbl_municipality.Text = ds.Tables["User"].Rows[0][7].ToString();
            lbl_province.Text = ds.Tables["User"].Rows[0][8].ToString();
        }

        private void lbl_back_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            this.Hide();
            cart.Show();
        }

        private void btn_placeorder_Click(object sender, EventArgs e)
        {
            string paymentOption = "COD";

            //If none of the radio button is selected, displays a message.
            if (rdb_cod.Checked == false && rdb_gcash.Checked == false)
            {
                MessageBox.Show("Please select payment option.", "Payment Option Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                //Setting the string value when a particular radio button is selected.
                if (rdb_cod.Checked == true)
                {
                    paymentOption = "COD";
                }
                else
                {
                    paymentOption = "GCash";
                }


                MySqlConnection conn = new MySqlConnection(con);
                string queryInsertOrders = "INSERT INTO Orders(UserID, GrandTotal, PaymentOption, CheckoutDate, Status) " +
                    "VALUES(" + userID + "," + grandTotal + ",'" + paymentOption + "','" + date + "','Placed')";
                conn.Open();
                MySqlCommand cmd_insertOrders = new MySqlCommand(queryInsertOrders, conn);


                //Getting the item/s on the shopping cart of the customer.
                DataSet ds = new DataSet();
                string select_shoppingcart = "SELECT * FROM Cart WHERE UserID=" + userID + "";
                MySqlDataAdapter da = new MySqlDataAdapter(select_shoppingcart, conn);
                da.Fill(ds, "CartItems");
                int row = ds.Tables["CartItems"].Rows.Count;


                string queryDelete = "DELETE FROM Cart WHERE UserID=" + userID + "";
                MySqlCommand cmd_delete = new MySqlCommand(queryDelete, conn);


                try
                {
                    //Placing the order of the user.
                    cmd_insertOrders.ExecuteNonQuery();
                    MessageBox.Show("Your order is placed successfully.", "Order Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Getting the last inserted id of the order table
                    string select_last_inserted_id = "SELECT ID FROM Orders WHERE Id=(SELECT LAST_INSERT_ID())";
                    da = new MySqlDataAdapter(select_last_inserted_id, conn);
                    da.Fill(ds, "lastID");
                    string orderID = ds.Tables["lastID"].Rows[0][0].ToString();
                     

                    //Inserting the items from the shopping cart in orderline table.
                    for (int i = 0; i < row; i++)
                    {
                        string itemID = ds.Tables["CartItems"].Rows[i][2].ToString();
                        string quantity = ds.Tables["CartItems"].Rows[i][3].ToString();
                        string subtotal = ds.Tables["CartItems"].Rows[i][4].ToString();

                        string queryInsertOrderline = "INSERT INTO OrderLine(OrderID, ItemID, Quantity, Subtotal) " +
                            "VALUES(" + orderID + "," + itemID + "," + quantity + "," + subtotal + ")";
                        MySqlCommand cmd_insertOrderLine = new MySqlCommand(queryInsertOrderline, conn);
                        cmd_insertOrderLine.ExecuteNonQuery();
                    }


                    //Removing the item/s in the shopping cart.
                    cmd_delete.ExecuteNonQuery();
                    conn.Close();

                    //Display the main form(customer) where user selects an item.
                    Customer customer = new Customer();
                    customer.Show();
                    this.Hide();
                }
                catch(Exception err)
                {
                    MessageBox.Show("There is an error placing your order with a message of "+err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
