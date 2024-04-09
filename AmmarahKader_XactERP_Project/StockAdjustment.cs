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
    public partial class StockAdjustment : Sample
    {
        // Creating an object of the Stock class
        Stock us = new Stock();

        // Creating an object of the StockList class
        StockList ul = new StockList();

        // Creating an object of the Database context
        DatabaseContext databaseContext = new DatabaseContext();

        // Declaring an sql connection
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=AM-Enterprise-Program;Integrated Security=True");

        SqlCommand cmd;

        public StockAdjustment()
        {
            InitializeComponent();
        }

        private void StockAdjustment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_AM_Enterprise_ProgramDataSet.Stocks' table. You can move, or remove it, as needed.
            this.stocksTableAdapter.Fill(this._AM_Enterprise_ProgramDataSet.Stocks);
            
            ul.StockListDataGridView.DataSource = databaseContext.Stocks.ToList<Stock>();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (NewStockTB.Text.Length == 0)
                {
                    MessageBox.Show("Fields cannot be blank!", "AM Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Open the connection
                    con.Open();

                    // Calculations
                    string newStockAmnt = (Convert.ToInt32(StockOnHandTB.Text) + Convert.ToInt32(NewStockTB.Text)).ToString();
                    string newQtyPurchased = (Convert.ToInt32(QtyPurchasedTB.Text) + Convert.ToInt32(NewStockTB.Text)).ToString();

                    // Sql query to update the data in the dabatse
                    cmd = new SqlCommand("Update Stocks set sDescriptionOne='" + DescriptionOneTB.Text + "', sDescriptionTwo='" + DescriptionTwoTB.Text + "', sCategory='" + CategoryCB.Text +
                        "', sOnHand=" + newStockAmnt + ", sQtyPurchased=" + newQtyPurchased + " where sCode = '" + StockCodeCB.Text + "';", con);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Stock Amended Successfully", "AM Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Closes the connection 
                    con.Close();

                    // Updates the data gid view
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

        private void StockOnHandTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void StockCodeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Connection string
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=AM-Enterprise-Program;Integrated Security=True");

            // Sql query 
            string sql = "select sCode, sDescriptionOne, sDescriptionTwo, sCategory, sQtyPurchased, sOnHand from Stocks where sCode = '" + StockCodeCB.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                // Open the connection string 
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    // Assign a variable to each text box value that needs to be added
                    var stockcode = myreader.GetString(0);
                    var descriptionone = myreader.GetString(1);
                    var descriptiontwo = myreader.GetString(2);
                    var category = myreader.GetString(3);
                    int qtypurchased = myreader.GetInt32(4);
                    int stockonhand = myreader.GetInt32(5);

                    // Adds the value to the text boxes
                    StockCodeCB.Text = stockcode;
                    DescriptionOneTB.Text = descriptionone;
                    DescriptionTwoTB.Text = descriptiontwo;
                    CategoryCB.Text = category;
                    QtyPurchasedTB.Text = qtypurchased.ToString();
                    StockOnHandTB.Text = stockonhand.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
