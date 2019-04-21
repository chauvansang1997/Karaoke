using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAO
{
    public static class LoaiPhongDAO
    {
        public static bool ThemLoaiPhong(LoaiPhong loaiPhong)
        {
            string query = "EXEC uspThemLoaiPhong  @tenLoaiPhong,@gia";

            string ma = TaoMa.TaoMaPhong();

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tenLoaiPhong",SqlDbType.NVarChar){Value=loaiPhong.Ten },

                new SqlParameter("@gia",SqlDbType.Int){Value=loaiPhong.Gia }

            };

            return Dataprovider.ExcuteNonQuery(query, parameters.ToArray()) > 0;
        }

        public static bool CapNhatLoaiPhong(LoaiPhong loaiPhong)
        {
            string query = "EXEC uspCapNhatLoaiPhong  @tenLoaiPhong,@gia";

            string ma = TaoMa.TaoMaPhong();

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tenLoaiPhong",SqlDbType.NVarChar){Value=loaiPhong.Ten },

                new SqlParameter("@gia",SqlDbType.Int){Value=loaiPhong.Gia }

            };

            return Dataprovider.ExcuteNonQuery(query, parameters.ToArray()) > 0;
        }
        public static bool KiemTraLoaiPhong(string tenLoaiPhong)
        {
            string query = "EXEC uspKiemTraLoaiPhong  @tenLoaiPhong,@gia";

            string ma = TaoMa.TaoMaPhong();

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tenLoaiPhong",SqlDbType.NVarChar){Value=tenLoaiPhong}

            };

            return (int)Dataprovider.ExcuteScalar(query, parameters.ToArray()) == 0 ;
        }



        public static List<LoaiPhong> TraCuuLoaiPhong(LoaiPhong loaiPhong)
        {
            string query = "EXEC uspXemLoaiPhong  @tenLoaiPhong,@gia";

            string ma = TaoMa.TaoMaPhong();

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tenLoaiPhong",SqlDbType.NVarChar){Value=loaiPhong.Ten },

                new SqlParameter("@gia",SqlDbType.Int){Value=loaiPhong.Gia }

            };
            List<LoaiPhong> list = new List<LoaiPhong>();
            try
            {
                DataTable table = Dataprovider.ExcuteQuery(query, parameters.ToArray());
                list = table.AsEnumerable().ToList().ConvertAll(x =>
                        new LoaiPhong()
                        {
                            Ma = x[0].ToString(),
                            Ten = x[1].ToString(),
                            Gia = int.Parse(x[2].ToString())
                        });
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }

            return list;
        }
    }
}
