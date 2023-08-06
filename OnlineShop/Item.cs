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
    public partial class Item : Form
    {
        string con = ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;

        public Item()
        {
            InitializeComponent();
        }

        private void LoadGridView()
        {
            MySqlConnection conn = new MySqlConnection(con);

            string cmd = "SELECT Item.Id AS Id, Item.Name AS Item, Category.Name AS Category, SellingPrice, Size, Color, Visible " +
                " FROM Item, Category " +
                " WHERE Item.CategoryId = Category.Id " +
                " ORDER BY Item.Id";

            MySqlDataAdapter da = new MySqlDataAdapter(cmd, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Category");

            dgv_list.DataSource = ds.Tables["Category"].DefaultView;
        }

        private bool check_item_ifexists(string id)
        {
            MySqlConnection conn = new MySqlConnection(con);
            string selectQuery = "SELECT * FROM Item WHERE Id = '" + id + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(selectQuery, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Item");

            //If there is no record, returns false.
            int row = ds.Tables["Item"].Rows.Count;
            if (row <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void lbl_back_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Hide();
            admin.Show();
        }

        private void Item_Load(object sender, EventArgs e)
        {
            //Loads Item table on the grid view.
            LoadGridView();

            //Loads all Category in the combo box
            MySqlConnection conn = new MySqlConnection(con);
            string cmd = "SELECT Name FROM Category ORDER BY Id";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Category");
            foreach (DataRow row in ds.Tables["Category"].Rows)
            {
                cmb_category.Items.Add(row["Name"].ToString());
            }
        }

        private void dgv_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //When a cell is clicked, displays the selected rows on the text boxes.
            txt_name.Text = dgv_list.SelectedRows[0].Cells[1].Value.ToString();
            cmb_category.Text = dgv_list.SelectedRows[0].Cells[2].Value.ToString();
            txt_price.Text = dgv_list.SelectedRows[0].Cells[3].Value.ToString();
            txt_size.Text = dgv_list.SelectedRows[0].Cells[4].Value.ToString();
            txt_color.Text = dgv_list.SelectedRows[0].Cells[5].Value.ToString();
            
            string visible = dgv_list.SelectedRows[0].Cells[6].Value.ToString();
            string status;
            if(visible == "Yes")
            {
                status = "Posted";
            }
            else
            {
                status = "Hidden";
            }
            cmb_status.Text = status;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string id = dgv_list.SelectedRows[0].Cells[0].Value.ToString();
            string name = txt_name.Text;
            string category = (string)cmb_category.SelectedItem;
            string categoryId = (cmb_category.SelectedIndex + 1).ToString();
            //Checks if the category is not on the set of categories.
            if (category == null)
            {
                MessageBox.Show("Please select from the set of categories.", "Incomplete Detail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            string price = txt_price.Text;
            string size = txt_size.Text;
            string color = txt_color.Text;
            string posted = (string)cmb_status.SelectedItem;
            //Checks if the status is not on the options.
            if (posted == null)
            {
                MessageBox.Show("Please select from the set of item status.", "Incomplete Detail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            string visible;
            if (posted == "Posted")
            {
                visible = "Yes";
            }
            else
            {
                visible = "No";
            }

            //Checks first if a textbox is empty.
            if (name == "" || price == "")
            {
                MessageBox.Show("Please complete all required fields.", "Incomplete Detail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MySqlConnection conn = new MySqlConnection(con);
                string queryUpdate = "UPDATE Item SET Name='" + name + "', " +
                    " CategoryId=" + categoryId + "," +
                    " SellingPrice=" + price + "," +
                    " Size='" + size + "'," +
                    " Color='" + color + "'," +
                    " Visible='" + visible + "'" +
                    " WHERE Id=" + id + "";

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(queryUpdate, conn);


                //Check first if the category number is existing.
                bool id_exists = check_item_ifexists(id);
                if (!id_exists)
                {
                    //Displays message, if the category number doesn't exist.
                    MessageBox.Show("Item Id doesn't exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Item is successfully updated.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch(Exception err)
                    {
                        MessageBox.Show("Item is not updated successfully: "+ err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                conn.Close();
                LoadGridView(); //To update the contents of the grid view.
                txt_name.Text = ""; //Clears textbox.
                cmb_category.Text = "";
                txt_size.Text = "";
                txt_color.Text = "";
                txt_price.Text = "";
                cmb_status.Text = "";
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string category = (string)cmb_category.SelectedItem;
            string categoryId = (cmb_category.SelectedIndex + 1).ToString();
            //Checks if the category is not on the set of categories.
            if (category == null)
            {
                MessageBox.Show("Please select from the set of categories.", "Incomplete Detail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            string price = txt_price.Text;
            string size = txt_size.Text;
            string color = txt_color.Text;
            string posted = (string)cmb_status.SelectedItem;
            //Checks if the status is not on the options.
            if (posted == null)
            {
                MessageBox.Show("Please select from the set of item status.", "Incomplete Detail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            string visible;
            if (posted == "Posted")
            {
                visible = "Yes";
            }
            else
            {
                visible = "No";
            }


            //Checks first if a textbox is empty.
            if (name == "" || price == "")
            {
                MessageBox.Show("Please complete all required fields.", "Incomplete Detail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MySqlConnection conn = new MySqlConnection(con);
                string queryInsert = "INSERT INTO Item(Name, CategoryId, SellingPrice, Size, Color, Visible) " +
                    " VALUES('" + name + "', " + categoryId + ", " + price + ", '" + size + "', '" + color + "', '" + visible + "')";

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(queryInsert, conn);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item is successfully added.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    //Displays message when the entered category number already exists.
                    MessageBox.Show("Item already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                conn.Close();
                LoadGridView(); //To add the inserted record on the grid view.
                txt_name.Text = ""; //Clears textbox.
                cmb_category.Text = "";
                txt_size.Text = "";
                txt_color.Text = "";
                txt_price.Text = "";
                cmb_status.Text = "";
            }
        }
    }
}
