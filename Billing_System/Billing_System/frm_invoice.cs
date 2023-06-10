using MySql.Data.MySqlClient;
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
           
            MySqlDataAdapter da = new MySqlDataAdapter("select * from job", connection_class.con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {


                drp_job.Items.Add(dt.Rows[i]["jobName"]);

            }


            connection_class.close_connection();
        }

        private void txt_vehicleNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_vehicleNumber.Text))
            {
                e.Cancel = true;
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            connection_class.open_connection();
            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM `customer` WHERE `registerNumber` =@id", connection_class.con);
            cmd1.Parameters.AddWithValue("id", txt_vehicleNumber.Text);

            MySqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();

            if (reader1.Read())
            {
                txt_vehicleModle.Text = reader1["vehicleModel"].ToString();
                txt_km.Text = reader1["km"].ToString();
                drp_fuelType.Text = reader1["fuelType"].ToString();
             //   drp_job.Text = reader1["item_price"].ToString();




            }
            else
            {
                MessageBox.Show("No data found");
            }
            connection_class.close_connection();

        
        }
    }
}
