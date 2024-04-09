
namespace AmmarahKader_XactERP_Project.View
{
    partial class UserList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.SearchBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SearchTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UserDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.uNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uEmailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uContactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uUsernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._AM_Enterprise_ProgramDataSet = new AmmarahKader_XactERP_Project._AM_Enterprise_ProgramDataSet();
            this.tblUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aM_EnterpriseDataSet = new AmmarahKader_XactERP_Project.AM_EnterpriseDataSet();
            this.tblUserTableAdapter = new AmmarahKader_XactERP_Project.AM_EnterpriseDataSetTableAdapters.tblUserTableAdapter();
            this.tableAdapterManager = new AmmarahKader_XactERP_Project.AM_EnterpriseDataSetTableAdapters.TableAdapterManager();
            this.usersTableAdapter = new AmmarahKader_XactERP_Project._AM_Enterprise_ProgramDataSetTableAdapters.UsersTableAdapter();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._AM_Enterprise_ProgramDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aM_EnterpriseDataSet)).BeginInit();
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
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(570, 116);
            this.guna2Panel1.TabIndex = 2;
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
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "User List";
            // 
            // UserDataGridView
            // 
            this.UserDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.UserDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UserDataGridView.AutoGenerateColumns = false;
            this.UserDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UserDataGridView.ColumnHeadersHeight = 50;
            this.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.UserDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uNameDataGridViewTextBoxColumn,
            this.uSurnameDataGridViewTextBoxColumn,
            this.uEmailAddressDataGridViewTextBoxColumn,
            this.uContactNumberDataGridViewTextBoxColumn,
            this.uUsernameDataGridViewTextBoxColumn});
            this.UserDataGridView.DataSource = this.usersBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(217)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.UserDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UserDataGridView.Location = new System.Drawing.Point(32, 134);
            this.UserDataGridView.Margin = new System.Windows.Forms.Padding(7);
            this.UserDataGridView.Name = "UserDataGridView";
            this.UserDataGridView.RowHeadersVisible = false;
            this.UserDataGridView.RowHeadersWidth = 51;
            this.UserDataGridView.RowTemplate.Height = 24;
            this.UserDataGridView.Size = new System.Drawing.Size(526, 221);
            this.UserDataGridView.TabIndex = 3;
            this.UserDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.UserDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.UserDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.UserDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.UserDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.UserDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.UserDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UserDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.SeaGreen;
            this.UserDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.UserDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.UserDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.UserDataGridView.ThemeStyle.HeaderStyle.Height = 50;
            this.UserDataGridView.ThemeStyle.ReadOnly = false;
            this.UserDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.UserDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UserDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.SeaGreen;
            this.UserDataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.UserDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UserDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.SeaGreen;
            this.UserDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserDataGridView_CellContentClick);
            this.UserDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserDataGridView_CellContentDoubleClick);
            this.UserDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.UserDataGridView_CellFormatting);
            this.UserDataGridView.DoubleClick += new System.EventHandler(this.UserDataGridView_DoubleClick);
            // 
            // uNameDataGridViewTextBoxColumn
            // 
            this.uNameDataGridViewTextBoxColumn.DataPropertyName = "uName";
            this.uNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.uNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uNameDataGridViewTextBoxColumn.Name = "uNameDataGridViewTextBoxColumn";
            // 
            // uSurnameDataGridViewTextBoxColumn
            // 
            this.uSurnameDataGridViewTextBoxColumn.DataPropertyName = "uSurname";
            this.uSurnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.uSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uSurnameDataGridViewTextBoxColumn.Name = "uSurnameDataGridViewTextBoxColumn";
            // 
            // uEmailAddressDataGridViewTextBoxColumn
            // 
            this.uEmailAddressDataGridViewTextBoxColumn.DataPropertyName = "uEmailAddress";
            this.uEmailAddressDataGridViewTextBoxColumn.HeaderText = "Email Address";
            this.uEmailAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uEmailAddressDataGridViewTextBoxColumn.Name = "uEmailAddressDataGridViewTextBoxColumn";
            // 
            // uContactNumberDataGridViewTextBoxColumn
            // 
            this.uContactNumberDataGridViewTextBoxColumn.DataPropertyName = "uContactNumber";
            this.uContactNumberDataGridViewTextBoxColumn.HeaderText = "Contact Number";
            this.uContactNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uContactNumberDataGridViewTextBoxColumn.Name = "uContactNumberDataGridViewTextBoxColumn";
            // 
            // uUsernameDataGridViewTextBoxColumn
            // 
            this.uUsernameDataGridViewTextBoxColumn.DataPropertyName = "uUsername";
            this.uUsernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.uUsernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uUsernameDataGridViewTextBoxColumn.Name = "uUsernameDataGridViewTextBoxColumn";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this._AM_Enterprise_ProgramDataSet;
            // 
            // _AM_Enterprise_ProgramDataSet
            // 
            this._AM_Enterprise_ProgramDataSet.DataSetName = "_AM_Enterprise_ProgramDataSet";
            this._AM_Enterprise_ProgramDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUserBindingSource
            // 
            this.tblUserBindingSource.DataMember = "tblUser";
            this.tblUserBindingSource.DataSource = this.aM_EnterpriseDataSet;
            // 
            // aM_EnterpriseDataSet
            // 
            this.aM_EnterpriseDataSet.DataSetName = "AM_EnterpriseDataSet";
            this.aM_EnterpriseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUserTableAdapter
            // 
            this.tblUserTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblUserTableAdapter = this.tblUserTableAdapter;
            this.tableAdapterManager.UpdateOrder = AmmarahKader_XactERP_Project.AM_EnterpriseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 378);
            this.Controls.Add(this.UserDataGridView);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UserList";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._AM_Enterprise_ProgramDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aM_EnterpriseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox SearchTB;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button AddBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton SearchBtn;
        public Guna.UI2.WinForms.Guna2DataGridView UserDataGridView;
        private AM_EnterpriseDataSet aM_EnterpriseDataSet;
        private System.Windows.Forms.BindingSource tblUserBindingSource;
        private AM_EnterpriseDataSetTableAdapters.tblUserTableAdapter tblUserTableAdapter;
        private AM_EnterpriseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uEmailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uContactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uUsernameDataGridViewTextBoxColumn;
        private _AM_Enterprise_ProgramDataSet _AM_Enterprise_ProgramDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private _AM_Enterprise_ProgramDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
    }
}