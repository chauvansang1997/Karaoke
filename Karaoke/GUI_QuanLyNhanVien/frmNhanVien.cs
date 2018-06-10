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

        private void LoadDataTable()
        {
            dGVDSNV.DataSource = BUS.NhanVienBUS.LoadNhanVien();

        }

        public void LoadComboBox()
        {
            cbxMaCVU.DisplayMember = "MaCV";
            cbxMaCVU.ValueMember = "MaCV";
            cbxMaCVU.DataSource = BUS.ChucVuBUS.LoadMaChucVu();
        }

        public frmNhanVien()
        {
            InitializeComponent();
            LoadDataTable();
            LoadComboBox();
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            frmTaiKhoan TaoTaiKhoan = new frmTaiKhoan();
            TaoTaiKhoan.ShowDialog();
            if (TaoTaiKhoan.ShowDialog() != DialogResult.OK)
            {
                txtTaiKhoan.Text = TaoTaiKhoan.TheValue;
            }
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            dGVDSNV.DataSource = BUS.NhanVienBUS.TraCuuNhanVien(new DTO.NhanVien() { MaNV = txtMaNV.Text, HoTen = txtTenNV.Text, SoDienThoai = txtSDT.Text, DiaChi = txtDiaChi.Text }, cbxMaCVU.Text, txtTaiKhoan.Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtTaiKhoan.Text == "" || cbxMaCVU.Text == "" || txtTenNV.Text == "" || txtSDT.Text == "" || txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (BUS.NhanVienBUS.KiemTraNhanVien(txtMaNV.Text))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại, vui lòng chọn lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!BUS.TaiKhoanBUS.KiemTraTaiKhoan(txtTaiKhoan.Text))
            {
                MessageBox.Show("Tài khoản đăng nhập không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!BUS.NhanVienBUS.ThemNhanVien(new DTO.NhanVien() { MaNV = txtMaNV.Text, HoTen = txtTenNV.Text, SoDienThoai = txtSDT.Text, DiaChi = txtDiaChi.Text }, cbxMaCVU.Text, txtTaiKhoan.Text))
            {
                MessageBox.Show("Thêm nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LoadDataTable();
                return;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtTaiKhoan.Text == "" || cbxMaCVU.Text == "" || txtTenNV.Text == "" || txtSDT.Text == "" || txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!BUS.NhanVienBUS.CapNhatNhanVien(new DTO.NhanVien() { MaNV = txtMaNV.Text, HoTen = txtTenNV.Text, SoDienThoai = txtSDT.Text, DiaChi = txtDiaChi.Text }, cbxMaCVU.Text))
            {
                MessageBox.Show("Cập nhật nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LoadDataTable();
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!BUS.NhanVienBUS.XoaNhanVien(txtMaNV.Text, txtTaiKhoan.Text))
            {
                MessageBox.Show("Xóa nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LoadDataTable();
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dGVDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dGVDSNV.Rows[e.RowIndex];

                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtTaiKhoan.Text = row.Cells[1].Value.ToString();
                cbxMaCVU.Text = row.Cells[2].Value.ToString();
                txtTenNV.Text = row.Cells[3].Value.ToString();
                txtSDT.Text = row.Cells[4].Value.ToString();
                txtDiaChi.Text = row.Cells[5].Value.ToString();
            }
        }
    }
}
