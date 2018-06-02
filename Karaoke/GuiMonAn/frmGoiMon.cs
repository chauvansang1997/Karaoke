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
    enum Loai
    {
        ThucAn,
        NuocUong,
        TraiCay
    }
    public partial class frmGoiMon : Form
    {
        private const int pageSize = 1;
        private int pageNumber;
        private int totalPage;
        private List<FoodLayout> listFoodLayout;
        private Loai loaiHienTai;
        private HashSet<string> hashMaHangHoa;
        private List<HangHoa> listHangHoa;
        private DataTable dtHoaDon;
        private BindingSource bindingSource = new BindingSource();
        private uint tongCong;
        private float giamGia;
        private string soHoaDon;
        private Dictionary<int, List<FoodLayout>> dictionaryHienTai;
        private Dictionary<int, List<FoodLayout>> dictionaryThucAn;
        private Dictionary<int, List<FoodLayout>> dictionaryTraiCay;
        private Dictionary<int, List<FoodLayout>> dictionaryNuocUong;
        private Dictionary<int, List<HangHoa>> dictionaryMonAn;

        public frmGoiMon(string soHoaDon)
        {
            InitializeComponent();
            this.soHoaDon = soHoaDon;
            khoiTao();
        }

        private void khoiTao()
        {
            dictionaryThucAn = new Dictionary<int, List<FoodLayout>>();
            dictionaryMonAn = new Dictionary<int, List<HangHoa>>();
            dictionaryTraiCay = new Dictionary<int, List<FoodLayout>>();
            dictionaryNuocUong = new Dictionary<int, List<FoodLayout>>();
            TongCong = 0;
            loaiHienTai = Loai.ThucAn;
            giamGia = 0.5f;
            txtGiamGia.Text = giamGia.ToString() + "%";
            listFoodLayout = new List<FoodLayout>();
            hashMaHangHoa = new HashSet<string>();
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
            dGVHoaDon.Columns["IndexDict"].Visible = false;
            dGVHoaDon.Columns["IndexList"].Visible = false;
            dGVHoaDon.Columns["Gia"].ReadOnly = true;
            dGVHoaDon.Columns["Ten"].ReadOnly = true;
            dGVHoaDon.Columns["Thanhtien"].ReadOnly = true;
            List<GoiMonDataSource> temp = BUS.HoaDonBUS.XemChiTietHoaDon(soHoaDon);
            if (temp != null)
            {
                uint tongCong = 0;
                bindingSource.DataSource = BUS.HoaDonBUS.XemChiTietHoaDon(soHoaDon);
                for (int i = 0; i < temp.Count; i++)
                {
                    hashMaHangHoa.Add(temp[i].Ma);
                    tongCong += uint.Parse(temp[i].Thanhtien);

                }
                TongCong = tongCong;

            }
            thayDoiLoai();
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
                txtThanhTien.Text = (value - (value * giamGia)).ToString();
            }
        }
        private void thayDoiLoai()
        {
            if (loaiHienTai == Loai.ThucAn)
            {
                totalPage = BUS.HangHoaBUS.DemHangHoa((int)loaiHienTai);
                totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
                txtTotalPage.Text = totalPage.ToString();
                pageNumber = 1;
                dictionaryHienTai = dictionaryThucAn;
            }
            else if (loaiHienTai == Loai.NuocUong)
            {
                totalPage = BUS.HangHoaBUS.DemHangHoa((int)loaiHienTai);
                totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
                txtTotalPage.Text = totalPage.ToString();
                pageNumber = 1;
                dictionaryHienTai = dictionaryNuocUong;
            }
            else
            {
                totalPage = BUS.HangHoaBUS.DemHangHoa((int)loaiHienTai);
                totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
                txtTotalPage.Text = totalPage.ToString();
                pageNumber = 1;
                dictionaryHienTai = dictionaryTraiCay;
            }
            hienThiDanhSachHangHoa();
        }
        private void frmGoiMon_Load(object sender, EventArgs e)
        {


        }
        /// <summary>
        ///  
        /// </summary>
        private void hienThiDanhSachHangHoa()
        {
            flowFoodLayout.Controls.Clear();
            if (dictionaryHienTai.ContainsKey(pageNumber) == false)
            {
                listHangHoa = BUS.HangHoaBUS.XemHangHoa((int)loaiHienTai, pageNumber, pageSize);
                listFoodLayout = new List<FoodLayout>();
                for (int i = 0; i < listHangHoa.Count; i++)
                {
                    HangHoa item = listHangHoa[i];
                    // Get the current directory.
                    string path = Directory.GetCurrentDirectory();
                    path = Path.GetFullPath(Path.Combine(path, @"..\..\")) + @"\Image\" + item.TenHinhAnh;
                    Image image = null;
                    try
                    {
                        image = Image.FromFile(path);
                    }
                    catch (Exception)
                    {

                    }


                    FoodLayout foodLayout = new FoodLayout(image) { HangHoa = item, IndexDict = pageNumber, IndexList = i };
                    foodLayout.HangHoa = item;
                    foodLayout.setClick((sender, e) =>
                    {

                        if (hashMaHangHoa.Contains(foodLayout.HangHoa.Ma))
                        {
                            return;
                        }
                        hashMaHangHoa.Add(foodLayout.HangHoa.Ma);
                        bindingSource.Add(new GoiMonDataSource()
                        {

                            Ma = foodLayout.HangHoa.Ma,
                            Ten = foodLayout.HangHoa.Ten,
                            Gia = foodLayout.HangHoa.Gia.ToString(),
                            Soluong = "1",
                            Thanhtien = foodLayout.HangHoa.Gia.ToString(),
                            Loai = foodLayout.HangHoa.Loai,
                            IndexDict = foodLayout.IndexDict,
                            IndexList = foodLayout.IndexList,
                        });
                        TongCong = TongCong + foodLayout.HangHoa.Gia;

                    });
                    flowFoodLayout.Controls.Add(foodLayout);

                    listFoodLayout.Add(foodLayout);
                }
                dictionaryHienTai.Add(pageNumber, listFoodLayout);

            }
            else
            {
                listFoodLayout = dictionaryHienTai[pageNumber];
                for (int i = 0; i < listFoodLayout.Count; i++)
                {
                    flowFoodLayout.Controls.Add(listFoodLayout[i]);
                }
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
            hienThiDanhSachHangHoa();
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
            hienThiDanhSachHangHoa();
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();
            hienThiDanhSachHangHoa();
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            pageNumber = totalPage;
            txtPageNumber.Text = pageNumber.ToString();
            hienThiDanhSachHangHoa();
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
            if (loaiHienTai != Loai.ThucAn)
            {
                loaiHienTai = Loai.ThucAn;
                thayDoiLoai();
            }

        }

        private void btnNuocUong_Click(object sender, EventArgs e)
        {
            if (loaiHienTai != Loai.NuocUong)
            {
                loaiHienTai = Loai.NuocUong;
                thayDoiLoai();
            }

        }

        private void btnTraiCay_Click(object sender, EventArgs e)
        {
            if (loaiHienTai != Loai.TraiCay)
            {
                loaiHienTai = Loai.TraiCay;
                thayDoiLoai();
            }
        }

        private void dGVHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                int indexDict = int.Parse(dGVHoaDon[6, e.RowIndex].Value.ToString());
                int indexList = int.Parse(dGVHoaDon[8, e.RowIndex].Value.ToString());

                hashMaHangHoa.Remove(dGVHoaDon[7, e.RowIndex].Value.ToString());


                TongCong = TongCong - (uint.Parse(dGVHoaDon[2, e.RowIndex].Value.ToString()) *
                    uint.Parse(dGVHoaDon[3, e.RowIndex].Value.ToString()));
                dGVHoaDon.Rows.RemoveAt(e.RowIndex);

            }
        }

        private void dGVHoaDon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex > -1)
            {
                dGVHoaDon[4, e.RowIndex].Value = int.Parse(dGVHoaDon[3, e.RowIndex].Value.ToString()) *
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
                string ma = dGVHoaDon[7, i].Value.ToString();
                string soluong = dGVHoaDon[3, i].Value.ToString();

                if (dGVHoaDon[5, i].Value.ToString() == "Nước uống" || dGVHoaDon[5, i].Value.ToString() == "Trái cây")
                {
                    maSanPham.Add(ma);
                    soluongSanPham.Add(soluong);
                  
                }
                else
                {
                    maMonAn.Add(ma);
                    soluongMonAn.Add(soluong);
                }
            }
            if (BUS.HoaDonBUS.ThemChiTietHoaDon(soHoaDon, maMonAn, soluongMonAn, maSanPham, soluongSanPham))
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
