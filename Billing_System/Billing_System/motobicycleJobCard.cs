using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_System
{
    public partial class motobicycleJobCard : Form
    {
        public motobicycleJobCard()
        {
            InitializeComponent();
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
            lbl_phoneNumber.Text = frm_motoBicycle.setphoneNumber;
            lbl_chassisNo.Text = frm_motoBicycle.setchassisNo;
            lbl_cName.Text = frm_motoBicycle.setcName;
            lbl_complaints1.Text = frm_motoBicycle.setcomplaints1;
            lbl_complaints2.Text = frm_motoBicycle.setcomplaints2;
            lbl_complaints3.Text = frm_motoBicycle.setcomplaints3;
            lbl_complaints4.Text = frm_motoBicycle.setcomplaints4;
            lbl_decision1.Text = frm_motoBicycle.setdecision1;
            lbl_decision2.Text = frm_motoBicycle.setdecision2;
            lbl_decision3.Text = frm_motoBicycle.setdecision3;
            lbl_decision4.Text = frm_motoBicycle.setdecision4;
            lbl_remark1.Text = frm_motoBicycle.setremark1;
            lbl_estimatedCost.Text = frm_motoBicycle.setestimatedCost;
            lbl_pDate.Text = frm_motoBicycle.setpDate;
            lbl_dtime.Text = frm_motoBicycle.setdtime;
            lbl_cInform.Text = frm_motoBicycle.setcInform;
            lbl_nDate.Text = DateTime.Now.ToShortDateString();
        }
    }
}
