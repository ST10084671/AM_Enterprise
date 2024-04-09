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
    public partial class DebtorList : Sample
    {
        // Creating an object of the Debtor class
        Debtor us = new Debtor();

        // Creating an object of the Database context
        DatabaseContext databaseContext = new DatabaseContext();

        // Declaring variables
        private BindingSource sourceName;
        int id = 0;

        public DebtorList()
        {
            InitializeComponent();

            this.debtorsTableAdapter.Fill(this._AM_Enterprise_ProgramDataSet.Debtors);
            DebtorListDataGridView.DataSource = databaseContext.Debtors.ToList<Debtor>();
        }

        private void DebtorList_Load(object sender, EventArgs e)
        {
            this.debtorsTableAdapter.Fill(this._AM_Enterprise_ProgramDataSet.Debtors);
            DebtorListDataGridView.DataSource = databaseContext.Debtors.ToList<Debtor>();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            new AddDebtor(sourceName).Show();
            using (AddDebtor addUser = new AddDebtor(this.debtorsBindingSource))
            {
                addUser.ShowDialog();
            }
            this.Validate();
            this.debtorsBindingSource.EndEdit();
        }

        private void DebtorListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sql connection string
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AM-Enterprise-Program;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            if (SearchTB.Text != "")
            {
                // Search feature
                DebtorListDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                SqlDataAdapter adap = new SqlDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                // Select all the data that has this info
                string command = "Select * From Debtors Where dAccountCode like '%" + SearchTB.Text + "%';";

                con.Open();
                adap = new SqlDataAdapter(command, con);
                adap.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                DebtorListDataGridView.DataSource = dv;
                con.Close();

            }
            else
            {
                DebtorListDataGridView.Refresh();
            }
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            // Refreshing the data grid view
            DebtorListDataGridView.DataSource = databaseContext.Debtors.ToList<Debtor>();
            SearchTB.Clear();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            new AmendDebtor().Show();
            using (AmendDebtor addUser = new AmendDebtor())
            {
                addUser.ShowDialog();
            }
            this.Validate();
            this.debtorsBindingSource.EndEdit();
        }

        private void AdjustBalanceBtn_Click(object sender, EventArgs e)
        {
            new BalanceAdjustment().Show();
            using (BalanceAdjustment addUser = new BalanceAdjustment())
            {
                addUser.ShowDialog();
            }
            this.Validate();
            this.debtorsBindingSource.EndEdit();
        }
    }
}
