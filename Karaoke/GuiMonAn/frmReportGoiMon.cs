using DTO;
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

        private string gioVao;

        private string gioRa;

        //private string soHoaDon;
        public frmReportGoiMon(string soHoaDon,string giamGia="0")
        {
            this.soHoaDon = soHoaDon;
            this.giamGia = giamGia;
            InitializeComponent();
        }
        public frmReportGoiMon(string soHoaDon, string gioVao, string gioRa,string phong,string giamGia = "0")
        {
            this.soHoaDon = soHoaDon;
            this.gioVao = gioVao;
            this.gioRa = gioRa;
            this.giamGia = giamGia;
            InitializeComponent();
        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataSet dataSet = new HoaDonDataSet();

            DataTable data = BUS.HoaDonBUS.XemHoaDonBaoCao(soHoaDon);
            //tao khung
            dataSet.Tables[0].Merge(data);

            //lấy thông tin 
            HoaDon hoaDon = BUS.HoaDonBUS.LayThongTinHoaDon(soHoaDon);
            //lấy datable ,list
            rptHoaDon rpHoaDon = new rptHoaDon();
            rpHoaDon.SetDataSource(dataSet);
            rpHoaDon.DataDefinition.FormulaFields["TenKhachHang"].Text = "'" + hoaDon.TenKhachHang + "'";
            rpHoaDon.DataDefinition.FormulaFields["SoDienThoai"].Text = "'" + hoaDon.SoDienThoai + "'";
            rpHoaDon.DataDefinition.FormulaFields["GiamGia"].Text = "'" + hoaDon.GiamGia + "'";
            rpHoaDon.DataDefinition.FormulaFields["TienGio"].Text = "'" + hoaDon.TienGio + "'";
            rpHoaDon.DataDefinition.FormulaFields["GioBatDau"].Text = "'" + hoaDon.GioVao + "'";
            rpHoaDon.DataDefinition.FormulaFields["GioKetThuc"].Text = "'" + hoaDon.GioRa + "'";
            rpHoaDon.DataDefinition.FormulaFields["Phong"].Text = "'" + hoaDon.MaPhong + "'";
            crystalReportViewer1.ReportSource = rpHoaDon;
            
        }
    }
}
