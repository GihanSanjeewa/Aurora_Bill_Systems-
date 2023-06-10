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
    
    public partial class frm_sconditionReport : Form
    {
        
        public frm_sconditionReport()
        {
            InitializeComponent();
            lbl_date.Text = DateTime.Now.ToString();

            
        }

        void mechanicName()
        {
            connection_class.open_connection();
            String command_query = "SELECT mechanicName FROM mechanic";
            MySqlCommand cmd = new MySqlCommand(command_query, connection_class.con);
            MySqlDataReader mydr;
            mydr = cmd.ExecuteReader();
                if(mydr.Read())
                {
                    string mName = mydr.GetString("mechanicName");
                    cmb_mName.Items.Add(mName);
                }

            connection_class.close_connection();
        }

        private void txt_vehicleNmber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_vehicleNumber.Text))
            {
                e.Cancel = true;
                txt_vehicleNumber.Focus();
                errorProvider1.SetError(txt_vehicleNumber, "Vehicle number cannot be empty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_vehicleNumber, "");
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
                txt_vehicleNumber.Focus();
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
                txt_vehicleNumber.Focus();
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            connection_class.open_connection();
            MySqlCommand cmd1 = new MySqlCommand("SELECT `registerNumber`, `vehicleModel`, `fuelType`, `km` FROM `customer` WHERE registerNumber =@registerNumber", connection_class.con);
            cmd1.Parameters.AddWithValue("registerNumber", txt_vehicleNumber.Text);

            MySqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();

            if (reader1.Read())
            {
                txt_vehicleNumber.Text = reader1["registerNumber"].ToString();
                txt_vehicleModel.Text = reader1["vehicleModel"].ToString();
                txt_fuelType.Text = reader1["fuelType"].ToString();
                txt_km.Text = reader1["km"].ToString();
                
            }
            else
            {
                MessageBox.Show("No data found !!!");
            }


            connection_class.close_connection();
        }

        private void frm_sconditionReport_Load(object sender, EventArgs e)
        {
            mechanicName();
        }
    }
}
