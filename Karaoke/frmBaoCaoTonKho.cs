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

            crystalReportViewer1.ReportSource = tonKhoTheoNgay;

        }

        private void frmBaoCaoTonKho_Load(object sender, EventArgs e)
        {
            dTPNgayBayDau.Format = DateTimePickerFormat.Custom;
            dTPNgayBayDau.CustomFormat = "dd/MM/yyyy  hh:mm:ss";
            dtpNgayKetThuc.Format = DateTimePickerFormat.Custom;
            dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy  hh:mm:ss";

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new TonKhoDataSet();
            DataTable data = BUS.BaoCaoBUS.XemTonKho(dTPNgayBayDau.Value, dtpNgayKetThuc.Value);
            //tao khung
            dataSet.Tables[0].Merge(data);

            //lấy datable ,list
            //rptTonKhoTheoNgay tonKhoTheoNgay = new rptTonKhoTheoNgay();
           // tonKhoTheoNgay.SetDataSource(dataSet);

            //crystalReportViewer1.ReportSource = tonKhoTheoNgay;
        }
    }
}
