using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Karaoke.PhanCong
{
	public partial class frmCaTruc : Form
	{
		CaLamViec ca;
        TimeSpan GioBD, GioKT;
		public frmCaTruc()
		{
			InitializeComponent();
			ca = new CaLamViec();
            dtpGioBD.Format = DateTimePickerFormat.Time;
            dtpGioBD.ShowUpDown = true;

			dtpGioKT.Format = DateTimePickerFormat.Time;
            dtpGioKT.ShowUpDown = true;
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			panelChoice.Height = btnThem.Height;
			panelChoice.Top = btnThem.Top;
			ca.MaCa = int.Parse(txtMaCa.Text);
			ca.TenCa = txtTenCa.Text;
			ca.GioBD = dtpGioBD.Value;
			ca.GioKT = dtpGioBD.Value;
			ca.TienLuong = int.Parse(txtTienLuong.Text);
			if (BUS.CaLamViecBUS.ThemCaLamViec(ca))
			{
				MessageBox.Show("Thêm ca thành công", "Thêm ca", MessageBoxButtons.OK, MessageBoxIcon.Information);
				frmCatTruc_Load(sender, e);
			}
			else
			{
				MessageBox.Show("Thêm ca thất bại", "Thêm ca", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			panelChoice.Height = btnCapNhat.Height;
			panelChoice.Top = btnCapNhat.Top;

			ca.MaCa = int.Parse(txtMaCa.Text);
            ca.TenCa = txtTenCa.Text;
            ca.GioBD = dtpGioBD.Value;
            ca.GioKT = dtpGioKT.Value;
			ca.TienLuong = int.Parse(txtTienLuong.Text);
			if (BUS.CaLamViecBUS.CapNhatCaLamViec(ca))
			{
				MessageBox.Show("Cập nhật ca thành công", "Cập nhật ca", MessageBoxButtons.OK, MessageBoxIcon.Information);
				frmCatTruc_Load(sender, e);

			}
			else
			{
				MessageBox.Show("Cập nhật ca thất bại", "Cập nhật ca", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			panelChoice.Height = btnXoa.Height;
			panelChoice.Top = btnXoa.Top;

			ca.MaCa = int.Parse(txtMaCa.Text);
			ca.TenCa = txtTenCa.Text;
			ca.GioBD = dtpGioBD.Value;
			ca.GioKT =dtpGioKT.Value;
			ca.TienLuong = int.Parse(txtTienLuong.Text);
			if (BUS.CaLamViecBUS.XoaCaLamViec(ca))
			{
				MessageBox.Show("Xoá ca thành công", "Xoá ca", MessageBoxButtons.OK, MessageBoxIcon.Information);
				frmCatTruc_Load(sender, e);
			}
			else
			{
				MessageBox.Show("Xoá ca thất bại", "Xoá ca", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void frmCatTruc_Load(object sender, EventArgs e)
		{
			dgvDanhSachCaTruc.DataSource = BUS.CaLamViecBUS.LoadCaLamViec();
			dgvDanhSachCaTruc.Columns[0].HeaderCell.Value = "Mã ca";
			dgvDanhSachCaTruc.Columns[1].HeaderCell.Value = "Tên ca";
			dgvDanhSachCaTruc.Columns[2].HeaderCell.Value = "Giờ BD";
			dgvDanhSachCaTruc.Columns[2].DefaultCellStyle.Format = "HH:mm:ss";
			dgvDanhSachCaTruc.Columns[3].HeaderCell.Value = "Giờ KT";
			dgvDanhSachCaTruc.Columns[3].DefaultCellStyle.Format = "HH:mm:ss";
			dgvDanhSachCaTruc.Columns[4].HeaderCell.Value = "Tiền lương";
			dgvDanhSachCaTruc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvDanhSachCaTruc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvDanhSachCaTruc.ReadOnly = true;
			dataBinding(dgvDanhSachCaTruc.DataSource);
		}

		private void dataBinding(object dataSource)
		{
			txtMaCa.DataBindings.Clear();
			txtMaCa.DataBindings.Add("Text", dataSource, "maCa");
			txtTenCa.DataBindings.Clear();
			txtTenCa.DataBindings.Add("Text", dataSource, "tenCa");
			dtpGioBD.DataBindings.Clear();
			dtpGioBD.DataBindings.Add("Text", dataSource, "gioBD");
			dtpGioKT.DataBindings.Clear();
			dtpGioKT.DataBindings.Add("Text", dataSource, "gioKT");
			txtTienLuong.DataBindings.Clear();
			txtTienLuong.DataBindings.Add("Text", dataSource, "tienLuong");

		}
	}
}
