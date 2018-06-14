using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAO
{
	public static class ThietBiDAO
	{
		public static bool ThemThietBi(ThietBi thietBi)
		{
			string query = "EXCUTE usp_ThemThietBi @maTB,@tenTB,@maNCC,@dvt ,@donGia";
			string maTB = thietBi.MaThietBi;
			string tenTB = thietBi.TenThietBi;
			string maNCC = thietBi.MaNCC;
			string dvt = thietBi.DVT;
			string donGia = thietBi.DonGia;
			bool rs = false;
			// Truyền tham số
			List<SqlParameter> parameters = new List<SqlParameter>()
			{
				new SqlParameter("@maTB", SqlDbType.Char) {IsNullable = false, Value = maTB},
				new SqlParameter("@tenTB", SqlDbType.Char) {IsNullable = false, Value = tenTB},
				new SqlParameter("@maNCC", SqlDbType.NVarChar) {IsNullable = false, Value = maNCC},
				new SqlParameter("@dvt", SqlDbType.NVarChar) {IsNullable = false, Value = dvt},
				new SqlParameter("@donGia", SqlDbType.NVarChar) {IsNullable = false, Value = donGia},
			};
			try
			{
				Dataprovider.ExcuteNonQuery(query,parameters.ToArray());
				rs = true;
			}
			catch (Exception ex)
			{
				Utility.Log(ex);
				rs = false;
			}

			return rs;
		}
	}
}
