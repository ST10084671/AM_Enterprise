﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmmarahKader_XactERP_Project
{
    public partial class FormMessagebox : Form
    {
        public FormMessagebox()
        {
            InitializeComponent();
        }

        private void FormMessagebox_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Hide();
        }
    }
}
