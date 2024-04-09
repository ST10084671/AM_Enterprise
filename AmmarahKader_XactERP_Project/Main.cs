using AmmarahKader_XactERP_Project.Model;
using AmmarahKader_XactERP_Project.View;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmmarahKader_XactERP_Project
{
    public partial class Main : Sample
    {
        // Declaring variables
        private BindingSource sourceName;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel4_MouseEnter(object sender, EventArgs e)
        {
            //guna2Panel1.Visible = false;
        }

        private void guna2Panel2_MouseEnter(object sender, EventArgs e)
        {
          //  guna2Panel1.Visible = false;
        }

        private void guna2Panel3_MouseEnter(object sender, EventArgs e)
        {
           // guna2Panel1.Visible = false;
        }
        
        private void AddControls(Form F)
        {
            // Controls to add the new screen to the stock panel
            guna2Panel2.Controls.Clear();
            F.TopLevel = false;
            F.Dock = DockStyle.Fill;
            guna2Panel2.Controls.Add(F);
            F.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            // Exits the program
            Application.Exit();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {

        }

        private void MaximizeBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
           // guna2Panel1.Visible = true;
        }

        private void StockAddBtn_Click(object sender, EventArgs e)
        {
            // Redirects you to this page
            new AddStock(sourceName).Show();
        }

        private void DebtorAddBtn_Click(object sender, EventArgs e)
        {
            // Redirects you to this page
            new AddDebtor(sourceName).Show();
        }

        private void InvoiceAddBtn_Click(object sender, EventArgs e)
        {

        }

        private void UsersAddBtn_Click(object sender, EventArgs e)
        {
            // Redirects you to this page
            new AddUser(sourceName).Show();
        }

        private void StockBtn_Click(object sender, EventArgs e)
        {
            // Redirects you to this page
            AddControls(new StockList());
        }

        private void DebtorBtn_Click(object sender, EventArgs e)
        {
            // Redirects you to this page
            AddControls(new DebtorList());
        }

        private void TransactionBtn_Click(object sender, EventArgs e)
        {
            // Redirects you to this page
            AddControls(new TransactionList());
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {

        }

        private void InvoiceBtn_Click(object sender, EventArgs e)
        {
            // Redirects you to this page
            AddControls(new InvoiceList());
        }

        private void UsersBtn_Click(object sender, EventArgs e)
        {
            // Redirects you to this page
            AddControls(new UserList());
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
