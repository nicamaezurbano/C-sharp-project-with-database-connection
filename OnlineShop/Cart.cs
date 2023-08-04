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
    public partial class Cart : Form
    {

        string con = ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
        string userID = Login.retrieved_userID.ToString(); //To get the userID of the current user when he/she logs in.
        public static decimal grandTotal;
        string itemID;
        decimal quantity;
        string price;

        public Cart()
        {
            InitializeComponent();
        }

        private void LoadGridView()
        {
            MySqlConnection conn = new MySqlConnection(con);

            string cmd = "SELECT Cart.ItemID AS 'Item ID', Item.Name AS Item, Category.Name AS 'Category', Size, Color, SellingPrice AS Price, Quantity, Subtotal" +
                " FROM Cart, Item, Category" +
                " WHERE Cart.ItemID=Item.Id AND Item.CategoryId =Category.Id AND UserID=" + userID + "";

            MySqlDataAdapter da = new MySqlDataAdapter(cmd, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Cart");

            //Displays the cart of the current user.
            dgv_list.DataSource = ds.Tables["Cart"].DefaultView;


            //To determine if there is an item on the shopping cart of the user.
            int row = ds.Tables["Cart"].Rows.Count;
            if (row > 0)
            {
                //If there is a record on the shopping cart,
                //Gets the grand total of the item/s included on the shopping cart.
                grandTotal = getGrandTotal();
                lbl_total.Text = grandTotal.ToString();
                //Also, enables the remove & checkout button.
                btn_remove_item.Enabled = true;
                btn_checkout.Enabled = true;
                btn_remove_item.BackColor = System.Drawing.Color.PeachPuff;
                btn_checkout.BackColor = System.Drawing.Color.PeachPuff;
            }
            else
            {
                //If there is no record on the shopping cart, grand total is set to 0.
                grandTotal = 0;
                lbl_total.Text = grandTotal.ToString();
                //Also, remove & checkout button is disabled.
                btn_checkout.Enabled = false;
                btn_remove_item.Enabled = false;
                btn_remove_item.BackColor = System.Drawing.Color.Snow;
                btn_checkout.BackColor = System.Drawing.Color.Snow;

            }

        }

        private decimal getGrandTotal()
        {
            MySqlConnection conn = new MySqlConnection(con);
            string cmd = "SELECT SUM(Subtotal) FROM Cart WHERE UserID=" + userID + "";

            MySqlDataAdapter da = new MySqlDataAdapter(cmd, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "GrandTotal");

            //Returns the grand total of the item/s.
            return decimal.Parse(ds.Tables["GrandTotal"].Rows[0][0].ToString());
        }

        private bool check_id_ifexists(string id)
        {
            MySqlConnection conn = new MySqlConnection(con);
            string selectQuery = "SELECT * FROM Cart WHERE ItemID = '" + id + "' AND UserID='" + userID + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(selectQuery, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Cart");


            //If there is no record, returns false.
            int row = ds.Tables["Cart"].Rows.Count;
            if (row <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            //Loads all item th user added to cart on the grid view.
            LoadGridView();
        }

        private void dgv_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Displays the selected records on the labels.
            itemID = dgv_list.SelectedRows[0].Cells[0].Value.ToString();
            lbl_item.Text = dgv_list.SelectedRows[0].Cells[1].Value.ToString();
            lbl_category.Text = dgv_list.SelectedRows[0].Cells[2].Value.ToString();
            lbl_size.Text = dgv_list.SelectedRows[0].Cells[3].Value.ToString();
            lbl_color.Text = dgv_list.SelectedRows[0].Cells[4].Value.ToString();
            lbl_price.Text = dgv_list.SelectedRows[0].Cells[5].Value.ToString();
            num_quantity.Value = decimal.Parse(dgv_list.SelectedRows[0].Cells[6].Value.ToString());
            quantity = num_quantity.Value;
            num_quantity.Enabled = true;
            price = lbl_price.Text;
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

        private void num_quantity_ValueChanged(object sender, EventArgs e)
        {
            quantity = num_quantity.Value;

            if (quantity == 0)
            {
                quantity = 1;
                num_quantity.Value = 1;
            }

            decimal subtotal = decimal.Parse(price) * num_quantity.Value;

            MySqlConnection conn = new MySqlConnection(con);
            string queryUpdate = "UPDATE Cart SET " +
                "Quantity='" + quantity + "', " +
                "Subtotal='" + subtotal + "' " +
                "WHERE ItemID=" + itemID + " AND UserID='" + userID + "'";

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(queryUpdate, conn);


            //Check first if the category number is existing.
            bool id_exists = check_id_ifexists(itemID);
            if (!id_exists)
            {
                //Displays message, if the cart item doesn't exist.
                MessageBox.Show("Item doesn't exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Not updated successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            conn.Close();
            LoadGridView(); //To update the contents of the grid view.
            
        }

        private void btn_remove_item_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(con);
            string queryDelete = "DELETE FROM Cart WHERE ItemID=" + itemID + " AND UserID='" + userID + "'";

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

            lbl_item.Text = "";
            lbl_category.Text = "";
            lbl_price.Text = "";
            lbl_size.Text = "";
            lbl_color.Text = "";
            num_quantity.Value = 1;
            num_quantity.Enabled = false;
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout();
            this.Hide();
            checkout.Show();
            checkout.lbl_total.Text = grandTotal.ToString();
        }
    }
}
