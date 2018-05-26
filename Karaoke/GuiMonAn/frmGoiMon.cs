using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.IO;

namespace Karaoke.GuiMonAn
{
    public partial class frmGoiMon : Form
    {
        private const int pageSize = 10;
        private int pageNumber;
        private int totalPage;
        private List<FoodLayout> listFoodLayout;

        private List<MonAn> listNuocuong;
        private List<MonAn> listTraiCay;
        private List<MonAn> listMonAn;
        private DataTable dtHoaDon;
        private BindingSource bindingSource = new BindingSource();
        private uint tongCong;
        private float giamGia;
        private string maHD;

        public frmGoiMon()
        {
            InitializeComponent();
            khoiTao();
        }

        private void khoiTao()
        {
            giamGia = 0.5f;
            txtGiamGia.Text = giamGia.ToString()+"%";
            listFoodLayout = new List<FoodLayout>();
            dGVHoaDon.AllowUserToAddRows = false;
            bindingSource.Add(new GoiMonDataSource());
            dGVHoaDon.DataSource = bindingSource;
            bindingSource.RemoveAt(0);
            dGVHoaDon.Columns["Ten"].HeaderText = "Tên";

            dGVHoaDon.Columns["Gia"].HeaderText = "Giá";

            dGVHoaDon.Columns["Soluong"].HeaderText = "Số lượng";
            dGVHoaDon.Columns["Thanhtien"].HeaderText = "Thành tiền";
            dGVHoaDon.Columns["Ma"].Visible = false;
            dGVHoaDon.Columns["Loai"].Visible = false;
            dGVHoaDon.Columns["Index"].Visible = false;
            dGVHoaDon.Columns["Gia"].ReadOnly = true;
            dGVHoaDon.Columns["Ten"].ReadOnly = true;
            dGVHoaDon.Columns["Thanhtien"].ReadOnly = true;

        }
        private void themCotHoaDon()
        {
            dtHoaDon = new DataTable();

        }
        private void themCotXoa()
        {

            dGVHoaDon.Columns["Ten"].HeaderText = "Tên";
        }
        internal uint TongCong
        {
            get { return this.tongCong; }
            set
            {
                this.tongCong = value;
                txtTongCong.Text = value.ToString();
                txtThanhTien.Text =  (value - (value*giamGia) ).ToString();
            }
        }
        private void frmGoiMon_Load(object sender, EventArgs e)
        {
            totalPage = BUS.MonAnBUS.DemMonAn("", "");
            totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();
            pageNumber = 1;
            listMonAn = BUS.MonAnBUS.XemMonAn("", "", pageNumber, pageSize);
            
         
            TongCong = 0;
            hienThiDanhSachThucAn();
        }
        /// <summary>
        ///  
        /// </summary>
        private void hienThiDanhSachThucAn()
        {
            for (int i = 0; i < listMonAn.Count; i++)
            {
                DTO.MonAn item = listMonAn[i];
                // Get the current directory.
                string path = Directory.GetCurrentDirectory();
                path = Path.GetFullPath(Path.Combine(path, @"..\..\")) + @"\Image\" + item.TenHinhAnh;
                //Image image = null;
                Image image = Image.FromFile(path);
                
                FoodLayout foodLayout = new FoodLayout(image, item.Ten, item.Gia);
                foodLayout.Index = i;

                foodLayout.setClick((sender, e) =>
                {
                    if (foodLayout.IsClick == false)
                    {
                        foodLayout.IsClick = true;
                        bindingSource.Add(new GoiMonDataSource() { Ma= listMonAn[foodLayout.Index].Ma,
                            Ten = foodLayout.Name,Gia= foodLayout.Price.ToString(),
                            Soluong ="1",Thanhtien= foodLayout.Price.ToString(),
                            Loai="ThucAn",Index= foodLayout.Index
                        });
                        TongCong = TongCong + foodLayout.Price;
                    }
                });
                flowFoodLayout.Controls.Add(foodLayout);
                listFoodLayout.Add(foodLayout);
            }


        }
        private void hienThiDanhSachNuocUong()
        {

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
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            pageNumber = totalPage;
            txtPageNumber.Text = pageNumber.ToString();
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
        }

        private void btnThucAn_Click(object sender, EventArgs e)
        {
         
        }

        private void btnNuocUong_Click(object sender, EventArgs e)
        {
         
        }

        private void btnTraiCay_Click(object sender, EventArgs e)
        {
            
        }

        private void dGVHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                FoodLayout foodLayout = listFoodLayout[int.Parse(dGVHoaDon[6, e.RowIndex].Value.ToString())];
                foodLayout.IsClick = false;
                TongCong = TongCong - (foodLayout.Price * uint.Parse(dGVHoaDon[3, e.RowIndex].Value.ToString()));
                dGVHoaDon.Rows.RemoveAt(e.RowIndex);
              
            }
        }

        private void dGVHoaDon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex > -1)
            {
                dGVHoaDon[4, e.RowIndex].Value = int.Parse(dGVHoaDon[3, e.RowIndex].Value.ToString())* 
                    int.Parse(dGVHoaDon[2, e.RowIndex].Value.ToString());
                
            }
        }

        private void dGVHoaDon_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex > -1)
            {
                uint oldValue = uint.Parse(dGVHoaDon[e.ColumnIndex, e.RowIndex].Value.ToString());
                uint newValue = uint.Parse(e.FormattedValue.ToString());
                TongCong = TongCong - oldValue * uint.Parse(dGVHoaDon[2, e.RowIndex].Value.ToString())
                    + newValue * uint.Parse(dGVHoaDon[2, e.RowIndex].Value.ToString());
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            List<ChiTietHoaDon> listHoaDonMonAn = new List<ChiTietHoaDon>();
            List<ChiTietHoaDon> listHoaDonSanPham = new List<ChiTietHoaDon>();
            List<string> maMonAn = new List<string>();
            List<string> soluongMonAn = new List<string>();
            List<string> maSanPham = new List<string>();
            List<string> soluongSanPham = new List<string>();
            for (int i = 0; i < dGVHoaDon.Rows.Count; i++)
            {
                string ma = dGVHoaDon[5, i].Value.ToString();
                string soluong = dGVHoaDon[3, i].Value.ToString();

                if (dGVHoaDon[5, i].Value.ToString() == "ThucAn")
                {

                    maMonAn.Add(ma);
                    soluongMonAn.Add(soluong);
                }
                else
                {
                    maSanPham.Add(ma);
                    soluongSanPham.Add(soluong);
                }
            }
            if (BUS.HoaDonBUS.ThemChiTietHoaDon(maHD, maMonAn, soluongMonAn, maSanPham, soluongSanPham))
            {
                MessageBox.Show("Lưu thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra!. Vui lòng mời nhân viên kỹ thuật kiểm tra!!!");
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }
    }
}
