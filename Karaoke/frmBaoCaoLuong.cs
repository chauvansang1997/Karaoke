using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Karaoke
{
	public partial class frmBaoCaoLuong : Form
	{
		DataSet dataSet = new LuongDataSet();
		DataTable dataTable = new DataTable();
		public frmBaoCaoLuong()
		{
			InitializeComponent();
			bindingCombox();
		}

		private void bindingCombox()
		{
			cbDanhSachNhanVien.DisplayMember = "tenNV";
			cbDanhSachNhanVien.ValueMember = "maNV"; //Field in the datatable which you want to be the value of the combobox 
			cbDanhSachNhanVien.DataSource = BUS.LuongBUS.table_Select("SELECT DISTINCT dbo.PHANCONG.MANV,TENNV FROM dbo.NHANVIEN JOIN dbo.PHANCONG ON PHANCONG.MANV = NHANVIEN.MANV");

			cbThangLuong.DisplayMember = "thangLuong";
			cbThangLuong.ValueMember = "thangLuong"; //Field in the datatable which you want to be the value of the combobox 
			cbThangLuong.DataSource = BUS.LuongBUS.table_Select("select distinct THANGLUONG FROM LUONG");
		}

		private void frmBaoCaoLuong_Load(object sender, EventArgs e)
		{

			dataTable = BUS.LuongBUS.XemLuong("%%", null);
			loadRepport(dataTable);

		}

		public void loadRepport(DataTable dataTable)
		{
			dataSet.Tables[0].Merge(dataTable);
			rpBangLuongChiTietNhanVien rpLuong = new rpBangLuongChiTietNhanVien();

			ParameterFields pField = new ParameterFields();
			ParameterField pTruongKeToan = new ParameterField();
			ParameterDiscreteValue pTruongKeToan_value = new ParameterDiscreteValue();
			pTruongKeToan_value.Value = "Danh Thanh";
			pTruongKeToan.ParameterFieldName = "TruongKeToan";
			pTruongKeToan.CurrentValues.Add(pTruongKeToan_value);
			pField.Add(pTruongKeToan);

			ParameterField pTenQuan = new ParameterField();
			ParameterDiscreteValue pTenQuan_value = new ParameterDiscreteValue();
			pTenQuan_value.Value = "Quán Karaoke Nice";
			pTenQuan.ParameterFieldName = "TenQuan";
			pTenQuan.CurrentValues.Add(pTenQuan_value);
			pField.Add(pTenQuan);

			ParameterField pDiaChiQuan = new ParameterField();
			ParameterDiscreteValue pDiaChiQuan_value = new ParameterDiscreteValue();
			pDiaChiQuan_value.Value = "123 Đinh Tiên  Hoàng, quận 10, Tp. Hồ Chí Minh";
			pDiaChiQuan.ParameterFieldName = "DiaChiQuan";
			pDiaChiQuan.CurrentValues.Add(pDiaChiQuan_value);
			pField.Add(pDiaChiQuan);

			crBaoCaoLuong.ParameterFieldInfo = pField;


			rpLuong.SetDataSource(dataSet.Tables[0]);
			rpLuong.Refresh();
			crBaoCaoLuong.ReportSource = rpLuong;
		}

		private void btnThucThiBCCTL_Click(object sender, EventArgs e)
		{
			dataTable = BUS.LuongBUS.XemLuong(cbDanhSachNhanVien.SelectedValue.ToString(), cbThangLuong.SelectedValue.ToString());
			loadRepport(dataTable);
		}
	}
}
