using AmmarahKader_XactERP_Project.Database;
using AmmarahKader_XactERP_Project.View;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmmarahKader_XactERP_Project.Model
{
    public partial class AddDebtor : Sample
    {
        // Creating an object of the Debtors class
        Debtor us = new Debtor();

        // Creating an object of the DebtorList class
        DebtorList ul = new DebtorList();

        // Creating an object of the Database context
        DatabaseContext databaseContext = new DatabaseContext();

        // Declaring variables
        public BindingSource bindingSource;
        private BindingSource sourceName;

        public AddDebtor(BindingSource sourceName)
        {
            InitializeComponent();
            this.bindingSource = sourceName;
        }

        private void AddDebtor_Load(object sender, EventArgs e)
        {

        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            // Clears the text in this field
            AccountCodeTB.Clear();
            // Clears the text in this field
            AddressOneTB.Clear();
            // Clears the text in this field
            AddressTwoTB.Clear();
            // Clears the text in this field
            AddressThreeTB.Clear();
            // Clears the text in this field
            CategoryCB.SelectedIndex = -1;
            // Clears the text in this field
            InvoiceTypeCB.SelectedIndex = -1;
            // Clears the text in this field
            ContactOneTB.Clear();
            // Clears the text in this field
            ContactTwoTB.Clear();
            // Clears the text in this field
            BalanceTB.Clear();
            // Clears the text in this field
            SalesYearTB.Clear();
            // Clears the text in this field
            CostYearTB.Clear();
            // Clears the text in this field
            CreditLimitTB.Clear();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // Inserting the entry into the databse 
            // If validation to make sure none of the fields are blank when entering details
            if (AccountCodeTB.Text.Length == 0 || AddressOneTB.Text.Length == 0 || AddressTwoTB.Text.Length == 0 || CreditLimitTB.Text.Length == 0 || AddressThreeTB.Text.Length == 0 || CategoryCB.Text.Length == 0 || InvoiceTypeCB.Text.Length == 0 || ContactOneTB.Text.Length == 0 || ContactTwoTB.Text.Length == 0 || SalesYearTB.Text.Length == 0 || CostYearTB.Text.Length == 0 || BalanceTB.Text.Length == 0)
            {
                MessageBox.Show("Fields cannot be blank", "AM Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Making the variable equal to the value from the textbox
                us.dAccountCode = AccountCodeTB.Text;
                // Making the variable equal to the value from the textbox
                us.dAddressOne = AddressOneTB.Text;
                // Making the variable equal to the value from the textbox
                us.dAddressTwo = AddressTwoTB.Text;
                // Making the variable equal to the value from the textbox
                us.dAddressThree = AddressThreeTB.Text;
                // Making the variable equal to the value from the textbox
                us.dCategory = CategoryCB.Text;
                // Making the variable equal to the value from the textbox
                us.dInvoiceType = InvoiceTypeCB.Text;
                // Making the variable equal to the value from the textbox
                us.dContactNumberOne = ContactOneTB.Text;
                // Making the variable equal to the value from the textbox
                us.dContactNumberTwo = ContactTwoTB.Text;
                // Making the variable equal to the value from the textbox
                us.dBalance = Decimal.Parse(BalanceTB.Text);
                // Making the variable equal to the value from the textbox
                us.dSalesYearToDte = Decimal.Parse(SalesYearTB.Text);
                // Making the variable equal to the value from the textbox
                us.dCostYearToDate = Decimal.Parse(CostYearTB.Text);
                // Making the variable equal to the value from the textbox
               us.dCreditLimit = Decimal.Parse(CreditLimitTB.Text);

                // Pass the data into the DB
                databaseContext.Debtors.Add(us);

                // Insert it into table
                int res = databaseContext.SaveChanges();

                // If statement
                if (res > 0)
                {
                    // Message box will pop up depending on he result
                    MessageBox.Show("Data Added Successfully", "AM Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (InvoiceTypeCB.SelectedIndex == 1)
                {
                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.ShowDialog();
                }
                DebtorList form2 = new DebtorList();
                foreach (DataGridViewRow drv in form2.DebtorListDataGridView.Rows)
                {
                    DataRowView dataRow = (DataRowView)this.bindingSource.AddNew();
                    dataRow[1] = this.AccountCodeTB.Text;
                    dataRow[2] = this.AddressOneTB.Text;
                    dataRow[3] = this.AddressTwoTB.Text;
                    dataRow[4] = this.AddressThreeTB.Text;
                    dataRow[5] = this.CategoryCB.Text;
                    dataRow[6] = this.InvoiceTypeCB.Text;
                    dataRow[7] = this.ContactOneTB.Text;
                    dataRow[8] = this.ContactTwoTB.Text;
                    dataRow[9] = this.BalanceTB.Text;
                    dataRow[10] = this.SalesYearTB.Text;
                    dataRow[11] = this.CostYearTB.Text;
                    dataRow[12] = this.CreditLimitTB.Text;
                    dataRow.EndEdit();
                    form2.DebtorListDataGridView.DataSource = databaseContext.Debtors.ToList<Debtor>();
                }
                form2.DebtorListDataGridView.DataSource = databaseContext.Debtors.ToList<Debtor>();

                // Clears the text in this field
                AccountCodeTB.Clear();
                // Clears the text in this field
                AddressOneTB.Clear();
                // Clears the text in this field
                AddressTwoTB.Clear();
                // Clears the text in this field
                AddressThreeTB.Clear();
                // Clears the text in this field
                CategoryCB.SelectedIndex = -1;
                // Clears the text in this field
                InvoiceTypeCB.SelectedIndex = -1;
                // Clears the text in this field
                ContactOneTB.Clear();
                // Clears the text in this field
                ContactTwoTB.Clear();
                // Clears the text in this field
                BalanceTB.Clear();
                // Clears the text in this field
                SalesYearTB.Clear();
                // Clears the text in this field
                CostYearTB.Clear();
                // Clears the text in this field
                CreditLimitTB.Clear();

            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
                e.Graphics.DrawString( 
                    "Account Code: " + AccountCodeTB.Text 
                    + "\n" + "Address One: " + AddressOneTB.Text
                    + "\n" + "Address Two: " + AddressTwoTB.Text
                    + "\n" + "Address Three: " + AddressThreeTB.Text
                    + "\n" + "Category: " + CategoryCB.SelectedIndex
                    + "\n" + "Contact One: " + ContactOneTB.Text
                    + "\n" + "Contact Two: " + ContactTwoTB.Text
                    + "\n" + "Balance: " + BalanceTB.Text
                    + "\n" + "Sales Year: " + SalesYearTB.Text
                    + "\n" + "Cost Year: " + CostYearTB.Text
                    + "\n" + "Credit Limit: " + CreditLimitTB.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10,10));
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void InvoiceTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SalesYearTB_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (!string.IsNullOrEmpty(SalesYearTB.Text) &&
                 !int.TryParse(SalesYearTB.Text, out i)
              )
            {
                MessageBox.Show("Enter valid sales amount", "AM Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CostYearTB_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (!string.IsNullOrEmpty(CostYearTB.Text) &&
                 !int.TryParse(CostYearTB.Text, out i)
              )
            {
                MessageBox.Show("Enter valid cost amount", "AM Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BalanceTB_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (!string.IsNullOrEmpty(BalanceTB.Text) &&
                 !int.TryParse(BalanceTB.Text, out i)
              )
            {
                MessageBox.Show("Enter valid balance amount", "AM Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreditLimitTB_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (!string.IsNullOrEmpty(CreditLimitTB.Text) &&
                 !int.TryParse(CreditLimitTB.Text, out i)
              )
            {
                MessageBox.Show("Enter valid credit limit amount", "AM Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }    
}
