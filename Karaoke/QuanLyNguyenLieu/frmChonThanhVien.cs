using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Karaoke
{
    public partial class frmChonThanhVien : Form
    {
        public DTO.KhachHang khachHang;
        public frmChonThanhVien()
        {
            InitializeComponent();
            khachHang = new DTO.KhachHang();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            DataTable comboData = BUS.LoaiKhachHangBUS.LoadLoaiKH();
            //cbLoaiKH.DisplayMember = "tenLoaiKH";
            //cbLoaiKH.ValueMember = "maLoaiKH";
            //cbLoaiKH.DataSource = comboData;

            dgvDanhSachKhachHang.DataSource = BUS.KhachHangBUS.XemThongTinKhachHang(new DTO.KhachHang() { Ten = "", SoDT = "" });
            dgvDanhSachKhachHang.Columns[0].HeaderCell.Value = "Mã khách hàng";
            dgvDanhSachKhachHang.Columns[1].HeaderCell.Value = "Họ tên khách hàng";
            dgvDanhSachKhachHang.Columns[2].HeaderCell.Value = "Mã loại";
            dgvDanhSachKhachHang.Columns[2].Visible = false;
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

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvDanhSachKhachHang.DataSource = BUS.KhachHangBUS.XemThongTinKhachHang(new DTO.KhachHang()
            { Ten = txtTenThanhVien.Text, SoDT = txtSoDienThoai.Text });
        }

        private void dgvDanhSachKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvDanhSachKhachHang.CurrentCell.RowIndex;
            khachHang.Ten = dgvDanhSachKhachHang[1, index].Value.ToString();
            khachHang.SoDT = dgvDanhSachKhachHang[5, index].Value.ToString();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
