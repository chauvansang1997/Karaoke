using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhongDAO
    {
        /// <summary>
        /// Hàm thêm phòng
        /// </summary>
        /// <param name="phong"></param>
        /// <returns>bool</returns>
        public static bool ThemPhong(Phong phong)
        {
            KaraokeDataContext karaokeDataContext = new KaraokeDataContext();
            string ma = TaoMa.TaoMaPhong();
            //Truy vấn thêm phòng
            try
            {
                karaokeDataContext.PHONGs.InsertOnSubmit(new PHONG()
                {
                    MAPHONG = ma,
                    MALOAIPHONG = Int32.Parse(phong.TenLoai),
                    TINHTRANG = "1"
                });
                ChangeSet cs = karaokeDataContext.GetChangeSet();
                if (cs.Inserts.Count() == 1)
                {
                    karaokeDataContext.SubmitChanges();
                    return true;
                }

            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            return false;
        }
        /// <summary>
        /// Hàm cập nhật phòng
        /// </summary>
        /// <param name="phong"></param>
        /// <returns>bool</returns>
        public static bool CapNhatPhong(Phong phong)
        {
            using (KaraokeDataContext karaokeDataContext = new KaraokeDataContext())
            {
                try
                {
                    karaokeDataContext.PHONGs.Single(phg => phg.MAPHONG == phong.Ten).MALOAIPHONG = Int32.Parse(phong.TenLoai);

                    ChangeSet cs = karaokeDataContext.GetChangeSet();
                    if (cs.Updates.Count() == 1)
                    {
                        karaokeDataContext.SubmitChanges();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Utility.Log(ex);
                }
                return false;
            }
        }
        /// <summary>
        /// Hàm xem phòng theo loại phong
        /// </summary>
        /// <param name="loaiPhong"></param>
        /// <param name="tuKhoa"></param>
        /// <returns>DataTable phong</returns>
        public static DataTable XemPhongTheoLoai(string loaiPhong, string tuKhoa, int pageNumber, int pageSize)
        {
            DataTable dtXemPhongTheoLoai = null;

            using (KaraokeDataContext karaokeDataContext = new KaraokeDataContext())
            {

                try
                {
                    if (tuKhoa.Length > 0)
                    {
                        tuKhoa = tuKhoa.ToLower();
                        var query = (from phongTheoLoai in karaokeDataContext.PHONGs
                                     where (phongTheoLoai.LOAIPHONG.TENLOAIPHONG == loaiPhong &&
                                     (phongTheoLoai.MAPHONG.ToLower().Contains(tuKhoa) ||
                                        phongTheoLoai.TINHTRANG.ToLower().ToLower().Contains(tuKhoa) ||
                                        phongTheoLoai.LOAIPHONG.TENLOAIPHONG.ToLower().Contains(tuKhoa) ||
                                        phongTheoLoai.LOAIPHONG.GIA.ToString().ToLower().Contains(tuKhoa)
                                     ))
                                     select new { phongTheoLoai.MAPHONG, phongTheoLoai.LOAIPHONG.TENLOAIPHONG, phongTheoLoai.LOAIPHONG.GIA })
                                     .Skip((pageNumber - 1) * pageSize)
                                     .Take(pageSize);
                        dtXemPhongTheoLoai = Utility.ConvertToDataTable(query.ToList());
                    }
                    else
                    {
                        var query = (from phongTheoLoai in karaokeDataContext.PHONGs
                                     where (phongTheoLoai.LOAIPHONG.TENLOAIPHONG == loaiPhong)
                                     select new { phongTheoLoai.MAPHONG, phongTheoLoai.LOAIPHONG.TENLOAIPHONG, phongTheoLoai.LOAIPHONG.GIA })
                                      .Skip((pageNumber - 1) * pageSize)
                                     .Take(pageSize);
                        dtXemPhongTheoLoai = Utility.ConvertToDataTable(query.ToList());
                    }
                    return dtXemPhongTheoLoai;

                }
                catch (Exception ex)
                {
                    Utility.Log(ex);
                }
                return dtXemPhongTheoLoai;
            }
        }
        /// <summary>
        /// Hàm xóa phòng
        /// </summary>
        /// <param name="phong"></param>
        /// <returns>bool</returns>
        public static bool XoaPhong(Phong phong)
        {
            using (KaraokeDataContext karaokeDataContext = new KaraokeDataContext())
            {
                try
                {
                    var phg = (from phongCT in karaokeDataContext.PHONGs
                               where (phongCT.MAPHONG == phong.Ten)
                               select phongCT).SingleOrDefault();
                    karaokeDataContext.PHONGs.DeleteOnSubmit(phg);
                    karaokeDataContext.SubmitChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    Utility.Log(ex);
                }
                return false;
            }
        }
        /// <summary>
        /// Ghi nhận đặt phòng
        /// </summary>
        /// <param name="khachHang"></param>
        /// <param name="maPhong"></param>
        /// <param name="maNV"></param>
        /// <returns></returns>
        public static bool GhiNhanDatPhong(KhachHang khachHang, string maPhong, string maNV)
        {
            string query = "EXEC uspGhiNhanDatPhong @maPhong,@tenKhachHang,@soDienThoai,@soHoaDon,@maNV";


            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maPhong",SqlDbType.VarChar){ Value=maPhong  },
                 new SqlParameter("@tenKhachHang",SqlDbType.NVarChar){ Value=khachHang.Ten  },
                  new SqlParameter("@soDienThoai",SqlDbType.VarChar){ Value=khachHang.SoDT  },
                  new SqlParameter("@soHoaDon",SqlDbType.VarChar){ Value=""  },
                  new SqlParameter("@maNV",SqlDbType.VarChar){ Value=maNV  },

            };
            try
            {
                Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
                return false;
            }
            return true;
        }
        public static bool NhanPhongDatTruoc(string soHoaDon)
        {
            string query = "EXEC uspNhanPhong @soHoaDon,@NgayNhan";


            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                  new SqlParameter("@soHoaDon",SqlDbType.VarChar){ Value=soHoaDon  },
                  new SqlParameter("@soHoaDon",SqlDbType.DateTime){ Value=DateTime.Now  },


            };
            try
            {
                Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
                return false;
            }
            return true;
        }

        public static bool NhanPhongDatTruoc(ThongTinDatPhong thongTinDatPhong)
        {
            KaraokeDataContext karaokeDataContext = new KaraokeDataContext();

            string maDatPhong = TaoMa.TaoMaDatPhong();
            karaokeDataContext.TAOMAs.Where(taoMa => taoMa.ID == 16).First().MACUOI += 1;
            karaokeDataContext.THONGTINDATPHONGs.InsertOnSubmit(new THONGTINDATPHONG()
            {
                MADATPHONG = maDatPhong,
                GIAMGIA = thongTinDatPhong.giamGia,
                MAKH = thongTinDatPhong.khachHang.Ma,
                MANV = thongTinDatPhong.nhanVien.MaNV,
                NGAYDAT = thongTinDatPhong.ngayDat,
                NGAYNHAN = thongTinDatPhong.ngayNhan,
                TIENCOC = thongTinDatPhong.tienCoc,
            });

            var phongs = karaokeDataContext.CHITIETDATPHONGs.Where(ctdp => ctdp.MADATPHONG == thongTinDatPhong.maDatPhong);
            //thêm chi tiết đặt phòng
            foreach (var phong in phongs)
            {
                karaokeDataContext.PHONGs.Where(p => p.MAPHONG == phong.MAPHONG).First().TINHTRANG = "1";
                karaokeDataContext.CHITIETDATPHONGs.Where(ctdp => (ctdp.MAPHONG == phong.MAPHONG &&
                ctdp.MADATPHONG == thongTinDatPhong.maDatPhong)).First().GIOVAO = DateTime.Now;
            }
            karaokeDataContext.SubmitChanges();

            return true;
        }
        public static bool DatPhongTruoc(List<Phong> phongs, ThongTinDatPhong thongTinDatPhong)
        {
            KaraokeDataContext karaokeDataContext = new KaraokeDataContext();

            string maDatPhong = TaoMa.TaoMaDatPhong();
            karaokeDataContext.TAOMAs.Where(taoMa => taoMa.ID == 16).First().MACUOI += 1;
            karaokeDataContext.THONGTINDATPHONGs.InsertOnSubmit(
                new THONGTINDATPHONG()
                {
                    MADATPHONG = maDatPhong,
                    GIAMGIA = thongTinDatPhong.giamGia,
                    MAKH = thongTinDatPhong.khachHang.Ma,
                    MANV = thongTinDatPhong.nhanVien.MaNV,
                    NGAYDAT = thongTinDatPhong.ngayDat,
                    NGAYNHAN = thongTinDatPhong.ngayNhan,
                    TIENCOC = thongTinDatPhong.tienCoc,
                }
            );

            //thêm chi tiết đặt phòng
            foreach (var phong in phongs)
            {
                karaokeDataContext.PHONGs.Where(p => p.MAPHONG == phong.Ten).First().TINHTRANG = "1";
                karaokeDataContext.CHITIETDATPHONGs.InsertOnSubmit(new CHITIETDATPHONG()
                {
                    MADATPHONG = maDatPhong,
                    GIOVAO = DateTime.Now,
                    MAPHONG = phong.Ten,
                });
            }


            return true;
        }
        public static string GhiNhanDatPhong(List<Phong> phongs, ThongTinDatPhong thongTinDatPhong) {


            KaraokeDataContext karaokeDataContext = new KaraokeDataContext();
            DateTime now = DateTime.Now;
            string maDatPhong = TaoMa.TaoMaDatPhong();
            karaokeDataContext.TAOMAs.Where(taoMa => taoMa.ID == 16).First().MACUOI += 1;
            karaokeDataContext.THONGTINDATPHONGs.InsertOnSubmit(new THONGTINDATPHONG() {
                MADATPHONG = maDatPhong,
                GIAMGIA = thongTinDatPhong.giamGia,
                MAKH = thongTinDatPhong.khachHang.Ma,
                MANV = thongTinDatPhong.nhanVien.MaNV,
                NGAYDAT = now,
                NGAYNHAN = now,
                TIENCOC = thongTinDatPhong.tienCoc,
                DATHANHTOAN  = 0
            });

            //Thêm chi tiết đặt phòng
            foreach (var phong in phongs)
            {
                karaokeDataContext.PHONGs.Where(p => p.MAPHONG == phong.Ten).First().TINHTRANG = "1";
                karaokeDataContext.CHITIETDATPHONGs.InsertOnSubmit(new CHITIETDATPHONG() {
                    MADATPHONG = maDatPhong,
                    GIOVAO = now,
                    MAPHONG = phong.Ten,
                });
            }
           
            karaokeDataContext.SubmitChanges();

            return maDatPhong;
        }
        public static List<Phong> XemPhong(int trangThai, int pageSize, int pageNumber)
        {
            KaraokeDataContext karaokeDataContext = new KaraokeDataContext();
            if(trangThai == -1)
            {
                var phongDaDat = (from ctdp in karaokeDataContext.CHITIETDATPHONGs
                                  join ttdp in karaokeDataContext.THONGTINDATPHONGs
                                  on ctdp.MADATPHONG equals ttdp.MADATPHONG
                                  where ttdp.DATHANHTOAN == 0
                                  select new Phong()
                                  {
                                      Ten = ctdp.PHONG.MAPHONG,
                                      Gia = (uint)ctdp.PHONG.LOAIPHONG.GIA,
                                      TenLoai = ctdp.PHONG.LOAIPHONG.TENLOAIPHONG,
                                      TinhTrang = int.Parse(ctdp.PHONG.TINHTRANG),
                                      GetKhachHang = new KhachHang()
                                      {
                                          Ma = ttdp.KHACHHANG.MAKH,
                                          Ten = ttdp.KHACHHANG.TENKH == "" ? "Vãn lai": ttdp.KHACHHANG.TENKH,
                                          SoDT = ttdp.KHACHHANG.SDT,
                                          LoaiKH = ttdp.KHACHHANG.LOAIKHACHHANG.MALOAIKH,

                                      }
                                  }).ToList();
                phongDaDat.AddRange((
                    from phong in karaokeDataContext.PHONGs
                    where phong.TINHTRANG == "0"
                    select new Phong()
                    {
                        Gia = (uint)phong.LOAIPHONG.GIA,
                        Ten = phong.MAPHONG,
                        TenLoai = phong.LOAIPHONG.TENLOAIPHONG,
                        TinhTrang = int.Parse(phong.TINHTRANG),
                        GetKhachHang = new KhachHang()
                        {
                            Ma = "",
                            Ten = "",
                            SoDT = "",
                            LoaiKH = 1,

                        }
                    })
                    );
                return phongDaDat.OrderBy(p=> p.Ten).Skip((pageNumber - 1)* pageSize).Take(pageSize).ToList();
            }
            else if(trangThai == 1)
            {
                return (from ctdp in karaokeDataContext.CHITIETDATPHONGs
                         join ttdp in karaokeDataContext.THONGTINDATPHONGs
                         on ctdp.MADATPHONG equals ttdp.MADATPHONG
                         where ttdp.DATHANHTOAN == 0
                         select new Phong()
                         {
                             Ten = ctdp.PHONG.MAPHONG,
                             Gia = (uint)ctdp.PHONG.LOAIPHONG.GIA,
                             TenLoai = ctdp.PHONG.LOAIPHONG.TENLOAIPHONG,
                             TinhTrang = int.Parse(ctdp.PHONG.TINHTRANG),
                             GetKhachHang = new KhachHang()
                             {
                                 Ma = ttdp.KHACHHANG.MAKH,
                                 Ten = ttdp.KHACHHANG.TENKH == "" ? "Vãn lai" : ttdp.KHACHHANG.TENKH,
                                 SoDT = ttdp.KHACHHANG.SDT,
                                 LoaiKH = ttdp.KHACHHANG.LOAIKHACHHANG.MALOAIKH,

                             }
                         }).OrderBy(p => p.Ten).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            }
            else
            {
                return (from phong in karaokeDataContext.PHONGs
                        where phong.TINHTRANG == "0"
                        select new Phong()
                        {
                            Gia = (uint)phong.LOAIPHONG.GIA,
                            Ten = phong.MAPHONG,
                            TenLoai = phong.LOAIPHONG.TENLOAIPHONG,
                            TinhTrang = int.Parse(phong.TINHTRANG)
                        }).OrderBy(p => p.Ten).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            }

        }

        public static int DemPhong(int trangThai)
        {
            string query = "EXEC uspDemPhong @trangThai";

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@trangThai",SqlDbType.Int){IsNullable=false,Value=trangThai }

            };
            int count = 0;
            try
            {
                count = int.Parse(Dataprovider.ExcuteScalar(query, parameters.ToArray()).ToString());
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            return count;
        }

        public static bool ChuyenPhong(string phongHienTai, string phongChuyen)
        {
            string query = "EXEC uspChuyenPhong @maPhongHienTai,@maPhongChuyen ";


            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                  new SqlParameter("@maPhongHienTai",SqlDbType.VarChar){ Value=phongHienTai  },
                  new SqlParameter("@maPhongChuyen",SqlDbType.VarChar){ Value=phongChuyen },


            };
            try
            {
                Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
                return false;
            }
            return true;
        }

        public static DataTable XemLichSuPhong(int pageNumber, int pageSize)
        {
            string query = "EXEC uspXemLichSuDatPhong @pageNumber,@pageSize";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@pageNumber",SqlDbType.Int){ Value=pageNumber  },
                new SqlParameter("@pageSize",SqlDbType.Int){ Value=pageSize  },

            };
            DataTable table = null;
            try
            {
                table = Dataprovider.ExcuteQuery(query, parameters.ToArray());

            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }

            return table;
        }
        public static int DemLichSuPhong()
        {
            string query = "EXEC uspDemLichSuDatPhong ";
            int count = 0;
            try
            {
                count = int.Parse(Dataprovider.ExcuteScalar(query).ToString());
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            return count;
        }
        public static DataTable XemLoaiPhong()
        {
            using (KaraokeDataContext karaokeDataContext = new KaraokeDataContext())
            {
                DataTable dtXemLoaiPhong = null;
                var select = from loaiPhong in karaokeDataContext.LOAIPHONGs
                             select loaiPhong;
                dtXemLoaiPhong = Utility.ConvertToDataTable(select.ToList());
                return dtXemLoaiPhong;
            }
        }
        public static DataTable XemPhongQuanLy(string maPhong, int loaiPhong, int pageNumber, int pageSize)
        {
            DataTable tbPhong = new DataTable();
            using (KaraokeDataContext karaokeDataContext = new KaraokeDataContext())
            {
                try
                {
                    var xemPhongQuanLyQuery = (from phong in karaokeDataContext.PHONGs
                                               join loaiPhongTable in karaokeDataContext.LOAIPHONGs
                                               on phong.MALOAIPHONG equals loaiPhongTable.MALOAIPHONG
                                               where (phong.MAPHONG.ToString().ToLower().Contains(maPhong.ToString().ToLower()) ||
                                                     loaiPhongTable.MALOAIPHONG.ToString().ToLower().Contains(loaiPhong.ToString().ToLower())
                                               )
                                               select new
                                               {
                                                   phong.MAPHONG,
                                                   loaiPhongTable.MALOAIPHONG,
                                                   loaiPhongTable.TENLOAIPHONG,
                                                   loaiPhongTable.GIA
                                               }).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                    tbPhong = Utility.ConvertToDataTable(xemPhongQuanLyQuery.ToList());
                }
                catch (Exception ex)
                {
                    Utility.Log(ex);
                }
            }
            return tbPhong;
        }
        public static int DemPhongQuanLy(string maPhong, int loaiPhong)
        {
            string query = "EXEC uspDemPhongQuanLy @maPhong,@loaiPhong";

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maPhong",SqlDbType.VarChar){ Value=maPhong  },
                new SqlParameter("@loaiPhong",SqlDbType.Int){ Value=loaiPhong  },
            };
            int count = 0;
            try
            {
                count = int.Parse(Dataprovider.ExcuteScalar(query, parameters.ToArray()).ToString());
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            return count;
        }
    }
}