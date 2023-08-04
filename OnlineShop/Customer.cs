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
    public partial class Customer : Form
    {
        string con = ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
        string itemID = "0";
        string price;
        string userID = Login.retrieved_userID.ToString(); //To get the userID of the current user when he/she logs in.

        public Customer()
        {
            InitializeComponent();
        }

        private void LoadGridView()
        {
            MySqlConnection conn = new MySqlConnection(con);

            string cmd = "SELECT Item.Id AS Id, Item.Name AS Item, Category.Name AS Category, SellingPrice, Size, Color " +
                " FROM Item, Category " +
                " WHERE Item.CategoryId = Category.Id " +
                " AND Visible='Yes'" +
                " ORDER BY Item.Id";

            MySqlDataAdapter da = new MySqlDataAdapter(cmd, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Category");

            dgv_list.DataSource = ds.Tables["Category"].DefaultView;
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
            //Clears all labels.
            lbl_item.Text = "";
            lbl_category.Text = "";
            lbl_price.Text = "";
            lbl_size.Text = "";
            lbl_color.Text = "";
            itemID = "0";

            btn_save_wishlist.Text = "Save to wishlist";
            btn_save_wishlist.Enabled = true;
            btn_save_wishlist.BackColor = System.Drawing.Color.PeachPuff;

            btn_add_cart.Text = "Add to cart";
            btn_add_cart.Enabled = true;
            btn_add_cart.BackColor = System.Drawing.Color.PeachPuff;
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

        private void lbl_wishlist_Click(object sender, EventArgs e)
        {
            Wishlist wishlist = new Wishlist();
            this.Hide();
            wishlist.Show();
        }

        private void lbl_orders_Click(object sender, EventArgs e)
        {
            PlacedOrder placedorder = new PlacedOrder();
            this.Hide();
            placedorder.Show();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            //Loads Item table on the grid view.
            LoadGridView();
        }

        private void dgv_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //When a cell is clicked, displays the selected rows on the text boxes.
            lbl_item.Text = dgv_list.SelectedRows[0].Cells[1].Value.ToString();
            lbl_category.Text = dgv_list.SelectedRows[0].Cells[2].Value.ToString();
            lbl_price.Text = dgv_list.SelectedRows[0].Cells[3].Value.ToString();
            lbl_size.Text = dgv_list.SelectedRows[0].Cells[4].Value.ToString();
            lbl_color.Text = dgv_list.SelectedRows[0].Cells[5].Value.ToString();
            
            itemID = dgv_list.SelectedRows[0].Cells[0].Value.ToString();
            price = dgv_list.SelectedRows[0].Cells[3].Value.ToString();

            //Disable button if the item already saved to wishist.
            bool itemID_exists_on_wishlist = check_ItemID_ifexists(userID, itemID, "Wishlist");
            if (itemID_exists_on_wishlist == true)
            {
                btn_save_wishlist.Text = "Already saved";
                btn_save_wishlist.Enabled = false;
                btn_save_wishlist.BackColor = System.Drawing.Color.Snow;
            }
            else
            {
                btn_save_wishlist.Text = "Save to wishlist";
                btn_save_wishlist.Enabled = true;
                btn_save_wishlist.BackColor = System.Drawing.Color.PeachPuff;
            }

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

        private void btn_save_wishlist_Click(object sender, EventArgs e)
        {
            
            if (itemID == "0")
            {
                MessageBox.Show("Please select an item.", "No selected item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
                MySqlConnection conn = new MySqlConnection(con);
                string queryInsert = "INSERT INTO Wishlist(UserID, ItemID) VALUES(" + userID + "," + itemID + ")";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(queryInsert, conn);

                try
                {
                    //Adding the item on the wishlist.
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item is successfully saved to your wishlist.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception err)
                {
                    MessageBox.Show("Item is not saved successfully to your wishlist." + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
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
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(queryInsert, conn);

                try
                {
                    //Adding the item on the wishlist.
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item is successfully added to your cart.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show("Item is not added successfully to your cart." + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
                clear();
            }
        }
    }
}
