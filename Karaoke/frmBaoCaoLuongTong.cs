using CrystalDecisions.Shared;
using DTO;
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
	public partial class frmBaoCaoLuongTong : Form
	{
		DataSet dataSet = new LuongDataSet();
		DataTable dataTable = new DataTable();
		public frmBaoCaoLuongTong()
		{
			InitializeComponent();
		}

		private void frmBaoCaoLuongTong_Load(object sender, EventArgs e)
		{
			try
			{
				DataTable data = BUS.LuongBUS.LoadThangLuongDesc();
				cbThangLuong.DataSource = data;
				cbThangLuong.DisplayMember = "thangLuong";
				cbThangLuong.ValueMember = "thangLuong";
				
				if (data.Rows.Count!=0)
				{
					dataTable = BUS.LuongBUS.XemLuongTong(null, cbThangLuong.SelectedValue.ToString());
					loadRepport(dataTable);
				}
				else
				{
					MessageBox.Show("Tháng lương chưa có", "Báo cáo lương", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				
			}
			catch(Exception ex)
			{
				MessageBox.Show("Có lỗi xảy ra", "Báo cáo lương", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Utility.Log(ex);
				return;
			}


		}

		public void loadRepport(DataTable dataTable)
		{
			dataSet.Tables[0].Merge(dataTable);
			rpLuongTong rpLuongTong = new rpLuongTong();

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

			crLuongTong.ParameterFieldInfo = pField;
			rpLuongTong.SetDataSource(dataSet.Tables[0]);
			crLuongTong.ReportSource = rpLuongTong;

			dataSet.Tables[0].Reset();
		}

		private void btnThucThi_Click(object sender, EventArgs e)
		{
			dataTable = BUS.LuongBUS.XemLuongTong(null, cbThangLuong.SelectedValue.ToString());
			loadRepport(dataTable);
		}

		private void lbXemChiTiet_Click(object sender, EventArgs e)
		{
			frmBaoCaoLuong baoCaoLuong = new frmBaoCaoLuong();
			baoCaoLuong.StartPosition = FormStartPosition.CenterScreen;
			baoCaoLuong.ShowDialog();
		}
	}
}
