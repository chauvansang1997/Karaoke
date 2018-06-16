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
			string query = "EXECUTE usp_ThemNCC @maNCC,@tenNCC,@loaiHangCC,@sdt,@diaChi";

			string maNCC = ncc.MaNCC;
			string tenNCC = ncc.Ten;
			string loaiHangCC = ncc.LoaiHangCC;
			string sdt = ncc.SDT;
			string diaChi = ncc.DiaChi;
			// Truyền tham số
			List<SqlParameter> parameters = new List<SqlParameter>()
			{
				new SqlParameter("@maNCC", SqlDbType.Char) {IsNullable = false, Value=maNCC},
				new SqlParameter("@tenNCC", SqlDbType.NVarChar) {IsNullable = false, Value = tenNCC},
				new SqlParameter("@loaiHangCC", SqlDbType.NVarChar) {IsNullable = false, Value = loaiHangCC},
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
			string query = "EXEC usp_CapNhatNCC @maNCC,@tenNCC,@loaiHangCC,@sdt,@diaChi";

			string maNCC = ncc.MaNCC;
			string tenNCC = ncc.Ten;
			string loaiHangCC = ncc.LoaiHangCC;
			string sdt = ncc.SDT;
			string diaChi = ncc.DiaChi;
			// Truyền tham số
			List<SqlParameter> parameters = new List<SqlParameter>()
			{
				new SqlParameter("@maNCC", SqlDbType.Char) {IsNullable = false, Value=maNCC},
				new SqlParameter("@tenNCC", SqlDbType.NVarChar) {IsNullable = false, Value = tenNCC},
				new SqlParameter("@loaiHangCC", SqlDbType.NVarChar) {IsNullable = false, Value = loaiHangCC},
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

		public static bool XoaNCC(NhaCungCap ncc)
		{
			bool rs = false;
			string query = "EXEC usp_XoaNCC @maNCC";

			string maNCC = ncc.MaNCC;
			// Truyền tham số
			List<SqlParameter> parameters = new List<SqlParameter>()
			{
				new SqlParameter("@maNCC", SqlDbType.Char) {IsNullable = false, Value=maNCC},
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

		public static DataTable LoadNCC()
		{
			DataTable data = new DataTable();
			try
			{
				string query = "EXEC usp_LoadNCC";
				data= Dataprovider.ExcuteQuery(query);
			}
			catch(Exception ex)
			{
				Utility.Log(ex);
			}
			return data;
		}
	}
}
