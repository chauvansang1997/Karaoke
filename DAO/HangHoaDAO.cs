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
    public static class HangHoaDAO
    {
        public static List<HangHoa> XemHangHoa(int loai, int pageNumber, int pageSize,int loaiChiTiet)
        {
            string query = "EXEC uspXemHangHoa @loai,@pageNumber,@pageSize,@loaiChiTiet";

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                 new SqlParameter("@loai",SqlDbType.Int){IsNullable=false,Value=loai },
                 new SqlParameter("@pageNumber",SqlDbType.Int){IsNullable=false,Value=pageNumber},
                 new SqlParameter("@pageSize",SqlDbType.Int){IsNullable=false,Value=pageSize },
                 new SqlParameter("@loaiChiTiet",SqlDbType.Int){IsNullable=false,Value=loaiChiTiet }

            };
            List<HangHoa> list = new List<HangHoa>();
            try
            {
                DataTable table = Dataprovider.ExcuteQuery(query, parameters.ToArray());
                list = table.AsEnumerable().ToList().ConvertAll(x =>
                        new HangHoa()
                        {
                            Ma = x[0].ToString(),
                            Ten =loai.ToString(),
                            Loai = loai.ToString(),
                            Gia = uint.Parse(x[3].ToString()),
                            TenHinhAnh = x[4].ToString(),
                            LoaiHangHoa=new LoaiHangHoa() { Ma = x[2].ToString()  ,Ten= x[5].ToString() },
                         
                        });
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }

            return list;
        }
        public static int DemHangHoa( int loai,int loaiChiTiet)
        {
            string query = "EXEC uspDemHangHoa @loai,@loaiChiTiet";

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@loai",SqlDbType.Int){IsNullable=false,Value=loai },
                 new SqlParameter("@loaiChiTiet",SqlDbType.Int){IsNullable=false,Value=loaiChiTiet },
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
        public static List<LoaiHangHoa> XemLoaiMon(int loai)
        {
            string query = "EXEC uspXemLoaiHangHoa @loai";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@loai",SqlDbType.Int){IsNullable=false,Value=loai }
            };
            List<LoaiHangHoa> list = null;
            try
            {
                DataTable table = Dataprovider.ExcuteQuery(query,parameters.ToArray());
                list = table.AsEnumerable().ToList().ConvertAll(x =>
                        new LoaiHangHoa()
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
    }
}
