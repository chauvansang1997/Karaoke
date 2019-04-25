using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAO
{
    public static class ThietBiDAO
    {
        public static bool ThemThietBi(ThietBi thietBi)
        {
            string query = "EXEC [usp_ThemThietBi] @tenTB,@maNCC,@dvt ,@donGia";
            string tenTB = thietBi.Ten;
            string maNCC = thietBi.MaNCC;
            string dvt = thietBi.DVT;
            string donGia = thietBi.DonGia;
            bool rs = false;
            // Truyền tham số
            List<SqlParameter> parameters = new List<SqlParameter>()
            {

                new SqlParameter("@tenTB", SqlDbType.NVarChar) {IsNullable = false, Value = tenTB},
                new SqlParameter("@maNCC", SqlDbType.NVarChar) {IsNullable = false, Value = maNCC},
                new SqlParameter("@dvt", SqlDbType.NVarChar) {IsNullable = false, Value = dvt},
                new SqlParameter("@donGia", SqlDbType.BigInt) {IsNullable = false, Value = donGia},
            };
            try
            {
                Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
                rs = true;
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
                rs = false;
            }

            return rs;
        }
        public static bool SuaThietBi(ThietBi thietBi)
        {
            string query = "EXEC [usp_SuaThietBi] @ma,@tenTB,@maNCC,@dvt ,@donGia";
            string tenTB = thietBi.Ten;
            string maNCC = thietBi.MaNCC;
            string dvt = thietBi.DVT;
            string donGia = thietBi.DonGia;
            bool rs = false;
            // Truyền tham số
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@ma", SqlDbType.NVarChar) {IsNullable = false, Value = thietBi.Ma},
                new SqlParameter("@tenTB", SqlDbType.NVarChar) {IsNullable = false, Value = tenTB},
                new SqlParameter("@maNCC", SqlDbType.NVarChar) {IsNullable = false, Value = maNCC},
                new SqlParameter("@dvt", SqlDbType.NVarChar) {IsNullable = false, Value = dvt},
                new SqlParameter("@donGia", SqlDbType.BigInt) {IsNullable = false, Value = donGia},
            };
            try
            {
                Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
                rs = true;
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
                rs = false;
            }

            return rs;
        }
        public static bool CapNhatThietBi(ThietBi thietBi)
        {
            string query = "EXCUTE usp_CapNhatThietBi @maTB,@tenTB,@maNCC,@dvt ,@donGia";
            string maTB = thietBi.Ma;
            string tenTB = thietBi.Ten;
            string maNCC = thietBi.MaNCC;
            string dvt = thietBi.DVT;
            string donGia = thietBi.DonGia;
            // Truyền tham số
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maTB", SqlDbType.Char) {IsNullable = false, Value = maTB},
                new SqlParameter("@tenTB", SqlDbType.Char) {IsNullable = false, Value = tenTB},
                new SqlParameter("@maNCC", SqlDbType.NVarChar) {IsNullable = false, Value = maNCC},
                new SqlParameter("@dvt", SqlDbType.NVarChar) {IsNullable = false, Value = dvt},
                new SqlParameter("@donGia", SqlDbType.BigInt) {IsNullable = false, Value = donGia},
            };
            try
            {
                Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
                return true;
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
                return false;
            }
        }
        public static PhieuNhapHang LapPhieuNhap(string nhaCungCap, string maNhanVien)
        {
            string query = "EXEC uspLapPhieuNhapThietBi @nhaCungCap,@maNhanVien";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@nhaCungCap",SqlDbType.VarChar){IsNullable=false,Value=nhaCungCap },
                new SqlParameter("@maNhanVien",SqlDbType.VarChar){IsNullable=false,Value=maNhanVien },

            };
            DataRow result = null;
            PhieuNhapHang phieuNhapHang = null;
            try
            {
                result = Dataprovider.ExcuteQuery(query, parameters.ToArray()).Rows[0];
                phieuNhapHang = new PhieuNhapHang()
                {
                    SoPhieu = result[0].ToString(),
                    MaNhanVien = result[1].ToString(),
                    TenNhanVien = result[2].ToString(),
                    SoDienThoai = result[3].ToString(),
                    NgayDat = result[4].ToString(),
                };
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            return phieuNhapHang;
        }

        public static bool NhapHang(string soPhieuNhap, List<string> listMa, List<string> listSoLuong, uint thanhTien)
        {
            string query = "EXEC uspNhapHangTietBi @soPhieuNhap,@danhSachMa,@danhSachSoLuong,@thanhTien";

            string danhSachMa = String.Join("|", listMa);
            string danhSachSoLuong = String.Join("|", listSoLuong);

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@soPhieuNhap",SqlDbType.NVarChar){IsNullable=false,Value=soPhieuNhap },
                new SqlParameter("@danhSachMa",SqlDbType.NVarChar){IsNullable=false,Value=danhSachMa },
                new SqlParameter("@danhSachSoLuong",SqlDbType.NVarChar){IsNullable=false,Value=danhSachSoLuong },
                new SqlParameter("@thanhTien",SqlDbType.Int){IsNullable=false,Value=thanhTien },

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
        public static bool GiaoHang(string soPhieuNhap, string nguoiGiao)
        {
            string query = "EXEC uspGiaoThietBi @soPhieuNhap,@nguoiGiao";


            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@soPhieuNhap",SqlDbType.NVarChar){IsNullable=false,Value=soPhieuNhap },
                new SqlParameter("@nguoiGiao",SqlDbType.NVarChar){IsNullable=false,Value=nguoiGiao },

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

        public static List<PhieuNhapHang> XemPhieuNhapHang(int loai, int pageNumber, int pageSize)
        {
            string query = "EXEC uspXemPhieuNhapThietBi @loai,@pageNumber,@pageSize";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@loai",SqlDbType.Int){IsNullable=false,Value=loai },
                new SqlParameter("@pageNumber",SqlDbType.Int){IsNullable=false,Value=pageNumber },
                new SqlParameter("@pageSize",SqlDbType.Int){IsNullable=false,Value=pageSize }

            };
            DataTable table = Dataprovider.ExcuteQuery(query, parameters.ToArray());
            List<PhieuNhapHang> list = null;


            try
            {
                list = table.AsEnumerable().ToList().ConvertAll(x =>
                new PhieuNhapHang()
                {
                    SoPhieu = x[0].ToString(),
                    MaNhanVien = x[1].ToString(),
                    NgayDat = x[2].ToString(),
                    NgayGiao = x[3].ToString(),
                    ThanhTien = uint.Parse(x[4].ToString()),
                    NguoiGiao = x[5].ToString(),
                    TenNhanVien = x[6].ToString(),
                    SoDienThoai = x[7].ToString(),
                    TenNhaCungCap= x[8].ToString(),
                });
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            //Chuyển Table thành List tên hành khách
            return list;

        }

        public static int DemPhieuNhapHang(int loai)
        {
            string query = "EXEC uspDemPhieuNhapThietBi @loai";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@loai",SqlDbType.Int){IsNullable=false,Value=loai },

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
        public static bool XoaThietBi(ThietBi thietBi)
        {
            string query = "EXCUTE usp_XoaThietBi @maTB";
            string maTB = thietBi.Ma;
            // Truyền tham số
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maTB", SqlDbType.Char) {IsNullable = false, Value = maTB},
            };
            try
            {
                Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
                return true;
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
                return false;
            }
        }

        public static DataTable LayMaNCC()
        {
            DataTable data = new DataTable();
            try
            {
                string query = "EXEC usp_LoadNCC";
                data = Dataprovider.ExcuteQuery(query);
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            return data;
        }
        public static int DemThietBiSuDung(string tenThietBi, string maNhaCungCap, List<string> exceptList)
        {
            string query = "EXEC uspDemThietBiExcepList @tenThietBi,@maNhaCungCap,@danhSachLoaiTru";
            string danhSachLoaiTru= exceptList==null?"": String.Join("|", exceptList);
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tenThietBi",SqlDbType.NVarChar){IsNullable=true,Value=tenThietBi },
                new SqlParameter("@maNhaCungCap",SqlDbType.VarChar){IsNullable=true,Value=maNhaCungCap },
                new SqlParameter("@danhSachLoaiTru",SqlDbType.VarChar){IsNullable=true,Value=danhSachLoaiTru }

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
        public static DataTable XemThietBiSuDung(string tenThietBi, string maNhaCungCap, int pageNumber, int pageSize, List<string> exceptList)
        {
            string query = "EXEC uspXemThietBiExcepList @tenThietBi,@maNhaCungCap,@danhSachLoaiTru,@pageNumber,@pageSize";
            string danhSachLoaiTru = exceptList == null ? "" : String.Join("|", exceptList);
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                    new SqlParameter("@tenThietBi",SqlDbType.NVarChar){IsNullable=false,Value=tenThietBi },
                    new SqlParameter("@maNhaCungCap",SqlDbType.NVarChar){IsNullable=false,Value=maNhaCungCap },
                    new SqlParameter("@danhSachLoaiTru",SqlDbType.VarChar){IsNullable=true,Value=danhSachLoaiTru },
                    new SqlParameter("@pageNumber",SqlDbType.Int){IsNullable=false,Value=pageNumber },
                    new SqlParameter("@pageSize",SqlDbType.Int){IsNullable=false,Value=pageSize },
            };
            DataTable data = new DataTable();
            try
            {
                data = Dataprovider.ExcuteQuery(query, parameters.ToArray());
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            return data;
        }
        public static List<ThietBi> XemThietBi(string tenThietBi, string maNhaCungCap, int pageNumber, int pageSize)
        {
            string query = "EXEC usp_LoadThietBi @tenThietBi,@maNhaCungCap,@pageNumber,@pageSize";

            List<SqlParameter> parameters = new List<SqlParameter>()
                {
                     new SqlParameter("@tenThietBi",SqlDbType.NVarChar){IsNullable=false,Value=tenThietBi },
                    new SqlParameter("@maNhaCungCap",SqlDbType.NVarChar){IsNullable=false,Value=maNhaCungCap },
                    new SqlParameter("@pageNumber",SqlDbType.Int){IsNullable=false,Value=pageNumber },
                    new SqlParameter("@pageSize",SqlDbType.Int){IsNullable=false,Value=pageSize },
                };
            DataTable data = new DataTable();
            List<ThietBi> list = null;
            try
            {


                list = Dataprovider.ExcuteQuery(query, parameters.ToArray()).AsEnumerable().ToList().ConvertAll(x =>
                new ThietBi()
                {
                    Ma = x[5].ToString(),
                    Ten = x[0].ToString(),
                    DonGia = x[2].ToString(),
                    DVT = x[1].ToString(),
                    MaNCC = x[4].ToString(),
                    TenNhaCungCap = x[3].ToString(),
                });
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            return list;
        }
        public static List<PhieuNhapHangDataSource> XemChiTietPhieuNhapThietBi(string soPhieuDat)
        {
            string query = "EXEC uspXemChiTietPhieuNhapThietBi @soPhieuDat";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@soPhieuDat",SqlDbType.VarChar){IsNullable=false,Value=soPhieuDat },

            };
            List<PhieuNhapHangDataSource> list = null;
            try
            {
                list = Dataprovider.ExcuteQuery(query, parameters.ToArray()).AsEnumerable().ToList().ConvertAll(x =>
                  new PhieuNhapHangDataSource()
                  {
                      Ma = x[1].ToString(),
                      Ten = x[2].ToString(),
                      DonViTinh = x[3].ToString(),
                      Gia = x[4].ToString(),
                      Soluong = x[5].ToString(),
                      Thanhtien = x[6].ToString(),

                  });
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            return list;

        }
        public static DataTable XemChiTietPhieuNhapThietBiTable(string soPhieuDat)
        {
            string query = "EXEC uspXemChiTietPhieuNhapThietBi @soPhieuDat";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@soPhieuDat",SqlDbType.VarChar){IsNullable=false,Value=soPhieuDat },

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
        public static DataTable LoadThietBi(string tenThietBi, string maNhaCungCap, int pageNumber, int pageSize)
        {
            DataTable data = new DataTable();
            try
            {
                string query = "EXEC usp_LoadThietBi @tenThietBi,@maNhaCungCap,@pageNumber,@pageSize";


                List<SqlParameter> parameters = new List<SqlParameter>()
                {
                     new SqlParameter("@tenThietBi",SqlDbType.NVarChar){IsNullable=false,Value=tenThietBi },
                    new SqlParameter("@maNhaCungCap",SqlDbType.NVarChar){IsNullable=false,Value=maNhaCungCap },
                    new SqlParameter("@pageNumber",SqlDbType.Int){IsNullable=false,Value=pageNumber },
                    new SqlParameter("@pageSize",SqlDbType.Int){IsNullable=false,Value=pageSize },
                };
                data = Dataprovider.ExcuteQuery(query, parameters.ToArray());
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            return data;
        }
        public static int DemThietBi(string tenThietBi, string maNhaCungCap)
        {
            string query = "EXEC uspDemThietBi @tenThietBi,@maNhaCungCap";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tenThietBi",SqlDbType.NVarChar){IsNullable=true,Value=tenThietBi },
                new SqlParameter("@maNhaCungCap",SqlDbType.VarChar){IsNullable=true,Value=maNhaCungCap }

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
        public static bool ThemSuDungThietBi(string lyDo, List<string> listMa, List<string> listSoLuong)
        {
            string query = "EXEC uspThemSuDungThietBi @lyDo,@danhSachThietBi,@danhSachSoLuong";

            string danhSachMa = String.Join("|", listMa);
            string danhSachSoLuong = String.Join("|", listSoLuong);

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@lyDo",SqlDbType.NVarChar){IsNullable=false,Value=lyDo },
                new SqlParameter("@danhSachThietBi",SqlDbType.NVarChar){IsNullable=false,Value=danhSachMa },
                new SqlParameter("@danhSachSoLuong",SqlDbType.NVarChar){IsNullable=false,Value=danhSachSoLuong },

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
        public static bool CapNhatSuDungThietBi(string maSuDung,string lyDo, List<string> listMa, List<string> listSoLuong)
        {
            string query = "EXEC uspCapNhatSuDungThietBi @maSuDung,@lyDo,@danhSachThietBi,@danhSachSoLuong";

            string danhSachMa = String.Join("|", listMa);
            string danhSachSoLuong = String.Join("|", listSoLuong);

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                 new SqlParameter("@maSuDung",SqlDbType.NVarChar){IsNullable=false,Value=maSuDung },
                new SqlParameter("@lyDo",SqlDbType.NVarChar){IsNullable=false,Value=lyDo },
                new SqlParameter("@danhSachThietBi",SqlDbType.NVarChar){IsNullable=false,Value=danhSachMa },
                new SqlParameter("@danhSachSoLuong",SqlDbType.NVarChar){IsNullable=false,Value=danhSachSoLuong },

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
        public static DataTable XemSuDungThietBi(string lyDo,string tenThietBi, int pageNumber, int pageSize)
        {
            string query = "EXEC uspXemSuDungThietBi @lyDo,@tenThietBi,@pageNumber,@pageSize";



            List<SqlParameter> parameters = new List<SqlParameter>()
                {
                      new SqlParameter("@lyDo",SqlDbType.NVarChar){IsNullable=false,Value=lyDo },
                     new SqlParameter("@tenThietBi",SqlDbType.NVarChar){IsNullable=false,Value=tenThietBi },
                    new SqlParameter("@pageNumber",SqlDbType.Int){IsNullable=false,Value=pageNumber },
                    new SqlParameter("@pageSize",SqlDbType.Int){IsNullable=false,Value=pageSize },
                };
            DataTable data = null;
            try
            {

                data = Dataprovider.ExcuteQuery(query, parameters.ToArray());
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            return data;
        }
        public static int DemSuDungThietBi(string lyDo, string tenThietBi)
        {
            string query = "EXEC uspDemSuDungThietBi @lyDo,@tenThietBi";

            List<SqlParameter> parameters = new List<SqlParameter>()
                {
                     new SqlParameter("@lyDo",SqlDbType.NVarChar){IsNullable=false,Value=lyDo },
                     new SqlParameter("@tenThietBi",SqlDbType.NVarChar){IsNullable=false,Value=tenThietBi },
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

        public static List<ThietBiDataSource> XemChiTietSuDungThietBi(string maSuDung)
        {
            string query = "EXEC uspXemChiTietSuDungThietBi @maSuDung";



            List<SqlParameter> parameters = new List<SqlParameter>()
                {
                     new SqlParameter("@maSuDung",SqlDbType.NVarChar){IsNullable=false,Value=maSuDung },
                };
            List<ThietBiDataSource> list = null;
            try
            {
                list = Dataprovider.ExcuteQuery(query, parameters.ToArray()).AsEnumerable().ToList().ConvertAll(x =>
                  new ThietBiDataSource()
                  {
                      MaThietBi = x[0].ToString(),
                      TenThietBi = x[1].ToString(),
                      SoLuong = x[3].ToString(),
                      DonGia = x[2].ToString(),
                      TenNhaCungCap = x[4].ToString(),
                  });
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            return list;
        }
        public static bool KiemTraTonThietBi(string maThietBi, int soLuong,int soLuongCu)
        {
            string query = "EXEC uspKiemTraTon @maThietBi,@soLuong,@soLuongCu";


            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maThietBi",SqlDbType.NVarChar){IsNullable=false,Value=maThietBi },
                new SqlParameter("@soLuong",SqlDbType.Int){IsNullable=false,Value=soLuong },
                new SqlParameter("@soLuongCu",SqlDbType.Int){IsNullable=false,Value=soLuongCu },

            };
            int num = 0;
            try
            {
                num= int.Parse(Dataprovider.ExcuteScalar(query, parameters.ToArray()).ToString());
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
                return false;
            }

            return num > 0? true : false;
        }
    }
}
