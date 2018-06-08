using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DAO;

namespace DAO.TinhLuong
{
	public static class LuongDAO
	{
		private static SqlDataAdapter adapter;

		public static DataTable XemLuong(String maNV,String thangLuong)
		{
			string query = "EXECUTE dbo.usp_CapNhatChiTietLuong @maNV ,@thangLuong";
			List<SqlParameter> parameters = new List<SqlParameter>()
			{
				 new SqlParameter("@maNV",SqlDbType.VarChar){IsNullable=true,Value=maNV??(Object)DBNull.Value},
				 new SqlParameter("@thangLuong",SqlDbType.NVarChar){IsNullable=true,Value=thangLuong??(Object)DBNull.Value}
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

		public static DataTable XemLuongTong(String maNV,String thangLuong)
		{
			string query = "EXECUTE usp_XemLuong @maNV ,@thangLuong";
			List<SqlParameter> parameters = new List<SqlParameter>()
			{
				 new SqlParameter("@maNV",SqlDbType.NVarChar){IsNullable=true,Value=maNV??(Object)DBNull.Value},
				 new SqlParameter("@thangLuong",SqlDbType.NVarChar){IsNullable=true,Value=thangLuong??(Object)DBNull.Value}
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

		public static DataTable table_Select(String sql)
		{
			adapter = new SqlDataAdapter(sql,DAO.Dataprovider.ConnectionString );
			//Tạo mới table
			var table = new DataTable();
			//Đỗ dữ lêiuj vào
			adapter.Fill(table);
			//Trả về data table
			return table;
		}
	}
}
