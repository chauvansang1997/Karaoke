using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAO.QuanLyCaTruc
{
	public static class CaLamViecDAO
	{
		public static object Ultility { get; private set; }

		public static DataTable LoadLamViec()
		{
			DataTable data = new DataTable();

			string query = "EXEC usp_LoadCaTruc";

			try
			{
				data = Dataprovider.ExcuteQuery(query);
			}
			catch(Exception ex)
			{
				Utility.Log(ex);
			}
			return data;
		}

		public static bool ThemCaLamViec(CaLamViec ca)
		{
			int rowCount = 0;
			int maCa = ca.MaCa;
			string tenCa = ca.TenCa;
			DateTime gioBD = ca.GioBD;
			DateTime gioKT = ca.GioKT;
			int tienLuong = ca.TienLuong;
			string query = "EXEC usp_ThemCaTruc @maCa,@tenCa,@gioBD,@gioKT,@tienLuong";

			List<SqlParameter> parameters = new List<SqlParameter>
			{
				new SqlParameter("@maCa",SqlDbType.Int){IsNullable= false,Value=maCa},
				new SqlParameter("@tenCa",SqlDbType.NVarChar){IsNullable= false,Value=tenCa},
				new SqlParameter("@gioBD",SqlDbType.DateTime){IsNullable= false,Value=gioBD},
				new SqlParameter("@gioKT",SqlDbType.DateTime){IsNullable= false,Value=gioKT},
				new SqlParameter("@tienLuong",SqlDbType.Int){IsNullable= false,Value=tienLuong },

			};

			try
			{
				rowCount =Dataprovider.ExcuteNonQuery(query,parameters.ToArray());
			}
			catch (Exception ex)
			{
				Utility.Log(ex);
			}
			return rowCount > 0 ? true : false;
		}

		public static bool CapNhatCaLamViec(CaLamViec ca)
		{
			int rowCount = 0;
			int maCa = ca.MaCa;
			string tenCa = ca.TenCa;
			DateTime gioBD = ca.GioBD;
			DateTime gioKT = ca.GioKT;
			int tienLuong = ca.TienLuong;
			string query = "EXEC usp_CapNhatCaTruc @maCa,@tenCa,@gioBD,@gioKT,@tienLuong";

			List<SqlParameter> parameters = new List<SqlParameter>
			{
				new SqlParameter("@maCa",SqlDbType.Int){IsNullable= false,Value=maCa},
				new SqlParameter("@tenCa",SqlDbType.NVarChar){IsNullable= false,Value=tenCa},
				new SqlParameter("@gioBD",SqlDbType.Time){IsNullable= false,Value=gioBD},
				new SqlParameter("@gioKT",SqlDbType.Time){IsNullable= false,Value=gioKT},
				new SqlParameter("@tienLuong",SqlDbType.Int){IsNullable= false,Value=tienLuong },

			};

			try
			{
				rowCount = Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
			}
			catch (Exception ex)
			{
				Utility.Log(ex);
			}
			return rowCount > 0 ? true : false;
		}

		public static bool XoaCaLamViec(CaLamViec ca)
		{
			int rowCount = 0;
			int maCa = ca.MaCa;
			string tenCa = ca.TenCa;
			DateTime gioBD = ca.GioBD;
			DateTime gioKT = ca.GioKT;
			int tienLuong = ca.TienLuong;
			string query = "EXEC usp_XoaCaTruc @maCa";

			List<SqlParameter> parameters = new List<SqlParameter>
			{
				new SqlParameter("@maCa",SqlDbType.Int){IsNullable= false,Value=maCa},
			};

			try
			{
				rowCount = Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
			}
			catch (Exception ex)
			{
				Utility.Log(ex);
			}
			return rowCount > 0 ? true : false;
		}
	}
}
