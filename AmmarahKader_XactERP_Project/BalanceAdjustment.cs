using AmmarahKader_XactERP_Project.Database;
using AmmarahKader_XactERP_Project.View;
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

namespace AmmarahKader_XactERP_Project
{
    public partial class BalanceAdjustment : Sample
    {
        // Creating an object of the Stock class
        Stock us = new Stock();

        // Creating an object of the StockList class
        StockList ul = new StockList();

        // Creating an object of the Database context
        DatabaseContext databaseContext = new DatabaseContext();

        // Declaring the connection string
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=AM-Enterprise-Program;Integrated Security=True");
       
        SqlCommand cmd;
       
        // Creating an object of the Debtors class
        Debtor deb = new Debtor();

        // Creating an object of the DebtorList class
        DebtorList debl = new DebtorList();

        // Declaring variables
        public BindingSource bindingSource;
        private BindingSource sourceName;

        public BalanceAdjustment()
        {
            InitializeComponent();
        }

        private void BalanceAdjustment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_AM_Enterprise_ProgramDataSet.Debtors' table. You can move, or remove it, as needed.
            this.debtorsTableAdapter.Fill(this._AM_Enterprise_ProgramDataSet.Debtors);

            debl.DebtorListDataGridView.DataSource = databaseContext.Debtors.ToList<Debtor>();

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // If validation to make sure none of the fields are blank when entering details
                if (NewBalanceTB.Text.Length == 0)
                {
                    MessageBox.Show("Fields cannot be blank", "AM Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    con.Open();

                    // Calculations
                    string newbalance = (Convert.ToDecimal(BalanceTB.Text) - Convert.ToDecimal(NewBalanceTB.Text)).ToString();

                    // Sql query to update the database table
                    cmd = new SqlCommand("Update Debtors set dBalance=" + newbalance.ToString().Replace(",", ".") + " where dAccountCode = '" + AccountCodeCB.Text + "';", con);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Balance Amended Successfully", "AM Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Close the connection
                    con.Close();

                    debl.DebtorListDataGridView.DataSource = databaseContext.Debtors.ToList<Debtor>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void AccountCodeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Connection string
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=AM-Enterprise-Program;Integrated Security=True");

            // Sql query
            string sql = "select dAccountCode, dSalesYearToDte, dBalance from Debtors where dAccountCode = '" + AccountCodeCB.Text + "';";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    // declaring variable to act as a temp variale
                    var accountcode = myreader.GetString(0);
                    decimal salesyear = myreader.GetDecimal(1);
                    decimal balance = myreader.GetDecimal(2);

                    // Setting the temp varible to equal the value of the text box
                    AccountCodeCB.Text = accountcode;
                    SalesYearTB.Text = salesyear.ToString();
                    BalanceTB.Text = balance.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
