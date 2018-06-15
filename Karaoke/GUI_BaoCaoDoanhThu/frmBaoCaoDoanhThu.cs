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
			cbThang.ValueMember = "thangHoaDoN";
			cbThang.DropDownStyle = ComboBoxStyle.DropDownList;
			cbThang.DataSource = BUS.DoanhThuBUS.LayThangHoaDon();

			dataTable = BUS.DoanhThuBUS.LoadDoanhThu(cbThang.SelectedValue.ToString());
			loadRepport(dataTable);
		}

		private void loadRepport(DataTable dataTable)
		{
			dataSet.Tables[0].Merge(dataTable);
			rpBaoCaoDoanhThu rpDoanhThu = new rpBaoCaoDoanhThu();
			rpDoanhThu.SetDataSource(dataSet.Tables[0]);
			crBaoCaoDoanhThu.ReportSource = rpDoanhThu;

			dataSet.Tables[0].Reset();
		}
	}
}
