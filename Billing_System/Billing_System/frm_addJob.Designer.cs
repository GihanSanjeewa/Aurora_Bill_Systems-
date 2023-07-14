
namespace Billing_System
{
    partial class frm_addJob
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
            this.dgv_job = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_addJob = new Guna.UI2.WinForms.Guna2Button();
            this.txt_jobName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_editItem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel11 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_jobPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_job)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_job
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_job.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_job.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_job.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_job.ColumnHeadersHeight = 4;
            this.dgv_job.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_job.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_job.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_job.Location = new System.Drawing.Point(328, -1);
            this.dgv_job.Name = "dgv_job";
            this.dgv_job.RowHeadersVisible = false;
            this.dgv_job.RowHeadersWidth = 51;
            this.dgv_job.Size = new System.Drawing.Size(827, 622);
            this.dgv_job.TabIndex = 45;
            this.dgv_job.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_job.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_job.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_job.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_job.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_job.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgv_job.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_job.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_job.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_job.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_job.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_job.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_job.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_job.ThemeStyle.ReadOnly = false;
            this.dgv_job.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_job.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_job.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_job.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_job.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_job.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_job.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_job.Validating += new System.ComponentModel.CancelEventHandler(this.txt_jobName_Validating);
            // 
            // btn_addJob
            // 
            this.btn_addJob.BorderRadius = 10;
            this.btn_addJob.BorderThickness = 1;
            this.btn_addJob.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addJob.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addJob.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addJob.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addJob.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_addJob.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addJob.ForeColor = System.Drawing.Color.White;
            this.btn_addJob.Location = new System.Drawing.Point(63, 355);
            this.btn_addJob.Name = "btn_addJob";
            this.btn_addJob.Size = new System.Drawing.Size(200, 57);
            this.btn_addJob.TabIndex = 44;
            this.btn_addJob.Text = "Add Job";
            this.btn_addJob.Click += new System.EventHandler(this.btn_addJob_Click);
            // 
            // txt_jobName
            // 
            this.txt_jobName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_jobName.DefaultText = "";
            this.txt_jobName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_jobName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_jobName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_jobName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_jobName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_jobName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_jobName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_jobName.Location = new System.Drawing.Point(63, 145);
            this.txt_jobName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_jobName.Name = "txt_jobName";
            this.txt_jobName.PasswordChar = '\0';
            this.txt_jobName.PlaceholderText = "";
            this.txt_jobName.SelectedText = "";
            this.txt_jobName.Size = new System.Drawing.Size(200, 36);
            this.txt_jobName.TabIndex = 42;
            this.txt_jobName.Validating += new System.ComponentModel.CancelEventHandler(this.txt_jobName_Validating);
            this.txt_jobName.Validated += new System.EventHandler(this.txt_jobName_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "Job Name :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Cascadia Mono", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label11.Location = new System.Drawing.Point(603, 15);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 40);
            this.label11.TabIndex = 17;
            this.label11.Text = "Add Job";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.guna2GradientPanel1.Controls.Add(this.guna2Panel1);
            this.guna2GradientPanel1.Controls.Add(this.label11);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(-92, -1);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1371, 73);
            this.guna2GradientPanel1.TabIndex = 46;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Black;
            this.guna2Panel1.Location = new System.Drawing.Point(417, 71);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1076, 2);
            this.guna2Panel1.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(269, 663);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 49;
            this.label5.Text = "Edit ";
            // 
            // btn_editItem
            // 
            this.btn_editItem.BackgroundImage = global::Billing_System.Properties.Resources.settings;
            this.btn_editItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_editItem.BorderColor = System.Drawing.Color.Transparent;
            this.btn_editItem.BorderRadius = 10;
            this.btn_editItem.BorderThickness = 2;
            this.btn_editItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_editItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_editItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_editItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_editItem.FillColor = System.Drawing.Color.Transparent;
            this.btn_editItem.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold);
            this.btn_editItem.ForeColor = System.Drawing.Color.White;
            this.btn_editItem.Location = new System.Drawing.Point(272, 620);
            this.btn_editItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_editItem.Name = "btn_editItem";
            this.btn_editItem.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_editItem.Size = new System.Drawing.Size(40, 41);
            this.btn_editItem.TabIndex = 48;
            this.btn_editItem.Click += new System.EventHandler(this.btn_editItem_Click);
            // 
            // guna2Panel11
            // 
            this.guna2Panel11.BackColor = System.Drawing.Color.Black;
            this.guna2Panel11.Location = new System.Drawing.Point(325, 73);
            this.guna2Panel11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel11.Name = "guna2Panel11";
            this.guna2Panel11.Size = new System.Drawing.Size(2, 612);
            this.guna2Panel11.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(59, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 37;
            this.label3.Text = "Job Price :";
            // 
            // txt_jobPrice
            // 
            this.txt_jobPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_jobPrice.DefaultText = "";
            this.txt_jobPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_jobPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_jobPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_jobPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_jobPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_jobPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_jobPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_jobPrice.Location = new System.Drawing.Point(63, 253);
            this.txt_jobPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_jobPrice.Name = "txt_jobPrice";
            this.txt_jobPrice.PasswordChar = '\0';
            this.txt_jobPrice.PlaceholderText = "";
            this.txt_jobPrice.SelectedText = "";
            this.txt_jobPrice.Size = new System.Drawing.Size(200, 36);
            this.txt_jobPrice.TabIndex = 41;
            this.txt_jobPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txt_jobPrice_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_addJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.dgv_job);
            this.Controls.Add(this.btn_addJob);
            this.Controls.Add(this.txt_jobPrice);
            this.Controls.Add(this.txt_jobName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_editItem);
            this.Controls.Add(this.guna2Panel11);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_addJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_addJob";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_job)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgv_job;
        private Guna.UI2.WinForms.Guna2Button btn_addJob;
        private Guna.UI2.WinForms.Guna2TextBox txt_jobName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btn_editItem;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel11;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_jobPrice;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}