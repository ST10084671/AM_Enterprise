using AmmarahKader_XactERP_Project.Database;
using AmmarahKader_XactERP_Project.View;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmmarahKader_XactERP_Project.Model
{
    public partial class AddInvoice : Sample
    {
        private static int visitCounter = 0; // Common to all Form1
        // Creating an object of the Users class
        Invoice us = new Invoice();

        Stock st = new Stock();
        StockList stkl = new StockList();   
        DebtorList debl = new DebtorList();

        Debtor det = new Debtor();

        // Creating an object of the UsersList class
        InvoiceList ul = new InvoiceList();

        // Creating an object of the Database context
        DatabaseContext databaseContext = new DatabaseContext();

        // Declaring variables
        public BindingSource bindingSource;
        private BindingSource sourceName;
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=AM-Enterprise-Program;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;

        Datalayer dl;
        public AddInvoice(BindingSource sourceName)
        {
           // dl = new DataLayer();
            InitializeComponent();
            this.bindingSource = sourceName;
            StockCodeCB.SelectedIndex = -1;
            AccountCodeCB.SelectedIndex = -1;
        } 

        private void AddInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_AM_Enterprise_ProgramDataSet.Stocks' table. You can move, or remove it, as needed.
            this.stocksTableAdapter.Fill(this._AM_Enterprise_ProgramDataSet.Stocks);
            // TODO: This line of code loads data into the '_AM_Enterprise_ProgramDataSet.Debtors' table. You can move, or remove it, as needed.
            this.debtorsTableAdapter.Fill(this._AM_Enterprise_ProgramDataSet.Debtors);

            StockCodeCB.SelectedIndex = -1;
            AccountCodeCB.SelectedIndex = -1;

            visitCounter++; // Increase each time a form is loaded
            TotalSalesTB.Text = visitCounter.ToString("0"); // Format the counter

        }

        public void fillcombobox()
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=AM-Enterprise-Program;Integrated Security=True");
            string sql = "select * from Debtors";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader= cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(1);
                    AccountCodeCB.Items.Add(sname);
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

        private void DescriptionOneTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccountCodeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=AM-Enterprise-Program;Integrated Security=True");
            string sql = "select dSalesYearToDte, dCostYearToDate, dBalance from Debtors where dAccountCode = '" + AccountCodeCB.Text+"';";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                   Decimal totalsales = myreader.GetDecimal(0);
                   Decimal totalcost = myreader.GetDecimal(1);
                   Decimal balance = myreader.GetDecimal(2);
                   TotalSalesTB.Text = totalsales.ToString();
                   TotalSalesCostTB.Text = totalcost.ToString();
                   BalanceTB.Text = balance.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StockCodeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=AM-Enterprise-Program;Integrated Security=True");
            string sql = "select sCostPrice, sSellingPrice, sOnHand, sQtySold from Stocks where sCode = '" + StockCodeCB.Text+"';";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    Decimal unitcost = myreader.GetDecimal(0);
                    Decimal unitsell = myreader.GetDecimal(1);
                    int stockonhandold = myreader.GetInt32(2);
                    int oldqtysold = myreader.GetInt32(3);
                    UnitCostTB.Text = unitcost.ToString();
                    UnitSellTB.Text = unitsell.ToString();
                    StockOnHandTB.Text = stockonhandold.ToString();
                    OldQtySoldTB.Text = oldqtysold.ToString();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // Inserting the entry into the database
            if (AccountCodeCB.Text.Length == 0 || DateTB.Text.Length == 0 || TotalSellAmtTB.Text.Length == 0 || VatTB.Text.Length == 0 || TotalCostTB.Text.Length == 0 || InvNumberTB.Text.Length == 0 || ItemNumberTB.Text.Length == 0 || StockCodeCB.Text.Length == 0 || QtySoldTB.Text.Length == 0 || UnitCostTB.Text.Length == 0 || UnitSellTB.Text.Length == 0 || DiscountAmtTB.Text.Length == 0 || TotalTB.Text.Length == 0 || TransactionTypeCB.Text.Length == 0 || DocumentNumberTB.Text.Length == 0)
            {
                MessageBox.Show("Fields cannot be blank", "AM Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
            // Making the variable equal to the value from the textbox
            us.iAccountCode = AccountCodeCB.Text;
            // Making the variable equal to the value from the textbox
            us.iDate = DateTime.Parse(DateTB.Text);
            // Making the variable equal to the value from the textbox
            us.iTotalSell = TotalSellAmtTB.Text;
            // Making the variable equal to the value from the textbox
            us.iVat = VatTB.Text;
            // Making the variable equal to the value from the textbox
            us.iNumber = InvNumberTB.Text;
            // Making the variable equal to the value from the textbox
            us.iItemNumber = ItemNumberTB.Text;
            // Making the variable equal to the value from the textbox
            us.iStockCode = StockCodeCB.Text;
            // Making the variable equal to the value from the textbox
            us.iQtySold = Int32.Parse(QtySoldTB.Text);
            // Making the variable equal to the value from the textbox
            us.iUnitCost = Decimal.Parse(UnitCostTB.Text);
            // Making the variable equal to the value from the textbox
            us.iUnitSell = Decimal.Parse(UnitSellTB.Text);
            // Making the variable equal to the value from the textbox
            us.iDiscount = Decimal.Parse(DiscountAmtTB.Text);
            // Making the variable equal to the value from the textbox
            us.iTotal = Decimal.Parse(TotalTB.Text);
            // Making the variable equal to the value from the textbox
            us.iTransactionType = TransactionTypeCB.Text;
            // Making the variable equal to the value from the textbox
            us.iDocumentNumber = DocumentNumberTB.Text;

            // Pass the data into the DB
            databaseContext.Invoices.Add(us);

            // Insert it into table
            int res = databaseContext.SaveChanges();

            // If statement
            if (res > 0)
            {
                // Message box will pop up depending on he result
                MessageBox.Show("Invoice Created Successfully", "AM Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Open();

                string newsold = (Convert.ToInt32(OldQtySoldTB.Text) + Convert.ToInt32(QtySoldTB.Text)).ToString();
                string newonhand = (Convert.ToInt32(StockOnHandTB.Text) - Convert.ToInt32(QtySoldTB.Text)).ToString();

                cmd = new SqlCommand("Update Stocks set sQtySold=" + newsold + ", sOnHand=" + newonhand + " where sCode = '" + StockCodeCB.Text + "';", con);

                cmd.ExecuteNonQuery();
                con.Close();

                con.Open();

                string newbalance = (Convert.ToDecimal(BalanceTB.Text) + Convert.ToDecimal(TotalCostTB.Text)).ToString();
                string newsalesyear = (Convert.ToDecimal(TotalSalesTB.Text) + Convert.ToDecimal(TotalCostTB.Text)).ToString();
                string newcostyear = (Convert.ToDecimal(TotalSalesCostTB.Text) + Convert.ToDecimal(UnitCostTB.Text)).ToString();

                cmd = new SqlCommand("Update Debtors set dBalance=" + newbalance.ToString().Replace(",", ".")  + ", dSalesYearToDte=" + newsalesyear.ToString().Replace(",", ".")  + ", dCostYearToDate=" + newcostyear.ToString().Replace(",", ".")  + " where dAccountCode = '" + AccountCodeCB.Text + "';", con);

                cmd.ExecuteNonQuery();
                con.Close();
                stkl.StockListDataGridView.DataSource = databaseContext.Stocks.ToList<Stock>();
                debl.DebtorListDataGridView.DataSource = databaseContext.Debtors.ToList<Debtor>();

            }
            foreach (DataGridViewRow drv in ul.InvoiceDataGridView.Rows)
            {
                DataRowView dataRow = (DataRowView)this.bindingSource.AddNew();
                dataRow[1] = this.AccountCodeCB.Text;
                dataRow[2] = this.DateTB.Text;
                dataRow[3] = this.TotalSellAmtTB.Text;
                dataRow[4] = this.VatTB.Text;
                dataRow[5] = this.InvNumberTB.Text;
                dataRow[6] = this.ItemNumberTB.Text;
                dataRow[7] = this.StockCodeCB.Text;
                dataRow[8] = this.QtySoldTB.Text;
                dataRow[9] = this.UnitCostTB.Text;
                dataRow[10] = this.UnitSellTB.Text;
                dataRow[11] = this.DiscountAmtTB.Text;
                dataRow[12] = this.TotalCostTB.Text;
                dataRow.EndEdit();

                ul.InvoiceDataGridView.DataSource = databaseContext.Invoices.ToList<Invoice>();
            }
            ul.InvoiceDataGridView.DataSource = databaseContext.Invoices.ToList<Invoice>();

        }
}
        private void ClearBtn_Click(object sender, EventArgs e)
        {

        }

        private void TotalTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            // Calculations for the amounts
            decimal discount = Decimal.Parse(DiscountAmtTB.Text) / 100;
            decimal discountedamount = Decimal.Parse(UnitSellTB.Text) * discount;
            decimal amtafterdiscount = (Decimal.Parse(UnitSellTB.Text) - discountedamount) * Int32.Parse(QtySoldTB.Text);

            decimal vat = 0.14m;

            TotalTB.Text = Math.Round(amtafterdiscount, 2).ToString();
            TotalSellAmtTB.Text = Math.Round(amtafterdiscount, 2).ToString();
            decimal amountaftervat = Decimal.Parse(TotalTB.Text) * vat;
            VatTB.Text = Math.Round(amountaftervat, 2).ToString();
            TotalCostTB.Text = Math.Round((Convert.ToDecimal(amountaftervat) + Convert.ToDecimal(amtafterdiscount)), 2).ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void QtySoldTB_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (!string.IsNullOrEmpty(QtySoldTB.Text) &&
                 !int.TryParse(QtySoldTB.Text, out i)
              )
            {
                MessageBox.Show("Enter valid quantity sold amount", "AM Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DiscountAmtTB_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (!string.IsNullOrEmpty(DiscountAmtTB.Text) &&
                 !int.TryParse(DiscountAmtTB.Text, out i)
              )
            {
                MessageBox.Show("Enter valid discount amount", "AM Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
