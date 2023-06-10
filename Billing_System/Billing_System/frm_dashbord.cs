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
    public partial class frm_dashbord : Form
    {
        public frm_dashbord()
        {
            InitializeComponent();
        }

        private void btn_jobcardMotorbike_Click(object sender, EventArgs e)
        {
            frm_motoBicycle motoBike = new frm_motoBicycle();
            motoBike.Show();
        }

        private void btn_invoice_Click(object sender, EventArgs e)
        {
            frm_invoice invoice = new frm_invoice();
            invoice.Show();
        }

        private void btn_jobcardMotorcar_Click(object sender, EventArgs e)
        {
            frm_motoCar motoCar = new frm_motoCar();
            motoCar.Show();
        }

        private void btn_suspensionCondition_Click(object sender, EventArgs e)
        {
            frm_sconditionReport sconditionReport = new frm_sconditionReport();
            sconditionReport.Show();
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            frm_salesReport salesReport = new frm_salesReport();
            salesReport.Show();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_add add = new frm_add();
            add.Show();
        }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            frm_inventory inventory = new frm_inventory();
            inventory.Show();
        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            this.Hide();
            login.Show(); 
        }

        private void lbl_jcCar_Click(object sender, EventArgs e)
        {

        }

        private void lbl_invoice_Click(object sender, EventArgs e)
        {

        }

        private void lbl_jcBike_Click(object sender, EventArgs e)
        {

        }
    }
}
