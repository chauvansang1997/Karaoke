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
			if(txtTenKH.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng");
                return;
            }
            if (DTO.Utility.IsContainsText(txtSDT.Text) || txtSDT.Text != "")
            {
                MessageBox.Show("Bạn phải nhập sai định dạng số điện thoại");
                return;
            }
            
		}

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            DataTable comboData = BUS.LoaiKhachHangBUS.LoadLoaiKH();
            cbLoaiKH.DisplayMember = "tenLoaiKH";
            cbLoaiKH.ValueMember = "maLoaiKH";
            cbLoaiKH.DataSource = comboData;

            dgvDanhSachKhachHang.DataSource = BUS.KhachHangBUS.XemThongTinKhachHang(new DTO.KhachHang() { Ten = "",SoDT =""});
			dgvDanhSachKhachHang.Columns[0].HeaderCell.Value = "Mã khách hàng";
			dgvDanhSachKhachHang.Columns[1].HeaderCell.Value = "Họ tên khách hàng";
			dgvDanhSachKhachHang.Columns[2].HeaderCell.Value = "Mã loại";
			dgvDanhSachKhachHang.Columns[2].Visible= false;
			dgvDanhSachKhachHang.Columns[3].HeaderCell.Value = "Loại khách hàng";
			dgvDanhSachKhachHang.Columns[4].HeaderCell.Value = "Số điểm tích lũy";
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

			txtSDT.DataBindings.Clear();
			txtSDT.DataBindings.Add("Text", dataSource, "sdt");
		}

		private void btnThemKhachHang_Click(object sender, EventArgs e)
		{
            panelChoice.Height = btnThemKhachHang.Height;
            panelChoice.Top = btnThemKhachHang.Top;

            khachHang.Ten = txtTenKH.Text;
		
			khachHang.SoDT = txtSDT.Text;
			if (BUS.KhachHangBUS.ThemKhachHangThanhVien(khachHang) != "")
			{
				MessageBox.Show("Thêm khách hàng thành công", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
				frmKhachHang_Load(sender, e);
			}
			else
			{
				MessageBox.Show("Thêm khách hàng đã tồn tại!!!", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void btnCapNhatKhachHang_Click(object sender, EventArgs e)
		{
            panelChoice.Height = btnCapNhatKhachHang.Height;
            panelChoice.Top = btnCapNhatKhachHang.Top;

            khachHang.Ma = dgvDanhSachKhachHang.CurrentRow.Cells[0].Value.ToString();
			khachHang.Ten = txtTenKH.Text;

			khachHang.SoDT = txtSDT.Text;
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
            panelChoice.Height = btnXoaKhachHang.Height;
            panelChoice.Top = btnXoaKhachHang.Top;

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
