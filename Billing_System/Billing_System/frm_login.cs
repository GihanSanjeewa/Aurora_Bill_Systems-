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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = true;
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            frm_dashbord dashbord = new frm_dashbord();
            this.Hide();
            dashbord.Show();
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
