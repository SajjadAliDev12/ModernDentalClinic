using BusinessLogicLayer;
using ModrenDentalClinic.Inventory;
using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using static BusinessLogicLayer.BusinessLayer;

namespace ModrenDentalClinic.InventoryPage
{
    public partial class FrmInventory : Form
    {
        private int _selectedID = -1;
        private Form _frm;

        public FrmInventory(Form frm)
        {
            InitializeComponent();
            _frm = frm;
        }

        private void FrmInventory_Load(object sender, EventArgs e)
        {
            LoadInventory();
            CheckLowStock();
            dgvInventory.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgvInventory_RowPrePaint);
        }

        private void LoadInventory()
        {
            dgvInventory.DataSource = clsInventory.GetAll();
            dgvInventory.Columns["ItemID"].HeaderText = "الرقم";
            dgvInventory.Columns["ItemName"].HeaderText = "اسم المادة";
            dgvInventory.Columns["Quantity"].HeaderText = "الكمية";
            dgvInventory.Columns["MinQuantity"].HeaderText = "الحد الأدنى";
            dgvInventory.Columns["ExpiryDate"].HeaderText = "تاريخ الانتهاء";
            dgvInventory.Columns["DateOfPurchase"].HeaderText = "تاريخ الشراء";
            dgvInventory.ClearSelection();
            dgvInventory.Refresh();
            foreach (DataGridViewRow r in dgvInventory.Rows)
            {
                if (r.Cells["Quantity"].Value != null && r.Cells["MinQuantity"].Value != null)
                {
                    int qty = Convert.ToInt32(r.Cells["Quantity"].Value);
                    int min = Convert.ToInt32(r.Cells["MinQuantity"].Value);
                    if (qty <= min)
                    {
                        r.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 200, 200);
                        r.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkRed;
                    }
                }
            }
        }

        private void CheckLowStock()
        {
            DataTable low = clsInventory.GetLowStock();
            if (low.Rows.Count > 0)
            {
                string msg = "تنبيه: المواد التالية قريبة من النفاد:\n\n";
                foreach (DataRow r in low.Rows)
                    msg += $"{r["ItemName"]} (الكمية: {r["Quantity"]})\n";
                MessageBox.Show(msg, "تحذير المخزون", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dgvInventory_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvInventory.ClearSelection();
                dgvInventory.Rows[e.RowIndex].Selected = true;
                dgvInventory.CurrentCell = dgvInventory.Rows[e.RowIndex].Cells[0];
            }
        }
        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvInventory.Rows[e.RowIndex];
                _selectedID = Convert.ToInt32(row.Cells["ItemID"].Value);
                
            }
        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if (_selectedID == -1)
            {
                MessageBox.Show("اختر مادة أولاً", "تنبيه");
                return;
            }
            Form frm = new frmEditItem(_selectedID);
            frm.ShowDialog();
                LoadInventory();
                
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedID == -1)
            {
                MessageBox.Show("اختر مادة أولاً", "تنبيه");
                return;
            }

            if (MessageBox.Show("هل تريد حذف هذه المادة؟", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (clsInventory.Delete(_selectedID))
                {
                    MessageBox.Show("تم الحذف", "نجاح");
                    LoadInventory();
                    
                }
                else MessageBox.Show("فشل في الحذف", "خطأ");
            }
        }

        

        // هذا الحدث يلون الصفوف قبل رسمها على الشاشة
        private void dgvInventory_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvInventory.Rows[e.RowIndex];

            if (row.Cells["Quantity"].Value == DBNull.Value || row.Cells["MinQuantity"].Value == DBNull.Value)
                return;

            int qty = Convert.ToInt32(row.Cells["Quantity"].Value);
            int min = Convert.ToInt32(row.Cells["MinQuantity"].Value);

            // لو الكمية أقل أو مساوية للحد الأدنى => يظهر باللون الأحمر الفاتح
            if (qty <= min)
            {
                row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 200, 200); // خلفية حمراء فاتحة
                row.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkRed;
                row.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Red;
                row.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            }
            else
            {
                // اللون العادي
                row.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                row.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                row.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
                row.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            }
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_selectedID == -1)
            {
                MessageBox.Show("اختر مادة أولاً", "تنبيه");
                return;
            }

            if (MessageBox.Show("هل تريد حذف هذه المادة؟", "تأكيد", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsInventory.Delete(_selectedID))
                {
                    MessageBox.Show("تم الحذف", "نجاح",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    LoadInventory();
                    
                }
                else MessageBox.Show("فشل في الحذف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddItem();
            frm.ShowDialog();
            LoadInventory();
        }

        private void إضافةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddItem();
            frm.ShowDialog();
            LoadInventory();
        }

        private void btncclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
