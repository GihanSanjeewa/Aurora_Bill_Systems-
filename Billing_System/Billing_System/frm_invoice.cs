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
    public partial class frm_invoice : Form
    {
        public frm_invoice()
        {
            InitializeComponent();
        }

        private void frm_invoice_Load(object sender, EventArgs e)
        {

        }

        private void txt_vehicleNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_vehicleNumber.Text))
            {
                e.Cancel = false;
                //txt_vehicleNumber.Focus();
                errorProvider1.SetError(txt_vehicleNumber, "Vehicle Number Should not be Blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_vehicleNumber, "");
            }
        }

        private void drp_fuelType_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(drp_fuelType.Text))
            {
                e.Cancel = true;
                //drp_fuelType.Focus();
                errorProvider1.SetError(drp_fuelType, "Fuel Type Should not be Blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(drp_fuelType, "");
            }
        }

        private void txt_vehicleModle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_vehicleModle.Text))
            {
                e.Cancel = true;
                //txt_vehicleModle.Focus();
                errorProvider1.SetError(txt_vehicleModle, "Vehicle Modle Should not be Blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_vehicleModle, "");
            }
        }

        private void txt_discount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_discount.Text))
            {
                e.Cancel = true;
                //txt_discount.Focus();
                errorProvider1.SetError(txt_discount, "Discount Should not be Blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_discount, "");
            }
        }

        private void txt_km_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_km.Text))
            {
                e.Cancel = true;
                //txt_km.Focus();
                errorProvider1.SetError(txt_km, "Mileage Should not be Blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_km, "");
            }
        }

        private void drp_job_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(drp_job.Text))
            {
                e.Cancel = true;
                //drp_job.Focus();
                errorProvider1.SetError(drp_job, "Job Should not be Blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(drp_job, "");
            }
        }
    }
}
