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
    public partial class frm_addCustomer : Form
    {
        public frm_addCustomer()
        {
            InitializeComponent();
        }

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
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

        private void txt_customerName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_customerName.Text))
            {
                e.Cancel = true;
                txt_customerName.Focus();
                errorProvider1.SetError(txt_customerName, "Username Should not be Blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_customerName, "");
            }
        }

        private void txt_registrationNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty( txt_registrationNo.Text))
            {
                e.Cancel = true;
                txt_customerName.Focus();
                errorProvider1.SetError(txt_registrationNo , "Username Should not be Blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_registrationNo, "");
            }
        }

        private void cmb_vehicleModel_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_vehicleModel.Text))
            {
                e.Cancel = true;
                txt_customerName.Focus();
                errorProvider1.SetError( cmb_vehicleModel, "Username Should not be Blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cmb_vehicleModel, "");
            }
        }

        private void txt_chassisNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_chassisNo.Text))
            {
                e.Cancel = true;
                txt_customerName.Focus();
                errorProvider1.SetError(txt_chassisNo, "Username Should not be Blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_chassisNo, "");
            }
        }

        private void cmb_fuelType_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_fuelType.Text))
            {
                e.Cancel = true;
                txt_customerName.Focus();
                errorProvider1.SetError(cmb_fuelType, "Username Should not be Blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cmb_fuelType, "");
            }
        }

        private void txt_km_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_km.Text))
            {
                e.Cancel = true;
                txt_customerName.Focus();
                errorProvider1.SetError(txt_km, "Username Should not be Blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_km, "");
            }
        }

        private void txt_address_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_address.Text))
            {
                e.Cancel = true;
                txt_customerName.Focus();
                errorProvider1.SetError(txt_address, "Username Should not be Blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_address, "");
            }
        }

        private void txt_company_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txt_company.Text))
            {
                e.Cancel = true;
                txt_customerName.Focus();
                errorProvider1.SetError(txt_company, "Username Should not be Blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_company, "");
            }
        }

        private void txt_phoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_phoneNumber.Text))
            {
                e.Cancel = true;
                txt_customerName.Focus();
                errorProvider1.SetError(txt_phoneNumber, "Username Should not be Blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_phoneNumber, "");
            }
        }
    }
}
