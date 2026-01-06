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
    public partial class frmAddAppointment : Form
    {
        private int _id;
        public frmAddAppointment(int ID)
        {
            InitializeComponent();
            this._id = ID;
            BusinessLogicLayer.BusinessLayer.clsPatients P1 = BusinessLogicLayer.BusinessLayer.clsPatients.GetPatientByID(_id);
            lblPatientName.Text = P1.FullName;
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtbxNotes.Text) && !string.IsNullOrWhiteSpace(txtbxReason.Text) && !string.IsNullOrWhiteSpace(txtbxStaus.Text))
            {
                if (BusinessLogicLayer.BusinessLayer.clsAppointments.Add(_id, dateTimePicker1.Value, txtbxReason.Text, txtbxStaus.Text, txtbxNotes.Text))
                { MessageBox.Show("تمت اضافة الموعد بنجاح!", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information); this.Close(); }
                else
                    MessageBox.Show("فشل في اضافة الموعد", "فشل!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
