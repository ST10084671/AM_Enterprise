namespace AmmarahKader_XactERP_Project
{
    partial class StockAdjustment
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
            this.StockOnHandTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.QtyPurchasedTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NewStockTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.UpdateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CloseBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.StockCodeCB = new System.Windows.Forms.ComboBox();
            this.stocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aMEnterpriseProgramDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._AM_Enterprise_ProgramDataSet = new AmmarahKader_XactERP_Project._AM_Enterprise_ProgramDataSet();
            this.CategoryCB = new System.Windows.Forms.ComboBox();
            this.DescriptionTwoTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.DescriptionOneTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stocksTableAdapter = new AmmarahKader_XactERP_Project._AM_Enterprise_ProgramDataSetTableAdapters.StocksTableAdapter();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMEnterpriseProgramDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._AM_Enterprise_ProgramDataSet)).BeginInit();
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
            this.guna2Panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adjust Stock Details";
            // 
            // StockOnHandTB
            // 
            this.StockOnHandTB.BackColor = System.Drawing.Color.SeaGreen;
            this.StockOnHandTB.BorderColor = System.Drawing.Color.SeaGreen;
            this.StockOnHandTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StockOnHandTB.DefaultText = "";
            this.StockOnHandTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StockOnHandTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StockOnHandTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StockOnHandTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StockOnHandTB.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.StockOnHandTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StockOnHandTB.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockOnHandTB.ForeColor = System.Drawing.Color.White;
            this.StockOnHandTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StockOnHandTB.Location = new System.Drawing.Point(167, 40);
            this.StockOnHandTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StockOnHandTB.Name = "StockOnHandTB";
            this.StockOnHandTB.PasswordChar = '\0';
            this.StockOnHandTB.PlaceholderText = "";
            this.StockOnHandTB.SelectedText = "";
            this.StockOnHandTB.Size = new System.Drawing.Size(186, 21);
            this.StockOnHandTB.TabIndex = 6;
            this.StockOnHandTB.TextChanged += new System.EventHandler(this.StockOnHandTB_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SeaGreen;
            this.label7.Location = new System.Drawing.Point(3, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Stock On Hand:";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderColor = System.Drawing.Color.SeaGreen;
            this.guna2Panel4.BorderThickness = 1;
            this.guna2Panel4.Controls.Add(this.QtyPurchasedTB);
            this.guna2Panel4.Controls.Add(this.label6);
            this.guna2Panel4.Controls.Add(this.NewStockTB);
            this.guna2Panel4.Controls.Add(this.label4);
            this.guna2Panel4.Controls.Add(this.StockOnHandTB);
            this.guna2Panel4.Controls.Add(this.label7);
            this.guna2Panel4.Location = new System.Drawing.Point(381, 61);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(365, 138);
            this.guna2Panel4.TabIndex = 18;
            // 
            // QtyPurchasedTB
            // 
            this.QtyPurchasedTB.BackColor = System.Drawing.Color.SeaGreen;
            this.QtyPurchasedTB.BorderColor = System.Drawing.Color.SeaGreen;
            this.QtyPurchasedTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QtyPurchasedTB.DefaultText = "";
            this.QtyPurchasedTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.QtyPurchasedTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.QtyPurchasedTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QtyPurchasedTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QtyPurchasedTB.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.QtyPurchasedTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QtyPurchasedTB.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtyPurchasedTB.ForeColor = System.Drawing.Color.White;
            this.QtyPurchasedTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QtyPurchasedTB.Location = new System.Drawing.Point(167, 10);
            this.QtyPurchasedTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QtyPurchasedTB.Name = "QtyPurchasedTB";
            this.QtyPurchasedTB.PasswordChar = '\0';
            this.QtyPurchasedTB.PlaceholderText = "";
            this.QtyPurchasedTB.SelectedText = "";
            this.QtyPurchasedTB.Size = new System.Drawing.Size(186, 21);
            this.QtyPurchasedTB.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SeaGreen;
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Qty Purchased:";
            // 
            // NewStockTB
            // 
            this.NewStockTB.BackColor = System.Drawing.Color.SeaGreen;
            this.NewStockTB.BorderColor = System.Drawing.Color.SeaGreen;
            this.NewStockTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NewStockTB.DefaultText = "";
            this.NewStockTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NewStockTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NewStockTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewStockTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewStockTB.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.NewStockTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewStockTB.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewStockTB.ForeColor = System.Drawing.Color.White;
            this.NewStockTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewStockTB.Location = new System.Drawing.Point(167, 102);
            this.NewStockTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewStockTB.Name = "NewStockTB";
            this.NewStockTB.PasswordChar = '\0';
            this.NewStockTB.PlaceholderText = "";
            this.NewStockTB.SelectedText = "";
            this.NewStockTB.Size = new System.Drawing.Size(186, 21);
            this.NewStockTB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(3, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "New Stock Added:";
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
            this.guna2Panel2.TabIndex = 21;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
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
            this.guna2Panel3.Controls.Add(this.StockCodeCB);
            this.guna2Panel3.Controls.Add(this.CategoryCB);
            this.guna2Panel3.Controls.Add(this.DescriptionTwoTB);
            this.guna2Panel3.Controls.Add(this.DescriptionOneTB);
            this.guna2Panel3.Controls.Add(this.label2);
            this.guna2Panel3.Controls.Add(this.label3);
            this.guna2Panel3.Controls.Add(this.label);
            this.guna2Panel3.Controls.Add(this.label5);
            this.guna2Panel3.Location = new System.Drawing.Point(12, 61);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(363, 138);
            this.guna2Panel3.TabIndex = 22;
            // 
            // StockCodeCB
            // 
            this.StockCodeCB.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.StockCodeCB.DataSource = this.stocksBindingSource;
            this.StockCodeCB.DisplayMember = "sCode";
            this.StockCodeCB.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockCodeCB.ForeColor = System.Drawing.Color.Honeydew;
            this.StockCodeCB.FormattingEnabled = true;
            this.StockCodeCB.Location = new System.Drawing.Point(132, 4);
            this.StockCodeCB.Name = "StockCodeCB";
            this.StockCodeCB.Size = new System.Drawing.Size(221, 28);
            this.StockCodeCB.TabIndex = 1;
            this.StockCodeCB.ValueMember = "sCode";
            this.StockCodeCB.SelectedIndexChanged += new System.EventHandler(this.StockCodeCB_SelectedIndexChanged);
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
            // CategoryCB
            // 
            this.CategoryCB.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.CategoryCB.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryCB.ForeColor = System.Drawing.Color.Honeydew;
            this.CategoryCB.FormattingEnabled = true;
            this.CategoryCB.Items.AddRange(new object[] {
            "SUV",
            "Coupe",
            "Truck",
            "Wagon",
            "Hatchback",
            "Sedan",
            "Crossover",
            "MPV",
            "Convertible",
            "Sports car"});
            this.CategoryCB.Location = new System.Drawing.Point(132, 102);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.Size = new System.Drawing.Size(221, 28);
            this.CategoryCB.TabIndex = 4;
            // 
            // DescriptionTwoTB
            // 
            this.DescriptionTwoTB.BackColor = System.Drawing.Color.SeaGreen;
            this.DescriptionTwoTB.BorderColor = System.Drawing.Color.SeaGreen;
            this.DescriptionTwoTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DescriptionTwoTB.DefaultText = "";
            this.DescriptionTwoTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DescriptionTwoTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DescriptionTwoTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DescriptionTwoTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DescriptionTwoTB.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.DescriptionTwoTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DescriptionTwoTB.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTwoTB.ForeColor = System.Drawing.Color.White;
            this.DescriptionTwoTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DescriptionTwoTB.Location = new System.Drawing.Point(132, 71);
            this.DescriptionTwoTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DescriptionTwoTB.Name = "DescriptionTwoTB";
            this.DescriptionTwoTB.PasswordChar = '\0';
            this.DescriptionTwoTB.PlaceholderText = "";
            this.DescriptionTwoTB.SelectedText = "";
            this.DescriptionTwoTB.Size = new System.Drawing.Size(221, 23);
            this.DescriptionTwoTB.TabIndex = 3;
            // 
            // DescriptionOneTB
            // 
            this.DescriptionOneTB.BackColor = System.Drawing.Color.SeaGreen;
            this.DescriptionOneTB.BorderColor = System.Drawing.Color.SeaGreen;
            this.DescriptionOneTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DescriptionOneTB.DefaultText = "";
            this.DescriptionOneTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DescriptionOneTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DescriptionOneTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DescriptionOneTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DescriptionOneTB.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.DescriptionOneTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DescriptionOneTB.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionOneTB.ForeColor = System.Drawing.Color.White;
            this.DescriptionOneTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DescriptionOneTB.Location = new System.Drawing.Point(132, 40);
            this.DescriptionOneTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DescriptionOneTB.Name = "DescriptionOneTB";
            this.DescriptionOneTB.PasswordChar = '\0';
            this.DescriptionOneTB.PlaceholderText = "";
            this.DescriptionOneTB.SelectedText = "";
            this.DescriptionOneTB.Size = new System.Drawing.Size(221, 21);
            this.DescriptionOneTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(3, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(3, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Description 2:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.SeaGreen;
            this.label.Location = new System.Drawing.Point(3, 40);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(100, 21);
            this.label.TabIndex = 9;
            this.label.Text = "Description 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Stock Code:";
            // 
            // stocksTableAdapter
            // 
            this.stocksTableAdapter.ClearBeforeFill = true;
            // 
            // StockAdjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "StockAdjustment";
            this.Text = "StockAdjustment";
            this.Load += new System.EventHandler(this.StockAdjustment_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMEnterpriseProgramDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._AM_Enterprise_ProgramDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2TextBox StockOnHandTB;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button UpdateBtn;
        private Guna.UI2.WinForms.Guna2Button CloseBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.ComboBox StockCodeCB;
        public System.Windows.Forms.ComboBox CategoryCB;
        public Guna.UI2.WinForms.Guna2TextBox DescriptionTwoTB;
        public Guna.UI2.WinForms.Guna2TextBox DescriptionOneTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label5;
        public Guna.UI2.WinForms.Guna2TextBox NewStockTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource aMEnterpriseProgramDataSetBindingSource;
        private _AM_Enterprise_ProgramDataSet _AM_Enterprise_ProgramDataSet;
        private System.Windows.Forms.BindingSource stocksBindingSource;
        private _AM_Enterprise_ProgramDataSetTableAdapters.StocksTableAdapter stocksTableAdapter;
        public Guna.UI2.WinForms.Guna2TextBox QtyPurchasedTB;
        private System.Windows.Forms.Label label6;
    }
}