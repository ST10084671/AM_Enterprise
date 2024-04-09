
namespace AmmarahKader_XactERP_Project.View
{
    partial class StockList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SearchBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SearchTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.aM_EnterpriseDataSet1 = new AmmarahKader_XactERP_Project.AM_EnterpriseDataSet1();
            this.tblStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblStockTableAdapter = new AmmarahKader_XactERP_Project.AM_EnterpriseDataSet1TableAdapters.tblStockTableAdapter();
            this.tableAdapterManager = new AmmarahKader_XactERP_Project.AM_EnterpriseDataSet1TableAdapters.TableAdapterManager();
            this.StockListDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.sCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDescriptionOneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDescriptionTwoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sInvoiceTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCostPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSellingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTotalPurchasesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTotalSalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sQtyPurchasedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sQtySoldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOnHandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aMEnterpriseProgramDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._AM_Enterprise_ProgramDataSet = new AmmarahKader_XactERP_Project._AM_Enterprise_ProgramDataSet();
            this.stocksTableAdapter = new AmmarahKader_XactERP_Project._AM_Enterprise_ProgramDataSetTableAdapters.StocksTableAdapter();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aM_EnterpriseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMEnterpriseProgramDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._AM_Enterprise_ProgramDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.UpdateBtn);
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
            this.guna2Panel1.TabIndex = 4;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.Honeydew;
            this.guna2Button1.BorderRadius = 14;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.SeaGreen;
            this.guna2Button1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 10.2F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.IndicateFocus = true;
            this.guna2Button1.Location = new System.Drawing.Point(398, 44);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(160, 30);
            this.guna2Button1.TabIndex = 13;
            this.guna2Button1.Text = "Stock Adjustment";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Animated = true;
            this.UpdateBtn.AutoRoundedCorners = true;
            this.UpdateBtn.BackColor = System.Drawing.Color.Transparent;
            this.UpdateBtn.BorderColor = System.Drawing.Color.Honeydew;
            this.UpdateBtn.BorderRadius = 14;
            this.UpdateBtn.BorderThickness = 1;
            this.UpdateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateBtn.FillColor = System.Drawing.Color.SeaGreen;
            this.UpdateBtn.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 10.2F);
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.IndicateFocus = true;
            this.UpdateBtn.Location = new System.Drawing.Point(481, 8);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(77, 30);
            this.UpdateBtn.TabIndex = 12;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseTransparentBackground = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
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
            this.SearchBtn.TabIndex = 11;
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
            this.SearchTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchTB_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(28, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
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
            this.AddBtn.Location = new System.Drawing.Point(398, 8);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(77, 30);
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
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stock List";
            // 
            // aM_EnterpriseDataSet1
            // 
            this.aM_EnterpriseDataSet1.DataSetName = "AM_EnterpriseDataSet1";
            this.aM_EnterpriseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStockBindingSource
            // 
            this.tblStockBindingSource.DataMember = "tblStock";
            this.tblStockBindingSource.DataSource = this.aM_EnterpriseDataSet1;
            // 
            // tblStockTableAdapter
            // 
            this.tblStockTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblDebtorTableAdapter = null;
            this.tableAdapterManager.tblStockTableAdapter = this.tblStockTableAdapter;
            this.tableAdapterManager.UpdateOrder = AmmarahKader_XactERP_Project.AM_EnterpriseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // StockListDataGridView
            // 
            this.StockListDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.StockListDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StockListDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StockListDataGridView.ColumnHeadersHeight = 50;
            this.StockListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sCodeDataGridViewTextBoxColumn,
            this.sDescriptionOneDataGridViewTextBoxColumn,
            this.sDescriptionTwoDataGridViewTextBoxColumn,
            this.sCategoryDataGridViewTextBoxColumn,
            this.sInvoiceTypeDataGridViewTextBoxColumn,
            this.sCostPriceDataGridViewTextBoxColumn,
            this.sSellingPriceDataGridViewTextBoxColumn,
            this.sTotalPurchasesDataGridViewTextBoxColumn,
            this.sTotalSalesDataGridViewTextBoxColumn,
            this.sQtyPurchasedDataGridViewTextBoxColumn,
            this.sQtySoldDataGridViewTextBoxColumn,
            this.sOnHandDataGridViewTextBoxColumn});
            this.StockListDataGridView.DataSource = this.stocksBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(217)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StockListDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.StockListDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StockListDataGridView.Location = new System.Drawing.Point(32, 134);
            this.StockListDataGridView.Name = "StockListDataGridView";
            this.StockListDataGridView.RowHeadersVisible = false;
            this.StockListDataGridView.RowHeadersWidth = 51;
            this.StockListDataGridView.RowTemplate.Height = 24;
            this.StockListDataGridView.Size = new System.Drawing.Size(526, 221);
            this.StockListDataGridView.TabIndex = 5;
            this.StockListDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.StockListDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StockListDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.StockListDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StockListDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StockListDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.StockListDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StockListDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.SeaGreen;
            this.StockListDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.StockListDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockListDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StockListDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.StockListDataGridView.ThemeStyle.HeaderStyle.Height = 50;
            this.StockListDataGridView.ThemeStyle.ReadOnly = false;
            this.StockListDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.StockListDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StockListDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockListDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.SeaGreen;
            this.StockListDataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.StockListDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StockListDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.SeaGreen;
            this.StockListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StockListDataGridView_CellContentClick);
            this.StockListDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StockListDataGridView_CellContentDoubleClick);
            this.StockListDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.StockListDataGridView_CellMouseDoubleClick);
            // 
            // sCodeDataGridViewTextBoxColumn
            // 
            this.sCodeDataGridViewTextBoxColumn.DataPropertyName = "sCode";
            this.sCodeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.sCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sCodeDataGridViewTextBoxColumn.Name = "sCodeDataGridViewTextBoxColumn";
            // 
            // sDescriptionOneDataGridViewTextBoxColumn
            // 
            this.sDescriptionOneDataGridViewTextBoxColumn.DataPropertyName = "sDescriptionOne";
            this.sDescriptionOneDataGridViewTextBoxColumn.HeaderText = "Desc One";
            this.sDescriptionOneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sDescriptionOneDataGridViewTextBoxColumn.Name = "sDescriptionOneDataGridViewTextBoxColumn";
            // 
            // sDescriptionTwoDataGridViewTextBoxColumn
            // 
            this.sDescriptionTwoDataGridViewTextBoxColumn.DataPropertyName = "sDescriptionTwo";
            this.sDescriptionTwoDataGridViewTextBoxColumn.HeaderText = "Desc Two";
            this.sDescriptionTwoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sDescriptionTwoDataGridViewTextBoxColumn.Name = "sDescriptionTwoDataGridViewTextBoxColumn";
            // 
            // sCategoryDataGridViewTextBoxColumn
            // 
            this.sCategoryDataGridViewTextBoxColumn.DataPropertyName = "sCategory";
            this.sCategoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.sCategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sCategoryDataGridViewTextBoxColumn.Name = "sCategoryDataGridViewTextBoxColumn";
            // 
            // sInvoiceTypeDataGridViewTextBoxColumn
            // 
            this.sInvoiceTypeDataGridViewTextBoxColumn.DataPropertyName = "sInvoiceType";
            this.sInvoiceTypeDataGridViewTextBoxColumn.HeaderText = "Invoice Type";
            this.sInvoiceTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sInvoiceTypeDataGridViewTextBoxColumn.Name = "sInvoiceTypeDataGridViewTextBoxColumn";
            // 
            // sCostPriceDataGridViewTextBoxColumn
            // 
            this.sCostPriceDataGridViewTextBoxColumn.DataPropertyName = "sCostPrice";
            this.sCostPriceDataGridViewTextBoxColumn.HeaderText = "Cost Price";
            this.sCostPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sCostPriceDataGridViewTextBoxColumn.Name = "sCostPriceDataGridViewTextBoxColumn";
            // 
            // sSellingPriceDataGridViewTextBoxColumn
            // 
            this.sSellingPriceDataGridViewTextBoxColumn.DataPropertyName = "sSellingPrice";
            this.sSellingPriceDataGridViewTextBoxColumn.HeaderText = "Selling Price";
            this.sSellingPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sSellingPriceDataGridViewTextBoxColumn.Name = "sSellingPriceDataGridViewTextBoxColumn";
            // 
            // sTotalPurchasesDataGridViewTextBoxColumn
            // 
            this.sTotalPurchasesDataGridViewTextBoxColumn.DataPropertyName = "sTotalPurchases";
            this.sTotalPurchasesDataGridViewTextBoxColumn.HeaderText = "Total Purchases";
            this.sTotalPurchasesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTotalPurchasesDataGridViewTextBoxColumn.Name = "sTotalPurchasesDataGridViewTextBoxColumn";
            // 
            // sTotalSalesDataGridViewTextBoxColumn
            // 
            this.sTotalSalesDataGridViewTextBoxColumn.DataPropertyName = "sTotalSales";
            this.sTotalSalesDataGridViewTextBoxColumn.HeaderText = "Total Sales";
            this.sTotalSalesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTotalSalesDataGridViewTextBoxColumn.Name = "sTotalSalesDataGridViewTextBoxColumn";
            // 
            // sQtyPurchasedDataGridViewTextBoxColumn
            // 
            this.sQtyPurchasedDataGridViewTextBoxColumn.DataPropertyName = "sQtyPurchased";
            this.sQtyPurchasedDataGridViewTextBoxColumn.HeaderText = "Qty Purchased";
            this.sQtyPurchasedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sQtyPurchasedDataGridViewTextBoxColumn.Name = "sQtyPurchasedDataGridViewTextBoxColumn";
            // 
            // sQtySoldDataGridViewTextBoxColumn
            // 
            this.sQtySoldDataGridViewTextBoxColumn.DataPropertyName = "sQtySold";
            this.sQtySoldDataGridViewTextBoxColumn.HeaderText = "Qty Sold";
            this.sQtySoldDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sQtySoldDataGridViewTextBoxColumn.Name = "sQtySoldDataGridViewTextBoxColumn";
            // 
            // sOnHandDataGridViewTextBoxColumn
            // 
            this.sOnHandDataGridViewTextBoxColumn.DataPropertyName = "sOnHand";
            this.sOnHandDataGridViewTextBoxColumn.HeaderText = "On Hand";
            this.sOnHandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sOnHandDataGridViewTextBoxColumn.Name = "sOnHandDataGridViewTextBoxColumn";
            // 
            // stocksBindingSource
            // 
            this.stocksBindingSource.DataMember = "Stocks";
            this.stocksBindingSource.DataSource = this.aMEnterpriseProgramDataSetBindingSource;
            // 
            // aMEnterpriseProgramDataSetBindingSource
            // 
            this.aMEnterpriseProgramDataSetBindingSource.DataSource = this._AM_Enterprise_ProgramDataSet;
            this.aMEnterpriseProgramDataSetBindingSource.Position = 0;
            // 
            // _AM_Enterprise_ProgramDataSet
            // 
            this._AM_Enterprise_ProgramDataSet.DataSetName = "_AM_Enterprise_ProgramDataSet";
            this._AM_Enterprise_ProgramDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stocksTableAdapter
            // 
            this.stocksTableAdapter.ClearBeforeFill = true;
            // 
            // StockList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 380);
            this.Controls.Add(this.StockListDataGridView);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "StockList";
            this.Text = "StockList";
            this.Load += new System.EventHandler(this.StockList_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aM_EnterpriseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMEnterpriseProgramDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._AM_Enterprise_ProgramDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox SearchTB;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button AddBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton SearchBtn;
        private AM_EnterpriseDataSet1 aM_EnterpriseDataSet1;
        private System.Windows.Forms.BindingSource tblStockBindingSource;
        private AM_EnterpriseDataSet1TableAdapters.tblStockTableAdapter tblStockTableAdapter;
        private AM_EnterpriseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        public Guna.UI2.WinForms.Guna2DataGridView StockListDataGridView;
        private System.Windows.Forms.BindingSource aMEnterpriseProgramDataSetBindingSource;
        private _AM_Enterprise_ProgramDataSet _AM_Enterprise_ProgramDataSet;
        private System.Windows.Forms.BindingSource stocksBindingSource;
        private _AM_Enterprise_ProgramDataSetTableAdapters.StocksTableAdapter stocksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDescriptionOneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDescriptionTwoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sInvoiceTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCostPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSellingPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTotalPurchasesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTotalSalesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sQtyPurchasedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sQtySoldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOnHandDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Button UpdateBtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}