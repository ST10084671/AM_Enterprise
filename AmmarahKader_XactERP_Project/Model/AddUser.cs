using AmmarahKader_XactERP_Project.Database;
using AmmarahKader_XactERP_Project.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmmarahKader_XactERP_Project.Model
{
    public partial class AddUser : Sample
    {
        // Creating an object of the Users class
        User us = new User();

        // Creating an object of the UsersList class
        UserList ul = new UserList();

        // Creating an object of the Database context
        DatabaseContext databaseContext = new DatabaseContext();

        // Declaring variables
        public BindingSource bindingSource;
        private BindingSource sourceName;


        public AddUser(BindingSource sourceName)
        {
            InitializeComponent();
            this.bindingSource = sourceName;

        }
        static string Encrypt(string value)
        {
            //Using MD5 to encrypt a string
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                //Hash data
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }

        private void User_Load(object sender, EventArgs e)
        {
            
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            // Clears the text in this field
            NameTB.Clear();
            // Clears the text in this field
            SurnameTB.Clear();
            // Clears the text in this field
            EmailAddressTB.Clear();
            // Clears the text in this field
            ContactNumberTB.Clear();
            // Clears the text in this field
            UsernameTB.Clear();
            // Clears the text in this field
            PasswordTB.Clear();
            // Clears the text in this field
            ConfirmPasswordTB.Clear();
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // Inserting the entry into the databse 

            // If validation to make sure none of the fields are blank when entering details
            if (NameTB.Text.Length == 0 || SurnameTB.Text.Length == 0 || EmailAddressTB.Text.Length == 0 || ContactNumberTB.Text.Length == 0 || UsernameTB.Text.Length == 0 || PasswordTB.Text.Length == 0 || ConfirmPasswordTB.Text.Length == 0)
            {
                MessageBox.Show("Fields cannot be blank", "AM Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // If the password matches the confirm password then the following occurs
                if (PasswordTB.Text == ConfirmPasswordTB.Text)
                {
                    // Making the variable equal to the value from the textbox
                    us.uName = NameTB.Text;
                    // Making the variable equal to the value from the textbox
                    us.uSurname = SurnameTB.Text;
                    // Making the variable equal to the value from the textbox
                    us.uEmailAddress = EmailAddressTB.Text;
                    // Making the variable equal to the value from the textbox
                    us.uContactNumber = ContactNumberTB.Text;
                    // Making the variable equal to the value from the textbox
                    us.uUsername = UsernameTB.Text;
                    // Making the variable equal to the value from the textbox
                    us.uPassword = Encrypt(PasswordTB.Text);
                    // Making the variable equal to the value from the textbox
                    us.uConfirmPassword = Encrypt(ConfirmPasswordTB.Text);


                    // Pass the data into the DB
                    databaseContext.Users.Add(us);

                    // Insert it into table
                    int res = databaseContext.SaveChanges();

                    // If statement
                    if (res > 0)
                    {
                        // Message box will pop up depending on he result
                        MessageBox.Show("Data added successfully", "AM Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("User was unsuccessful! \nPlease Try Again", "AM Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match\nPlease try again!!!", "AM Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } 
                UserList ul = new UserList();
                    foreach (DataGridViewRow drv in ul.UserDataGridView.Rows)
                    {
                        DataRowView dataRow = (DataRowView)this.bindingSource.AddNew();
                        dataRow[1] = this.NameTB.Text;
                        dataRow[2] = this.SurnameTB.Text;
                        dataRow[3] = this.EmailAddressTB.Text;
                        dataRow[4] = this.ContactNumberTB.Text;
                        dataRow[5] = this.UsernameTB.Text;
                        dataRow.EndEdit();
                        ul.UserDataGridView.DataSource = databaseContext.Users.ToList<User>();
                    }
                    ul.UserDataGridView.DataSource = databaseContext.Users.ToList<User>();

                    // Clears the text in this field
                    NameTB.Clear();
                    // Clears the text in this field
                    SurnameTB.Clear();
                    // Clears the text in this field
                    EmailAddressTB.Clear();
                    // Clears the text in this field
                    ContactNumberTB.Clear();
                    // Clears the text in this field
                    UsernameTB.Clear();
                    // Clears the text in this field
                    PasswordTB.Clear();
                    // Clears the text in this field
                    ConfirmPasswordTB.Clear();
                }
            }
        
        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Make password look like this
            PasswordTB.PasswordChar = guna2CheckBox1.Checked ? '\0' : '*';
        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            // Make confirm password look like this
            ConfirmPasswordTB.PasswordChar = guna2CheckBox1.Checked ? '\0' : '*';
        }
    }
}
