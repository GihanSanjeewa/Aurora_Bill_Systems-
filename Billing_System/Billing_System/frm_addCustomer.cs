﻿using MySql.Data.MySqlClient;
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
    public partial class frm_addCustomer : Form
    {
        public frm_addCustomer()
        {
            InitializeComponent();
        }

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            connection_class.open_connection();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `customer`( `registerNumber`, `customerName`, `vehicleModel`, `chassisNumber`, `fuelType`, `km`) VALUES( @txt_registrationNo, @txt_customerName, @cmb_vehicleModel, @txt_chassisNo, @cmb_fuelType, @txt_km )", connection_class.con);
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@txt_registrationNo", txt_registrationNo.Text);
            cmd.Parameters.AddWithValue("@txt_customerName", txt_customerName.Text);
            cmd.Parameters.AddWithValue("@cmb_vehicleModel", cmb_vehicleModel.Text);
            cmd.Parameters.AddWithValue("@txt_chassisNo", txt_chassisNo.Text);
            cmd.Parameters.AddWithValue("@cmb_fuelType", cmb_fuelType.Text);
            cmd.Parameters.AddWithValue("@txt_km", txt_km.Text);


            cmd.ExecuteNonQuery();
            connection_class.close_connection();

            MessageBox.Show("Customer Added Successfully!");
            fndataLoad();
        }

        public void fndataLoad()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from customer", connection_class.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "dgv_customer");
            dgv_customer.DataSource = ds.Tables["dgv_customer"].DefaultView;

        }

        private void btn_editCustomer_Click(object sender, EventArgs e)
        {
            frm_editCustomer editCustomer = new frm_editCustomer();
            editCustomer.Show();

        }
    }
}