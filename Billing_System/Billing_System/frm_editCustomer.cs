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
    public partial class frm_editCustomer : Form
    {
        public frm_editCustomer()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            connection_class.open_connection();
            MySqlCommand cmd1 = new MySqlCommand("SELECT `registerNumber`, `customerName`, `vehicleModel`, `chassisNumber`, `fuelType`, `km`, `address`, `phoneNumber`, `Company` FROM `customer` WHERE registerNumber =@registerNumber", connection_class.con);
            cmd1.Parameters.AddWithValue("registerNumber", txt_searchCustomer.Text);

            MySqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();

            if (reader1.Read())
            {
                txt_registrationNo.Text = reader1["registerNumber"].ToString();
                txt_customerName.Text = reader1["customerName"].ToString();
                cmb_vehicleModel.Text = reader1["vehicleModel"].ToString();
                txt_chassisNo.Text = reader1["chassisNumber"].ToString();
                cmb_fuelType.Text = reader1["fuelType"].ToString();
                txt_km.Text = reader1["km"].ToString();
                txt_address.Text = reader1["address"].ToString();
                txt_phoneNumber.Text = reader1["phoneNumber"].ToString();
                txt_company.Text = reader1["Company"].ToString();
            }
            else
            {
                MessageBox.Show("No data found !!!");
            }
            connection_class.close_connection();
        }

        private void frm_editCustomer_Load(object sender, EventArgs e)
        {
            fndataLoad();
        }

      

        private void btn_update_Click(object sender, EventArgs e)
        {
            connection_class.open_connection();

            string MysqlQry = "update customer set registerNumber =('" + txt_registrationNo.Text + "'),vehicleModel=('" + cmb_vehicleModel.Text + "'),chassisNumber=('" + txt_chassisNo.Text + "'),fuelType =('" + cmb_fuelType.Text + "'),km =('" + txt_km.Text + "'),address =('" + txt_address.Text + "'),phoneNumber =('" + txt_phoneNumber.Text + "'),Company =('" + txt_company.Text + "') where customerName = ('" + txt_customerName.Text + "')";

            MySqlCommand cmd = new MySqlCommand(MysqlQry, connection_class.con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Customer updated successfully !!!");

            connection_class.close_connection();


            fndataLoad();
        }

        public void fndataLoad()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from customer", connection_class.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "dgv_customer");
            dgv_customer.DataSource = ds.Tables["dgv_customer"].DefaultView;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            connection_class.open_connection();

            string MysqlQry = "delete from customer where registerNumber =('" + txt_registrationNo.Text + "')";

            MySqlCommand cmd = new MySqlCommand(MysqlQry, connection_class.con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Customer deleted successfully !!!");

            connection_class.close_connection();


            fndataLoad();
        }

        private void dgv_customer_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvrow = dgv_customer.Rows[e.RowIndex];
                txt_registrationNo.Text = dgvrow.Cells[0].Value.ToString();
                txt_customerName.Text = dgvrow.Cells[1].Value.ToString();
                cmb_vehicleModel.Text = dgvrow.Cells[2].Value.ToString();
                txt_chassisNo.Text = dgvrow.Cells[3].Value.ToString();
                cmb_fuelType.Text = dgvrow.Cells[4].Value.ToString();
                txt_km.Text = dgvrow.Cells[5].Value.ToString();
                txt_address.Text = dgvrow.Cells[6].Value.ToString();
                txt_phoneNumber.Text = dgvrow.Cells[7].Value.ToString();
                txt_company.Text = dgvrow.Cells[8].Value.ToString();

            }
        }
    }
}
