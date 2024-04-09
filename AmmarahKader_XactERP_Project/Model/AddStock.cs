using AmmarahKader_XactERP_Project.Database;
using AmmarahKader_XactERP_Project.View;
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
    public partial class AddStock : Sample
    {
        // Creating an object of the Stock class
        Stock us = new Stock();

        // Creating an object of the StockList class
        StockList ul = new StockList();

        // Creating an object of the Database context
        DatabaseContext databaseContext = new DatabaseContext();

        // Declaring variables
        public BindingSource bindingSource;
        private BindingSource sourceName;

        public AddStock(BindingSource sourceName)
        {
            InitializeComponent();
            this.bindingSource = sourceName;
        }


        private void AddStock_Load(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // Inserting the entry into the database
            if (StockCodeTB.Text.Length == 0 || DescriptionOneTB.Text.Length == 0 || DescriptionTwoTB.Text.Length == 0 || CategoryCB.Text.Length == 0 || InvoiceCB.Text.Length == 0 || CostPriceTB.Text.Length == 0 || SellingPriceTB.Text.Length == 0 || QtyPurchasedTB.Text.Length == 0 || QtySoldTB.Text.Length == 0 || StockOnHandTB.Text.Length == 0)
            {
                MessageBox.Show("Fields cannot be blank", "AM Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Making the variable equal to the value from the textbox
                us.sCode = StockCodeTB.Text;
                // Making the variable equal to the value from the textbox
                us.sDescriptionOne = DescriptionOneTB.Text;
                // Making the variable equal to the value from the textbox
                us.sDescriptionTwo = DescriptionTwoTB.Text;
                // Making the variable equal to the value from the textbox
                us.sCategory = CategoryCB.Text;
                // Making the variable equal to the value from the textbox
                us.sInvoiceType = InvoiceCB.Text;
                // Making the variable equal to the value from the textbox
                us.sCostPrice = Decimal.Parse(CostPriceTB.Text);
                // Making the variable equal to the value from the textbox
                us.sSellingPrice = Decimal.Parse(SellingPriceTB.Text);
                // Making the variable equal to the value from the textbox
                us.sTotalPurchases = Decimal.Parse(CostPriceTB.Text) * Decimal.Parse(QtyPurchasedTB.Text);
                // Making the variable equal to the value from the textbox
                us.sTotalSales = Decimal.Parse(SellingPriceTB.Text) * Decimal.Parse(QtySoldTB.Text);
                // Making the variable equal to the value from the textbox
                us.sQtyPurchased = Int32.Parse(QtyPurchasedTB.Text);
                // Making the variable equal to the value from the textbox
                us.sQtySold = Int32.Parse(QtySoldTB.Text);
                // Making the variable equal to the value from the textbox
                us.sOnHand = Int32.Parse(StockOnHandTB.Text);

                // Pass the data into the DB
                databaseContext.Stocks.Add(us);

                // Insert it into table
                int res = databaseContext.SaveChanges();

                // If statement
                if (res > 0)
                {
                    // Message box will pop up depending on he result
                    MessageBox.Show("Stock Added Successfully", "AM Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (InvoiceCB.SelectedIndex == 1)
                {
                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.ShowDialog();
                }
                StockList form2 = new StockList();
                foreach (DataGridViewRow drv in form2.StockListDataGridView.Rows)
                {
                    DataRowView dataRow = (DataRowView)this.bindingSource.AddNew();
                    dataRow[1] = this.StockCodeTB.Text;
                    dataRow[2] = this.DescriptionOneTB.Text;
                    dataRow[3] = this.DescriptionTwoTB.Text;
                    dataRow[4] = this.CategoryCB.Text;
                    dataRow[5] = this.InvoiceCB.Text;
                    dataRow[6] = this.CostPriceTB.Text;
                    dataRow[7] = this.SellingPriceTB.Text;
                    dataRow[8] = this.us.sTotalPurchases;
                    dataRow[9] = this.us.sTotalSales;
                    dataRow[10] = this.QtyPurchasedTB.Text;
                    dataRow[11] = this.QtySoldTB.Text;
                    dataRow[12] = this.StockOnHandTB.Text;
                    dataRow.EndEdit();
                    form2.StockListDataGridView.DataSource = databaseContext.Stocks.ToList<Stock>();
                }
                form2.StockListDataGridView.DataSource = databaseContext.Stocks.ToList<Stock>();

                // Clears the text in this field
                StockCodeTB.Clear();
                // Clears the text in this field
                DescriptionOneTB.Clear();
                // Clears the text in this field
                DescriptionTwoTB.Clear();
                // Clears the text in this field
                CategoryCB.SelectedIndex = -1;
                // Clears the text in this field
                InvoiceCB.SelectedIndex = -1;
                // Clears the text in this field
                CostPriceTB.Clear();
                // Clears the text in this field
                SellingPriceTB.Clear();
                // Clears the text in this field
                // TotalPurchasesTB.Clear();
                // Clears the text in this field
                // TotalSalesTB.Clear();
                // Clears the text in this field
                QtyPurchasedTB.Clear();
                // Clears the text in this field
                QtySoldTB.Clear();
                // Clears the text in this field
                StockOnHandTB.Clear();
            }
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            // Clears the text in this field
            StockCodeTB.Clear();
            // Clears the text in this field
            DescriptionOneTB.Clear();
            // Clears the text in this field
            DescriptionTwoTB.Clear();
            // Clears the text in this field
            CategoryCB.SelectedIndex = -1;
            // Clears the text in this field
            InvoiceCB.SelectedIndex = -1;
            // Clears the text in this field
            CostPriceTB.Clear();
            // Clears the text in this field
            SellingPriceTB.Clear();
            // Clears the text in this field
            //  TotalPurchasesTB.Clear();
            // Clears the text in this field
            // TotalSalesTB.Clear();
            // Clears the text in this field
            QtyPurchasedTB.Clear();
            // Clears the text in this field
            QtySoldTB.Clear();
            // Clears the text in this field
            StockOnHandTB.Clear();
        }

        private void TotalPurchasesTB_TextChanged(object sender, EventArgs e)
        {
            //us.sTotalPurchases = Decimal.Parse(CostPriceTB.Text) * Decimal.Parse(TotalPurchasesTB.Text);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InvoiceCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(
                "Stock Code: " + StockCodeTB.Text
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

        private void CostPriceTB_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (!string.IsNullOrEmpty(CostPriceTB.Text) &&
                 !int.TryParse(CostPriceTB.Text, out i)
              )
            {
                MessageBox.Show("Enter valid cost price amount", "AM Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SellingPriceTB_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (!string.IsNullOrEmpty(SellingPriceTB.Text) &&
                 !int.TryParse(SellingPriceTB.Text, out i)
              )
            {
                MessageBox.Show("Enter valid selling price amount", "AM Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void QtyPurchasedTB_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (!string.IsNullOrEmpty(QtyPurchasedTB.Text) &&
                 !int.TryParse(QtyPurchasedTB.Text, out i)
              )
            {
                MessageBox.Show("Enter valid quantity purchased amount", "AM Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void StockOnHandTB_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (!string.IsNullOrEmpty(StockOnHandTB.Text) &&
                 !int.TryParse(StockOnHandTB.Text, out i)
              )
            {
                MessageBox.Show("Enter valid stock on hand amount", "AM Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
