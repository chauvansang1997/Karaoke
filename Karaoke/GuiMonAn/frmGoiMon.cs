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
using Subro.Controls;
using Karaoke.PhongKaoraoke;

namespace Karaoke.GuiMonAn
{
    enum Loai
    {
        ThucAn = 0,
        NuocUong = 1,
        TraiCay = 2,
        Sanham = 3
    }
    public partial class frmGoiMon : Form
    {
        private const int pageSize = 2;
        private int pageNumber;
        private int totalPage;
        private List<FoodLayout> listFoodLayout;
        private Loai loaiHienTai;
        //loại thức ăn hiện tại (món khai vi, món chính,món la séc)
        private int loaiThucAnHienTai;
        //loại sản phẩm hiện tại(nước uống,trái cây)


        private int indexLoaiHienTai;

        private Dictionary<string, Dictionary<string, GoiMonDataSource>> dictionaryDataSource;
        private HashSet<string> hashMaHangHoa;
        private List<HangHoa> listHangHoa;
        private DataTable dtHoaDon;
        private BindingSource bindingSource = new BindingSource();
        private uint tongCong;
        private float giamGia;
        private string soHoaDon;


        List<Dictionary<int, List<FoodLayout>>> listDictionaryHangHoa;

        private Dictionary<int, List<FoodLayout>> dictionaryHienTai;

        private Dictionary<string, int> listCu = new Dictionary<string, int>();
        private Dictionary<string, int> listMoi = new Dictionary<string, int>();

