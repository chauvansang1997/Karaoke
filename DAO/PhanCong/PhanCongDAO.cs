﻿using DTO;
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

		public static DataTable LayMaNV()
		{
			string query = "SELECT DISTINCT MANV,TENNV FROM NHANVIEN";
			return Dataprovider.ExcuteQuery(query);
		}

		public static DataTable LayMaCa()
		{
			string query ="SELECT DISTINCT MACA,TENCA FROM CALAMVIEC";
			return Dataprovider.ExcuteQuery(query);
		}

		public static bool  ThemPhanCong(String maNV,String maCa,DateTime ngay)
		{
			string query = "EXEC usp_ThemPhanCong @maNV,@maCa,@ngay";
			List<SqlParameter> parameters = new List<SqlParameter>()
			{
				new SqlParameter("@maNV", SqlDbType.VarChar) {IsNullable = false, Value =maNV },
				new SqlParameter("@maCa", SqlDbType.VarChar) {IsNullable = false, Value = maCa },
				new SqlParameter("@ngay", SqlDbType.DateTime) {IsNullable = false, Value = ngay },
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
			return false ;
		}

		public static bool XoaPhanCong(String maNV, String maCa, DateTime ngay)
		{
			string query = "EXEC usp_XoaPhanCong @maNV,@maCa,@ngay";
			List<SqlParameter> parameters = new List<SqlParameter>()
			{
				new SqlParameter("@maNV", SqlDbType.VarChar) {IsNullable = false, Value =maNV },
				new SqlParameter("@maCa", SqlDbType.VarChar) {IsNullable = false, Value = maCa },
				new SqlParameter("@ngay", SqlDbType.DateTime) {IsNullable = false, Value = ngay },
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

		public static bool CapNhatPhanCong(String maNVCu, String maCaCu, DateTime ngayCu, String maNV, String maCa, DateTime ngay)
		{
			string query = "EXEC usp_CapNhatPhanCong @maNVCu,@maCaCu,@ngayCu,@maNV,@maCa,@ngay";
			List<SqlParameter> parameters = new List<SqlParameter>()
			{
				new SqlParameter("@maNVCu", SqlDbType.VarChar) {IsNullable = false, Value =maNVCu},
				new SqlParameter("@maCaCu", SqlDbType.VarChar) {IsNullable = false, Value = maCaCu },
				new SqlParameter("@ngayCu", SqlDbType.DateTime) {IsNullable = false, Value = ngayCu },
				new SqlParameter("@maNV", SqlDbType.VarChar) {IsNullable = false, Value =maNV },
				new SqlParameter("@maCa", SqlDbType.VarChar) {IsNullable = false, Value = maCa },
				new SqlParameter("@ngay", SqlDbType.DateTime) {IsNullable = false, Value = ngay },
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
	}
}
