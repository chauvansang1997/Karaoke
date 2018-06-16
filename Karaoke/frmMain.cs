
using Karaoke.GUI_BaoCaoDoanhThu;
using Karaoke.GUI_QuanLyNhanVien;
using Karaoke.GuiMonAn;
using Karaoke.KhachHang;
using Karaoke.NguyenLieu;
using Karaoke.NhaCungCap;
using Karaoke.PhanCong;
using Karaoke.PhongKaoraoke;
using Karaoke.QuanLyPhanCong;
using Karaoke.QuanLySanPham;
using Karaoke.QuanLyThietBi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karaoke
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void suaSanPham_Click(object sender, EventArgs e)
        {
            frmSamPham samPham = new frmSamPham();
            samPham.ShowDialog();
        }

        private void suaNguyenLieu_Click(object sender, EventArgs e)
        {
            frmNguyenLieu nguyenLieu = new frmNguyenLieu();
            nguyenLieu.ShowDialog();
        }

        private void nhapKho_Click(object sender, EventArgs e)
        {
            frmNhapNguyenLieu nhapNguyenLieu= new frmNhapNguyenLieu();
            nhapNguyenLieu.ShowDialog();
        }

        private void nhapKhoSanPham_Click(object sender, EventArgs e)
        {
            frmNhapSanPham nhapSanPham = new frmNhapSanPham();
            nhapSanPham.ShowDialog();
        }

        private void baoCaoTonKho_Click(object sender, EventArgs e)
        {
            frmBaoCaoTonKho frmBaoCao = new frmBaoCaoTonKho();
            frmBaoCao.ShowDialog();
        }

        private void baoCaoDoanhThu_Click(object sender, EventArgs e)
        {
			frmBaoCaoDoanhThu baoCaoDoanhThu = new frmBaoCaoDoanhThu();
			baoCaoDoanhThu.ShowDialog();
		}

        private void datPhongMenu_Click(object sender, EventArgs e)
        {
            frmPhongKaraoke phongKaraoke = new frmPhongKaraoke();
            phongKaraoke.ShowDialog();
        }

        private void nhanDatTiecMenu_Click(object sender, EventArgs e)
        {
            frmDatTiec datTiec = new frmDatTiec();
            datTiec.ShowDialog();
        }

        private void khachHangMenu_Click(object sender, EventArgs e)
        {
			frmKhachHang khachHang = new frmKhachHang();
			khachHang.ShowDialog();
		}

        private void nhanVienMenu_Click(object sender, EventArgs e)
        {
            frmNhanVien nhanVien = new frmNhanVien();
            nhanVien.ShowDialog();
        }

		private void phanCongMenu_Click(object sender, EventArgs e)
		{
			frmBaoCaoLuongTong luongTong = new frmBaoCaoLuongTong();
			luongTong.ShowDialog();
		}

		private void phanCongItem_Click(object sender, EventArgs e)
		{
			frmPhanCong phanCong = new frmPhanCong();
			phanCong.ShowDialog();
		}

		private void caTrucItem_Click(object sender, EventArgs e)
		{
			frmCaTruc caTruc = new frmCaTruc();
			caTruc.ShowDialog();
		}

		private void baoCaoLuongMenu_Click(object sender, EventArgs e)
		{
			try
			{
				frmBaoCaoLuongTong baoCaoLuongTong = new frmBaoCaoLuongTong();
				baoCaoLuongTong.ShowDialog();
			}
			catch(Exception ex)
			{
				MessageBox.Show("Có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void nhapMonAnMenu_Click(object sender, EventArgs e)
        {
            frmMonAn monAn = new frmMonAn();
            monAn.ShowDialog();
        }

        private void nhapkhoThietBi_Click(object sender, EventArgs e)
        {
            frmNhapThietBi thietBi = new frmNhapThietBi();
            thietBi.ShowDialog();
        }

        private void chinhSuaTietBi_Click(object sender, EventArgs e)
        {
            frmThietBi thietBi = new frmThietBi();
            thietBi.ShowDialog();
        }

        private void nhaCungCapMenu_Click(object sender, EventArgs e)
        {
            frmNhaCungCap nhaCungCap = new frmNhaCungCap();
            nhaCungCap.ShowDialog();
        }

		private void nhanViemMenuItem_Click(object sender, EventArgs e)
		{
			frmNhanVien nhanVien = new frmNhanVien();
			nhanVien.ShowDialog();
		}

		private void phanCongMenu_Click_1(object sender, EventArgs e)
		{
			frmPhanCong phanCong = new frmPhanCong();
			phanCong.ShowDialog();
		}

		private void caTrucMenu_Click(object sender, EventArgs e)
		{
			frmCaTruc caTruc = new frmCaTruc();
			caTruc.ShowDialog();
		}
	}
}
