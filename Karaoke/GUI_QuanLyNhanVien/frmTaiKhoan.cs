using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace Karaoke.GUI_QuanLyNhanVien
{
    public partial class frmTaiKhoan : Form
    {
		TaiKhoan taiKhoan = new TaiKhoan();
        public frmTaiKhoan()
        {
            InitializeComponent();
        }
    
        public string TheValue
        {
            get { return txtTenTK.Text; }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
			if(txtTenTK.Text.Length!=0 && txtMatKhau.Text.Length != 0) {
				taiKhoan.TenTaiKhoan = txtTenTK.Text;
				taiKhoan.MatKhau = txtMatKhau.Text;
				if (BUS.TaiKhoanBUS.TaoTaiKhoan(taiKhoan))
				{
					MessageBox.Show("Tạo tài khoản thành công", "Tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Dispose();
				}
				else
				{
					MessageBox.Show("Tạo tài khoản thất bại", "Tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
        }
    }
}
