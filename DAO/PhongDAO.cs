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
            string query = "insert into PHONG(MAPHONG,MALOAIPHONG,TINHTRANG) VALUES(@maphong,@maloaiphong,@tinhtrang)";

            string ma = TaoMa.TaoMaPhong();

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maphong",SqlDbType.NVarChar){ Value=ma  },
                new SqlParameter("@maloaiphong",SqlDbType.NVarChar){Value=phong.TenLoai },
                new SqlParameter("@tinhtrang",SqlDbType.NVarChar){Value=phong.TinhTrang }

            };

            return Dataprovider.ExcuteNonQuery(query, parameters.ToArray()) > 0;
        }

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

        public static List<Phong> XemPhong(int trangThai, int pageSize, int pagenumber)
        {
            string query = "EXEC uspTraCuuPhong @trangThai,@pageSize,@pageNumber";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@trangThai",SqlDbType.Int){ Value=trangThai  },
                 new SqlParameter("@pageSize",SqlDbType.Int){ Value=pageSize  },
                  new SqlParameter("@pageNumber",SqlDbType.Int){ Value=pagenumber  }
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
    }
}
