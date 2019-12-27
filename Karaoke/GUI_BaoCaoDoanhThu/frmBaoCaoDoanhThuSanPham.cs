﻿using CrystalDecisions.Shared;
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

namespace Karaoke.GUI_BaoCaoDoanhThu
{
    public partial class frmBaoCaoDoanhThuSanPham : Form
    {
        DataSet dataSet = new DoanhThuTheoSanPham();
        DataTable dataTable = new DataTable();
        public frmBaoCaoDoanhThuSanPham()
        {
            InitializeComponent();
        }

        private void frmBaoCaoDoanhThuSanPham_Load(object sender, EventArgs e)
        {
            DataTable data = BUS.DoanhThuBUS.DoanhThuTheoSanPham();
            loadRepport(data);

        }
        public void loadRepport(DataTable dataTable)
        {

            dataSet.Tables[0].Merge(dataTable);


            rptDoanhThuSanPham rpDoanhThuSanPham = new rptDoanhThuSanPham();

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



            rpDoanhThuSanPham.SetDataSource(dataSet);
            rpDoanhThuSanPham.Refresh();
            crBaoCaoDoanhThu.ReportSource = rpDoanhThuSanPham;
            // dataSet.Tables[0].Reset();
        }
    }
}