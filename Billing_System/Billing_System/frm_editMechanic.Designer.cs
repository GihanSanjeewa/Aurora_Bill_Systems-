
namespace Billing_System
{
    partial class frm_editMechanic
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
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_searchMechanic = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.dgv_mechanic = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txt_mId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_profession = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_mName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_update = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel11 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_search = new Guna.UI2.WinForms.Guna2Button();
            this.txt_cNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mechanic)).BeginInit();
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
            this.btn_delete.Font = new System.Drawing.Font("Cascadia Mono", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(226, 648);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(125, 58);
            this.btn_delete.TabIndex = 75;
            this.btn_delete.Text = "Delete";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.guna2GradientPanel1.Controls.Add(this.label5);
            this.guna2GradientPanel1.Controls.Add(this.txt_searchMechanic);
            this.guna2GradientPanel1.Controls.Add(this.btn_search);
            this.guna2GradientPanel1.Controls.Add(this.guna2Panel1);
            this.guna2GradientPanel1.Controls.Add(this.label11);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(-123, -1);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1828, 90);
            this.guna2GradientPanel1.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(202, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 27);
            this.label5.TabIndex = 42;
            this.label5.Text = "Search Mechanic :";
            // 
            // txt_searchMechanic
            // 
            this.txt_searchMechanic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_searchMechanic.DefaultText = "";
            this.txt_searchMechanic.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_searchMechanic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_searchMechanic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_searchMechanic.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_searchMechanic.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_searchMechanic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_searchMechanic.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_searchMechanic.Location = new System.Drawing.Point(207, 36);
            this.txt_searchMechanic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_searchMechanic.Name = "txt_searchMechanic";
            this.txt_searchMechanic.PasswordChar = '\0';
            this.txt_searchMechanic.PlaceholderText = "";
            this.txt_searchMechanic.SelectedText = "";
            this.txt_searchMechanic.Size = new System.Drawing.Size(265, 36);
            this.txt_searchMechanic.TabIndex = 41;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Black;
            this.guna2Panel1.Location = new System.Drawing.Point(556, 87);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1435, 3);
            this.guna2Panel1.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Cascadia Mono", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label11.Location = new System.Drawing.Point(1047, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(308, 50);
            this.label11.TabIndex = 17;
            this.label11.Text = "Edit Mechanic";
            // 
            // dgv_mechanic
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_mechanic.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_mechanic.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_mechanic.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_mechanic.ColumnHeadersHeight = 4;
            this.dgv_mechanic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_mechanic.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_mechanic.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_mechanic.Location = new System.Drawing.Point(435, 89);
            this.dgv_mechanic.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_mechanic.Name = "dgv_mechanic";
            this.dgv_mechanic.RowHeadersVisible = false;
            this.dgv_mechanic.RowHeadersWidth = 51;
            this.dgv_mechanic.Size = new System.Drawing.Size(1103, 765);
            this.dgv_mechanic.TabIndex = 72;
            this.dgv_mechanic.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_mechanic.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_mechanic.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_mechanic.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_mechanic.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_mechanic.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgv_mechanic.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_mechanic.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_mechanic.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_mechanic.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_mechanic.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_mechanic.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_mechanic.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_mechanic.ThemeStyle.ReadOnly = false;
            this.dgv_mechanic.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_mechanic.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_mechanic.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_mechanic.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_mechanic.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_mechanic.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_mechanic.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_mechanic.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_mechanic_CellClick);
            // 
            // txt_mId
            // 
            this.txt_mId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mId.DefaultText = "";
            this.txt_mId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_mId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_mId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_mId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_mId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_mId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mId.Location = new System.Drawing.Point(84, 154);
            this.txt_mId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_mId.Name = "txt_mId";
            this.txt_mId.PasswordChar = '\0';
            this.txt_mId.PlaceholderText = "";
            this.txt_mId.SelectedText = "";
            this.txt_mId.Size = new System.Drawing.Size(267, 44);
            this.txt_mId.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 27);
            this.label1.TabIndex = 80;
            this.label1.Text = "Mechanic ID :";
            // 
            // txt_profession
            // 
            this.txt_profession.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_profession.DefaultText = "";
            this.txt_profession.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_profession.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_profession.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_profession.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_profession.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_profession.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_profession.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_profession.Location = new System.Drawing.Point(82, 411);
            this.txt_profession.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_profession.Name = "txt_profession";
            this.txt_profession.PasswordChar = '\0';
            this.txt_profession.PlaceholderText = "";
            this.txt_profession.SelectedText = "";
            this.txt_profession.Size = new System.Drawing.Size(267, 44);
            this.txt_profession.TabIndex = 78;
            // 
            // txt_mName
            // 
            this.txt_mName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mName.DefaultText = "";
            this.txt_mName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_mName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_mName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_mName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_mName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_mName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mName.Location = new System.Drawing.Point(82, 278);
            this.txt_mName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_mName.Name = "txt_mName";
            this.txt_mName.PasswordChar = '\0';
            this.txt_mName.PlaceholderText = "";
            this.txt_mName.SelectedText = "";
            this.txt_mName.Size = new System.Drawing.Size(267, 44);
            this.txt_mName.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(77, 351);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 27);
            this.label3.TabIndex = 76;
            this.label3.Text = "Profession :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(77, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 27);
            this.label2.TabIndex = 77;
            this.label2.Text = "Mechanic Name :";
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
            this.btn_update.Font = new System.Drawing.Font("Cascadia Mono", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(84, 648);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(125, 58);
            this.btn_update.TabIndex = 71;
            this.btn_update.Text = "Update";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // guna2Panel11
            // 
            this.guna2Panel11.BackColor = System.Drawing.Color.Black;
            this.guna2Panel11.Location = new System.Drawing.Point(433, 90);
            this.guna2Panel11.Name = "guna2Panel11";
            this.guna2Panel11.Size = new System.Drawing.Size(3, 753);
            this.guna2Panel11.TabIndex = 74;
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
            this.btn_search.Location = new System.Drawing.Point(480, 27);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(54, 50);
            this.btn_search.TabIndex = 43;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_cNumber
            // 
            this.txt_cNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cNumber.DefaultText = "";
            this.txt_cNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_cNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_cNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_cNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_cNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_cNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_cNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_cNumber.Location = new System.Drawing.Point(84, 550);
            this.txt_cNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_cNumber.Name = "txt_cNumber";
            this.txt_cNumber.PasswordChar = '\0';
            this.txt_cNumber.PlaceholderText = "";
            this.txt_cNumber.SelectedText = "";
            this.txt_cNumber.Size = new System.Drawing.Size(267, 44);
            this.txt_cNumber.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(79, 490);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 27);
            this.label4.TabIndex = 82;
            this.label4.Text = "Contact Number :";
            // 
            // frm_editMechanic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.txt_cNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.dgv_mechanic);
            this.Controls.Add(this.txt_mId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_profession);
            this.Controls.Add(this.txt_mName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.guna2Panel11);
            this.Name = "frm_editMechanic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_editMechanic";
            this.Load += new System.EventHandler(this.frm_editMechanic_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mechanic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_delete;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txt_searchMechanic;
        private Guna.UI2.WinForms.Guna2Button btn_search;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_mechanic;
        private Guna.UI2.WinForms.Guna2TextBox txt_mId;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_profession;
        private Guna.UI2.WinForms.Guna2TextBox txt_mName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_update;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel11;
        private Guna.UI2.WinForms.Guna2TextBox txt_cNumber;
        private System.Windows.Forms.Label label4;
    }
}