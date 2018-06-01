using DTO;
using Subro.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karaoke
{
    enum Loai
    {
        ThucAn = 0,
        Sanham = 1
    }

    public partial class frmChonMon : Form
    {
        private const int pageSize = 1;
        private int pageNumber;
        private int totalPage;
        private List<FoodLayout> listFoodLayout;
        private Loai loaiHienTai;
        //loại thức ăn hiện tại (món khai vi, món chính,món la séc)
        private int loaiThucAnHienTai;
        //loại sản phẩm hiện tại(nước uống,trái cây)
        private int loaiSanPhamHienTai;

        private int indexLoaiHienTai;

        private Dictionary<string, Dictionary<string, GoiMonDataSource>> dictionaryDataSource;
        private HashSet<string> hashMaHangHoa;
        private List<HangHoa> listHangHoa;
        private DataTable dtHoaDon;
        private BindingSource bindingSource = new BindingSource();
        private uint tongCong;
        private float giamGia;
        private string soHoaDon;

        List<List<Dictionary<int, List<FoodLayout>>>> listDictionaryHangHoa;
        List<Dictionary<int, List<FoodLayout>>> listDictionaryThucAn;
        List<Dictionary<int, List<FoodLayout>>> listDictionarySanPham;

        private Dictionary<int, List<FoodLayout>> dictionaryHienTai;
        private Dictionary<int, List<FoodLayout>> dictionaryThucAn;
        private Dictionary<int, List<FoodLayout>> dictionaryTraiCay;
        private Dictionary<int, List<FoodLayout>> dictionaryNuocUong;
        private Dictionary<int, List<HangHoa>> dictionaryMonAn;
        private Dictionary<string, TabPage> dictionaryTabThucAn;

        private List<FlowLayoutPanel> listLayoutThucAn;
        private List<FlowLayoutPanel> listLayoutSanPham;
        private FlowLayoutPanel flowFoodLayoutHienTai;

        private List<LoaiHangHoa> listTenGroup;
        public frmChonMon()
        {
            InitializeComponent();
            khoiTao();
        }
        private void khoiTao()
        {
            dictionaryDataSource = new Dictionary<string, Dictionary<string, GoiMonDataSource>>();
            listLayoutThucAn = new List<FlowLayoutPanel>();
            listLayoutSanPham = new List<FlowLayoutPanel>();
            listDictionaryThucAn = new List<Dictionary<int, List<FoodLayout>>>();
            listDictionarySanPham = new List<Dictionary<int, List<FoodLayout>>>();

            listDictionaryHangHoa = new List<List<Dictionary<int, List<FoodLayout>>>>();

            dictionaryThucAn = new Dictionary<int, List<FoodLayout>>();
            dictionaryMonAn = new Dictionary<int, List<HangHoa>>();
            dictionaryTraiCay = new Dictionary<int, List<FoodLayout>>();
            dictionaryNuocUong = new Dictionary<int, List<FoodLayout>>();
            TongCong = 0;
            loaiHienTai = Loai.ThucAn;
            loaiThucAnHienTai = 1;
            loaiSanPhamHienTai = 1;

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
            dGVHoaDon.Columns["MaLoaiHangHoa"].Visible = false;
            dGVHoaDon.Columns["TenLoaiHangHoa"].Visible = false;
            dGVHoaDon.Columns["IndexList"].Visible = false;
            dGVHoaDon.Columns["Gia"].ReadOnly = true;
            dGVHoaDon.Columns["Ten"].ReadOnly = true;
            dGVHoaDon.Columns["Thanhtien"].ReadOnly = true;

            var grouper = new Subro.Controls.DataGridViewGrouper(dGVHoaDon);
            grouper.SetGroupOn("MaLoaiHangHoa");
            //grouper.Options.GroupSortOrder = SortOrder.None;
            grouper.DisplayGroup += grouper_DisplayGroup;
           
            //lấy danh sách loại thức ăn ra đưa vào tabcontrol nhỏ
            List<LoaiMon> listLoaiMon = BUS.MonAnBUS.XemLoaiMon();
            if (listLoaiMon != null)
            {
                tabControlThucAn.TabPages.Clear();
                for (int i = 0; i < listLoaiMon.Count; i++)
                {
                    FlowLayoutPanel flowFoodLayout = new FlowLayoutPanel();
                    flowFoodLayout.Dock = DockStyle.Fill;
                    listLayoutThucAn.Add(flowFoodLayout);
                    //listDictionaryThucAn
                    Dictionary<int, List<FoodLayout>> dictionary = new Dictionary<int, List<FoodLayout>>();
                    TabPage tabPage = new TabPage(listLoaiMon[i].Ten);
                    tabPage.Controls.Add(flowFoodLayout);
                    tabPage.Name = listLoaiMon[i].Ma;

                    tabControlThucAn.TabPages.Add(tabPage);
                    listDictionaryThucAn.Add(dictionary);
                }
            }
            //lấy danh sách loại sản phẩm đưa vào tabcontrol lớn
            List<LoaiHangHoa> listLoaiHangHoa = BUS.HangHoaBUS.XemLoaiMon((int)Loai.Sanham);
            if (listLoaiHangHoa != null)
            {
                //tabControl.TabPages.Clear();
                for (int i = 0; i < listLoaiHangHoa.Count; i++)
                {
                    FlowLayoutPanel flowFoodLayout = new FlowLayoutPanel();
                    flowFoodLayout.Dock = DockStyle.Fill;
                    listLayoutSanPham.Add(flowFoodLayout);
                    //listDictionaryThucAn
                    Dictionary<int, List<FoodLayout>> dictionary = new Dictionary<int, List<FoodLayout>>();
                    TabPage tabPage = new TabPage(listLoaiHangHoa[i].Ten);
                    tabPage.Controls.Add(flowFoodLayout);
                    tabPage.Name = listLoaiHangHoa[i].Ma;
                    tabControl.TabPages.Add(tabPage);
                    listDictionarySanPham.Add(dictionary);
                }
            }
            //bindingSource.Clear();
            //bindingSource.Add(new GoiMonDataSource() { TenLoaiHangHoa="b"});
            //bindingSource.Add(new GoiMonDataSource() { TenLoaiHangHoa = "a" });
            //bindingSource.Add(new GoiMonDataSource() { TenLoaiHangHoa = "c" });
            // List<HangHoa>
            //List<GoiMonDataSource> temp = BUS.HoaDonBUS.XemChiTietHoaDon(soHoaDon);
            //if (temp != null)
            //{
            //    uint tongCong = 0;
            //    bindingSource.DataSource = BUS.HoaDonBUS.XemChiTietHoaDon(soHoaDon);
            //    for (int i = 0; i < temp.Count; i++)
            //    {
            //        hashMaHangHoa.Add(temp[i].Ma);
            //        tongCong += uint.Parse(temp[i].Thanhtien);

            //    }
            //    TongCong = tongCong;

            //}
            thayDoiLoai();

            listTenGroup = BUS.HangHoaBUS.XemLoaiMon(-1);
            if (listTenGroup != null)
            {

                for (int i = 0; i < listTenGroup.Count; i++)
                {
                    dictionaryDataSource.Add(listTenGroup[i].Ten, new Dictionary<string, GoiMonDataSource>());
                }
            }
        }
        private void sapXepLaiDanhSachHoaDon()
        {
            bindingSource.Clear();
            //List<string> temp = dictionaryDataSource.Keys.ToList();
            foreach (KeyValuePair<string, Dictionary<string, GoiMonDataSource>> itemSource in dictionaryDataSource)
            {              
                foreach (KeyValuePair<string, GoiMonDataSource> item in itemSource.Value)
                {
                   // MessageBox.Show(item.Value.TenLoaiHangHoa);
                    bindingSource.Add(item.Value);
                    // bindingSource.Add(new GoiMonDataSource());
                    //await Task.Delay(1000);
                }
            }
        }
        void grouper_DisplayGroup(object sender, GroupDisplayEventArgs e)
        {
            e.BackColor = (e.Group.GroupIndex % 2) == 0 ? Color.Orange : Color.LightBlue;
            e.Header = listTenGroup[int.Parse(e.DisplayValue)-1].Ten;
            e.DisplayValue = "";
            
            // e.Summary = "contains " + e.Group.Count + " rows";
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
                totalPage = BUS.HangHoaBUS.DemHangHoa((int)loaiHienTai, loaiThucAnHienTai);
                totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);

                txtTotalPage.Text = totalPage.ToString();
                pageNumber = 1;
                dictionaryHienTai = listDictionaryThucAn[loaiThucAnHienTai - 1];
                flowFoodLayoutHienTai = listLayoutThucAn[loaiThucAnHienTai - 1];
                indexLoaiHienTai = loaiThucAnHienTai;
            }
            else
            {
                totalPage = BUS.HangHoaBUS.DemHangHoa((int)loaiHienTai, loaiSanPhamHienTai);
                totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
                txtTotalPage.Text = totalPage.ToString();
                pageNumber = 1;
                dictionaryHienTai = listDictionarySanPham[loaiSanPhamHienTai - 1];
                flowFoodLayoutHienTai = listLayoutSanPham[loaiSanPhamHienTai - 1];
                indexLoaiHienTai = loaiSanPhamHienTai;
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

            flowFoodLayoutHienTai.Controls.Clear();
            if (dictionaryHienTai.ContainsKey(pageNumber) == false)
            {
                listHangHoa = BUS.HangHoaBUS.XemHangHoa((int)loaiHienTai, pageNumber, pageSize, indexLoaiHienTai);
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
                        string tenLoaiHangHoa = foodLayout.HangHoa.LoaiHangHoa.Ten;
                        string maHangHoa = foodLayout.HangHoa.Ma;
                        if (dictionaryDataSource.ContainsKey(tenLoaiHangHoa))
                        {
                            dictionaryDataSource[tenLoaiHangHoa].Add(maHangHoa, new GoiMonDataSource()
                            {

                                Ma = foodLayout.HangHoa.Ma,
                                Ten = foodLayout.HangHoa.Ten,
                                Gia = foodLayout.HangHoa.Gia.ToString(),
                                Soluong = "1",
                                Thanhtien = foodLayout.HangHoa.Gia.ToString(),
                                Loai = foodLayout.HangHoa.Loai,
                                IndexDict = foodLayout.IndexDict,
                                IndexList = foodLayout.IndexList,
                                MaLoaiHangHoa = foodLayout.HangHoa.LoaiHangHoa.Ma,
                                TenLoaiHangHoa = foodLayout.HangHoa.LoaiHangHoa.Ten,
                            });
                        }

                     
                        hashMaHangHoa.Add(foodLayout.HangHoa.Ma);
                        sapXepLaiDanhSachHoaDon();
                        //bindingSource.Add(new GoiMonDataSource()
                        //{

                        //    Ma = foodLayout.HangHoa.Ma,
                        //    Ten = foodLayout.HangHoa.Ten,
                        //    Gia = foodLayout.HangHoa.Gia.ToString(),
                        //    Soluong = "1",
                        //    Thanhtien = foodLayout.HangHoa.Gia.ToString(),
                        //    Loai = foodLayout.HangHoa.Loai,
                        //    IndexDict = foodLayout.IndexDict,
                        //    IndexList = foodLayout.IndexList,
                        //    MaLoaiHangHoa = foodLayout.HangHoa.LoaiHangHoa.Ma,
                        //    TenLoaiHangHoa = foodLayout.HangHoa.LoaiHangHoa.Ten,
                        //});
                        TongCong = TongCong + foodLayout.HangHoa.Gia;

                    });
                    flowFoodLayoutHienTai.Controls.Add(foodLayout);

                    listFoodLayout.Add(foodLayout);
                }
                dictionaryHienTai.Add(pageNumber, listFoodLayout);

            }
            else
            {
                listFoodLayout = dictionaryHienTai[pageNumber];
                for (int i = 0; i < listFoodLayout.Count; i++)
                {
                    flowFoodLayoutHienTai.Controls.Add(listFoodLayout[i]);
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




        private void dGVHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0 && e.RowIndex > -1)
                {
                    int indexDict = int.Parse(dGVHoaDon[6, e.RowIndex].Value.ToString());
                    int indexList = int.Parse(dGVHoaDon[8, e.RowIndex].Value.ToString());
                    string maHangHoa = dGVHoaDon[7, e.RowIndex].Value.ToString();
                    hashMaHangHoa.Remove(maHangHoa);
                    dictionaryDataSource[dGVHoaDon[10, e.RowIndex].Value.ToString()].Remove(maHangHoa);

                    TongCong = TongCong - (uint.Parse(dGVHoaDon[2, e.RowIndex].Value.ToString()) *
                        uint.Parse(dGVHoaDon[3, e.RowIndex].Value.ToString()));
                    dGVHoaDon.Rows.RemoveAt(e.RowIndex);

                }
            }
            catch (Exception)
            {
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

                if (dGVHoaDon[5, i].Value.ToString() == "1" )
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

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage tabPage = tabControl.SelectedTab;
            if (tabPage != null)
            {
                //loaiThucAnHienTai = tabControlThucAn.SelectedIndex + 1;

                if (tabControl.SelectedIndex > 0)
                {
                    loaiSanPhamHienTai = tabControl.SelectedIndex;
                    loaiHienTai = Loai.Sanham;
                }
                else
                {
                    loaiHienTai = Loai.ThucAn;
                }
                thayDoiLoai();
            }
        }

        private void tabControlThucAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage tabPage = tabControlThucAn.SelectedTab;
            if (tabPage != null)
            {
                loaiThucAnHienTai = tabControlThucAn.SelectedIndex + 1;
                thayDoiLoai();
            }
        }
    }
}
