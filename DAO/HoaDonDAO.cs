using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public static class HoaDonDAO
    {
        public static bool ThemChiTietHoaDon(string mahd,List<string> listMa,List<string> listSoLuongMa, List<string> listSp, List<string> listSoLuongSp)
        {
            string query = "EXEC uspThemChiTietHoaDon @maHD,@danhSachMa,@danhSachSoLuongMa,@danhSachSp,@danhSachSoLuongSp";

            string danhSachMa= String.Join("|", listMa);
            string danhSachSoLuongMa = String.Join("|", listSoLuongMa);
            string danhSachSp = String.Join("|", listSp);
            string danhSachSoLuongSp = String.Join("|", listSoLuongSp);
            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maHD",SqlDbType.NVarChar){IsNullable=false,Value=mahd },
                new SqlParameter("@danhSachMa",SqlDbType.NVarChar){IsNullable=false,Value=danhSachMa },
                new SqlParameter("@danhSachSoLuongMa",SqlDbType.NVarChar){IsNullable=false,Value=danhSachSoLuongMa },
                new SqlParameter("@danhSachSp",SqlDbType.NVarChar){IsNullable=false,Value=danhSachSp },
                new SqlParameter("@danhSachSoLuongSp",SqlDbType.NVarChar){IsNullable=false,Value=danhSachSoLuongSp },

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
        public static string LayMaHoaDon(string maPhong)
        {
            string query = "EXEC uspLayHoaDon @maPhong";

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maPhong",SqlDbType.VarChar){IsNullable=false,Value=maPhong }

            };
            string result="";
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
                            Ma= x[0].ToString(),
                            Ten = x[1].ToString(),
                            Soluong = x[2].ToString(),
                            Loai = x[3].ToString(),                          
                            Gia = x[4].ToString(),
                            Thanhtien = (int.Parse(x[2].ToString())* int.Parse(x[4].ToString())).ToString()
                        }
                        );
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }

            return list;
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
                            MaLoaiHangHoa= x[3].ToString(),
                            TenLoaiHangHoa= x[6].ToString()

                        }
                        );
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }

            return list;
        }
        public static bool DatCocTien(uint tienDatCoc,string soHD)
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

        public static string LayMaHoaDonDatTiec(string maPhong,string tenKhachHang,string soDienThoai,DateTime ngayNhanPhong)
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
    }
}
