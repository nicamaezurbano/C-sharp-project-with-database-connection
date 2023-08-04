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
    public partial class Wishlist : Form
    {
        string con = ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
        string userID = Login.retrieved_userID.ToString(); //To get the userID of the current user when he/she logs in.
        string itemID = "0";
        string price;

        public Wishlist()
        {
            InitializeComponent();
        }

        private void LoadGridView()
        {
            MySqlConnection conn = new MySqlConnection(con);

            string cmd = "SELECT Wishlist.ItemID AS 'Item ID', Item.Name AS Item, Category.Name AS 'Category', Size, Color, SellingPrice AS Price" +
                " FROM Wishlist, Item, Category" +
                " WHERE Wishlist.ItemID=Item.Id AND Item.CategoryId =Category.Id AND UserID=" + userID + "";

            MySqlDataAdapter da = new MySqlDataAdapter(cmd, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Wishlist");

            //Displays the cart of the current user.
            dgv_list.DataSource = ds.Tables["Wishlist"].DefaultView;
        }

        private bool check_ItemID_ifexists(string userID, string itemID, string table)
        {
            MySqlConnection conn = new MySqlConnection(con);
            DataSet ds = new DataSet();
            int row = 0;

            //Getting the no. rows from the particular table.
            string selectQuery = "SELECT * FROM " + table + " WHERE UserID=" + userID + " AND ItemID=" + itemID + "";
            MySqlDataAdapter da = new MySqlDataAdapter(selectQuery, conn);
            da.Fill(ds, "SelectedTable");
            row = ds.Tables["SelectedTable"].Rows.Count;

            //If there is no record, returns false.
            if (row <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void clear()
        {
            lbl_item.Text = "";
            lbl_category.Text = "";
            lbl_price.Text = "";
            lbl_size.Text = "";
            lbl_color.Text = "";
        }

        private void lbl_login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void lbl_cart_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            this.Hide();
            cart.Show();
        }

        private void lbl_orders_Click(object sender, EventArgs e)
        {
            PlacedOrder placedorder = new PlacedOrder();
            this.Hide();
            placedorder.Show();
        }

        private void lbl_home_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            this.Hide();
            customer.Show();
        }

        private void Wishlist_Load(object sender, EventArgs e)
        {
            //Loads all item th user added to cart on the grid view.
            LoadGridView();
        }

        private void dgv_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Displays the selected records on the labels.
            itemID = dgv_list.SelectedRows[0].Cells[0].Value.ToString();
            price = dgv_list.SelectedRows[0].Cells[5].Value.ToString();
            lbl_item.Text = dgv_list.SelectedRows[0].Cells[1].Value.ToString();
            lbl_category.Text = dgv_list.SelectedRows[0].Cells[2].Value.ToString();
            lbl_size.Text = dgv_list.SelectedRows[0].Cells[3].Value.ToString();
            lbl_color.Text = dgv_list.SelectedRows[0].Cells[4].Value.ToString();
            lbl_price.Text = dgv_list.SelectedRows[0].Cells[5].Value.ToString();

            //Disable button if the item already added to cart.
            bool itemID_exists_on_cart = check_ItemID_ifexists(userID, itemID, "Cart");
            if (itemID_exists_on_cart == true)
            {
                btn_add_cart.Text = "Already added";
                btn_add_cart.Enabled = false;
                btn_add_cart.BackColor = System.Drawing.Color.Snow;
            }
            else
            {
                btn_add_cart.Text = "Add to cart";
                btn_add_cart.Enabled = true;
                btn_add_cart.BackColor = System.Drawing.Color.PeachPuff;
            }
        }

        private void btn_remove_item_Click(object sender, EventArgs e)
        {
            if (itemID == "0")
            {
                MessageBox.Show("Please select an item.", "No selected item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MySqlConnection conn = new MySqlConnection(con);
                string queryDelete = "DELETE FROM Wishlist WHERE ItemID=" + itemID + " AND UserID='" + userID + "'";

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(queryDelete, conn);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Deleting item is not successfull.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conn.Close();
                LoadGridView(); //To update the contents of the grid view.
                clear();
            }
            
        }

        private void btn_add_cart_Click(object sender, EventArgs e)
        {

            if (itemID == "0")
            {
                MessageBox.Show("Please select an item.", "No selected item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MySqlConnection conn = new MySqlConnection(con);
                string queryInsert = "INSERT INTO Cart(UserID, ItemID, Quantity, Subtotal) " +
                    "VALUES(" + userID + "," + itemID + ", 1, " + price + ")";
                string queryDelete = "DELETE FROM Wishlist WHERE ItemID=" + itemID + " AND UserID='" + userID + "'";

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(queryInsert, conn);
                MySqlCommand cmd2 = new MySqlCommand(queryDelete, conn);

                try
                {
                    //Adding the item on the wishlist.
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Item is successfully added to your cart.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception err)
                {
                    MessageBox.Show("Item is not added successfully to your cart." + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
                LoadGridView(); //To update the contents of the grid view.
                clear();
            }
        }
    }
}
