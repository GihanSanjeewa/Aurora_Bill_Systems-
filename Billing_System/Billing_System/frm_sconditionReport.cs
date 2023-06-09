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
    public partial class frm_sconditionReport : Form
    {
        public frm_sconditionReport()
        {
            InitializeComponent();
        }

        private void txt_vehicleNmber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_vehicleNmber.Text))
            {
                e.Cancel = true;
                txt_vehicleNmber.Focus();
                errorProvider1.SetError(txt_vehicleNmber, "Vehicle number cannot be empty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_vehicleNmber, "");
            }
        }

        private void txt_vehicleModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_vehicleModel_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_vehicleModel.Text))
            {
                e.Cancel = true;
                txt_vehicleNmber.Focus();
                errorProvider1.SetError(txt_vehicleModel, "Vehicle model cannot be empty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_vehicleModel, "");
            }
        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_km_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_km.Text))
            {
                e.Cancel = true;
                txt_vehicleNmber.Focus();
                errorProvider1.SetError(txt_km, "km cannot be empty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_km, "");
            }
        }

        private void lbl_date_Click(object sender, EventArgs e)
        {

        }

        private void txt_vehicleNmber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_process_Click(object sender, EventArgs e)
        {

        }
    }
}
