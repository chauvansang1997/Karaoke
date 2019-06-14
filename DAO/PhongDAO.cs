using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhongDAO
    {
        public static bool ThemPhong(Phong phong)
        {
            string query = "EXEC uspTaoPhong @maloaiphong";

            string ma = TaoMa.TaoMaPhong();

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maloaiphong",SqlDbType.NVarChar){Value=phong.TenLoai }

            };

            return Dataprovider.ExcuteNonQuery(query, parameters.ToArray()) > 0;
        }
        public static bool CapNhatPhong(Phong phong)
        {
            string query = "EXEC uspCapNhatPhong @maphong,@maloaiphong";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maphong",SqlDbType.NVarChar){ Value=phong.Ten  },
                new SqlParameter("@maloaiphong",SqlDbType.NVarChar){Value=phong.TenLoai }

            };

            return Dataprovider.ExcuteNonQuery(query, parameters.ToArray()) > 0;
        }
        public static bool GhiNhanDatPhong(KhachHang khachHang, string maPhong, string maNV)
        {
            try
            {
                using (KaraokeDataContext karaokeDataContext = new KaraokeDataContext())
                {
                    var thongTinKhachHang = (from kh in karaokeDataContext.KHACHHANGs
                                             where kh.TENKH == khachHang.Ten && kh.SDT == khachHang.SoDT
                                             select kh).First();
                    bool checkKhachHang = thongTinKhachHang != null;

                    string maHoaDon = TaoMa.TaoHoaDon();
                    var checkDangSuDung = karaokeDataContext.DANGSUDUNGs.Where(s => s.MAPHONG == maPhong).Count();
                    // .FirstOrDefault().SOHD = maHoaDon;
                    if (checkDangSuDung == 0)
                    {
                        karaokeDataContext.DANGSUDUNGs.InsertOnSubmit(new DANGSUDUNG()
                        {
                            MAPHONG = maPhong,
                            SOHD = maHoaDon
                        });
                    }

                    string maKhachHang = "";
                    karaokeDataContext.DANGSUDUNGs.Where(t => t.MAPHONG == maPhong).First().SOHD = maHoaDon;
                    karaokeDataContext.TAOMAs.Where(s => s.ID == 3).First().MACUOI += 1;
                    if (!checkKhachHang)
                    {
                        maKhachHang = TaoMa.TaoMaKhachHang();
                        karaokeDataContext.KHACHHANGs.InsertOnSubmit(new KHACHHANG()
                        {
                            MAKH = maKhachHang,
                            TENKH = khachHang.Ten,
                            MALOAIKH = 1,
                            SDT = khachHang.SoDT
                        });
                        karaokeDataContext.TAOMAs.Where(s => s.ID == 4).First().MACUOI += 1;
                    }
                    else
                    {
                        maKhachHang = thongTinKhachHang.MAKH;
                    }

                    bool checkKhuyenMai = (from kh in karaokeDataContext.KHACHHANGs
                                           join loaiKh in karaokeDataContext.LOAIKHACHHANGs
                                           on kh.MALOAIKH equals loaiKh.MALOAIKH
                                           join km in karaokeDataContext.CHITIETKMs
                                           on loaiKh.MALOAIKH equals km.MALOAIKH
                                           select kh).Count() > 0;
                    double giamGia = 0;
                    if (checkKhuyenMai)
                    {
                        var thongTinKhuyenMain = from kh in karaokeDataContext.KHACHHANGs
                                                 join loaiKh in karaokeDataContext.LOAIKHACHHANGs
                                                  on kh.MALOAIKH equals loaiKh.MALOAIKH
                                                 join ctkm in karaokeDataContext.CHITIETKMs
                                                 on loaiKh.MALOAIKH equals ctkm.MALOAIKH
                                                 join km in karaokeDataContext.KHUYENMAIs
                                                 on ctkm.MAKM equals km.MAKM
                                                 where km.NGAYBD <= DateTime.Now && km.NGAYKT >= DateTime.Now
                                                 select ctkm.MUCKM;
                        if (thongTinKhuyenMain.Count() > 0)
                        {
                            var maxValue = thongTinKhuyenMain.Max(x => x.Value);
                            giamGia = thongTinKhuyenMain.First(x => x.Value == maxValue).Value;
                        }
                    }
                    karaokeDataContext.PHONGs.Where(s => s.MAPHONG == maPhong).FirstOrDefault().TINHTRANG = "1";
                    karaokeDataContext.HOADONs.InsertOnSubmit(new HOADON()
                    {
                        SOHD = maHoaDon,
                        MAKH = maKhachHang,
                        MANV = maNV,
                        MAPHONG = maPhong,
                        GIOVAO = DateTime.Now,
                        TRANGTHAI = 0,
                        GIAMGIA = (int)giamGia,
                        THANHTIEN = 0,
                        TIENGIO = 0,
                        TIENDATCOC = 0,
                        NGAYLAP = DateTime.Now
                    });

                    karaokeDataContext.SubmitChanges();

                }
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
        public static List<Phong> XemPhong(int trangThai, int pageSize, int pageNumber)
        {
            string query = "EXEC uspTraCuuPhong @trangThai,@pageSize,@pageNumber";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@trangThai",SqlDbType.Int){ Value=trangThai  },
                 new SqlParameter("@pageSize",SqlDbType.Int){ Value=pageSize  },
                  new SqlParameter("@pageNumber",SqlDbType.Int){ Value=pageNumber  }
            };
            List<Phong> list = new List<Phong>();
            try
            {
                DataTable table = Dataprovider.ExcuteQuery(query, parameters.ToArray());
                list = table.AsEnumerable().ToList().ConvertAll(x =>
                        new Phong()
                        {
                            Ten = x[0].ToString(),
                            TenLoai = x[1].ToString(),
                            Gia = uint.Parse(x[2].ToString()),
                            TinhTrang = int.Parse(x[3].ToString()),
                            GetKhachHang = new KhachHang() { Ma = x[4].ToString(), Ten = x[5].ToString(), SoDT = x[6].ToString() }
                        });
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }

            return list;
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

        public static bool ChuyenPhong(string phongHienTai,string phongChuyen)
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

        public static DataTable XemLichSuPhong(int pageNumber,int pageSize)
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
                table = Dataprovider.ExcuteQuery(query,parameters.ToArray());

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

            //truyền tham số vào câu truy vấn
            //List<SqlParameter> parameters = new List<SqlParameter>()
            //{
            //    new SqlParameter("@trangThai",SqlDbType.Int){IsNullable=false,Value=trangThai }

            //};
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
            string query = "SELECT * FROM LOAIPHONG";


            DataTable table = null;
            try
            {
                table = Dataprovider.ExcuteQuery(query);

            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }

            return table;
        }
        public static DataTable XemPhongQuanLy(string maPhong,int loaiPhong, int pageNumber,int pageSize)
        {
            string query = "EXEC uspXemPhong @maPhong,@loaiPhong,@pageNumber,@pageSize";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maPhong",SqlDbType.VarChar){ Value=maPhong  },
                new SqlParameter("@loaiPhong",SqlDbType.Int){ Value=loaiPhong  },
    
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
