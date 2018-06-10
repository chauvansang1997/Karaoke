using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAO.PhanCong
{
	public static class PhanCongDAO
	{
		public static DataTable LoadPhanCong()
		{
			string query = "EXEC usp_LoadPhanCong";
			return Dataprovider.ExcuteQuery(query);
		}
		public static DataTable SelectAll(String query)
		{
			return Dataprovider.ExcuteQuery(query);
		}
	}
}
