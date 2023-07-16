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

        private void drp_job_DropDown(object sender, EventArgs e)
        {
            
        }


        private void btn_process_Click(object sender, EventArgs e)
        {

        }


        //process start

        private void process1()
        {
            lbl_job1.Text = drp_job.Text;
            lbl_price1.Text = txt_price.Text;
            lbl_discount1.Text = txt_discount.Text;
            lbl_fprice1.Text = lbl_price.Text;

            int total = (Convert.ToInt32(lbl_fprice1.Text));
            lbl_total.Text = total.ToString();
            txt_discount.Text = "0";
            //txt_price.Text = "";
            //drp_job.Text = "";
            //lbl_price.Text = "0.00";
        }
        private void process2()
        {
            lbl_job2.Text = drp_job.Text;
            lbl_price2.Text = txt_price.Text;
            lbl_discount2.Text = txt_discount.Text;
            lbl_fprice2.Text = lbl_price.Text;

            int total = (Convert.ToInt32(lbl_fprice1.Text)) + (Convert.ToInt32(lbl_fprice2.Text));
            lbl_total.Text = total.ToString();
            //txt_discount.Text = "";
            //txt_price.Text = "";
            //drp_job.Text = "";
            //lbl_price.Text = "0.00";
        }
        private void process3()
        {
            lbl_job3.Text = drp_job.Text;
            lbl_price3.Text = txt_price.Text;
            lbl_discount3.Text = txt_discount.Text;
            lbl_fprice3.Text = lbl_price.Text;

            int total = (Convert.ToInt32(lbl_fprice1.Text)) + (Convert.ToInt32(lbl_fprice2.Text)) + (Convert.ToInt32(lbl_fprice3.Text));
            lbl_total.Text = total.ToString();
            //txt_discount.Text = "";
            //txt_price.Text = "";
            //drp_job.Text = "";
            //lbl_price.Text = "0.00";
        }
        private void process4()
        {
            lbl_job4.Text = drp_job.Text;
            lbl_price4.Text = txt_price.Text;
            lbl_discount4.Text = txt_discount.Text;
            lbl_fprice4.Text = lbl_price.Text;

            int total = (Convert.ToInt32(lbl_fprice1.Text)) + (Convert.ToInt32(lbl_fprice2.Text)) + (Convert.ToInt32(lbl_fprice3.Text)) + (Convert.ToInt32(lbl_fprice4.Text));
            lbl_total.Text = total.ToString();
            //txt_discount.Text = "";
            //txt_price.Text = "";
            //drp_job.Text = "";
            //lbl_price.Text = "0.00";
        }
        private void process5()
        {
            lbl_job5.Text = drp_job.Text;
            lbl_price5.Text = txt_price.Text;
            lbl_discount5.Text = txt_discount.Text;
            lbl_fprice5.Text = lbl_price.Text;

            int total = (Convert.ToInt32(lbl_fprice1.Text)) + (Convert.ToInt32(lbl_fprice2.Text)) + (Convert.ToInt32(lbl_fprice3.Text)) + (Convert.ToInt32(lbl_fprice4.Text)) + (Convert.ToInt32(lbl_fprice5.Text));
            lbl_total.Text = total.ToString();
            //txt_discount.Text = "";
            //txt_price.Text = "";
            //drp_job.Text = "";
            //lbl_price.Text = "0.00";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (drp_job.Text == "")
            {
                MessageBox.Show("Enter the job type !!!");
            }
            else
            {
                if (lbl_job1.Text == "")
                {
                    process1();
                    btn_remove1.Visible = true;
                }
                else if (lbl_job2.Text == "")
                {
                    process2();
                    btn_remove2.Visible = true;
                }

                else if (lbl_job3.Text == "")
                {
                    process3();
                    btn_remove3.Visible = true;
                }

                else if (lbl_job4.Text == "")
                {
                    process4();
                    btn_remove4.Visible = true;
                }
                else
                {
                    process5();
                    btn_remove5.Visible = true;
                }
            }
        }

        private void txt_discount_DropDown(object sender, EventArgs e)
        {
            

                
            
        }

        private void txt_discount_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txt_discount_SelectedIndexChanged(object sender, EventArgs e)
        {
            int new_Price = Convert.ToInt32(txt_price.Text) - Convert.ToInt32(txt_discount.SelectedItem);
            lbl_price.Text = new_Price.ToString();
        }

        private void drp_job_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drp_job.Text != null)
            {
                connection_class.open_connection();
                MySqlCommand cmd1 = new MySqlCommand("SELECT `jobPrice` FROM `job` WHERE `jobName` =@jobName", connection_class.con);
                cmd1.Parameters.AddWithValue("jobName", drp_job.Text);

                MySqlDataReader reader1;
                reader1 = cmd1.ExecuteReader();

                if (reader1.Read())
                {
                    txt_price.Text = reader1["jobPrice"].ToString();
                }

                connection_class.close_connection();
            }
        }
    }
}
