
namespace Billing_System
{
    partial class motobicycleJobCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(motobicycleJobCard));
            this.lbl_estimatedCost = new System.Windows.Forms.Label();
            this.lbl_pDate = new System.Windows.Forms.Label();
            this.lbl_cInform = new System.Windows.Forms.Label();
            this.lbl_dtime = new System.Windows.Forms.Label();
            this.lbl_nDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_print = new Guna.UI2.WinForms.Guna2Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // lbl_estimatedCost
            // 
            this.lbl_estimatedCost.AutoSize = true;
            this.lbl_estimatedCost.BackColor = System.Drawing.Color.Transparent;
            this.lbl_estimatedCost.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estimatedCost.Location = new System.Drawing.Point(45, 681);
            this.lbl_estimatedCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_estimatedCost.Name = "lbl_estimatedCost";
            this.lbl_estimatedCost.Size = new System.Drawing.Size(12, 13);
            this.lbl_estimatedCost.TabIndex = 1;
            this.lbl_estimatedCost.Text = "-";
            // 
            // lbl_pDate
            // 
            this.lbl_pDate.AutoSize = true;
            this.lbl_pDate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pDate.Font = new System.Drawing.Font("Malgun Gothic", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pDate.Location = new System.Drawing.Point(136, 682);
            this.lbl_pDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pDate.Name = "lbl_pDate";
            this.lbl_pDate.Size = new System.Drawing.Size(9, 12);
            this.lbl_pDate.TabIndex = 2;
            this.lbl_pDate.Text = "-";
            // 
            // lbl_cInform
            // 
            this.lbl_cInform.AutoSize = true;
            this.lbl_cInform.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cInform.Font = new System.Drawing.Font("Malgun Gothic", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cInform.Location = new System.Drawing.Point(500, 682);
            this.lbl_cInform.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_cInform.Name = "lbl_cInform";
            this.lbl_cInform.Size = new System.Drawing.Size(9, 12);
            this.lbl_cInform.TabIndex = 2;
            this.lbl_cInform.Text = "-";
            // 
            // lbl_dtime
            // 
            this.lbl_dtime.AutoSize = true;
            this.lbl_dtime.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dtime.Font = new System.Drawing.Font("Malgun Gothic", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dtime.Location = new System.Drawing.Point(322, 682);
            this.lbl_dtime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dtime.Name = "lbl_dtime";
            this.lbl_dtime.Size = new System.Drawing.Size(9, 12);
            this.lbl_dtime.TabIndex = 3;
            this.lbl_dtime.Text = "-";
            // 
            // lbl_nDate
            // 
            this.lbl_nDate.AutoSize = true;
            this.lbl_nDate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nDate.Font = new System.Drawing.Font("Malgun Gothic", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nDate.Location = new System.Drawing.Point(454, 778);
            this.lbl_nDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nDate.Name = "lbl_nDate";
            this.lbl_nDate.Size = new System.Drawing.Size(9, 12);
            this.lbl_nDate.TabIndex = 2;
            this.lbl_nDate.Text = "-";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Billing_System.Properties.Resources.Screenshot_2023_05_26_at_17_21_35;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(2, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 604);
            this.panel1.TabIndex = 4;
            // 
            // btn_print
            // 
            this.btn_print.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_print.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_print.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_print.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_print.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(12, 10);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(595, 32);
            this.btn_print.TabIndex = 5;
            this.btn_print.Text = "Print";
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // motobicycleJobCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(619, 652);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_dtime);
            this.Controls.Add(this.lbl_nDate);
            this.Controls.Add(this.lbl_cInform);
            this.Controls.Add(this.lbl_pDate);
            this.Controls.Add(this.lbl_estimatedCost);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "motobicycleJobCard";
            this.Text = "motobicycleJobCard";
            this.Load += new System.EventHandler(this.motobicycleJobCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_estimatedCost;
        private System.Windows.Forms.Label lbl_pDate;
        private System.Windows.Forms.Label lbl_cInform;
        private System.Windows.Forms.Label lbl_dtime;
        private System.Windows.Forms.Label lbl_nDate;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btn_print;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}