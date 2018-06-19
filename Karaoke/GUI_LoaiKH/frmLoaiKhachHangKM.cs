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
            List<int> listLoaiKhachHang = new List<int>();
            for (int i = 0; i < bindingSource.Count; i++)
            {
                LoaiKhachHang loaiKhachHang = (LoaiKhachHang)bindingSource[i];
                listLoaiKhachHang.Add(loaiKhachHang.MaLoaiKH);
            }
            if (maKhuyenMai !=-1)
            {
                cmbLoaiKH.DataSource = BUS.KhuyenMaiBUS.XemChiTiet(maKhuyenMai, listLoaiKhachHang);
            }
            else
            {
                if (bindingSource.Count > 0)
                {
                    cmbLoaiKH.DataSource = BUS.LoaiKhachHangBUS.XemLoaiKhachHang(listLoaiKhachHang);
                    cmbLoaiKH.DisplayMember = "TENLOAIKH";
                }
                else
                {
                    cmbLoaiKH.DataSource = BUS.LoaiKhachHangBUS.LoadLoaiKH();
                    cmbLoaiKH.DisplayMember = "TENLOAIKH";
                }
       
            }
            cmbLoaiKH.DisplayMember = "TENLOAIKH";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cmbLoaiKH.SelectedValue != null )
            {
                DataRow row = ((DataRowView)cmbLoaiKH.SelectedValue).Row;
                bindingSource.Add(new LoaiKhachHang()
                {
                    MaLoaiKH =(int)row["MALOAIKH"],
                    TenLoaiKH = row["TENLOAIKH"].ToString(),
                    MucKM = float.Parse(txtMucKM.Text),
                });
                this.Close();
            }
           
        }
    }
}
