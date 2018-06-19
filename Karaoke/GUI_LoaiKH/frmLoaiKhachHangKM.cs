using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Karaoke.GUI_LoaiKH
{
    public partial class frmLoaiKhachHangKM : Form
    {
        private List<string> listLoaiKhachHang;
        private BindingSource bindingSource;
        private int maKhuyenMai;
        public frmLoaiKhachHangKM(BindingSource bindingSource,int maKhuyenMai)
        {
            this.bindingSource = bindingSource;
            this.maKhuyenMai = maKhuyenMai;
            InitializeComponent();
            khoiTao();
        }

        private void khoiTao()
        {
            if(bindingSource.Count> 0)
            {
                List<int> listLoaiKhachHang = ((List<LoaiKhachHang>)bindingSource.DataSource).Select(l => l.MaLoaiKH).ToList();

                cmbLoaiKH.DataSource = BUS.KhuyenMaiBUS.XemChiTiet(maKhuyenMai, listLoaiKhachHang);
            }
            else
            {
                cmbLoaiKH.DataSource = BUS.KhuyenMaiBUS.XemChiTiet(maKhuyenMai, null);
            }
            cmbLoaiKH.DisplayMember = "TENLOAIKH";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cmbLoaiKH.SelectedValue != null )
            {
                DataRow row = (DataRow)cmbLoaiKH.SelectedValue;
                bindingSource.Add(new LoaiKhachHang()
                {
                    MaLoaiKH =(int)row["MALOAIKH"],
                    TenLoaiKH = row["TENLOAIKH"].ToString(),
                    MucKM = (float)row["MUCKM"],
                });
                this.Close();
            }
           
        }
    }
}
