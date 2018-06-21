using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Karaoke.QuanLyThietBi
{
    public partial class frmNhapThietBi : Form
    {
        private const int pageSize = 5;
        private int pageNumber;
        private int totalPage;
        private BindingSource bindingSource = new BindingSource();
        public frmNhapThietBi()
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
            totalPage = BUS.ThietBiBUS.DemPhieuNhapHang(rbChuaGiao.Checked ? 0 : 1);
            totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();

            // bindingSource.Add(new PhieuNhapHang());
            bindingSource.DataSource = BUS.ThietBiBUS.XemPhieuNhapHang(rbChuaGiao.Checked ? 0 : 1, pageNumber, pageSize);
            dGVPhieuNhap.DataSource = bindingSource;
            //bindingSource.Clear();
            dGVPhieuNhap.Columns["SoPhieu"].HeaderText = "Số phiếu";
            dGVPhieuNhap.Columns["MaNhanVien"].Visible = false;
            dGVPhieuNhap.Columns["MaNhaCungCap"].Visible = false;
            dGVPhieuNhap.Columns["ThanhTien"].Visible = false;
            dGVPhieuNhap.Columns["NgayDat"].HeaderText = "Ngày đặt";
            dGVPhieuNhap.Columns["TenNhaCungCap"].HeaderText = "Tên nhà cung cấp";
            dGVPhieuNhap.Columns["NgayGiao"].HeaderText = "Ngày giao";
            dGVPhieuNhap.Columns["ThanhTien"].HeaderText = "Thành tiền";
            dGVPhieuNhap.Columns["NguoiGiao"].HeaderText = "Người giao hàng";
            dGVPhieuNhap.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
            dGVPhieuNhap.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            dGVPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void reset()
        {
            rbChuaGiao.Checked = true;
            pageNumber = 1;
            txtPageNumber.Text = "1";
            totalPage = BUS.ThietBiBUS.DemPhieuNhapHang(rbChuaGiao.Checked ? 0 : 1);
            totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();

            // bindingSource.Add(new PhieuNhapHang());
            bindingSource.DataSource = BUS.ThietBiBUS.XemPhieuNhapHang(rbChuaGiao.Checked ? 0 : 1, pageNumber, pageSize);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lập đơn đặt hàng không không?", "Xác nhận", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                DTO.NhaCungCap nhaCungCap = ((DTO.NhaCungCap)cmbNhaCungCap.SelectedValue);
                PhieuNhapHang phieuNhap = BUS.ThietBiBUS.LapPhieuNhap(nhaCungCap.MaNCC, "NV001");
                if (phieuNhap != null)
                {
                    MessageBox.Show("Lập phiếu thành công");
                    rbChuaGiao.Checked = true;
                    pageNumber = 1;
                    txtPageNumber.Text = "1";
                    totalPage = BUS.ThietBiBUS.DemPhieuNhapHang(rbChuaGiao.Checked ? 0 : 1);
                    totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
                    txtTotalPage.Text = totalPage.ToString();

                    // bindingSource.Add(new PhieuNhapHang());
                    bindingSource.DataSource = BUS.ThietBiBUS.XemPhieuNhapHang(rbChuaGiao.Checked ? 0 : 1, pageNumber, pageSize);
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
            totalPage = BUS.ThietBiBUS.DemPhieuNhapHang(rbChuaGiao.Checked ? 0 : 1);
            totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();
            bindingSource.DataSource = BUS.ThietBiBUS.XemPhieuNhapHang(rbChuaGiao.Checked ? 0 : 1, pageNumber, pageSize);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dGVPhieuNhap.CurrentRow != null)
            {
                int index = dGVPhieuNhap.CurrentRow.Index;
                DTO.NhaCungCap nhaCungCap = ((DTO.NhaCungCap)cmbNhaCungCap.SelectedValue);
                PhieuNhapHang phieuNhapHang = (PhieuNhapHang)bindingSource[index];
                string soPhieuNhap = dGVPhieuNhap[0, index].Value.ToString();

                frmNhapChiTietThietBi chiTietThietBi = new frmNhapChiTietThietBi(nhaCungCap,phieuNhapHang);
                chiTietThietBi.ShowDialog();
              //  frmNhapChiTietSanPham chiTietSanPham = new
              //frmNhapChiTietSanPham(nhaCungCap, phieuNhapHang);
              // chiTietSanPham.ShowDialog();
            }

        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            if (dGVPhieuNhap.CurrentRow != null)
            {
                int index = dGVPhieuNhap.CurrentRow.Index;
                string soPhieuNhap = dGVPhieuNhap[0, index].Value.ToString();
                frmGiaoThietBi giaoThietBi = new frmGiaoThietBi(soPhieuNhap);
                giaoThietBi.ShowDialog();
                //  frmGiaoSanPham giaoSanPham = new frmGiaoSanPham(soPhieuNhap);
                //     giaoSanPham.ShowDialog();
                reset();
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
            bindingSource.DataSource = BUS.ThietBiBUS.XemPhieuNhapHang(rbChuaGiao.Checked ? 0 : 1, pageNumber, pageSize);
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
            bindingSource.DataSource = BUS.ThietBiBUS.XemPhieuNhapHang(rbChuaGiao.Checked ? 0 : 1, pageNumber, pageSize);
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();
            bindingSource.DataSource = BUS.ThietBiBUS.XemPhieuNhapHang(rbChuaGiao.Checked ? 0 : 1, pageNumber, pageSize);
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            pageNumber = totalPage;
            txtPageNumber.Text = pageNumber.ToString();
            bindingSource.DataSource = BUS.ThietBiBUS.XemPhieuNhapHang(rbChuaGiao.Checked ? 0 : 1, pageNumber, pageSize);
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
            bindingSource.DataSource = BUS.ThietBiBUS.XemPhieuNhapHang(rbChuaGiao.Checked ? 0 : 1, pageNumber, pageSize);
        }

        private void frmNhapSanPham_Load(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bindingSource.DataSource = BUS.ThietBiBUS.XemPhieuNhapHang(rbChuaGiao.Checked ? 0 : 1, pageNumber, pageSize);
        }
    }
}
