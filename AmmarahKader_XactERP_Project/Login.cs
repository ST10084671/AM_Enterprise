using AmmarahKader_XactERP_Project.Database;
using AmmarahKader_XactERP_Project.View;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace AmmarahKader_XactERP_Project
{
    public partial class Login : Sample
    {
        SqlConnection connection; // Creating object of the SqlConnection

        SqlCommand cmd; // Creating object of the SqlCommand

        SqlDataReader reader; // Creating object of the SqlReader

        User ul = new User();

        static string strcon = ConfigurationManager.ConnectionStrings["DatabaseContext"].ConnectionString; // Creating object of the Connection string in the app config

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        static string Encrypt(string value)
        {
            // Using MDS to encrypt a string
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                // Creating an object
                UTF8Encoding utf8 = new UTF8Encoding();

                // Hashing the data
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));

                // Returning the hashed code
                return Convert.ToBase64String(data);
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            // Try/Catch statement put into place for exception handling
            try
            {
                // If validation to make sure none of the fields are blank when entering details
                if (UsernameTB.Text.Length == 0 || PasswordTB.Text.Length == 0)
                {
                    MessageBox.Show("Fields cannot be blank", "AM Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    connection = new SqlConnection(strcon);

                    // Open the connection
                    connection.Open();

                    // Sql Query to see if the entered username and password matched the details of a registered user
                    cmd = new SqlCommand("Select * from Users where uUsername = '" + UsernameTB.Text + "' AND uPassword = '" + Encrypt(PasswordTB.Text) + "'", connection);

                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if (reader["uPassword"].ToString() == Encrypt(PasswordTB.Text)) // If the passwords match
                        {
                           ul.uUsername  = UsernameTB.Text; // Pulling the variable from the StoreUser class and assigning it to the logged in user to create a unique identification

                            MessageBox.Show("Welcome " + ul.uUsername + "!", "AM Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Redirects you to the main page
                            new Main().Show();
                            this.Hide();
                            // Close the connection
                            connection.Close();
                        }
                    }
                    // If the user account does not exists this will show up
                    else
                    {
                        MessageBox.Show("Invalid credentials!!\nPlease try again", "AM Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //finally
            //{
            //    reader.Close();

            //    // Close the connection
            //    connection.Close();
            //}
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Makes the password show this character
            PasswordTB.PasswordChar = guna2CheckBox1.Checked ? '\0' : '*';
        }
    }
}
