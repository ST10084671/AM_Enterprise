
namespace AmmarahKader_XactERP_Project.View
{
    partial class DebtorList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebtorList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.AdjustBalanceBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SearchBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SearchTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DebtorListDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.debtorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._AM_Enterprise_ProgramDataSet = new AmmarahKader_XactERP_Project._AM_Enterprise_ProgramDataSet();
            this.tblDebtorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aM_EnterpriseDataSet1 = new AmmarahKader_XactERP_Project.AM_EnterpriseDataSet1();
            this.tblDebtorTableAdapter = new AmmarahKader_XactERP_Project.AM_EnterpriseDataSet1TableAdapters.tblDebtorTableAdapter();
            this.tableAdapterManager = new AmmarahKader_XactERP_Project.AM_EnterpriseDataSet1TableAdapters.TableAdapterManager();
            this.debtorsTableAdapter = new AmmarahKader_XactERP_Project._AM_Enterprise_ProgramDataSetTableAdapters.DebtorsTableAdapter();
            this.dAccountCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dAddressOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dAddressTwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dAddressThree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dInvoiceTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dContactNumberOneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dContactNumberTwoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dSalesYearToDte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dCostYearToDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dCreditLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DebtorListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._AM_Enterprise_ProgramDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDebtorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aM_EnterpriseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.AdjustBalanceBtn);
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
            this.guna2Panel1.Size = new System.Drawing.Size(571, 116);
            this.guna2Panel1.TabIndex = 3;
            // 
            // AdjustBalanceBtn
            // 
            this.AdjustBalanceBtn.Animated = true;
            this.AdjustBalanceBtn.AutoRoundedCorners = true;
            this.AdjustBalanceBtn.BackColor = System.Drawing.Color.Transparent;
            this.AdjustBalanceBtn.BorderColor = System.Drawing.Color.Honeydew;
            this.AdjustBalanceBtn.BorderRadius = 14;
            this.AdjustBalanceBtn.BorderThickness = 1;
            this.AdjustBalanceBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AdjustBalanceBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AdjustBalanceBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AdjustBalanceBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AdjustBalanceBtn.FillColor = System.Drawing.Color.SeaGreen;
            this.AdjustBalanceBtn.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 10.2F);
            this.AdjustBalanceBtn.ForeColor = System.Drawing.Color.White;
            this.AdjustBalanceBtn.IndicateFocus = true;
            this.AdjustBalanceBtn.Location = new System.Drawing.Point(396, 45);
            this.AdjustBalanceBtn.Name = "AdjustBalanceBtn";
            this.AdjustBalanceBtn.Size = new System.Drawing.Size(162, 30);
            this.AdjustBalanceBtn.TabIndex = 14;
            this.AdjustBalanceBtn.Text = "Adjust Balance";
            this.AdjustBalanceBtn.UseTransparentBackground = true;
            this.AdjustBalanceBtn.Click += new System.EventHandler(this.AdjustBalanceBtn_Click);
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
            this.UpdateBtn.Location = new System.Drawing.Point(480, 9);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(78, 30);
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
            this.AddBtn.Location = new System.Drawing.Point(396, 8);
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
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Debtor List";
            // 
            // DebtorListDataGridView
            // 
            this.DebtorListDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DebtorListDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DebtorListDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DebtorListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DebtorListDataGridView.ColumnHeadersHeight = 50;
            this.DebtorListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DebtorListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dAccountCode,
            this.dAddressOne,
            this.dAddressTwo,
            this.dAddressThree,
            this.dCategoryDataGridViewTextBoxColumn,
            this.dInvoiceTypeDataGridViewTextBoxColumn,
            this.dContactNumberOneDataGridViewTextBoxColumn,
            this.dContactNumberTwoDataGridViewTextBoxColumn,
            this.dSalesYearToDte,
            this.dCostYearToDateDataGridViewTextBoxColumn,
            this.dBalanceDataGridViewTextBoxColumn,
            this.dCreditLimit});
            this.DebtorListDataGridView.DataSource = this.debtorsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(217)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DebtorListDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.DebtorListDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DebtorListDataGridView.Location = new System.Drawing.Point(32, 134);
            this.DebtorListDataGridView.Name = "DebtorListDataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DebtorListDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DebtorListDataGridView.RowHeadersVisible = false;
            this.DebtorListDataGridView.RowHeadersWidth = 51;
            this.DebtorListDataGridView.RowTemplate.Height = 24;
            this.DebtorListDataGridView.Size = new System.Drawing.Size(526, 221);
            this.DebtorListDataGridView.TabIndex = 4;
            this.DebtorListDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DebtorListDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DebtorListDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DebtorListDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DebtorListDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DebtorListDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DebtorListDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DebtorListDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DebtorListDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DebtorListDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebtorListDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DebtorListDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DebtorListDataGridView.ThemeStyle.HeaderStyle.Height = 50;
            this.DebtorListDataGridView.ThemeStyle.ReadOnly = false;
            this.DebtorListDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DebtorListDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DebtorListDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebtorListDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DebtorListDataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.DebtorListDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DebtorListDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DebtorListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DebtorListDataGridView_CellContentClick);
            // 
            // debtorsBindingSource
            // 
            this.debtorsBindingSource.DataMember = "Debtors";
            this.debtorsBindingSource.DataSource = this._AM_Enterprise_ProgramDataSet;
            // 
            // _AM_Enterprise_ProgramDataSet
            // 
            this._AM_Enterprise_ProgramDataSet.DataSetName = "_AM_Enterprise_ProgramDataSet";
            this._AM_Enterprise_ProgramDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDebtorBindingSource
            // 
            this.tblDebtorBindingSource.DataMember = "tblDebtor";
            this.tblDebtorBindingSource.DataSource = this.aM_EnterpriseDataSet1;
            // 
            // aM_EnterpriseDataSet1
            // 
            this.aM_EnterpriseDataSet1.DataSetName = "AM_EnterpriseDataSet1";
            this.aM_EnterpriseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDebtorTableAdapter
            // 
            this.tblDebtorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblDebtorTableAdapter = this.tblDebtorTableAdapter;
            this.tableAdapterManager.tblStockTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AmmarahKader_XactERP_Project.AM_EnterpriseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // debtorsTableAdapter
            // 
            this.debtorsTableAdapter.ClearBeforeFill = true;
            // 
            // dAccountCode
            // 
            this.dAccountCode.DataPropertyName = "dAccountCode";
            this.dAccountCode.HeaderText = "Acc Code";
            this.dAccountCode.MinimumWidth = 6;
            this.dAccountCode.Name = "dAccountCode";
            // 
            // dAddressOne
            // 
            this.dAddressOne.DataPropertyName = "dAddressOne";
            this.dAddressOne.HeaderText = "Address One";
            this.dAddressOne.MinimumWidth = 6;
            this.dAddressOne.Name = "dAddressOne";
            // 
            // dAddressTwo
            // 
            this.dAddressTwo.DataPropertyName = "dAddressTwo";
            this.dAddressTwo.HeaderText = "Address Two";
            this.dAddressTwo.MinimumWidth = 6;
            this.dAddressTwo.Name = "dAddressTwo";
            // 
            // dAddressThree
            // 
            this.dAddressThree.DataPropertyName = "dAddressThree";
            this.dAddressThree.HeaderText = "Address Three";
            this.dAddressThree.MinimumWidth = 6;
            this.dAddressThree.Name = "dAddressThree";
            // 
            // dCategoryDataGridViewTextBoxColumn
            // 
            this.dCategoryDataGridViewTextBoxColumn.DataPropertyName = "dCategory";
            this.dCategoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.dCategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dCategoryDataGridViewTextBoxColumn.Name = "dCategoryDataGridViewTextBoxColumn";
            // 
            // dInvoiceTypeDataGridViewTextBoxColumn
            // 
            this.dInvoiceTypeDataGridViewTextBoxColumn.DataPropertyName = "dInvoiceType";
            this.dInvoiceTypeDataGridViewTextBoxColumn.HeaderText = "Invoice Type";
            this.dInvoiceTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dInvoiceTypeDataGridViewTextBoxColumn.Name = "dInvoiceTypeDataGridViewTextBoxColumn";
            // 
            // dContactNumberOneDataGridViewTextBoxColumn
            // 
            this.dContactNumberOneDataGridViewTextBoxColumn.DataPropertyName = "dContactNumberOne";
            this.dContactNumberOneDataGridViewTextBoxColumn.HeaderText = "Email Address";
            this.dContactNumberOneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dContactNumberOneDataGridViewTextBoxColumn.Name = "dContactNumberOneDataGridViewTextBoxColumn";
            // 
            // dContactNumberTwoDataGridViewTextBoxColumn
            // 
            this.dContactNumberTwoDataGridViewTextBoxColumn.DataPropertyName = "dContactNumberTwo";
            this.dContactNumberTwoDataGridViewTextBoxColumn.HeaderText = "Contact No. 2";
            this.dContactNumberTwoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dContactNumberTwoDataGridViewTextBoxColumn.Name = "dContactNumberTwoDataGridViewTextBoxColumn";
            // 
            // dSalesYearToDte
            // 
            this.dSalesYearToDte.DataPropertyName = "dSalesYearToDte";
            this.dSalesYearToDte.HeaderText = "Sales Year";
            this.dSalesYearToDte.MinimumWidth = 6;
            this.dSalesYearToDte.Name = "dSalesYearToDte";
            // 
            // dCostYearToDateDataGridViewTextBoxColumn
            // 
            this.dCostYearToDateDataGridViewTextBoxColumn.DataPropertyName = "dCostYearToDate";
            this.dCostYearToDateDataGridViewTextBoxColumn.HeaderText = "Cost Year ";
            this.dCostYearToDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dCostYearToDateDataGridViewTextBoxColumn.Name = "dCostYearToDateDataGridViewTextBoxColumn";
            // 
            // dBalanceDataGridViewTextBoxColumn
            // 
            this.dBalanceDataGridViewTextBoxColumn.DataPropertyName = "dBalance";
            this.dBalanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.dBalanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dBalanceDataGridViewTextBoxColumn.Name = "dBalanceDataGridViewTextBoxColumn";
            // 
            // dCreditLimit
            // 
            this.dCreditLimit.DataPropertyName = "dCreditLimit";
            this.dCreditLimit.HeaderText = "Credit Limit";
            this.dCreditLimit.MinimumWidth = 6;
            this.dCreditLimit.Name = "dCreditLimit";
            // 
            // DebtorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 378);
            this.Controls.Add(this.DebtorListDataGridView);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "DebtorList";
            this.Text = "DebtorList";
            this.Load += new System.EventHandler(this.DebtorList_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DebtorListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._AM_Enterprise_ProgramDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDebtorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aM_EnterpriseDataSet1)).EndInit();
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
        private System.Windows.Forms.BindingSource tblDebtorBindingSource;
        private AM_EnterpriseDataSet1TableAdapters.tblDebtorTableAdapter tblDebtorTableAdapter;
        private AM_EnterpriseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        public Guna.UI2.WinForms.Guna2DataGridView DebtorListDataGridView;
        private _AM_Enterprise_ProgramDataSet _AM_Enterprise_ProgramDataSet;
        private System.Windows.Forms.BindingSource debtorsBindingSource;
        private _AM_Enterprise_ProgramDataSetTableAdapters.DebtorsTableAdapter debtorsTableAdapter;
        private Guna.UI2.WinForms.Guna2Button UpdateBtn;
        private Guna.UI2.WinForms.Guna2Button AdjustBalanceBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAccountCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAddressOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAddressTwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAddressThree;
        private System.Windows.Forms.DataGridViewTextBoxColumn dCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dInvoiceTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dContactNumberOneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dContactNumberTwoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dSalesYearToDte;
        private System.Windows.Forms.DataGridViewTextBoxColumn dCostYearToDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dCreditLimit;
    }
}