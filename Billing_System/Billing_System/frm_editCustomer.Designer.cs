
namespace Billing_System
{
    partial class frm_editCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_update = new Guna.UI2.WinForms.Guna2Button();
            this.cmb_vehicleModel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_km = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_search = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel11 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_searchCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmb_fuelType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_chassisNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_registrationNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_customerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_customer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.BorderRadius = 10;
            this.btn_delete.BorderThickness = 1;
            this.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_delete.Font = new System.Drawing.Font("Cascadia Mono", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(223, 769);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(125, 62);
            this.btn_delete.TabIndex = 91;
            this.btn_delete.Text = "Delete";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BorderRadius = 10;
            this.btn_update.BorderThickness = 1;
            this.btn_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_update.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_update.Font = new System.Drawing.Font("Cascadia Mono", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(81, 769);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(120, 63);
            this.btn_update.TabIndex = 90;
            this.btn_update.Text = "Update";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // cmb_vehicleModel
            // 
            this.cmb_vehicleModel.BackColor = System.Drawing.Color.Transparent;
            this.cmb_vehicleModel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_vehicleModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_vehicleModel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_vehicleModel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_vehicleModel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_vehicleModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_vehicleModel.ItemHeight = 30;
            this.cmb_vehicleModel.Items.AddRange(new object[] {
            "Car",
            "Van",
            "Mini-Van",
            "Bike",
            "Lorry"});
            this.cmb_vehicleModel.Location = new System.Drawing.Point(83, 385);
            this.cmb_vehicleModel.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_vehicleModel.Name = "cmb_vehicleModel";
            this.cmb_vehicleModel.Size = new System.Drawing.Size(265, 36);
            this.cmb_vehicleModel.TabIndex = 89;
            // 
            // txt_km
            // 
            this.txt_km.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_km.DefaultText = "";
            this.txt_km.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_km.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_km.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_km.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_km.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_km.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_km.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_km.Location = new System.Drawing.Point(81, 704);
            this.txt_km.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_km.Name = "txt_km";
            this.txt_km.PasswordChar = '\0';
            this.txt_km.PlaceholderText = "";
            this.txt_km.SelectedText = "";
            this.txt_km.Size = new System.Drawing.Size(267, 39);
            this.txt_km.TabIndex = 88;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Cascadia Mono", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label11.Location = new System.Drawing.Point(1047, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(308, 50);
            this.label11.TabIndex = 17;
            this.label11.Text = "Edit Customer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-93, 679);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 27);
            this.label7.TabIndex = 87;
            this.label7.Text = "Km :";
            // 
            // btn_search
            // 
            this.btn_search.BackgroundImage = global::Billing_System.Properties.Resources.search;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.BorderColor = System.Drawing.Color.Transparent;
            this.btn_search.BorderRadius = 10;
            this.btn_search.BorderThickness = 1;
            this.btn_search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_search.FillColor = System.Drawing.Color.Empty;
            this.btn_search.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.Black;
            this.btn_search.Location = new System.Drawing.Point(1645, 28);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(54, 53);
            this.btn_search.TabIndex = 43;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // guna2Panel11
            // 
            this.guna2Panel11.BackColor = System.Drawing.Color.Black;
            this.guna2Panel11.Location = new System.Drawing.Point(430, 97);
            this.guna2Panel11.Name = "guna2Panel11";
            this.guna2Panel11.Size = new System.Drawing.Size(3, 800);
            this.guna2Panel11.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1369, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 27);
            this.label5.TabIndex = 42;
            this.label5.Text = "Search registration no :";
            // 
            // txt_searchCustomer
            // 
            this.txt_searchCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_searchCustomer.DefaultText = "";
            this.txt_searchCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_searchCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_searchCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_searchCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_searchCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_searchCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_searchCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_searchCustomer.Location = new System.Drawing.Point(1371, 35);
            this.txt_searchCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_searchCustomer.Name = "txt_searchCustomer";
            this.txt_searchCustomer.PasswordChar = '\0';
            this.txt_searchCustomer.PlaceholderText = "";
            this.txt_searchCustomer.SelectedText = "";
            this.txt_searchCustomer.Size = new System.Drawing.Size(265, 38);
            this.txt_searchCustomer.TabIndex = 41;
            // 
            // cmb_fuelType
            // 
            this.cmb_fuelType.BackColor = System.Drawing.Color.Transparent;
            this.cmb_fuelType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_fuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_fuelType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_fuelType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_fuelType.Font = new System.Drawing.Font("Cascadia Mono", 10.8F, System.Drawing.FontStyle.Bold);
            this.cmb_fuelType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_fuelType.ItemHeight = 30;
            this.cmb_fuelType.Items.AddRange(new object[] {
            "Petrol",
            "Deisel",
            "Hybrid"});
            this.cmb_fuelType.Location = new System.Drawing.Point(81, 608);
            this.cmb_fuelType.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_fuelType.Name = "cmb_fuelType";
            this.cmb_fuelType.Size = new System.Drawing.Size(265, 36);
            this.cmb_fuelType.TabIndex = 86;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(76, 556);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 27);
            this.label6.TabIndex = 85;
            this.label6.Text = "Fuel type :";
            // 
            // txt_chassisNo
            // 
            this.txt_chassisNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_chassisNo.DefaultText = "";
            this.txt_chassisNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_chassisNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_chassisNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_chassisNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_chassisNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_chassisNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_chassisNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_chassisNo.Location = new System.Drawing.Point(81, 492);
            this.txt_chassisNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_chassisNo.Name = "txt_chassisNo";
            this.txt_chassisNo.PasswordChar = '\0';
            this.txt_chassisNo.PlaceholderText = "";
            this.txt_chassisNo.SelectedText = "";
            this.txt_chassisNo.Size = new System.Drawing.Size(267, 39);
            this.txt_chassisNo.TabIndex = 82;
            // 
            // txt_registrationNo
            // 
            this.txt_registrationNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_registrationNo.DefaultText = "";
            this.txt_registrationNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_registrationNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_registrationNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_registrationNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_registrationNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_registrationNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_registrationNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_registrationNo.Location = new System.Drawing.Point(81, 265);
            this.txt_registrationNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_registrationNo.Name = "txt_registrationNo";
            this.txt_registrationNo.PasswordChar = '\0';
            this.txt_registrationNo.PlaceholderText = "";
            this.txt_registrationNo.SelectedText = "";
            this.txt_registrationNo.Size = new System.Drawing.Size(267, 39);
            this.txt_registrationNo.TabIndex = 83;
            // 
            // txt_customerName
            // 
            this.txt_customerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_customerName.DefaultText = "";
            this.txt_customerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_customerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_customerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_customerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_customerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_customerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_customerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_customerName.Location = new System.Drawing.Point(81, 150);
            this.txt_customerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.PasswordChar = '\0';
            this.txt_customerName.PlaceholderText = "";
            this.txt_customerName.ReadOnly = true;
            this.txt_customerName.SelectedText = "";
            this.txt_customerName.Size = new System.Drawing.Size(267, 39);
            this.txt_customerName.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(76, 444);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 27);
            this.label4.TabIndex = 78;
            this.label4.Text = "Chassis Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(76, 335);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 27);
            this.label3.TabIndex = 79;
            this.label3.Text = "Vehicle Model :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(76, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 27);
            this.label2.TabIndex = 80;
            this.label2.Text = "Registration Number :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 27);
            this.label1.TabIndex = 81;
            this.label1.Text = "Customer Name :";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.guna2GradientPanel1.Controls.Add(this.label5);
            this.guna2GradientPanel1.Controls.Add(this.txt_searchCustomer);
            this.guna2GradientPanel1.Controls.Add(this.btn_search);
            this.guna2GradientPanel1.Controls.Add(this.guna2Panel1);
            this.guna2GradientPanel1.Controls.Add(this.label11);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(-125, 2);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1828, 96);
            this.guna2GradientPanel1.TabIndex = 76;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Black;
            this.guna2Panel1.Location = new System.Drawing.Point(556, 92);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1435, 3);
            this.guna2Panel1.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(76, 659);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 27);
            this.label8.TabIndex = 92;
            this.label8.Text = "Km :";
            // 
            // dgv_customer
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_customer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_customer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_customer.ColumnHeadersHeight = 4;
            this.dgv_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_customer.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_customer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_customer.Location = new System.Drawing.Point(434, 97);
            this.dgv_customer.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_customer.Name = "dgv_customer";
            this.dgv_customer.RowHeadersVisible = false;
            this.dgv_customer.RowHeadersWidth = 51;
            this.dgv_customer.Size = new System.Drawing.Size(1147, 765);
            this.dgv_customer.TabIndex = 93;
            this.dgv_customer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_customer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_customer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_customer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_customer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_customer.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgv_customer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_customer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_customer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_customer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_customer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_customer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_customer.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_customer.ThemeStyle.ReadOnly = false;
            this.dgv_customer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_customer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_customer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_customer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_customer.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_customer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_customer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_customer_CellClick_1);
            // 
            // frm_editCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1582, 845);
            this.Controls.Add(this.dgv_customer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.cmb_vehicleModel);
            this.Controls.Add(this.txt_km);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.guna2Panel11);
            this.Controls.Add(this.cmb_fuelType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_chassisNo);
            this.Controls.Add(this.txt_registrationNo);
            this.Controls.Add(this.txt_customerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "frm_editCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_editCustomer";
            this.Load += new System.EventHandler(this.frm_editCustomer_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_delete;
        private Guna.UI2.WinForms.Guna2Button btn_update;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_vehicleModel;
        private Guna.UI2.WinForms.Guna2TextBox txt_km;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btn_search;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel11;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txt_searchCustomer;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_fuelType;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txt_chassisNo;
        private Guna.UI2.WinForms.Guna2TextBox txt_registrationNo;
        private Guna.UI2.WinForms.Guna2TextBox txt_customerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_customer;
    }
}