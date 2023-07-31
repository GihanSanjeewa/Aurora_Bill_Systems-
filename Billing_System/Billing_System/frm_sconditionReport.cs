using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_System
{
    public partial class frm_sconditionReport : Form
    {

        public static string setEngineOil = "";
        


        String engineOil;
        String gearOil;
        String breakOil;
        String acFilter;
        String breaks;
        String radiator; 
        String socket;
        String airFilter;
        String tire;
        String larm;
        String uarm;
        String carm; 
        String ebelt;
        String axel; 
        String mount;
        String oilLeak;

        

        public frm_sconditionReport()
        {
            InitializeComponent();
            lbl_date.Text = DateTime.Now.ToString();

            
        }

        void mechanicName()
        {
            try
            {
                connection_class.open_connection();
                String command_query = "SELECT mechanicName FROM mechanic";
                MySqlCommand cmd = new MySqlCommand(command_query, connection_class.con);
                MySqlDataReader mydr;
                mydr = cmd.ExecuteReader();
                if (mydr.Read())
                {
                    string mName = mydr.GetString("mechanicName");
                    cmb_mName.Items.Add(mName);
                }

                connection_class.close_connection();
            }
            catch
            {
                MessageBox.Show("You Can Not Use System Without DataBase Connection","Please Contact Your Developers");

            }
            
        }

        private void txt_vehicleNmber_Validating(object sender, CancelEventArgs e)
        {
        }

        private void txt_vehicleModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_vehicleModel_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_km_Validating(object sender, CancelEventArgs e)
        {
            
        }

        //private bool IsValidNumericInput(string input)
        //{
        //    // Regular expression pattern to check for only numbers
        //    string pattern = @"^\d+$";
        //    return Regex.IsMatch(input, pattern);
        //}

        //private bool IsValidStringInput(string input)
        //{
        //    // Regular expression pattern to check for only string values
        //    string pattern = @"^[a-zA-Z]+$";
        //    return Regex.IsMatch(input, pattern);
        //}

        //private void ClearAllTextBoxesExceptNumeric()
        //{
        //    txt_vehicleNumber.Clear();
        //    txt_vehicleModel.Clear();
        //    txt_km.Clear();
        //    txt_fuelType.Clear();
        //}

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
            txt_vehicleNumber.Clear();
            txt_vehicleModel.Clear();
            txt_km.Clear();
            txt_fuelType.Clear();
        }

        private void btn_process_Click(object sender, EventArgs e)
        {
            connection_class.open_connection();

            //String ValidateVNumber = txt_vehicleNumber.Text;


            //if (!IsValidStringInput(ValidateVNumber))
            //{
            //    MessageBox.Show("Invalid input! Please enter Correct Vehical Number.");
            //    ClearAllTextBoxesExceptNumeric();
            //    return;
            //}

            String ValidateVNumber = txt_vehicleNumber.Text;


            if (!IsValidStringInput(ValidateVNumber))
            {
                MessageBox.Show("Invalid input! Please enter Correct Vehical Number.");
                ClearAllTextBoxesExceptNumeric();
                return;
            }





            RadioButton[] newRadioButtons = {rbtn_engineoilGood,rbtn_engineoilBad,rbtn_gearoilGood,
                rbtn_gearoilBad,rbtn_upperarmGood,rbtn_upperarmBad,rbtn_tireGood,rbtn_tireBad,rbtn_socketGood,rbtn_socketBad,rbtn_radiatorGood,
                rbtn_radiatorBad,rbtn_oilLeakGood,rbtn_oilLeakBad,rbtn_mountGood,
                rbtn_mountBad,rbtn_lowarmGood,rbtn_lowarmBad,rbtn_ebeltGood,rbtn_ebeltBad,rbtn_carmGood,rbtn_carmBad,
                rbtn_breakGood,rbtn_breakBad,rbtn_axelGood,rbtn_axelBad,rbtn_airfilterGood,rbtn_airfilterBad,rbtn_acfilterGood,rbtn_acfilterBad };

            bool anyRadioButtonChecked = newRadioButtons.Any(radioButton => radioButton.Checked);

            if (anyRadioButtonChecked)
            {
                try
                {

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO `sconditionreport`( `registerNumber`, `vehicleModel`, `fuelType`, `km`, `mechanicName`,  `date`, `engineOilStatus`, `gearOilStatus`, `breakOilStatus`, `airFilterStatus`,`acFilterStatus`,`breakStatus`,`radiatorCWaterStatus`, `socketStatus`,`rodRackStatus`,`lowBushStatus`,`upperBushStatus`, `cArmStatus`, `eBeltStatus`, `axelStatus`, `mountStatus`, `leakOilStatus`) VALUES( @txt_registerNumber, @txt_vehicleModel, @txt_fuelType, @txt_km, @txt_mechanicName,  @txt_date, @txt_engineOilStatus, @txt_gearOilStatus, @txt_breakOilStatus, @txt_airFilterStatus, @txt_acFilterStatus, @txt_breakStatus, @txt_radiatorCWaterStatus, @txt_socketStatus, @txt_rodRackStatus, @txt_lowBushStatus, @txt_upperBushStatus, @txt_cArmStatus, @txt_eBeltStatus, @txt_axelStatus, @txt_mountStatus, @txt_leakOilStatus )", connection_class.con);
                    cmd.Parameters.Clear();


                    cmd.Parameters.AddWithValue("@txt_registerNumber", txt_vehicleNumber.Text);

                    cmd.Parameters.AddWithValue("@txt_vehicleModel", txt_vehicleModel.Text);

                    cmd.Parameters.AddWithValue("@txt_fuelType", txt_fuelType.Text);

                    cmd.Parameters.AddWithValue("@txt_km", txt_km.Text);

                    cmd.Parameters.AddWithValue("@txt_mechanicName", cmb_mName.Text);

                    cmd.Parameters.AddWithValue("@txt_date", lbl_date.Text);

                    //--------

                    if (rbtn_engineoilGood.Checked == true)
                    {
                        engineOil = "Good";
                        setEngineOil = rbtn_engineoilGood.Text;
                    }
                    else if (rbtn_engineoilBad.Checked == true)
                    {
                        engineOil = "Bad";
                    }

                    cmd.Parameters.Add("@txt_engineOilStatus", MySqlDbType.VarChar).Value = engineOil;


                    //---------

                    if (rbtn_gearoilGood.Checked == true)
                    {
                        gearOil = "Good";
                    }
                    else if (rbtn_gearoilBad.Checked == true)
                    {
                        gearOil = "Bad";
                    }

                    cmd.Parameters.Add("@txt_gearOilStatus", MySqlDbType.VarChar).Value = gearOil;

                    //---------

                    if (rbtn_breakoilGood.Checked == true)
                    {
                        breakOil = "Good";
                    }
                    else if (rbtn_breakoilBad.Checked == true)
                    {
                        breakOil = "Bad";
                    }

                    cmd.Parameters.Add("@txt_breakOilStatus", MySqlDbType.VarChar).Value = breakOil;

                    //---------

                    if (rbtn_airfilterGood.Checked == true)
                    {
                        airFilter = "Good";
                    }
                    else if (rbtn_airfilterBad.Checked == true)
                    {
                        airFilter = "Bad";
                    }

                    cmd.Parameters.Add("@txt_airFilterStatus", MySqlDbType.VarChar).Value = airFilter;

                    //---------

                    if (rbtn_acfilterGood.Checked == true)
                    {
                        acFilter = "Good";
                    }
                    else if (rbtn_acfilterBad.Checked == true)
                    {
                        acFilter = "Bad";
                    }

                    cmd.Parameters.Add("@txt_acFilterStatus", MySqlDbType.VarChar).Value = acFilter;

                    //---------

                    if (rbtn_breakGood.Checked == true)
                    {
                        breaks = "Good";
                    }
                    else if (rbtn_breakBad.Checked == true)
                    {
                        breaks = "Bad";
                    }

                    cmd.Parameters.Add("@txt_breakStatus", MySqlDbType.VarChar).Value = breaks;

                    //---------

                    if (rbtn_radiatorGood.Checked == true)
                    {
                        radiator = "Good";
                    }
                    else if (rbtn_radiatorBad.Checked == true)
                    {
                        radiator = "Bad";
                    }

                    cmd.Parameters.Add("@txt_radiatorCWaterStatus", MySqlDbType.VarChar).Value = radiator;

                    //---------

                    if (rbtn_socketGood.Checked == true)
                    {
                        socket = "Good";
                    }
                    else if (rbtn_socketBad.Checked == true)
                    {
                        socket = "Bad";
                    }

                    cmd.Parameters.Add("@txt_socketStatus", MySqlDbType.VarChar).Value = socket;

                    //---------

                    if (rbtn_tireGood.Checked == true)
                    {
                        tire = "Good";
                    }
                    else if (rbtn_tireBad.Checked == true)
                    {
                        tire = "Bad";
                    }

                    cmd.Parameters.Add("@txt_rodRackStatus", MySqlDbType.VarChar).Value = tire;

                    //---------
                    if (rbtn_lowarmGood.Checked == true)
                    {
                        larm = "Good";
                    }
                    else if (rbtn_lowarmBad.Checked == true)
                    {
                        larm = "Bad";
                    }

                    cmd.Parameters.Add("@txt_lowBushStatus", MySqlDbType.VarChar).Value = larm;

                    //---------

                    if (rbtn_upperarmGood.Checked == true)
                    {
                        uarm = "Good";
                    }
                    else if (rbtn_upperarmBad.Checked == true)
                    {
                        uarm = "Bad";
                    }

                    cmd.Parameters.Add("@txt_upperBushStatus", MySqlDbType.VarChar).Value = uarm;

                    //---------

                    if (rbtn_carmGood.Checked == true)
                    {
                        carm = "Good";
                    }
                    else if (rbtn_carmBad.Checked == true)
                    {
                        carm = "Bad";
                    }

                    cmd.Parameters.Add("@txt_cArmStatus", MySqlDbType.VarChar).Value = carm;

                    //---------

                    if (rbtn_ebeltGood.Checked == true)
                    {
                        ebelt = "Good";
                    }
                    else if (rbtn_ebeltBad.Checked == true)
                    {
                        ebelt = "Bad";
                    }

                    cmd.Parameters.Add("@txt_eBeltStatus", MySqlDbType.VarChar).Value = ebelt;

                    //---------

                    if (rbtn_axelGood.Checked == true)
                    {
                        axel = "Good";
                    }
                    else if (rbtn_axelBad.Checked == true)
                    {
                        axel = "Bad";
                    }

                    cmd.Parameters.Add("@txt_axelStatus", MySqlDbType.VarChar).Value = axel;

                    //---------

                    if (rbtn_mountGood.Checked == true)
                    {
                        mount = "Good";
                    }
                    else if (rbtn_mountBad.Checked == true)
                    {
                        mount = "Bad";
                    }

                    cmd.Parameters.Add("@txt_mountStatus", MySqlDbType.VarChar).Value = mount;

                    //---------

                    if (rbtn_oilLeakGood.Checked == true)
                    {
                        oilLeak = "Good";

                    }
                    else if (rbtn_oilLeakBad.Checked == true)
                    {
                        oilLeak = "Bad";
                    }

                    cmd.Parameters.Add("@txt_leakOilStatus", MySqlDbType.VarChar).Value = oilLeak;

                    //---------

                    cmd.ExecuteNonQuery();
                    connection_class.close_connection();
                    MessageBox.Show("Saved Successfully!");

                    sconditionPrint sc = new sconditionPrint();
                    sc.Show();
                }
                catch
                {
                    MessageBox.Show("Please Fill The All Values", "Somthing Wrong !");

                }


                    
                }

              
            else
            {
                // when no radio button is checked

                int inti;
                for (inti = 0; inti < newRadioButtons.Length; inti++)
                {

                    if (newRadioButtons[inti].Checked == false)
                    {
                        MessageBox.Show("Please Select All Values");
                        newRadioButtons[inti].Focus();
                        return;
                    }
                }
            }

            

     

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
