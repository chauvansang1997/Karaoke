using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Karaoke.GUI_BaoCaoDoanhThu
{
	public partial class frmBaoCaoDoanhThu : Form
	{
		DataSet dataSet = new DoanhThuDataSet();
		DataTable dataTable = new DataTable();
		public frmBaoCaoDoanhThu()
		{
			InitializeComponent();
		}

		private void frmBaoCaoDoanhThu_Load(object sender, EventArgs e)
		{
			cbThang.DisplayMember = "thangHoaDon";
			cbThang.ValueMember = "thangHoaDon";
			cbThang.DropDownStyle = ComboBoxStyle.DropDownList;
			cbThang.DataSource = BUS.DoanhThuBUS.LayThangHoaDon();
			try
			{
				dataTable = BUS.DoanhThuBUS.LoadDoanhThu(cbThang.SelectedValue.ToString());
				loadRepport(dataTable);
			}catch(Exception ex)
			{
				MessageBox.Show("Có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void loadRepport(DataTable dataTable)
		{
			dataSet.Tables[0].Merge(dataTable);
			rpBaoCaoDoanhThu rpDoanhThu = new rpBaoCaoDoanhThu();

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
			crBaoCaoDoanhThu.ParameterFieldInfo = pField;


			rpDoanhThu.SetDataSource(dataSet.Tables[0]);
			crBaoCaoDoanhThu.ReportSource = rpDoanhThu;

			dataSet.Tables[0].Reset();
		}
	}
}
