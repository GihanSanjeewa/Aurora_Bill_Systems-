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
    public partial class frm_motoBicycle : Form
    {
        public frm_motoBicycle()
        {
            InitializeComponent();
        }

        private void btn_process_Click(object sender, EventArgs e)
        {
            motobicycleJobCard mbcard = new motobicycleJobCard();
            mbcard.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            connection_class.open_connection();
            MySqlCommand cmd1 = new MySqlCommand("SELECT `registerNumber`, `customerName`, `vehicleModel`, `chassisNumber`, `fuelType`,`km` FROM `customer` WHERE registerNumber =@registerNumber", connection_class.con);
            cmd1.Parameters.AddWithValue("registerNumber", txt_search.Text);

            MySqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();

            if (reader1.Read())
            {
                txt_regNo.Text = reader1["registerNumber"].ToString();
                txt_cutomerName.Text = reader1["customerName"].ToString();
                cmb_vehicleModel.Text = reader1["vehicleModel"].ToString();
                txt_chasisNo.Text = reader1["chassisNumber"].ToString();
                txt_fuel.Text = reader1["fuelType"].ToString();
                txt_odoMeter.Text = reader1["km"].ToString();

            }
            else
            {
                MessageBox.Show("No data found");
            }
            connection_class.close_connection();
        }
    }
}
