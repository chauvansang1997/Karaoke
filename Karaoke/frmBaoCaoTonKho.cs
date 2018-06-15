using CrystalDecisions.CrystalReports.Engine;
using Karaoke.DataSetContainer;
using Karaoke.report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karaoke
{
    public partial class frmBaoCaoTonKho : Form
    {
        ReportDocument oRpt;
        string reportFile;
        public frmBaoCaoTonKho()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataSet dataSet = new TonKhoDataSet();
            DataTable data = BUS.BaoCaoBUS.XemTonKho(dTPNgayBayDau.Value, dtpNgayKetThuc.Value);
            //tao khung
            dataSet.Tables[0].Merge(data);

            //lấy datable ,list
            rptTonKhoTheoNgay tonKhoTheoNgay = new rptTonKhoTheoNgay();
            tonKhoTheoNgay.SetDataSource(dataSet);
            //phieuNhapHang.DataDefinition.FormulaFields["NhaCungCap"].Text = nhaCungCap.Ten;
            //phieuNhapHang.DataDefinition.FormulaFields["DiaChi"].Text = nhaCungCap.DiaChi;
            //phieuNhapHang.DataDefinition.FormulaFields["SoDienThoai"].Text = nhaCungCap.SoDienThoai;
            //phieuNhapHang.DataDefinition.FormulaFields["NguoiDat"].Text = phieuNhap.SoPhieu;
            //phieuNhapHang.DataDefinition.FormulaFields["NgayDat"].Text = phieuNhap.NgayDat;
            crystalReportViewer1.ReportSource = tonKhoTheoNgay;

        }

        private void frmBaoCaoTonKho_Load(object sender, EventArgs e)
        {
            dTPNgayBayDau.Format = DateTimePickerFormat.Custom;
            dTPNgayBayDau.CustomFormat = "dd/MM/yyyy  hh:mm:ss";
            dtpNgayKetThuc.Format = DateTimePickerFormat.Custom;
            dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy  hh:mm:ss";

        }
    }
}
