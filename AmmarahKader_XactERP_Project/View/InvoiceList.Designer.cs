namespace AmmarahKader_XactERP_Project.View
{
    partial class InvoiceList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.SearchBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SearchTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InvoiceDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.iAccountCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTotalSellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iVatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iItemNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iStockCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iQtySoldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iUnitCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iUnitSellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDiscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._AM_Enterprise_ProgramDataSet = new AmmarahKader_XactERP_Project._AM_Enterprise_ProgramDataSet();
            this.invoicesTableAdapter = new AmmarahKader_XactERP_Project._AM_Enterprise_ProgramDataSetTableAdapters.InvoicesTableAdapter();
            this.tableAdapterManager = new AmmarahKader_XactERP_Project._AM_Enterprise_ProgramDataSetTableAdapters.TableAdapterManager();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._AM_Enterprise_ProgramDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.SearchBtn);
            this.guna2Panel1.Controls.Add(this.SearchTB);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.AddBtn);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.SeaGreen;
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(570, 116);
            this.guna2Panel1.TabIndex = 3;
            // 
            // SearchBtn
            // 
            this.SearchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchBtn.FillColor = System.Drawing.Color.SeaGreen;
            this.SearchBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Image = ((System.Drawing.Image)(resources.GetObject("SearchBtn.Image")));
            this.SearchBtn.Location = new System.Drawing.Point(253, 73);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.SearchBtn.Size = new System.Drawing.Size(30, 27);
            this.SearchBtn.TabIndex = 10;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchTB
            // 
            this.SearchTB.Animated = true;
            this.SearchTB.BackColor = System.Drawing.Color.SeaGreen;
            this.SearchTB.BorderColor = System.Drawing.Color.Honeydew;
            this.SearchTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTB.DefaultText = "";
            this.SearchTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTB.FillColor = System.Drawing.Color.SeaGreen;
            this.SearchTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchTB.ForeColor = System.Drawing.Color.Honeydew;
            this.SearchTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTB.Location = new System.Drawing.Point(32, 73);
            this.SearchTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.PasswordChar = '\0';
            this.SearchTB.PlaceholderForeColor = System.Drawing.Color.Honeydew;
            this.SearchTB.PlaceholderText = "";
            this.SearchTB.SelectedText = "";
            this.SearchTB.Size = new System.Drawing.Size(215, 27);
            this.SearchTB.TabIndex = 9;
            this.SearchTB.TextChanged += new System.EventHandler(this.SearchTB_TextChanged);
            this.SearchTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchTB_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(28, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search";
            // 
            // AddBtn
            // 
            this.AddBtn.Animated = true;
            this.AddBtn.AutoRoundedCorners = true;
            this.AddBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddBtn.BorderColor = System.Drawing.Color.Honeydew;
            this.AddBtn.BorderRadius = 14;
            this.AddBtn.BorderThickness = 1;
            this.AddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddBtn.FillColor = System.Drawing.Color.SeaGreen;
            this.AddBtn.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 10.2F);
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.IndicateFocus = true;
            this.AddBtn.Location = new System.Drawing.Point(480, 9);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(78, 30);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "+ Add";
            this.AddBtn.UseTransparentBackground = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Invoice List";
            // 
            // InvoiceDataGridView
            // 
            this.InvoiceDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.InvoiceDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.InvoiceDataGridView.AutoGenerateColumns = false;
            this.InvoiceDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InvoiceDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.InvoiceDataGridView.ColumnHeadersHeight = 50;
            this.InvoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.InvoiceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iAccountCodeDataGridViewTextBoxColumn,
            this.iDateDataGridViewTextBoxColumn,
            this.iTotalSellDataGridViewTextBoxColumn,
            this.iVatDataGridViewTextBoxColumn,
            this.iNumberDataGridViewTextBoxColumn,
            this.iItemNumberDataGridViewTextBoxColumn,
            this.iStockCodeDataGridViewTextBoxColumn,
            this.iQtySoldDataGridViewTextBoxColumn,
            this.iUnitCostDataGridViewTextBoxColumn,
            this.iUnitSellDataGridViewTextBoxColumn,
            this.iDiscountDataGridViewTextBoxColumn,
            this.iTotalDataGridViewTextBoxColumn});
            this.InvoiceDataGridView.DataSource = this.invoicesBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(217)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InvoiceDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.InvoiceDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.InvoiceDataGridView.Location = new System.Drawing.Point(32, 134);
            this.InvoiceDataGridView.Margin = new System.Windows.Forms.Padding(7);
            this.InvoiceDataGridView.Name = "InvoiceDataGridView";
            this.InvoiceDataGridView.RowHeadersVisible = false;
            this.InvoiceDataGridView.RowHeadersWidth = 51;
            this.InvoiceDataGridView.RowTemplate.Height = 24;
            this.InvoiceDataGridView.Size = new System.Drawing.Size(526, 221);
            this.InvoiceDataGridView.TabIndex = 4;
            this.InvoiceDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.InvoiceDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.InvoiceDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.InvoiceDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.InvoiceDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.InvoiceDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.InvoiceDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.InvoiceDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.SeaGreen;
            this.InvoiceDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.InvoiceDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.InvoiceDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.InvoiceDataGridView.ThemeStyle.HeaderStyle.Height = 50;
            this.InvoiceDataGridView.ThemeStyle.ReadOnly = false;
            this.InvoiceDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.InvoiceDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.InvoiceDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.SeaGreen;
            this.InvoiceDataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.InvoiceDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.InvoiceDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.SeaGreen;
            this.InvoiceDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserDataGridView_CellContentClick);
            // 
            // iAccountCodeDataGridViewTextBoxColumn
            // 
            this.iAccountCodeDataGridViewTextBoxColumn.DataPropertyName = "iAccountCode";
            this.iAccountCodeDataGridViewTextBoxColumn.HeaderText = "Acc Code";
            this.iAccountCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iAccountCodeDataGridViewTextBoxColumn.Name = "iAccountCodeDataGridViewTextBoxColumn";
            // 
            // iDateDataGridViewTextBoxColumn
            // 
            this.iDateDataGridViewTextBoxColumn.DataPropertyName = "iDate";
            this.iDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.iDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDateDataGridViewTextBoxColumn.Name = "iDateDataGridViewTextBoxColumn";
            // 
            // iTotalSellDataGridViewTextBoxColumn
            // 
            this.iTotalSellDataGridViewTextBoxColumn.DataPropertyName = "iTotalSell";
            this.iTotalSellDataGridViewTextBoxColumn.HeaderText = "Total Sell";
            this.iTotalSellDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iTotalSellDataGridViewTextBoxColumn.Name = "iTotalSellDataGridViewTextBoxColumn";
            // 
            // iVatDataGridViewTextBoxColumn
            // 
            this.iVatDataGridViewTextBoxColumn.DataPropertyName = "iVat";
            this.iVatDataGridViewTextBoxColumn.HeaderText = "Vat";
            this.iVatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iVatDataGridViewTextBoxColumn.Name = "iVatDataGridViewTextBoxColumn";
            // 
            // iNumberDataGridViewTextBoxColumn
            // 
            this.iNumberDataGridViewTextBoxColumn.DataPropertyName = "iNumber";
            this.iNumberDataGridViewTextBoxColumn.HeaderText = "Invoice No.";
            this.iNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iNumberDataGridViewTextBoxColumn.Name = "iNumberDataGridViewTextBoxColumn";
            // 
            // iItemNumberDataGridViewTextBoxColumn
            // 
            this.iItemNumberDataGridViewTextBoxColumn.DataPropertyName = "iItemNumber";
            this.iItemNumberDataGridViewTextBoxColumn.HeaderText = "Item No.";
            this.iItemNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iItemNumberDataGridViewTextBoxColumn.Name = "iItemNumberDataGridViewTextBoxColumn";
            // 
            // iStockCodeDataGridViewTextBoxColumn
            // 
            this.iStockCodeDataGridViewTextBoxColumn.DataPropertyName = "iStockCode";
            this.iStockCodeDataGridViewTextBoxColumn.HeaderText = "Stk Code";
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
            // iDiscountDataGridViewTextBoxColumn
            // 
            this.iDiscountDataGridViewTextBoxColumn.DataPropertyName = "iDiscount";
            this.iDiscountDataGridViewTextBoxColumn.HeaderText = "Disc";
            this.iDiscountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDiscountDataGridViewTextBoxColumn.Name = "iDiscountDataGridViewTextBoxColumn";
            // 
            // iTotalDataGridViewTextBoxColumn
            // 
            this.iTotalDataGridViewTextBoxColumn.DataPropertyName = "iTotal";
            this.iTotalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.iTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iTotalDataGridViewTextBoxColumn.Name = "iTotalDataGridViewTextBoxColumn";
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "Invoices";
            this.invoicesBindingSource.DataSource = this._AM_Enterprise_ProgramDataSet;
            // 
            // _AM_Enterprise_ProgramDataSet
            // 
            this._AM_Enterprise_ProgramDataSet.DataSetName = "_AM_Enterprise_ProgramDataSet";
            this._AM_Enterprise_ProgramDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.@__MigrationHistoryTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DebtorsTableAdapter = null;
            this.tableAdapterManager.InvoicesTableAdapter = this.invoicesTableAdapter;
            this.tableAdapterManager.StocksTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AmmarahKader_XactERP_Project._AM_Enterprise_ProgramDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // InvoiceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 378);
            this.Controls.Add(this.InvoiceDataGridView);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "InvoiceList";
            this.Text = "ViewInvoice";
            this.Load += new System.EventHandler(this.ViewInvoice_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._AM_Enterprise_ProgramDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CircleButton SearchBtn;
        private Guna.UI2.WinForms.Guna2TextBox SearchTB;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button AddBtn;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2DataGridView InvoiceDataGridView;
        private _AM_Enterprise_ProgramDataSet _AM_Enterprise_ProgramDataSet;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private _AM_Enterprise_ProgramDataSetTableAdapters.InvoicesTableAdapter invoicesTableAdapter;
        private _AM_Enterprise_ProgramDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn iAccountCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTotalSellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iVatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iItemNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iStockCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iQtySoldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iUnitCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iUnitSellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDiscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTotalDataGridViewTextBoxColumn;
    }
}