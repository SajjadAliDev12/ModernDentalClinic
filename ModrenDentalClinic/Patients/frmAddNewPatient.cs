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
    public partial class frmAddNewPatient : Form
    {
        private int _ID = 0;
        public frmAddNewPatient()
        {
            InitializeComponent();
            rdbtnMale.Checked = true;
        }
        public frmAddNewPatient(int PatientID)
        {
            InitializeComponent();
            _ID = PatientID;
            _loadData();
        }
        private void _loadData()
        {
            if (BusinessLogicLayer.BusinessLayer.IsPatientExist(_ID))
            {
                label1.Text = "تحديث معلومات المراجع";
                BusinessLogicLayer.BusinessLayer.clsPatients Patient1 = BusinessLogicLayer.BusinessLayer.clsPatients.GetPatientByID(_ID);
                txtbxAddress.Text = Patient1.Address;
                txtbxAge.Text = Patient1.Age.ToString();
                txtbxCanalLength.Text = Patient1.CanalLength;
                if(Patient1.Gender == 1)
                    rdbtnMale.Checked = true;
                else
                    rdbtnFemale.Checked = true;
                dateTimePicker1.Text = Patient1.VisitDate.ToString();
                txtbxNotes.Text = Patient1.Notes;
                txtbxMedicalHistory.Text = Patient1.MedicalHistory;
                txtbxFullName.Text = Patient1.FullName;
                txtbxPhone.Text = Patient1.PhoneNumber;
                Patient1.Mode = BusinessLogicLayer.BusinessLayer.clsPatients.enMode.Update;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!Char.IsControl(e.KeyChar)))
            {
                errorProvider1.SetError(txtbxAge, "يجب ادخال ارقام ققط");
                e.Handled = true;
            }
        }

        private void txtbxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!Char.IsControl(e.KeyChar)))
            { e.Handled = true;
                errorProvider1.SetError(txtbxPhone, "يجب ادخال ارقام ققط");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbxFullName.Text))
            {
                errorProvider1.SetError(txtbxFullName, "يجب ادخال الاسم");
                txtbxFullName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtbxAge.Text))
            {
                errorProvider1.SetError(txtbxAge, "يجب ادخال العمر");txtbxAge.Focus();
                txtbxAge.Focus();
                return ;
            }
            if (string.IsNullOrWhiteSpace(txtbxPhone.Text))
            {
                errorProvider1.SetError(txtbxPhone, "يجب ادخال رقم الهاتف");
                txtbxPhone.Focus();
                return ;
            }

            BusinessLogicLayer.BusinessLayer.clsPatients Patient1 = new BusinessLogicLayer.BusinessLayer.clsPatients();
            if (_ID != 0)
            {
                Patient1 = BusinessLogicLayer.BusinessLayer.clsPatients.GetPatientByID(_ID);
                Patient1.Mode = BusinessLogicLayer.BusinessLayer.clsPatients.enMode.Update;
            }
            else
                Patient1.Mode = BusinessLogicLayer.BusinessLayer.clsPatients.enMode.AddNew;
            Patient1.PatientID = _ID;
            Patient1.FullName = txtbxFullName.Text;
            Patient1.CanalLength = txtbxCanalLength.Text;
            Patient1.Notes = txtbxNotes.Text;
            Patient1.Address = txtbxAddress.Text;
            Patient1.VisitDate = dateTimePicker1.Value;
            Patient1.Age = Convert.ToInt16(txtbxAge.Text);
            if (rdbtnFemale.Checked)
                Patient1.Gender = 0;
            else
                Patient1 .Gender = 1;
            Patient1.PhoneNumber = txtbxPhone.Text;
            Patient1.MedicalHistory = txtbxMedicalHistory.Text;
            if(Patient1.Save())
            {
                MessageBox.Show("تم حفظ البيانات بنجاح!","تم الحفظ",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("!خطأ في حفظ البيانات","خطأ",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void txtbxFullName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbxFullName.Text))
            {
                errorProvider1.SetError(txtbxFullName, "يجب ادخال الاسم");
            }
            else
                errorProvider1.SetError(txtbxFullName, "");
        }

        private void txtbxAge_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbxAge.Text))
            {
                errorProvider1.SetError(txtbxAge, "يجب ادخال العمر");
            }
            else
                errorProvider1.SetError(txtbxAge, "");
        }

        private void txtbxPhone_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbxPhone.Text))
            {
                errorProvider1.SetError(txtbxPhone, "يجب ادخال رقم الهاتف");
            }
            else
                errorProvider1.SetError(txtbxPhone, "");
        }
    }
}
