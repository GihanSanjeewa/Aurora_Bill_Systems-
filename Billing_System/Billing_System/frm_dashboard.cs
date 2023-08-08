using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_System
{
    public partial class frm_dashboard : Form
    {

        private PerformanceCounter cpuCounter;
        private Timer updateTimer;

        public frm_dashboard()
        {
            InitializeComponent();
            InitializePerformanceCounter();
            InitializeTimer();
        }

        private void InitializePerformanceCounter()
        {
            string categoryName = "Processor"; // Change this to the appropriate category name
            string counterName = "% Processor Time";
            string instanceName = "_Total";

            if (PerformanceCounterCategory.Exists(categoryName))
            {
                cpuCounter = new PerformanceCounter(categoryName, counterName, instanceName);
            }
            else
            {
                MessageBox.Show($"The category '{categoryName}' does not exist on this system.", "Category Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Handle the situation where the category doesn't exist
            }
        }

        private void InitializeTimer()
        {
            // Initialize and start the timer
            updateTimer = new Timer();
            updateTimer.Interval = 1000; // Update every 1 second
            updateTimer.Tick += UpdatePerformanceMetrics;
            updateTimer.Start();
        }

        private void UpdatePerformanceMetrics(object sender, EventArgs e)
        {
            // Get the current CPU usage
            float cpuUsage = cpuCounter.NextValue();

            // Update the UI with CPU usage information
            cpuUsageLabel.Text = $"CPU Usage: {cpuUsage:F2}%";

            DateTime currentDateTime = DateTime.Now;
            dateTimeLabel.Text = $"{currentDateTime}";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Clean up resources when the form is closing
            cpuCounter.Dispose();
            updateTimer.Stop();
            updateTimer.Dispose();
        }
    
    

        private void btn_jobcardMotorbike_Click(object sender, EventArgs e)
        {
            frm_motoBicycle motoBike = new frm_motoBicycle();
            motoBike.Show();
        }

        private void btn_invoice_Click(object sender, EventArgs e)
        {
            frm_invoice invoice = new frm_invoice();
            invoice.Show();
        }

        private void btn_jobcardMotorcar_Click(object sender, EventArgs e)
        {
            frm_motoCar motoCar = new frm_motoCar();
            motoCar.Show();
        }

        private void btn_suspensionCondition_Click(object sender, EventArgs e)
        {
            frm_sconditionReport sconditionReport = new frm_sconditionReport();
            sconditionReport.Show();
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            frm_salesReport salesReport = new frm_salesReport();
            salesReport.Show();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_add add = new frm_add();
            add.Show();
        }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            frm_inventory inventory = new frm_inventory();
            inventory.Show();
        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            this.Hide();
            login.Show(); 
        }

        private void lbl_jcCar_Click(object sender, EventArgs e)
        {

        }

        private void lbl_invoice_Click(object sender, EventArgs e)
        {

        }

        private void lbl_jcBike_Click(object sender, EventArgs e)
        {

        }

        private void frm_dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
