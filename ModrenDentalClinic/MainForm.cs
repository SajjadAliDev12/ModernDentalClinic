using ModrenDentalClinic.Appointments;
using ModrenDentalClinic.Patients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModrenDentalClinic
{
    public partial class MainForm : Form
    {
        private Form _frm = new frmLogin() ;
        ToolTip tip = new ToolTip(); 

        public MainForm()
        {
            InitializeComponent();

            tip.OwnerDraw = true;
            lblUserName.Text ="مرحباً يا "+Global.Username.ToString();
            tip.Popup += Tip_Popup;
            tip.Draw += Tip_Draw;

            tip.SetToolTip(btnAppointment, "المواعيد");
            tip.SetToolTip(btnPatients, "المراجعين");
            tip.SetToolTip(btnUsers, "المستخدمين");
            tip.SetToolTip(btnSetting, "الاعدادات");
            tip.SetToolTip(btnInventory, "المخزن");
            tip.SetToolTip(btnSignOut, "تسجيل الخروج");

        }

        private void Tip_Popup(object sender, PopupEventArgs e)
        {
            string text = tip.GetToolTip(e.AssociatedControl);
            SizeF size;
            using (Graphics g = e.AssociatedControl.CreateGraphics())
            {
                size = g.MeasureString(text, new Font("Tahoma", 14, FontStyle.Bold));
            }
            e.ToolTipSize = new Size((int)size.Width + 10, (int)size.Height + 4);
        }

        private void Tip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.Graphics.FillRectangle(SystemBrushes.Info, e.Bounds);
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, e.Bounds.Width - 1, e.Bounds.Height - 1));
            e.Graphics.DrawString(e.ToolTipText, new Font("Tahoma", 14, FontStyle.Bold), Brushes.Black, e.Bounds);
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
            if (_frm != null || !_frm.IsDisposed)
            {
                _frm.Show();
                _frm.BringToFront();
            }
            else {_frm = new frmLogin(); 
            _frm.ShowDialog();
            }
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            Form frm = new FrmPatients();
            frm.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Form frm = new ModrenDentalClinic.Users.FrmUsers();
            frm.ShowDialog();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Form frm = new ModrenDentalClinic.InventoryPage.FrmInventory(this);
            frm.ShowDialog();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            Form frm = new frmAppointments();
            frm.ShowDialog();
        }
    }

}
