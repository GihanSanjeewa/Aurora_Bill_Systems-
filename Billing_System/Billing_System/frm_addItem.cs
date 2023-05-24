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
    public partial class frm_addItem : Form
    {
        public frm_addItem()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            connection_class.open_connection();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `item`( `itemName`, `itemPrice`, `itemQuantity`, `itemBrandName`) VALUES( @txt_itemName, @txt_itemPrice, @txt_itemQuantity, @txt_itemBrandName )", connection_class.con);
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@txt_itemName", txt_itemName.Text);
            cmd.Parameters.AddWithValue("@txt_itemPrice", txt_itemPrice.Text);
            cmd.Parameters.AddWithValue("@txt_itemQuantity", txt_itemQuantity.Text);
            cmd.Parameters.AddWithValue("@txt_itemBrandName", txt_itemBrandName.Text);


            cmd.ExecuteNonQuery();
            connection_class.close_connection();

            MessageBox.Show("Item Added Successfully!");
            fndataLoad();
        }

        public void fndataLoad()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from item", connection_class.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "dgv_item");
            dgv_item.DataSource = ds.Tables["dgv_item"].DefaultView;

        }

        private void btn_editItem_Click(object sender, EventArgs e)
        {
            frm_editItem editItem = new frm_editItem();
            this.Hide();
            editItem.Show();

        }
    }
}
