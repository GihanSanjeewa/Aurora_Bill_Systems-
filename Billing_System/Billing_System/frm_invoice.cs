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
using System.Text.RegularExpressions;

namespace Billing_System
{
    public partial class frm_invoice : Form
    {
        public frm_invoice()
        {
            InitializeComponent();
        }

        //Validation functions 
        private bool IsValidNumericInput(string input)
        {
            // Regular expression pattern to check for only numbers
            string pattern = @"^\d+$";
            return Regex.IsMatch(input, pattern);
        }

        private bool IsValidStringInput(string input)
        {
            // Regular expression pattern to check for only string values
            string pattern = @"^[a-zA-Z]+$";
            return Regex.IsMatch(input, pattern);
        }

        private void ClearAllTextBoxesExceptNumeric()
        {
            
        }

        private void frm_invoice_Load(object sender, EventArgs e)
        {
            timer1.Start();

            //job
            MySqlDataAdapter da = new MySqlDataAdapter("select * from job", connection_class.con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {


                drp_job.Items.Add(dt.Rows[i]["jobName"]);

            }

            //mechanic
            MySqlDataAdapter daa = new MySqlDataAdapter("select * from mechanic", connection_class.con);

            DataTable dtt = new DataTable();

            daa.Fill(dtt);

            for (int i = 0; i < dtt.Rows.Count; i++)
            {


                drp_mechanic.Items.Add(dtt.Rows[i]["mechanicName"]);

            }


            connection_class.close_connection();
        }

        //VALIDATION

        private void txt_vehicleNumber_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void drp_fuelType_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txt_vehicleModle_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txt_discount_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txt_km_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void drp_job_Validating(object sender, CancelEventArgs e)
        {
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
            connection_class.open_connection();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `invoice`( `registerNumber`,`vehicleModel`,`fuelType`,`km`,`mechanicName`,`date`,`job1`,`job2`,`job3`,`job4`,`job5`,`job6`,`job7`,`job8`,`discount`,`price`)  VALUES (@registerNumber,@vehicleModel,@fuelType,@km,@mechanicName,@date,@job1,@job2,@job3,@job4,@job5,@job6,@job7,@job8,@discount,@price)", connection_class.con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@registerNumber", txt_vehicleNumber.Text);
            cmd.Parameters.AddWithValue("@vehicleModel", txt_vehicleModle.Text);
            cmd.Parameters.AddWithValue("@fuelType", drp_fuelType.Text);
            cmd.Parameters.AddWithValue("@km", txt_km.Text);
            cmd.Parameters.AddWithValue("@mechanicName", drp_mechanic.Text);
            cmd.Parameters.AddWithValue("@date", lbl_date.Text);
            cmd.Parameters.AddWithValue("@job1", lbl_job1.Text);
            cmd.Parameters.AddWithValue("@job2", lbl_job2.Text);
            cmd.Parameters.AddWithValue("@job3", lbl_job3.Text);
            cmd.Parameters.AddWithValue("@job4", lbl_job4.Text);
            cmd.Parameters.AddWithValue("@job5", lbl_job5.Text);
            cmd.Parameters.AddWithValue("@job6", lbl_job6.Text);
            cmd.Parameters.AddWithValue("@job7", lbl_job7.Text);
            cmd.Parameters.AddWithValue("@job8", lbl_job8.Text);
            cmd.Parameters.AddWithValue("@discount", lbl_totDiscount.Text);
            cmd.Parameters.AddWithValue("@price", lbl_total.Text);

            cmd.ExecuteNonQuery();
            connection_class.close_connection();
            MessageBox.Show("Invoice printed !!!");
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

            int tot_discount = (Convert.ToInt32(lbl_discount1.Text));
            lbl_totDiscount.Text = tot_discount.ToString();

            //txt_discount.Text = "0";
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

            int tot_discount = (Convert.ToInt32(lbl_discount1.Text))+ (Convert.ToInt32(lbl_discount2.Text));
            lbl_totDiscount.Text = tot_discount.ToString();

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

            int tot_discount = (Convert.ToInt32(lbl_discount1.Text)) + (Convert.ToInt32(lbl_discount2.Text))+ (Convert.ToInt32(lbl_discount3.Text));
            lbl_totDiscount.Text = tot_discount.ToString();

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

            int tot_discount = (Convert.ToInt32(lbl_discount1.Text)) + (Convert.ToInt32(lbl_discount2.Text)) + (Convert.ToInt32(lbl_discount3.Text))+ (Convert.ToInt32(lbl_discount4.Text));
            lbl_totDiscount.Text = tot_discount.ToString();

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

            int tot_discount = (Convert.ToInt32(lbl_discount1.Text)) + (Convert.ToInt32(lbl_discount2.Text)) + (Convert.ToInt32(lbl_discount3.Text)) + (Convert.ToInt32(lbl_discount4.Text))+ (Convert.ToInt32(lbl_discount5.Text));
            lbl_totDiscount.Text = tot_discount.ToString();

            //txt_discount.Text = "";
            //txt_price.Text = "";
            //drp_job.Text = "";
            //lbl_price.Text = "0.00";
        }

