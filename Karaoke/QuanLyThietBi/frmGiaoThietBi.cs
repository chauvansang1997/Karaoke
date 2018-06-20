using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Karaoke.QuanLyThietBi
{
    public partial class frmGiaoThietBi : Form
    {
        private string phieuDatHang;
        public frmGiaoThietBi(string phieuDatHang)
        {
            this.phieuDatHang = phieuDatHang;
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (BUS.ThietBiBUS.GiaoHang(phieuDatHang, txtTenNguoi.Text))
            {
                MessageBox.Show("Lưu thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra!. Vui lòng mời nhân viên kỹ thuật kiểm tra!!!");
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }
    }
}
