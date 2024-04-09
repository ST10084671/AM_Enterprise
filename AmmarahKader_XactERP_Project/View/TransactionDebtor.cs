using AmmarahKader_XactERP_Project.Database;
using Devart.Common;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace AmmarahKader_XactERP_Project.View
{
    public partial class TransactionDebtor : Sample
    {
        // Creating an object of the Stock class
        Debtor us = new Debtor();

        // Creating an object of the StockList class
        DebtorList ul = new DebtorList();

        // Creating an object of the Database context
        DatabaseContext databaseContext = new DatabaseContext();

        DebtorList form2 = new DebtorList();

        SqlConnection con = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=AM-Enterprise-Program;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        public TransactionDebtor()
        {
            InitializeComponent();
        }

        private void TransactionDebtor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_AM_Enterprise_ProgramDataSet.Debtors' table. You can move, or remove it, as needed.
            this.debtorsTableAdapter.Fill(this._AM_Enterprise_ProgramDataSet.Debtors);

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            // Closes the screen
            this.Close();
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {

        }

        private void SelectDebtorCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AM-Enterprise-Program;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            if (SelectDebtorCB.SelectedIndex != null)
            {
                DebtorTransactionDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                SqlDataAdapter adap = new SqlDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                // Select all from the table that contains this
                string command = "Select * From Invoices Where iAccountCode = '" + SelectDebtorCB.Text + "';";

                con.Open();
                adap = new SqlDataAdapter(command, con);
                adap.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                DebtorTransactionDataGridView.DataSource = dv;
                con.Close();

            }
            else
            {
                DebtorTransactionDataGridView.Refresh();
            }
        }

        private void SelectDebtorCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Invoice invoice = SelectDebtorCB.SelectedItem as Invoice;
            if (invoice != null)
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    using(DatabaseContext db = new DatabaseContext())
                    {
                        db.Configuration.ProxyCreationEnabled = false;
                        var query = from o in db.Invoices
                                    where o.iAccountCode == invoice.iAccountCode
                                    select 0;
                        DebtorTransactionDataGridView.DataSource= query.ToList();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }
                Cursor.Current = Cursors.Default;
            }
        }

        private void FilterCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if ()
            //{

            //}
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Filter to show total in decending order
            invoicesBindingSource.DataSource = DebtorTransactionDataGridView.DataSource;
            invoicesBindingSource.Sort = "iTotal Desc";
            DebtorTransactionDataGridView.DataSource = invoicesBindingSource;
        }
    }
}
