﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public static class HoaDonDAO
    {

        public static bool ThemChiTietHoaDon(string mahd, List<ChiTietHoaDon> chiTietHoaDons)
        {
            KaraokeDataContext karaokeDataContext = new KaraokeDataContext();


            //xóa dữ liệu cũ trong bảng hóa đơn cập nhật dữ liệu mới
            var deleteMonAn = from cthdma in karaokeDataContext.CTHDMAs
                              where cthdma.SOHD == mahd
                              select cthdma;

            if (deleteMonAn.Count() != 0)
            {
                karaokeDataContext.CTHDMAs.DeleteAllOnSubmit(deleteMonAn);
            }

            chiTietHoaDons.ForEach(
                chiTietHoaDon =>
                {

                }
            );
            var deleteSanPhams = from cthdsp in karaokeDataContext.CTHDSPs
                                 where cthdsp.SOHD == mahd
                                 select cthdsp;



            var updateSanPhams = (from cthdsp in karaokeDataContext.CTHDSPs
                                  join chiTietHoaDon in chiTietHoaDons
                                  on cthdsp.SANPHAM.MASP equals chiTietHoaDon.Ma

                                  where chiTietHoaDon.LoaiHangHoa == ChiTietHoaDon.Loai.Sanpham
                                  && cthdsp.SOHD == mahd
                                  select new
                                  {
                                      SoLuong = cthdsp.SOLUONG - chiTietHoaDon.Soluong
                                  });

            updateSanPhams.ToList().ForEach(s => /*s.sanPham.SLTON +=*/  { });


            //cập nhật lại số lượng tồn của 
            List<CTHDSP> cTHDSPs = new List<CTHDSP>();
            List<CTHDMA> cTHDMAs = new List<CTHDMA>();

            karaokeDataContext.CTHDSPs.DeleteAllOnSubmit(deleteSanPhams);

            //thêm dữ liệu mới
            chiTietHoaDons.ForEach(chiTietHoaDon =>
            {

                //nếu là món ăn thì thêm vào bảng CTHDMA
                if (chiTietHoaDon.LoaiHangHoa == ChiTietHoaDon.Loai.MonAn)
                {
                    karaokeDataContext.CTHDMAs.Where(s => s.MAMON == chiTietHoaDon.Ma).
                    First().MONAN.TPMONANs.ToList().ForEach(t => t.NGUYENLIEU.SLTON -=
                    chiTietHoaDon.Soluong * t.SOLUONG
                    );



                    karaokeDataContext.CTHDMAs.InsertOnSubmit(new CTHDMA()
                    {
                        //HOADON = (from hoaDon in karaokeDataContext.HOADONs
                        //         where hoaDon.SOHD == mahd
                        //         select hoaDon).First(),
                        SOHD = mahd,
                        MAMON = chiTietHoaDon.Ma,
                        SOLUONG = chiTietHoaDon.Soluong,
                        //MONAN = (from monAn in karaokeDataContext.MONANs
                        //         where monAn.MAMON == chiTietHoaDon.Ma
                        //         select monAn).First(),


                    });
                }
                else
                {
                    karaokeDataContext.CTHDSPs.Where(s => s.MASP == chiTietHoaDon.Ma).
                    First().SANPHAM.SLTON -= chiTietHoaDon.Soluong;
                    //nếu là sản phẩm thì thêm vào bảng CTHDMA
                    karaokeDataContext.CTHDSPs.InsertOnSubmit(new CTHDSP()
                    {
                        //HOADON = (from hoaDon in karaokeDataContext.HOADONs
                        //          where hoaDon.SOHD == mahd
                        //          select hoaDon).First(),
                        SOHD = mahd,
                        MASP = chiTietHoaDon.Ma,
                        SOLUONG = chiTietHoaDon.Soluong,
                        //SANPHAM = (from sanPham in karaokeDataContext.SANPHAMs
                        //         where sanPham.MASP == chiTietHoaDon.Ma
                        //         select sanPham).First(),
                    });
                }

            });

            // kiểm tra dữ liệu có xóa hết không
            ChangeSet cs = karaokeDataContext.GetChangeSet();
            if (cs.Deletes.Count == (deleteMonAn.Count() + deleteSanPhams.Count())
               && cs.Inserts.Count == chiTietHoaDons.Count
                )
            {
                karaokeDataContext.SubmitChanges();
                return true;
            }
            //karaokeDataContext.




            return false;
        }
        public static string LayMaHoaDon(string maPhong)
        {
            string query = "EXEC uspLayHoaDon @maPhong";

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maPhong",SqlDbType.VarChar){IsNullable=false,Value=maPhong }

            };
            string result = "";
            try
            {
                result = Dataprovider.ExcuteScalar(query, parameters.ToArray()).ToString();
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            return result;
        }

        public static List<GoiMonDataSource> XemChiTietHoaDon(string soHoaDon)
        {
            string query = "EXEC uspXemChiTietHoaDon @soHoaDon";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@soHoaDon",SqlDbType.VarChar){ Value=soHoaDon  }

            };
            List<GoiMonDataSource> list = null;
            try
            {
                DataTable table = Dataprovider.ExcuteQuery(query, parameters.ToArray());
                list = table.AsEnumerable().ToList().ConvertAll(x =>
                        new GoiMonDataSource()
                        {
                            Ma = x[0].ToString(),
                            Ten = x[1].ToString(),
                            Soluong = x[2].ToString(),
                            Loai = x[3].ToString(),
                            Gia = x[4].ToString(),
                            Thanhtien = (int.Parse(x[2].ToString()) * int.Parse(x[4].ToString())).ToString()
                        }
                        );
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }

            return list;
        }

        public static DataTable XemHoaDonBaoCao(string soHoaDon)
        {
            string query = "EXEC uspXemHoaDonBaoCao @soHoaDon";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@soHoaDon",SqlDbType.VarChar){ Value=soHoaDon  }

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
        /// <summary>
        /// Khác với chi tiết hóa đơn bình thường, có phân chia loại khai vị,món chính,món la séc
        /// </summary>
        /// <param name="soHoaDon">số hóa đơn</param>
        /// <returns></returns>
        public static List<GoiMonDataSource> XemChiTietHoaDonDatTiec(string soHoaDon)
        {
            string query = "EXEC uspXemChiTietHoaDonDatTiec @soHoaDon";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@soHoaDon",SqlDbType.VarChar){ Value=soHoaDon  }

            };
            List<GoiMonDataSource> list = null;
            try
            {
                DataTable table = Dataprovider.ExcuteQuery(query, parameters.ToArray());
                list = table.AsEnumerable().ToList().ConvertAll(x =>
                        new GoiMonDataSource()
                        {
                            Ma = x[0].ToString(),
                            Ten = x[1].ToString(),
                            Soluong = x[2].ToString(),
                            Loai = x[5].ToString(),
                            Gia = x[4].ToString(),
                            Thanhtien = (int.Parse(x[2].ToString()) * int.Parse(x[4].ToString())).ToString(),
                            MaLoaiHangHoa = x[3].ToString(),
                            TenLoaiHangHoa = x[6].ToString()

                        }
                        );
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }

            return list;
        }
        public static List<GoiMonDataSource> XemChiTietHoaDonGoiMon(string soHoaDon)
        {
            string query = "EXEC uspXemChiTietHoaDonDatTiec @soHoaDon";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@soHoaDon",SqlDbType.VarChar){ Value=soHoaDon  }

            };
            List<GoiMonDataSource> list = null;
            try
            {
                DataTable table = Dataprovider.ExcuteQuery(query, parameters.ToArray());
                list = table.AsEnumerable().ToList().ConvertAll(x =>
                        new GoiMonDataSource()
                        {
                            Ma = x[0].ToString(),
                            Ten = x[1].ToString(),
                            Soluong = x[2].ToString(),
                            Loai = x[5].ToString(),
                            Gia = x[4].ToString(),
                            Thanhtien = (int.Parse(x[2].ToString()) * int.Parse(x[4].ToString())).ToString(),
                            MaLoaiHangHoa = x[5].ToString() == "0" ? "1" : x[3].ToString(),
                            TenLoaiHangHoa = x[5].ToString() == "0" ? "Thức ăn" : x[6].ToString()

                        }
                        );
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }

            return list;
        }
        public static bool DatCocTien(uint tienDatCoc, string soHD)
        {
            string query = "UPDATE HOADON SET tienDatCoc=@tienDatCoc WHERE SOHD=@soHD";
            int num = 0;
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tienDatCoc",SqlDbType.Int){IsNullable=false,Value=tienDatCoc },
                new SqlParameter("@soHD",SqlDbType.VarChar){IsNullable=false,Value=soHD },


            };
            try
            {
                num = Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
                return false;
            }
            return num == 1 ? true : false;
        }

        public static string LayMaHoaDonDatTiec(string maPhong, string tenKhachHang, string soDienThoai, DateTime ngayNhanPhong)
        {
            string query = "EXEC uspLayHoaDonDatTiec @maPhong,@tenKhachHang,@soDienThoai,@ngayNhanPhong";

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maPhong",SqlDbType.VarChar){IsNullable=false,Value=maPhong },
                new SqlParameter("@tenKhachHang",SqlDbType.NVarChar){IsNullable=false,Value=tenKhachHang },
                new SqlParameter("@soDienThoai",SqlDbType.VarChar){IsNullable=false,Value=soDienThoai },
                new SqlParameter("@ngayNhanPhong",SqlDbType.DateTime){IsNullable=false,Value=ngayNhanPhong }

            };
            string result = "";
            try
            {
                result = Dataprovider.ExcuteScalar(query, parameters.ToArray()).ToString();
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            return result;
        }
        //public static int TinhTienGio(string soHoaDon, DateTime, gioRa)
        //{
        //    string query = "EXEC uspThanhToanPhong @soHoaDon";

        //    List<SqlParameter> parameters = new List<SqlParameter>()
        //    {
        //        new SqlParameter("@soHoaDon",SqlDbType.VarChar){IsNullable=false,Value=soHoaDon }


        //    };
        //    int result = 0;
        //    try
        //    {
        //        result = (int)Dataprovider.ExcuteScalar(query, parameters.ToArray());
        //    }
        //    catch (Exception ex)
        //    {
        //        Utility.Log(ex);
        //    }
        //    return result == 0 ? false : true;
        //}
        public static bool ThanhToan(string soHoaDon, DateTime gioRa, int thanhTien, int giamGia)
        {

            string query = "EXEC uspThanhToanPhong @soHoaDon,@gioRa,@thanhTien,@giamGia";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@soHoaDon",SqlDbType.VarChar){IsNullable=false,Value=soHoaDon },
                new SqlParameter("@gioRa",SqlDbType.DateTime){IsNullable=false,Value=gioRa },
                new SqlParameter("@thanhTien",SqlDbType.Int){IsNullable=false,Value=thanhTien },
                new SqlParameter("@giamGia",SqlDbType.Int){IsNullable=false,Value=giamGia },
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
        public static bool HoaDonDatTiec(string soHoaDon)
        {
            string query = "SELECT COUNT(*) FROM HOADON A INNER JOIN PHIEUDATPHONG B ON A.SOHD=B.SOHD WHERE A.SOHD = @soHoaDon";

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@soHoaDon",SqlDbType.VarChar){IsNullable=false,Value=soHoaDon }

            };
            int result = 0;
            try
            {
                result = (int)Dataprovider.ExcuteScalar(query, parameters.ToArray());
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            return result == 0 ? false : true;
        }

        public static bool ThemHoaDonMonAn(string soHoaDon, string ma, int soLuong)
        {
            string query = "EXEC uspThemHangHoaDon @soHoaDon,@ma,@soLuong";

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@soHoaDon",SqlDbType.VarChar){IsNullable=false,Value=soHoaDon },
                new SqlParameter("@ma",SqlDbType.VarChar){IsNullable=false,Value=ma },
                new SqlParameter("@soLuong",SqlDbType.Int){IsNullable=false,Value=soLuong },

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
        public static bool CapNhatTon(string soHoaDon, string ma, int soLuongCu, int soLuongMoi)
        {
            string query = "EXEC uspCapNhatTon @soHoaDon,@ma,@soLuongCu,@soLuongMoi";

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@soHoaDon",SqlDbType.VarChar){IsNullable=false,Value=soHoaDon },
                new SqlParameter("@ma",SqlDbType.VarChar){IsNullable=false,Value=ma },
                new SqlParameter("@soLuongCu",SqlDbType.Int){IsNullable=false,Value=soLuongCu },
                new SqlParameter("@soLuongMoi",SqlDbType.Int){IsNullable=false,Value=soLuongMoi }

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
        public static bool KiemTraMonAn(string ma, int soLuong, int soLuongCu)
        {
            string query = "EXEC uspKiemTraGoiMon @ma,@soLuong,@soLuongCu";

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@ma",SqlDbType.VarChar){IsNullable=false,Value=ma },
                new SqlParameter("@soLuong",SqlDbType.Int){IsNullable=false,Value=soLuong },
                 new SqlParameter("@soLuongCu",SqlDbType.Int){IsNullable=false,Value=soLuongCu },
            };
            int result = 0;
            try
            {
                result = (int)Dataprovider.ExcuteScalar(query, parameters.ToArray());
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            return result == 0 ? false : true;
        }
        public static bool KiemTraSanPham(string ma, int soLuong, int soLuongCu)
        {
            string query = "EXEC uspKiemTraSanPham @ma,@soLuong,@soLuongCu";

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@ma",SqlDbType.VarChar){IsNullable=false,Value=ma },
                new SqlParameter("@soLuong",SqlDbType.Int){IsNullable=false,Value=soLuong },
                 new SqlParameter("@soLuongCu",SqlDbType.Int){IsNullable=false,Value=soLuongCu },
            };
            int result = 0;
            try
            {
                result = (int)Dataprovider.ExcuteScalar(query, parameters.ToArray());
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            return result == 0 ? false : true;
        }
        public static HoaDon LayThongTinHoaDon(string soHoaDon)
        {
            string query = "EXEC uspXemThongTinHoaDon @soHoaDon";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@soHoaDon",SqlDbType.VarChar){ Value=soHoaDon  }

            };
            HoaDon hoaDon = null;
            try
            {
                DataRow row = Dataprovider.ExcuteQuery(query, parameters.ToArray()).Select()[0];
                hoaDon = new HoaDon()
                {
                    SoHoaDon = row.ItemArray[4].ToString(),
                    GioVao = row.ItemArray[0].ToString(),
                    GioRa = row.ItemArray[1].ToString(),
                    GiamGia = row.ItemArray[2].ToString(),
                    MaPhong = row.ItemArray[3].ToString(),
                    TienGio = row.ItemArray[5].ToString(),
                    TenKhachHang = row.ItemArray[6].ToString(),
                    SoDienThoai = row.ItemArray[7].ToString(),
                    TienDatCoc = row.ItemArray[8].ToString(),
                    TinhTrang = row.ItemArray[9].ToString(),
                };
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }

            return hoaDon;
        }
    }
}
