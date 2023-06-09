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
    public partial class frm_addJob : Form
    {
        public frm_addJob()
        {
            InitializeComponent();
        }

        private void btn_addJob_Click(object sender, EventArgs e)
        {
            connection_class.open_connection();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `job`( `jobName`, `jobPrice`) VALUES( @txt_jobName, @txt_jobPrice)", connection_class.con);
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@txt_jobName", txt_jobName.Text);
            cmd.Parameters.AddWithValue("@txt_jobPrice", txt_jobPrice.Text);
           


            cmd.ExecuteNonQuery();
            connection_class.close_connection();

            MessageBox.Show("Job Added Successfully!");
            fndataLoad();
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
            if(string.IsNullOrWhiteSpace(txt_jobName.Text))
            {
                e.Cancel = true;
                txt_jobName.Focus();
                errorProvider1.SetError(txt_jobName, "Fill the Job Name ");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_jobName, "");
            }
        }

        private void txt_jobPrice_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_jobPrice.Text))
            {
                e.Cancel = true;
                txt_jobPrice.Focus();
                errorProvider1.SetError(txt_jobPrice, "Enter the Job Price ");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_jobPrice, "");
            }
        }
    }
}
