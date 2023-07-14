namespace Billing_System
{
    partial class frm_invoice
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
            this.txt_vehicleNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_vehicleModle = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_km = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_discount = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_vehicle_number = new System.Windows.Forms.Label();
            this.lbl_vehicle_model = new System.Windows.Forms.Label();
            this.lbl_fuel = new System.Windows.Forms.Label();
            this.lbl_km = new System.Windows.Forms.Label();
            this.lbl_name_of_the_machanic = new System.Windows.Forms.Label();
            this.lbl_job = new System.Windows.Forms.Label();
            this.lbl_discount = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.drp_fuelType = new System.Windows.Forms.ComboBox();
            this.drp_machanicNam = new System.Windows.Forms.ComboBox();
            this.drp_job = new System.Windows.Forms.ComboBox();
            this.btn_process = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_invoice_page = new System.Windows.Forms.Label();
            this.guna2Panel11 = new Guna.UI2.WinForms.Guna2Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_Bkm = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.btn_search = new Guna.UI2.WinForms.Guna2Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_vehicleNumber
            // 
            this.txt_vehicleNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_vehicleNumber.DefaultText = "";
            this.txt_vehicleNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_vehicleNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_vehicleNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_vehicleNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_vehicleNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_vehicleNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_vehicleNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_vehicleNumber.Location = new System.Drawing.Point(48, 119);
            this.txt_vehicleNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_vehicleNumber.Name = "txt_vehicleNumber";
            this.txt_vehicleNumber.PasswordChar = '\0';
            this.txt_vehicleNumber.PlaceholderText = "";
            this.txt_vehicleNumber.SelectedText = "";
            this.txt_vehicleNumber.Size = new System.Drawing.Size(199, 29);
            this.txt_vehicleNumber.TabIndex = 2;
            this.txt_vehicleNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txt_vehicleNumber_Validating);
            // 
            // txt_vehicleModle
            // 
            this.txt_vehicleModle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_vehicleModle.DefaultText = "";
            this.txt_vehicleModle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_vehicleModle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_vehicleModle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_vehicleModle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_vehicleModle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_vehicleModle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_vehicleModle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_vehicleModle.Location = new System.Drawing.Point(46, 244);
            this.txt_vehicleModle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_vehicleModle.Name = "txt_vehicleModle";
            this.txt_vehicleModle.PasswordChar = '\0';
            this.txt_vehicleModle.PlaceholderText = "";
            this.txt_vehicleModle.SelectedText = "";
            this.txt_vehicleModle.Size = new System.Drawing.Size(199, 23);
            this.txt_vehicleModle.TabIndex = 3;
            this.txt_vehicleModle.Validating += new System.ComponentModel.CancelEventHandler(this.txt_vehicleModle_Validating);
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
            this.txt_km.Location = new System.Drawing.Point(47, 321);
            this.txt_km.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_km.Name = "txt_km";
            this.txt_km.PasswordChar = '\0';
            this.txt_km.PlaceholderText = "";
            this.txt_km.SelectedText = "";
            this.txt_km.Size = new System.Drawing.Size(199, 23);
            this.txt_km.TabIndex = 5;
            this.txt_km.Validating += new System.ComponentModel.CancelEventHandler(this.txt_km_Validating);
            // 
            // txt_discount
            // 
            this.txt_discount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_discount.DefaultText = "";
            this.txt_discount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_discount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_discount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_discount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_discount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_discount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_discount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_discount.Location = new System.Drawing.Point(291, 404);
            this.txt_discount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.PasswordChar = '\0';
            this.txt_discount.PlaceholderText = "";
            this.txt_discount.SelectedText = "";
            this.txt_discount.Size = new System.Drawing.Size(201, 23);
            this.txt_discount.TabIndex = 8;
            this.txt_discount.TextChanged += new System.EventHandler(this.txt_discount_TextChanged);
            // 
            // lbl_vehicle_number
            // 
            this.lbl_vehicle_number.AutoSize = true;
            this.lbl_vehicle_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vehicle_number.ForeColor = System.Drawing.Color.White;
            this.lbl_vehicle_number.Location = new System.Drawing.Point(46, 88);
            this.lbl_vehicle_number.Name = "lbl_vehicle_number";
            this.lbl_vehicle_number.Size = new System.Drawing.Size(135, 20);
            this.lbl_vehicle_number.TabIndex = 11;
            this.lbl_vehicle_number.Text = "Vehicle Number";
            // 
            // lbl_vehicle_model
            // 
            this.lbl_vehicle_model.AutoSize = true;
            this.lbl_vehicle_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vehicle_model.ForeColor = System.Drawing.Color.White;
            this.lbl_vehicle_model.Location = new System.Drawing.Point(44, 213);
            this.lbl_vehicle_model.Name = "lbl_vehicle_model";
            this.lbl_vehicle_model.Size = new System.Drawing.Size(121, 20);
            this.lbl_vehicle_model.TabIndex = 12;
            this.lbl_vehicle_model.Text = "Vehicle Model";
            // 
            // lbl_fuel
            // 
            this.lbl_fuel.AutoSize = true;
            this.lbl_fuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fuel.ForeColor = System.Drawing.Color.White;
            this.lbl_fuel.Location = new System.Drawing.Point(290, 212);
            this.lbl_fuel.Name = "lbl_fuel";
            this.lbl_fuel.Size = new System.Drawing.Size(44, 20);
            this.lbl_fuel.TabIndex = 13;
            this.lbl_fuel.Text = "Fuel";
            // 
            // lbl_km
            // 
            this.lbl_km.AutoSize = true;
            this.lbl_km.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_km.ForeColor = System.Drawing.Color.White;
            this.lbl_km.Location = new System.Drawing.Point(44, 291);
            this.lbl_km.Name = "lbl_km";
            this.lbl_km.Size = new System.Drawing.Size(34, 20);
            this.lbl_km.TabIndex = 14;
            this.lbl_km.Text = "KM";
            // 
            // lbl_name_of_the_machanic
            // 
            this.lbl_name_of_the_machanic.AutoSize = true;
            this.lbl_name_of_the_machanic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_of_the_machanic.Location = new System.Drawing.Point(-258, 495);
            this.lbl_name_of_the_machanic.Name = "lbl_name_of_the_machanic";
            this.lbl_name_of_the_machanic.Size = new System.Drawing.Size(188, 20);
            this.lbl_name_of_the_machanic.TabIndex = 15;
            this.lbl_name_of_the_machanic.Text = "Name of the Machanic";
            // 
            // lbl_job
            // 
            this.lbl_job.AutoSize = true;
            this.lbl_job.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_job.ForeColor = System.Drawing.Color.White;
            this.lbl_job.Location = new System.Drawing.Point(289, 289);
            this.lbl_job.Name = "lbl_job";
            this.lbl_job.Size = new System.Drawing.Size(43, 20);
            this.lbl_job.TabIndex = 16;
            this.lbl_job.Text = "JOB";
            // 
            // lbl_discount
            // 
            this.lbl_discount.AutoSize = true;
            this.lbl_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_discount.ForeColor = System.Drawing.Color.White;
            this.lbl_discount.Location = new System.Drawing.Point(289, 375);
            this.lbl_discount.Name = "lbl_discount";
            this.lbl_discount.Size = new System.Drawing.Size(80, 20);
            this.lbl_discount.TabIndex = 17;
            this.lbl_discount.Text = "Discount";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_date.ForeColor = System.Drawing.Color.White;
            this.lbl_date.Location = new System.Drawing.Point(1012, 25);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(65, 20);
            this.lbl_date.TabIndex = 19;
            this.lbl_date.Text = "********";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_price.ForeColor = System.Drawing.Color.White;
            this.lbl_price.Location = new System.Drawing.Point(225, 501);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(65, 20);
            this.lbl_price.TabIndex = 20;
            this.lbl_price.Text = "********";
            // 
            // drp_fuelType
            // 
            this.drp_fuelType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.drp_fuelType.FormattingEnabled = true;
            this.drp_fuelType.Items.AddRange(new object[] {
            "Auto Diesel",
            "Super Diesel",
            "Petrol 92",
            "Petrol 95"});
            this.drp_fuelType.Location = new System.Drawing.Point(291, 244);
            this.drp_fuelType.Name = "drp_fuelType";
            this.drp_fuelType.Size = new System.Drawing.Size(199, 23);
            this.drp_fuelType.TabIndex = 21;
            this.drp_fuelType.Validating += new System.ComponentModel.CancelEventHandler(this.drp_fuelType_Validating);
            // 
            // drp_machanicNam
            // 
            this.drp_machanicNam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.drp_machanicNam.FormattingEnabled = true;
            this.drp_machanicNam.Items.AddRange(new object[] {
            "Auto Diesel",
            "Super Diesel",
            "Petrol 92",
            "Petrol 95"});
            this.drp_machanicNam.Location = new System.Drawing.Point(-255, 533);
            this.drp_machanicNam.Name = "drp_machanicNam";
            this.drp_machanicNam.Size = new System.Drawing.Size(199, 23);
            this.drp_machanicNam.TabIndex = 22;
            // 
            // drp_job
            // 
            this.drp_job.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.drp_job.FormattingEnabled = true;
            this.drp_job.Location = new System.Drawing.Point(291, 322);
            this.drp_job.Name = "drp_job";
            this.drp_job.Size = new System.Drawing.Size(198, 23);
            this.drp_job.TabIndex = 23;
            this.drp_job.DropDown += new System.EventHandler(this.drp_job_DropDown);
            this.drp_job.Validating += new System.ComponentModel.CancelEventHandler(this.drp_job_Validating);
            // 
            // btn_process
            // 
            this.btn_process.BorderRadius = 10;
            this.btn_process.BorderThickness = 2;
            this.btn_process.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_process.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_process.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_process.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_process.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_process.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_process.ForeColor = System.Drawing.Color.Black;
            this.btn_process.Location = new System.Drawing.Point(161, 585);
            this.btn_process.Margin = new System.Windows.Forms.Padding(2);
            this.btn_process.Name = "btn_process";
            this.btn_process.Size = new System.Drawing.Size(171, 63);
            this.btn_process.TabIndex = 25;
            this.btn_process.Text = "Process";
            this.btn_process.Click += new System.EventHandler(this.btn_process_Click);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.guna2Panel4.Controls.Add(this.label2);
            this.guna2Panel4.Controls.Add(this.lbl_invoice_page);
            this.guna2Panel4.Controls.Add(this.lbl_date);
            this.guna2Panel4.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(1584, 73);
            this.guna2Panel4.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1105, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Date";
            // 
            // lbl_invoice_page
            // 
            this.lbl_invoice_page.AutoSize = true;
            this.lbl_invoice_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_invoice_page.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lbl_invoice_page.Location = new System.Drawing.Point(525, 12);
            this.lbl_invoice_page.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_invoice_page.Name = "lbl_invoice_page";
            this.lbl_invoice_page.Size = new System.Drawing.Size(117, 36);
            this.lbl_invoice_page.TabIndex = 16;
            this.lbl_invoice_page.Text = "Invoice";
            // 
            // guna2Panel11
            // 
            this.guna2Panel11.BackColor = System.Drawing.Color.Black;
            this.guna2Panel11.Controls.Add(this.label11);
            this.guna2Panel11.Controls.Add(this.label10);
            this.guna2Panel11.Controls.Add(this.label9);
            this.guna2Panel11.Controls.Add(this.label8);
            this.guna2Panel11.Controls.Add(this.label7);
            this.guna2Panel11.Controls.Add(this.lbl_Bkm);
            this.guna2Panel11.Controls.Add(this.label6);
            this.guna2Panel11.Controls.Add(this.label5);
            this.guna2Panel11.Controls.Add(this.label4);
            this.guna2Panel11.Controls.Add(this.label3);
            this.guna2Panel11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.guna2Panel11.Location = new System.Drawing.Point(533, 72);
            this.guna2Panel11.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel11.Name = "guna2Panel11";
            this.guna2Panel11.Size = new System.Drawing.Size(679, 634);
            this.guna2Panel11.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(74, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Job 5 -";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(74, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Job 4 -";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(74, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Job 3 -";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(74, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Job 2 -";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(74, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Job 1 -";
            // 
            // lbl_Bkm
            // 
            this.lbl_Bkm.AutoSize = true;
            this.lbl_Bkm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lbl_Bkm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bkm.ForeColor = System.Drawing.Color.White;
            this.lbl_Bkm.Location = new System.Drawing.Point(542, 79);
            this.lbl_Bkm.Name = "lbl_Bkm";
            this.lbl_Bkm.Size = new System.Drawing.Size(34, 20);
            this.lbl_Bkm.TabIndex = 11;
            this.lbl_Bkm.Text = "KM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(542, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "KM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(443, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fuel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(277, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Vehicle Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(63, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Vehicle Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(108, 496);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "New Price  :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_add
            // 
            this.btn_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(308, 495);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(68, 29);
            this.btn_add.TabIndex = 38;
            this.btn_add.Text = "Add";
            // 
            // btn_search
            // 
            this.btn_search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(291, 119);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(68, 29);
            this.btn_search.TabIndex = 39;
            this.btn_search.Text = "Search";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(46, 376);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 20);
            this.label12.TabIndex = 41;
            this.label12.Text = "Price";
            // 
            // txt_price
            // 
            this.txt_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_price.DefaultText = "";
            this.txt_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_price.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_price.Location = new System.Drawing.Point(48, 404);
            this.txt_price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_price.Name = "txt_price";
            this.txt_price.PasswordChar = '\0';
            this.txt_price.PlaceholderText = "";
            this.txt_price.SelectedText = "";
            this.txt_price.Size = new System.Drawing.Size(201, 23);
            this.txt_price.TabIndex = 40;
            // 
            // frm_invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1186, 693);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel11);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.btn_process);
            this.Controls.Add(this.drp_job);
            this.Controls.Add(this.drp_machanicNam);
            this.Controls.Add(this.drp_fuelType);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_discount);
            this.Controls.Add(this.lbl_job);
            this.Controls.Add(this.lbl_name_of_the_machanic);
            this.Controls.Add(this.lbl_km);
            this.Controls.Add(this.lbl_fuel);
            this.Controls.Add(this.lbl_vehicle_model);
            this.Controls.Add(this.lbl_vehicle_number);
            this.Controls.Add(this.txt_discount);
            this.Controls.Add(this.txt_km);
            this.Controls.Add(this.txt_vehicleModle);
            this.Controls.Add(this.txt_vehicleNumber);
            this.Name = "frm_invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_invoice";
            this.Load += new System.EventHandler(this.frm_invoice_Load);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel11.ResumeLayout(false);
            this.guna2Panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txt_vehicleNumber;
        private Guna.UI2.WinForms.Guna2TextBox txt_vehicleModle;
        private Guna.UI2.WinForms.Guna2TextBox txt_km;
        private Guna.UI2.WinForms.Guna2TextBox txt_discount;
        private System.Windows.Forms.Label lbl_vehicle_number;
        private System.Windows.Forms.Label lbl_vehicle_model;
        private System.Windows.Forms.Label lbl_fuel;
        private System.Windows.Forms.Label lbl_km;
        private System.Windows.Forms.Label lbl_name_of_the_machanic;
        private System.Windows.Forms.Label lbl_job;
        private System.Windows.Forms.Label lbl_discount;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.ComboBox drp_fuelType;
        private System.Windows.Forms.ComboBox drp_machanicNam;
        private System.Windows.Forms.ComboBox drp_job;
        private Guna.UI2.WinForms.Guna2Button btn_process;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label lbl_invoice_page;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2Button btn_search;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_Bkm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txt_price;
    }
}