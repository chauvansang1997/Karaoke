using System;
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
        /// <summary>
        /// Thêm chi tiết hóa đơn:
        /// B1: Xóa dữ liệu cũ trong chi tiết hóa đơn,
        /// B2: Cập nhật số lượng tồn khi xóa dữ liệu cũ
        /// B3: Thêm dữ liệu mới vào chi tiết hóa đơn, đồng thời
        ///         cập nhật dữ liệu tồn khi thêm dữ liệu mới
        /// </summary>
        /// <param name="maDatPhong"></param>
        /// <param name="chiTietHoaDons"></param>
        /// <returns></returns>
        public static bool ThemChiTietHoaDon(string maDatPhong, string maPhong, List<ChiTietHoaDon> chiTietHoaDons)
        {
            KaraokeDataContext karaokeDataContext = new KaraokeDataContext();

            #region B1: xóa dữ liệu cũ trong chi tiết hóa đơn
            //xóa dữ liệu món ăn cũ trong bảng hóa đơn cập nhật dữ liệu mới
            var deleteSanPhams = from cthdma in karaokeDataContext.CHITIETGOIMONs
                                 where cthdma.MADATPHONG == maDatPhong && cthdma.MAPHONG == maPhong
                                 select cthdma;

            if (deleteSanPhams.Count() != 0)
            {
                karaokeDataContext.CHITIETGOIMONs.DeleteAllOnSubmit(deleteSanPhams);
            }

            #endregion

            #region B2: cập nhật số lượng tồn khi xóa dữ liệu cũ
            //cập nhật lại số lượng tồn của sản phẩm
            deleteSanPhams.ToList().ForEach(s => s.SANPHAM.SLTON += s.SOLUONG);
            #endregion

            #region B3: Thêm dữ liệu mới vào chi tiết hóa đơn, đồng thời cập nhật dữ liệu tồn khi thêm dữ liệu mới

            //thêm dữ liệu mới
            chiTietHoaDons.ForEach(chiTietHoaDon =>
            {

                //cập nhật số lượng tồn sản phẩm
                karaokeDataContext.SANPHAMs.Where(s => s.MASP == chiTietHoaDon.Ma).First().SLTON -= chiTietHoaDon.Soluong;
                //nếu là sản phẩm thì thêm vào bảng CTHDMA
                karaokeDataContext.CHITIETGOIMONs.InsertOnSubmit(new CHITIETGOIMON()
                {

                    MADATPHONG = maDatPhong,
                    MASP = chiTietHoaDon.Ma,
                    SOLUONG = chiTietHoaDon.Soluong,
                    MAPHONG = maPhong,

                });

            });
            #endregion

            // kiểm tra dữ liệu có xóa hết không
            ChangeSet cs = karaokeDataContext.GetChangeSet();
            if (cs.Deletes.Count == (deleteSanPhams.Count())
               && cs.Inserts.Count == chiTietHoaDons.Count)
            {
                karaokeDataContext.SubmitChanges();
                return true;
            }
            return false;
        }

        public static DataTable HoaDonDataSet(ThongTinDatPhong thongTinDatPhong)
        {



            KaraokeDataContext karaokeDataContext = new KaraokeDataContext();

           var list = from ttdp in karaokeDataContext.THONGTINDATPHONGs
            join ctdp in karaokeDataContext.CHITIETDATPHONGs
            on ttdp.MADATPHONG equals ctdp.MADATPHONG
                   join hoaDon in karaokeDataContext.HOADONs
                   on ttdp.MADATPHONG equals hoaDon.MADATPHONG


                   join ctgm in karaokeDataContext.CHITIETGOIMONs 
                   on new { ctdp.MADATPHONG, ctdp.MAPHONG }  equals
                    new  {  ctgm.MADATPHONG,ctgm.MAPHONG } into ps 
                    from p in ps.DefaultIfEmpty()
                      where ttdp.MADATPHONG == thongTinDatPhong.maDatPhong 
      
            select new
            {
                MAHOADON =  hoaDon.MAHD,
                MADATPHONG = thongTinDatPhong.maDatPhong,
                hoaDon.NGAYGIOLAP,
                ttdp.KHACHHANG.MAKH,
                ttdp.NGAYDAT,
                ttdp.NGAYNHAN,
                ttdp.NHANVIEN.MANV,
                GIAMGIA = 0,
                ctdp.MAPHONG,
                ctdp.GIOVAO,
                ctdp.GIORA,
                p.MASP,
                p.SOLUONG,
                GIA = p == null ? 0 : (int)(p.GIA),
                p.SANPHAM.TENSP,
                p.SANPHAM.DVT,
                ctdp.PHONG.MALOAIPHONG,
                ctdp.PHONG.LOAIPHONG.TENLOAIPHONG,
                GIAPHONG = (int)ctdp.PHONG.LOAIPHONG.GIA,
                ttdp.KHACHHANG.TENKH,
                ttdp.KHACHHANG.SDT,
                p.SANPHAM.DONVI.TENDV,
                GIO = (ctdp.GIORA.Value - ctdp.GIOVAO.Value).TotalHours



            };


            return Utility.ConvertToDataTable(list.ToList());
        }
        public static string LayMaHoaDon(string maPhong)
        {

            //string query = "EXEC uspLayHoaDon @maPhong";

            //truyền tham số vào câu truy vấn
            //List<SqlParameter> parameters = new List<SqlParameter>()
            //{
            //    new SqlParameter("@maPhong",SqlDbType.VarChar){IsNullable=false,Value=maPhong }

            //};
            string result = "";
            //try
            //{
            //    //result = Dataprovider.ExcuteScalar(query, parameters.ToArray()).ToString();
            //    using (KaraokeDataContext karaokeDataContext = new KaraokeDataContext())
            //    {
            //        result = (from hoaDon in karaokeDataContext.HOADONs
            //                  where hoaDon.MAPHONG == maPhong &&
            //                  hoaDon.PHONG.TINHTRANG == "1"

            //                  select hoaDon.SOHD).First();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Utility.Log(ex);
            //}



            return result;
        }

        public static List<GoiMonDataSource> XemChiTietHoaDon(string maDatPhong, string maPhong)
        {
            //string query = "EXEC uspXemChiTietHoaDon @soHoaDon";

            //List<SqlParameter> parameters = new List<SqlParameter>()
            //{
            //    new SqlParameter("@soHoaDon",SqlDbType.VarChar){ Value=soHoaDon  }

            //};
            List<GoiMonDataSource> list = null;
            try
            {

                //DataTable table = Dataprovider.ExcuteQuery(query, parameters.ToArray());
                //list = table.AsEnumerable().ToList().ConvertAll(x =>
                //        new GoiMonDataSource()
                //        {
                //            Ma = x[0].ToString(),
                //            Ten = x[1].ToString(),
                //            Soluong = int.Parse(x[2].ToString()),
                //            Loai = x[3].ToString(),
                //            Gia = int.Parse(x[4].ToString()),
                //            Thanhtien = (int.Parse(x[2].ToString()) *
                //            int.Parse(x[4].ToString())).ToString()
                //        }
                //        );

                using (KaraokeDataContext karaokeDataContext = new KaraokeDataContext())
                {


                    list = (from cthdsp in karaokeDataContext.CHITIETGOIMONs
                            join sanPham in karaokeDataContext.SANPHAMs
                            on cthdsp.MASP equals sanPham.MASP
                            join loai in karaokeDataContext.LOAISANPHAMs
                            on sanPham.LOAISP equals loai.MA
                            where cthdsp.MADATPHONG == maDatPhong && cthdsp.MAPHONG == maPhong

                            select new GoiMonDataSource
                            {
                                Ma = cthdsp.MASP,
                                Ten = sanPham.TENSP,
                                Soluong = cthdsp.SOLUONG.HasValue ? cthdsp.SOLUONG.Value.ToString()
                                  : "0",
                                Loai = sanPham.LOAISP.ToString(),
                                Gia = sanPham.DONGIA.HasValue ? sanPham.DONGIA.Value.ToString()
                                : "0",
                                Thanhtien = (cthdsp.SOLUONG.Value * sanPham.DONGIA.Value).ToString(),
                                MaLoaiHangHoa = loai.MA.ToString(),
                                TenLoaiHangHoa = loai.TENLOAI

                            }).ToList();
                }
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
                            MaLoaiHangHoa = x[5].ToString(),
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
        public static bool ThanhToan(string maDatPhong, DateTime gioRa, int thanhTien, int giamGia)
        {

            KaraokeDataContext karaokeDataContext = new KaraokeDataContext();
            string maHoaDon = TaoMa.TaoHoaDon();
            //tạo hóa đơn
            karaokeDataContext.HOADONs.InsertOnSubmit(new HOADON()
            {
                MADATPHONG = maDatPhong,
                MAHD = maHoaDon,
                NGAYGIOLAP = DateTime.Now,
                THANHTIEN = thanhTien,

            });

            karaokeDataContext.TAOMAs.Where(taoMa => taoMa.ID == 3).First().MACUOI += 1;

            //Cập nhật trạng thái hiện tại của phòng
            karaokeDataContext.CHITIETDATPHONGs.Where(ctdp => ctdp.MADATPHONG == maDatPhong).ToList().ForEach(
                    ctdp =>
                    {
                        karaokeDataContext.PHONGs.Where(phong => phong.MAPHONG == ctdp.MAPHONG).First().TINHTRANG = "0";
                    }
                );
            //cập nhật trạng thái thông tin đặt phòng
            karaokeDataContext.THONGTINDATPHONGs.Where(ttdp => ttdp.MADATPHONG == maDatPhong).First().DATHANHTOAN = 1;


            //string query = "EXEC uspThanhToanPhong @soHoaDon,@gioRa,@thanhTien,@giamGia";

            //List<SqlParameter> parameters = new List<SqlParameter>()
            //{
            //    new SqlParameter("@soHoaDon",SqlDbType.VarChar){IsNullable=false,Value=maDatPhong },
            //    new SqlParameter("@gioRa",SqlDbType.DateTime){IsNullable=false,Value=gioRa },
            //    new SqlParameter("@thanhTien",SqlDbType.Int){IsNullable=false,Value=thanhTien },
            //    new SqlParameter("@giamGia",SqlDbType.Int){IsNullable=false,Value=giamGia },
            //};
            //try
            //{
            //    Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
            //}
            //catch (Exception ex)
            //{
            //    Utility.Log(ex);
            //    return false;
            //}
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
        public static bool KiemTraSoLuongHangHoa(string ma, int soLuong, int soLuongCu)
        {
            //string query = "EXEC uspKiemTraGoiMon @ma,@soLuong,@soLuongCu";

            ////truyền tham số vào câu truy vấn
            //List<SqlParameter> parameters = new List<SqlParameter>()
            //{
            //    new SqlParameter("@ma",SqlDbType.VarChar){IsNullable=false,Value=ma },
            //    new SqlParameter("@soLuong",SqlDbType.Int){IsNullable=false,Value=soLuong },
            //     new SqlParameter("@soLuongCu",SqlDbType.Int){IsNullable=false,Value=soLuongCu },
            //};
            int result = 0;
            try
            {
                //result = (int)Dataprovider.ExcuteScalar(query, parameters.ToArray());
                using (KaraokeDataContext karaokeDataContext = new KaraokeDataContext())
                {
                    int checkMonAn = karaokeDataContext.MONANs.Where(s => s.MAMON == ma).Count();

                    result =
                        checkMonAn == 0 ?
                        //nếu mã là sản phẩm
                        karaokeDataContext.SANPHAMs.Where(s => s.MASP == ma &&
                         s.SLTON >= soLuong).Count()
                         :
                        //nếu là mã là món ăn

                        //chọn ra món cần tìm bằng mã
                        karaokeDataContext.TPMONANs.Where(s => s.MAMON == ma).
                        // kết nguyên liệu và thành phần món ăn
                        Join(karaokeDataContext.NGUYENLIEUs, tpMonAn => tpMonAn.MANL, nguyenLieu => nguyenLieu.MANL,
                        (tpMonan, nguyenLieu) => new { tpMonan, nguyenLieu }).
                        //kiểm tra có còn đủ số lượng
                        Where(
                            s => (s.nguyenLieu.SLTON >= soLuong * s.tpMonan.SOLUONG)
                        ).Count();
                }
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
