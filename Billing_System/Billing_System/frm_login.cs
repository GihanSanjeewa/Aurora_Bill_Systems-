using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
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


        private void btn_login_Click(object sender, EventArgs e)
        {


            string username, password;

            username = txt_username.Text;
            password = txt_password.Text;

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

                    frm_dashbord db = new frm_dashbord();
                    this.Hide();
                    db.Show();
                }
                else
                {
                    MessageBox.Show("Invalid login !!!");
                }
            }
            catch
            {
                MessageBox.Show("Please try again !!!");
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
    }
}
