using AmmarahKader_XactERP_Project.Database;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using AmmarahKader_XactERP_Project.View;
using System.Data.Entity;
using ComboBox = System.Windows.Forms.ComboBox;
using MainClass;

namespace AmmarahKader_XactERP_Project
{
    public partial class AmmendStock : Sample
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

        public AmmendStock()
        {
            InitializeComponent();
        }

        private void AmmendStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_AM_Enterprise_ProgramDataSet.Stocks' table. You can move, or remove it, as needed.
            this.stocksTableAdapter.Fill(this._AM_Enterprise_ProgramDataSet.Stocks);

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
  
        }

        private void StockCodeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Connection string
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=AM-Enterprise-Program;Integrated Security=True");

            // Sql query
            string sql = "select sCode, sDescriptionOne, sDescriptionTwo, sCategory, sInvoiceType, sCostPrice, sSellingPrice, sTotalPurchases, sTotalSales, sQtyPurchased, sQtySold, sOnHand from Stocks where sCode = '" + StockCodeCB.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    // Temp variables assign value to 
                    var stockcode = myreader.GetString(0);
                    var descriptionone = myreader.GetString(1);
                    var descriptiontwo = myreader.GetString(2);
                    var category = myreader.GetString(3);
                    var invoicetype = myreader.GetString(4);
                    Decimal costprice = myreader.GetDecimal(5);
                    Decimal sellingprice = myreader.GetDecimal(6);
                    Decimal totalpurchases = myreader.GetDecimal(7);
                    Decimal totalsales = myreader.GetDecimal(8);
                    int qtypurchased = myreader.GetInt32(9);
                    int qtysold = myreader.GetInt32(10);
                    int stockonhand = myreader.GetInt32(11);

                    // Using the tmep variable, the textboxes will use those values
                    StockCodeCB.Text = stockcode;
                    DescriptionOneTB.Text = descriptionone;
                    DescriptionTwoTB.Text = descriptiontwo;
                    CategoryCB.Text = category;
                    InvoiceCB.Text = invoicetype;
                    CostPriceTB.Text = costprice.ToString();
                    SellingPriceTB.Text = sellingprice.ToString();
                    QtyPurchasedTB.Text = qtypurchased.ToString();
                    QtySoldTB.Text = qtysold.ToString();
                    StockOnHandTB.Text = stockonhand.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // If validation to make sure none of the fields are blank when entering details
                if (StockCodeCB.Text.Length == 0 || DescriptionOneTB.Text.Length == 0 || DescriptionTwoTB.Text.Length == 0 || CategoryCB.Text.Length == 0 || InvoiceCB.Text.Length == 0 || CostPriceTB.Text.Length == 0 || SellingPriceTB.Text.Length == 0 || QtyPurchasedTB.Text.Length == 0 || QtySoldTB.Text.Length == 0 || StockOnHandTB.Text.Length == 0)
                {
                    MessageBox.Show("Fields cannot be blank", "AM Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Making the variable equal to the value from the textbox
                    us.sTotalPurchases = Decimal.Parse(CostPriceTB.Text) * Decimal.Parse(QtyPurchasedTB.Text);
                    us.sTotalSales = Decimal.Parse(SellingPriceTB.Text) * Decimal.Parse(QtySoldTB.Text);

                    // Replacing the signs in the decimal values so that it goes through the sql query
                    var sCostPrice = CostPriceTB.Text.ToString().Replace(",", ".");
                    var sSellingPrice = SellingPriceTB.Text.ToString().Replace(",", ".");
                    var sTotalPurchases = us.sTotalPurchases.ToString().Replace(",", ".");
                    var sTotalSales = us.sTotalSales.ToString().Replace(",", ".");

                    // open connection
                    con.Open();

                    // Sql query to update the table
                    cmd = new SqlCommand("Update Stocks set sDescriptionOne='" + DescriptionOneTB.Text + "', sDescriptionTwo='" + DescriptionTwoTB.Text + "', sCategory='" + CategoryCB.Text +
                        "', sInvoiceType='" + InvoiceCB.Text +
                        "', sCostPrice=" + sCostPrice +
                        ", sSellingPrice=" + sSellingPrice +
                        ", sTotalPurchases=" + sTotalPurchases +
                        ", sTotalSales=" + sTotalSales +
                        ", sQtyPurchased=" + QtyPurchasedTB.Text +
                        ", sQtySold=" + QtySoldTB.Text +
                        ", sOnHand=" + StockOnHandTB.Text + " where sCode = '" + StockCodeCB.Text + "';", con);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Stock Amended Successfully", "AM Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (InvoiceCB.SelectedIndex == 1)
                    {
                        // If you selected to print the document, it will print
                        printPreviewDialog1.Document = printDocument1;
                        printPreviewDialog1.ShowDialog();
                    }
                    // Close the connection
                    con.Close();

                    // Updates the data in the data grid view
                    ul.StockListDataGridView.DataSource = databaseContext.Stocks.ToList<Stock>();
                    ul.StockListDataGridView.Refresh();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        private void AddControls(Form F)
        {
            guna2Panel2.Controls.Clear();
            F.TopLevel = false;
            F.Dock = DockStyle.Fill;
            guna2Panel2.Controls.Add(F);
            F.Show();
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AddControls(new StockList());
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // This is how the page will be set up to print
            e.Graphics.DrawString(
                "Stock Code: " + StockCodeCB.SelectedIndex
                + "\n" + "Description One: " + DescriptionOneTB.Text
                + "\n" + "Description Two: " + DescriptionTwoTB.Text
                + "\n" + "Category: " + CategoryCB.SelectedIndex
                + "\n" + "Cost Price: " + CostPriceTB.Text
                + "\n" + "Selling Price: " + SellingPriceTB.Text
                + "\n" + "Total Purchases: " + us.sTotalPurchases
                + "\n" + "Total Sales: " + us.sTotalSales
                + "\n" + "Quantity Purchased: " + QtyPurchasedTB.Text
                + "\n" + "Quantity Sold: " + QtySoldTB.Text
                + "\n" + "Stock On Hand: " + StockOnHandTB.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, 10));
        }
    }
}
