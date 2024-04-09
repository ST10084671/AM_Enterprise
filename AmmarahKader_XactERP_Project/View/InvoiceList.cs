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
    public partial class InvoiceList : Sample
    {
        // Creating an object of the Database context
        DatabaseContext databaseContext = new DatabaseContext();

        // Declaring variables
        private BindingSource sourceName;

        public InvoiceList()
        {
            InitializeComponent();
        }

        private void ViewInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_AM_Enterprise_ProgramDataSet.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this._AM_Enterprise_ProgramDataSet.Invoices);

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            new AddInvoice(sourceName).Show();
            using (AddInvoice addUser = new AddInvoice(this.invoicesBindingSource))
            {
                addUser.ShowDialog();
            }
            this.Validate();
            this.invoicesBindingSource.EndEdit();
        }

        private void UserDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sql connection string
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AM-Enterprise-Program;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            if (SearchTB.Text != "")
            {
                // Search feature
                InvoiceDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                SqlDataAdapter adap = new SqlDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                // Shows only the data that has these details in
                string command = "Select * From Invoices Where iNumber like '%" + SearchTB.Text + "%';";

                con.Open();
                adap = new SqlDataAdapter(command, con);
                adap.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                InvoiceDataGridView.DataSource = dv;
                con.Close();

            }
            else
            {
                InvoiceDataGridView.Refresh();
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            // Refreshes the data grid view
            InvoiceDataGridView.DataSource = databaseContext.Invoices.ToList<Invoice>();
            SearchTB.Clear();
        }
    }
}
