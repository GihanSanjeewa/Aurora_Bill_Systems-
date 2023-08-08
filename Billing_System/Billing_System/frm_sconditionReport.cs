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


        public static string  vehicle_number="";
        public static string VehicleModel="";
        public static string MachanicName="";
        public static string fuel="";
        public static string km="";
        public static string date="";
        public static string engineOil="";
        public static string gearOil="";
        public static string breakOil="";
        public static string acFilter="";
        public static string breaks="";
        public static string radiator=""; 
        public static string socket="";
        public static string airFilter="";
        public static string tire="";
        public static string larm="";
        public static string uarm="";
        public static string carm=""; 
        public static string ebelt="";
        public static string axel=""; 
        public static string mount="";
        public static string rod="";
        public static string low="";
        public static string upper="";
        public static string oilLeak="";

        

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






            RadioButton[] newRadioButtons = {rbtn_engineoilGood,rbtn_engineoilBad,rbtn_gearoilGood,
                rbtn_gearoilBad,rbtn_upperarmGood,rbtn_upperarmBad,rbtn_tireGood,rbtn_tireBad,rbtn_socketGood,rbtn_socketBad,rbtn_radiatorGood,
                rbtn_radiatorBad,rbtn_oilLeakGood,rbtn_oilLeakBad,rbtn_mountGood,
                rbtn_mountBad,rbtn_lowarmGood,rbtn_lowarmBad,rbtn_ebeltGood,rbtn_ebeltBad,rbtn_carmGood,rbtn_carmBad,
                rbtn_breakGood,rbtn_breakBad,rbtn_axelGood,rbtn_axelBad,rbtn_airfilterGood,rbtn_airfilterBad,rbtn_acfilterGood,rbtn_acfilterBad };

            bool anyRadioButtonChecked = newRadioButtons.Any(radioButton => radioButton.Checked);

            if (anyRadioButtonChecked)
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

                    //---------Direct send tire rod

                    if (rbtn_tireGood.Checked == true)
                    {
                        tire = "Good";
                        rod = tire;
                    }
                    else if (rbtn_tireBad.Checked == true)
                    {
                        tire = "Bad";
                        rod = tire;
                    }

                    cmd.Parameters.Add("@txt_rodRackStatus", MySqlDbType.VarChar).Value = tire;

                    //---------Direct send lower
                    if (rbtn_lowarmGood.Checked == true)
                    {
                        larm = "Good";
                        low = larm;
                    }
                    else if (rbtn_lowarmBad.Checked == true)
                    {
                        larm = "Bad";
                        low = larm;
                    }

                    cmd.Parameters.Add("@txt_lowBushStatus", MySqlDbType.VarChar).Value = larm;

                    //---------Direct send upper

                    if (rbtn_upperarmGood.Checked == true)
                    {
                        uarm = "Good";
                        upper = uarm;
                    }
                    else if (rbtn_upperarmBad.Checked == true)
                    {
                        uarm = "Bad";
                        upper = uarm;
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


           
                connection_class.open_connection();
                MySqlCommand cmd1 = new MySqlCommand("SELECT `registerNumber`, `vehicleModel`, `fuelType`, `km`, `mechanicName`, `date`, `engineOilStatus`, `gearOilStatus`, `breakOilStatus`, `airFilterStatus`, `acFilterStatus`, `breakStatus`, `radiatorCWaterStatus`, `socketStatus`, `rodRackStatus`, `lowBushStatus`, `upperBushStatus`, `cArmStatus`, `eBeltStatus`, `axelStatus`, `mountStatus`, `leakOilStatus` FROM `sconditionreport` WHERE registerNumber =@registerNumber", connection_class.con);
                cmd1.Parameters.AddWithValue("registerNumber", txt_vehicleNumber.Text);

                MySqlDataReader reader1;
                reader1 = cmd1.ExecuteReader();


                vehicle_number = txt_vehicleNumber.Text;
                VehicleModel = txt_vehicleModel.Text;

                MachanicName = cmb_mName.Text;
                fuel = txt_fuelType.Text;
                km = txt_km.Text;
                date = DateTime.Now.ToString("hh:mm");
            while (reader1.Read())
            {
                date = reader1["date"].ToString();
                engineOil = reader1["engineOilStatus"].ToString();
                gearOil = reader1["gearOilStatus"].ToString();
                breakOil = reader1["breakOilStatus"].ToString();
                airFilter = reader1["airFilterStatus"].ToString();
                acFilter = reader1["acFilterStatus"].ToString();
                breaks = reader1["breakStatus"].ToString();
                radiator = reader1["radiatorCWaterStatus"].ToString();
                socket = reader1["socketStatus"].ToString();

                //These three values cannot send using database (Have to find)
                /*rod = reader1["rodRackStatus"].ToString();
                low = reader1["lowBushStatus"].ToString();
                upper = reader1["upperBushStatus"].ToString();*/

                carm = reader1["cArmStatus"].ToString();
                ebelt = reader1["eBeltStatus"].ToString();
                axel = reader1["axelStatus"].ToString();
                mount = reader1["mountStatus"].ToString();
                oilLeak = reader1["leakOilStatus"].ToString();
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
