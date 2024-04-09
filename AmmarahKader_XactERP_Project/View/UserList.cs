using AmmarahKader_XactERP_Project.Database;
using AmmarahKader_XactERP_Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmmarahKader_XactERP_Project.View
{
    public partial class UserList : Sample
    {
        // Creating an object of the User class
        User us = new User();

        // Creating an object of the Database context
        DatabaseContext databaseContext = new DatabaseContext();

        // Declaring variables
        private BindingSource sourceName;

        public UserList()
        {
            InitializeComponent();
            // Data drig view
            this.usersTableAdapter.Fill(this._AM_Enterprise_ProgramDataSet.Users);
            UserDataGridView.DataSource = databaseContext.Users.ToList<User>();
        }

        private void User_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this._AM_Enterprise_ProgramDataSet.Users);
            // Data grid view on load
            UserDataGridView.DataSource = databaseContext.Users.ToList<User>();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            // Redirects you to the add new screen
            new AddUser(sourceName).Show();
            using (AddUser addUser = new AddUser(this.usersBindingSource))
            {
                addUser.ShowDialog();
            }
            this.Validate();
            this.usersBindingSource.EndEdit();
        }

        private void UserDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserDataGridView_DoubleClick(object sender, EventArgs e)
        {

        }

        private void UserDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sql connection string
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AM-Enterprise-Program;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            if (SearchTB.Text != "")
            {
                // Updating the data drid view to show the data 
                UserDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                SqlDataAdapter adap = new SqlDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                // Sql query to show only specific values
                string command = "Select * From Users Where uName like '%" + SearchTB.Text + "%';";

                con.Open();
                adap = new SqlDataAdapter(command, con);
                adap.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                UserDataGridView.DataSource = dv;
                con.Close();

            }
            else
            {
                UserDataGridView.Refresh();
            }
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            // Refreshes the data grid view
            UserDataGridView.DataSource = databaseContext.Users.ToList<User>();
            SearchTB.Clear();
        }

        private void UserDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
}
