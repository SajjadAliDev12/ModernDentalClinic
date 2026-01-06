using BusinessLogicLayer;
using Microsoft.Win32;
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
    public partial class frmLogin : Form
    {
        string RegPath = @"HKEY_CURRENT_USER\Software\DentalClinic";
        string Key = "1234567890123456";
        public frmLogin()
        {
            InitializeComponent();
            string Username = Registry.GetValue(RegPath, "UserName", null) as string;
            string Password = Registry.GetValue(RegPath, "Password", null) as string;
            if (Username != null || Password != null)
            {
                txtbxUserName.Text = Username;
                txtbxPassword.Text = BusinessLayer.clsHashing.Decrypt(Password, Key);
                chkbxRemeberme.Checked = true;
            }
            else
            {
                chkbxRemeberme.Checked = false;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string role = "";
            if (BusinessLayer.clsUsers.Login(txtbxUserName.Text, txtbxPassword.Text, ref role))
            {
                Global.Username = txtbxUserName.Text;
                Global.Role = role;
                if (chkbxRemeberme.Checked)
                {
                    Registry.SetValue(RegPath, "UserName", txtbxUserName.Text);
                    string encPass = BusinessLayer.clsHashing.Encrypt(txtbxPassword.Text, Key);
                    Registry.SetValue(RegPath, "Password", encPass);
                }
                else
                {
                    Registry.SetValue(RegPath, "UserName", null);
                    Registry.SetValue(RegPath, "Password", null);
                }

                Form frm = new MainForm();
                this.Hide();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void frmLogin_Shown(object sender, EventArgs e)
        {
            btnSignIn.Focus();
        }
    }
}
