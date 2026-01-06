using BusinessLogicLayer;
using System;
using System.Data;
using System.Windows.Forms;
using static BusinessLogicLayer.BusinessLayer;

namespace ModrenDentalClinic.Users
{
    public partial class FrmUsers : Form
    {
        private int _selectedID = -1;

        public FrmUsers()
        {
            InitializeComponent();
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            LoadUsers();
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnAdd.Visible = false;
            btnCancel .Visible = false;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.MultiSelect = false;
        }

        private void LoadUsers()
        {
            dgvUsers.DataSource = clsUsers.GetAll();
            dgvUsers.Columns["UserID"].HeaderText = "الرقم";
            dgvUsers.Columns["Username"].HeaderText = "اسم المستخدم";
            dgvUsers.Columns["Role"].HeaderText = "الدور";
            dgvUsers.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(cmbRole.Text))
            {
                MessageBox.Show("يرجى ملء جميع الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (clsUsers.Add(txtUsername.Text, txtPassword.Text, cmbRole.Text))
            {
                MessageBox.Show("تمت الإضافة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
                ClearForm();
            }
            else
            {
                MessageBox.Show("فشل في الإضافة، تأكد من أن اسم المستخدم غير مكرر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("الباسورد لا يمكن ان يكون فارغاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("اسم المستخدم لا يمكن ان يكون فارغاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_selectedID == -1)
            {
                MessageBox.Show("يرجى اختيار مستخدم أولاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("هل انت متاكد من تعديل البيانات؟","تأكيد",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                if (clsUsers.Update(_selectedID, txtUsername.Text, txtPassword.Text, cmbRole.Text))
            {
                MessageBox.Show("تم التحديث بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnUpdate.Visible = false;
                    btnCancel.Visible = false;
                    LoadUsers();
                    ClearForm();
            }
            else
            {
                MessageBox.Show("فشل في التحديث", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedID == -1)
            {
                MessageBox.Show("يرجى اختيار مستخدم أولاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("هل تريد حذف هذا المستخدم؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (clsUsers.Delete(_selectedID))
                {
                    MessageBox.Show("تم الحذف بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
                    ClearForm();
                    btnDelete.Visible = false;
                }
                else
                {
                    MessageBox.Show("لا يمكن حذف هذا المستخدم، قد يكون هو المستخدم الأخير في النظام", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnDelete.Visible = false;
                }
                
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
                _selectedID = Convert.ToInt32(row.Cells["UserID"].Value);
                //txtUsername.Text = row.Cells["Username"].Value.ToString();
                //cmbRole.Text = row.Cells["Role"].Value.ToString();
                //txtPassword.Text = "";
            }
        }

        private void ClearForm()
        {
            _selectedID = -1;
            txtUsername.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = -1;
            dgvUsers.ClearSelection();
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = true;
            btnCancel.Visible = true;
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = true;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if(txtUsername.Text.Length > 0 && btnUpdate.Visible != true)
                btnAdd.Visible = true;
            else btnAdd.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = false;
            btnUpdate.Visible = false;
        }
    }
}
