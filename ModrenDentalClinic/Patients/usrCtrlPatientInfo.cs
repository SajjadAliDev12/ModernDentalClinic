using ModrenDentalClinic.Appointments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModrenDentalClinic.Patients
{
    public partial class usrCtrlPatientInfo : UserControl
    {
        private int _id ;
        public int Id { get => _id; set { _id = value;_loadData(); } }
        public usrCtrlPatientInfo()
        {
            InitializeComponent();
            
        }
        public  void _loadData()
        {
           BusinessLogicLayer.BusinessLayer.clsPatients Patient1 = BusinessLogicLayer.BusinessLayer.clsPatients.GetPatientByID(_id);
            if (Patient1 != null)
            {
                lblAddress.Text = Patient1.Address;
                lblAge.Text = Patient1.Age.ToString();
                lblCanalLength.Text = Patient1.CanalLength;
                lblFullName.Text = Patient1.FullName;
                if (Patient1.Gender == 1)
                    lblGender.Text = "ذكر";
                else lblGender.Text = "أنثى";
                lblMidecalHistory.Text = Patient1.MedicalHistory;
                lblNotes.Text = Patient1.Notes;
                lblPhone.Text = Patient1.PhoneNumber;
                lblVisitDate.Text =Global.FormatDateWithDay( Patient1.VisitDate);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmAppointments(Id);
            frm.ShowDialog();
        }
    }
}
