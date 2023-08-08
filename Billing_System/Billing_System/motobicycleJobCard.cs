using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Billing_System
{
    public partial class motobicycleJobCard : Form
    {

        private Bitmap panelImage;
        public motobicycleJobCard()
        {
            InitializeComponent();
            //date = DateTime.Now.ToString("mm/dd/yyyy");
        }

        private void print(Panel pnl)
        {
            //PrinterSettings ps = new PrinterSettings();
           // panel1 = pnl;
            //getprintarea(pnl);
            //printPreviewDialog1.Document = printDocument1;
            //printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
           // printPreviewDialog1.ShowDialog();
        }

        

        private void getprintarea(Panel pnl)
        {
           // memoryimg = new Bitmap(pnl.Width, pnl.Height);
            //pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void motobicycleJobCard_Load(object sender, EventArgs e)
        {
            lbl_customerName.Text = frm_motoBicycle.setCustomerName;
            lbl_vehicleModel.Text = frm_motoBicycle.setvehicleModel;
            lbl_dateReceived.Text = frm_motoBicycle.setdateReceived;
            lbl_time.Text = frm_motoBicycle.settime;
            lbl_fuelType.Text = frm_motoBicycle.setfuelType;
            lbl_address.Text = frm_motoBicycle.setaddress;
            lbl_regNo.Text = frm_motoBicycle.setregNo;
            lbl_odoMeter.Text = frm_motoBicycle.setodoMeter;
            lbl_odoMeterb.Text = frm_motoBicycle.setodoMeter;
            lbl_phoneNumber.Text = frm_motoBicycle.setphoneNumber;
            lbl_chassisNo.Text = frm_motoBicycle.setchassisNo;
            lbl_cName.Text = frm_motoBicycle.setcName;
            lbl_complain1.Text =  frm_motoBicycle.setcomplaints1;
            lbl_complain2.Text =  frm_motoBicycle.setcomplaints2;
            lbl_complain3.Text =  frm_motoBicycle.setcomplaints3;
            lbl_complain4.Text =  frm_motoBicycle.setcomplaints4;
            lbl_decision1.Text =  frm_motoBicycle.setdecision1;
            lbl_decision2.Text =  frm_motoBicycle.setdecision2;
            lbl_decision3.Text =  frm_motoBicycle.setdecision3;
            lbl_decision4.Text =  frm_motoBicycle.setdecision4;
            lbl_remarks.Text = frm_motoBicycle.setResultRemark;
            lbl_estimatedCostb.Text = frm_motoBicycle.setestimatedCost;
            lbl_pDateb.Text = frm_motoBicycle.setpDate;
            lbl_dtimeb.Text = frm_motoBicycle.settime;
            lbl_cInformb.Text = frm_motoBicycle.setcInform;
            lbl_nDateb.Text = DateTime.Now.ToShortDateString();

            panel1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
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

        private void btn_print_Click(object sender, EventArgs e)
        {
            // Create a new PrintDocument
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
