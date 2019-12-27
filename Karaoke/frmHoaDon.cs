using CrystalDecisions.Shared;
using DTO;
using Karaoke.DataSetContainer;
using Karaoke.report;
using System;
using System.Data;
using System.Windows.Forms;

namespace Karaoke
{
    public partial class frmHoaDon : Form
	{
		DataSet dataSet = new HoaDonThanhToan();
		DataTable dataTable = new DataTable();
        ThongTinDatPhong thongTinDatPhong;
		public frmHoaDon(ThongTinDatPhong thongTinDatPhong)
		{
            this.thongTinDatPhong = thongTinDatPhong;

            InitializeComponent();
			bindingCombox();
		}

		private void bindingCombox()
		{
			//cbDanhSachNhanVien.DisplayMember = "tenNV";
			//cbDanhSachNhanVien.ValueMember = "maNV"; //Field in the datatable which you want to be the value of the combobox 
			//cbDanhSachNhanVien.DataSource = BUS.LuongBUS.LoadNhanVienPhanCong();

			//cbThangLuong.DisplayMember = "thangLuong";
			//cbThangLuong.ValueMember = "thangLuong"; //Field in the datatable which you want to be the value of the combobox 
			//cbThangLuong.DataSource = BUS.LuongBUS.LoadThangLuongDesc();
		}

		private void frmBaoCaoLuong_Load(object sender, EventArgs e)
		{

            dataTable = BUS.HoaDonBUS.HoaDonDataSet(thongTinDatPhong);
            loadRepport(dataTable);

		}

		public void loadRepport(DataTable dataTable)
		{

            dataSet.Tables[0].Merge(dataTable);
          

            rptHoaDonThanhToan rpLuong = new rptHoaDonThanhToan();

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

			crBaoCaoLuong.ParameterFieldInfo = pField;

			

			rpLuong.SetDataSource(dataSet);
			rpLuong.Refresh();
			crBaoCaoLuong.ReportSource = rpLuong;
            // dataSet.Tables[0].Reset();
		}

		private void btnThucThiBCCTL_Click(object sender, EventArgs e)
		{
			//dataTable = BUS.LuongBUS.XemLuong(cbDanhSachNhanVien.SelectedValue.ToString(), cbThangLuong.SelectedValue.ToString());
			//loadRepport(dataTable);
		}
	}
}
