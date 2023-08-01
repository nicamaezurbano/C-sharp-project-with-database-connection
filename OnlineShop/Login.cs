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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // Stores the UserID of the user.
        public static int retrieved_userID;

        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = txtBox_email.Text;
            string pass = txtBox_pass.Text;

            //If there is no email and password, displays a message.
            if (email == "" || pass == "")
            {
                MessageBox.Show("Please enter your email and password.", "Incomplete Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                //Getting the user record from the onlineshop database.
                string con = ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
                MySqlConnection conn = new MySqlConnection(con);
                string selectQuery = "SELECT Id, Email, Password, FirstName FROM User WHERE Email = '" + email + "'";
                MySqlDataAdapter da = new MySqlDataAdapter(selectQuery, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "User");

                //If there is no record, displays a message.
                int row = ds.Tables["User"].Rows.Count;
                if (row <= 0)
                {
                    MessageBox.Show("Incorrect email. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Getting the userID, username, and password.
                    retrieved_userID = int.Parse(ds.Tables["User"].Rows[0][0].ToString());
                    string retrieved_email = ds.Tables["User"].Rows[0][1].ToString();
                    string retrieved_password = ds.Tables["User"].Rows[0][2].ToString();
                    string fname = ds.Tables["User"].Rows[0][3].ToString();

                    //If the password doesn't match, displays a message.
                    if (retrieved_password != pass)
                    {
                        MessageBox.Show("Incorrect password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //If the userID is 1, displays the form for admin/owner.
                        if (retrieved_userID == 1)
                        {
                            Admin admin = new Admin();
                            this.Hide();
                            admin.Show();
                            admin.lbl_name.Text = fname;
                        }
                        //Displays the form for customer.
                        else
                        {
                            Customer customer = new Customer();
                            customer.Show();
                            this.Hide();
                            customer.lbl_name.Text = fname;
                        }
                    }
                }
            }
        }

        private void txtBox_pass_TextChanged(object sender, EventArgs e)
        {
            // The password character is an asterisk.
            txtBox_pass.PasswordChar = '*';
        }

        private void ck_showPass_CheckedChanged(object sender, EventArgs e)
        {
            txtBox_pass.PasswordChar = ck_showPass.Checked ? '\0' : '*';
        }

        private void link_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