        private List<FlowLayoutPanel> listLayoutHangHoa;
        private FlowLayoutPanel flowFoodLayoutHienTai;
        private int tienGiamGia;
        private List<LoaiHangHoa> listTenGroup;
        internal uint TongCong
        {
            get { return this.tongCong; }
            set
            {
                this.tongCong = value;
                txtTongCong.Text = value.ToString();
                txtThanhTien.Text = (value - (value * giamGia)).ToString();
                tienGiamGia = (int)(value * giamGia);
            }
        }
        private frmPhongKaraoke phongKaraoke;
        public frmGoiMon(string soHD, frmPhongKaraoke phongKaraoke)
        {

            this.phongKaraoke = phongKaraoke;
            soHoaDon = soHD;
            InitializeComponent();
            khoiTao();
        }
        private void khoiTao()
        {
            dictionaryDataSource = new Dictionary<string, Dictionary<string, GoiMonDataSource>>();

            listLayoutHangHoa = new List<FlowLayoutPanel>();

            listDictionaryHangHoa = new List<Dictionary<int, List<FoodLayout>>>();




            TongCong = 0;
            loaiHienTai = Loai.ThucAn;
            loaiThucAnHienTai = 1;


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

            FlowLayoutPanel flowFoodLayout = new FlowLayoutPanel();
            flowFoodLayout.Dock = DockStyle.Fill;
            listLayoutHangHoa.Add(flowFoodLayout);

            Dictionary<int, List<FoodLayout>> dictionary = new Dictionary<int, List<FoodLayout>>();
            TabPage tabPage = new TabPage("Thức ăn");
            tabPage.Controls.Add(flowFoodLayout);
            tabPage.Name = "1";
            tabControl.TabPages.Add(tabPage);
            listDictionaryHangHoa.Add(dictionary);
            //lấy danh sách loại sản phẩm đưa vào tabcontrol lớn
            List<LoaiHangHoa> listLoaiHangHoa = BUS.HangHoaBUS.XemLoaiMon(1);
            if (listLoaiHangHoa != null)
            {

                //tabControl.TabPages.Clear();
                for (int i = 0; i < listLoaiHangHoa.Count; i++)
                {
                    flowFoodLayout = new FlowLayoutPanel();
                    flowFoodLayout.Dock = DockStyle.Fill;
                    listLayoutHangHoa.Add(flowFoodLayout);

                    dictionary = new Dictionary<int, List<FoodLayout>>();
                    tabPage = new TabPage(listLoaiHangHoa[i].Ten);
                    tabPage.Controls.Add(flowFoodLayout);
                    tabPage.Name = listLoaiHangHoa[i].Ma;
                    tabControl.TabPages.Add(tabPage);
                    listDictionaryHangHoa.Add(dictionary);
                }
            }
            listTenGroup = new List<LoaiHangHoa>();
            listTenGroup.Add(new LoaiHangHoa() { Ma = "0", Ten = "Thức ăn" });
            listTenGroup.AddRange(BUS.HangHoaBUS.XemLoaiMon(2));
            if (listTenGroup != null)
            {

                for (int i = 0; i < listTenGroup.Count; i++)
                {
                    dictionaryDataSource.Add(listTenGroup[i].Ten, new Dictionary<string, GoiMonDataSource>());
                }
            }
            if (soHoaDon != "")
            {
                List<GoiMonDataSource> temp = BUS.HoaDonBUS.XemChiTietHoaDonGoiMon(soHoaDon);
                if (temp != null)
                {
                    uint tongCong = 0;
                    for (int i = 0; i < temp.Count; i++)
                    {
                        hashMaHangHoa.Add(temp[i].Ma);
                        dictionaryDataSource[temp[i].TenLoaiHangHoa].Add(temp[i].Ma, temp[i]);
                        bindingSource.Add(temp[i]);
                        tongCong += uint.Parse(temp[i].Thanhtien);
                        listCu.Add(temp[i].Ma, int.Parse(temp[i].Soluong));
                        listMoi.Add(temp[i].Ma, int.Parse(temp[i].Soluong));
                    }
                    TongCong = tongCong;

                }
            }

            thayDoiLoai();


        }
        private void sapXepLaiDanhSachHoaDon()
        {
            bindingSource.Clear();
            foreach (KeyValuePair<string, Dictionary<string, GoiMonDataSource>> itemSource in dictionaryDataSource)
            {
                foreach (KeyValuePair<string, GoiMonDataSource> item in itemSource.Value)
                {
                    bindingSource.Add(item.Value);
                }
            }
        }
        void grouper_DisplayGroup(object sender, GroupDisplayEventArgs e)
        {
            e.BackColor = (e.Group.GroupIndex % 2) == 0 ? Color.Orange : Color.LightBlue;
            e.Header = listTenGroup[int.Parse(e.DisplayValue) - 1].Ten;
            e.DisplayValue = "";
            e.ForeColor = (e.Group.GroupIndex % 2) == 0 ? Color.White : Color.Black;
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

        private void thayDoiLoai()
        {
            pageNumber = 1;
            txtPageNumber.Text = "1";
            totalPage = BUS.HangHoaBUS.DemHangHoaGoiMon((int)loaiHienTai);
            totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();

            dictionaryHienTai = listDictionaryHangHoa[(int)loaiHienTai];
            flowFoodLayoutHienTai = listLayoutHangHoa[(int)loaiHienTai];
            indexLoaiHienTai = (int)loaiHienTai;

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
            flowFoodLayoutHienTai.Dock = DockStyle.Fill;
            if (dictionaryHienTai.ContainsKey(pageNumber) == false)
            {
                listHangHoa = BUS.HangHoaBUS.XemHangHoaGoiMon((int)loaiHienTai, pageNumber, pageSize);
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
                    foodLayout.AutoScaleMode = AutoScaleMode.None;
                    foodLayout.AutoSize = false;
                    foodLayout.AutoScaleMode = AutoScaleMode.None;

                    foodLayout.HangHoa = item;
                    foodLayout.setClick((sender, e) =>
                    {
                        string tenLoaiHangHoa = foodLayout.HangHoa.Loai == "0" ? "Thức ăn" : foodLayout.HangHoa.LoaiHangHoa.Ten;
                        string maHangHoa = foodLayout.HangHoa.Ma;

                        if (!HoaDonBUS.KiemTraGoiMon(maHangHoa, int.Parse(foodLayout.HangHoa.Loai)))
                        {
                            MessageBox.Show("Mặt hàng đã hết số lượng");
                            return;
                        }
                        if (hashMaHangHoa.Contains(foodLayout.HangHoa.Ma))
                        {
                            return;
                        }
                        listMoi.Add(maHangHoa, 1);
                        if (dictionaryDataSource.ContainsKey(tenLoaiHangHoa))
                        {
                            dictionaryDataSource[tenLoaiHangHoa].Add(maHangHoa, new GoiMonDataSource()
                            {

                                Ma = maHangHoa,
                                Ten = foodLayout.HangHoa.Ten,
                                Gia = foodLayout.HangHoa.Gia.ToString(),
                                Soluong = "1",
                                Thanhtien = foodLayout.HangHoa.Gia.ToString(),
                                Loai = foodLayout.HangHoa.Loai,
                                IndexDict = foodLayout.IndexDict,
                                IndexList = foodLayout.IndexList,
                                MaLoaiHangHoa = foodLayout.HangHoa.LoaiHangHoa.Ma,
                                TenLoaiHangHoa = tenLoaiHangHoa,
                            });
                        }


                        hashMaHangHoa.Add(maHangHoa);
                        sapXepLaiDanhSachHoaDon();

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
                    FoodLayout foodLayout = listFoodLayout[i];
                    flowFoodLayoutHienTai.Controls.Add(foodLayout);
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


        private bool bKiemTraTon;

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
                    if (listMoi.ContainsKey(maHangHoa))
                    {
                        listMoi.Remove(maHangHoa);
                    }
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
            try
            {
                if (e.ColumnIndex == 3 && e.RowIndex > -1)
                {
                    if (!bKiemTraTon)
                    {
                        MessageBox.Show("Món hàng không đủ số lượng");
                        return;
                    }
                    dGVHoaDon[4, e.RowIndex].Value = int.Parse(dGVHoaDon[3, e.RowIndex].Value.ToString()) *
                        int.Parse(dGVHoaDon[2, e.RowIndex].Value.ToString());
                    listMoi[dGVHoaDon[7, e.RowIndex].Value.ToString()] = int.Parse(dGVHoaDon[3, e.RowIndex].Value.ToString());

                }
            }
            catch (Exception)
            {

                
            }
            bKiemTraTon = false;
        }

        private void dGVHoaDon_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 3 && e.RowIndex > -1)
                {
                    if (BUS.HoaDonBUS.KiemTraGoiMon(dGVHoaDon[6, e.RowIndex].Value.ToString(), int.Parse(dGVHoaDon[3, e.RowIndex].Value.ToString())))
                    {
                        bKiemTraTon = true;
                        return;
                    }
                    uint oldValue = uint.Parse(dGVHoaDon[e.ColumnIndex, e.RowIndex].Value.ToString());
                    uint newValue = uint.Parse(e.FormattedValue.ToString());
                 
                    TongCong = TongCong - oldValue * uint.Parse(dGVHoaDon[2, e.RowIndex].Value.ToString())
                        + newValue * uint.Parse(dGVHoaDon[2, e.RowIndex].Value.ToString());
                }
            }
            catch (Exception)
            {


            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (listCu.Count > 0)
            {
                foreach (KeyValuePair<string, int> itemSource in listCu)
                {
                    if (listMoi.ContainsKey(itemSource.Key))
                    {

                    }
                    else
                    {

                    }
                }
            }
            else
            {

            }
          

            List<ChiTietHoaDon> listHoaDonMonAn = new List<ChiTietHoaDon>();
            List<ChiTietHoaDon> listHoaDonSanPham = new List<ChiTietHoaDon>();
            List<string> maMonAn = new List<string>();
            List<string> soluongMonAn = new List<string>();
            List<string> maSanPham = new List<string>();
            List<string> soluongSanPham = new List<string>();
            foreach (KeyValuePair<string, Dictionary<string, GoiMonDataSource>> itemSource in dictionaryDataSource)
            {
                foreach (KeyValuePair<string, GoiMonDataSource> item in itemSource.Value)
                {
                    string ma = item.Value.Ma;
                    string soluong = item.Value.Soluong;
                    string loai = item.Value.Loai;

                    if (loai == "1")
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
            if (BUS.HoaDonBUS.ThanhToan(soHoaDon, DateTime.Now, int.Parse(txtThanhTien.Text), tienGiamGia))
            {
                MessageBox.Show("Thanh toán thành công");
                this.Close();
                phongKaraoke.reset();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra!. Vui lòng mời nhân viên kỹ thuật kiểm tra!!!");
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage tabPage = tabControl.SelectedTab;
            if (tabPage != null)
            {
                loaiHienTai = (Loai)tabControl.SelectedIndex;

                thayDoiLoai();
            }
        }

        private void tabControlThucAn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private Rectangle dragBoxFromMouseDown;

        private int rowIndexFromMouseDown;

        private int rowIndexOfItemUnderMouseToDrop;





        private void dGVHoaDon_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)

            {

                // If the mouse moves outside the rectangle, start the drag.

                if (dragBoxFromMouseDown != Rectangle.Empty &&

                    !dragBoxFromMouseDown.Contains(e.X, e.Y))

                {



                    // Proceed with the drag and drop, passing in the list item.                   

                    DragDropEffects dropEffect = dGVHoaDon.DoDragDrop(
                             dGVHoaDon.Rows[rowIndexFromMouseDown],
                             DragDropEffects.Move);

                }

            }
        }

        private void dGVHoaDon_MouseDown(object sender, MouseEventArgs e)
        {
            //Get the index of the item the mouse is below.

            rowIndexFromMouseDown = dGVHoaDon.HitTest(e.X, e.Y).RowIndex;



            if (rowIndexFromMouseDown != -1)

            {

                // Remember the point where the mouse down occurred. 
                // The DragSize indicates the size that the mouse can move 
                // before a drag event should be started.               

                Size dragSize = SystemInformation.DragSize;



                // Create a rectangle using the DragSize, with the mouse position being

                // at the center of the rectangle.

                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2),

                                                               e.Y - (dragSize.Height / 2)),
                                                        dragSize);

            }

            else

                // Reset the rectangle if the mouse is not over an item in the ListBox.

                dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void dGVHoaDon_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dGVHoaDon_DragDrop(object sender, DragEventArgs e)
        {
            Point clientPoint = dGVHoaDon.PointToClient(new Point(e.X, e.Y));
            rowIndexOfItemUnderMouseToDrop =
                dGVHoaDon.HitTest(clientPoint.X, clientPoint.Y).RowIndex;
            if (e.Effect == DragDropEffects.Move)
            {
                DataGridViewRow rowToMove = (DataGridViewRow)e.Data.GetData(typeof(DataGridViewRow));
                // find the row to move in the datasource:
                bindingSource.Add(rowToMove.DataBoundItem);
                bindingSource.RemoveAt(rowToMove.Index);

            }



        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmReportGoiMon reportGoiMon = new frmReportGoiMon(soHoaDon);
            reportGoiMon.ShowDialog();
        }
    }
}
