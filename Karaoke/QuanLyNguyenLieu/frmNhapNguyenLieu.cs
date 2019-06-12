using DTO;
using Karaoke.QuanLyNguyenLieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Karaoke.NguyenLieu
{
    public partial class frmNhapNguyenLieu : Form
    {
        private const int pageSize = 5;
        private int pageNumber;
        private int totalPage;
        private BindingSource bindingSource = new BindingSource();
        public frmNhapNguyenLieu()
        {
            InitializeComponent();
            khoiTao();
        }

        private void khoiTao()
        {

            List<DTO.NhaCungCap> list = BUS.NhaCungCapBUS.XemNhaCungCap();
            cmbNhaCungCap.DataSource = list;
            cmbNhaCungCap.DisplayMember = "Ten";
            cmbNhaCungCap.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbNhaCungCap.AutoCompleteSource = AutoCompleteSource.ListItems;


            cmbTKNhaCC.DataSource = new List<DTO.NhaCungCap>(list);
            cmbTKNhaCC.DisplayMember = "Ten";
            cmbTKNhaCC.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbTKNhaCC.AutoCompleteSource = AutoCompleteSource.ListItems;

            rbChuaGiao.Checked = true;
            pageNumber = 1;
            txtPageNumber.Text = "1";
            totalPage = BUS.NguyenLieuBUS.DemPhieuNhapNguyenLieu(rbChuaGiao.Checked ? 0 : 1);
            totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();
            bindingSource.DataSource = BUS.NguyenLieuBUS.XemPhieuNhapHang(rbChuaGiao.Checked ? 0 : 1, pageNumber, pageSize);
            dGVPhieuNhap.DataSource = bindingSource;
            dGVPhieuNhap.Columns["SoPhieu"].HeaderText = "Số phiếu";
            dGVPhieuNhap.Columns["MaNhanVien"].Visible = false;
            dGVPhieuNhap.Columns["NgayDat"].HeaderText = "Ngày đặt";
            dGVPhieuNhap.Columns["TenNhaCungCap"].HeaderText = "Tên nhà cung cấp";
            dGVPhieuNhap.Columns["MaNhaCungCap"].Visible = false;
            dGVPhieuNhap.Columns["NgayGiao"].HeaderText = "Ngày giao";
            dGVPhieuNhap.Columns["ThanhTien"].HeaderText = "Thành tiền";
            dGVPhieuNhap.Columns["NguoiGiao"].HeaderText = "Người giao hàng";
            dGVPhieuNhap.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
            dGVPhieuNhap.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lập phiếu không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DTO.NhaCungCap nhaCungCap = ((DTO.NhaCungCap)cmbNhaCungCap.SelectedValue);
                PhieuNhapHang soPhieuNhap = BUS.NguyenLieuBUS.LapPhieuNhap(nhaCungCap.MaNCC, User.NhanVien.MaNV);
                if (soPhieuNhap != null)
                {
                    MessageBox.Show("Lập phiếu thành công");
                    frmNhapCTNguyenLieu nhapCTNguyenLieu = new frmNhapCTNguyenLieu(nhaCungCap, soPhieuNhap);
                    nhapCTNguyenLieu.ShowDialog();
                    pageNumber = 1;
                    txtPageNumber.Text = "1";
                    totalPage = BUS.NguyenLieuBUS.DemPhieuNhapNguyenLieu(rbChuaGiao.Checked ? 0 : 1);
                    totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
                    txtTotalPage.Text = totalPage.ToString();
                    bindingSource.DataSource = BUS.NguyenLieuBUS.XemPhieuNhapHang(rbChuaGiao.Checked ? 0 : 1, pageNumber, pageSize);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra. Hãy báo cho nhà cung cấp phần mềm để biết thêm chi tiết");
                }
            }
            else if (result == DialogResult.No)
            {
                //...
            }
            else
            {
                //...
            }
        }

        private void rbDaGiao_CheckedChanged(object sender, EventArgs e)
        {
            pageNumber = 1;
            txtPageNumber.Text = "1";
            totalPage = BUS.NguyenLieuBUS.DemPhieuNhapNguyenLieu(rbChuaGiao.Checked ? 0 : 1);
            totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();
            bindingSource.DataSource = BUS.NguyenLieuBUS.XemPhieuNhapHang(rbChuaGiao.Checked ? 0 : 1, pageNumber, pageSize);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dGVPhieuNhap.CurrentRow != null)
            {
                int index = dGVPhieuNhap.CurrentRow.Index;
                DTO.NhaCungCap nhaCungCap = ((DTO.NhaCungCap)cmbNhaCungCap.SelectedValue);
                PhieuNhapHang soPhieuNhap = (PhieuNhapHang)bindingSource[index];
                frmNhapCTNguyenLieu nhapCTNguyenLieu = new frmNhapCTNguyenLieu(nhaCungCap, soPhieuNhap);
                nhapCTNguyenLieu.ShowDialog();
                bindingSource.DataSource = BUS.NguyenLieuBUS.XemPhieuNhapHang(rbChuaGiao.Checked ? 0 : 1, pageNumber, pageSize);
            }

        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            if (dGVPhieuNhap.CurrentRow != null)
            {
                int index = dGVPhieuNhap.CurrentRow.Index;
                string soPhieuNhap = dGVPhieuNhap[0, index].Value.ToString();
                frmGiaoNguyenLieu giaoNguyenLieu = new frmGiaoNguyenLieu(soPhieuNhap);
                //  frmGiaoSanPham giaoSanPham = new frmGiaoSanPham(soPhieuNhap);
                giaoNguyenLieu.ShowDialog();
                khoiTao();
            }

        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (pageNumber + 1 > totalPage)
            {
                pageNumber = 1;
            }
            else
            {
                ++pageNumber;
            }
            txtPageNumber.Text = pageNumber.ToString();
            bindingSource.DataSource = BUS.NguyenLieuBUS.XemPhieuNhapHang(rbChuaGiao.Checked ? 0 : 1, pageNumber, pageSize);
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (pageNumber - 1 == 0)
            {
                pageNumber = 1;
            }
            else
            {
                --pageNumber;
            }
            txtPageNumber.Text = pageNumber.ToString();
            bindingSource.DataSource = BUS.NguyenLieuBUS.XemPhieuNhapHang(rbChuaGiao.Checked ? 0 : 1, pageNumber, pageSize);
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();
            bindingSource.DataSource = BUS.NguyenLieuBUS.XemPhieuNhapHang(rbChuaGiao.Checked ? 0 : 1, pageNumber, pageSize);
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            pageNumber = totalPage;
            txtPageNumber.Text = pageNumber.ToString();
            bindingSource.DataSource = BUS.NguyenLieuBUS.XemPhieuNhapHang(rbChuaGiao.Checked ? 0 : 1, pageNumber, pageSize);
        }

        private void txtPageNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToUInt32(txtPageNumber.Text) <= totalPage)
                {
                    pageNumber = (int)Convert.ToUInt32(txtPageNumber.Text);

                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {

                txtPageNumber.Text = pageNumber.ToString();
            }
            bindingSource.DataSource = BUS.NguyenLieuBUS.XemPhieuNhapHang(rbChuaGiao.Checked ? 0 : 1, pageNumber, pageSize);
        }
    }
}