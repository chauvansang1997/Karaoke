using BUS;
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
        private const int pageSize = 5;
        private int pageNumber;
        private int totalPage;

        private TrangThai trangThai;
        private Dictionary<int, List<PhongLayout>> dictionaryHienTai;
        private Dictionary<int, List<PhongLayout>> dictionaryAllLayout;
        private Dictionary<int, List<PhongLayout>> dictionaryAvailableLayout;
        private Dictionary<int, List<PhongLayout>> dictionaryUnAvailableLayout;

        private Dictionary<int, List<ThongTinDatPhongLayout>> dictionaryThongTinDpHienTai;

        private List<PhongLayout> listPhongLayout;
        private List<Phong> listAllPhong;
        private List<ThongTinDatPhong> thongTinDatPhongs;
        private List<ThongTinDatPhongLayout> thongTinDatPhongLayouts;

        private bool xemPhong = true;
        private ThongTinDatPhong thongTinDatPhong;
        private Phong phongHienTai;
        private int indexHienTai;
        private int indexTruoc;

        private int indexDatPhongHienTai;
        private int indexDatPhongTruoc;
        public Phong PhongHienTai
        {
            get
            {
                return phongHienTai;
            }
            set
            {
                phongHienTai = value;
                //txtTenPhong.Text = phongHienTai.Ten;
                //txtGia.Text = phongHienTai.Gia.ToString();
                //txtLoaiPhong.Text = phongHienTai.TenLoai;
                txtTenKhachHang.Text = phongHienTai.GetKhachHang != null ? phongHienTai.GetKhachHang.Ten : "";
                txtSDT.Text = phongHienTai.GetKhachHang != null ? phongHienTai.GetKhachHang.SoDT : "";
            }
        }



        public frmPhongKaraoke()
        {

            InitializeComponent();
            khoiTao();
        }
        private void thayDoiTrangThai()
        {
            if (xemPhong)
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
            else
            {
                totalPage = Utility.TinhKichThuocTrang(BUS.DatPhongBUS.DemThongTinDatPhong(0), pageSize);
                txtTotalPage.Text = totalPage.ToString();
                pageNumber = 1;
                txtPageNumber.Text = "1";
                hienThiTatCaPhong();
            }

        }
        public void khoiTao()
        {
            txtTenKhachHang.Enabled = true;
            txtSDT.Enabled = true;
            //btnThanhToan.Enabled = false;
            settingsXemPhong.Checked = true;
            trangThai = TrangThai.TatCa;
            indexHienTai = -1;
            indexDatPhongHienTai = -1;
            dictionaryAllLayout = new Dictionary<int, List<PhongLayout>>();

            dictionaryAvailableLayout = new Dictionary<int, List<PhongLayout>>();

            dictionaryUnAvailableLayout = new Dictionary<int, List<PhongLayout>>();

            dictionaryThongTinDpHienTai = new Dictionary<int, List<ThongTinDatPhongLayout>>();
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
            indexDatPhongHienTai = -1;
            trangThai = TrangThai.TatCa;
            dictionaryThongTinDpHienTai.Clear();
            xemPhong = false;
            settingsXemPhong.Checked = true;
            settingXemDanhSachDatPhong.Checked = false;
            dictionaryHienTai.Clear();
            panelChoice.Height = btnTatCa.Height;
            panelChoice.Top = btnTatCa.Top;
            hienThiTatCaPhong();
        }
        private void hienThiTatCaPhong()
        {
            indexHienTai = -1;
            flowPhongLayout.Controls.Clear();
            if (xemPhong)
            {
                if (dictionaryHienTai.ContainsKey(pageNumber) == false)
                {
                    listAllPhong = BUS.PhongBUS.XemPhong((int)trangThai, pageSize, pageNumber);
                    listPhongLayout = new List<PhongLayout>();

                    for (int i = 0; i < listAllPhong.Count; i++)
                    {
                        DTO.Phong item = listAllPhong[i];

                        PhongLayout phongLayout = new PhongLayout() { Phong = item, IndexList = i };
                        phongLayout.Ten = item.Ten;
                        phongLayout.Loai = item.TenLoai;

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
                            if (listPhongLayout[indexHienTai].Phong.TinhTrang == 0)
                            {
                                btnGoiMon.Enabled = false;
                            }
                            else {
                                btnGoiMon.Enabled = true;
                            }

                            PhongHienTai = phongLayout.Phong;

                            phongLayout.BackColor = Color.Blue;

                            //if (PhongHienTai.TinhTrang == 0)
                            //{
                            //    //txtTenKhachHang.ReadOnly = false;
                            //    txtSDT.ReadOnly = false;
                            //}
                            //else
                            //{
                            //    txtTenKhachHang.ReadOnly = true;
                            //    txtSDT.ReadOnly = true;
                            //}
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
            else
            {
                thongTinDatPhongs = BUS.DatPhongBUS.XemThongTinDatPhong(0, pageSize, pageNumber);

                thongTinDatPhongLayouts = new List<ThongTinDatPhongLayout>();
                if (dictionaryThongTinDpHienTai.ContainsKey(pageNumber) == false)
                {
                    for (int i = 0; i < thongTinDatPhongs.Count; i++)
                    {
                        DTO.ThongTinDatPhong item = thongTinDatPhongs[i];

                        ThongTinDatPhongLayout thongTinDatPhongLayout = new ThongTinDatPhongLayout()
                        {
                            ThongTinDatPhong = item,
                            IndexList = i
                        };

                        thongTinDatPhongLayout.Ten = item.khachHang.Ten;

                        thongTinDatPhongLayout.BackColor = Color.ForestGreen;

                        thongTinDatPhongLayout.setClick((sender, e) =>
                        {
                            indexDatPhongTruoc = indexDatPhongHienTai;
                          
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
                            indexDatPhongHienTai = thongTinDatPhongLayout.IndexList;

                            thongTinDatPhong = thongTinDatPhongLayout.ThongTinDatPhong;

                            thongTinDatPhongLayout.BackColor = Color.Blue;

                            //txtTenKhachHang.ReadOnly = false;
                            //txtSDT.ReadOnly = false;

                            txtTenKhachHang.Text = thongTinDatPhong.khachHang.Ten;
                            if (txtTenKhachHang.Text == "")
                            {
                                txtTenKhachHang.Text = "Vãn lai";
                            }
                            txtSDT.Text = thongTinDatPhong.khachHang.SoDT;
                            //if (PhongHienTai.TinhTrang == 0)
                            //{

                            //}
                            //else
                            //{
                            //    txtTenKhachHang.ReadOnly = true;
                            //    txtSDT.ReadOnly = true;
                            //}
                        });
                        flowPhongLayout.Controls.Add(thongTinDatPhongLayout);

                        thongTinDatPhongLayouts.Add(thongTinDatPhongLayout);
                    }
                    dictionaryThongTinDpHienTai.Add(pageNumber, thongTinDatPhongLayouts);
                }
                else
                {
                    thongTinDatPhongLayouts = dictionaryThongTinDpHienTai[pageNumber];
                    for (int i = 0; i < thongTinDatPhongLayouts.Count; i++)
                    {
                        flowPhongLayout.Controls.Add(thongTinDatPhongLayouts[i]);
                    }
                }

            }



        }


        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            string maKhachHang = KhachHangBUS.ThemKhachHangThanhVien(new DTO.KhachHang()
            {
                Ten = txtTenKhachHang.Text,
                SoDT = txtSDT.Text,

            });
            frmChonPhongKaraoke chonPhongKaraoke = new frmChonPhongKaraoke(new DTO.KhachHang
            {
                Ten = txtTenKhachHang.Text,
                SoDT = txtSDT.Text,
                Ma = maKhachHang
            }, this);
            chonPhongKaraoke.ShowDialog();
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
            if (xemPhong)
            {
                panelChoice.Height = btnTrong.Height;
                panelChoice.Top = btnTrong.Top;

                if (trangThai != TrangThai.ChuaDat)
                {
                    trangThai = TrangThai.ChuaDat;
                    thayDoiTrangThai();
                }

            }


        }

        private void btnDaDat_Click(object sender, EventArgs e)
        {
            if (xemPhong)
            {
                panelChoice.Height = btnDaDat.Height;
                panelChoice.Top = btnDaDat.Top;

                if (trangThai != TrangThai.DaDat)
                {
                    trangThai = TrangThai.DaDat;
                    thayDoiTrangThai();
                }
            }

        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            if (xemPhong)
            {
                panelChoice.Height = btnTatCa.Height;
                panelChoice.Top = btnTatCa.Top;
                if (trangThai != TrangThai.TatCa)
                {
                    trangThai = TrangThai.TatCa;
                    thayDoiTrangThai();
                }
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

        private void btnFind_Click(object sender, EventArgs e)
        {
            frmChonThanhVien chonThanhVien = new frmChonThanhVien();
            chonThanhVien.ShowDialog();
            txtTenKhachHang.Text = chonThanhVien.khachHang.Ten;
            txtSDT.Text = chonThanhVien.khachHang.SoDT;
        }

        private void settingsXemPhong_Click(object sender, EventArgs e)
        {
            xemPhong = true;
            settingXemDanhSachDatPhong.Checked = false;
            settingsXemPhong.Checked = true;
            //btnThanhToan.Enabled = false;
            btnGoiMon.Enabled = true;
            if (indexHienTai != -1)
            {
                dictionaryHienTai[pageNumber][indexHienTai].BackColor = Color.ForestGreen;
            }


            thayDoiTrangThai();
        }

        private void settingXemDanhSachDatPhong_Click(object sender, EventArgs e)
        {
            xemPhong = false;
            settingXemDanhSachDatPhong.Checked = true;
            settingsXemPhong.Checked = false;
            //btnThanhToan.Enabled = true;
            btnGoiMon.Enabled = false;
            if (indexDatPhongHienTai != -1)
            {
                dictionaryThongTinDpHienTai[pageNumber][indexDatPhongHienTai].BackColor = Color.ForestGreen;
            }
            thayDoiTrangThai();
            // hienThiTatCaPhong();
        }

        private void btnGoiMon_Click(object sender, EventArgs e)
        {
            // string soHoaDon = BUS.HoaDonBUS.LayMaHoaDon(listPhongLayout[indexHienTai].Phong.Ten);
            string maDatPhong = BUS.DatPhongBUS.LayMaDatPhong(listPhongLayout[indexHienTai].Phong.Ten);

            frmGoiMon goiMon = new frmGoiMon(maDatPhong, listPhongLayout[indexHienTai].Phong.Ten, this);
            goiMon.ShowDialog();
            //if (BUS.HoaDonBUS.HoaDonDatTiec(soHoaDon))
            //{
            //    frmChonMon chonMon = new frmChonMon(soHoaDon);
            //    chonMon.ShowDialog();
            //}
            //else
            //{

            //}
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (xemPhong)
            {
                if(PhongHienTai.TinhTrang == 1)
                {
                    BUS.DatPhongBUS.ThanhToanPhong(PhongHienTai.Ten);
                    dictionaryThongTinDpHienTai.Clear();
                    dictionaryHienTai.Clear();
                    indexDatPhongHienTai = -1;
                    indexHienTai = -1;
                    hienThiTatCaPhong();
                }
            }
            else
            {
                if (thongTinDatPhong != null)
                {
                    BUS.DatPhongBUS.ThanhToanHoaDon(thongTinDatPhong.maDatPhong);
                    dictionaryThongTinDpHienTai.Clear();
                    dictionaryHienTai.Clear();
                    indexDatPhongHienTai = -1;
                    indexHienTai = -1;
                    hienThiTatCaPhong();
                }
            }
           
        }
    }
}
