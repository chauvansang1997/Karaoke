using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Karaoke.NhaCungCap
{
	public partial class frmNhaCungCap : Form
	{
		DTO.NhaCungCap ncc;
		
		public frmNhaCungCap()
		{
			InitializeComponent();
			ncc = new DTO.NhaCungCap();
		}

		private void frmNhaCungCap_Load(object sender, EventArgs e)
		{
            int page = BUS.NhaCungCapBUS.DemNhaCungCap("");
			DataTable data = BUS.NhaCungCapBUS.XemNhaCungCap("",1, page);
			dgvDanhSachNCC.DataSource = data;
			dgvDanhSachNCC.Columns[0].HeaderCell.Value = "Mã NCC";
			dgvDanhSachNCC.Columns[1].HeaderCell.Value = "Tên NCC";
			dgvDanhSachNCC.Columns[2].HeaderCell.Value = "Loại hàng cung cấp";
			dgvDanhSachNCC.Columns[3].HeaderCell.Value = "Số điện thoại";
			dgvDanhSachNCC.Columns[4].HeaderCell.Value = "Địa chỉ";
			dgvDanhSachNCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvDanhSachNCC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvDanhSachNCC.ReadOnly = true;
			dataBinding(dgvDanhSachNCC.DataSource);
		}

		private void dataBinding(object data)
		{
			txtMaNCC.DataBindings.Clear();
			txtMaNCC.DataBindings.Add("Text", data, "maNCC");
			txtTenNCC.DataBindings.Clear();
			txtTenNCC.DataBindings.Add("Text", data, "tenNCC");
			txtLoaiHangCC.DataBindings.Clear();
			txtLoaiHangCC.DataBindings.Add("Text", data, "loaiHangCC");
			txtSDT.DataBindings.Clear();
			txtSDT.DataBindings.Add("Text", data, "sdt");
			txtDiaChi.DataBindings.Clear();
			txtDiaChi.DataBindings.Add("Text", data, "diaChi");
		}

		private void btnThemNCC_Click(object sender, EventArgs e)
		{
            panelChoice.Height = btnThemNCC.Height;
            panelChoice.Top = btnThemNCC.Top;
            ncc.MaNCC = txtMaNCC.Text;
			ncc.Ten = txtTenNCC.Text;
			ncc.LoaiHangCC = txtLoaiHangCC.Text;
			ncc.SDT = txtSDT.Text;
			ncc.DiaChi = txtDiaChi.Text;
			if (BUS.NhaCungCapBUS.ThemNCC(ncc))
			{
				MessageBox.Show("Thêm thành công NCC");
				frmNhaCungCap_Load(sender, e);
			}
			else
			{
				MessageBox.Show("Thêm nhà cung cấp thất bại");
				return;
			}
			
		}

		private void btnCapNhatNCC_Click(object sender, EventArgs e)
		{
            panelChoice.Height = btnCapNhatNCC.Height;
            panelChoice.Top = btnCapNhatNCC.Top;

            ncc.MaNCC = txtMaNCC.Text;
			ncc.Ten = txtTenNCC.Text;
			ncc.LoaiHangCC = txtLoaiHangCC.Text;
			ncc.SDT = txtSDT.Text;
			ncc.DiaChi = txtDiaChi.Text;

			if (BUS.NhaCungCapBUS.CapNhatNCC(ncc))
			{
				MessageBox.Show("Cập nhật thành công NCC");
				frmNhaCungCap_Load(sender, e);
			}
			else
			{
				MessageBox.Show("Cập nhật nhà cung cấp thất bại");
				return;
			}
		}

		private void btnXoaNCC_Click(object sender, EventArgs e)
		{
   //         panelChoice.Height = btnXoaNCC.Height;
   //         panelChoice.Top = btnXoaNCC.Top;
   //         ncc.MaNCC = txtMaNCC.Text;
			//if (BUS.NhaCungCapBUS.XoaNCC(ncc))
			//{
			//	MessageBox.Show("Xoá thành công NCC");
			//	frmNhaCungCap_Load(sender, e);
			//}
			//else
			//{
			//	MessageBox.Show("Xoá nhà cung cấp thất bại");
			//	return;
			//}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}
    }
}
