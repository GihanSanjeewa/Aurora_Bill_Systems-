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
    public partial class addMechanic : Form
    {
        public addMechanic()
        {
            InitializeComponent();
        }

        private void btn_addMechanic_Click(object sender, EventArgs e)
        {
            connection_class.open_connection();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `mechanic`( `mechanicName`, `profession`,`contact`) VALUES( @txt_mName, @txt_profession, @txt_cNumber)", connection_class.con);
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@txt_mName", txt_mName.Text);
            cmd.Parameters.AddWithValue("@txt_profession", txt_profession.Text);
            cmd.Parameters.AddWithValue("@txt_cNumber", txt_cNumber.Text);



            cmd.ExecuteNonQuery();
            connection_class.close_connection();

            MessageBox.Show("Mechanic Added Successfully!");
            fndataLoad();
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
