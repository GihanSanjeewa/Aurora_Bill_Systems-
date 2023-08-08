using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if(!ValidateRegistrationNo() || !ValidateCustomerName() || !ValidateVehicleModel() || !ValidateChassisNo() || !ValidateFuelType() || !ValidateKM() || !ValidateAddress() || !ValidateCompany() || !ValidatePhoneNo())

            connection_class.open_connection();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `customer`( `registerNumber`, `customerName`, `vehicleModel`, `chassisNumber`, `fuelType`, `km`,`address`,`phoneNumber`,`Company`) VALUES( @txt_registrationNo, @txt_customerName, @cmb_vehicleModel, @txt_chassisNo, @cmb_fuelType, @txt_km, @txt_address, @txt_phoneNumber, @txt_company )", connection_class.con);
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@txt_registrationNo", txt_registrationNo.Text);
            cmd.Parameters.AddWithValue("@txt_customerName", txt_customerName.Text);
            cmd.Parameters.AddWithValue("@cmb_vehicleModel", cmb_vehicleModel.Text);
            cmd.Parameters.AddWithValue("@txt_chassisNo", txt_chassisNo.Text);
            cmd.Parameters.AddWithValue("@cmb_fuelType", cmb_fuelType.Text);
            cmd.Parameters.AddWithValue("@txt_km", txt_km.Text);
            cmd.Parameters.AddWithValue("@txt_address", txt_address.Text);
            cmd.Parameters.AddWithValue("@txt_company", txt_company.Text);
            cmd.Parameters.AddWithValue("@txt_phoneNumber", txt_phoneNumber.Text);



            cmd.ExecuteNonQuery();
            connection_class.close_connection();

            MessageBox.Show("Customer Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fndataLoad();

            txt_registrationNo.Text = "";
            txt_customerName.Text = "";
            cmb_vehicleModel.Text = "";
            txt_chassisNo.Text = "";
            cmb_fuelType.Text = "";
            txt_km.Text = "";
            txt_address.Text = "";
            txt_company.Text = "";
            txt_phoneNumber.Text = "";


        }

        //Validation Registration Number
        private bool ValidateRegistrationNo()
        {
            if (string.IsNullOrWhiteSpace(txt_registrationNo.Text))
            {
                MessageBox.Show("Please enter the Registration Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_registrationNo.Focus();
                return false;
            }
            // Use regular expression to check for A-Z and a-z only
            if (!Regex.IsMatch(txt_registrationNo.Text, "^[A-Za-z]+$,^[0-9]+$"))
            {
                MessageBox.Show("Customer's Registration Number should contain letters (A-Z and a-z) and numbers (0-9).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_registrationNo.Focus();
                return false;
            }

            return true;
        }

        //Validation Customer Name
        private bool ValidateCustomerName()
        {
            if (string.IsNullOrWhiteSpace(txt_customerName.Text))
            {
                MessageBox.Show("Please enter the Customer Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_customerName.Focus();
                return false;
            }
            
            // Use regular expression to check for A-Z and a-z only
            if (!Regex.IsMatch(txt_customerName.Text, "^[A-Za-z]+$"))
            {
                MessageBox.Show("Mechanic name should contain only letters (A-Z and a-z).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_customerName.Focus();
                return false;
            }
            return true;
        }

        //Validation Vehicle Model
        private bool ValidateVehicleModel()
        {
            if (string.IsNullOrWhiteSpace(cmb_vehicleModel.Text))
            {
                MessageBox.Show("Please select vehicle Model.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_vehicleModel.Focus();
                return false;
            }
            return true;
        }

        //Validation Chassis Number
        private bool ValidateChassisNo()
        {
            if (string.IsNullOrWhiteSpace(txt_chassisNo.Text))
            {
                MessageBox.Show("Please enter the chassis number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_chassisNo.Focus();
                return false;
            }
            // Use regular expression to check for A-Z and a-z only
            if (!Regex.IsMatch(txt_registrationNo.Text, "^[A-Za-z]+$,^[0-9]+$"))
            {
                MessageBox.Show("Vehicle Chassis Number should contain letters (A-Z and a-z) and numbers (0-9).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_registrationNo.Focus();
                return false;
            }
            return true;
        }

        //Validation Fuel Type
        private bool ValidateFuelType()
        {
            if (string.IsNullOrWhiteSpace(cmb_fuelType.Text))
            {
                MessageBox.Show("Please select fuel Type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_fuelType.Focus();
                return false;
            }
            return true;
        }

        //Validation kilo meters
        private bool ValidateKM()
        {
            if (string.IsNullOrWhiteSpace(txt_km.Text))
            {
                MessageBox.Show("Please enter the amount of kilo meters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_km.Focus();
                return false;
            }

            // Use regular expression to check for numbers only
            if (!Regex.IsMatch(txt_km.Text, "^[0-9]+$"))
            {
                MessageBox.Show("Kilo meters should contain only numbers (0-9).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_km.Focus();
                return false;
            }
            return true;
        }

        //Validation Address
        private bool ValidateAddress()
        {
            if (string.IsNullOrWhiteSpace(txt_address.Text))
            {
                MessageBox.Show("Please enter the customer's address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_address.Focus();
                return false;
            }
            // Use regular expression to check for A-Z and a-z only
            if (!Regex.IsMatch(txt_registrationNo.Text, "^[A-Za-z]+$,^[0-9]+$"))
            {
                MessageBox.Show("Customer Address should contain letters (A-Z and a-z) and numbers (0-9).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_registrationNo.Focus();
                return false;
            }

            return true;
        }

        //Validation Company
        private bool ValidateCompany()
        {
            if (string.IsNullOrWhiteSpace(txt_company.Text))
            {
                MessageBox.Show("Please enter the customer's company.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_company.Focus();
                return false;
            }

            return true;
        }

        //Validation Phone Number
        private bool ValidatePhoneNo()
{
            if (string.IsNullOrWhiteSpace(txt_phoneNumber.Text))
            {
                MessageBox.Show("Please enter the customer phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_phoneNumber.Focus();
                return false;
            }
            return true;
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

        private void txt_customerName_Validating(object sender, CancelEventArgs e)
        {
        }

        private void txt_registrationNo_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void cmb_vehicleModel_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void txt_chassisNo_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void cmb_fuelType_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void txt_km_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void txt_address_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txt_company_Validating(object sender, CancelEventArgs e)
        {

           
        }

        private void txt_phoneNumber_Validating(object sender, CancelEventArgs e)
        {
           
        }
    }
}