        private void process6()
        {
            lbl_job6.Text = drp_job.Text;
            lbl_price6.Text = txt_price.Text;
            lbl_discount6.Text = txt_discount.Text;
            lbl_fprice6.Text = lbl_price.Text;

            int total = (Convert.ToInt32(lbl_fprice1.Text)) + (Convert.ToInt32(lbl_fprice2.Text)) + (Convert.ToInt32(lbl_fprice3.Text)) + (Convert.ToInt32(lbl_fprice4.Text)) + (Convert.ToInt32(lbl_fprice5.Text))+ (Convert.ToInt32(lbl_fprice6.Text));
            lbl_total.Text = total.ToString();


            int tot_discount = (Convert.ToInt32(lbl_discount1.Text)) + (Convert.ToInt32(lbl_discount2.Text)) + (Convert.ToInt32(lbl_discount3.Text)) + (Convert.ToInt32(lbl_discount4.Text)) + (Convert.ToInt32(lbl_discount5.Text))+ (Convert.ToInt32(lbl_discount6.Text));
            lbl_totDiscount.Text = tot_discount.ToString();

            //txt_discount.Text = "";
            //txt_price.Text = "";
            //drp_job.Text = "";
            //lbl_price.Text = "0.00";
        }

        private void process7()
        {
            lbl_job7.Text = drp_job.Text;
            lbl_price7.Text = txt_price.Text;
            lbl_discount7.Text = txt_discount.Text;
            lbl_fprice7.Text = lbl_price.Text;

            int total = (Convert.ToInt32(lbl_fprice1.Text)) + (Convert.ToInt32(lbl_fprice2.Text)) + (Convert.ToInt32(lbl_fprice3.Text)) + (Convert.ToInt32(lbl_fprice4.Text)) + (Convert.ToInt32(lbl_fprice5.Text))+ (Convert.ToInt32(lbl_fprice6.Text))+ (Convert.ToInt32(lbl_fprice7.Text));
            lbl_total.Text = total.ToString();

            int tot_discount = (Convert.ToInt32(lbl_discount1.Text)) + (Convert.ToInt32(lbl_discount2.Text)) + (Convert.ToInt32(lbl_discount3.Text)) + (Convert.ToInt32(lbl_discount4.Text)) + (Convert.ToInt32(lbl_discount5.Text)) + (Convert.ToInt32(lbl_discount6.Text))+ (Convert.ToInt32(lbl_discount7.Text));
            lbl_totDiscount.Text = tot_discount.ToString();

            //txt_discount.Text = "";
            //txt_price.Text = "";
            //drp_job.Text = "";
            //lbl_price.Text = "0.00";
        }

