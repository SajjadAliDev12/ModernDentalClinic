using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModrenDentalClinic.Appointments
{
    public partial class frmAppointmentDetailes : Form
    {
        private int _id;
        public frmAppointmentDetailes(int ID)
        {
            InitializeComponent();
            this._id = ID;
            LoadData();
        }

        private void LoadData()
        {
            BusinessLogicLayer.BusinessLayer.clsAppointments appointments = BusinessLogicLayer.BusinessLayer.clsAppointments.GetByAppt(_id);
            if (appointments != null)
            {
                lblCause.Text = appointments.Reason;
                lblData.Text =Global.FormatDateWithDay( appointments.AppointmentDate);
                lblNotes.Text = appointments.Notes;
                lblStatus.Text = appointments.Status;
                BusinessLogicLayer.BusinessLayer.clsPatients p1 = BusinessLogicLayer.BusinessLayer.clsPatients.GetPatientByID(appointments.PatientID);
                lblPatientName.Text = p1.FullName;
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new frmEditAppointment(_id);
            frm.ShowDialog();
            LoadData();
        }
    }
}
