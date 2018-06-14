using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Karaoke.QuanLyPhanCong
{
	public partial class frmPhanCong : Form
	{
		String maNV = "";
		String maCa = "";
		DateTime ngay = DateTime.Now;
		String maNVCu = "";
		String maCaCu = "";
		DateTime ngayCu = DateTime.Now;

		DataTable tableNhanVien;
		public frmPhanCong()
		{
			InitializeComponent();
			bindingData();
		}

		private void bindingData()
		{
			cbMaNV.DropDownStyle = ComboBoxStyle.DropDownList;
			cbMaNV.DisplayMember = "maNV";
			cbMaNV.ValueMember = "maNV";
			tableNhanVien= BUS.PhanCongBUS.LayMaNV();
			cbMaNV.DataSource = tableNhanVien;

			cbTenNV.DropDownStyle = ComboBoxStyle.DropDownList;
			cbTenNV.DisplayMember = "tenNV";
			cbTenNV.ValueMember = "maNV";
			cbTenNV.DataSource = tableNhanVien;

			cbTenCa.DropDownStyle = ComboBoxStyle.DropDownList;
			cbTenCa.DisplayMember = "tenCa";
			cbTenCa.ValueMember = "maCa";
			cbTenCa.DataSource = BUS.PhanCongBUS.LayMaCa();
			
		}

		private void frmPhanCong_Load(object sender, EventArgs e)
		{
			dgvDanhSachPhanCong.DataSource = BUS.PhanCongBUS.LoadPhanCong();
			dgvDanhSachPhanCong.Columns[0].HeaderCell.Value = "Mã NV";
			dgvDanhSachPhanCong.Columns[1].HeaderCell.Value = "Họ tên";
			dgvDanhSachPhanCong.Columns[2].HeaderCell.Value = "Mã ca";
			dgvDanhSachPhanCong.Columns[2].Visible = false;
			dgvDanhSachPhanCong.Columns[3].HeaderCell.Value = "Tên ca";
			dgvDanhSachPhanCong.Columns[4].HeaderCell.Value = "Ngày";
			dgvDanhSachPhanCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvDanhSachPhanCong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvDanhSachPhanCong.ReadOnly = true;
			bindingToCombox(dgvDanhSachPhanCong.DataSource);

		}

		private void bindingToCombox(object dataSource)
		{
			cbMaNV.DataBindings.Clear();
			cbMaNV.DataBindings.Add("Text", dataSource, "maNV");
			cbTenNV.DataBindings.Clear();
			cbTenNV.DataBindings.Add("Text", dataSource, "tenNV");
			cbTenCa.DataBindings.Clear();
			cbTenCa.DataBindings.Add("Text", dataSource, "tenCa");
			dtpNgayPhanCong.DataBindings.Clear();
			dtpNgayPhanCong.DataBindings.Add("Text", dataSource, "ngay");
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			maNV = cbMaNV.SelectedValue.ToString();
			maCa = cbTenCa.SelectedValue.ToString();
			ngay = dtpNgayPhanCong.Value;
				if(BUS.PhanCongBUS.ThemPhanCong(maNV, maCa, ngay))
				{
					MessageBox.Show("Thêm nhân viên thành công", "Thêm phân công", MessageBoxButtons.OK, MessageBoxIcon.Information);
					frmPhanCong_Load(sender, e);
				}
				else
				{
					MessageBox.Show("Thêm nhân viên thất bại xin kiểm tra lại!", "Thêm phân công", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			maNV = cbMaNV.SelectedValue.ToString();
			maCa = cbTenCa.SelectedValue.ToString();
			ngay = dtpNgayPhanCong.Value;

			maNVCu = dgvDanhSachPhanCong.CurrentRow.Cells[0].Value.ToString();
			maCaCu = dgvDanhSachPhanCong.CurrentRow.Cells[2].Value.ToString();
			ngayCu = DateTime.Parse(dgvDanhSachPhanCong.CurrentRow.Cells[4].Value.ToString());
			if (BUS.PhanCongBUS.CapNhatPhanCong(maNVCu, maCaCu, ngayCu, maNV, maCa, ngay))
			{
				MessageBox.Show("Cập nhật phân công thành công", "Cập nhật phân công", MessageBoxButtons.OK, MessageBoxIcon.Information);
				frmPhanCong_Load(sender, e);
			}
			else
			{
				MessageBox.Show("Cập nhật phân công thất bại xin kiểm tra lại!", "Cập nhật phân công", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			maNVCu = "";
			maCaCu = "";
			ngayCu = DateTime.Now;
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			maNV = cbMaNV.SelectedValue.ToString();
			maCa = cbTenCa.SelectedValue.ToString();
			ngay = dtpNgayPhanCong.Value;
			if(ngay <= (DateTime.Now))
			{
				MessageBox.Show("Không được xoá ngày phân công nhỏ hơn hiện tại!", "Xoá phân công", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				if (BUS.PhanCongBUS.XoaPhanCong(maNV, maCa, ngay))
				{
					MessageBox.Show("Xoá phân công thành công", "Xoá phân công", MessageBoxButtons.OK, MessageBoxIcon.Information);
					frmPhanCong_Load(sender, e);
				}
				else
				{
					MessageBox.Show("Xoá phân công xin kiểm tra lại!", "Xoá phân công", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
		}
	}
}
