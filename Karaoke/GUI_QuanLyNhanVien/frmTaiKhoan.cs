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
            if (txtTenTK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (txtTenTK.Text.Length > 20)
            {
                MessageBox.Show("Tên tài khoản đã vượt quá 20 ký tự, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (BUS.TaiKhoanBUS.KiemTraTaiKhoan(txtTenTK.Text ))
            {
                MessageBox.Show("Tên tài khoản đã tồn tại, vui lòng chọn tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (txtMatKhau.Text.Length > 20)
            {
                MessageBox.Show("Mật khẩu đã vượt quá 20 ký tự, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!BUS.TaiKhoanBUS.TaoTaiKhoan(new DTO.TaiKhoan() { TenTaiKhoan = txtTenTK.Text, MatKhau = txtMatKhau.Text }))
            {
                MessageBox.Show("Tạo tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                MessageBox.Show("Tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
                return;
            }
        }
    }
}
