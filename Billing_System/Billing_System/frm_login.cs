﻿using System;
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

                    frm_dashboard db = new frm_dashboard();
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

        private void txt_password_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_password.Text))
            {
                e.Cancel = true;
                txt_password.Focus();
                errorProvider1.SetError(txt_password, "Password Should not be Blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_password, "");
            }
        }

        private void txt_username_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_username.Text))
            {
                e.Cancel = true;
                txt_username.Focus();
                errorProvider1.SetError(txt_username, "Username Should not be Blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_username, "");
            }
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
