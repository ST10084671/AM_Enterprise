
namespace AmmarahKader_XactERP_Project.View
{
    partial class TransactionStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionStock));
            this.StockTransactionDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.iDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iStockCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iQtySoldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iUnitCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iUnitSellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTransactionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDocumentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoicesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._AM_Enterprise_ProgramDataSet = new AmmarahKader_XactERP_Project._AM_Enterprise_ProgramDataSet();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.FilterCB = new System.Windows.Forms.ComboBox();
            this.SelectStockCB = new System.Windows.Forms.ComboBox();
            this.stocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ExitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.FilterBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stocksTableAdapter = new AmmarahKader_XactERP_Project._AM_Enterprise_ProgramDataSetTableAdapters.StocksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StockTransactionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._AM_Enterprise_ProgramDataSet)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StockTransactionDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.StockTransactionDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StockTransactionDataGridView.AutoGenerateColumns = false;
            this.StockTransactionDataGridView.BackgroundColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(217)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(217)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockTransactionDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StockTransactionDataGridView.ColumnHeadersHeight = 50;
            this.StockTransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.StockTransactionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDateDataGridViewTextBoxColumn,
            this.iStockCodeDataGridViewTextBoxColumn,
            this.iQtySoldDataGridViewTextBoxColumn,
            this.iUnitCostDataGridViewTextBoxColumn,
            this.iUnitSellDataGridViewTextBoxColumn,
            this.iTransactionTypeDataGridViewTextBoxColumn,
            this.iDocumentNumberDataGridViewTextBoxColumn});
            this.StockTransactionDataGridView.DataSource = this.invoicesBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StockTransactionDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.StockTransactionDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StockTransactionDataGridView.Location = new System.Drawing.Point(32, 140);
            this.StockTransactionDataGridView.Name = "StockTransactionDataGridView";
            this.StockTransactionDataGridView.RowHeadersVisible = false;
            this.StockTransactionDataGridView.RowHeadersWidth = 51;
            this.StockTransactionDataGridView.RowTemplate.Height = 24;
            this.StockTransactionDataGridView.Size = new System.Drawing.Size(586, 236);
            this.StockTransactionDataGridView.TabIndex = 6;
            this.StockTransactionDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.StockTransactionDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StockTransactionDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.StockTransactionDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StockTransactionDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StockTransactionDataGridView.ThemeStyle.BackColor = System.Drawing.Color.Honeydew;
            this.StockTransactionDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StockTransactionDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.StockTransactionDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.StockTransactionDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockTransactionDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StockTransactionDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.StockTransactionDataGridView.ThemeStyle.HeaderStyle.Height = 50;
            this.StockTransactionDataGridView.ThemeStyle.ReadOnly = false;
            this.StockTransactionDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.StockTransactionDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StockTransactionDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockTransactionDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.StockTransactionDataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.StockTransactionDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StockTransactionDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // iDateDataGridViewTextBoxColumn
            // 
            this.iDateDataGridViewTextBoxColumn.DataPropertyName = "iDate";
            this.iDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.iDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDateDataGridViewTextBoxColumn.Name = "iDateDataGridViewTextBoxColumn";
            // 
            // iStockCodeDataGridViewTextBoxColumn
            // 
            this.iStockCodeDataGridViewTextBoxColumn.DataPropertyName = "iStockCode";
            this.iStockCodeDataGridViewTextBoxColumn.HeaderText = "Stock Code";
            this.iStockCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iStockCodeDataGridViewTextBoxColumn.Name = "iStockCodeDataGridViewTextBoxColumn";
            // 
            // iQtySoldDataGridViewTextBoxColumn
            // 
            this.iQtySoldDataGridViewTextBoxColumn.DataPropertyName = "iQtySold";
            this.iQtySoldDataGridViewTextBoxColumn.HeaderText = "Qty Sold";
            this.iQtySoldDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iQtySoldDataGridViewTextBoxColumn.Name = "iQtySoldDataGridViewTextBoxColumn";
            // 
            // iUnitCostDataGridViewTextBoxColumn
            // 
            this.iUnitCostDataGridViewTextBoxColumn.DataPropertyName = "iUnitCost";
            this.iUnitCostDataGridViewTextBoxColumn.HeaderText = "Unit Cost";
            this.iUnitCostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iUnitCostDataGridViewTextBoxColumn.Name = "iUnitCostDataGridViewTextBoxColumn";
            // 
            // iUnitSellDataGridViewTextBoxColumn
            // 
            this.iUnitSellDataGridViewTextBoxColumn.DataPropertyName = "iUnitSell";
            this.iUnitSellDataGridViewTextBoxColumn.HeaderText = "Unit Sell";
            this.iUnitSellDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iUnitSellDataGridViewTextBoxColumn.Name = "iUnitSellDataGridViewTextBoxColumn";
            // 
            // iTransactionTypeDataGridViewTextBoxColumn
            // 
            this.iTransactionTypeDataGridViewTextBoxColumn.DataPropertyName = "iTransactionType";
            this.iTransactionTypeDataGridViewTextBoxColumn.HeaderText = "Transaction Type";
            this.iTransactionTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iTransactionTypeDataGridViewTextBoxColumn.Name = "iTransactionTypeDataGridViewTextBoxColumn";
            // 
            // iDocumentNumberDataGridViewTextBoxColumn
            // 
            this.iDocumentNumberDataGridViewTextBoxColumn.DataPropertyName = "iDocumentNumber";
            this.iDocumentNumberDataGridViewTextBoxColumn.HeaderText = "Document Number";
            this.iDocumentNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDocumentNumberDataGridViewTextBoxColumn.Name = "iDocumentNumberDataGridViewTextBoxColumn";
            // 
            // invoicesBindingSource1
            // 
            this.invoicesBindingSource1.DataMember = "Invoices";
            this.invoicesBindingSource1.DataSource = this._AM_Enterprise_ProgramDataSet;
            // 
            // _AM_Enterprise_ProgramDataSet
            // 
            this._AM_Enterprise_ProgramDataSet.DataSetName = "_AM_Enterprise_ProgramDataSet";
            this._AM_Enterprise_ProgramDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.guna2Panel1.Controls.Add(this.FilterCB);
            this.guna2Panel1.Controls.Add(this.SelectStockCB);
            this.guna2Panel1.Controls.Add(this.ExitBtn);
            this.guna2Panel1.Controls.Add(this.FilterBtn);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.DarkSeaGreen;
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(650, 116);
            this.guna2Panel1.TabIndex = 7;
            // 
            // FilterCB
            // 
            this.FilterCB.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterCB.ForeColor = System.Drawing.Color.SeaGreen;
            this.FilterCB.FormattingEnabled = true;
            this.FilterCB.Items.AddRange(new object[] {
            "Highest to Lowest"});
            this.FilterCB.Location = new System.Drawing.Point(32, 72);
            this.FilterCB.Name = "FilterCB";
            this.FilterCB.Size = new System.Drawing.Size(180, 29);
            this.FilterCB.TabIndex = 15;
            this.FilterCB.Text = "Sort By:";
            // 
            // SelectStockCB
            // 
            this.SelectStockCB.DataSource = this.stocksBindingSource;
            this.SelectStockCB.DisplayMember = "sCode";
            this.SelectStockCB.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectStockCB.ForeColor = System.Drawing.Color.SeaGreen;
            this.SelectStockCB.FormattingEnabled = true;
            this.SelectStockCB.Location = new System.Drawing.Point(297, 16);
            this.SelectStockCB.Name = "SelectStockCB";
            this.SelectStockCB.Size = new System.Drawing.Size(180, 29);
            this.SelectStockCB.TabIndex = 14;
            this.SelectStockCB.ValueMember = "sCode";
            this.SelectStockCB.SelectedIndexChanged += new System.EventHandler(this.SelectStockCB_SelectedIndexChanged);
            // 
            // stocksBindingSource
            // 
            this.stocksBindingSource.DataMember = "Stocks";
            this.stocksBindingSource.DataSource = this._AM_Enterprise_ProgramDataSet;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.ExitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExitBtn.FillColor = System.Drawing.Color.Transparent;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.ExitBtn.Location = new System.Drawing.Point(610, 3);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(37, 36);
            this.ExitBtn.TabIndex = 12;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click_1);
            // 
            // FilterBtn
            // 
            this.FilterBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FilterBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FilterBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FilterBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FilterBtn.FillColor = System.Drawing.Color.SeaGreen;
            this.FilterBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FilterBtn.ForeColor = System.Drawing.Color.White;
            this.FilterBtn.Image = ((System.Drawing.Image)(resources.GetObject("FilterBtn.Image")));
            this.FilterBtn.Location = new System.Drawing.Point(218, 72);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(31, 29);
            this.FilterBtn.TabIndex = 11;
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stock Transaction List";
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "Invoices";
            this.invoicesBindingSource.DataSource = this._AM_Enterprise_ProgramDataSet;
            // 
            // stocksTableAdapter
            // 
            this.stocksTableAdapter.ClearBeforeFill = true;
            // 
            // TransactionStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.StockTransactionDataGridView);
            this.Name = "TransactionStock";
            this.Text = "TransactionStock";
            this.Load += new System.EventHandler(this.TransactionStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockTransactionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._AM_Enterprise_ProgramDataSet)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView StockTransactionDataGridView;
        public Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.ComboBox FilterCB;
        private System.Windows.Forms.ComboBox SelectStockCB;
        private Guna.UI2.WinForms.Guna2Button ExitBtn;
        private Guna.UI2.WinForms.Guna2Button FilterBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iStockCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iQtySoldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iUnitCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iUnitSellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTransactionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDocumentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource invoicesBindingSource1;
        private _AM_Enterprise_ProgramDataSet _AM_Enterprise_ProgramDataSet;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private System.Windows.Forms.BindingSource stocksBindingSource;
        private _AM_Enterprise_ProgramDataSetTableAdapters.StocksTableAdapter stocksTableAdapter;
    }
}