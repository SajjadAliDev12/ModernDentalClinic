using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BusinessLogicLayer.BusinessLayer;

namespace ModrenDentalClinic.Inventory
{
    public partial class frmAddItem : Form
    {
        public frmAddItem()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                if (clsInventory.Add(txtName.Text, (int)numQty.Value, (int)numMin.Value, dtpExp.Value, dtpBuy.Value))
                {
                    MessageBox.Show("تمت الإضافة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else MessageBox.Show("فشل في الإضافة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("يجب اضافة اسم المادة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btncclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
