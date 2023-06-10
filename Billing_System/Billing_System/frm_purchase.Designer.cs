namespace Billing_System
{
    partial class frm_purchase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_purchasingID = new Guna.UI2.WinForms.Guna2TextBox();
            this.item_name = new System.Windows.Forms.Label();
            this.item_quantity = new System.Windows.Forms.Label();
            this.item_purchPrice = new System.Windows.Forms.Label();
            this.dealer = new System.Windows.Forms.Label();
            this.txt_itemName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_itemQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_item_purchPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_dealer = new Guna.UI2.WinForms.Guna2TextBox();
            this.purch_date = new System.Windows.Forms.Label();
            this.txt_purch_date = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.purchase = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(405, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purchasing ID";
            // 
            // txt_purchasingID
            // 
            this.txt_purchasingID.BorderRadius = 3;
            this.txt_purchasingID.BorderThickness = 2;
            this.txt_purchasingID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_purchasingID.DefaultText = "";
            this.txt_purchasingID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_purchasingID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_purchasingID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_purchasingID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_purchasingID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_purchasingID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_purchasingID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_purchasingID.Location = new System.Drawing.Point(768, 204);
            this.txt_purchasingID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_purchasingID.Name = "txt_purchasingID";
            this.txt_purchasingID.PasswordChar = '\0';
            this.txt_purchasingID.PlaceholderText = "";
            this.txt_purchasingID.SelectedText = "";
            this.txt_purchasingID.Size = new System.Drawing.Size(258, 46);
            this.txt_purchasingID.TabIndex = 2;
            // 
            // item_name
            // 
            this.item_name.AutoSize = true;
            this.item_name.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_name.ForeColor = System.Drawing.Color.White;
            this.item_name.Location = new System.Drawing.Point(405, 289);
            this.item_name.Name = "item_name";
            this.item_name.Size = new System.Drawing.Size(120, 27);
            this.item_name.TabIndex = 0;
            this.item_name.Text = "Item Name";
            // 
            // item_quantity
            // 
            this.item_quantity.AutoSize = true;
            this.item_quantity.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_quantity.ForeColor = System.Drawing.Color.White;
            this.item_quantity.Location = new System.Drawing.Point(405, 377);
            this.item_quantity.Name = "item_quantity";
            this.item_quantity.Size = new System.Drawing.Size(168, 27);
            this.item_quantity.TabIndex = 0;
            this.item_quantity.Text = "Item Quantity";
            // 
            // item_purchPrice
            // 
            this.item_purchPrice.AutoSize = true;
            this.item_purchPrice.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_purchPrice.ForeColor = System.Drawing.Color.White;
            this.item_purchPrice.Location = new System.Drawing.Point(405, 462);
            this.item_purchPrice.Name = "item_purchPrice";
            this.item_purchPrice.Size = new System.Drawing.Size(264, 27);
            this.item_purchPrice.TabIndex = 0;
            this.item_purchPrice.Text = "Item Purchasing Price";
            this.item_purchPrice.Click += new System.EventHandler(this.item_purchPrice_Click);
            // 
            // dealer
            // 
            this.dealer.AutoSize = true;
            this.dealer.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealer.ForeColor = System.Drawing.Color.White;
            this.dealer.Location = new System.Drawing.Point(405, 539);
            this.dealer.Name = "dealer";
            this.dealer.Size = new System.Drawing.Size(84, 27);
            this.dealer.TabIndex = 0;
            this.dealer.Text = "Dealer";
            // 
            // txt_itemName
            // 
            this.txt_itemName.BorderRadius = 3;
            this.txt_itemName.BorderThickness = 2;
            this.txt_itemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_itemName.DefaultText = "";
            this.txt_itemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_itemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_itemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_itemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_itemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_itemName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_itemName.Location = new System.Drawing.Point(768, 289);
            this.txt_itemName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.PasswordChar = '\0';
            this.txt_itemName.PlaceholderText = "";
            this.txt_itemName.SelectedText = "";
            this.txt_itemName.Size = new System.Drawing.Size(258, 46);
            this.txt_itemName.TabIndex = 2;
            // 
            // txt_itemQuantity
            // 
            this.txt_itemQuantity.BorderRadius = 3;
            this.txt_itemQuantity.BorderThickness = 2;
            this.txt_itemQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_itemQuantity.DefaultText = "";
            this.txt_itemQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_itemQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_itemQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_itemQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_itemQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_itemQuantity.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_itemQuantity.Location = new System.Drawing.Point(768, 377);
            this.txt_itemQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_itemQuantity.Name = "txt_itemQuantity";
            this.txt_itemQuantity.PasswordChar = '\0';
            this.txt_itemQuantity.PlaceholderText = "";
            this.txt_itemQuantity.SelectedText = "";
            this.txt_itemQuantity.Size = new System.Drawing.Size(258, 46);
            this.txt_itemQuantity.TabIndex = 2;
            // 
            // txt_item_purchPrice
            // 
            this.txt_item_purchPrice.BorderRadius = 3;
            this.txt_item_purchPrice.BorderThickness = 2;
            this.txt_item_purchPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_item_purchPrice.DefaultText = "";
            this.txt_item_purchPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_item_purchPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_item_purchPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_item_purchPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_item_purchPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_item_purchPrice.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_item_purchPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_item_purchPrice.Location = new System.Drawing.Point(768, 462);
            this.txt_item_purchPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_item_purchPrice.Name = "txt_item_purchPrice";
            this.txt_item_purchPrice.PasswordChar = '\0';
            this.txt_item_purchPrice.PlaceholderText = "";
            this.txt_item_purchPrice.SelectedText = "";
            this.txt_item_purchPrice.Size = new System.Drawing.Size(258, 46);
            this.txt_item_purchPrice.TabIndex = 2;
            // 
            // txt_dealer
            // 
            this.txt_dealer.BorderRadius = 3;
            this.txt_dealer.BorderThickness = 2;
            this.txt_dealer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_dealer.DefaultText = "";
            this.txt_dealer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_dealer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_dealer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_dealer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_dealer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_dealer.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dealer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_dealer.Location = new System.Drawing.Point(768, 548);
            this.txt_dealer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_dealer.Name = "txt_dealer";
            this.txt_dealer.PasswordChar = '\0';
            this.txt_dealer.PlaceholderText = "";
            this.txt_dealer.SelectedText = "";
            this.txt_dealer.Size = new System.Drawing.Size(258, 46);
            this.txt_dealer.TabIndex = 2;
            // 
            // purch_date
            // 
            this.purch_date.AutoSize = true;
            this.purch_date.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purch_date.ForeColor = System.Drawing.Color.White;
            this.purch_date.Location = new System.Drawing.Point(405, 631);
            this.purch_date.Name = "purch_date";
            this.purch_date.Size = new System.Drawing.Size(192, 27);
            this.purch_date.TabIndex = 0;
            this.purch_date.Text = "Purchasing Date";
            // 
            // txt_purch_date
            // 
            this.txt_purch_date.BorderRadius = 3;
            this.txt_purch_date.BorderThickness = 2;
            this.txt_purch_date.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_purch_date.DefaultText = "";
            this.txt_purch_date.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_purch_date.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_purch_date.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_purch_date.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_purch_date.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_purch_date.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_purch_date.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_purch_date.Location = new System.Drawing.Point(768, 631);
            this.txt_purch_date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_purch_date.Name = "txt_purch_date";
            this.txt_purch_date.PasswordChar = '\0';
            this.txt_purch_date.PlaceholderText = "";
            this.txt_purch_date.SelectedText = "";
            this.txt_purch_date.Size = new System.Drawing.Size(258, 46);
            this.txt_purch_date.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.purchase);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(99)))), ((int)(((byte)(182)))));
            this.panel1.Location = new System.Drawing.Point(174, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 84);
            this.panel1.TabIndex = 3;
            // 
            // purchase
            // 
            this.purchase.AutoSize = true;
            this.purchase.Font = new System.Drawing.Font("Cascadia Mono", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.purchase.Location = new System.Drawing.Point(449, 14);
            this.purchase.Name = "purchase";
            this.purchase.Size = new System.Drawing.Size(198, 49);
            this.purchase.TabIndex = 0;
            this.purchase.Text = "Purchase";
            this.purchase.Click += new System.EventHandler(this.purchase_Click);
            // 
            // frm_purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_purch_date);
            this.Controls.Add(this.txt_dealer);
            this.Controls.Add(this.txt_item_purchPrice);
            this.Controls.Add(this.txt_itemQuantity);
            this.Controls.Add(this.txt_itemName);
            this.Controls.Add(this.txt_purchasingID);
            this.Controls.Add(this.purch_date);
            this.Controls.Add(this.dealer);
            this.Controls.Add(this.item_purchPrice);
            this.Controls.Add(this.item_quantity);
            this.Controls.Add(this.item_name);
            this.Controls.Add(this.label1);
            this.Name = "frm_purchase";
            this.Text = "frm_purchase";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_purchasingID;
        private System.Windows.Forms.Label item_name;
        private System.Windows.Forms.Label item_quantity;
        private System.Windows.Forms.Label item_purchPrice;
        private System.Windows.Forms.Label dealer;
        private Guna.UI2.WinForms.Guna2TextBox txt_itemName;
        private Guna.UI2.WinForms.Guna2TextBox txt_itemQuantity;
        private Guna.UI2.WinForms.Guna2TextBox txt_item_purchPrice;
        private Guna.UI2.WinForms.Guna2TextBox txt_dealer;
        private System.Windows.Forms.Label purch_date;
        private Guna.UI2.WinForms.Guna2TextBox txt_purch_date;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label purchase;
    }
}