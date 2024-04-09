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

namespace AmmarahKader_XactERP_Project.View
{
    public partial class TransactionStock : Sample
    {
        // Creating an object of the Stock class
        Stock us = new Stock();

        // Creating an object of the StockList class
        StockList ul = new StockList();

        // Creating an object of the Database context
        DatabaseContext databaseContext = new DatabaseContext();

        // Sql Connection string
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=AM-Enterprise-Program;Integrated Security=True");
        SqlCommand cmd;

        public TransactionStock()
        {
            InitializeComponent();
        }

        private void TransactionStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_AM_Enterprise_ProgramDataSet.Stocks' table. You can move, or remove it, as needed.
            this.stocksTableAdapter.Fill(this._AM_Enterprise_ProgramDataSet.Stocks);

        }

        private void ExitBtn_Click_1(object sender, EventArgs e)
        {
            // Closes the program
            this.Close();
        }

        private void FilterBtn_Click_1(object sender, EventArgs e)
        {
            // Filter button to show the quantity sold in decreasing order
            invoicesBindingSource.DataSource = StockTransactionDataGridView.DataSource;
            invoicesBindingSource.Sort = "iQtySold Desc";
            StockTransactionDataGridView.DataSource = invoicesBindingSource;
        }

        private void SelectStockCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Sql connection sctring
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AM-Enterprise-Program;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            if (SelectStockCB.SelectedIndex != null)
            {
                StockTransactionDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                SqlDataAdapter adap = new SqlDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                // Selects all data that falls within 
                string command = "Select * From Invoices Where iStockCode = '" + SelectStockCB.Text + "';";

                con.Open();
                adap = new SqlDataAdapter(command, con);
                adap.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                StockTransactionDataGridView.DataSource = dv;
                con.Close();

            }
            else
            {
                StockTransactionDataGridView.Refresh();
            }
        }
    }
}
