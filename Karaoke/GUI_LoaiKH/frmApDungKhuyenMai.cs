using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Karaoke.GUI_LoaiKH
{
    public partial class frmApDungKhuyenMai : Form
    {
        private bool bSua;
        private bool bThem;
        private const int pageSize = 10;
        private int pageNumber;
        private int totalPage;
        private int ma;
        private BindingSource bindingSource = new BindingSource();
        public frmApDungKhuyenMai()
        {
            InitializeComponent();
            khoiTao();
        }

        private void khoiTao()
        {
            bSua = false;
            bThem = false;
            pageNumber = 1;
            txtPageNumber.Text = "1";
            totalPage = BUS.KhuyenMaiBUS.DemKhuyenMai("", -1);
            totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();
            dGVDanhSach.DataSource = BUS.KhuyenMaiBUS.XemKhuyenMai("", -1, pageNumber, pageSize);
            this.dGVLoaiKhachHang.DataSource = bindingSource;
            bindingSource.Add(new LoaiKhachHang());
            bindingSource.RemoveAt(0);
            this.dGVLoaiKhachHang.Columns["MucKM"].HeaderText = "Mức khuyến mãi";
            this.dGVLoaiKhachHang.Columns["TenLoaiKH"].HeaderText = "Tên loại khách hàng";
            this.dGVLoaiKhachHang.Columns["MaLoaiKH"].Visible = false;
            this.dGVLoaiKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AddGridTableStyle();
        }


        private void AddGridTableStyle()
        {
            DataGridViewCellStyle cell = new DataGridViewCellStyle
            {
                BackColor = Color.Bisque,
                //  SelectionBackColor = Color.Teal,
                //   SelectionForeColor = Color.PaleGreen,
            };
            this.dGVDanhSach.BackColor = Color.GhostWhite;
            this.dGVDanhSach.ForeColor = Color.MidnightBlue;
            this.dGVDanhSach.BackgroundColor = Color.GhostWhite;
            this.dGVDanhSach.GridColor = Color.RoyalBlue;
            this.dGVDanhSach.AlternatingRowsDefaultCellStyle = cell;
            this.dGVDanhSach.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            this.dGVDanhSach.Columns["MaKhuyenMai"].Visible = false;
            this.dGVDanhSach.Columns["TenKhuyenMai"].HeaderText = "Tên khuyến mãi";
            this.dGVDanhSach.Columns["NgayBatDau"].HeaderText = "Ngày bắt đầu";
            this.dGVDanhSach.Columns["NgayBatDau"].DefaultCellStyle.Format = "MM/dd/yyyy HH:mm";
            this.dGVDanhSach.Columns["NgayKetThuc"].HeaderText = "Ngày bắt kết thúc";
            this.dGVDanhSach.Columns["NgayKetThuc"].DefaultCellStyle.Format = "MM/dd/yyyy HH:mm";

           
            cmbLoaiKHTK.DataSource = BUS.LoaiKhachHangBUS.LoadLoaiKH();
            cmbLoaiKHTK.DisplayMember = "TENLOAIKH";

            //this.dataGrid1.TableStyles.Add(table);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bSua = true;
            enableButton(false);

            enableControls(true);
        }


        private void enableButton1(bool enable)
        {
            btnHuy.Enabled = enable;
            btnLuu.Enabled = enable;
        }
        private void enableButton(bool enable)
        {
            btnThem.Enabled = enable;
            btnXoa.Enabled = enable;
            btnSua.Enabled = enable;
        }
        private void enableControls(bool enable)
        {
            txtTenKM.Enabled = enable;
            dTPNgayBatDau.Enabled = enable;
            dTPNgayKetThuc.Enabled = enable;
            btnLuu.Enabled = enable;
            btnHuy.Enabled = enable;
            btnThemLoaiKH.Enabled = enable;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnFind_MouseHover(object sender, EventArgs e)
        {
            this.btnFind.FlatAppearance.BorderSize = 2;
        }

        private void btnThem_MouseHover(object sender, EventArgs e)
        {
            this.btnThem.FlatAppearance.BorderSize = 2;
        }

        private void btnXoa_MouseHover(object sender, EventArgs e)
        {
            this.btnXoa.FlatAppearance.BorderSize = 2;
        }

        private void btnSua_MouseHover(object sender, EventArgs e)
        {
            this.btnSua.FlatAppearance.BorderSize = 2;
        }

        private void btnThoat_MouseHover(object sender, EventArgs e)
        {
            this.btnThoat.FlatAppearance.BorderSize = 2;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            enableControls(true);
            enableButton(false);
            // enableButton1(true);
            //for (int i = 0; i < bindingSource.Count; i++)
            //{

            //}
            while (bindingSource.Current != null)
            {
                bindingSource.RemoveCurrent();
            }
           // bindingSource.Filter = "[MaLoaiKH] = [MaLoaiKH]";
          
         
           // bindingSource.DataSource = null ;
           // bindingSource.Add(new LoaiKhachHang());

            bThem = true;
            txtTenKM.Text = "";

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

            loadDanhSach();
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
            loadDanhSach();
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();
            loadDanhSach();

        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            pageNumber = totalPage;
            txtPageNumber.Text = pageNumber.ToString();
            loadDanhSach();
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
            loadDanhSach();
        }

        private void dGVDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dGVDanhSach.CurrentCell != null)
            {
                int index = dGVDanhSach.CurrentCell.RowIndex;
                ma = int.Parse(dGVDanhSach[0, index].Value.ToString());
                txtTenKM.Text = dGVDanhSach[1, index].Value.ToString();
                dTPNgayBatDau.Value = (DateTime)dGVDanhSach[2, index].Value;
                dTPNgayKetThuc.Value = (DateTime)dGVDanhSach[3, index].Value;

                bindingSource.DataSource = KhuyenMaiBUS.XemChiTiet(ma, null);
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (bThem)
            {
                List<int> listMaLoaiKhachHang = new List<int>();
                List<float> listMucKhuyenMai = new List<float>();
                List<LoaiKhachHang> list = new List<LoaiKhachHang>();
                for (int i = 0; i < bindingSource.Count; i++)
                {
                    LoaiKhachHang loaiKhachHang = (LoaiKhachHang)bindingSource[i];
                    listMaLoaiKhachHang.Add(loaiKhachHang.MaLoaiKH);
                    listMucKhuyenMai.Add(loaiKhachHang.SoTienTichLuy);
                }
               
                if (BUS.KhuyenMaiBUS.ThemkhuyenMai(new DTO.KhuyenMai()
                {
                    NgayBatDau=dTPNgayBatDau.Value,
                    NgayKetThuc=dTPNgayKetThuc.Value,
                    TenKhuyenMai = txtTenKM.Text,

                }, listMaLoaiKhachHang, listMucKhuyenMai))
                {
                    MessageBox.Show("Thêm nguyên liệu thành công");
                }
                bThem = false;
                enableControls(false);
                enableButton(true);
                resetDanhSach();
            }
            else if (bSua)
            {
                List<LoaiKhachHang> list = (List<LoaiKhachHang>)bindingSource.DataSource;
                List<int> listMaLoaiKhachHang = list.Select(l => l.MaLoaiKH).ToList();
                List<int> listMucKhuyenMai = list.Select(l => l.SoTienTichLuy).ToList();
                if (BUS.KhuyenMaiBUS.CapNhatkhuyenMai(new DTO.KhuyenMai()
                {

                    TenKhuyenMai = txtTenKM.Text,

                }, listMaLoaiKhachHang, listMucKhuyenMai))
                {
                    MessageBox.Show("Sửa nguyên liệu thành công");
                }
                bSua = false;
                enableControls(false);
                enableButton(true);
                resetDanhSach();
            }
        }
        private void resetDanhSach()
        {
            bSua = false;
            bThem = false;
            pageNumber = 1;
            txtPageNumber.Text = "1";
            DataRow row = ((DataRowView)cmbLoaiKHTK.SelectedValue).Row;
            totalPage = BUS.KhuyenMaiBUS.DemKhuyenMai("", (int)(row)["MALOAIKH"]);
            totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();

            dGVDanhSach.DataSource = BUS.KhuyenMaiBUS.XemKhuyenMai(txtTenKMTK.Text, (int)(row)["MALOAIKH"], pageNumber, pageSize);

            AddGridTableStyle();
        }
        private void loadDanhSach()
        {
            DataRow row = ((DataRowView)cmbLoaiKHTK.SelectedValue).Row;
            dGVDanhSach.DataSource = BUS.KhuyenMaiBUS.XemKhuyenMai(txtTenKMTK.Text, (int)(row)["MALOAIKH"], pageNumber, pageSize);
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (cmbLoaiKHTK.SelectedValue != null)
            {
                pageNumber = 1;
                txtPageNumber.Text = "1";
                DataRow row = ((DataRowView)cmbLoaiKHTK.SelectedValue).Row;
                totalPage = BUS.KhuyenMaiBUS.DemKhuyenMai("", (int)(row)["MALOAIKH"]);
                totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
                txtTotalPage.Text = totalPage.ToString();
                dGVDanhSach.DataSource = BUS.KhuyenMaiBUS.XemKhuyenMai(txtTenKMTK.Text, (int)(row)["MALOAIKH"], pageNumber, pageSize);
            }
            else
            {
                pageNumber = 1;
                txtPageNumber.Text = "1";
                totalPage = BUS.KhuyenMaiBUS.DemKhuyenMai("", -1);
                totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
                txtTotalPage.Text = totalPage.ToString();
                dGVDanhSach.DataSource = BUS.KhuyenMaiBUS.XemKhuyenMai("", -1, pageNumber, pageSize);


            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (BUS.KhuyenMaiBUS.XoaKhuyenMai(ma))
            {
                MessageBox.Show("Xóa khuyến mãi thành công");
                resetDanhSach();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            enableControls(false);
            enableButton(true);
        }

        private void dGVDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThemLoaiKhachHang_Click(object sender, EventArgs e)
        {
            if (bThem)
            {
                frmLoaiKhachHangKM loaiKhachHangKM = new frmLoaiKhachHangKM(bindingSource, -1);
                loaiKhachHangKM.ShowDialog();
            }
            else
            {
                frmLoaiKhachHangKM loaiKhachHangKM = new frmLoaiKhachHangKM(bindingSource, ma);
                loaiKhachHangKM.ShowDialog();
            }
        }

        private void dGVLoaiKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex ==0 && e.RowIndex >= 0)
            {
                dGVLoaiKhachHang.Rows.RemoveAt(e.RowIndex);

            }
        }
    }
}
