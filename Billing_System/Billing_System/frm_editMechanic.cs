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
    public partial class frm_editMechanic : Form
    {
        public frm_editMechanic()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            connection_class.open_connection();
            MySqlCommand cmd1 = new MySqlCommand("SELECT `mechanicId`, `mechanicName`, `profession`, `contact` FROM `mechanic` WHERE mechanicName =@mechanicName", connection_class.con);
            cmd1.Parameters.AddWithValue("mechanicName", txt_searchMechanic.Text);

            MySqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();

            if (reader1.Read())
            {
                txt_mId.Text = reader1["mechanicId"].ToString();
                txt_mName.Text = reader1["mechanicName"].ToString();
                txt_profession.Text = reader1["profession"].ToString();
                txt_cNumber.Text = reader1["contact"].ToString();
            }
            else
            {
                MessageBox.Show("No data found !!!");
            }
            connection_class.close_connection();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            connection_class.open_connection();

            string MysqlQry = "update mechanic set mechanicName =('" + txt_mName.Text + "'),profession =('" + txt_profession.Text + "'), contact =('" + txt_cNumber.Text + "') where mechanicId = ('" + txt_mId.Text + "')";

            MySqlCommand cmd = new MySqlCommand(MysqlQry, connection_class.con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Mechanic updated successfully !!!");

            connection_class.close_connection();


            fndataLoad();
        }

        public void fndataLoad()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from mechanic", connection_class.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "dgv_mechanic");
            dgv_mechanic.DataSource = ds.Tables["dgv_mechanic"].DefaultView;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            connection_class.open_connection();

            string MysqlQry = "delete from mechanic where mechanicId =('" + txt_mId.Text + "')";

            MySqlCommand cmd = new MySqlCommand(MysqlQry, connection_class.con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Mechanic deleted successfully !!!");

            connection_class.close_connection();


            fndataLoad();
        }



        private void frm_editMechanic_Load(object sender, EventArgs e)
        {
            fndataLoad();
        }

        private void dgv_mechanic_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvrow = dgv_mechanic.Rows[e.RowIndex];
                txt_mId.Text = dgvrow.Cells[0].Value.ToString();
                txt_mName.Text = dgvrow.Cells[1].Value.ToString();
                txt_profession.Text = dgvrow.Cells[2].Value.ToString();
                txt_cNumber.Text = dgvrow.Cells[3].Value.ToString();

            }
        }
    }
}
