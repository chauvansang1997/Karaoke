using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAO
{
    public class KhuyenMaiDAO
    {
        public static bool ThemkhuyenMai(KhuyenMai khuyenMai,List<int> listLoaiKhachHang,List<float> listMucKhuyenMai)
        {
            string query = "EXEC uspThemLoaiKhuyenMai @tenKhuyenMai,@danhSachmaLoaiKhachHang,@danhSachMucKhuyenMai,@NgayBatDau,@NgayKetThuc";

            string danhSachLoaiKhachHang = String.Join("|", listLoaiKhachHang);
            string danhSachMucKhuyenMai = String.Join("|", listMucKhuyenMai);
            // Truyền tham số
            List<SqlParameter> parameters = new List<SqlParameter>()
            {

                new SqlParameter("@tenKhuyenMai", SqlDbType.NVarChar) {IsNullable = false, Value = khuyenMai.TenKhuyenMai},
                new SqlParameter("@danhSachmaLoaiKhachHang", SqlDbType.VarChar) {IsNullable = false, Value = danhSachLoaiKhachHang},
                new SqlParameter("@danhSachMucKhuyenMai", SqlDbType.VarChar) {IsNullable = false, Value = danhSachMucKhuyenMai},
                new SqlParameter("@NgayBatDau", SqlDbType.DateTime) {IsNullable = false, Value = khuyenMai.NgayBatDau},
                new SqlParameter("@NgayKetThuc", SqlDbType.DateTime) {IsNullable = false, Value = khuyenMai.NgayKetThuc},
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
        public static bool CapNhatkhuyenMai(KhuyenMai khuyenMai, List<int> listLoaiKhachHang, List<float> listMucKhuyenMai)
        {
            string query = "EXEC uspCapNhatKhuyenMai @maKhuyenMai,@tenKhuyenMai,@danhSachmaLoaiKhachHang,@danhSachMucKhuyenMai,@NgayBatDau,@NgayKetThuc";

            string danhSachLoaiKhachHang = String.Join("|", listLoaiKhachHang);
            string danhSachMucKhuyenMai = String.Join("|", listMucKhuyenMai);
            // Truyền tham số
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maKhuyenMai", SqlDbType.NVarChar) {IsNullable = false, Value = khuyenMai.MaKhuyenMai},
                new SqlParameter("@tenKhuyenMai", SqlDbType.NVarChar) {IsNullable = false, Value = khuyenMai.TenKhuyenMai},
                new SqlParameter("@danhSachmaLoaiKhachHang", SqlDbType.VarChar) {IsNullable = false, Value = danhSachLoaiKhachHang},
                new SqlParameter("@danhSachMucKhuyenMai", SqlDbType.VarChar) {IsNullable = false, Value = danhSachMucKhuyenMai},
                new SqlParameter("@NgayBatDau", SqlDbType.DateTime) {IsNullable = false, Value = khuyenMai.NgayBatDau},
                new SqlParameter("@NgayKetThuc", SqlDbType.DateTime) {IsNullable = false, Value = khuyenMai.NgayKetThuc},
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
        public static bool XoaKhuyenMai(int maKhuyenMai)
        {

            string query = "EXEC uspXoaKhuyenMai @maKhuyenMai";

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maKhuyenMai",SqlDbType.Int){IsNullable=false,Value=maKhuyenMai }
            };
            try
            {
                //nếu số dòng thành công trả về lớn hơn 0 thì thành công
                Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
                return false;
            }

            return true;
        }
        public static List<KhuyenMai> XemKhuyenMai(string tenKhuyenMai,int loaiKhachHang, int pageNumber, int pageSize)
        {
            string query = "EXEC uspXemKhuyenMai @tenKhuyenMai,@loaiKhachHang,@pageNumber,@pageSize";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                 new SqlParameter("@tenKhuyenMai",SqlDbType.NVarChar){ Value=tenKhuyenMai  },
                 new SqlParameter("@loaiKhachHang",SqlDbType.Int){ Value=loaiKhachHang  },
                 new SqlParameter("@pageNumber",SqlDbType.Int){ Value=pageNumber  },
                 new SqlParameter("@pageSize",SqlDbType.Int){ Value=pageSize  }
            };
            List<KhuyenMai> list = new List<KhuyenMai>();
            try
            {
                DataTable table = Dataprovider.ExcuteQuery(query, parameters.ToArray());
                list = table.AsEnumerable().ToList().ConvertAll(x =>
                        new KhuyenMai()
                        {
                            MaKhuyenMai = x[0].ToString(),
                            TenKhuyenMai = x[0].ToString(),
                            NgayBatDau = (DateTime)x[0],
                            NgayKetThuc = (DateTime)x[0],
                        });
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }

            return list;
        }
        public static int DemKhuyenMai(string tenKhuyenMai, int loaiKhachHang)
        {
            string query = "EXEC uspDemKhuyenMai @tenKhuyenMai,@loaiKhachHang";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tenKhuyenMai",SqlDbType.NVarChar){IsNullable=false,Value=tenKhuyenMai },
                new SqlParameter("@loaiKhachHang",SqlDbType.Int){IsNullable=false,Value=loaiKhachHang },
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
        public static DataTable XemChiTiet(int maKhuyenMai,List<int> listMaLoaiKhachHang)
        {
            string query = "EXEC uspXemDanhSachLoaiKhachHangKM @maKhuyenMai,@danhSachLoaiKhachHang";
            string danhSachLoaiKhachHang = listMaLoaiKhachHang == null ? "" : String.Join(",", listMaLoaiKhachHang);

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maKhuyenMai",SqlDbType.Int){ Value=maKhuyenMai  },
                new SqlParameter("@danhSachLoaiKhachHang",SqlDbType.VarChar){IsNullable=false,Value=danhSachLoaiKhachHang },
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
    }
}
