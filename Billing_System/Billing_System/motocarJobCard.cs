using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_System
{
    public partial class motocarJobCard : Form
    {
        public motocarJobCard()
        {
            InitializeComponent();
        }

        private void motocarJobCard_Load(object sender, EventArgs e)
        {
            //lbl_customerName.Text = frm_motoCar.setCustomerName;
            //lbl_vehicleModel.Text = frm_motoCar.setvehicleModel;
            //lbl_dateReceived.Text = frm_motoCar.setdateReceived;
            //lbl_time.Text = frm_motoCar.settime;
            //lbl_fuelType.Text = frm_motoCar.setfuelType;
            //lbl_address.Text = frm_motoCar.setaddress;
            //lbl_regNo.Text = frm_motoCar.setregNo;
            //lbl_OdoMeter.Text = frm_motoCar.setodoMeter;
            //lbl_phoneNumber.Text = frm_motoCar.setphoneNumber;
            //lbl_chassisNo.Text = frm_motoCar.setchassisNo;
            //lbl_cName.Text = frm_motoCar.setcName;
            //lbl_complaints1.Text = frm_motoCar.setcomplaints1;
            //lbl_complaintsc2.Text = frm_motoCar.setcomplaints2;
            //lbl_complaints3.Text = frm_motoCar.setcomplaints3;
            //lbl_complaints4.Text = frm_motoCar.setcomplaints4;
            //lbl_decision1.Text = frm_motoCar.setdecision1;
            //lbl_decision2.Text = frm_motoCar.setdecision2;
            //lbl_decision3.Text = frm_motoCar.setdecision3;
            //lbl_decision4.Text = frm_motoCar.setdecision4;
            //lbl_remarks.Text = frm_motoCar.setremark1;
            //lbl_estimatedCost.Text = frm_motoCar.setestimatedCost;
            //lblPdatec.Text = frm_motoCar.setpDate;
            //lbl_dtimec.Text = frm_motoCar.setdtime;
            //lbl_CInform.Text = frm_motoCar.setcInform;
            //lbl_nDatec.Text = DateTime.Now.ToShortDateString();
            //nothing
        }

        private void lbl_complaints4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_fuelType_Click(object sender, EventArgs e)
        {

        }

        private void lbl_dtimec_Click(object sender, EventArgs e)
        {

        }

        private void lbl_nDatec_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Odometerc_Click(object sender, EventArgs e)
        {

        }

        private void lblPdatec_Click(object sender, EventArgs e)
        {

        }

        private void lbl_estimatedCost_Click(object sender, EventArgs e)
        {

        }

        private void lbl_cName_Click(object sender, EventArgs e)
        {

        }

        private void lbl_time_Click(object sender, EventArgs e)
        {

        }

        private void lbl_dateReceived_Click(object sender, EventArgs e)
        {

        }

        private void lbl_phoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void lbl_address_Click(object sender, EventArgs e)
        {

        }

        private void lbl_CInform_Click(object sender, EventArgs e)
        {

        }

        private void lbl_remarks_Click(object sender, EventArgs e)
        {

        }

        private void lbl_decision4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_decision3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_decision2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_complaints3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_decision1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_complaintsc2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_complaints1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_chassisNo_Click(object sender, EventArgs e)
        {

        }

        private void lbl_regNo_Click(object sender, EventArgs e)
        {

        }

        private void lbl_OdoMeter_Click(object sender, EventArgs e)
        {

        }

        private void lbl_customerName_Click(object sender, EventArgs e)
        {

        }

        private void lbl_vehicleModel_Click(object sender, EventArgs e)
        {

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintPage);
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle marginBounds = e.MarginBounds;

            // Calculate the aspect ratio of the image
            float aspectRatio = (float)panel1.BackgroundImage.Width / panel1.BackgroundImage.Height;

            // Calculate the target width and height for A4 size
            int targetWidth = marginBounds.Width;
            int targetHeight = (int)(targetWidth / aspectRatio);

            // Check if the height exceeds the printable area height
            if (targetHeight > marginBounds.Height)
            {
                targetHeight = marginBounds.Height;
                targetWidth = (int)(targetHeight * aspectRatio);
            }

            // Calculate the position to center the image
            int x = marginBounds.Left + (marginBounds.Width - targetWidth) / 2;
            int y = marginBounds.Top + (marginBounds.Height - targetHeight) / 2;

            // Draw the image on the print page graphics
            g.DrawImage(panel1.BackgroundImage, x, y, targetWidth, targetHeight);
        }
    }
}
