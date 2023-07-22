using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace Billing_System
{
    public partial class motocarJobCard : Form
    {

        private Bitmap panelImage;
        public motocarJobCard()
        {
            InitializeComponent();
        }

        private void motocarJobCard_Load(object sender, EventArgs e)
        {
            lbl_customerName.Text = frm_motoCar.setCustomerName;
            lbl_vehicleModel.Text = frm_motoCar.setvehicleModel;
            lbl_dateReceived.Text = frm_motoCar.setdateReceived;
            lbl_time.Text = frm_motoCar.settime;
            lbl_fuelType.Text = frm_motoCar.setfuelType;
            lbl_address.Text = frm_motoCar.setaddress;
            lbl_regNo.Text = frm_motoCar.setregNo;
            lbl_OdoMeter.Text = frm_motoCar.setodoMeter;
            lbl_phoneNumber.Text = frm_motoCar.setphoneNumber;
            lbl_chassisNo.Text = frm_motoCar.setchassisNo;
            lbl_cName.Text = frm_motoCar.setcName;
            lbl_complaints1.Text = frm_motoCar.setcomplaints1;
            lbl_complaints2.Text = frm_motoCar.setcomplaints2;
            lbl_complaints3.Text = frm_motoCar.setcomplaints3;
            lbl_complaints4.Text = frm_motoCar.setcomplaints4;
            lbl_decision1.Text = frm_motoCar.setdecision1;
            lbl_decision2.Text = frm_motoCar.setdecision2;
            lbl_decision3.Text = frm_motoCar.setdecision3;
            lbl_decision4.Text = frm_motoCar.setdecision4;
            lbl_remarks.Text = frm_motoCar.setremark1;
            lbl_estimatedCost.Text = frm_motoCar.setestimatedCost;
            lblPdatec.Text = frm_motoCar.setpDate;
            lbl_dtimec.Text = frm_motoCar.setdtime;
            lbl_CInform.Text = frm_motoCar.setcInform;
        
            lbl_ddate.Text = DateTime.Now.ToShortDateString();

            //panel1.BackgroundImage = Image.FromFile("C:\\Users\\Gihan Sanjeewa\\Documents\\GitHub\\Aurora_Bill_Systems-\\Billing_System\\Billing_System\\Resources\\No.10, Galapitamulla, Hindagolla 076-1558383 auroraautocare1st@gmail.com www.Aurora autocare.facebook.com.png");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;


        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            // Create a new PrintDocument
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintPage);
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;
            if(printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            // Calculate the target print size in pixels (A4 size at 96 dpi)
            int printWidth = (int)(8.27f * e.PageSettings.PrinterResolution.X);
            int printHeight = (int)(11.69f * e.PageSettings.PrinterResolution.Y);

            // Calculate the aspect ratio of the panel
            float aspectRatio = (float)panel1.Width / (float)panel1.Height;

            // Calculate the new width and height while maintaining the aspect ratio
            int newWidth = printWidth;
            int newHeight = (int)(printWidth / aspectRatio);

            if (newHeight > printHeight)
            {
                newHeight = printHeight;
                newWidth = (int)(printHeight * aspectRatio);
            }

            // Create a bitmap to store the panel content
            panelImage = new Bitmap(newWidth, newHeight);
            panel1.DrawToBitmap(panelImage, new Rectangle(0, 0, newWidth, newHeight));

            // Draw the panel content on the print document
            e.Graphics.DrawImage(panelImage, 0, 0, printWidth, printHeight);
        }
    }
}
