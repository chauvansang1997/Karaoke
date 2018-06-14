using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Karaoke.QuanLySanPham
{
    public partial class frmGiaoSanPham : Form
    {
        private string phieuDatHang;
        public frmGiaoSanPham(string phieuDatHang)
        {
            this.phieuDatHang = phieuDatHang;
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (BUS.SanPhamBUS.GiaoSanPham(phieuDatHang, txtTenNguoi.Text))
            {
                MessageBox.Show("Lưu thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra!. Vui lòng mời nhân viên kỹ thuật kiểm tra!!!");
            }
        }
    }
}
