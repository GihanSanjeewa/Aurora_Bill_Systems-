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
    public partial class frm_addJob : Form
    {
        public frm_addJob()
        {
            InitializeComponent();
        }

        private void btn_addJob_Click(object sender, EventArgs e)
        {

            if (!ValidateJobName() || !ValidateJobPrice())

                return;

                connection_class.open_connection();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `job`( `jobName`, `jobPrice`) VALUES( @txt_jobName, @txt_jobPrice)", connection_class.con);
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@txt_jobName", txt_jobName.Text);
                cmd.Parameters.AddWithValue("@txt_jobPrice", txt_jobPrice.Text);

                cmd.ExecuteNonQuery();
                connection_class.close_connection();

            //for check 

            MessageBox.Show("Job Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fndataLoad();

            txt_jobName.Text = "";
            txt_jobPrice.Text = "";


        }

        //validation for job name
        private bool ValidateJobName()
        {
            if(string.IsNullOrEmpty(txt_jobName.Text))
            {
                MessageBox.Show("Please enter the Job name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_jobName.Focus();
                return false;
            }
            return true;
        }

        //validation for job price
        private bool ValidateJobPrice()
        {
            if (string.IsNullOrEmpty(txt_jobPrice.Text))
            {
                MessageBox.Show("Please enter the Job price", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_jobPrice.Focus();
                return false;
            }
            return true;
        }

        public void fndataLoad()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from job", connection_class.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "dgv_job");
            dgv_job.DataSource = ds.Tables["dgv_job"].DefaultView;

        }

        private void btn_editItem_Click(object sender, EventArgs e)
        {
            frm_editJob editJob = new frm_editJob();
            editJob.Show();
        }

        private void txt_jobName_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void txt_jobPrice_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txt_jobName_Validated(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frm_editJob editJob = new frm_editJob();
            editJob.Show();
        }
    }
}
