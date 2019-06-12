using DTO;
using FastMember;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karaoke.GuiMonAn
{
    public partial class frmThemNguyenLieuMonAn : Form
    {
        private DataTable dtNguyenLieu;
        private List<String> listMaNguyenLieu;
        private const int pageSize = 10;
        private int pageNumber;
        private int totalPage;
        public BindingSource bindingSource;
        frmMonAn monAn;
        public DataTable DtNguyeLieuMonAn
        {
            get
            {
                return dtNguyenLieu;
            }
            set
            {
                dtNguyenLieu = value;
            }
        }

        public frmThemNguyenLieuMonAn(frmMonAn monAn)
        {
            InitializeComponent();
            bindingSource = monAn.bindingSource;
            this.monAn = monAn;
            List<DTO.NhaCungCap> NCCs = BUS.NhaCungCapBUS.XemNhaCungCap();
            cmbNhaCungCap.DataSource = NCCs;
            cmbNhaCungCap.DisplayMember = "Ten";
            cmbNhaCungCap.SelectedIndex = NCCs.Count - 1; 
            //  IEnumerable<NguyenLieuDataSource> data = (List<NguyenLieuDataSource>)dtNguyeLieuMonAn.DataSource;
            //using (var reader = ObjectReader.Create((List<NguyenLieuDataSource>)dtNguyeLieuMonAn.DataSource))
            //{
            //    DtNguyeLieuMonAn.Load(reader);
            //}
            listMaNguyenLieu = new List<string>();
            for (int i = 0; i < monAn.bindingSource.Count; i++)
            {
                listMaNguyenLieu.Add(((NguyenLieuMADataSource)monAn.bindingSource[i]).Ma);
            }


            pageNumber = 1;
            txtPageNumber.Text = "1";
            totalPage = BUS.NguyenLieuBUS.DemNguyenLieu("", "", false, listMaNguyenLieu);
            totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();
            dtNguyenLieu = BUS.NguyenLieuBUS.TiemKiemNguyenLieu("", "", false, pageNumber, pageSize, listMaNguyenLieu);
            dGVNguyenLieu.DataSource = dtNguyenLieu;
            AddGridTableStyle();
        }
        private void loadDanhSach()
        {
            if (cmbNhaCungCap.SelectedValue != null)
            {
                dtNguyenLieu = BUS.NguyenLieuBUS.TiemKiemNguyenLieu(txtTenNguyenLieu.Text, ((DTO.NhaCungCap)(cmbNhaCungCap.SelectedValue)).MaNCC, false, pageNumber, pageSize, listMaNguyenLieu);
            }
            else
            {
                dtNguyenLieu = BUS.NguyenLieuBUS.TiemKiemNguyenLieu(txtTenNguyenLieu.Text, "", false, pageNumber, pageSize, listMaNguyenLieu);
            }
            dGVNguyenLieu.DataSource = dtNguyenLieu;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            txtPageNumber.Text = "1";
            if (cmbNhaCungCap.SelectedValue != null)
            {
                totalPage = BUS.NguyenLieuBUS.DemNguyenLieu(txtTenNguyenLieu.Text, ((DTO.NhaCungCap)(cmbNhaCungCap.SelectedValue)).MaNCC, false, listMaNguyenLieu);
            }
            else
            {
                totalPage = BUS.NguyenLieuBUS.DemNguyenLieu(txtTenNguyenLieu.Text, "", false, listMaNguyenLieu);
            }
            
            totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();

            loadDanhSach();
            // if (this.DtNguyeLieuMonAn == null)
            //{
       //     this.DtNguyeLieuMonAn = dtNguyenLieu.Clone();
        //    this.DtNguyeLieuMonAn.Clear();
            // }
            AddGridTableStyle();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dGVNguyenLieu.CurrentCell != null)
            {
                int index = dGVNguyenLieu.CurrentCell.RowIndex;
                // DataRow row = dtNguyenLieu.Rows[dGVNguyenLieu.CurrentCell.RowIndex];
                //  DtNguyeLieuMonAn.Rows.Add(row.ItemArray);
                bindingSource.Add(new NguyenLieuMADataSource()
                {
                    Ma = dGVNguyenLieu[0, index].Value.ToString(),
                    Ten = dGVNguyenLieu[1, index].Value.ToString(),
                    DonViTinh = dGVNguyenLieu[4, index].Value.ToString(),
                    SoLuong = "1",
                    Gia = dGVNguyenLieu[5, index].Value.ToString(),
                });
                this.Close();
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

            this.dGVNguyenLieu.Columns["manl"].Visible = false;
            //this.dGVNguyenLieu.Columns["manl"].HeaderText = "Mã nguyên liệu";
         //   this.dGVNguyenLieu.Columns["manl"].Width = 50;


            this.dGVNguyenLieu.Columns["tennl"].HeaderText = "Tên nguyên liệu";
            //this.dGVNguyenLieu.Columns["tennl"].Width = 50;

            this.dGVNguyenLieu.Columns["TENNCC"].HeaderText = "Nhà cung cấp";
            this.dGVNguyenLieu.Columns["TENNCC"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //  this.dGVNguyenLieu.Columns["TENNCC"].Width = 50;

            this.dGVNguyenLieu.Columns["DVT"].HeaderText = "Đơn vị tính";
          //  this.dGVNguyenLieu.Columns["DVT"].Width = 50;

            this.dGVNguyenLieu.Columns["DONGIA"].HeaderText = "Đơn giá bán";
         //   this.dGVNguyenLieu.Columns["DONGIA"].Width = 50;

            this.dGVNguyenLieu.Columns["DONGIANHAP"].HeaderText = "Đơn giá nhập";
         //   this.dGVNguyenLieu.Columns["DONGIANHAP"].Width = 50;

            this.dGVNguyenLieu.Columns["SLTOITHIEU"].HeaderText = "Số lượng tối thiểu";
            // this.dGVNguyenLieu.Columns["SLTOITHIEU"].Width = 50;
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
            // loadDanhSach();
        }

        private void frmThemNguyenLieuMonAn_Load(object sender, EventArgs e)
        {

        }
    }
}
