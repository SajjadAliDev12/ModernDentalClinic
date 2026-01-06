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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ModrenDentalClinic.Patients
{
    public partial class FrmPatients : Form
    {
        public FrmPatients()
        {
            InitializeComponent();
            _LoadData();
            txtbxSearch.Enabled = false;
        }
        private int currentPage = 1;
        private int pageSize = 12;

        private void _LoadData()
        {
            dvgPatients.DataSource = BusinessLogicLayer.BusinessLayer.GetAllPatients(currentPage, pageSize);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            _LoadData();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
                currentPage--;
            _LoadData();
        }

        private void dvgPatients_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dvgPatients.ClearSelection();
                dvgPatients.Rows[e.RowIndex].Selected = true;
                dvgPatients.CurrentCell = dvgPatients.Rows[e.RowIndex].Cells[0];
            }
        }

        private void اعادةالتحميلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void عرضالتفاصيلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmPatientInfoDetailes(Convert.ToInt32( dvgPatients.CurrentRow.Cells[0].Value));
            
            frm.ShowDialog();
            
            _LoadData();
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PatientID = Convert.ToInt32(dvgPatients.CurrentRow.Cells[0].Value);
            if (MessageBox.Show("هل انت متأكد؟\nسيتم حذف المراجع وكل متعلقاته في النظام", "تحذير!", MessageBoxButtons.YesNo, icon: MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if(BusinessLogicLayer.BusinessLayer.DeletePatient(PatientID) == true)
                    MessageBox.Show("تم الحذف بنجاح!","معلومات!",MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                else
                    MessageBox.Show("فشل الحذف", "معلومات!", MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
            }
            _LoadData() ;
        }

        

        private void cmbxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxSearch.SelectedItem.ToString() == "")
            {
                txtbxSearch.Enabled = false;
                txtbxSearch.Text = "";
                _LoadData();
            }

            else
            {
                txtbxSearch.Enabled = true;
                txtbxSearch.Text = "";
                txtbxSearch.Focus();
                _LoadData();
            }
        }
        private void txtbxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbxSearch.SelectedItem.ToString() == "رقم الهاتف")
            {
                if ((!char.IsNumber(e.KeyChar)) && (!Char.IsControl(e.KeyChar)))
                    e.Handled = true;
            }
            else
            { e.Handled = false; }
        }

        private void txtbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbxSearch.Text))
            {
                _LoadData();
                return;
            }

            string column = "";
            if (cmbxSearch.Text == "الاسم")
                column = "FullName";
            else if (cmbxSearch.Text == "رقم الهاتف")
                column = "Phone";

            dvgPatients.DataSource = BusinessLogicLayer.BusinessLayer.clsPatients.SearchPatients(column, txtbxSearch.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddNewPatient();
            
            frm.ShowDialog();
            
            _LoadData();
        }

        private void اضافةمراجعجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddNewPatient();
            
            frm.ShowDialog();
            
            _LoadData();
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddNewPatient(Convert.ToInt32(dvgPatients.CurrentRow.Cells[0].Value));
            
            frm.ShowDialog();
            
            _LoadData();
        }

        private void dvgPatients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form frm = new frmPatientInfoDetailes(Convert.ToInt32(dvgPatients.CurrentRow.Cells[0].Value));

            frm.ShowDialog();

            _LoadData();
        }

        private void اضافةموعدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddAppointment(Convert.ToInt32(dvgPatients.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
            _LoadData();
        }

        private void عرضالمواعيدالخاصهبالمراجعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAppointments(Convert.ToInt32(dvgPatients.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
