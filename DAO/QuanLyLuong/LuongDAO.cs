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
		public static DataTable XemLuong(String maNV)
		{
			string query = "EXEC usp_XemLuong @maNV";
			List<SqlParameter> parameters = new List<SqlParameter>()
			{
				 new SqlParameter("@maNV",SqlDbType.VarChar){IsNullable=true,Value=maNV??(Object)DBNull.Value}
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
	}
}
