using DTO;
using Karaoke.GuiMonAn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karaoke.PhongKaoraoke
{
    enum TrangThai
    {
        ChuaDat,
        DaDat,
        TatCa = -1
    }
    public partial class frmPhongKaraoke : Form
    {
        private const int pageSize = 10;
        private int pageNumber;
        private int totalPage;

        private TrangThai trangThai;
        private Dictionary<int, List<PhongLayout>> dictionaryHienTai;
        private Dictionary<int, List<PhongLayout>> dictionaryAllLayout;
        private Dictionary<int, List<PhongLayout>> dictionaryAvailableLayout;
        private Dictionary<int, List<PhongLayout>> dictionaryUnAvailableLayout;

        private List<PhongLayout> listPhongLayout;
        private List<Phong> listAllPhong;



        private Phong phongHienTai;
        private int indexHienTai;
        private int indexTruoc;
        public Phong PhongHienTai
        {
            get
            {
                return phongHienTai;
            }
            set
            {
                phongHienTai = value;
                txtTenPhong.Text = phongHienTai.Ten;
                txtGia.Text = phongHienTai.Gia.ToString();
                txtLoaiPhong.Text = phongHienTai.TenLoai;
                txtTenKhachHang.Text = phongHienTai.GetKhachHang.Ten;
                txtSDT.Text = phongHienTai.GetKhachHang.SoDT;
            }
        }


     
        public frmPhongKaraoke()
        {
           
            InitializeComponent();
            khoiTao();
        }
        private void thayDoiTrangThai()
        {
            try
            {
                if (listPhongLayout[indexHienTai].Phong.TinhTrang == 0)
                {
                    listPhongLayout[indexHienTai].BackColor = Color.ForestGreen;
                }
                else
                {
                    listPhongLayout[indexHienTai].BackColor = Color.DarkRed;
                }
            }
            catch (Exception)
            {

            }


            if (trangThai == TrangThai.TatCa)
            {
                totalPage = Utility.TinhKichThuocTrang(BUS.PhongBUS.DemPhong((int)trangThai), pageSize);
                txtTotalPage.Text = totalPage.ToString();
                pageNumber = 1;
                txtPageNumber.Text = "1";
                indexHienTai = -1;

                dictionaryHienTai = dictionaryAllLayout;
            }
            else if (trangThai == TrangThai.DaDat)
            {
                totalPage = Utility.TinhKichThuocTrang(BUS.PhongBUS.DemPhong((int)trangThai), pageSize);
                txtTotalPage.Text = totalPage.ToString();
                pageNumber = 1;
                txtPageNumber.Text = "1";
                indexHienTai = -1;
                dictionaryHienTai = dictionaryAvailableLayout;
            }
            else
            {
                totalPage = Utility.TinhKichThuocTrang(BUS.PhongBUS.DemPhong((int)trangThai), pageSize);
                txtTotalPage.Text = totalPage.ToString();
                pageNumber = 1;
                txtPageNumber.Text = "1";
                indexHienTai = -1;
                dictionaryHienTai = dictionaryUnAvailableLayout;
            }
            hienThiTatCaPhong();
        }
        public void khoiTao()
        {
            trangThai = TrangThai.TatCa;
            indexHienTai = -1;
            dictionaryAllLayout = new Dictionary<int, List<PhongLayout>>();

            dictionaryAvailableLayout = new Dictionary<int, List<PhongLayout>>();

            dictionaryUnAvailableLayout = new Dictionary<int, List<PhongLayout>>();
           // dictionaryPage = new Dictionary<int, int>();
            thayDoiTrangThai();
        }
        public void reset()
        {
            totalPage = Utility.TinhKichThuocTrang(BUS.PhongBUS.DemPhong((int)trangThai), pageSize);
            txtTotalPage.Text = totalPage.ToString();
            pageNumber = 1;
            txtPageNumber.Text = "1";
            indexHienTai = -1;

            dictionaryHienTai = dictionaryAllLayout;
            hienThiTatCaPhong();
        }
        private void hienThiTatCaPhong()
        {
            indexHienTai = -1;
            flowPhongLayout.Controls.Clear();
            if (dictionaryHienTai.ContainsKey(pageNumber) == false)
            {
                listAllPhong = BUS.PhongBUS.XemPhong((int)trangThai, pageSize, pageNumber);
                listPhongLayout = new List<PhongLayout>();
                for (int i = 0; i < listAllPhong.Count; i++)
                {
                    DTO.Phong item = listAllPhong[i];

                    PhongLayout phongLayout = new PhongLayout() { Phong = item, IndexList = i };
                    phongLayout.Ten = item.Ten;
                    if (item.TinhTrang == 0)
                    {
                        phongLayout.BackColor = Color.ForestGreen;
                    }
                    else
                    {
                        phongLayout.BackColor = Color.DarkRed;
                    }

                    phongLayout.setClick((sender, e) =>
                    {
                        indexTruoc = indexHienTai;
                        if (indexTruoc != -1)
                        {
                            if (listPhongLayout[indexTruoc].Phong.TinhTrang == 0)
                            {
                                listPhongLayout[indexTruoc].BackColor = Color.ForestGreen;
                            }
                            else
                            {
                                listPhongLayout[indexTruoc].BackColor = Color.DarkRed;
                            }
                        }
                        indexHienTai = phongLayout.IndexList;

                        PhongHienTai = phongLayout.Phong;

                        phongLayout.BackColor = Color.Blue;

                        if (PhongHienTai.TinhTrang == 0)
                        {
                            txtTenKhachHang.ReadOnly = false;
                            txtSDT.ReadOnly = false;
                        }
                        else
                        {
                            txtTenKhachHang.ReadOnly = true;
                            txtSDT.ReadOnly = true;
                        }
                    });
                    flowPhongLayout.Controls.Add(phongLayout);

                    listPhongLayout.Add(phongLayout);
                }
                dictionaryHienTai.Add(pageNumber, listPhongLayout);
            }
            else
            {
                listPhongLayout = dictionaryHienTai[pageNumber];
                for (int i = 0; i < listPhongLayout.Count; i++)
                {
                    flowPhongLayout.Controls.Add(listPhongLayout[i]);
                }
            }
        }


        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đặt phòng không?", "Xác nhận", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                if (BUS.PhongBUS.GhiNhanDatPhong(new DTO.KhachHang() { Ten = txtTenKhachHang.Text, SoDT = txtSDT.Text }, PhongHienTai.Ten, "NV001"))
                {
                    MessageBox.Show("Đặt phòng thành công");
                    listPhongLayout[indexHienTai].BackColor = Color.DarkRed;
                    listPhongLayout[indexHienTai].Phong.TinhTrang = 1;
                    listPhongLayout[indexHienTai].Phong.GetKhachHang.Ten = txtTenKhachHang.Text;
                    listPhongLayout[indexHienTai].Phong.GetKhachHang.SoDT = txtSDT.Text;
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

        private void frmPhongKaraoke_Load(object sender, EventArgs e)
        {

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
            hienThiTatCaPhong();
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
            hienThiTatCaPhong();
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();
            hienThiTatCaPhong();
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            pageNumber = totalPage;
            txtPageNumber.Text = pageNumber.ToString();
            hienThiTatCaPhong();
        }
        private void btnTrong_Click(object sender, EventArgs e)
        {
            panelChoice.Height = btnTrong.Height;
            panelChoice.Top = btnTrong.Top;

            if (trangThai != TrangThai.ChuaDat)
            {
                trangThai = TrangThai.ChuaDat;
                thayDoiTrangThai();
            }


        }

        private void btnDaDat_Click(object sender, EventArgs e)
        {
            panelChoice.Height = btnDaDat.Height;
            panelChoice.Top = btnDaDat.Top;

            if (trangThai != TrangThai.DaDat)
            {
                trangThai = TrangThai.DaDat;
                thayDoiTrangThai();
            }
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            panelChoice.Height = btnTatCa.Height;
            panelChoice.Top = btnTatCa.Top;
            if (trangThai != TrangThai.TatCa)
            {
                trangThai = TrangThai.TatCa;
                thayDoiTrangThai();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                string soHoaDon = BUS.HoaDonBUS.LayMaHoaDon(listPhongLayout[indexHienTai].Phong.Ten);
                
                if (BUS.HoaDonBUS.HoaDonDatTiec(soHoaDon))
                {
                    frmChonMon chonMon = new frmChonMon(soHoaDon);
                    chonMon.ShowDialog();
                }
                else
                {
                    frmGoiMon goiMon = new frmGoiMon(soHoaDon,this);
                    goiMon.ShowDialog();
                }
            }
            catch (Exception)
            {            
            }   
        }

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

        private void btnChuyenPhong_Click(object sender, EventArgs e)
        {
            if (PhongHienTai != null)
            {
                frmChuyenPhong chuyenPhong = new frmChuyenPhong(PhongHienTai.Ten);
                chuyenPhong.ShowDialog();
                khoiTao();
            }
        }

        private void txtPageNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
