using AmmarahKader_XactERP_Project.Database;
using AmmarahKader_XactERP_Project.Model;
using Guna.UI2.WinForms;
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
    public partial class StockList : Sample
    {
        // Creating an object of the Stock class
        Stock us = new Stock();

        // Creating an object of the Database context
        DatabaseContext databaseContext = new DatabaseContext();

        // Declaring variables
        private BindingSource sourceName;
        Main mn = new Main();
        int id = 0;
       // AddStock ast = new AddStock();
        public StockList()
        {
            InitializeComponent();

            this.stocksTableAdapter.Fill(this._AM_Enterprise_ProgramDataSet.Stocks);
            StockListDataGridView.DataSource = databaseContext.Stocks.ToList<Stock>();
        }

        private void StockList_Load(object sender, EventArgs e)
        {
            this.stocksTableAdapter.Fill(this._AM_Enterprise_ProgramDataSet.Stocks);
            StockListDataGridView.DataSource = databaseContext.Stocks.ToList<Stock>();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            new AddStock(sourceName).Show();
            using (AddStock addUser = new AddStock(this.tblStockBindingSource))
            {
                addUser.ShowDialog();
            }
            this.Validate();
            this.stocksBindingSource.EndEdit();
        }

        private void StockListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sql connection string
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AM-Enterprise-Program;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            if (SearchTB.Text != "")
            {
                StockListDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                SqlDataAdapter adap = new SqlDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                // Search feature that will allow you to search for specific entries
                string command = "Select * From Stocks Where sCode like '%" + SearchTB.Text + "%';";

                con.Open();
                adap = new SqlDataAdapter(command, con);
                adap.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                StockListDataGridView.DataSource = dv;
                con.Close();

            }
            else
            {
                StockListDataGridView.Refresh();
            }
        }
        private void AddControls(Form F)
        {
            mn.guna2Panel2.Controls.Clear();
            F.TopLevel = false;
            F.Dock = DockStyle.Fill;
            mn.guna2Panel2.Controls.Add(F);
            F.Show();
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            // Refreshes the data grid view
             this.stocksTableAdapter.Fill(this._AM_Enterprise_ProgramDataSet.Stocks);
              StockListDataGridView.DataSource = databaseContext.Stocks.ToList<Stock>();
             SearchTB.Clear();

          // AddControls(new StockList());
           StockListDataGridView.Refresh();
            StockListDataGridView.Update();
        }

        private void StockListDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StockListDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            new AmmendStock().Show();
            using (AmmendStock addUser = new AmmendStock())
            {
                addUser.ShowDialog();
            }
            this.Validate();
            this.stocksBindingSource.EndEdit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            new StockAdjustment().Show();
            using (StockAdjustment addUser = new StockAdjustment())
            {
                addUser.ShowDialog();
            }
            this.Validate();
            this.stocksBindingSource.EndEdit();
        }
    }
}
