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
    public partial class frmSuDungThietBi : Form
    {
        private bool bSua;
        private bool bThem;
        private const int pageSize = 10;
        private int pageNumber;
        private int totalPage;
        private string ma;
        private BindingSource bindingSource = new BindingSource();
        private BindingSource bindingSourceTemp = new BindingSource();
        public frmSuDungThietBi()
        {
            InitializeComponent();
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
            this.dGVDanhSach.Columns["MASUDUNG"].Visible = false;
            this.dGVDanhSach.Columns["LYDO"].HeaderText = "Lý do sử dụng thiết bị";
            this.dGVDanhSach.Columns["NGAY"].HeaderText = "Ngày sử dụng";
            this.dGVDanhSach.Columns["NGAY"].DefaultCellStyle.Format = "MM/dd/yyyy HH:mm";
            this.dGVThietBi.BackColor = Color.GhostWhite;
            this.dGVThietBi.ForeColor = Color.MidnightBlue;
            this.dGVThietBi.BackgroundColor = Color.GhostWhite;
            this.dGVThietBi.GridColor = Color.RoyalBlue;
            this.dGVThietBi.AlternatingRowsDefaultCellStyle = cell;
            this.dGVThietBi.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bSua = true;
            enableButton(false);

            enableControls(true);
        }
        private void frmSuDungThietBi_Load(object sender, EventArgs e)
        {
            bSua = false;
            bThem = false;
            pageNumber = 1;
            txtPageNumber.Text = "1";
            totalPage = BUS.ThietBiBUS.DemSuDungThietBi("", "");
            totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();
            dGVDanhSach.DataSource = BUS.ThietBiBUS.XemSuDungThietBi("", "", pageNumber, pageSize);

            bindingSource.Add(new ThietBiDataSource());
            dGVThietBi.DataSource = bindingSource;
            bindingSource.RemoveAt(0);
            this.dGVThietBi.Columns["MaThietBi"].Visible = false;
            this.dGVThietBi.Columns["TenThietBi"].HeaderText = "Tên thiết bị";
            this.dGVThietBi.Columns["SoLuong"].HeaderText = "Số lượng";
            this.dGVThietBi.Columns["TenNhaCungCap"].HeaderText = "Tên nhà cung cấp";
            this.dGVThietBi.Columns["DonGia"].HeaderText = "Đơn giá";
            AddGridTableStyle();
        }
        private void resetDanhSach()
        {
            bSua = false;
            bThem = false;
            pageNumber = 1;
            txtPageNumber.Text = "1";
            totalPage = BUS.ThietBiBUS.DemSuDungThietBi(txtLyDoSuDung.Text, txtTenKMTK.Text);
            totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();

            dGVDanhSach.DataSource = BUS.ThietBiBUS.XemSuDungThietBi(txtLyDoSuDung.Text, txtTenKMTK.Text, pageNumber, pageSize);

            AddGridTableStyle();
        }
        private void loadDanhSach()
        {
            dGVDanhSach.DataSource =
                BUS.ThietBiBUS.XemSuDungThietBi(txtLyDoSuDung.Text, txtTenKMTK.Text, pageNumber, pageSize);
        }
        private void enableButton1(bool enable)
        {
            btnHuy.Enabled = enable;
            btnLuu.Enabled = enable;
        }
        private void enableButton(bool enable)
        {

        }
        private void enableControls(bool enable)
        {

            btnLuu.Enabled = enable;
            btnHuy.Enabled = enable;
            txtLyDoSuDung.Enabled = enable;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnFind_MouseHover(object sender, EventArgs e)
        {
            this.btnFind.FlatAppearance.BorderSize = 2;
        }


        private void btnThoat_MouseHover(object sender, EventArgs e)
        {
            this.btnThoat.FlatAppearance.BorderSize = 2;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            enableControls(true);
            enableButton(false);
            bThem = true;
            while (bindingSource.Current != null)
            {
                bindingSource.RemoveCurrent();
            }
            while (bindingSourceTemp.Current != null)
            {
                bindingSourceTemp.RemoveCurrent();
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
                ma = dGVDanhSach[0, index].Value.ToString();
                txtLyDoSuDung.Text = dGVDanhSach[1, index].Value.ToString();
                List<ThietBiDataSource> list = BUS.ThietBiBUS.XemChiTietSuDungThietBi(ma);
                bindingSource.DataSource = list;
                bindingSourceTemp.DataSource = new List<ThietBiDataSource>(list);
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            List<string> thietBi = new List<string>();
            for (int i = 0; i < bindingSource.Count; i++)
            {
                thietBi.Add(((ThietBiDataSource)bindingSource[i]).MaThietBi);
            }
            List<string> soluong = new List<string>();
            for (int i = 0; i < bindingSource.Count; i++)
            {
                soluong.Add(((ThietBiDataSource)bindingSource[i]).SoLuong);
            }
            if (bThem)
            {

                if (BUS.ThietBiBUS.ThemSuDungThietBi(txtLyDoSuDung.Text, thietBi, soluong))
                {
                    MessageBox.Show("Thêm sử dụng thiết bị thành công");
                }
                bThem = false;
                enableControls(false);
                enableButton(true);
                resetDanhSach();
            }
            else if (bSua)
            {
                if (BUS.ThietBiBUS.CapNhatSuDungThietBi(ma, txtLyDoSuDung.Text, thietBi, soluong))
                {
                    MessageBox.Show("Sửa sử dụng thiết bị thành công");
                }
                bSua = false;
                enableControls(false);
                enableButton(true);
                resetDanhSach();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //     if (cmbNhaCC.SelectedValue != null)
            //     {
            //         pageNumber = 1;
            //         txtPageNumber.Text = "1";
            //         totalPage = BUS.ThietBiBUS.DemThietBi(txtTenNguyenLieu.Text, ((DTO.NhaCungCap)cmbNhaCC.SelectedValue).MaNCC);
            //         totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
            //         txtTotalPage.Text = totalPage.ToString();
            //         dGVDanhSach.DataSource =
            //BUS.ThietBiBUS.XemThietBiTable(txtTenNguyenLieu.Text, ((DTO.NhaCungCap)cmbNhaCC.SelectedValue).MaNCC, pageNumber, pageSize);
            //     }
            //     else
            //     {
            //         pageNumber = 1;
            //         txtPageNumber.Text = "1";
            //         totalPage = BUS.ThietBiBUS.DemThietBi(txtTenNguyenLieu.Text, "");
            //         totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
            //         txtTotalPage.Text = totalPage.ToString();
            //         dGVDanhSach.DataSource =
            //BUS.ThietBiBUS.XemThietBiTable(txtTenNguyenLieu.Text, "", pageNumber, pageSize);
            //     }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (BUS.ThietBiBUS.XoaThietBi(new DTO.ThietBi()
            {
                Ma = ma,

            }))
            {
                MessageBox.Show("Xóa thiết bị thành công");
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

        private void btnThemThietBi_Click(object sender, EventArgs e)
        {
            frmThemThietBiSuDung themThietBiSuDung = new frmThemThietBiSuDung(bindingSource,bindingSourceTemp);
            themThietBiSuDung.ShowDialog();
        }

        private void dGVThietBi_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex  > 0 && e.ColumnIndex == 3)
            {
                int soLuongCu = 0;
                if (bindingSourceTemp.Count > 0)
                {
                    ThietBiDataSource thietBiDataSource = (ThietBiDataSource)bindingSourceTemp[e.RowIndex];
                    if (thietBiDataSource.MaThietBi == dGVThietBi[1, e.RowIndex].Value.ToString())
                    {
                        soLuongCu = int.Parse(thietBiDataSource.SoLuong);
                    }
                    if (!BUS.ThietBiBUS.KiemTraTonThietBi(dGVThietBi[1, e.RowIndex].Value.ToString(), int.Parse(dGVThietBi[e.ColumnIndex, e.RowIndex].Value.ToString()), soLuongCu))
                    {
                        MessageBox.Show("Thiết bị hết số lượng trong kho");
                        dGVThietBi[e.ColumnIndex, e.RowIndex].Value = thietBiDataSource.SoLuong;
                        return;
                    }
                    thietBiDataSource.SoLuong = dGVThietBi[e.ColumnIndex, e.RowIndex].Value.ToString();
                }
                //else
                //{
                //    if (!BUS.ThietBiBUS.KiemTraTonThietBi(dGVThietBi[1, e.RowIndex].Value.ToString(), int.Parse(dGVThietBi[e.ColumnIndex, e.RowIndex].Value.ToString()), 0))
                //    {
                //        MessageBox.Show("Thiết bị hết số lượng trong kho");
                //        dGVThietBi[e.ColumnIndex, e.RowIndex].Value = thietBiDataSource.SoLuong;
                //    }
                //}
            }
        }
    }
}
