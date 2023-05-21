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
            this.username_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.password_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.user_name = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.White;
            this.btn_login.BorderRadius = 5;
            this.btn_login.BorderThickness = 2;
            this.btn_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(91)))), ((int)(((byte)(39)))));
            this.btn_login.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(196, 579);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(180, 46);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            // 
            // picturebox_logo
            // 
            this.picturebox_logo.Image = ((System.Drawing.Image)(resources.GetObject("picturebox_logo.Image")));
            this.picturebox_logo.ImageRotate = 0F;
            this.picturebox_logo.Location = new System.Drawing.Point(150, 54);
            this.picturebox_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picturebox_logo.Name = "picturebox_logo";
            this.picturebox_logo.Size = new System.Drawing.Size(300, 199);
            this.picturebox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_logo.TabIndex = 1;
            this.picturebox_logo.TabStop = false;
            // 
            // username_textbox
            // 
            this.username_textbox.BorderRadius = 5;
            this.username_textbox.BorderThickness = 2;
            this.username_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username_textbox.DefaultText = "";
            this.username_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username_textbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.username_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username_textbox.Location = new System.Drawing.Point(245, 330);
            this.username_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.PasswordChar = '\0';
            this.username_textbox.PlaceholderText = "";
            this.username_textbox.SelectedText = "";
            this.username_textbox.Size = new System.Drawing.Size(229, 48);
            this.username_textbox.TabIndex = 4;
            this.username_textbox.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // password_txtbox
            // 
            this.password_txtbox.BorderRadius = 5;
            this.password_txtbox.BorderThickness = 2;
            this.password_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_txtbox.DefaultText = "";
            this.password_txtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password_txtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password_txtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_txtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_txtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.password_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_txtbox.Location = new System.Drawing.Point(245, 435);
            this.password_txtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.PasswordChar = '\0';
            this.password_txtbox.PlaceholderText = "";
            this.password_txtbox.SelectedText = "";
            this.password_txtbox.Size = new System.Drawing.Size(229, 48);
            this.password_txtbox.TabIndex = 5;
            this.password_txtbox.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.user_name.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.Location = new System.Drawing.Point(92, 339);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(122, 29);
            this.user_name.TabIndex = 6;
            this.user_name.Text = "User Name";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.password.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(104, 445);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(110, 29);
            this.password.TabIndex = 7;
            this.password.Text = "Password";
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(150)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(632, 745);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.picturebox_logo);
            this.Controls.Add(this.btn_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_login";
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_login;
        private Guna.UI2.WinForms.Guna2PictureBox picturebox_logo;
        private Guna.UI2.WinForms.Guna2TextBox username_textbox;
        private Guna.UI2.WinForms.Guna2TextBox password_txtbox;
        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Label password;
    }
}