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
    public partial class Register : Form
    {
        string con = ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;


        public Register()
        {
            InitializeComponent();
        }

        private void txtBox_password_TextChanged(object sender, EventArgs e)
        {
            txtBox_password.PasswordChar = '*';
        }

        private void ck_showPass_CheckedChanged(object sender, EventArgs e)
        {
            txtBox_password.PasswordChar = ck_showPass.Checked ? '\0' : '*';
        }

        private void lbl_login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            //When a text field is blanked, displays a message.
            if ((txtBox_fname.Text == "") || (txtBox_lname.Text == "") || (txtBox_contact.Text == "") ||
                (txtBox_email.Text == "") || (txtBox_barangay.Text == "") || (txtBox_municipality.Text == "") ||
                (txtBox_povince.Text == "") || (txtBox_password.Text == ""))
            {
                MessageBox.Show("Please complete all fields to proceed.", "Incomplete Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string email = txtBox_email.Text;
                string pass = txtBox_password.Text;
                string fname = txtBox_fname.Text;
                string lname = txtBox_lname.Text;
                string contact = txtBox_contact.Text;
                string brgy = txtBox_barangay.Text;
                string municipality = txtBox_municipality.Text;
                string province = txtBox_povince.Text;

                MySqlConnection conn = new MySqlConnection(con);
                conn.Open();

                //Inserting the record to user table.
                string query = "INSERT INTO User(Email, Password, FirstName, LastName, ContactNumber, Barangay, Municipality, Province, Type) " +
                    "VALUES ('" + email + "','" + pass + "','" + fname + "','" + lname + "','" + contact + "','" + brgy + "','" + municipality + "','" + province + "','Customer')";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                try
                {
                    //When record is added, displays a message.
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account created successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //After the the user is registered, displays again the login form.
                    Login login = new Login();
                    this.Hide();
                    login.Show();
                }
                catch(Exception err)
                {
                    //When record is not added, displays a message.
                    MessageBox.Show("Email already exists.: "+ err, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
                conn.Close();
            }
        }
    }
}
