
namespace AmmarahKader_XactERP_Project.View
{
    partial class TransactionDebtor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionDebtor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.FilterCB = new System.Windows.Forms.ComboBox();
            this.SelectDebtorCB = new System.Windows.Forms.ComboBox();
            this.debtorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._AM_Enterprise_ProgramDataSet = new AmmarahKader_XactERP_Project._AM_Enterprise_ProgramDataSet();
            this.ExitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DebtorTransactionDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.iAccountCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iVatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTransactionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDocumentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.debtorsTableAdapter = new AmmarahKader_XactERP_Project._AM_Enterprise_ProgramDataSetTableAdapters.DebtorsTableAdapter();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._AM_Enterprise_ProgramDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DebtorTransactionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.FilterCB);
            this.guna2Panel1.Controls.Add(this.SelectDebtorCB);
            this.guna2Panel1.Controls.Add(this.ExitBtn);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.DarkSeaGreen;
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(650, 116);
            this.guna2Panel1.TabIndex = 4;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.Location = new System.Drawing.Point(218, 72);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(26, 29);
            this.guna2Button1.TabIndex = 16;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
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
            this.FilterCB.SelectedIndexChanged += new System.EventHandler(this.FilterCB_SelectedIndexChanged);
            // 
            // SelectDebtorCB
            // 
            this.SelectDebtorCB.DataSource = this.debtorsBindingSource;
            this.SelectDebtorCB.DisplayMember = "dAccountCode";
            this.SelectDebtorCB.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectDebtorCB.ForeColor = System.Drawing.Color.SeaGreen;
            this.SelectDebtorCB.FormattingEnabled = true;
            this.SelectDebtorCB.Location = new System.Drawing.Point(297, 16);
            this.SelectDebtorCB.Name = "SelectDebtorCB";
            this.SelectDebtorCB.Size = new System.Drawing.Size(180, 29);
            this.SelectDebtorCB.TabIndex = 14;
            this.SelectDebtorCB.ValueMember = "dAccountCode";
            this.SelectDebtorCB.SelectedIndexChanged += new System.EventHandler(this.SelectDebtorCB_SelectedIndexChanged);
            this.SelectDebtorCB.SelectionChangeCommitted += new System.EventHandler(this.SelectDebtorCB_SelectionChangeCommitted);
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
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Debtor Transaction List";
            // 
            // DebtorTransactionDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DebtorTransactionDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DebtorTransactionDataGridView.AutoGenerateColumns = false;
            this.DebtorTransactionDataGridView.BackgroundColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(217)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(217)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DebtorTransactionDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DebtorTransactionDataGridView.ColumnHeadersHeight = 50;
            this.DebtorTransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DebtorTransactionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iAccountCodeDataGridViewTextBoxColumn,
            this.iDateDataGridViewTextBoxColumn,
            this.iVatDataGridViewTextBoxColumn,
            this.iTotalDataGridViewTextBoxColumn,
            this.iTransactionTypeDataGridViewTextBoxColumn,
            this.iDocumentNumberDataGridViewTextBoxColumn});
            this.DebtorTransactionDataGridView.DataSource = this.invoicesBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DebtorTransactionDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.DebtorTransactionDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DebtorTransactionDataGridView.Location = new System.Drawing.Point(32, 140);
            this.DebtorTransactionDataGridView.Name = "DebtorTransactionDataGridView";
            this.DebtorTransactionDataGridView.RowHeadersVisible = false;
            this.DebtorTransactionDataGridView.RowHeadersWidth = 51;
            this.DebtorTransactionDataGridView.RowTemplate.Height = 24;
            this.DebtorTransactionDataGridView.Size = new System.Drawing.Size(586, 236);
            this.DebtorTransactionDataGridView.TabIndex = 5;
            this.DebtorTransactionDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DebtorTransactionDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DebtorTransactionDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DebtorTransactionDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DebtorTransactionDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DebtorTransactionDataGridView.ThemeStyle.BackColor = System.Drawing.Color.Honeydew;
            this.DebtorTransactionDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DebtorTransactionDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DebtorTransactionDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DebtorTransactionDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebtorTransactionDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DebtorTransactionDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DebtorTransactionDataGridView.ThemeStyle.HeaderStyle.Height = 50;
            this.DebtorTransactionDataGridView.ThemeStyle.ReadOnly = false;
            this.DebtorTransactionDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DebtorTransactionDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DebtorTransactionDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebtorTransactionDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DebtorTransactionDataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.DebtorTransactionDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DebtorTransactionDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // iAccountCodeDataGridViewTextBoxColumn
            // 
            this.iAccountCodeDataGridViewTextBoxColumn.DataPropertyName = "iAccountCode";
            this.iAccountCodeDataGridViewTextBoxColumn.HeaderText = "Account Code";
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
            // iVatDataGridViewTextBoxColumn
            // 
            this.iVatDataGridViewTextBoxColumn.DataPropertyName = "iVat";
            this.iVatDataGridViewTextBoxColumn.HeaderText = "Vat Value";
            this.iVatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iVatDataGridViewTextBoxColumn.Name = "iVatDataGridViewTextBoxColumn";
            // 
            // iTotalDataGridViewTextBoxColumn
            // 
            this.iTotalDataGridViewTextBoxColumn.DataPropertyName = "iTotal";
            this.iTotalDataGridViewTextBoxColumn.HeaderText = "Gross Trans Value";
            this.iTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iTotalDataGridViewTextBoxColumn.Name = "iTotalDataGridViewTextBoxColumn";
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
            this.iDocumentNumberDataGridViewTextBoxColumn.HeaderText = "Document No.";
            this.iDocumentNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDocumentNumberDataGridViewTextBoxColumn.Name = "iDocumentNumberDataGridViewTextBoxColumn";
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "Invoices";
            this.invoicesBindingSource.DataSource = this._AM_Enterprise_ProgramDataSet;
            // 
            // debtorsTableAdapter
            // 
            this.debtorsTableAdapter.ClearBeforeFill = true;
            // 
            // TransactionDebtor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.DebtorTransactionDataGridView);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "TransactionDebtor";
            this.Text = "TransactionDebtor";
            this.Load += new System.EventHandler(this.TransactionDebtor_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._AM_Enterprise_ProgramDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DebtorTransactionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView DebtorTransactionDataGridView;
        private Guna.UI2.WinForms.Guna2Button ExitBtn;
        private System.Windows.Forms.ComboBox FilterCB;
        private System.Windows.Forms.ComboBox SelectDebtorCB;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private _AM_Enterprise_ProgramDataSet _AM_Enterprise_ProgramDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn iAccountCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iVatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTransactionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDocumentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource debtorsBindingSource;
        private _AM_Enterprise_ProgramDataSetTableAdapters.DebtorsTableAdapter debtorsTableAdapter;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}