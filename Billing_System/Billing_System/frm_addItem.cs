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
            // Before adding the item, we'll call the validation functions for each textbox
            if (!ValidateItemName() || !ValidateItemPrice() || !ValidateItemQuantity() || !ValidateItemBrandName())
                return;

            connection_class.open_connection();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `item`( `itemName`, `itemPrice`, `itemQuantity`, `itemBrandName`) VALUES( @txt_itemName, @txt_itemPrice, @txt_itemQuantity, @txt_itemBrandName )", connection_class.con);
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@txt_itemName", txt_itemName.Text);
            cmd.Parameters.AddWithValue("@txt_itemPrice", txt_itemPrice.Text);
            cmd.Parameters.AddWithValue("@txt_itemQuantity", txt_itemQuantity.Text);
            cmd.Parameters.AddWithValue("@txt_itemBrandName", txt_itemBrandName.Text);

            cmd.ExecuteNonQuery();
            connection_class.close_connection();

            MessageBox.Show("Item Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fndataLoad();

            txt_itemName.Text = "";
            txt_itemPrice.Text = "";
            txt_itemQuantity.Text = "";
            txt_itemBrandName.Text = "";
        }

        // Validation for Item Name
        private bool ValidateItemName()
        {
            if (string.IsNullOrWhiteSpace(txt_itemName.Text))
            {
                MessageBox.Show("Please enter the item name.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_itemName.Focus();
                return false;
            }
            return true;
        }

        // Validation for Item Price
        private bool ValidateItemPrice()
        {
            if (!decimal.TryParse(txt_itemPrice.Text, out decimal itemPrice) || itemPrice < 0)
            {
                MessageBox.Show("Please enter a valid item price.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_itemPrice.Focus();
                return false;
            }
            return true;
        }

        // Validation for Item Quantity
        private bool ValidateItemQuantity()
        {
            if (!int.TryParse(txt_itemQuantity.Text, out int itemQuantity) || itemQuantity < 0)
            {
                MessageBox.Show("Please enter a valid item quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_itemQuantity.Focus();
                return false;
            }
            return true;
        }

        // Validation for Item Brand Name
        private bool ValidateItemBrandName()
        {
            if (string.IsNullOrWhiteSpace(txt_itemBrandName.Text))
            {
                MessageBox.Show("Please enter the item brand name.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_itemBrandName.Focus();
                return false;
            }
            return true;
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

        private void txt_itemName_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txt_itemPrice_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txt_itemQuantity_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void txt_itemBrandName_Validating(object sender, CancelEventArgs e)
        {
           
        }
    }
}
