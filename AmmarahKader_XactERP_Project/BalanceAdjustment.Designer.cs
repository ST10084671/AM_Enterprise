namespace AmmarahKader_XactERP_Project
{
    partial class BalanceAdjustment
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.UpdateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CloseBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.AccountCodeCB = new System.Windows.Forms.ComboBox();
            this.debtorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._AM_Enterprise_ProgramDataSet = new AmmarahKader_XactERP_Project._AM_Enterprise_ProgramDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.SalesYearTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NewBalanceTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BalanceTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.debtorsTableAdapter = new AmmarahKader_XactERP_Project._AM_Enterprise_ProgramDataSetTableAdapters.DebtorsTableAdapter();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._AM_Enterprise_ProgramDataSet)).BeginInit();
            this.guna2Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Honeydew;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.DarkSeaGreen;
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(759, 55);
            this.guna2Panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adjust Debtor Balance Details";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Honeydew;
            this.guna2Panel2.Controls.Add(this.UpdateBtn);
            this.guna2Panel2.Controls.Add(this.CloseBtn);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.DarkSeaGreen;
            this.guna2Panel2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 370);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(759, 80);
            this.guna2Panel2.TabIndex = 22;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Animated = true;
            this.UpdateBtn.AutoRoundedCorners = true;
            this.UpdateBtn.BackColor = System.Drawing.Color.Transparent;
            this.UpdateBtn.BorderColor = System.Drawing.Color.SeaGreen;
            this.UpdateBtn.BorderRadius = 16;
            this.UpdateBtn.BorderThickness = 1;
            this.UpdateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateBtn.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.UpdateBtn.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 10.2F);
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.IndicateFocus = true;
            this.UpdateBtn.Location = new System.Drawing.Point(12, 22);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(106, 34);
            this.UpdateBtn.TabIndex = 9;
            this.UpdateBtn.Text = "SAVE";
            this.UpdateBtn.UseTransparentBackground = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Animated = true;
            this.CloseBtn.AutoRoundedCorners = true;
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.BorderColor = System.Drawing.Color.SeaGreen;
            this.CloseBtn.BorderRadius = 16;
            this.CloseBtn.BorderThickness = 1;
            this.CloseBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CloseBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CloseBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CloseBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CloseBtn.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.CloseBtn.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 10.2F);
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.IndicateFocus = true;
            this.CloseBtn.Location = new System.Drawing.Point(640, 22);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(106, 34);
            this.CloseBtn.TabIndex = 7;
            this.CloseBtn.Text = "CLOSE";
            this.CloseBtn.UseTransparentBackground = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = System.Drawing.Color.SeaGreen;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.AccountCodeCB);
            this.guna2Panel3.Controls.Add(this.label5);
            this.guna2Panel3.Location = new System.Drawing.Point(12, 61);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(363, 138);
            this.guna2Panel3.TabIndex = 24;
            // 
            // AccountCodeCB
            // 
            this.AccountCodeCB.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.AccountCodeCB.DataSource = this.debtorsBindingSource;
            this.AccountCodeCB.DisplayMember = "dAccountCode";
            this.AccountCodeCB.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountCodeCB.ForeColor = System.Drawing.Color.Honeydew;
            this.AccountCodeCB.FormattingEnabled = true;
            this.AccountCodeCB.Location = new System.Drawing.Point(132, 4);
            this.AccountCodeCB.Name = "AccountCodeCB";
            this.AccountCodeCB.Size = new System.Drawing.Size(221, 28);
            this.AccountCodeCB.TabIndex = 1;
            this.AccountCodeCB.ValueMember = "dAccountCode";
            this.AccountCodeCB.SelectedIndexChanged += new System.EventHandler(this.AccountCodeCB_SelectedIndexChanged);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Account Code:";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderColor = System.Drawing.Color.SeaGreen;
            this.guna2Panel4.BorderThickness = 1;
            this.guna2Panel4.Controls.Add(this.SalesYearTB);
            this.guna2Panel4.Controls.Add(this.label6);
            this.guna2Panel4.Controls.Add(this.NewBalanceTB);
            this.guna2Panel4.Controls.Add(this.label4);
            this.guna2Panel4.Controls.Add(this.BalanceTB);
            this.guna2Panel4.Controls.Add(this.label7);
            this.guna2Panel4.Location = new System.Drawing.Point(381, 61);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(365, 138);
            this.guna2Panel4.TabIndex = 23;
            // 
            // SalesYearTB
            // 
            this.SalesYearTB.BackColor = System.Drawing.Color.SeaGreen;
            this.SalesYearTB.BorderColor = System.Drawing.Color.SeaGreen;
            this.SalesYearTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SalesYearTB.DefaultText = "";
            this.SalesYearTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SalesYearTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SalesYearTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SalesYearTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SalesYearTB.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.SalesYearTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SalesYearTB.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesYearTB.ForeColor = System.Drawing.Color.White;
            this.SalesYearTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SalesYearTB.Location = new System.Drawing.Point(167, 10);
            this.SalesYearTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SalesYearTB.Name = "SalesYearTB";
            this.SalesYearTB.PasswordChar = '\0';
            this.SalesYearTB.PlaceholderText = "";
            this.SalesYearTB.SelectedText = "";
            this.SalesYearTB.Size = new System.Drawing.Size(186, 21);
            this.SalesYearTB.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SeaGreen;
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Sales Year To date:";
            // 
            // NewBalanceTB
            // 
            this.NewBalanceTB.BackColor = System.Drawing.Color.SeaGreen;
            this.NewBalanceTB.BorderColor = System.Drawing.Color.SeaGreen;
            this.NewBalanceTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NewBalanceTB.DefaultText = "";
            this.NewBalanceTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NewBalanceTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NewBalanceTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewBalanceTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewBalanceTB.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.NewBalanceTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewBalanceTB.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewBalanceTB.ForeColor = System.Drawing.Color.White;
            this.NewBalanceTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewBalanceTB.Location = new System.Drawing.Point(167, 102);
            this.NewBalanceTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewBalanceTB.Name = "NewBalanceTB";
            this.NewBalanceTB.PasswordChar = '\0';
            this.NewBalanceTB.PlaceholderText = "";
            this.NewBalanceTB.SelectedText = "";
            this.NewBalanceTB.Size = new System.Drawing.Size(186, 21);
            this.NewBalanceTB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(3, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "New Amount Added:";
            // 
            // BalanceTB
            // 
            this.BalanceTB.BackColor = System.Drawing.Color.SeaGreen;
            this.BalanceTB.BorderColor = System.Drawing.Color.SeaGreen;
            this.BalanceTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BalanceTB.DefaultText = "";
            this.BalanceTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BalanceTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BalanceTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BalanceTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BalanceTB.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.BalanceTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BalanceTB.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceTB.ForeColor = System.Drawing.Color.White;
            this.BalanceTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BalanceTB.Location = new System.Drawing.Point(167, 40);
            this.BalanceTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BalanceTB.Name = "BalanceTB";
            this.BalanceTB.PasswordChar = '\0';
            this.BalanceTB.PlaceholderText = "";
            this.BalanceTB.SelectedText = "";
            this.BalanceTB.Size = new System.Drawing.Size(186, 21);
            this.BalanceTB.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SeaGreen;
            this.label7.Location = new System.Drawing.Point(3, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Current Balance:";
            // 
            // debtorsTableAdapter
            // 
            this.debtorsTableAdapter.ClearBeforeFill = true;
            // 
            // BalanceAdjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "BalanceAdjustment";
            this.Text = "BalanceAdjustment";
            this.Load += new System.EventHandler(this.BalanceAdjustment_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._AM_Enterprise_ProgramDataSet)).EndInit();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button UpdateBtn;
        private Guna.UI2.WinForms.Guna2Button CloseBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.ComboBox AccountCodeCB;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        public Guna.UI2.WinForms.Guna2TextBox SalesYearTB;
        private System.Windows.Forms.Label label6;
        public Guna.UI2.WinForms.Guna2TextBox NewBalanceTB;
        private System.Windows.Forms.Label label4;
        public Guna.UI2.WinForms.Guna2TextBox BalanceTB;
        private System.Windows.Forms.Label label7;
        private _AM_Enterprise_ProgramDataSet _AM_Enterprise_ProgramDataSet;
        private System.Windows.Forms.BindingSource debtorsBindingSource;
        private _AM_Enterprise_ProgramDataSetTableAdapters.DebtorsTableAdapter debtorsTableAdapter;
    }
}