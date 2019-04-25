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

namespace Karaoke.QuanLyThietBi
{
    public partial class frmThemThietBiSuDung : Form
    {
        private DataTable dtNguyenLieu;
        private List<String> listMaNguyenLieu;
        private const int pageSize = 10;
        private int pageNumber;
        private int totalPage;
        private BindingSource bindingSource;
        private BindingSource bindingSourceTemp;

        public frmThemThietBiSuDung(BindingSource bindingSource, BindingSource bindingSourceTemp)
        {
            InitializeComponent();
            this.bindingSourceTemp = bindingSourceTemp;
            this.bindingSource = bindingSource;
            cmbNhaCungCap.DataSource = BUS.NhaCungCapBUS.XemNhaCungCap();
            cmbNhaCungCap.DisplayMember = "Ten";

            listMaNguyenLieu = new List<string>();
            for (int i = 0; i < this.bindingSource.Count; i++)
            {
                listMaNguyenLieu.Add(((ThietBiDataSource)this.bindingSource[i]).MaThietBi);
            }
            pageNumber = 1;
            txtPageNumber.Text = "1";
            totalPage = BUS.ThietBiBUS.DemThietBiSuDung("", "", listMaNguyenLieu);
            totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();
            dtNguyenLieu = BUS.ThietBiBUS.XemThietBiSuDung("", "", pageNumber, pageSize, listMaNguyenLieu);
            dGVNguyenLieu.DataSource = dtNguyenLieu;
            AddGridTableStyle();
        }
        private void loadDanhSach()
        {
            if (cmbNhaCungCap.SelectedValue != null)
            {
                dtNguyenLieu = BUS.ThietBiBUS.XemThietBiSuDung(txtTenNguyenLieu.Text, ((DTO.NhaCungCap)(cmbNhaCungCap.SelectedValue)).MaNCC, pageNumber, pageSize, listMaNguyenLieu);
            }
            else
            {
                dtNguyenLieu = BUS.ThietBiBUS.XemThietBiSuDung(txtTenNguyenLieu.Text, "", pageNumber, pageSize, listMaNguyenLieu);
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            txtPageNumber.Text = "1";
            if (cmbNhaCungCap.SelectedValue != null)
            {
                totalPage = BUS.ThietBiBUS.DemThietBiSuDung(txtTenNguyenLieu.Text, ((DTO.NhaCungCap)(cmbNhaCungCap.SelectedValue)).MaNCC, listMaNguyenLieu);
            }
            else
            {
                totalPage = BUS.ThietBiBUS.DemThietBiSuDung(txtTenNguyenLieu.Text, "", listMaNguyenLieu);
            }

            totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();

            loadDanhSach();
            // if (this.DtNguyeLieuMonAn == null)
            //{
            //     this.DtNguyeLieuMonAn = dtNguyenLieu.Clone();
            //    this.DtNguyeLieuMonAn.Clear();
            // }
            dGVNguyenLieu.DataSource = dtNguyenLieu;
            AddGridTableStyle();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dGVNguyenLieu.CurrentCell != null)
            {
                int index = dGVNguyenLieu.CurrentCell.RowIndex;
                if(BUS.ThietBiBUS.KiemTraTonThietBi(dGVNguyenLieu[5, index].Value.ToString(), 1, 0))
                {
                    bindingSource.Add(new ThietBiDataSource()
                    {
                        MaThietBi = dGVNguyenLieu[5, index].Value.ToString(),
                        TenThietBi = dGVNguyenLieu[0, index].Value.ToString(),
                        SoLuong = "1",
                        TenNhaCungCap = dGVNguyenLieu[3, index].Value.ToString(),
                        DonGia = dGVNguyenLieu[2, index].Value.ToString()
                    });
                    bindingSourceTemp.Add(new ThietBiDataSource()
                    {
                        MaThietBi = dGVNguyenLieu[5, index].Value.ToString(),
                        TenThietBi = dGVNguyenLieu[0, index].Value.ToString(),
                        SoLuong = "1",
                        TenNhaCungCap = dGVNguyenLieu[3, index].Value.ToString(),
                        DonGia = dGVNguyenLieu[2, index].Value.ToString()
                    });
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mặt hàng hết số lượng");
                }
                // DataRow row = dtNguyenLieu.Rows[dGVNguyenLieu.CurrentCell.RowIndex];
                //  DtNguyeLieuMonAn.Rows.Add(row.ItemArray);
              
            }
        }
        private void AddGridTableStyle()
        {
            DataGridViewCellStyle cell = new DataGridViewCellStyle
            {
                BackColor = Color.Bisque,
                //  SelectionBackColor = Color.Teal,
                //   SelectionForeColor = Color.PaleGreen,
            };
            this.dGVNguyenLieu.BackColor = Color.GhostWhite;
            this.dGVNguyenLieu.ForeColor = Color.MidnightBlue;
            this.dGVNguyenLieu.BackgroundColor = Color.GhostWhite;
            this.dGVNguyenLieu.GridColor = Color.RoyalBlue;
            this.dGVNguyenLieu.AlternatingRowsDefaultCellStyle = cell;
            this.dGVNguyenLieu.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            //this.dGVNguyenLieu.ColumnHeadersDefaultCellStyle.ForeColor = Color.Lavender;

            dGVNguyenLieu.EnableHeadersVisualStyles = false;

            this.dGVNguyenLieu.Columns["MANCC"].Visible = false;

            this.dGVNguyenLieu.Columns["MATB"].Visible = false;
            //this.dGVNguyenLieu.Columns["manl"].HeaderText = "Mã nguyên liệu";
            //   this.dGVNguyenLieu.Columns["manl"].Width = 50;

           // this.dGVNguyenLieu.Columns["Tên nhà cung cấp"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            this.dGVNguyenLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnThem_MouseHover(object sender, EventArgs e)
        {
            this.btnThem.FlatAppearance.BorderSize = 2;
        }

        private void btnThoat_MouseHover(object sender, EventArgs e)
        {
            this.btnThoat.FlatAppearance.BorderSize = 2;
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

        private void frmThemNguyenLieuMonAn_Load(object sender, EventArgs e)
        {

        }

        private void dGVNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
