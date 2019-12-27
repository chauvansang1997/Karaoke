using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAO
{
    public static class DatPhongDao
    {
        public static int DemThongTinDatPhong(int thanhToan)
        {
            KaraokeDataContext karaokeDataContext = new KaraokeDataContext();
            return
           (from ttdp in karaokeDataContext.THONGTINDATPHONGs

            where ttdp.DATHANHTOAN == (thanhToan == -1 ? ttdp.DATHANHTOAN : thanhToan) && ttdp.NGAYNHAN != null
            select new ThongTinDatPhong()
            {
                giamGia = (uint)ttdp.GIAMGIA,
                khachHang = new KhachHang()
                {
                    Ma = ttdp.KHACHHANG.MAKH,
                    LoaiKH = ttdp.KHACHHANG.LOAIKHACHHANG.MALOAIKH,
                    SoDT = ttdp.KHACHHANG.SDT,
                    Ten = ttdp.KHACHHANG.TENKH
                },
                maDatPhong = ttdp.MADATPHONG,
                ngayDat = ttdp.NGAYDAT.Value,
                ngayNhan = ttdp.NGAYNHAN.Value,
                tienCoc = (uint)ttdp.TIENCOC
            }).Count();
        }
        public static List<ThongTinDatPhong> XemThongTinDatPhong(int thanhToan, int pageSize, int pageNumber)
        {
            KaraokeDataContext karaokeDataContext = new KaraokeDataContext();
            // Utility.
            var list = (from ttdp in karaokeDataContext.THONGTINDATPHONGs

                        where ttdp.DATHANHTOAN == (thanhToan == -1 ? ttdp.DATHANHTOAN : thanhToan) && ttdp.NGAYNHAN != null
                        select new ThongTinDatPhong()
                        {
                            giamGia = (uint)ttdp.GIAMGIA,
                            khachHang = new KhachHang()
                            {
                                Ma = ttdp.KHACHHANG.MAKH,
                                LoaiKH = ttdp.KHACHHANG.LOAIKHACHHANG.MALOAIKH,
                                SoDT = ttdp.KHACHHANG.SDT,
                                Ten = ttdp.KHACHHANG.TENKH
                            },
                            maDatPhong = ttdp.MADATPHONG,
                            ngayDat = ttdp.NGAYDAT.Value,
                            ngayNhan = ttdp.NGAYNHAN.Value,
                            tienCoc = (uint)ttdp.TIENCOC,
                            nhanVien = User.NhanVien
                            
                        }).Skip((pageNumber - 1) * pageSize).Take(pageSize);
            return list.ToList();

        }
        public static DataTable XemDanhSachDatPhong(int thanhToan, int pageSize, int pageNumber)
        {
            KaraokeDataContext karaokeDataContext = new KaraokeDataContext();
            // Utility.
            var list = (from ttdp in karaokeDataContext.THONGTINDATPHONGs
                        where ttdp.DATHANHTOAN == (thanhToan == -1 ? ttdp.DATHANHTOAN : thanhToan) && ttdp.NGAYNHAN != null
                        select new
                        {
                            ttdp.MADATPHONG,
                            ttdp.GIAMGIA,
                            ttdp.MAKH,
                            ttdp.MANV,
                            ttdp.NGAYDAT,
                            ttdp.NGAYNHAN,
                            ttdp.TIENCOC,
                            ttdp.DATHANHTOAN
                        }).Skip((pageNumber - 1) * pageSize).Take(pageSize);
            return Utility.ConvertToDataTable(list.ToList());

        }
        public static int DemDanhSachDatPhong(int thanhToan)
        {
            KaraokeDataContext karaokeDataContext = new KaraokeDataContext();

            var list = from ttdp in karaokeDataContext.THONGTINDATPHONGs
                       where ttdp.DATHANHTOAN == (thanhToan == -1 ? ttdp.DATHANHTOAN : thanhToan) && ttdp.NGAYNHAN != null
                       select new
                       {
                           Ma = ttdp.MADATPHONG,
                           ttdp.GIAMGIA,
                           ttdp.MAKH,
                           ttdp.MANV,
                           ttdp.NGAYDAT,
                           ttdp.NGAYNHAN,
                           ttdp.TIENCOC,
                           ttdp.DATHANHTOAN
                       };
            return list.ToList().Count;
        }
        public static string LayMaDatPhong(string maPhong)
        {
            KaraokeDataContext karaokeDataContext = new KaraokeDataContext();
            return (from ttdp in karaokeDataContext.THONGTINDATPHONGs
                    join ctdp in karaokeDataContext.CHITIETDATPHONGs
                    on ttdp.MADATPHONG equals ctdp.MADATPHONG
                    where ctdp.MAPHONG == maPhong && ttdp.DATHANHTOAN == 0 && ttdp.NGAYNHAN != null
                    select ttdp.MADATPHONG).First();
        }

        public static bool ThanhToanHoaDon(string maDatPhong)
        {
            KaraokeDataContext karaokeDataContext = new KaraokeDataContext();

            //tính thành tiền
            long thanhTien = 0;
            DateTime now = DateTime.Now;
            //lấy danh sách phòng
            karaokeDataContext.CHITIETDATPHONGs.Where(ctdp => ctdp.MADATPHONG == maDatPhong).ToList().ForEach(
                    ctdp =>
                    {
                        karaokeDataContext.PHONGs.Where(p => p.MAPHONG == ctdp.MAPHONG).First().TINHTRANG = "0";
                        ctdp.GIORA = now;
                        karaokeDataContext.CHITIETGOIMONs.Where(ctgm => ctgm.MADATPHONG == maDatPhong
                        && ctgm.MAPHONG == ctdp.MAPHONG).ToList().ForEach(
                                ctgm =>
                                {
                                    ctgm.GIA = ctgm.SANPHAM.DONGIA;
                                    thanhTien += (ctgm.GIA * ctgm.SOLUONG).Value;
                                    
                                }
                            );


                    }
                );
            //Tạo hóa đơn 
            string maHoaDon = TaoMa.TaoHoaDon();
            karaokeDataContext.TAOMAs.Where(taoMa => taoMa.ID == 3).First().MACUOI += 1;
            karaokeDataContext.HOADONs.InsertOnSubmit(new HOADON()
            {
                MAHD = maHoaDon,
                MADATPHONG = maDatPhong,
                NGAYGIOLAP = DateTime.Now,
                THANHTIEN = thanhTien
            });
            karaokeDataContext.THONGTINDATPHONGs.Where(ttdp => ttdp.MADATPHONG == maDatPhong).First().DATHANHTOAN = 1;
            karaokeDataContext.SubmitChanges();
            return true;
        }
    }
}
