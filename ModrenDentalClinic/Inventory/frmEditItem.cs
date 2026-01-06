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
    public partial class frmEditItem : Form
    {
        private int _id;
        public frmEditItem(int ID)
        {
            InitializeComponent();
            _id = ID;
            DataTable dt = BusinessLogicLayer.BusinessLayer.clsInventory.GetAItemByID(_id);
            DataRow dataRow = dt.Rows[0];
            txtName.Text = dataRow["ItemName"].ToString();
            numQty.Value = Convert.ToInt32(dataRow["Quantity"]);
            numMin.Value = Convert.ToInt32(dataRow["MinQuantity"]);
            dtpExp.Value = dataRow["ExpiryDate"] == DBNull.Value ? DateTime.Today : Convert.ToDateTime(dataRow["ExpiryDate"]);
            dtpBuy.Value = dataRow["DateOfPurchase"] == DBNull.Value ? DateTime.Today : Convert.ToDateTime(dataRow["DateOfPurchase"]);
        }

        private void btncclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (clsInventory.Update(_id, txtName.Text, (int)numQty.Value, (int)numMin.Value, dtpExp.Value, dtpBuy.Value))
            {
                MessageBox.Show("تم التحديث", "نجاح",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else MessageBox.Show("فشل في التحديث", "خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
