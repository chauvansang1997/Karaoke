using BUS;
using DTO;
using Karaoke.GuiMonAn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Karaoke.PhongKaoraoke
{
    public partial class frmChonPhongKaraoke : Form
    {
        const int pageSize = 10;
        int pageNumber = 1;
        List<Phong> phongs = new List<Phong>();
        List<Phong> phongsDat = new List<Phong>();
        DTO.KhachHang khachHang;
        string maDatPhong;
        bool datPhongTruoc;
        frmPhongKaraoke phongKaraoke;
        public frmChonPhongKaraoke(DTO.KhachHang khachHang, frmPhongKaraoke phongKaraoke)
        {
            InitializeComponent();
            this.khachHang = khachHang;
            this.phongKaraoke = phongKaraoke;
            Init();
        }
        void LayoutDanhSachPhong() {
            dGVDanhSachPhong.Columns["GetKhachHang"].Visible = false;
    
        }
        void Init() {
            //lấy tất cả phòng đang trống hiện thị lên giao diện
            phongs = PhongBUS.XemPhong(0, pageSize, pageNumber);
            dGVDanhSachPhong.DataSource = phongs;
            LayoutDanhSachPhong();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dGVDanhSachPhong.CurrentCell != null) {
                Phong phong = phongs[dGVDanhSachPhong.CurrentCell.RowIndex];
                dGVDanhSachPhong.DataSource = null;
                dGVDanhSachChonPhong.DataSource = null;
                phongs.Remove(phong);
                phongsDat.Add(phong);
                phongsDat = phongsDat.OrderBy(o => o.Ten).ToList();
                dGVDanhSachChonPhong.DataSource = phongsDat;
                dGVDanhSachPhong.DataSource = phongs;
                dGVDanhSachChonPhong.Columns["GetKhachHang"].Visible = false;
                dGVDanhSachPhong.Columns["GetKhachHang"].Visible = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (dGVDanhSachChonPhong.CurrentCell != null)
            {
                Phong phong = phongsDat[dGVDanhSachChonPhong.CurrentCell.RowIndex];
                dGVDanhSachPhong.DataSource = null;
                dGVDanhSachChonPhong.DataSource = null;
                phongsDat.Remove(phong);
                phongs.Add(phong);
                phongs = phongs.OrderBy(o => o.Ten).ToList();
                dGVDanhSachChonPhong.DataSource = phongsDat;
                dGVDanhSachPhong.DataSource = phongs;
                dGVDanhSachChonPhong.Columns["GetKhachHang"].Visible = false;
                dGVDanhSachPhong.Columns["GetKhachHang"].Visible = false;
            }
        }

        void DatPhong() {

        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            maDatPhong = BUS.PhongBUS.GhiNhanDatPhong(phongsDat, new ThongTinDatPhong() {
                khachHang = khachHang,
                nhanVien = User.NhanVien,            
            });
            MessageBox.Show("Đặt phong thành công");
           // phongKaraoke.
            this.Close();
        }

        private void btnGoiMon_Click(object sender, EventArgs e)
        {

            //if (dGVDanhSachChonPhong.CurrentCell != null)
            //{
            //    Phong phong = phongsDat[dGVDanhSachChonPhong.CurrentCell.RowIndex];
            //    frmGoiMon goiMon = new frmGoiMon(maDatPhong, phong.Ten);
            //    goiMon.ShowDialog();
               
            //}
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }
    }
}
