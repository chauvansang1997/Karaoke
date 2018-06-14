using DTO;
using Karaoke.QuanLyNguyenLieu;
using Karaoke.QuanLySanPham;
using Subro.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Karaoke.NguyenLieu
{
    public partial class frmNhapCTNguyenLieu : Form
    {

        public frmNhapCTNguyenLieu(NhaCungCap nhaCungCap, PhieuNhapHang phieuNhapHang)
        {
            this.nhaCungCap = nhaCungCap;
            this.phieuNhapHang = phieuNhapHang;
            InitializeComponent();
            khoiTao();
        }

        private const int pageSize = 10;
        private int pageNumber;
        private int totalPage;


        private NhaCungCap nhaCungCap;
        private PhieuNhapHang phieuNhapHang;


        private Dictionary<string, Dictionary<string, HangHoaDataSource>> dictionaryDataSource;
        private HashSet<string> hashMaHangHoa;
        private DataTable dtHoaDon;
        private BindingSource bindingSource = new BindingSource();
        private BindingList<NguyenLieuDataSource> bindingListPhieu=new BindingList<NguyenLieuDataSource>();
        private BindingList<DTO.NguyenLieu> bindingListNguyenLieu = new BindingList<DTO.NguyenLieu>();
        private BindingSource nguyenLieuSource = new BindingSource();
        private uint tongCong;
        private float giamGia;



        private List<LoaiHangHoa> listTenGroup;


        private void khoiTao()
        {
            dictionaryDataSource = new Dictionary<string, Dictionary<string, HangHoaDataSource>>();

            TongCong = 0;

            giamGia = 0.0f;
            //txtGiamGia.Text = giamGia.ToString() + "%";

            hashMaHangHoa = new HashSet<string>();
            dGVHoaDon.AllowUserToAddRows = false;
            bindingSource.Add(new NguyenLieuDataSource());
            dGVHoaDon.DataSource = bindingSource;
            bindingSource.RemoveAt(0);
            dGVHoaDon.Columns["Ten"].HeaderText = "Tên";

            dGVHoaDon.Columns["Gia"].HeaderText = "Giá";

            dGVHoaDon.Columns["Soluong"].HeaderText = "Số lượng";
            dGVHoaDon.Columns["Thanhtien"].HeaderText = "Thành tiền";
            dGVHoaDon.Columns["DonViTinh"].HeaderText = "Đơn vị tính";

            dGVHoaDon.Columns["Ma"].Visible = false;
            dGVHoaDon.Columns["Loai"].Visible = false;


            dGVHoaDon.Columns["Gia"].ReadOnly = true;
            dGVHoaDon.Columns["Ten"].ReadOnly = true;
            dGVHoaDon.Columns["Thanhtien"].ReadOnly = true;

            //    var grouper = new Subro.Controls.DataGridViewGrouper(dGVHoaDon);
            //      grouper.SetGroupOn("MaLoaiHangHoa");
            //grouper.Options.GroupSortOrder = SortOrder.None;
            //    grouper.DisplayGroup += grouper_DisplayGroup;

            nguyenLieuSource.Add(BUS.NguyenLieuBUS.TimKiemDanhSachNguyenLieu("", nhaCungCap.Ma, false, 1, pageSize));
            //  nguyenLieuSource.da
            bindingListNguyenLieu =new BindingList<DTO.NguyenLieu>( BUS.NguyenLieuBUS.TimKiemDanhSachNguyenLieu("", nhaCungCap.Ma, false, 1, pageSize));
            dGVNguyenLieu.DataSource = bindingListNguyenLieu;
            dGVNguyenLieu.Columns["Ten"].HeaderText = "Tên";
            dGVNguyenLieu.Columns["Ma"].HeaderText = "Mã";
            dGVNguyenLieu.Columns["Loai"].HeaderText = "Loại";
            dGVNguyenLieu.Columns["NhaCungCap"].HeaderText = "Nhà cung cấp";
            dGVNguyenLieu.Columns["DonViTinh"].HeaderText = "Đơn vị tinh";
            dGVNguyenLieu.Columns["Dongia"].HeaderText = "Đơn giá";
            dGVNguyenLieu.Columns["SoLuongTon"].HeaderText = "Số lượng tồn";
            dGVNguyenLieu.Columns["SoLuongToiThieu"].Visible = false;

            List<NguyenLieuDataSource> temp = BUS.NguyenLieuBUS.XemChiTietPhieuNhapNguyenlieu(phieuNhapHang.SoPhieu);
            if (temp != null)
            {
                uint tongCong = 0;
                for (int i = 0; i < temp.Count; i++)
                {
                    hashMaHangHoa.Add(temp[i].Ma);
                  
                    bindingSource.Add(temp[i]);
                    tongCong += uint.Parse(temp[i].Thanhtien);

                }
                TongCong = tongCong;

            }
            //listTenGroup = new List<LoaiHangHoa>();
            //listTenGroup.AddRange(BUS.HangHoaBUS.XemLoaiMon(2));
            //if (listTenGroup != null)
            //{

            //    for (int i = 0; i < listTenGroup.Count; i++)
            //    {
            //        dictionaryDataSource.Add(listTenGroup[i].Ten, new Dictionary<string, HangHoaDataSource>());
            //    }
            //}
            //if (soHoaDon != "")
            //{
            //    List<HangHoaDataSource> temp = BUS.HoaDonBUS.XemChiTietHoaDonGoiMon(soHoaDon);
            //    if (temp != null)
            //    {
            //        uint tongCong = 0;
            //        for (int i = 0; i < temp.Count; i++)
            //        {
            //            hashMaHangHoa.Add(temp[i].Ma);
            //            dictionaryDataSource[temp[i].TenLoaiHangHoa].Add(temp[i].Ma, temp[i]);
            //            bindingSource.Add(temp[i]);
            //            tongCong += uint.Parse(temp[i].Thanhtien);

            //        }
            //        TongCong = tongCong;

            //    }
            //}

            //  thayDoiLoai();


        }
        private void sapXepLaiDanhSachHoaDon()
        {
            bindingSource.Clear();
            foreach (KeyValuePair<string, Dictionary<string, HangHoaDataSource>> itemSource in dictionaryDataSource)
            {
                foreach (KeyValuePair<string, HangHoaDataSource> item in itemSource.Value)
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

            pageNumber = 1;
            txtPageNumber.Text = "1";
            totalPage = BUS.NguyenLieuBUS.DemNguyenLieu(txtTenNguyenLieu.Text, nhaCungCap.Ma, rbHetSoLuong.Checked);
            totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();

            bindingListNguyenLieu = new BindingList<DTO.NguyenLieu>(
                BUS.NguyenLieuBUS.TimKiemDanhSachNguyenLieu(txtTenNguyenLieu.Text, nhaCungCap.Ma, rbHetSoLuong.Checked, pageNumber, pageSize));
           // bindingList = ;

            //nguyenLieuSource.DataSource

        }
        private void rbTatCa_CheckedChanged(object sender, EventArgs e)
        {
            thayDoiLoai();
        }
        private void frmGoiMon_Load(object sender, EventArgs e)
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
            nguyenLieuSource.Add(BUS.NguyenLieuBUS.TimKiemDanhSachNguyenLieu(txtTenNguyenLieu.Text, nhaCungCap.Ma, rbHetSoLuong.Checked, pageNumber, pageSize));
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
            nguyenLieuSource.Add(BUS.NguyenLieuBUS.TimKiemDanhSachNguyenLieu(txtTenNguyenLieu.Text, nhaCungCap.Ma, rbHetSoLuong.Checked, pageNumber, pageSize));
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();
            nguyenLieuSource.Add(BUS.NguyenLieuBUS.TimKiemDanhSachNguyenLieu(txtTenNguyenLieu.Text, nhaCungCap.Ma, rbHetSoLuong.Checked, pageNumber, pageSize));
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            pageNumber = totalPage;
            txtPageNumber.Text = pageNumber.ToString();
            nguyenLieuSource.Add(BUS.NguyenLieuBUS.TimKiemDanhSachNguyenLieu(txtTenNguyenLieu.Text, nhaCungCap.Ma, rbHetSoLuong.Checked, pageNumber, pageSize));
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
            nguyenLieuSource.Add(BUS.NguyenLieuBUS.TimKiemDanhSachNguyenLieu(txtTenNguyenLieu.Text, nhaCungCap.Ma, rbHetSoLuong.Checked, pageNumber, pageSize));
        }




        private void dGVHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(phieuNhapHang.NgayGiao!="" && phieuNhapHang.NgayGiao != null)
                {
                    MessageBox.Show("Đơn đặt hàng đã giao bạn không được phép sửa");
                    return;
                }
                if (e.ColumnIndex == 0 && e.RowIndex > -1)
                {
                   
                    string maHangHoa = dGVHoaDon[1, e.RowIndex].Value.ToString();
                    hashMaHangHoa.Remove(maHangHoa);
                    

                    TongCong = TongCong - (uint.Parse(dGVHoaDon[3, e.RowIndex].Value.ToString()) *
                        uint.Parse(dGVHoaDon[4, e.RowIndex].Value.ToString()));
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
                    dGVHoaDon[5, e.RowIndex].Value = int.Parse(dGVHoaDon[3, e.RowIndex].Value.ToString()) *
                        int.Parse(dGVHoaDon[4, e.RowIndex].Value.ToString());

                }
            }
            catch (Exception)
            {


            }

        }

        private void dGVHoaDon_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4 && e.RowIndex > -1)
                {
                    uint oldValue = uint.Parse(dGVHoaDon[e.ColumnIndex, e.RowIndex].Value.ToString());
                    uint newValue = uint.Parse(e.FormattedValue.ToString());
                    TongCong = TongCong - oldValue * uint.Parse(dGVHoaDon[3, e.RowIndex].Value.ToString())
                        + newValue * uint.Parse(dGVHoaDon[4, e.RowIndex].Value.ToString());
                }
            }
            catch (Exception)
            {


            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            List<string> maSanPham = new List<string>();
            List<string> soluongSanPham = new List<string>();

            for (int i = 0; i < dGVHoaDon.Rows.Count; i++)
            {
                string ma = dGVHoaDon[1, i].Value.ToString();
                string soluong = dGVHoaDon[4, i].Value.ToString();
                maSanPham.Add(ma);
                soluongSanPham.Add(soluong);
            }
            if (BUS.NguyenLieuBUS.NhapHangNguyeLieu(phieuNhapHang.SoPhieu, maSanPham, soluongSanPham, TongCong))
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
            //if (BUS.HoaDonBUS.ThanhToan(soHoaDon))
            //{
            //    MessageBox.Show("Thanh toán thành công");
            //}
            //else
            //{
            //    MessageBox.Show("Có lỗi xảy ra!. Vui lòng mời nhân viên kỹ thuật kiểm tra!!!");
            //}
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
            frmInDonDatNguyenLieu   inDonDatNguyenLieu = new frmInDonDatNguyenLieu(nhaCungCap, phieuNhapHang);
            inDonDatNguyenLieu.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void dGVNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (phieuNhapHang.NgayGiao != "" && phieuNhapHang.NgayGiao != null)
            {
                MessageBox.Show("Đơn đặt hàng đã giao bạn không được phép sửa");
                return;
            }
            if (dGVNguyenLieu.CurrentRow != null)
            {
                int index = dGVNguyenLieu.CurrentRow.Index;
                string soHD = dGVNguyenLieu[5, index].Value.ToString();
                DTO.NguyenLieu nguyenLieu= bindingListNguyenLieu[index];

                if (hashMaHangHoa.Contains(nguyenLieu.Ma))
                {
                    for (int i = 0; i < bindingSource.Count; i++)
                    {
                        if(((NguyenLieuDataSource)bindingSource[i]).Ma== nguyenLieu.Ma)
                        {
                            index = i;
                            break;
                        }
                    }
               
                    dGVHoaDon[4, index].Value = int.Parse(dGVHoaDon[4, index].Value.ToString()) + 1;
                    return;
                }
     
                string maHangHoa = nguyenLieu.Ma;
            


                hashMaHangHoa.Add(maHangHoa);
                bindingSource.Add(new NguyenLieuDataSource()
                {
                    Ma = nguyenLieu.Ma,
                    Ten = nguyenLieu.Ten,
                    DonViTinh = nguyenLieu.DonViTinh,
                    Gia = nguyenLieu.Dongia.ToString(),
                    Loai = nguyenLieu.Loai,
                    Soluong = "1",
                    Thanhtien = nguyenLieu.Dongia.ToString(),
                });
                TongCong = TongCong +nguyenLieu.Dongia;
            }
        }

      
    }
}
