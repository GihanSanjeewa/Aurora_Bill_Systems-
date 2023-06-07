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
            this.lbl_invoice_page = new System.Windows.Forms.Label();
            this.guna2Panel11 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2Panel4.SuspendLayout();
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
            this.txt_vehicleNumber.Location = new System.Drawing.Point(46, 157);
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
            this.txt_vehicleModle.Size = new System.Drawing.Size(199, 29);
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
            this.txt_km.Location = new System.Drawing.Point(46, 327);
            this.txt_km.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_km.Name = "txt_km";
            this.txt_km.PasswordChar = '\0';
            this.txt_km.PlaceholderText = "";
            this.txt_km.SelectedText = "";
            this.txt_km.Size = new System.Drawing.Size(199, 29);
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
            this.txt_discount.Location = new System.Drawing.Point(296, 244);
            this.txt_discount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.PasswordChar = '\0';
            this.txt_discount.PlaceholderText = "";
            this.txt_discount.SelectedText = "";
            this.txt_discount.Size = new System.Drawing.Size(199, 29);
            this.txt_discount.TabIndex = 8;
            this.txt_discount.Validating += new System.ComponentModel.CancelEventHandler(this.txt_discount_Validating);
            // 
            // lbl_vehicle_number
            // 
            this.lbl_vehicle_number.AutoSize = true;
            this.lbl_vehicle_number.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vehicle_number.ForeColor = System.Drawing.Color.White;
            this.lbl_vehicle_number.Location = new System.Drawing.Point(44, 126);
            this.lbl_vehicle_number.Name = "lbl_vehicle_number";
            this.lbl_vehicle_number.Size = new System.Drawing.Size(136, 21);
            this.lbl_vehicle_number.TabIndex = 11;
            this.lbl_vehicle_number.Text = "Vehicle Number";
            // 
            // lbl_vehicle_model
            // 
            this.lbl_vehicle_model.AutoSize = true;
            this.lbl_vehicle_model.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vehicle_model.ForeColor = System.Drawing.Color.White;
            this.lbl_vehicle_model.Location = new System.Drawing.Point(44, 213);
            this.lbl_vehicle_model.Name = "lbl_vehicle_model";
            this.lbl_vehicle_model.Size = new System.Drawing.Size(127, 21);
            this.lbl_vehicle_model.TabIndex = 12;
            this.lbl_vehicle_model.Text = "Vehicle Model";
            // 
            // lbl_fuel
            // 
            this.lbl_fuel.AutoSize = true;
            this.lbl_fuel.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fuel.ForeColor = System.Drawing.Color.White;
            this.lbl_fuel.Location = new System.Drawing.Point(293, 128);
            this.lbl_fuel.Name = "lbl_fuel";
            this.lbl_fuel.Size = new System.Drawing.Size(46, 21);
            this.lbl_fuel.TabIndex = 13;
            this.lbl_fuel.Text = "Fuel";
            // 
            // lbl_km
            // 
            this.lbl_km.AutoSize = true;
            this.lbl_km.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_km.ForeColor = System.Drawing.Color.White;
            this.lbl_km.Location = new System.Drawing.Point(43, 297);
            this.lbl_km.Name = "lbl_km";
            this.lbl_km.Size = new System.Drawing.Size(28, 21);
            this.lbl_km.TabIndex = 14;
            this.lbl_km.Text = "KM";
            // 
            // lbl_name_of_the_machanic
            // 
            this.lbl_name_of_the_machanic.AutoSize = true;
            this.lbl_name_of_the_machanic.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_of_the_machanic.Location = new System.Drawing.Point(-258, 495);
            this.lbl_name_of_the_machanic.Name = "lbl_name_of_the_machanic";
            this.lbl_name_of_the_machanic.Size = new System.Drawing.Size(190, 21);
            this.lbl_name_of_the_machanic.TabIndex = 15;
            this.lbl_name_of_the_machanic.Text = "Name of the Machanic";
            // 
            // lbl_job
            // 
            this.lbl_job.AutoSize = true;
            this.lbl_job.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_job.ForeColor = System.Drawing.Color.White;
            this.lbl_job.Location = new System.Drawing.Point(44, 389);
            this.lbl_job.Name = "lbl_job";
            this.lbl_job.Size = new System.Drawing.Size(37, 21);
            this.lbl_job.TabIndex = 16;
            this.lbl_job.Text = "JOB";
            // 
            // lbl_discount
            // 
            this.lbl_discount.AutoSize = true;
            this.lbl_discount.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_discount.ForeColor = System.Drawing.Color.White;
            this.lbl_discount.Location = new System.Drawing.Point(293, 213);
            this.lbl_discount.Name = "lbl_discount";
            this.lbl_discount.Size = new System.Drawing.Size(82, 21);
            this.lbl_discount.TabIndex = 17;
            this.lbl_discount.Text = "Discount";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_date.ForeColor = System.Drawing.Color.White;
            this.lbl_date.Location = new System.Drawing.Point(294, 329);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(82, 21);
            this.lbl_date.TabIndex = 19;
            this.lbl_date.Text = "********";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_price.ForeColor = System.Drawing.Color.White;
            this.lbl_price.Location = new System.Drawing.Point(292, 434);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(82, 21);
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
            this.drp_fuelType.Location = new System.Drawing.Point(296, 165);
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
            this.drp_job.Items.AddRange(new object[] {
            "Auto Diesel",
            "Super Diesel",
            "Petrol 92",
            "Petrol 95"});
            this.drp_job.Location = new System.Drawing.Point(48, 434);
            this.drp_job.Name = "drp_job";
            this.drp_job.Size = new System.Drawing.Size(198, 23);
            this.drp_job.TabIndex = 23;
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
            this.btn_process.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_process.ForeColor = System.Drawing.Color.Black;
            this.btn_process.Location = new System.Drawing.Point(162, 537);
            this.btn_process.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_process.Name = "btn_process";
            this.btn_process.Size = new System.Drawing.Size(198, 84);
            this.btn_process.TabIndex = 25;
            this.btn_process.Text = "Process";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.guna2Panel4.Controls.Add(this.lbl_invoice_page);
            this.guna2Panel4.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(1584, 73);
            this.guna2Panel4.TabIndex = 26;
            // 
            // lbl_invoice_page
            // 
            this.lbl_invoice_page.AutoSize = true;
            this.lbl_invoice_page.Font = new System.Drawing.Font("Cascadia Mono", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_invoice_page.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lbl_invoice_page.Location = new System.Drawing.Point(525, 12);
            this.lbl_invoice_page.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_invoice_page.Name = "lbl_invoice_page";
            this.lbl_invoice_page.Size = new System.Drawing.Size(143, 40);
            this.lbl_invoice_page.TabIndex = 16;
            this.lbl_invoice_page.Text = "Invoice";
            // 
            // guna2Panel11
            // 
            this.guna2Panel11.BackColor = System.Drawing.Color.LightGray;
            this.guna2Panel11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.guna2Panel11.Location = new System.Drawing.Point(533, 72);
            this.guna2Panel11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel11.Name = "guna2Panel11";
            this.guna2Panel11.Size = new System.Drawing.Size(679, 634);
            this.guna2Panel11.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(294, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 21);
            this.label1.TabIndex = 37;
            this.label1.Text = "Price Before discount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(292, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "Date";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1186, 693);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel11);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.btn_process);
            this.Controls.Add(this.drp_job);
            this.Controls.Add(this.drp_machanicNam);
            this.Controls.Add(this.drp_fuelType);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_date);
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
    }
}