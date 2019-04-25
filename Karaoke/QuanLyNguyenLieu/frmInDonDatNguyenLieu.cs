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
        PhieuNhapHang phieuNhap;
        DTO.NhaCungCap nhaCungCap;
        public frmInDonDatNguyenLieu(DTO.NhaCungCap nhaCungCap, PhieuNhapHang phieuNhap)
        {
            this.phieuNhap = phieuNhap;
            this.nhaCungCap = nhaCungCap;

            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataSet dataSet = new PhieuDatHangDataSet();
            DataTable data = BUS.NguyenLieuBUS.XemChiTietPhieuNhapHang(phieuNhap.SoPhieu);
            //tao khung
            dataSet.Tables[0].Merge(data);
            if (phieuNhap.NgayGiao == "" || phieuNhap.NgayGiao == null)
            {
                //lấy datable ,list
                rptDonDatHang phieuNhapHang = new rptDonDatHang();
                phieuNhapHang.SetDataSource(dataSet);
                phieuNhapHang.DataDefinition.FormulaFields["NhaCungCap"].Text = "'" + nhaCungCap.Ten + "'";
                phieuNhapHang.DataDefinition.FormulaFields["DiaChi"].Text = "'" + nhaCungCap.DiaChi + "'";
                phieuNhapHang.DataDefinition.FormulaFields["SoDienThoai"].Text = "'" + nhaCungCap.SDT + "'";
                phieuNhapHang.DataDefinition.FormulaFields["NguoiDat"].Text = "'" + phieuNhap.TenNhanVien + "'";
                phieuNhapHang.DataDefinition.FormulaFields["NgayDat"].Text = "'" + phieuNhap.NgayDat + "'";
                crystalReportViewer1.ReportSource = phieuNhapHang;
            }
            else
            {
                //lấy datable ,list
                rptPhieuNhapHang phieuNhapHang = new rptPhieuNhapHang();
                phieuNhapHang.SetDataSource(dataSet);
                phieuNhapHang.DataDefinition.FormulaFields["NguoiGiaoHang"].Text = "'" + phieuNhap.NguoiGiao + "'";
                phieuNhapHang.DataDefinition.FormulaFields["NgayGiaoHang"].Text = "'" + phieuNhap.NgayGiao + "'";

                crystalReportViewer1.ReportSource = phieuNhapHang;
            }
        }
    }
}
