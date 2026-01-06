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
    public partial class frmPatientInfoDetailes : Form
    {
        int _id;
        
        public frmPatientInfoDetailes(int PatientID)
        {
            InitializeComponent();
            usrCtrlPatientInfo1.Id = PatientID;
            
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddNewPatient(Convert.ToInt32(usrCtrlPatientInfo1.Id));
            
            frm.ShowDialog();
            usrCtrlPatientInfo1._loadData();
            
        }
    }
}
