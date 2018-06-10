using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Karaoke.QuanLyPhanCong
{
	public partial class frmPhanCong : Form
	{
		private static String SELECT_MANV = "SELECT DISTINCT MANV,TENNV FROM NHANVIEN";
		private static String SELECT_TENCA = "SELECT DISTINCT MACA,TENCA FROM CALAMVIEC";
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
			tableNhanVien= BUS.PhanCongBUS.SelectAll(SELECT_MANV);
			cbMaNV.DataSource = tableNhanVien;

			cbTenNV.DropDownStyle = ComboBoxStyle.DropDownList;
			cbTenNV.DisplayMember = "tenNV";
			cbTenNV.ValueMember = "maNV";
			cbTenNV.DataSource = tableNhanVien;

			cbTenCa.DropDownStyle = ComboBoxStyle.DropDownList;
			cbTenCa.DisplayMember = "tenCa";
			cbTenCa.ValueMember = "maCa";
			cbTenCa.DataSource = BUS.PhanCongBUS.SelectAll(SELECT_TENCA);
			
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

	}
}
