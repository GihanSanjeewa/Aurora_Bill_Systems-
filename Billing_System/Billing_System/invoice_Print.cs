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
    public partial class invoice_Print : Form
    {
        private Bitmap panelImage;
        public invoice_Print()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
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
    }
}
