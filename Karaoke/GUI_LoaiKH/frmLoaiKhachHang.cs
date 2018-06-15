using Karaoke.KhachHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Karaoke.GUI_LoaiKH
{
	public partial class frmLoaiKhachHang : Form
	{
		DTO.LoaiKhachHang loaiKhach;
		public frmLoaiKhachHang()
		{
			InitializeComponent();
			loaiKhach = new DTO.LoaiKhachHang();
		}

		private void btnThemLoaiKH_Click(object sender, EventArgs e)
		{
			
			try
			{
				loaiKhach.MaLoaiKH = int.Parse(txtMaLoaiKH.Text);

			}catch(Exception ex)
			{
				MessageBox.Show("Mã loại khách hàng chưa hợp lệ xin kiểm tra lại", "Thêm loại khách hàng",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}

			loaiKhach.TenLoaiKH = txtTenLoaiKH.Text;
			try
			{
				loaiKhach.MucKM = float.Parse(txtMucKM.Text);

			}
			catch (Exception ex)
			{
				MessageBox.Show("Mức khuyến mãi không hợp lại xin kiểm tra lại", "Thêm loại khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (BUS.LoaiKhachHangBUS.ThemLoaiKH(loaiKhach))
			{
				frmLoaiKhachHang_Load(sender, e);
				MessageBox.Show("Thêm loại khách hàng thành công", "Thêm loại khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Thêm loại khách hàng thất bại", "Thêm loại khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void btnCapNhatLoaiKH_Click(object sender, EventArgs e)
		{
			loaiKhach.MaLoaiKH = int.Parse(txtMaLoaiKH.Text);
			loaiKhach.TenLoaiKH = txtTenLoaiKH.Text;
			loaiKhach.MucKM = float.Parse(txtMucKM.Text);
			if (BUS.LoaiKhachHangBUS.CapNhatLoaiKH(loaiKhach))
			{
				frmLoaiKhachHang_Load(sender, e);
				MessageBox.Show("Cập nhật loại khách hàng thành công", "Cập nhật loại khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Cập nhật loại khách hàng thất bại", "Cập nhật loại khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void btnXoaLoaiKH_Click(object sender, EventArgs e)
		{
			loaiKhach.MaLoaiKH = int.Parse(txtMaLoaiKH.Text);
			if (BUS.LoaiKhachHangBUS.XoaLoaiKH(loaiKhach))
			{
				frmLoaiKhachHang_Load(sender, e);
				MessageBox.Show("Xoá loại khách hàng thành công", "Xoá loại khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Xoá loại khách hàng thất bại", "Xoá loại khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void frmLoaiKhachHang_Load(object sender, EventArgs e)
		{
			dgvDanhSachLoaiKH.DataSource = BUS.LoaiKhachHangBUS.LoadLoaiKH();
			dgvDanhSachLoaiKH.Columns[0].HeaderCell.Value = "Mã loại";
			dgvDanhSachLoaiKH.Columns[1].HeaderCell.Value = "Tên loại khách hàng ";
			dgvDanhSachLoaiKH.Columns[2].HeaderCell.Value = "Mức khuyến mãi";
			dgvDanhSachLoaiKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvDanhSachLoaiKH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvDanhSachLoaiKH.ReadOnly = true;
			dataBinding(dgvDanhSachLoaiKH.DataSource);
		}

		private void dataBinding(object dataSource)
		{
			txtMaLoaiKH.DataBindings.Clear();
			txtMaLoaiKH.DataBindings.Add("Text", dataSource, "maLoaiKH");
			txtTenLoaiKH.DataBindings.Clear();
			txtTenLoaiKH.DataBindings.Add("Text", dataSource, "tenLoaiKH");
			txtMucKM.DataBindings.Clear();
			txtMucKM.DataBindings.Add("Text", dataSource, "mucKM");
		}
	}
}
