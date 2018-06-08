using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAO.TinhLuong
{
	public static class LuongDAO
	{
		public static DataTable XemLuong(String maNV,String tenNV,String thangLuong)
		{
			string query = "EXECUTE dbo.usp_CapNhatChiTietLuong @maNV, @tenNV ,@thangLuong";
			List<SqlParameter> parameters = new List<SqlParameter>()
			{
				 new SqlParameter("@maNV",SqlDbType.VarChar){IsNullable=true,Value=maNV??(Object)DBNull.Value},
				 new SqlParameter("@tenNV",SqlDbType.VarChar){IsNullable=true,Value=tenNV??(Object)DBNull.Value},
				 new SqlParameter("@thangLuong",SqlDbType.VarChar){IsNullable=true,Value=thangLuong??(Object)DBNull.Value}
			};
			DataTable table = null;
			try
			{
				 table= Dataprovider.ExcuteQuery(query, parameters.ToArray());
				
			}
			catch (Exception ex)
			{
				Utility.Log(ex);
			}

			return table;
		}

		public static DataTable XemLuongT(String maNV, String tenNV, String thangLuong)
		{
			string query = "EXECUTE dbo.usp_CapNhatChiTietLuong @maNV, @tenNV ,@thangLuong";
			List<SqlParameter> parameters = new List<SqlParameter>()
			{
				 new SqlParameter("@maNV",SqlDbType.VarChar){IsNullable=true,Value=maNV??(Object)DBNull.Value},
				 new SqlParameter("@tenNV",SqlDbType.VarChar){IsNullable=true,Value=tenNV??(Object)DBNull.Value},
				 new SqlParameter("@thangLuong",SqlDbType.VarChar){IsNullable=true,Value=thangLuong??(Object)DBNull.Value}
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
