﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_System
{
    public partial class frm_motoBicycle : Form
    {
        public frm_motoBicycle()
        {
            InitializeComponent();
        }

        private void btn_process_Click(object sender, EventArgs e)
        {
            frm_invoice inv = new frm_invoice();
            this.Hide();
            inv.Show();

        }
    }
}