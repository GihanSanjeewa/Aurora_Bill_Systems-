using MySql.Data.MySqlClient;
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
    public partial class sconditionPrint : Form
    {
        
        public sconditionPrint()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Get the panel's content to print
            Bitmap panelBitmap = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(panelBitmap, new Rectangle(0, 0, panel1.Width, panel1.Height));

            // Calculate the position to center the panel horizontally on the page
            int xPosition = (e.PageBounds.Width - panelBitmap.Width) / 2;

            // Calculate the position to center the panel vertically on the page
            int yPosition = (e.PageBounds.Height - panelBitmap.Height) / 2;

            // Draw the panel's content onto the print page at the adjusted position
            e.Graphics.DrawImage(panelBitmap, new Point(xPosition, yPosition));
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

        private void sconditionPrint_Load(object sender, EventArgs e)
        {
            lbl_vNumber.Text = frm_sconditionReport.vehicle_number;
            lbl_vModel.Text = frm_sconditionReport.VehicleModel;
            lbl_nMachanic.Text = frm_sconditionReport.MachanicName;
            lbl_fuel.Text = frm_sconditionReport.fuel;
            lbl_km.Text = frm_sconditionReport.km;
            lbl_Date.Text = frm_sconditionReport.date;

            s0good.Text = frm_sconditionReport.engineOil;
            s1good.Text = frm_sconditionReport.gearOil;
            s2good.Text = frm_sconditionReport.breakOil;
            s3good.Text = frm_sconditionReport.airFilter;
            s4good.Text = frm_sconditionReport.acFilter;
            s5good.Text = frm_sconditionReport.breaks;
            s6good.Text = frm_sconditionReport.radiator;
            s7good.Text = frm_sconditionReport.socket;
            s8good.Text = frm_sconditionReport.rodrack;
            s9good.Text = frm_sconditionReport.lowbush;
            s10good.Text = frm_sconditionReport.upperbush;
            s11good.Text = frm_sconditionReport.carm;
            s12good.Text = frm_sconditionReport.ebelt;
            s13good.Text = frm_sconditionReport.axel;
            s14good.Text = frm_sconditionReport.mount;
            s15good.Text = frm_sconditionReport.oilLeak;
            

        }
    }
}
