using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DTO;
namespace DAO
{
    public static class PhanQuyenDAO
    {
        public static List<Quyen> XemQuyen()
        {
            List<Quyen> list = null;

            string query = "EXEC uspXemQuyen";

            try
            {
                list = Dataprovider.ExcuteQuery(query).AsEnumerable().ToList().ConvertAll(x =>
                  new Quyen()
                  {
                      Ma = int.Parse(x[0].ToString()),
                      Ten = x[1].ToString(),

                  });
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            return list;
        }

        public static List<PhanQuyen> XemPhanQuyen()
        {
            List<PhanQuyen> list = null;

            string query = "EXEC uspXemPhanQuyen";

            try
            {
                list = Dataprovider.ExcuteQuery(query).AsEnumerable().ToList().ConvertAll(x =>
                  new PhanQuyen()
                  {
                      MaChucVu = x[0].ToString(),
                      MaQuyen = int.Parse(x[1].ToString()),

                  });
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            return list;
        }
        public static List<int> LayQuyen(NhanVien nhanVien)
        {
            List<int> list = null;

            string query = "EXEC [uspLayQuyen] @maNhanVien";
            string sql = "SELECT C.MAQUYEN FROM NHANVIEN A,CHUCVU B, PHANQUYEN C WHERE A.MACV=B.MACV AND B.MACV = C.MACV AND A.MANV = @maNhanVien";
            //truyền tham số vào câu truy vấn
            //List<SqlParameter> parameters = new List<SqlParameter>()
            //{
            //    new SqlParameter("@maNhanVien",SqlDbType.VarChar){IsNullable=false,Value=nhanVien.MaNV }

            //};
            try
            {
                using (KaraokeDataContext karaokeDataContext = new KaraokeDataContext())
                {
                    list = (from phanQuyen in karaokeDataContext.PHANQUYENs
                            from nv in karaokeDataContext.NHANVIENs
                            from cv in karaokeDataContext.CHUCVUs
                            where nv.MACV == cv.MACV && phanQuyen.MACV == cv.MACV && nv.MANV == nhanVien.MaNV
                            select phanQuyen.MAQUYEN).ToList();
                }
                //list = Dataprovider.ExcuteQuery(query, parameters.ToArray()).AsEnumerable().ToList().ConvertAll(x =>
                //  int.Parse(x[0].ToString()));
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            return list;
        }
        public static bool CapNhatPhanQuyen(ChucVu chucVu, Quyen quyen, int bThem)
        {
            string query = "EXEC uspCapNhatQuyen @maChucVu,@maQuyen,@them";


            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maChucVu",SqlDbType.VarChar){IsNullable=false,Value=chucVu.MaChucVu },
                new SqlParameter("@maQuyen",SqlDbType.Int){IsNullable=false,Value=quyen.Ma },
                new SqlParameter("@them",SqlDbType.Int){IsNullable=false,Value=bThem },

            };
            try
            {
                //nếu số dòng thành công trả về lớn hơn 0 thì thành công
                Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
            }
            catch (Exception ex)
            {

                Utility.Log(ex);
            }


            return true;
        }

    }
}
