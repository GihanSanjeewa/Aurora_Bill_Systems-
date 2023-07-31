using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Billing_System
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = true;
        }

        //private bool IsValidStringInput(string input)
        //{
        //    // Regular expression pattern to check for only string values
        //    string pattern = @"^[a-zA-Z]+$";
        //    return Regex.IsMatch(input, pattern);
        //}

        private bool IsValidStringInput(string input)
        {
            // Regular expression pattern to check for only string values
            string pattern = @"^[a-zA-Z]+$";
            return Regex.IsMatch(input, pattern);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {


            string username, password;

            username = txt_username.Text;
            password = txt_password.Text;




            //if (!IsValidStringInput(username) && !IsValidStringInput(password))
            //{
            //    txt_password.Clear();
            //    txt_username.Clear();
            //    return;
            //}

            if (!IsValidStringInput(username) && !IsValidStringInput(password))
            {
                txt_password.Clear();
                txt_username.Clear();
                return;
            }

            try
            {
                string qry = "select * from user where userName = '" + txt_username.Text + "'AND password = '" + txt_password.Text + "'";
                MySqlDataAdapter sda = new MySqlDataAdapter(qry, connection_class.con);
                DataTable dtb = new DataTable();
                sda.Fill(dtb);

                if (dtb.Rows.Count > 0)
                {
                    username = txt_username.Text;
                    password = txt_password.Text;

                    frm_dashboard db = new frm_dashboard();
                    this.Hide();
                    db.Show();
                }
                else
                {
                    MessageBox.Show("Username or password incorrect!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            
            catch
            {
                MessageBox.Show(" please try agin","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
               
            }
        }

        private void btn_showPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txt_password.UseSystemPasswordChar = false;
        }

        private void btn_showPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txt_password.UseSystemPasswordChar = true;
        }

        private void txt_password_Validating(object sender, CancelEventArgs e)
        {
        }

        private void txt_username_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }
    }
}
