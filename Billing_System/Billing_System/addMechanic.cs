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
    public partial class addMechanic : Form
    {
        public addMechanic()
        {
            InitializeComponent();
        }

        private void btn_addMechanic_Click(object sender, EventArgs e)
        {

            if (!ValidateMName() || !ValidateProfession() || !ValidateNumber())
                return;

            connection_class.open_connection();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `mechanic`( `mechanicName`, `profession`,`contact`) VALUES( @txt_mName, @txt_profession, @txt_cNumber)", connection_class.con);
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@txt_mName", txt_mName.Text);
            cmd.Parameters.AddWithValue("@txt_profession", txt_profession.Text);
            cmd.Parameters.AddWithValue("@txt_cNumber", txt_cNumber.Text);



            cmd.ExecuteNonQuery();
            connection_class.close_connection();

            MessageBox.Show("Machanic Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fndataLoad();

            txt_mName.Text ="";
            txt_profession.Text ="";
            txt_cNumber.Text ="";

        }

        //validation machanic name
            
        private bool ValidateMName()
        {
            if (string.IsNullOrWhiteSpace(txt_mName.Text))
            {
                MessageBox.Show("Please enter the machanic name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_mName.Focus();
                return false;
            }

            // Use regular expression to check for A-Z and a-z only
            if (!Regex.IsMatch(txt_mName.Text, "^[A-Za-z]+$"))
            {
                MessageBox.Show("Mechanic name should contain only letters (A-Z and a-z).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_mName.Focus();
                return false;
            }
            return true;
        }

        //Validation Profession
        private bool ValidateProfession()
        {
            if (string.IsNullOrWhiteSpace(txt_profession.Text))
            {
                MessageBox.Show("Please enter the profession name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_profession.Focus();
                return false;
            }

            // Use regular expression to check for A-Z and a-z only
            if (!Regex.IsMatch(txt_profession.Text, "^[A-Za-z]+$"))
            {
                MessageBox.Show("Mechanic name should contain only letters (A-Z and a-z).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_profession.Focus();
                return false;
            }
            return true;
        }

        //Validation Number
        private bool ValidateNumber()
        {
            if (string.IsNullOrWhiteSpace(txt_cNumber.Text))
            {
                MessageBox.Show("Please enter the machanic number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_cNumber.Focus();
                return false;
            }

            // Use regular expression to check for numbers only
            if (!Regex.IsMatch(txt_cNumber.Text, "^[0-9]+$"))
            {
                MessageBox.Show("Contact number should contain only numbers (0-9).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_cNumber.Focus();
                return false;
            }

            return true;
        }

        public void fndataLoad()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from mechanic", connection_class.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "dgv_mechanic");
            dgv_mechanic.DataSource = ds.Tables["dgv_mechanic"].DefaultView;

        }

        private void btn_editMechanic_Click(object sender, EventArgs e)
        {
            frm_editMechanic editMechanic = new frm_editMechanic();
            editMechanic.Show();

        }
    }
}
