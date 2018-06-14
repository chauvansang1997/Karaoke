using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using Karaoke.NhaCungCap;

namespace Karaoke.ThietBi
{
	public partial class frmThietBi : Form
	{
		DTO.ThietBi thietBi;
		public frmThietBi()
		{
			InitializeComponent();
			thietBi = new DTO.ThietBi();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void tpNhapThietBi_Click(object sender, EventArgs e)
		{
			
		}

		private void btnThemTB_Click(object sender, EventArgs e)
		{
			thietBi.MaThietBi = txtMaTB.Text;
			thietBi.TenThietBi = txtTenTB.Text;
			thietBi.MaNCC = cbMaNCC.SelectedValue.ToString();
			thietBi.DVT = cbDVT.SelectedValue.ToString();
			thietBi.DonGia = txtDonGiaTB.Text;

			if (BUS.ThietBiBUS.ThemThietBi(thietBi))
			{
				MessageBox.Show("Thêm thành công");
			}
			else
			{
				MessageBox.Show("Thêm thất bại");
			}
		}

		private void btnThemNCC_Click(object sender, EventArgs e)
		{
			frmNhaCungCap nhaCungCap = new frmNhaCungCap();
			nhaCungCap.Visible = true;
		}

		private void btnThemDVT_Click(object sender, EventArgs e)
		{

		}

		private void btnThemPhieuNhapTB_Click(object sender, EventArgs e)
		{

		}

		private void btnCapNhatPhieuNhapTB_Click(object sender, EventArgs e)
		{

		}

		private void btnXoaPhieuNhapTB_Click(object sender, EventArgs e)
		{

		}
	}
}
