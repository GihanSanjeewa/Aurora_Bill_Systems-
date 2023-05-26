namespace Billing_System
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.btn_login = new Guna.UI2.WinForms.Guna2Button();
            this.picturebox_logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txt_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.user_name = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.btn_showPassword = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_logo)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.BorderRadius = 5;
            this.btn_login.BorderThickness = 2;
            this.btn_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_login.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(175, 527);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(265, 54);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // picturebox_logo
            // 
            this.picturebox_logo.Image = ((System.Drawing.Image)(resources.GetObject("picturebox_logo.Image")));
            this.picturebox_logo.ImageRotate = 0F;
            this.picturebox_logo.Location = new System.Drawing.Point(-1, -25);
            this.picturebox_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picturebox_logo.Name = "picturebox_logo";
            this.picturebox_logo.Size = new System.Drawing.Size(324, 218);
            this.picturebox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_logo.TabIndex = 1;
            this.picturebox_logo.TabStop = false;
            // 
            // txt_username
            // 
            this.txt_username.BorderRadius = 5;
            this.txt_username.BorderThickness = 2;
            this.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.DefaultText = "";
            this.txt_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username.Location = new System.Drawing.Point(229, 301);
            this.txt_username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_username.Name = "txt_username";
            this.txt_username.PasswordChar = '\0';
            this.txt_username.PlaceholderText = "";
            this.txt_username.SelectedText = "";
            this.txt_username.Size = new System.Drawing.Size(297, 48);
            this.txt_username.TabIndex = 4;
            // 
            // txt_password
            // 
            this.txt_password.BorderRadius = 5;
            this.txt_password.BorderThickness = 2;
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.DefaultText = "";
            this.txt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.Location = new System.Drawing.Point(229, 406);
            this.txt_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '\0';
            this.txt_password.PlaceholderText = "";
            this.txt_password.SelectedText = "";
            this.txt_password.Size = new System.Drawing.Size(297, 48);
            this.txt_password.TabIndex = 5;
            this.txt_password.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.ForeColor = System.Drawing.Color.White;
            this.user_name.Location = new System.Drawing.Point(87, 310);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(108, 27);
            this.user_name.TabIndex = 6;
            this.user_name.Text = "Username";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Location = new System.Drawing.Point(88, 416);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(108, 27);
            this.password.TabIndex = 7;
            this.password.Text = "Password";
            // 
            // btn_showPassword
            // 
            this.btn_showPassword.BackColor = System.Drawing.Color.Transparent;
            this.btn_showPassword.BackgroundImage = global::Billing_System.Properties.Resources.hide;
            this.btn_showPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_showPassword.BorderColor = System.Drawing.Color.Transparent;
            this.btn_showPassword.BorderRadius = 10;
            this.btn_showPassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_showPassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_showPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_showPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_showPassword.FillColor = System.Drawing.Color.Transparent;
            this.btn_showPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_showPassword.ForeColor = System.Drawing.Color.Transparent;
            this.btn_showPassword.Location = new System.Drawing.Point(532, 416);
            this.btn_showPassword.Name = "btn_showPassword";
            this.btn_showPassword.PressedColor = System.Drawing.Color.Transparent;
            this.btn_showPassword.Size = new System.Drawing.Size(34, 33);
            this.btn_showPassword.TabIndex = 8;
            this.btn_showPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_showPassword_MouseDown);
            this.btn_showPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_showPassword_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 10);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Location = new System.Drawing.Point(622, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(12, 752);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel3.Location = new System.Drawing.Point(-5, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(14, 751);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel4.Location = new System.Drawing.Point(-1, 733);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(635, 18);
            this.panel4.TabIndex = 11;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.guna2Panel1.BorderRadius = 100;
            this.guna2Panel1.BorderThickness = 10;
            this.guna2Panel1.Controls.Add(this.picturebox_logo);
            this.guna2Panel1.Location = new System.Drawing.Point(142, 71);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(349, 164);
            this.guna2Panel1.TabIndex = 12;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(632, 745);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_showPassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.btn_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_login";
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_logo)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_login;
        private Guna.UI2.WinForms.Guna2PictureBox picturebox_logo;
        private Guna.UI2.WinForms.Guna2TextBox txt_username;
        private Guna.UI2.WinForms.Guna2TextBox txt_password;
        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Label password;
        private Guna.UI2.WinForms.Guna2Button btn_showPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}