        private void process8()
        {
            lbl_job8.Text = drp_job.Text;
            lbl_price8.Text = txt_price.Text;
            lbl_discount8.Text = txt_discount.Text;
            lbl_fprice8.Text = lbl_price.Text;

            int total = (Convert.ToInt32(lbl_fprice1.Text)) + (Convert.ToInt32(lbl_fprice2.Text)) + (Convert.ToInt32(lbl_fprice3.Text)) + (Convert.ToInt32(lbl_fprice4.Text)) + (Convert.ToInt32(lbl_fprice5.Text))+ (Convert.ToInt32(lbl_fprice6.Text))+ (Convert.ToInt32(lbl_fprice7.Text))+ (Convert.ToInt32(lbl_fprice8.Text));
            lbl_total.Text = total.ToString();

            int tot_discount = (Convert.ToInt32(lbl_discount1.Text)) + (Convert.ToInt32(lbl_discount2.Text)) + (Convert.ToInt32(lbl_discount3.Text)) + (Convert.ToInt32(lbl_discount4.Text)) + (Convert.ToInt32(lbl_discount5.Text)) + (Convert.ToInt32(lbl_discount6.Text)) + (Convert.ToInt32(lbl_discount7.Text))+ (Convert.ToInt32(lbl_discount8.Text));
            lbl_totDiscount.Text = tot_discount.ToString();

            //txt_discount.Text = "";
            //txt_price.Text = "";
            //drp_job.Text = "";
            //lbl_price.Text = "0.00";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string ValidateVNumber = txt_vehicleNumber.Text;
            string ValidateJob = drp_job.Text;
            string ValidateDiscount = txt_discount.Text;
            string ValidateMechanic = drp_mechanic.Text;

           
            if (string.IsNullOrWhiteSpace(ValidateVNumber))
            {
                MessageBox.Show("Please enter a vehicle number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            
            /*if (!int.TryParse(ValidateVNumber, out _))
            {
                MessageBox.Show("Vehicle number should not contain only numeric values !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/


            if (string.IsNullOrEmpty(ValidateJob))
            {
                MessageBox.Show("Please select a job.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(ValidateDiscount))
            {
                MessageBox.Show("Please select a discount amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(ValidateMechanic))
            {
                MessageBox.Show("Please select a mechanic.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            
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
            else if (lbl_job5.Text == "")
            {
                process5();
                btn_remove5.Visible = true;
            }
            else if (lbl_job6.Text == "")
            {
                process6();
                btn_remove6.Visible = true;
            }
            else if (lbl_job7.Text == "")
            {
                process7();
                btn_remove7.Visible = true;
            }
            else if (lbl_job8.Text == "")
            {
                process8();
                btn_remove8.Visible = true;
            }
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

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToLongDateString();
            lbl_time.Text = DateTime.Now.ToLongTimeString();
        }

        //remove button
        private void clear8()
        {
            lbl_job8.Text = "";
            lbl_price8.Text = "";
            lbl_discount8.Text = "";
            lbl_fprice8.Text = "";
            btn_remove8.Visible = false;
        }

        private void clear7()
        {
            lbl_job7.Text = "";
            lbl_price7.Text = "";
            lbl_discount7.Text = "";
            lbl_fprice7.Text = "";
            btn_remove7.Visible = false;
        }

        private void clear6()
        {
            lbl_job6.Text = "";
            lbl_price6.Text = "";
            lbl_discount6.Text = "";
            lbl_fprice6.Text = "";
            btn_remove6.Visible = false;
        }

        private void clear5()
        {
            lbl_job5.Text = "";
            lbl_price5.Text = "";
            lbl_discount5.Text = "";
            lbl_fprice5.Text = "";
            btn_remove5.Visible = false;
        }
        private void clear4()
        {
            lbl_job4.Text = "";
            lbl_price4.Text = "";
            lbl_discount4.Text = "";
            lbl_fprice4.Text = "";
            btn_remove4.Visible = false;
        }
        private void clear3()
        {
            lbl_job3.Text = "";
            lbl_price3.Text = "";
            lbl_discount3.Text = "";
            lbl_fprice3.Text = "";
            btn_remove3.Visible = false;

        }
        private void clear2()
        {

            lbl_job2.Text = "";
            lbl_price2.Text = "";
            lbl_discount2.Text = "";
            lbl_fprice2.Text = "";
            btn_remove2.Visible = false;

        }
        private void clear1()
        {
            lbl_job1.Text = "";
            lbl_price1.Text = "";
            lbl_discount1.Text = "";
            lbl_fprice1.Text = "";
            btn_remove1.Visible = false;
        }

        private void btn_remove8_Click(object sender, EventArgs e)
        {
            clear8();


            lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text) + Convert.ToInt32(lbl_fprice2.Text) + Convert.ToInt32(lbl_fprice3.Text) + Convert.ToInt32(lbl_fprice4.Text) + Convert.ToInt32(lbl_fprice5.Text) + Convert.ToInt32(lbl_fprice6.Text) + Convert.ToInt32(lbl_fprice7.Text)).ToString();


        }

        private void btn_remove7_Click(object sender, EventArgs e)
        {



            if (lbl_job8.Text != "")
            {
                //shift by 1 raw
                lbl_job7.Text = lbl_job8.Text;
                lbl_price7.Text = lbl_price8.Text;
                lbl_discount7.Text = lbl_discount8.Text;
                lbl_fprice7.Text = lbl_fprice8.Text;
                btn_remove8.Visible = false;

                //clear raw 8

                clear8();

                lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text) + Convert.ToInt32(lbl_fprice2.Text) + Convert.ToInt32(lbl_fprice3.Text) + Convert.ToInt32(lbl_fprice4.Text) + Convert.ToInt32(lbl_fprice5.Text) + Convert.ToInt32(lbl_fprice6.Text) + Convert.ToInt32(lbl_fprice7.Text)).ToString();


            }
            else
            {

                clear7();
                lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text) + Convert.ToInt32(lbl_fprice2.Text) + Convert.ToInt32(lbl_fprice3.Text) + Convert.ToInt32(lbl_fprice4.Text) + Convert.ToInt32(lbl_fprice5.Text) + Convert.ToInt32(lbl_fprice6.Text)).ToString();


            }


        }

        private void btn_remove6_Click(object sender, EventArgs e)
        {


            if (lbl_job7.Text != "")
            {
                //shift by 1 raw
                lbl_job6.Text = lbl_job7.Text;
                lbl_price6.Text = lbl_price7.Text;
                lbl_discount6.Text = lbl_discount7.Text;
                lbl_fprice6.Text = lbl_fprice7.Text;

                clear7();

                if (lbl_job8.Text != "")
                {
                    //shift by 1 raw
                    lbl_job7.Text = lbl_job8.Text;
                    lbl_price7.Text = lbl_price8.Text;
                    lbl_discount7.Text = lbl_discount8.Text;
                    lbl_fprice7.Text = lbl_fprice8.Text;
                    btn_remove8.Visible = false;

                    //clear raw 8

                    clear8();
                    lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text) + Convert.ToInt32(lbl_fprice2.Text) + Convert.ToInt32(lbl_fprice3.Text) + Convert.ToInt32(lbl_fprice4.Text) + Convert.ToInt32(lbl_fprice5.Text) + Convert.ToInt32(lbl_fprice6.Text) + Convert.ToInt32(lbl_fprice7.Text)).ToString();
                }
                else
                {
                    clear7();
                    lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text) + Convert.ToInt32(lbl_fprice2.Text) + Convert.ToInt32(lbl_fprice3.Text) + Convert.ToInt32(lbl_fprice4.Text) + Convert.ToInt32(lbl_fprice5.Text) + Convert.ToInt32(lbl_fprice6.Text) ).ToString();
                }
            }
            else
            {
                clear6();
                lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text) + Convert.ToInt32(lbl_fprice2.Text) + Convert.ToInt32(lbl_fprice3.Text) + Convert.ToInt32(lbl_fprice4.Text) + Convert.ToInt32(lbl_fprice5.Text)).ToString();
            }
        }


        private void btn_remove5_Click(object sender, EventArgs e)
        {


            if (lbl_job6.Text != "")
            {
                //shift by 1 raw
                lbl_job5.Text = lbl_job6.Text;
                lbl_price5.Text = lbl_price6.Text;
                lbl_discount5.Text = lbl_discount6.Text;
                lbl_fprice5.Text = lbl_fprice6.Text;

                clear6();

                if (lbl_job7.Text != "")
                {
                    //shift by 1 raw
                    lbl_job6.Text = lbl_job7.Text;
                    lbl_price6.Text = lbl_price7.Text;
                    lbl_discount6.Text = lbl_discount7.Text;
                    lbl_fprice6.Text = lbl_fprice7.Text;
                    btn_remove7.Visible = false;

                    if (lbl_job8.Text != "")
                    {
                        //shift by 1 raw
                        lbl_job7.Text = lbl_job8.Text;
                        lbl_price7.Text = lbl_price8.Text;
                        lbl_discount7.Text = lbl_discount8.Text;
                        lbl_fprice7.Text = lbl_fprice8.Text;
                        btn_remove8.Visible = false;

                        //clear raw 8

                        clear8();

                        lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text) + Convert.ToInt32(lbl_fprice2.Text) + Convert.ToInt32(lbl_fprice3.Text) + Convert.ToInt32(lbl_fprice4.Text) + Convert.ToInt32(lbl_fprice5.Text) + Convert.ToInt32(lbl_fprice6.Text) + Convert.ToInt32(lbl_fprice7.Text)).ToString();
                    }
                    else
                    {
                        clear7();
                        lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text) + Convert.ToInt32(lbl_fprice2.Text) + Convert.ToInt32(lbl_fprice3.Text) + Convert.ToInt32(lbl_fprice4.Text) + Convert.ToInt32(lbl_fprice5.Text) + Convert.ToInt32(lbl_fprice6.Text)).ToString();
                    }
                }
                else
                {
                    clear6();
                    lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text) + Convert.ToInt32(lbl_fprice2.Text) + Convert.ToInt32(lbl_fprice3.Text) + Convert.ToInt32(lbl_fprice4.Text) + Convert.ToInt32(lbl_fprice5.Text)).ToString();
                }

            }
            else
            {
                clear5();
                lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text) + Convert.ToInt32(lbl_fprice2.Text) + Convert.ToInt32(lbl_fprice3.Text) + Convert.ToInt32(lbl_fprice4.Text)).ToString();
            }
        }


        private void btn_remove4_Click(object sender, EventArgs e)
        {
            if (lbl_job5.Text != "")
            {

                lbl_job4.Text = lbl_job5.Text;
                lbl_price4.Text = lbl_price5.Text;
                lbl_discount4.Text = lbl_discount5.Text;
                lbl_fprice4.Text = lbl_fprice5.Text;
                btn_remove5.Visible = false;
                clear5();


                if (lbl_job6.Text != "")
                {
                    //shift by 1 raw
                    lbl_job5.Text = lbl_job6.Text;
                    lbl_price5.Text = lbl_price6.Text;
                    lbl_discount5.Text = lbl_discount6.Text;
                    lbl_fprice5.Text = lbl_fprice6.Text;
                    btn_remove6.Visible = false;
                    

                    if (lbl_job7.Text != "")
                    {
                        //shift by 1 raw
                        lbl_job6.Text = lbl_job7.Text;
                        lbl_price6.Text = lbl_price7.Text;
                        lbl_discount6.Text = lbl_discount7.Text;
                        lbl_fprice6.Text = lbl_fprice7.Text;
                        btn_remove7.Visible = false;

                        if (lbl_job8.Text != "")
                        {
                            //shift by 1 raw
                            lbl_job7.Text = lbl_job8.Text;
                            lbl_price7.Text = lbl_price8.Text;
                            lbl_discount7.Text = lbl_discount8.Text;
                            lbl_fprice7.Text = lbl_fprice8.Text;
                            btn_remove8.Visible = false;

                            //clear raw 8

                            clear8();

                            lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text) + Convert.ToInt32(lbl_fprice2.Text) + Convert.ToInt32(lbl_fprice3.Text) + Convert.ToInt32(lbl_fprice4.Text) + Convert.ToInt32(lbl_fprice5.Text) + Convert.ToInt32(lbl_fprice6.Text) + Convert.ToInt32(lbl_fprice7.Text)).ToString();
                        }
                        else
                        {
                            clear7();
                            lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text) + Convert.ToInt32(lbl_fprice2.Text) + Convert.ToInt32(lbl_fprice3.Text) + Convert.ToInt32(lbl_fprice4.Text) + Convert.ToInt32(lbl_fprice5.Text) + Convert.ToInt32(lbl_fprice6.Text)).ToString();
                        }
                    }
                    else
                    {
                        clear6();
                        lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text) + Convert.ToInt32(lbl_fprice2.Text) + Convert.ToInt32(lbl_fprice3.Text) + Convert.ToInt32(lbl_fprice4.Text) + Convert.ToInt32(lbl_fprice5.Text)).ToString();
                    }

                }
                else
                {
                    clear5();
                    lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text) + Convert.ToInt32(lbl_fprice2.Text) + Convert.ToInt32(lbl_fprice3.Text) + Convert.ToInt32(lbl_fprice4.Text)).ToString();
                }
               
            }
            else
            {
                clear4();
                lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text) + Convert.ToInt32(lbl_fprice2.Text) + Convert.ToInt32(lbl_fprice3.Text)).ToString();
            }

        }

        private void btn_remove3_Click(object sender, EventArgs e)
        {
            if (lbl_job4.Text != "")
            {
                //shift by 1 raw
                lbl_job3.Text = lbl_job4.Text;
                lbl_price3.Text = lbl_price4.Text;
                lbl_discount3.Text = lbl_discount4.Text;
                lbl_fprice3.Text = lbl_fprice4.Text;
                btn_remove3.Visible = false;

                clear4();

                if (lbl_job5.Text != "")
                {

                    lbl_job4.Text = lbl_job5.Text;
                    lbl_price4.Text = lbl_price5.Text;
                    lbl_discount4.Text = lbl_discount5.Text;
                    lbl_fprice4.Text = lbl_fprice5.Text;
                    btn_remove5.Visible = false;


                    


                    if (lbl_job6.Text != "")
                    {
                        //shift by 1 raw
                        lbl_job5.Text = lbl_job6.Text;
                        lbl_price5.Text = lbl_price6.Text;
                        lbl_discount5.Text = lbl_discount6.Text;
                        lbl_fprice5.Text = lbl_fprice6.Text;
                        btn_remove6.Visible = false;
                        

                        if (lbl_job7.Text != "")
                        {
                            //shift by 1 raw
                            lbl_job6.Text = lbl_job7.Text;
                            lbl_price6.Text = lbl_price7.Text;
                            lbl_discount6.Text = lbl_discount7.Text;
                            lbl_fprice6.Text = lbl_fprice7.Text;
                            btn_remove7.Visible = false;

                            if (lbl_job8.Text != "")
                            {
                                //shift by 1 raw
                                lbl_job7.Text = lbl_job8.Text;
                                lbl_price7.Text = lbl_price8.Text;
                                lbl_discount7.Text = lbl_discount8.Text;
                                lbl_fprice7.Text = lbl_fprice8.Text;
                                btn_remove8.Visible = false;

                                //clear raw 8

                                clear8();

                                lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text) + Convert.ToInt32(lbl_fprice2.Text) + Convert.ToInt32(lbl_fprice3.Text) + Convert.ToInt32(lbl_fprice4.Text) + Convert.ToInt32(lbl_fprice5.Text) + Convert.ToInt32(lbl_fprice6.Text) + Convert.ToInt32(lbl_fprice7.Text)).ToString();
                            }
                            else
                            {
                                clear7();
                                lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text) + Convert.ToInt32(lbl_fprice2.Text) + Convert.ToInt32(lbl_fprice3.Text) + Convert.ToInt32(lbl_fprice4.Text) + Convert.ToInt32(lbl_fprice5.Text) + Convert.ToInt32(lbl_fprice6.Text)).ToString();
                            }
                        }
                        else
                        {
                            clear6();
                            lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text) + Convert.ToInt32(lbl_fprice2.Text) + Convert.ToInt32(lbl_fprice3.Text) + Convert.ToInt32(lbl_fprice4.Text) + Convert.ToInt32(lbl_fprice5.Text)).ToString();
                        }

                    }
                    else
                    {
                        clear5();
                        lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text) + Convert.ToInt32(lbl_fprice2.Text) + Convert.ToInt32(lbl_fprice3.Text) + Convert.ToInt32(lbl_fprice4.Text)).ToString();
                    }

                }
                else
                {
                    clear4();
                    lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text) + Convert.ToInt32(lbl_fprice2.Text) + Convert.ToInt32(lbl_fprice3.Text)).ToString();
                }
            }

            else
            {
                clear3();
                lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text) + Convert.ToInt32(lbl_fprice2.Text) ).ToString();
            }

        }

        private void btn_remove2_Click(object sender, EventArgs e)
        {

            if (lbl_job3.Text != "")
            {
                //shift by 1 raw
                lbl_job2.Text = lbl_job3.Text;
                lbl_price2.Text = lbl_price3.Text;
                lbl_discount2.Text = lbl_discount3.Text;
                lbl_fprice2.Text = lbl_fprice3.Text;

                clear3();


                if (lbl_job4.Text != "")
                {
                    //shift by 1 raw
                    lbl_job3.Text = lbl_job4.Text;
                    lbl_price3.Text = lbl_price4.Text;
                    lbl_discount3.Text = lbl_discount4.Text;
                    lbl_fprice3.Text = lbl_fprice4.Text;

                    btn_remove4.Visible = false;


                    if (lbl_job5.Text != "")
                    {

                        lbl_job4.Text = lbl_job5.Text;
                        lbl_price4.Text = lbl_price5.Text;
                        lbl_discount4.Text = lbl_discount5.Text;
                        lbl_fprice4.Text = lbl_fprice5.Text;

                        btn_remove5.Visible = false;

                        if (lbl_job6.Text != "")
                        {
                            //shift by 1 raw
                            lbl_job5.Text = lbl_job6.Text;
                            lbl_price5.Text = lbl_price6.Text;
                            lbl_discount5.Text = lbl_discount6.Text;
                            lbl_fprice5.Text = lbl_fprice6.Text;

                            btn_remove6.Visible = false;

                            if (lbl_job7.Text != "")
                            {
                                //shift by 1 raw
                                lbl_job6.Text = lbl_job7.Text;
                                lbl_price6.Text = lbl_price7.Text;
                                lbl_discount6.Text = lbl_discount7.Text;
                                lbl_fprice6.Text = lbl_fprice7.Text;
                                btn_remove7.Visible = false;

                                if (lbl_job8.Text != "")
                                {
                                    //shift by 1 raw
                                    lbl_job7.Text = lbl_job8.Text;
                                    lbl_price7.Text = lbl_price8.Text;
                                    lbl_discount7.Text = lbl_discount8.Text;
                                    lbl_fprice7.Text = lbl_fprice8.Text;
                                    btn_remove8.Visible = false;

                                    //clear raw 8

                                    clear8();

                                    lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text) + Convert.ToInt32(lbl_fprice2.Text) + Convert.ToInt32(lbl_fprice3.Text) + Convert.ToInt32(lbl_fprice4.Text) + Convert.ToInt32(lbl_fprice5.Text) + Convert.ToInt32(lbl_fprice6.Text) + Convert.ToInt32(lbl_fprice7.Text)).ToString();
                                }
                                else
                                {
                                    clear7();
                                    lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text) + Convert.ToInt32(lbl_fprice2.Text) + Convert.ToInt32(lbl_fprice3.Text) + Convert.ToInt32(lbl_fprice4.Text) + Convert.ToInt32(lbl_fprice5.Text) + Convert.ToInt32(lbl_fprice6.Text)).ToString();
                                }
                            }
                            else
                            {
                                clear6();
                                lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text) + Convert.ToInt32(lbl_fprice2.Text) + Convert.ToInt32(lbl_fprice3.Text) + Convert.ToInt32(lbl_fprice4.Text) + Convert.ToInt32(lbl_fprice5.Text)).ToString();
                            }

                        }
                        else
                        {
                            clear5();
                            lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text) + Convert.ToInt32(lbl_fprice2.Text) + Convert.ToInt32(lbl_fprice3.Text) + Convert.ToInt32(lbl_fprice4.Text)).ToString();
                        }

                    }
                    else
                    {
                        clear4();
                        lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text) + Convert.ToInt32(lbl_fprice2.Text) + Convert.ToInt32(lbl_fprice3.Text)).ToString();
                    }
                }

                else
                {
                    clear3();
                    lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text) + Convert.ToInt32(lbl_fprice2.Text)).ToString();
                }
            }

            else
            {
                clear2();
                lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text) ).ToString();
            }
        }

        private void btn_remove1_Click(object sender, EventArgs e)
        {

            if (lbl_job2.Text != "")
            {
                //shift by 1 raw
                lbl_job1.Text = lbl_job2.Text;
                lbl_price1.Text = lbl_price2.Text;
                lbl_discount1.Text = lbl_discount2.Text;
                lbl_fprice1.Text = lbl_fprice2.Text;
                clear2();

                if (lbl_job3.Text != "")
                {
                    //shift by 1 raw
                    lbl_job2.Text = lbl_job3.Text;
                    lbl_price2.Text = lbl_price3.Text;
                    lbl_discount2.Text = lbl_discount3.Text;
                    lbl_fprice2.Text = lbl_fprice3.Text;
                    


                    if (lbl_job4.Text != "")
                    {
                        //shift by 1 raw
                        lbl_job3.Text = lbl_job4.Text;
                        lbl_price3.Text = lbl_price4.Text;
                        lbl_discount3.Text = lbl_discount4.Text;
                        lbl_fprice3.Text = lbl_fprice4.Text;
                       

                        

                        if (lbl_job5.Text != "")
                        {

                            lbl_job4.Text = lbl_job5.Text;
                            lbl_price4.Text = lbl_price5.Text;
                            lbl_discount4.Text = lbl_discount5.Text;
                            lbl_fprice4.Text = lbl_fprice5.Text;
                            


                            


                            if (lbl_job6.Text != "")
                            {
                                //shift by 1 raw
                                lbl_job5.Text = lbl_job6.Text;
                                lbl_price5.Text = lbl_price6.Text;
                                lbl_discount5.Text = lbl_discount6.Text;
                                lbl_fprice5.Text = lbl_fprice6.Text;
                               
                                

                                if (lbl_job7.Text != "")
                                {
                                    //shift by 1 raw
                                    lbl_job6.Text = lbl_job7.Text;
                                    lbl_price6.Text = lbl_price7.Text;
                                    lbl_discount6.Text = lbl_discount7.Text;
                                    lbl_fprice6.Text = lbl_fprice7.Text;
                                   

                                    if (lbl_job8.Text != "")
                                    {
                                        //shift by 1 raw
                                        lbl_job7.Text = lbl_job8.Text;
                                        lbl_price7.Text = lbl_price8.Text;
                                        lbl_discount7.Text = lbl_discount8.Text;
                                        lbl_fprice7.Text = lbl_fprice8.Text;
                                        btn_remove8.Visible = false;

                                        //clear raw 8

                                        clear8();

                                        lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text) + Convert.ToInt32(lbl_fprice2.Text) + Convert.ToInt32(lbl_fprice3.Text) + Convert.ToInt32(lbl_fprice4.Text) + Convert.ToInt32(lbl_fprice5.Text) + Convert.ToInt32(lbl_fprice6.Text) + Convert.ToInt32(lbl_fprice7.Text)).ToString();
                                    }
                                    else
                                    {
                                        clear7();
                                        lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text) + Convert.ToInt32(lbl_fprice2.Text) + Convert.ToInt32(lbl_fprice3.Text) + Convert.ToInt32(lbl_fprice4.Text) + Convert.ToInt32(lbl_fprice5.Text) + Convert.ToInt32(lbl_fprice6.Text)).ToString();
                                    }
                                }
                                else
                                {
                                    clear6();
                                    lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text) + Convert.ToInt32(lbl_fprice2.Text) + Convert.ToInt32(lbl_fprice3.Text) + Convert.ToInt32(lbl_fprice4.Text) + Convert.ToInt32(lbl_fprice5.Text)).ToString();
                                }

                            }
                            else
                            {
                                clear5();
                                lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text) + Convert.ToInt32(lbl_fprice2.Text) + Convert.ToInt32(lbl_fprice3.Text) + Convert.ToInt32(lbl_fprice4.Text)).ToString();
                            }

                        }
                        else
                        {
                            clear4();
                            lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text) + Convert.ToInt32(lbl_fprice2.Text) + Convert.ToInt32(lbl_fprice3.Text)).ToString();
                        }
                    }

                    else
                    {
                        clear3();
                        lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text) + Convert.ToInt32(lbl_fprice2.Text)).ToString();
                    }
                }

                else
                {
                    clear2();
                    lbl_total.Text = (Convert.ToInt32(lbl_fprice1.Text)).ToString();
                }
            }

            else
            {
                clear1();
                lbl_total.Text = "0";
            }
        }
    }
}
