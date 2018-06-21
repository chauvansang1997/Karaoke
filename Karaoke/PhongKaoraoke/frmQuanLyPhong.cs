using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karaoke.PhongKaoraoke
{
    public partial class frmQuanLyPhong : Form
    {
        private bool bSua;
        private bool bThem;
        private const int pageSize = 10;
        private int pageNumber;
        private int totalPage;
        private string ma;
        public frmQuanLyPhong()
        {
            InitializeComponent();
        }

        private void frmNguyenLieu_Load(object sender, EventArgs e)
        {
            bSua = false;
            bThem = false;
            pageNumber = 1;

            txtPageNumber.Text = "1";
            totalPage = BUS.PhongBUS.DemPhongQuanLy("",-1);
            totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();
            dGVDanhSach.DataSource = BUS.PhongBUS.XemPhongQuanLy("", -1, pageNumber, pageSize);
            enableControls(false);
            AddGridTableStyle();
        }
        private void loadDanhSach()
        {
            DataRow row = ((DataRowView)cmbNhaCC.SelectedValue).Row;
            dGVDanhSach.DataSource = BUS.PhongBUS.XemPhongQuanLy(txtTenNguyenLieu.Text,(int)row["MALOAIPHONG"], pageNumber, pageSize);
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            txtPageNumber.Text = "1";
            if (cmbNhaCCTK.SelectedValue == null)
            {
                totalPage = BUS.PhongBUS.DemPhongQuanLy("", -1);
                totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
                dGVDanhSach.DataSource = BUS.PhongBUS.XemPhongQuanLy("", -1, pageNumber, pageSize);
            }
            else
            {
                DataRow row = ((DataRowView)cmbNhaCC.SelectedValue).Row;
                totalPage = BUS.PhongBUS.DemPhongQuanLy(txtTenNguyenLieu.Text, (int)row["MALOAIPHONG"]);
                totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
              
                dGVDanhSach.DataSource = BUS.PhongBUS.XemPhongQuanLy(txtTenNguyenLieu.Text, (int)row["MALOAIPHONG"], pageNumber, pageSize);
            }

            txtTotalPage.Text = totalPage.ToString();
        }
        private void resetDanhSach()
        {
            bSua = false;
            bThem = false;
            pageNumber = 1;

            txtPageNumber.Text = "1";
            totalPage = BUS.PhongBUS.DemPhongQuanLy("", -1);
            totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();
            dGVDanhSach.DataSource = BUS.PhongBUS.XemPhongQuanLy("", -1, pageNumber, pageSize);
            enableControls(false);
            AddGridTableStyle();
        }
        private void AddGridTableStyle()
        {
            DataGridViewCellStyle cell = new DataGridViewCellStyle
            {
                BackColor = Color.Bisque,
                //  SelectionBackColor = Color.Teal,
                //   SelectionForeColor = Color.PaleGreen,
            };
            this.dGVDanhSach.BackColor = Color.GhostWhite;
            this.dGVDanhSach.ForeColor = Color.MidnightBlue;
            this.dGVDanhSach.BackgroundColor = Color.GhostWhite;
            this.dGVDanhSach.GridColor = Color.RoyalBlue;
            this.dGVDanhSach.AlternatingRowsDefaultCellStyle = cell;
            this.dGVDanhSach.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;

            this.dGVDanhSach.Columns["MALOAIPHONG"].Visible = false;
            this.dGVDanhSach.Columns["MAPHONG"].HeaderText = "Tên";
            this.dGVDanhSach.Columns["TENLOAIPHONG"].HeaderText = "Tên loại phòng";
            this.dGVDanhSach.Columns["GIA"].HeaderText = "Giá";

            cmbNhaCC.DataSource = BUS.PhongBUS.XemLoaiPhong();
            cmbNhaCC.DisplayMember = "TENLOAIPHONG";
            cmbNhaCCTK.DataSource = BUS.PhongBUS.XemLoaiPhong();
            cmbNhaCCTK.DisplayMember = "TENLOAIPHONG";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bSua = true;
            enableControls(true);
        }

        private void frmNguyenLieu_Load_1(object sender, EventArgs e)
        {

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


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnFind_MouseHover(object sender, EventArgs e)
        {
            this.btnFind.FlatAppearance.BorderSize = 2;
        }

        private void btnThem_MouseHover(object sender, EventArgs e)
        {
            this.btnThem.FlatAppearance.BorderSize = 2;
        }

        private void btnXoa_MouseHover(object sender, EventArgs e)
        {
            this.btnXoa.FlatAppearance.BorderSize = 2;
        }
        private void dGVDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bThem)
            {
                return;
            }
            if (bSua)
            {
                return;
            }
            if (dGVDanhSach.CurrentCell != null)
            {
                int index = dGVDanhSach.CurrentCell.RowIndex;
                txtTenNL.Text = dGVDanhSach[0, index].Value.ToString();
            
                //  cmbNhaCC.SelectedValue = dGVDanhSach[6, index].Value.ToString();
                for (int i = 0; i < cmbNhaCC.Items.Count; i++)
                {
                    DataRow row = ((DataRowView)cmbNhaCC.Items[i]).Row;
                    if (row["MALOAIPHONG"].ToString() == dGVDanhSach[1, index].Value.ToString())
                    {
                        cmbNhaCC.SelectedIndex = i;
                    }
                }
              
                ma = dGVDanhSach[0, index].Value.ToString();
            }

        }
        private void btnSua_MouseHover(object sender, EventArgs e)
        {
            this.btnSua.FlatAppearance.BorderSize = 2;
        }

        private void btnThoat_MouseHover(object sender, EventArgs e)
        {
            this.btnThoat.FlatAppearance.BorderSize = 2;
        }
        private void enableButton(bool enable)
        {
            btnThem.Enabled = enable;
            btnXoa.Enabled = enable;
            btnSua.Enabled = enable;
        }
        private void enableControls(bool enable)
        {
            //txtTenNL.Enabled = enable;
            cmbNhaCC.Enabled = enable;
            btnLuu.Enabled = enable;
            btnHuy.Enabled = enable;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            enableControls(true);
            bThem = true;
            //txtTenNL.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cmbNhaCC.SelectedValue != null)
            {
                DataRow row = ((DataRowView)cmbNhaCC.SelectedValue).Row;
                if (bThem)
                {

                    if (BUS.PhongBUS.ThemPhong(new DTO.Phong()
                    {
                        Ten = txtTenNL.Text,
                        TenLoai = row["MALOAIPHONG"].ToString()

                    }))
                    {
                        MessageBox.Show("Thêm phòng thành công");
                    }
                    bThem = false;
                    enableControls(false);
                    resetDanhSach();
                }
                else if (bSua)
                {
                    if (BUS.PhongBUS.CapNhatPhong(new DTO.Phong()
                    {
                        Ten = txtTenNL.Text,
                        TenLoai = row["MALOAIPHONG"].ToString()

                    }))
                    {
                        MessageBox.Show("Sửa phòng thành công");
                    }
                    bSua = false;
                    enableControls(false);
                    resetDanhSach();
                }
            }
        
        }

  

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (BUS.NguyenLieuBUS.XoaNguyenLieu(ma))
            {
                MessageBox.Show("Xóa phòng thành công");
                resetDanhSach();
            }
            else
            {
                MessageBox.Show("Không thể xóa phòng");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnHuy_Click(object sender, EventArgs e)
        {
            bThem = false;
            bSua = false;
            enableControls(false);
            enableButton(true);
        }
    }
    
}
