using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO.QuanLyHangHoa
{
    public static class MonAnDAO
    {
        public static bool ThemMonAn(MonAn monAn,string listNguyenLieu,string listSoLuong)
        {
           
            //Thêm món ăn
            string query = " EXEC uspThemMonAn @listNguyenLieu,@listSoLuong,@tenmon,@loaimon,@anhminhhoa,@dongia";


           
            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            { 
                new SqlParameter("@listNguyenLieu", SqlDbType.VarChar) { IsNullable = false, Value = listNguyenLieu },
                new SqlParameter("@listSoLuong", SqlDbType.VarChar) { IsNullable = false, Value = listSoLuong },
                new SqlParameter("@tenmon",SqlDbType.NVarChar){IsNullable=false,Value=monAn.Ten },
                new SqlParameter("@loaimon",SqlDbType.NVarChar){IsNullable=false,Value=monAn.Loai },
                new SqlParameter("@anhminhhoa",SqlDbType.VarChar){IsNullable=false,Value=monAn.TenHinhAnh },
                new SqlParameter("@dongia",SqlDbType.Decimal){IsNullable=false,Value=monAn.Gia },
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
        public static bool SuaMonAn(MonAn monAn, string listNguyenLieu, string listSoLuong)
        {

            //Thêm món ăn
            string query = " EXEC uspSuaMonAn @maMonAn,@listNguyenLieu,@listSoLuong,@tenmon,@loaimon,@anhminhhoa,@dongia";



            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maMonAn", SqlDbType.VarChar) { IsNullable = false, Value = monAn.Ma },
                new SqlParameter("@listNguyenLieu", SqlDbType.VarChar) { IsNullable = false, Value = listNguyenLieu },
                new SqlParameter("@listSoLuong", SqlDbType.VarChar) { IsNullable = false, Value = listSoLuong },
                new SqlParameter("@tenmon",SqlDbType.NVarChar){IsNullable=false,Value=monAn.Ten },
                new SqlParameter("@loaimon",SqlDbType.NVarChar){IsNullable=false,Value=monAn.Loai },
                new SqlParameter("@anhminhhoa",SqlDbType.VarChar){IsNullable=false,Value=monAn.TenHinhAnh },
                new SqlParameter("@dongia",SqlDbType.Decimal){IsNullable=false,Value=monAn.Gia },
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
        public static bool CapNhatMonAn(MonAn monAn, string listNguyenLieu)
        {

            //Thêm món ăn
            string query = " EXEC uspThemMonAn @maMonAn,@listNguyenLieu,@mamon,@tenmon,@loaimon,@anhminhhoa,@dongia";



            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maMonAn", SqlDbType.VarChar) { IsNullable = false, Value = monAn.Ma },
                new SqlParameter("@listNguyenLieu", SqlDbType.VarChar) { IsNullable = false, Value = listNguyenLieu },
                new SqlParameter("@tenmon",SqlDbType.NVarChar){IsNullable=false,Value=monAn.Ten },
                new SqlParameter("@loaimon",SqlDbType.NVarChar){IsNullable=false,Value=monAn.Loai },
                new SqlParameter("@anhminhhoa",SqlDbType.VarChar){IsNullable=false,Value=monAn.TenHinhAnh },
                new SqlParameter("@dongia",SqlDbType.Decimal){IsNullable=false,Value=monAn.Gia },
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
        public static List<MonAn> XemMonAn(string tenMonAn, int loaiMonAn, int pageNumber,int pageSize,uint donGia = 0)
        {
            string query = "EXEC uspXemMonAn @tenMonAn,@loaiMonAn,@donGia,@pageNumber,@pageSize";

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tenMonAn",SqlDbType.NVarChar){IsNullable=false,Value=tenMonAn },
                new SqlParameter("@loaiMonAn",SqlDbType.Int){IsNullable=false,Value=loaiMonAn},
                new SqlParameter("@donGia",SqlDbType.Decimal){IsNullable=false,Value=donGia },
                 new SqlParameter("@pageNumber",SqlDbType.Int){IsNullable=false,Value=pageNumber},
                new SqlParameter("@pageSize",SqlDbType.Int){IsNullable=false,Value=pageSize },
            };
            List<MonAn> list = new List<MonAn>();
            try
            {
                DataTable table = Dataprovider.ExcuteQuery(query, parameters.ToArray());
                list = table.AsEnumerable().ToList().ConvertAll(x =>
                        new MonAn()
                        {
                            Ma = x[0].ToString(),
                            Ten = x[1].ToString(),
                            Loai = x[2].ToString(),                        
                            TenHinhAnh = x[3].ToString(),
                             Gia = uint.Parse(x[4].ToString())
                        });
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }

            return list;
        }
        public static List<MonAnDataSource> XemMonAnDataSource(string tenMonAn, int loaiMonAn, int pageNumber, int pageSize)
        {
            string query = "EXEC uspXemMonAn2 @tenMonAn,@loaiMonAn,@pageNumber,@pageSize";

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tenMonAn",SqlDbType.NVarChar){IsNullable=false,Value=tenMonAn },
                new SqlParameter("@loaiMonAn",SqlDbType.Int){IsNullable=false,Value=loaiMonAn},
                 new SqlParameter("@pageNumber",SqlDbType.Int){IsNullable=false,Value=pageNumber},
                new SqlParameter("@pageSize",SqlDbType.Int){IsNullable=false,Value=pageSize },
            };
            List<MonAnDataSource> list = new List<MonAnDataSource>();
            try
            {
                DataTable table = Dataprovider.ExcuteQuery(query, parameters.ToArray());
                list = table.AsEnumerable().ToList().ConvertAll(x =>
                        new MonAnDataSource()
                        {
                            Ma = x[0].ToString(),
                            Ten = x[1].ToString(),
                           MaLoaiHangHoa= x[2].ToString(),
                           Gia= x[3].ToString(),
                           AnhMinhHoa= x[4].ToString(),
                           TenLoaiHangHoa= x[5].ToString(),
                        });
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }

            return list;
        }
        public static List<MonAn> XemMonAn(string tenMonAn,int loaiMonAn,uint donGia = 0)
        {
            string query = "EXEC uspXemMonAn @tenMonAn,@loaiMonAn,@donGia";

 
            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tenMonAn",SqlDbType.NVarChar){IsNullable=false,Value=tenMonAn },
                new SqlParameter("@loaiMonAn",SqlDbType.Int){IsNullable=false,Value=loaiMonAn},
                new SqlParameter("@donGia",SqlDbType.Decimal){IsNullable=false,Value=donGia },

            };
            List<MonAn> list = null;
            try
            {
               DataTable table = Dataprovider.ExcuteQuery(query, parameters.ToArray());
               list = table.AsEnumerable().ToList().ConvertAll(x =>
                       new MonAn()
                       {
                           Ma = x[0].ToString(),
                           Ten = x[1].ToString(),
                           Loai = x[2].ToString(),
                           Gia = uint.Parse(x[3].ToString()),
                           TenHinhAnh = x[4].ToString()
                       });
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }

            return list;
        }

        public static bool XoaMonAn(string maMonAn)
        {

            string query = "delete from MONAN where mamon =@maMonAn";


            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maMonAn",SqlDbType.VarChar){IsNullable=false,Value=maMonAn }
            };
            //nếu số dòng thành công trả về lớn hơn 0 thì thành công
            int num = Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
            if (num == 0)
            {
                return false;
            }
            return true;
        }
        public static int DemMonAn(string tenMonAn, string loaiMonAn, uint donGia = 0)
        {
            string query = "EXEC uspDemMonAn @tenMonAn,@loaiMonAn,@donGia";

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tenMonAn",SqlDbType.NVarChar){IsNullable=false,Value=tenMonAn },
                new SqlParameter("@loaiMonAn",SqlDbType.NVarChar){IsNullable=false,Value=loaiMonAn},
                new SqlParameter("@donGia",SqlDbType.Decimal){IsNullable=false,Value=donGia },

            };
            int count = 0;
            try
            {
                count=int.Parse(Dataprovider.ExcuteScalar(query, parameters.ToArray()).ToString());
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            return count;
        }
        public static List<LoaiMon> XemLoaiMon()
        {
            string query = "SELECT * FROM LOAIMONAN";
            List<LoaiMon> list = null;
            try
            {
                DataTable table = Dataprovider.ExcuteQuery(query);
                list = table.AsEnumerable().ToList().ConvertAll(x =>
                        new LoaiMon()
                        {
                            Ma = x[0].ToString(),
                            Ten = x[1].ToString()
                        });
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }

            return list;
        }
        public static List<NguyenLieuMADataSource> XemNguyenLieuMonAn(string maMonAn)
        {
            string query = "EXEC uspXemChiTietMonAn @maMonAn";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maMonAn",SqlDbType.NVarChar){IsNullable=false,Value=maMonAn },


            };
            List<NguyenLieuMADataSource> list = null;
            try
            {
                DataTable table = Dataprovider.ExcuteQuery(query, parameters.ToArray());
                list = table.AsEnumerable().ToList().ConvertAll(x =>
                        new NguyenLieuMADataSource()
                        {
                            Ma = x[0].ToString(),
                            Ten = x[1].ToString(),
                            DonViTinh = x[2].ToString(),
                            Gia = x[3].ToString(),
                            SoLuong= x[4].ToString(),
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
