using DTO;
using Karaoke.GuiMonAn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Karaoke.PhongKaoraoke
{
    public partial class frmLichSuPhong : Form
    {

        private const int pageSize = 10;
        private int pageNumber;
        private int totalPage;
        private string soHoaDon="";
        public frmLichSuPhong()
        {
            InitializeComponent();
            khoiTao();
        }

        private void khoiTao()
        {
            pageNumber = 1;
            txtPageNumber.Text = "1";
            totalPage = BUS.PhongBUS.DemLichSuPhong();
            totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();

            dGvDanhSach.DataSource = BUS.PhongBUS.XemLichSuPhong(pageNumber, pageSize);

            dGvDanhSach.Columns[0].HeaderText = "Số hóa đơn";
            dGvDanhSach.Columns[1].HeaderText = "Tên khách hàng";
            dGvDanhSach.Columns[3].HeaderText = "Phòng";
            dGvDanhSach.Columns[5].HeaderText = "Giá";
            dGvDanhSach.Columns[4].HeaderText = "Loại phòng";
            dGvDanhSach.Columns[2].HeaderText = "Số điện thoại";
            dGvDanhSach.Columns[6].HeaderText = "Giờ vào";
            dGvDanhSach.Columns[7].HeaderText = "Giờ ra";
        }
        private void dGvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dGvDanhSach.CurrentCell != null)
            {
                int index = dGvDanhSach.CurrentCell.RowIndex;
                txtTenKhachHang.Text = dGvDanhSach[1, index].Value.ToString();
                txtTenPhong.Text = dGvDanhSach[3, index].Value.ToString();
                txtSDT.Text = dGvDanhSach[2, index].Value.ToString();
                txtGia.Text = dGvDanhSach[5, index].Value.ToString();
                txtLoaiPhong.Text = dGvDanhSach[4, index].Value.ToString();
                soHoaDon = dGvDanhSach[0, index].Value.ToString();
            }
        }
        private void loadDanhSach()
        {
            dGvDanhSach.DataSource = BUS.PhongBUS.XemLichSuPhong(pageNumber, pageSize);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (pageNumber + 1 > totalPage)
            {
                pageNumber = 1;
            }
            else
            {
                ++pageNumber;
            }
            txtPageNumber.Text = pageNumber.ToString();

            loadDanhSach();
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (pageNumber - 1 == 0)
            {
                pageNumber = 1;
            }
            else
            {
                --pageNumber;
            }
            txtPageNumber.Text = pageNumber.ToString();
            loadDanhSach();
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();
            loadDanhSach();

        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            pageNumber = totalPage;
            txtPageNumber.Text = pageNumber.ToString();
            loadDanhSach();
        }

      

        private void txtPageNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToUInt32(txtPageNumber.Text) <= totalPage)
                {
                    pageNumber = (int)Convert.ToUInt32(txtPageNumber.Text);

                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {

                txtPageNumber.Text = pageNumber.ToString();
            }
            loadDanhSach();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (soHoaDon != "")
            {
                frmGoiMon goiMon = new frmGoiMon(soHoaDon,null);
                goiMon.ShowDialog();
            }
        }
    }
}
