using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DTO;

namespace DAO.QuanLyNCC
{
	public static class NhaCungCapDAO
	{
		public static bool ThemNCC(NhaCungCap ncc)
		{
			string query = "EXECUTE usp_ThemNCC @tenNCC,@sdt,@diaChi";
			string tenNCC = ncc.Ten;
			string sdt = ncc.SDT;
			string diaChi = ncc.DiaChi;
			// Truyền tham số
			List<SqlParameter> parameters = new List<SqlParameter>()
			{
				new SqlParameter("@tenNCC", SqlDbType.NVarChar) {IsNullable = false, Value = tenNCC},
				new SqlParameter("@sdt", SqlDbType.NVarChar) {IsNullable = true, Value = sdt??(Object)DBNull.Value},
				new SqlParameter("@diaChi", SqlDbType.NVarChar) {IsNullable = true, Value = diaChi??(Object)DBNull.Value},
			};
			try
			{
				Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
				return true;
			}
			catch (Exception ex)
			{
				Utility.Log(ex);
			}

			return false;
		}


		public static bool CapNhatNCC(NhaCungCap ncc)
		{
			string query = "EXEC usp_CapNhatNCC @maNCC,@tenNCC,@sdt,@diaChi";

			string maNCC = ncc.MaNCC;
			string tenNCC = ncc.Ten;
			string sdt = ncc.SDT;
			string diaChi = ncc.DiaChi;
			// Truyền tham số
			List<SqlParameter> parameters = new List<SqlParameter>()
			{
				new SqlParameter("@maNCC", SqlDbType.Char) {IsNullable = false, Value=maNCC},
				new SqlParameter("@tenNCC", SqlDbType.NVarChar) {IsNullable = false, Value = tenNCC},
				new SqlParameter("@sdt", SqlDbType.NVarChar) {IsNullable = true, Value = sdt??(Object)DBNull.Value},
				new SqlParameter("@diaChi", SqlDbType.NVarChar) {IsNullable = true, Value = diaChi??(Object)DBNull.Value},
			};
			try
			{
				Dataprovider.ExcuteNonQuery(query,parameters.ToArray());
				return true;
			}
			catch (Exception ex)
			{
				Utility.Log(ex);
			}

			return false;
		}

		public static bool XoaNCC(string maNhaCungCap)
		{

			string query = "EXEC usp_XoaNCC @maNCC";


			// Truyền tham số
			List<SqlParameter> parameters = new List<SqlParameter>()
			{
				new SqlParameter("@maNCC", SqlDbType.VarChar) {IsNullable = false, Value=maNhaCungCap},
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
        public static List<NhaCungCap> XemNhaCungCap()
        {
            //string query = "SELECT * FROM NHACUNGCAP";

            //DataTable table = Dataprovider.ExcuteQuery(query);

            List<NhaCungCap> list = null;
            try
            {
                //list = table.AsEnumerable().ToList().ConvertAll(x =>
                //new NhaCungCap() { Ten = x[1].ToString(), SDT = x[2].ToString(), DiaChi = x[3].ToString(), MaNCC = x[0].ToString() });
                using (KaraokeDataContext karaokeDataContext = new KaraokeDataContext())
                {
                    var listNCC = (from ncc in karaokeDataContext.NHACUNGCAPs
                                   select new NhaCungCap()
                                   {
                                       MaNCC = ncc.MANCC,
                                       Ten = ncc.TENNCC,
                                       SDT = ncc.SDT,
                                       DiaChi = ncc.DIACHI,
                                   }).ToList();
                    listNCC.Add(new NhaCungCap() { MaNCC = "", Ten = "Tất cả" });
                    list = listNCC;
                }
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            return list;

        }
        public static DataTable XemNhaCungCap(string tenNhaCungCap,int pageNumber,int pageSize)
		{
            string query = "EXEC usp_LoadNCC @tenNhaCungCap,@pageNumber,@pageSize";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tenNhaCungCap",SqlDbType.NVarChar){IsNullable=false,Value=tenNhaCungCap },
                new SqlParameter("@pageNumber",SqlDbType.Int){IsNullable=false,Value=pageNumber },
                new SqlParameter("@pageSize",SqlDbType.Int){IsNullable=false,Value=pageSize },
            };
            DataTable data = new DataTable();
			try
			{
				
				data= Dataprovider.ExcuteQuery(query,parameters.ToArray());
			}
			catch(Exception ex)
			{
				Utility.Log(ex);
			}
			return data;
		}
        public static int DemNhaCungCap(string tenNhaCungCap)
        {
            string query = "EXEC uspDemNhaCungCap @tenNhaCungCap";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tenNhaCungCap",SqlDbType.NVarChar){IsNullable=false,Value=tenNhaCungCap },

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
