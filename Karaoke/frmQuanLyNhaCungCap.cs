using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Karaoke
{
    public partial class frmQuanLyNhaCungCap : Form
    {
        private bool bSua;
        private bool bThem;
        private const int pageSize = 10;
        private int pageNumber;
        private int totalPage;
        private string ma;
        public frmQuanLyNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmQuanLyNhaCungCap_Load(object sender, EventArgs e)
        {
            bSua = false;
            bThem = false;
            pageNumber = 1;
            txtPageNumber.Text = "1";
             totalPage = BUS.NhaCungCapBUS.DemNhaCungCap("");
            totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();
            dGVDanhSach.DataSource = BUS.NhaCungCapBUS.XemNhaCungCap("",  pageNumber, pageSize);
            enableControls(false);
            AddGridTableStyle();
        }
        private void resetDanhSach()
        {
            txtPageNumber.Text = "1";
            totalPage = BUS.NhaCungCapBUS.DemNhaCungCap("");
            totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();
            dGVDanhSach.DataSource = BUS.NhaCungCapBUS.XemNhaCungCap("", pageNumber, pageSize);

            bSua = false;
            bThem = false;
            AddGridTableStyle();
        }
        private void loadDanhSach()
        {
            dGVDanhSach.DataSource = BUS.NhaCungCapBUS.XemNhaCungCap(txtNhaCungCapTK.Text, pageNumber, pageSize);
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
            this.dGVDanhSach.Columns["MANCC"].Visible = false;
            this.dGVDanhSach.Columns["LOAIHANGCC"].Visible = false;
            this.dGVDanhSach.Columns["TENNCC"].HeaderText = "Nhà cung cấp";
            this.dGVDanhSach.Columns["SDT"].HeaderText = "Số điện thoại";
            this.dGVDanhSach.Columns["DIACHI"].HeaderText = "Địa chỉ";
         

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bSua = true;
            enableControls(true);
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
                txtNhaCungCap.Text = dGVDanhSach[1, index].Value.ToString();
                txtDiaChi.Text = dGVDanhSach[3, index].Value.ToString();
                txtSoDienThoai.Text = dGVDanhSach[2, index].Value.ToString();
                //  cmbNhaCC.SelectedValue = dGVDanhSach[6, index].Value.ToString();

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
            txtNhaCungCap.Enabled = enable;
            btnLuu.Enabled = enable;
            btnHuy.Enabled = enable;
            txtDiaChi.Enabled = enable;
            txtSoDienThoai.Enabled = enable;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            enableControls(true);
            bThem = true;
            txtSoDienThoai.Text = "";
            txtDiaChi.Text = "";
            txtNhaCungCap.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (bThem)
            {
                if (BUS.NhaCungCapBUS.ThemNCC(new DTO.NhaCungCap()
                {
                    Ten = txtNhaCungCap.Text,
                    DiaChi=txtDiaChi.Text,
                    SDT=txtSoDienThoai.Text

                }))
                {
                    MessageBox.Show("Thêm nhà cung cấp thành công");
                }
                bThem = false;
                enableControls(false);
                resetDanhSach();
            }
            else if (bSua)
            {
                if (BUS.NhaCungCapBUS.CapNhatNCC(new DTO.NhaCungCap()
                {
                    MaNCC = ma,
                    Ten = txtNhaCungCap.Text,
                    DiaChi = txtDiaChi.Text,
                    SDT = txtSoDienThoai.Text

                }))
                {
                    MessageBox.Show("Sửa nhà cung cấp thành công");
                }
                bSua = false;
                enableControls(false);
                resetDanhSach();
            }
        }

     

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (BUS.NhaCungCapBUS.XoaNhaCungCap(ma))
            {
                MessageBox.Show("Xóa nhà cung cấp thành công");
                resetDanhSach();
            }
            else
            {
                MessageBox.Show("Không thể xóa nhà cung cấp");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            txtPageNumber.Text = "1";
            totalPage = BUS.NhaCungCapBUS.DemNhaCungCap(txtNhaCungCapTK.Text);
            totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();
            loadDanhSach();
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
