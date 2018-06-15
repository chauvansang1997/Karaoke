using Karaoke.DataSetContainer;
using Karaoke.report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Karaoke.GuiMonAn
{
    public partial class frmReportGoiMon : Form
    {
      //  private DataTable data;
        private string soHoaDon;

        private string giamGia;

        private string ngayBatDau;

        private string ngayKetThuc;

        private string thoiGian;
        //private string soHoaDon;
        public frmReportGoiMon(string soHoaDon,string giamGia="0")
        {
            this.soHoaDon = soHoaDon;
            this.giamGia = giamGia;
            InitializeComponent();
        }
        public frmReportGoiMon(string soHoaDon, string ngayBatDau, string ngayKetThuc, string thoiGian,string phong,string giamGia = "0")
        {
            this.soHoaDon = soHoaDon;
            this.giamGia = giamGia;
            InitializeComponent();
        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataSet dataSet = new HoaDonDataSet();

            DataTable data = BUS.HoaDonBUS.XemHoaDonBaoCao(soHoaDon);
            //tao khung
            dataSet.Tables[0].Merge(data);

            //lấy datable ,list
            rptHoaDon hoaDon = new rptHoaDon();
            hoaDon.SetDataSource(dataSet);
            hoaDon.DataDefinition.FormulaFields["GiamGia"].Text = "15000";
            crystalReportViewer1.ReportSource = hoaDon;
            
        }
    }
}
