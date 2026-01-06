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
    public partial class frmAppointments : Form
    {
        private int _id = -1;
        public frmAppointments()
        {
            InitializeComponent();
            LoadData();
        }
        public frmAppointments(int ID)
        {
            InitializeComponent();
            LoadData(ID);
            this._id = ID;
        }
        private void LoadData()
        {
            dataGridView1.DataSource = BusinessLogicLayer.BusinessLayer.clsAppointments.GetAll();
            

        }
        public void LoadData(int ID)
        {
            BusinessLogicLayer.BusinessLayer.clsPatients p1 = BusinessLogicLayer.BusinessLayer.clsPatients.GetPatientByID(ID);

            if (p1 != null)
            {
                lblList.Text = p1.FullName;
                dataGridView1.DataSource = BusinessLogicLayer.BusinessLayer.clsAppointments.GetByPatient(ID);
            }
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (ToolStripItem item in contextMenuStrip1.Items)
                    item.Enabled = true;
            }
            else
            {
                foreach (ToolStripItem item in contextMenuStrip1.Items)
                    item.Enabled = false;
            }
        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form frm = new frmAppointmentDetailes(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
        }

        private void عرضالتفاصيلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAppointmentDetailes(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            
            frm.ShowDialog();
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                if (MessageBox.Show("سيتم حذف هذا الموعد\nهل انت متاكد", "تحذير!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (BusinessLogicLayer.BusinessLayer.clsAppointments.Delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)))
                    {
                        MessageBox.Show("تم الحذف بنجاح!", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (_id != -1)
                            LoadData(_id);
                        else
                            LoadData();
                    }
                
                    else
                        MessageBox.Show("فشل حذف الموعد!", "فشل", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                return;
        }

        private void contxEdit_Click(object sender, EventArgs e)
        {
            Form frm = new frmEditAppointment(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
        }
    }
}
