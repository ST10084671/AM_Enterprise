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
    public partial class AmendDebtor : Sample
    {
        // Creating an object of the Stock class
        Debtor us = new Debtor();

        // Creating an object of the StockList class
        DebtorList ul = new DebtorList();

        // Creating an object of the Database context
        DatabaseContext databaseContext = new DatabaseContext();

        // Delcaring the connection string
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=AM-Enterprise-Program;Integrated Security=True");
       
        SqlCommand cmd;

        int index;
        public AmendDebtor()
        {
            InitializeComponent();
        }

        private void AmendDebtor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_AM_Enterprise_ProgramDataSet.Debtors' table. You can move, or remove it, as needed.
            this.debtorsTableAdapter.Fill(this._AM_Enterprise_ProgramDataSet.Debtors);

        }

        private void AccountCodeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Connection string
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=AM-Enterprise-Program;Integrated Security=True");
            
            // Sql query to display the values
            string sql = "select dAccountCode, dAddressOne, dAddressTwo, dAddressThree, dCategory, dInvoiceType, dContactNumberOne, dContactNumberTwo, dBalance, dSalesYearToDte, dCostYearToDate, dCreditLimit from Debtors where dAccountCode = '" + AccountCodeCB.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    // Temp values that will be displayed in the text boxes
                    var accountcode = myreader.GetString(0);
                    var addressone = myreader.GetString(1);
                    var addresstwo = myreader.GetString(2);
                    var addressthree = myreader.GetString(3);
                    var category = myreader.GetString(4);
                    var invoicetype = myreader.GetString(5);
                    var contactnumberone = myreader.GetString(6);
                    var contactnumbertwo = myreader.GetString(7);
                    Decimal balance = myreader.GetDecimal(8);
                    Decimal salesyeartodate = myreader.GetDecimal(9);
                    Decimal costyeartodate = myreader.GetDecimal(10);
                    Decimal creditlimit = myreader.GetDecimal(11);

                    // Assigning the text boxes on the page with those temp values
                    AccountCodeCB.Text = accountcode;
                    AddressOneTB.Text = addressone;
                    AddressTwoTB.Text = addresstwo;
                    AddressThreeTB.Text = addressthree;
                    CategoryCB.Text = category;
                    InvoiceTypeCB.Text = invoicetype;
                    ContactOneTB.Text = contactnumberone;
                    ContactTwoTB.Text = contactnumbertwo;
                    BalanceTB.Text = balance.ToString();
                    SalesYearTB.Text = salesyeartodate.ToString();
                    CostYearTB.Text = costyeartodate.ToString();
                    CreditLimitTB.Text = creditlimit.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            // Closes the page
            this.Close();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // If validation to make sure none of the fields are blank when entering details
                if (AccountCodeCB.Text.Length == 0 || AddressOneTB.Text.Length == 0 || AddressTwoTB.Text.Length == 0 || CreditLimitTB.Text.Length == 0 || AddressThreeTB.Text.Length == 0 || CategoryCB.Text.Length == 0 || InvoiceTypeCB.Text.Length == 0 || ContactOneTB.Text.Length == 0 || ContactTwoTB.Text.Length == 0 || SalesYearTB.Text.Length == 0 || CostYearTB.Text.Length == 0 || BalanceTB.Text.Length == 0)
                {
                    MessageBox.Show("Fields cannot be blank", "AM Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Changing the decimal signs, so that it works within the sql query
                    var balance = BalanceTB.Text.ToString().Replace(",", ".");
                    var salesyeartodate = SalesYearTB.Text.ToString().Replace(",", ".");
                    var costyeartodate = CostYearTB.Text.ToString().Replace(",", ".");
                    var creditlimit = CreditLimitTB.Text.ToString().Replace(",", ".");

                    // Open the connection
                    con.Open();

                    // Updating the values in the database with the new updated values
                    cmd = new SqlCommand("Update Debtors set dAddressOne='" + AddressOneTB.Text + "', dAddressTwo='" + AddressTwoTB.Text + "', dAddressThree='" + AddressThreeTB.Text + "', dCategory='" + CategoryCB.Text +
                        "', dInvoiceType='" + InvoiceTypeCB.Text +
                        "', dContactNumberOne='" + ContactOneTB.Text +
                        "', dContactNumberTwo='" + ContactTwoTB.Text +
                        "', dBalance=" + balance +
                        ", dSalesYearToDte=" + salesyeartodate +
                        ", dCostYearToDate=" + costyeartodate +
                        ", dCreditLimit=" + creditlimit + " where dAccountCode = '" + AccountCodeCB.Text + "';", con);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Debtor Amended Successfully", "AM Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (InvoiceTypeCB.SelectedIndex == 1)
                    {
                        // If you choose the option to print the document, this will appear
                        printPreviewDialog1.Document = printDocument1;
                        printPreviewDialog1.ShowDialog();
                    }
                    // Close the connection
                    con.Close();

                    // Update the debtos data grid view
                    ul.DebtorListDataGridView.DataSource = databaseContext.Stocks.ToList<Stock>();
                    ul.DebtorListDataGridView.Refresh();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // If you choose to print the document, this is how the oage will be set up to print
            e.Graphics.DrawString(
                    "Account Code: " + AccountCodeCB.SelectedIndex
                    + "\n" + "Address One: " + AddressOneTB.Text
                    + "\n" + "Address Two: " + AddressTwoTB.Text
                    + "\n" + "Address Three: " + AddressThreeTB.Text
                    + "\n" + "Category: " + CategoryCB.SelectedIndex
                    + "\n" + "Contact One: " + ContactOneTB.Text
                    + "\n" + "Contact Two: " + ContactTwoTB.Text
                    + "\n" + "Balance: " + BalanceTB.Text
                    + "\n" + "Sales Year: " + SalesYearTB. Text
                    + "\n" + "Cost Year: " + CostYearTB.Text
                    + "\n" + "Credit Limit: " + CreditLimitTB.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, 10));
        }
    }
}
