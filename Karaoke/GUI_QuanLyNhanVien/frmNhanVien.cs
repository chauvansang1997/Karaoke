using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karaoke.GUI_QuanLyNhanVien
{
    public partial class frmNhanVien : Form
    {
		NhanVien nhanVien;
        private void LoadDataTable()
        {
            dGVDSNV.DataSource = BUS.NhanVienBUS.LoadNhanVien();
        }

        public void LoadComboBox()
        {
            cbxMaCVU.DisplayMember = "TenCV";
            cbxMaCVU.ValueMember = "MaCV";
            cbxMaCVU.DataSource = BUS.ChucVuBUS.LoadMaChucVu();
        }

        public frmNhanVien()
        {
            InitializeComponent();
			nhanVien = new NhanVien();
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            frmTaiKhoan TaoTaiKhoan = new frmTaiKhoan();
            if (TaoTaiKhoan.ShowDialog() != DialogResult.OK)
            {
                txtTaiKhoan.Text = TaoTaiKhoan.TheValue;
            }
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            dGVDSNV.DataSource = BUS.NhanVienBUS.TraCuuNhanVien(new DTO.NhanVien() { MaNV = txtMaNV.Text, HoTen = txtTenNV.Text, SoDienThoai = txtSDT.Text, DiaChi = txtDiaChi.Text }, cbxMaCVU.Text, txtTaiKhoan.Text);
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void frmNhanVien_Load(object sender, EventArgs e)
		{
			LoadDataTable();
			dGVDSNV.DataSource = BUS.NhanVienBUS.LoadNhanVien();
			bindingData();
			dGVDSNV.Columns[0].HeaderCell.Value = "Mã NV";
			dGVDSNV.Columns[1].HeaderCell.Value = "Họ tên";
			dGVDSNV.Columns[2].HeaderCell.Value = "SĐT";
			dGVDSNV.Columns[3].HeaderCell.Value = "Địa chỉ";
			dGVDSNV.Columns[4].HeaderCell.Value = "Mã CV";
			dGVDSNV.Columns[4].Visible = false;
			dGVDSNV.Columns[5].HeaderCell.Value = "Tên CV";
			dGVDSNV.Columns[6].HeaderCell.Value = "Tên TK";
			dGVDSNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dGVDSNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dGVDSNV.ReadOnly = true;
			bindingToCombox(dGVDSNV.DataSource);
		}

		private void bindingToCombox(object dataSource)
		{
			txtMaNV.DataBindings.Clear();
			txtMaNV.DataBindings.Add("Text", dataSource, "maNV");
			txtTenNV.DataBindings.Clear();
			txtTenNV.DataBindings.Add("Text", dataSource, "tenNV");
			txtSDT.DataBindings.Clear();
			txtSDT.DataBindings.Add("Text", dataSource, "sdt");
			txtDiaChi.DataBindings.Clear();
			txtDiaChi.DataBindings.Add("Text", dataSource, "diaChi");
			txtTaiKhoan.DataBindings.Clear();
			txtTaiKhoan.DataBindings.Add("Text", dataSource, "tenTK");
			cbxMaCVU.DataBindings.Clear();
			cbxMaCVU.DataBindings.Add("Text", dataSource, "tenCV");
		}

		private void bindingData()
		{
			DataTable tableChucVu = BUS.ChucVuBUS.LoadMaChucVu();
			cbxMaCVU.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxMaCVU.DisplayMember = "tenCV";
			cbxMaCVU.ValueMember = "maCV";
			cbxMaCVU.DataSource = tableChucVu;

		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			nhanVien.MaNV = txtMaNV.Text;
			nhanVien.HoTen = txtTenNV.Text;
			nhanVien.SoDienThoai = txtSDT.Text;
			nhanVien.DiaChi = txtDiaChi.Text;
			string maCV = cbxMaCVU.SelectedValue.ToString();
			string tenTK = txtTaiKhoan.Text.Trim();
			if (BUS.NhanVienBUS.ThemNhanVien(nhanVien, maCV, tenTK))
			{
				MessageBox.Show("Thêm nhân viên thành công", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
				frmNhanVien_Load(sender, e);
			}
			else
			{
				MessageBox.Show("Thêm nhân viên thất bại", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			nhanVien.MaNV = txtMaNV.Text;
			nhanVien.HoTen = txtTenNV.Text;
			nhanVien.SoDienThoai = txtSDT.Text;
			nhanVien.DiaChi = txtDiaChi.Text;
			string maCV = cbxMaCVU.SelectedValue.ToString();
			string tenTK = txtTaiKhoan.Text.Trim();
			if (BUS.NhanVienBUS.CapNhatNhanVien(nhanVien, maCV, tenTK))
			{
				MessageBox.Show("Cập nhật nhân viên thành công", "Cập nhật nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
				frmNhanVien_Load(sender, e);
			}
			else
			{
				MessageBox.Show("Cập nhật nhân viên thất bại", "Cập nhật nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			nhanVien.MaNV = txtMaNV.Text;
			nhanVien.HoTen = txtTenNV.Text;
			nhanVien.SoDienThoai = txtSDT.Text;
			nhanVien.DiaChi = txtDiaChi.Text;
			string maCV = cbxMaCVU.SelectedValue.ToString();
			string tenTK = txtTaiKhoan.Text.Trim();
			if (BUS.NhanVienBUS.XoaNhanVien(nhanVien.MaNV,tenTK))
			{
				MessageBox.Show("Xoá viên thành công", "Xoá nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
				frmNhanVien_Load(sender, e);
			}
			else
			{
				MessageBox.Show("Xoá nhân viên thất bại", "Xoá nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTuKhoa.Text;
            if (tuKhoa.Length <1)
            {
                frmNhanVien_Load(sender, e);
            }
            else
            {
                dGVDSNV.DataSource = BUS.NhanVienBUS.TimNhanVien(tuKhoa);
            }
        }
    }
}
