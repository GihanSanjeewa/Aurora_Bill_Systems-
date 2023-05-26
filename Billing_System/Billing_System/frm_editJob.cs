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
    public partial class frm_editJob : Form
    {
        public frm_editJob()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            connection_class.open_connection();
            MySqlCommand cmd1 = new MySqlCommand("SELECT `jobId`, `jobName`, `jobPrice` FROM `job` WHERE jobId =@jobId", connection_class.con);
            cmd1.Parameters.AddWithValue("jobId", txt_searchJob.Text);

            MySqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();

            if (reader1.Read())
            {
                txt_jobId.Text = reader1["jobId"].ToString();
                txt_jobName.Text = reader1["jobName"].ToString();
                txt_jobPrice.Text = reader1["jobPrice"].ToString();
            }
            else
            {
                MessageBox.Show("No data found !!!");
            }
            connection_class.close_connection();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            connection_class.open_connection();

            string MysqlQry = "update job set jobName =('" + txt_jobName.Text + "'),jobPrice =('" + txt_jobPrice.Text + "') where jobId = ('" + txt_jobId.Text + "')";

            MySqlCommand cmd = new MySqlCommand(MysqlQry, connection_class.con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Job updated successfully !!!");

            connection_class.close_connection();


            fndataLoad();
        }

        public void fndataLoad()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from job", connection_class.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "dgv_job");
            dgv_job.DataSource = ds.Tables["dgv_job"].DefaultView;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            connection_class.open_connection();

            string MysqlQry = "delete from job where jobId =('" + txt_jobId.Text + "')";

            MySqlCommand cmd = new MySqlCommand(MysqlQry, connection_class.con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Job deleted successfully !!!");

            connection_class.close_connection();


            fndataLoad();
        }

        private void dgv_item_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvrow = dgv_job.Rows[e.RowIndex];
                txt_jobId.Text = dgvrow.Cells[0].Value.ToString();
                txt_jobName.Text = dgvrow.Cells[1].Value.ToString();
                txt_jobPrice.Text = dgvrow.Cells[2].Value.ToString();

            }
        }

        private void frm_editJob_Load(object sender, EventArgs e)
        {
            fndataLoad();
        }
    }
}
