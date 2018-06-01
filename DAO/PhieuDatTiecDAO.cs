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
    public class PhieuDatTiecDAO
    {
        public static List<PhieuDatTiec> XemPhieuDatCho(string maPhong,int pageNumber,int pageSize)
        {
            string query = "EXEC uspXemPhieuDatCho @maPhong,@pageNumber,@pageSize";

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maPhong",SqlDbType.VarChar){IsNullable=false,Value=maPhong },
                new SqlParameter("@pageNumber",SqlDbType.VarChar){IsNullable=false,Value=pageNumber },
                new SqlParameter("@pageSize",SqlDbType.VarChar){IsNullable=false,Value=pageSize }

            };
            List<PhieuDatTiec> list = new List<PhieuDatTiec>();
            try
            {
                DataTable table = Dataprovider.ExcuteQuery(query, parameters.ToArray());
                list = table.AsEnumerable().ToList().ConvertAll(x =>
                        new PhieuDatTiec()
                        {
                            SoHD = x[0].ToString(),
                            Phong = x[1].ToString(),
                            TenKH = x[2].ToString(),
                            SoDienThoai = x[3].ToString(),
                            NgayDat = x[4].ToString(),
                            NgayNhan = x[5].ToString(),
                        });
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }

            return list;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="maPhong"></param>
        /// <returns></returns>
        public static int DemPhieuDatTiec(string maPhong)
        {
            string query = "EXEC uspDemPhieuDatCho @maPhong";

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
               new SqlParameter("@maPhong",SqlDbType.VarChar){IsNullable=false,Value=maPhong }

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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="khachHang"></param>
        /// <param name="maPhong"></param>
        /// <param name="maNV"></param>
        /// <param name="ngayNhanPhong"></param>
        /// <param name="thoiGianDat"></param>
        /// <returns></returns>
        public static bool GhiNhanDatTiec(KhachHang khachHang, string maPhong, string maNV, DateTime ngayNhanPhong, DateTime ngayDat, DateTime ngayGioKetThuc)
        {
            string query = "EXEC uspGhiNhanDatTiec @maPhong,@tenKhachHang,@soDienThoai,@soHoaDon,@maNV,@ngayNhanPhong,@ngayDat,@ngayGioKetThuc";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                  new SqlParameter("@maPhong",SqlDbType.VarChar){ Value=maPhong  },
                  new SqlParameter("@tenKhachHang",SqlDbType.NVarChar){ Value=khachHang.Ten  },
                  new SqlParameter("@soDienThoai",SqlDbType.VarChar){ Value=khachHang.SoDT  },
                  new SqlParameter("@maNV",SqlDbType.VarChar){ Value=maNV  },
                  new SqlParameter("@ngayNhanPhong",SqlDbType.DateTime){ Value=ngayNhanPhong  },
                  new SqlParameter("@ngayDat",SqlDbType.DateTime){ Value=ngayDat  },
                  new SqlParameter("@ngayGioKetThuc",SqlDbType.DateTime){ Value=ngayGioKetThuc  }
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
        public static bool KiemTraPhieuDatTiec(string maPhong, DateTime ngayNhanPhong, DateTime ngayGioKetThuc)
        {
            string query = "EXEC uspKiemTraDatPhong @maPhong,@ngayNhanPhong,@thoiGianDat";

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                   new SqlParameter("@maPhong",SqlDbType.VarChar){IsNullable=false,Value=maPhong },
                   new SqlParameter("@maNV",SqlDbType.DateTime){ Value=ngayNhanPhong  },
                   new SqlParameter("@maNV",SqlDbType.DateTime){ Value=ngayGioKetThuc  }
            };
            int count = -1;
            try
            {
                count = int.Parse(Dataprovider.ExcuteScalar(query, parameters.ToArray()).ToString());
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            return count > 0 ? true : false;
        }
    }
}
