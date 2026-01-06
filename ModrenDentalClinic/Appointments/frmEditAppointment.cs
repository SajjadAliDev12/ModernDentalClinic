using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModrenDentalClinic.Appointments
{
    public partial class frmEditAppointment : Form
    {
        private int _id;
        public frmEditAppointment(int ID)
        {
            InitializeComponent();
            this._id = ID;
            BusinessLogicLayer.BusinessLayer.clsAppointments app = BusinessLogicLayer.BusinessLayer.clsAppointments.GetByAppt(_id);
            BusinessLogicLayer.BusinessLayer.clsPatients P1 = BusinessLogicLayer.BusinessLayer.clsPatients.GetPatientByID(app.PatientID);
            lblPatientName.Text = P1.FullName;
            txtbxNotes.Text = app.Notes;
            txtbxReason.Text = app.Reason;
            txtbxStaus.Text = app.Status;
            dateTimePicker1.Value = app.AppointmentDate;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtbxNotes.Text) && !string.IsNullOrWhiteSpace(txtbxReason.Text) && !string.IsNullOrWhiteSpace(txtbxStaus.Text))
            {
                if (BusinessLogicLayer.BusinessLayer.clsAppointments.Update(_id, dateTimePicker1.Value, txtbxReason.Text, txtbxStaus.Text, txtbxNotes.Text))
                { MessageBox.Show("تم تعديل الموعد بنجاح!", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information); this.Close(); }
                else
                    MessageBox.Show("فشل في تعديل الموعد", "فشل!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("يجب ملئ كل الحقول", "فشل!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
