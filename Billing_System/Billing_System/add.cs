using System;
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
    public partial class frm_add : Form
    {
        public frm_add()
        {
            InitializeComponent();
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            frm_addItem addItem = new frm_addItem();
            addItem.Show();
        }

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            frm_addCustomer addCustomer = new frm_addCustomer();
            addCustomer.Show();

        }

        private void btn_addJob_Click(object sender, EventArgs e)
        {
            frm_addJob addJob = new frm_addJob();
            addJob.Show();
        }

        private void btn_addMechanic_Click(object sender, EventArgs e)
        {
            addMechanic addMechanic = new addMechanic();
            addMechanic.Show();
        }
    }
}
