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

namespace Karaoke.QuanLyNguyenLieu
{
    public partial class frmInDonDatNguyenLieu : Form
    {
        string soPhieuDat;
        string nguoiDat;
        string ngayDat;
        NhaCungCap nhaCungCap;
        public frmInDonDatNguyenLieu(NhaCungCap nhaCungCap,string soPhieuDat,string nguoiDat,string ngayDat)
        {
            this.soPhieuDat = soPhieuDat;
            this.nhaCungCap = nhaCungCap;
            this.nguoiDat = nguoiDat;
            this.ngayDat = ngayDat;
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataSet dataSet = new PhieuDatHangDataSet();
            DataTable data = BUS.NguyenLieuBUS.XemChiTietPhieuNhapHang(soPhieuDat);
            //tao khung
            dataSet.Tables[0].Merge(data);

            //lấy datable ,list
            rptPhieuNhapHang phieuNhapHang = new rptPhieuNhapHang();
            phieuNhapHang.SetDataSource(dataSet);
            phieuNhapHang.DataDefinition.FormulaFields["NhaCungCap"].Text = nhaCungCap.Ten;
            phieuNhapHang.DataDefinition.FormulaFields["DiaChi"].Text = nhaCungCap.DiaChi;
            phieuNhapHang.DataDefinition.FormulaFields["SoDienThoai"].Text = nhaCungCap.SoDienThoai;
            phieuNhapHang.DataDefinition.FormulaFields["NguoiDat"].Text = nguoiDat;
            phieuNhapHang.DataDefinition.FormulaFields["NgayDat"].Text = ngayDat;
            crystalReportViewer1.ReportSource = phieuNhapHang;
        }
    }
}
