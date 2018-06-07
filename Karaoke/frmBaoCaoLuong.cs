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
		public frmBaoCaoLuong()
		{
			InitializeComponent();
		}

		private void frmBaoCaoLuong_Load(object sender, EventArgs e)
		{
			DataSet dataSet = new LuongDataSet();
			DataTable dataTable = new DataTable();
			dataTable = BUS.LuongBUS.XemLuong(null);
			dataSet.Tables[0].Merge(dataTable);
			rpBangLuong rpLuong = new rpBangLuong();
			rpLuong.SetDataSource(dataSet.Tables[0]);
			crBaoCaoLuong.ReportSource = rpLuong;
		}
	}
}
