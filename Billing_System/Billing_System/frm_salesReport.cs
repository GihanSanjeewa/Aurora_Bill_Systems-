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
    public partial class frm_salesReport : Form
    {
        public frm_salesReport()
        {
            InitializeComponent();
        }


        
        private void colTot()
        {
            int sum = 0;
            for (int i = 0; i < dgv_item.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgv_item.Rows[i].Cells[3].Value);
            }
            lbl_total.Text = sum.ToString();
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand(" -- IN HERE NEED TO WRITE SALE QUERY -- BETWEEN @dtp_dateStart AND @dtp_dateEnd ", connection_class.con);


            cmd.Parameters.Add("@dtp_dateStart", MySqlDbType.Date).Value = dtp_dateStart.Value;
            cmd.Parameters.Add("@dtp_dateEnd", MySqlDbType.Date).Value = dtp_dateEnd.Value;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dgv_item.DataSource = table;

            colTot();
        }

        private void txt_searchItem_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_searchItem.Text))
            {
                e.Cancel = true;
                txt_searchItem.Focus();
                errorProvider1.SetError(txt_searchItem, "Search Item Should not be Blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_searchItem, "");
            }
        }
    }
}
