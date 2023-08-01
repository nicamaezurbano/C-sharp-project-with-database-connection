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
    public partial class Category : Form
    {
        string con = ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;

        public Category()
        {
            InitializeComponent();
        }

        private void LoadGridView()
        {
            MySqlConnection conn = new MySqlConnection(con);

            string cmd = "SELECT * FROM Category ORDER BY Id";

            MySqlDataAdapter da = new MySqlDataAdapter(cmd, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Category");

            dgv_list.DataSource = ds.Tables["Category"].DefaultView;
        }

        private bool check_categoryNum_ifexists(string id)
        {
            MySqlConnection conn = new MySqlConnection(con);
            string selectQuery = "SELECT * FROM Category WHERE Id = '" + id + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(selectQuery, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Category");


            //If there is no record, returns false.
            int row = ds.Tables["Category"].Rows.Count;
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

        private void Category_Load(object sender, EventArgs e)
        {
            //Loads Category table on the grid view.
            LoadGridView();
        }

        private void dgv_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //When a cell is clicked, displays the selected rows on the text boxes.
            txt_name.Text = dgv_list.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string id = dgv_list.SelectedRows[0].Cells[0].Value.ToString();
            string name = txt_name.Text;

            //Checks first if a textbox is empty.
            if (name == "")
            {
                MessageBox.Show("Please enter the category.", "Incomplete Detail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MySqlConnection conn = new MySqlConnection(con);
                string queryUpdate = "UPDATE Category SET Name='" + name + "' WHERE Id=" + id + "";

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(queryUpdate, conn);


                //Check first if the category number is existing.
                bool id_exists = check_categoryNum_ifexists(id);
                if (!id_exists)
                {
                    //Displays message, if the category number doesn't exist.
                    MessageBox.Show("Category number doesn't exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Category is successfully updated.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Category is not updated successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                conn.Close();
                LoadGridView(); //To update the contents of the grid view.
                txt_name.Text = ""; //Clears textbox.
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;


            //Checks first if a textbox is empty.
            if (name == "")
            {
                //Displays message, if there is blank textbox.
                MessageBox.Show("Please enter the category.", "Incomplete Detail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MySqlConnection conn = new MySqlConnection(con);
                string queryInsert = "INSERT INTO Category(Name) VALUES('" + name + "')";

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(queryInsert, conn);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category is successfully added.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    //Displays message when the entered category number already exists.
                    MessageBox.Show("Category already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                conn.Close();
                LoadGridView(); //To add the inserted record on the grid view.
                txt_name.Text = ""; //Clears textbox.
            }
        }
    }
}
