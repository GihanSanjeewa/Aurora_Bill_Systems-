
namespace Billing_System
{
    partial class frm_addCustomer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_customer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_addCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.txt_chassisNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_registrationNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_customerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel11 = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_fuelType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_km = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_vehicleModel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_editCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_phoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_company = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_address = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_customer
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_customer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_customer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_customer.ColumnHeadersHeight = 4;
            this.dgv_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_customer.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_customer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_customer.Location = new System.Drawing.Point(373, 89);
            this.dgv_customer.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_customer.Name = "dgv_customer";
            this.dgv_customer.RowHeadersVisible = false;
            this.dgv_customer.RowHeadersWidth = 51;
            this.dgv_customer.Size = new System.Drawing.Size(1209, 766);
            this.dgv_customer.TabIndex = 45;
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
            // 
            // btn_addCustomer
            // 
            this.btn_addCustomer.BorderRadius = 10;
            this.btn_addCustomer.BorderThickness = 1;
            this.btn_addCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_addCustomer.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addCustomer.ForeColor = System.Drawing.Color.White;
            this.btn_addCustomer.Location = new System.Drawing.Point(47, 763);
            this.btn_addCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addCustomer.Name = "btn_addCustomer";
            this.btn_addCustomer.Size = new System.Drawing.Size(267, 70);
            this.btn_addCustomer.TabIndex = 44;
            this.btn_addCustomer.Text = "Add Customer";
            this.btn_addCustomer.Click += new System.EventHandler(this.btn_addCustomer_Click);
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
            this.txt_chassisNo.Location = new System.Drawing.Point(47, 289);
            this.txt_chassisNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_chassisNo.Name = "txt_chassisNo";
            this.txt_chassisNo.PasswordChar = '\0';
            this.txt_chassisNo.PlaceholderText = "";
            this.txt_chassisNo.SelectedText = "";
            this.txt_chassisNo.Size = new System.Drawing.Size(267, 39);
            this.txt_chassisNo.TabIndex = 40;
            this.txt_chassisNo.Validating += new System.ComponentModel.CancelEventHandler(this.txt_chassisNo_Validating);
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
            this.txt_registrationNo.Location = new System.Drawing.Point(47, 123);
            this.txt_registrationNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_registrationNo.Name = "txt_registrationNo";
            this.txt_registrationNo.PasswordChar = '\0';
            this.txt_registrationNo.PlaceholderText = "";
            this.txt_registrationNo.SelectedText = "";
            this.txt_registrationNo.Size = new System.Drawing.Size(267, 39);
            this.txt_registrationNo.TabIndex = 42;
            this.txt_registrationNo.Validating += new System.ComponentModel.CancelEventHandler(this.txt_registrationNo_Validating);
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
            this.txt_customerName.Location = new System.Drawing.Point(47, 41);
            this.txt_customerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.PasswordChar = '\0';
            this.txt_customerName.PlaceholderText = "";
            this.txt_customerName.SelectedText = "";
            this.txt_customerName.Size = new System.Drawing.Size(267, 39);
            this.txt_customerName.TabIndex = 43;
            this.txt_customerName.Validating += new System.ComponentModel.CancelEventHandler(this.txt_customerName_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(43, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 27);
            this.label4.TabIndex = 36;
            this.label4.Text = "Chassis Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 27);
            this.label3.TabIndex = 37;
            this.label3.Text = "Vehicle Model :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 27);
            this.label2.TabIndex = 38;
            this.label2.Text = "Registration Number :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 27);
            this.label1.TabIndex = 39;
            this.label1.Text = "Customer Name :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Cascadia Mono", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label11.Location = new System.Drawing.Point(467, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(286, 50);
            this.label11.TabIndex = 17;
            this.label11.Text = "Add Customer";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.guna2GradientPanel1.Controls.Add(this.guna2Panel1);
            this.guna2GradientPanel1.Controls.Add(this.label11);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(373, -1);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1469, 90);
            this.guna2GradientPanel1.TabIndex = 46;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Black;
            this.guna2Panel1.Location = new System.Drawing.Point(556, 87);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1435, 2);
            this.guna2Panel1.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(315, 814);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 27);
            this.label5.TabIndex = 49;
            this.label5.Text = "Edit ";
            // 
            // guna2Panel11
            // 
            this.guna2Panel11.BackColor = System.Drawing.Color.Black;
            this.guna2Panel11.Location = new System.Drawing.Point(433, 90);
            this.guna2Panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel11.Name = "guna2Panel11";
            this.guna2Panel11.Size = new System.Drawing.Size(3, 753);
            this.guna2Panel11.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(43, 338);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 27);
            this.label6.TabIndex = 50;
            this.label6.Text = "Fuel type :";
            // 
            // cmb_fuelType
            // 
            this.cmb_fuelType.BackColor = System.Drawing.Color.Transparent;
            this.cmb_fuelType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_fuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_fuelType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_fuelType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_fuelType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_fuelType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_fuelType.ItemHeight = 30;
            this.cmb_fuelType.Items.AddRange(new object[] {
            "Petrol",
            "Deisel",
            "Hybrid"});
            this.cmb_fuelType.Location = new System.Drawing.Point(47, 377);
            this.cmb_fuelType.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_fuelType.Name = "cmb_fuelType";
            this.cmb_fuelType.Size = new System.Drawing.Size(265, 36);
            this.cmb_fuelType.TabIndex = 51;
            this.cmb_fuelType.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_fuelType_Validating);
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
            this.txt_km.Location = new System.Drawing.Point(47, 458);
            this.txt_km.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_km.Name = "txt_km";
            this.txt_km.PasswordChar = '\0';
            this.txt_km.PlaceholderText = "";
            this.txt_km.SelectedText = "";
            this.txt_km.Size = new System.Drawing.Size(267, 39);
            this.txt_km.TabIndex = 53;
            this.txt_km.Validating += new System.ComponentModel.CancelEventHandler(this.txt_km_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(44, 423);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 27);
            this.label7.TabIndex = 52;
            this.label7.Text = "Km :";
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
            this.cmb_vehicleModel.Location = new System.Drawing.Point(49, 208);
            this.cmb_vehicleModel.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_vehicleModel.Name = "cmb_vehicleModel";
            this.cmb_vehicleModel.Size = new System.Drawing.Size(265, 36);
            this.cmb_vehicleModel.TabIndex = 54;
            this.cmb_vehicleModel.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_vehicleModel_Validating);
            // 
            // btn_editCustomer
            // 
            this.btn_editCustomer.BackgroundImage = global::Billing_System.Properties.Resources.settings;
            this.btn_editCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_editCustomer.BorderColor = System.Drawing.Color.Transparent;
            this.btn_editCustomer.BorderRadius = 10;
            this.btn_editCustomer.BorderThickness = 2;
            this.btn_editCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_editCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_editCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_editCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_editCustomer.FillColor = System.Drawing.Color.Transparent;
            this.btn_editCustomer.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold);
            this.btn_editCustomer.ForeColor = System.Drawing.Color.White;
            this.btn_editCustomer.Location = new System.Drawing.Point(317, 763);
            this.btn_editCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_editCustomer.Name = "btn_editCustomer";
            this.btn_editCustomer.Padding = new System.Windows.Forms.Padding(5);
            this.btn_editCustomer.Size = new System.Drawing.Size(53, 50);
            this.btn_editCustomer.TabIndex = 48;
            this.btn_editCustomer.Click += new System.EventHandler(this.btn_editCustomer_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(47, 671);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(180, 27);
            this.label12.TabIndex = 96;
            this.label12.Text = "Phone Number :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(47, 586);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 27);
            this.label10.TabIndex = 97;
            this.label10.Text = "Company :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(45, 503);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 27);
            this.label9.TabIndex = 98;
            this.label9.Text = "Address :";
            // 
            // txt_phoneNumber
            // 
            this.txt_phoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_phoneNumber.DefaultText = "";
            this.txt_phoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_phoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_phoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_phoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_phoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_phoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_phoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_phoneNumber.Location = new System.Drawing.Point(51, 709);
            this.txt_phoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_phoneNumber.Name = "txt_phoneNumber";
            this.txt_phoneNumber.PasswordChar = '\0';
            this.txt_phoneNumber.PlaceholderText = "";
            this.txt_phoneNumber.SelectedText = "";
            this.txt_phoneNumber.Size = new System.Drawing.Size(267, 39);
            this.txt_phoneNumber.TabIndex = 93;
            this.txt_phoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txt_phoneNumber_Validating);
            // 
            // txt_company
            // 
            this.txt_company.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_company.DefaultText = "";
            this.txt_company.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_company.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_company.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_company.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_company.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_company.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_company.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_company.Location = new System.Drawing.Point(52, 624);
            this.txt_company.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_company.Name = "txt_company";
            this.txt_company.PasswordChar = '\0';
            this.txt_company.PlaceholderText = "";
            this.txt_company.SelectedText = "";
            this.txt_company.Size = new System.Drawing.Size(267, 39);
            this.txt_company.TabIndex = 94;
            this.txt_company.Validating += new System.ComponentModel.CancelEventHandler(this.txt_company_Validating);
            // 
            // txt_address
            // 
            this.txt_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_address.DefaultText = "";
            this.txt_address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_address.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_address.Location = new System.Drawing.Point(51, 542);
            this.txt_address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_address.Name = "txt_address";
            this.txt_address.PasswordChar = '\0';
            this.txt_address.PlaceholderText = "";
            this.txt_address.SelectedText = "";
            this.txt_address.Size = new System.Drawing.Size(267, 39);
            this.txt_address.TabIndex = 95;
            this.txt_address.Validating += new System.ComponentModel.CancelEventHandler(this.txt_address_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_addCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_phoneNumber);
            this.Controls.Add(this.txt_company);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.cmb_vehicleModel);
            this.Controls.Add(this.txt_km);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_fuelType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_customer);
            this.Controls.Add(this.btn_addCustomer);
            this.Controls.Add(this.txt_chassisNo);
            this.Controls.Add(this.txt_registrationNo);
            this.Controls.Add(this.txt_customerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_editCustomer);
            this.Controls.Add(this.guna2Panel11);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_addCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_addCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgv_customer;
        private Guna.UI2.WinForms.Guna2Button btn_addCustomer;
        private Guna.UI2.WinForms.Guna2TextBox txt_chassisNo;
        private Guna.UI2.WinForms.Guna2TextBox txt_registrationNo;
        private Guna.UI2.WinForms.Guna2TextBox txt_customerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btn_editCustomer;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel11;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_fuelType;
        private Guna.UI2.WinForms.Guna2TextBox txt_km;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_vehicleModel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txt_phoneNumber;
        private Guna.UI2.WinForms.Guna2TextBox txt_company;
        private Guna.UI2.WinForms.Guna2TextBox txt_address;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}