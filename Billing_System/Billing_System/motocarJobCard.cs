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
    public partial class motocarJobCard : Form
    {
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
            lbl_odoMeter.Text = frm_motoCar.setodoMeter;
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
            lbl_remark1.Text = frm_motoCar.setremark1;
            lbl_estimatedCost.Text = frm_motoCar.setestimatedCost;
            lbl_pDate.Text = frm_motoCar.setpDate;
            lbl_dtime.Text = frm_motoCar.setdtime;
            lbl_cInform.Text = frm_motoCar.setcInform;
            lbl_nDate.Text = DateTime.Now.ToShortDateString();
            //nothing
        }
    }
}
