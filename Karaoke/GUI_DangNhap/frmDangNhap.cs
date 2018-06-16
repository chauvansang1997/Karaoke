using DTO;
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
	}
}
