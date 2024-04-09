
namespace AmmarahKader_XactERP_Project.View
{
    partial class TransactionList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionList));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DebtorBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.StockBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.SeaGreen;
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(570, 78);
            this.guna2Panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(195, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transaction Details";
            // 
            // DebtorBtn
            // 
            this.DebtorBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DebtorBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DebtorBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DebtorBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DebtorBtn.FillColor = System.Drawing.Color.SeaGreen;
            this.DebtorBtn.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebtorBtn.ForeColor = System.Drawing.Color.White;
            this.DebtorBtn.Image = ((System.Drawing.Image)(resources.GetObject("DebtorBtn.Image")));
            this.DebtorBtn.ImageSize = new System.Drawing.Size(60, 60);
            this.DebtorBtn.Location = new System.Drawing.Point(130, 174);
            this.DebtorBtn.Name = "DebtorBtn";
            this.DebtorBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.DebtorBtn.Size = new System.Drawing.Size(130, 130);
            this.DebtorBtn.TabIndex = 8;
            this.DebtorBtn.Text = "DEBTOR";
            this.DebtorBtn.Click += new System.EventHandler(this.DebtorBtn_Click);
            // 
            // StockBtn
            // 
            this.StockBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StockBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StockBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StockBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StockBtn.FillColor = System.Drawing.Color.SeaGreen;
            this.StockBtn.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockBtn.ForeColor = System.Drawing.Color.White;
            this.StockBtn.Image = ((System.Drawing.Image)(resources.GetObject("StockBtn.Image")));
            this.StockBtn.ImageSize = new System.Drawing.Size(60, 60);
            this.StockBtn.Location = new System.Drawing.Point(317, 174);
            this.StockBtn.Name = "StockBtn";
            this.StockBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.StockBtn.Size = new System.Drawing.Size(130, 130);
            this.StockBtn.TabIndex = 9;
            this.StockBtn.Text = "STOCK";
            this.StockBtn.Click += new System.EventHandler(this.StockBtn_Click);
            // 
            // TransactionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 380);
            this.Controls.Add(this.StockBtn);
            this.Controls.Add(this.DebtorBtn);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "TransactionList";
            this.Text = "TransactionList";
            this.Load += new System.EventHandler(this.TransactionList_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton DebtorBtn;
        private Guna.UI2.WinForms.Guna2CircleButton StockBtn;
    }
}