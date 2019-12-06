using DTO;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Karaoke.GUI_DangNhap
{
	public partial class frmDangNhap : Form
	{
		public frmDangNhap()
		{
			InitializeComponent();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			User.UserName = txtTenDangNhap.Text;
			User.Password = txtMatKhau.Text;
			if (BUS.UserBUS.DangNhap())
			{
				frmMain main = new frmMain();
				main.Visible = true;
			}
			else
			{
				MessageBox.Show("Đăng nhập thất bại. Xin kiểm tra lại", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar.Equals(Convert.ToChar(13)))
			{
				btnOK_Click(sender, e);
			}
		}

        private void chkRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRememberMe.Checked)
            {
                Properties.Settings.Default.UserName = txtTenDangNhap.Text;
                Properties.Settings.Default.PassWord = txtMatKhau.Text;
                Properties.Settings.Default.Save();
                //Remember password to registry
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Karaoke");
                key.SetValue("UserName", Properties.Settings.Default.UserName);
                key.SetValue("PassWord", Properties.Settings.Default.PassWord);
                key.Close();
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            //using Registry
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Karaoke");

            //if it does exist, retrieve the stored values  
            if (key != null)
            {
                txtTenDangNhap.Text = (string) key.GetValue("UserName");
                txtMatKhau.Text = (string)key.GetValue("PassWord");
                key.Close();
            }
            ////Using default setting
            //if (Properties.Settings.Default.UserName != string.Empty)
            //{
            //    txtTenDangNhap.Text = Properties.Settings.Default.UserName;
            //    txtMatKhau.Text = Properties.Settings.Default.PassWord;
            //}
        }
    }
}
