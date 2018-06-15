using Karaoke.GUI_LoaiKH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Karaoke.KhachHang
{
	public partial class frmKhachHang : Form
	{
		DTO.KhachHang khachHang;
		public frmKhachHang()
		{
			InitializeComponent();
			khachHang = new DTO.KhachHang();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void btnThemLoaiKH_Click(object sender, EventArgs e)
		{
			frmLoaiKhachHang loaiKhachHang = new frmLoaiKhachHang();
			loaiKhachHang.Visible = true;
		}

		private void frmKhachHang_Load(object sender, EventArgs e)
		{
			DataTable comboData = BUS.LoaiKhachHangBUS.LoadLoaiKH();
			cbLoaiKH.DisplayMember = "tenLoaiKH";
			cbLoaiKH.ValueMember = "maLoaiKH";
			cbLoaiKH.DataSource = comboData;

			cbMucKM.DisplayMember = "mucKM";
			cbMucKM.ValueMember = "mucKM";
			cbMucKM.DataSource = comboData;

			dgvDanhSachKhachHang.DataSource = BUS.KhachHangBUS.LoadKhachHang();
			dgvDanhSachKhachHang.Columns[0].HeaderCell.Value = "Mã khách hàng";
			dgvDanhSachKhachHang.Columns[1].HeaderCell.Value = "Họ tên khách hàng";
			dgvDanhSachKhachHang.Columns[2].HeaderCell.Value = "Mã loại";
			dgvDanhSachKhachHang.Columns[2].Visible= false;
			dgvDanhSachKhachHang.Columns[3].HeaderCell.Value = "Loại khách hàng";
			dgvDanhSachKhachHang.Columns[4].HeaderCell.Value = "Mức KM";
			dgvDanhSachKhachHang.Columns[5].HeaderCell.Value = "Số ĐT";
			dgvDanhSachKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvDanhSachKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvDanhSachKhachHang.ReadOnly = true;
			dataBinding(dgvDanhSachKhachHang.DataSource);
		}

		private void dataBinding(object dataSource)
		{
			txtTenKH.DataBindings.Clear();
			txtTenKH.DataBindings.Add("Text", dataSource, "tenKH");
			cbLoaiKH.DataBindings.Clear();
			cbLoaiKH.DataBindings.Add("Text", dataSource, "tenLoaiKH");
			cbMucKM.DataBindings.Clear();
			cbMucKM.DataBindings.Add("Text", dataSource, "mucKM");
			txtSDT.DataBindings.Clear();
			txtSDT.DataBindings.Add("Text", dataSource, "sdt");
		}

		private void btnThemKhachHang_Click(object sender, EventArgs e)
		{
			khachHang.Ten = txtTenKH.Text;
			khachHang.LoaiKH = Convert.ToInt16(cbLoaiKH.SelectedValue.ToString());
			khachHang.SDT = txtSDT.Text;
			if (BUS.KhachHangBUS.ThemKhachHang(khachHang))
			{
				MessageBox.Show("Thêm khách hàng thành công", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
				frmKhachHang_Load(sender, e);
			}
			else
			{
				MessageBox.Show("Thêm khách hàng thất bại", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void btnCapNhatKhachHang_Click(object sender, EventArgs e)
		{
			khachHang.Ma = dgvDanhSachKhachHang.CurrentRow.Cells[0].Value.ToString();
			khachHang.Ten = txtTenKH.Text;
			khachHang.LoaiKH = Convert.ToInt16(cbLoaiKH.SelectedValue.ToString());
			khachHang.SDT = txtSDT.Text;
			if (BUS.KhachHangBUS.CapNhatKhachHang(khachHang))
			{
				MessageBox.Show("Cập nhật khách hàng thành công", "Cập nhật khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
				frmKhachHang_Load(sender, e);
			}
			else
			{
				MessageBox.Show("Cập nhật khách hàng thất bại", "Cập nhật khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void btnXoaKhachHang_Click(object sender, EventArgs e)
		{
			khachHang.Ma = dgvDanhSachKhachHang.CurrentRow.Cells[0].Value.ToString();
			if (BUS.KhachHangBUS.XoaKhachHang(khachHang))
			{
				MessageBox.Show("Xoá khách hàng thành công", "Xoá khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
				frmKhachHang_Load(sender, e);
			}
			else
			{
				MessageBox.Show("Xoá khách hàng thất bại", "Xoá khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}
	}
}
