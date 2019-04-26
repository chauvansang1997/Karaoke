using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Karaoke.QuanLySanPham
{
    public partial class frmSamPham : Form
    {
        private bool bSua;
        private bool bThem;
        private const int pageSize = 10;
        private int pageNumber;
        private int totalPage;
        private string ma;
        private string tenHinhAnh;
        public frmSamPham()
        {
            InitializeComponent();
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
            this.dGVDanhSach.Columns["MASP"].Visible = false;
            this.dGVDanhSach.Columns["LOAISP"].Visible = false;
            this.dGVDanhSach.Columns["ANHMINHHOA"].Visible = false;
            this.dGVDanhSach.Columns["MA"].Visible = false;
            this.dGVDanhSach.Columns["MANCC"].Visible = false;

            this.dGVDanhSach.Columns["TENSP"].HeaderText = "Tên";
            this.dGVDanhSach.Columns["TENLOAI"].HeaderText = "Loại";
            this.dGVDanhSach.Columns["TENNCC"].HeaderText = "Nhà cung cấp";
            this.dGVDanhSach.Columns["DVT"].HeaderText = "Đơn vị tính";
            this.dGVDanhSach.Columns["DONGIA"].HeaderText = "Đơn giá bán";
            this.dGVDanhSach.Columns["DONGIANHAP"].HeaderText = "Đơn giá nhập";
            this.dGVDanhSach.Columns["SLTOITHIEU"].HeaderText = "Tồn tối thiểu";
 
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bSua = true;
            enableControls(true);
            enableButton(false);
        }
        private void frmMonAn_Load(object sender, EventArgs e)
        {
            enableControls(false);
            cmbNhaCC.DataSource = BUS.NhaCungCapBUS.XemNhaCungCap();
            cmbNhaCC.DisplayMember = "Ten";
            cmbNhaCCTK.DataSource = BUS.NhaCungCapBUS.XemNhaCungCap();
            cmbNhaCCTK.DisplayMember = "Ten";


            cmbLoai.DataSource = BUS.SanPhamBUS.XemLoai();
            cmbLoai.DisplayMember = "Ten";
            cmbLoaiTK.DataSource = BUS.SanPhamBUS.XemLoai();
            cmbLoaiTK.DisplayMember = "Ten";
            bSua = false;
            bThem = false;
            pageNumber = 1;

            txtPageNumber.Text = "1";
            totalPage = BUS.SanPhamBUS.DemSanPham("", 0, "");
            totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();
            dGVDanhSach.DataSource = BUS.SanPhamBUS.XemSanPhamTable("", 0, "", pageNumber, pageSize);
            AddGridTableStyle();
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if(cmbNhaCCTK.SelectedValue != null)
            {
                DTO.NhaCungCap nhaCungCap = (DTO.NhaCungCap)cmbNhaCCTK.SelectedValue;
                DTO.LoaiHangHoa loaiHangHoa= (DTO.LoaiHangHoa)cmbLoaiTK.SelectedValue;
                pageNumber = 1;
                txtPageNumber.Text = "1";
                totalPage = BUS.SanPhamBUS.DemSanPham(nhaCungCap.MaNCC, int.Parse(loaiHangHoa.Ma),txtTenTK.Text);
                totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
                txtTotalPage.Text = totalPage.ToString();
                dGVDanhSach.DataSource = BUS.SanPhamBUS.XemSanPhamTable(nhaCungCap.MaNCC, int.Parse(loaiHangHoa.Ma), 
                    txtTenTK.Text, pageNumber, pageSize);

            }
            else
            {
                pageNumber = 1;
                txtPageNumber.Text = "1";
                totalPage = BUS.SanPhamBUS.DemSanPham("", 0,  txtTenTK.Text);
                totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
                txtTotalPage.Text = totalPage.ToString();
                dGVDanhSach.DataSource = BUS.SanPhamBUS.XemSanPhamTable("", 0, txtTenTK.Text, pageNumber, pageSize);
                AddGridTableStyle();
            }
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

        private void loadDanhSach()
        {
            if (cmbNhaCC.SelectedValue != null)
            {
                dGVDanhSach.DataSource = BUS.SanPhamBUS.XemSanPhamTable(((DTO.NhaCungCap)cmbNhaCC.SelectedValue).MaNCC, 0, txtTenTK.Text, pageNumber, pageSize);

            }
            else
            {
                dGVDanhSach.DataSource = BUS.SanPhamBUS.XemSanPhamTable("", 0, txtTenTK.Text, pageNumber, pageSize);

            }

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
                txtTenSP.Text = dGVDanhSach[1, index].Value.ToString();
                txtDVT.Text = dGVDanhSach[3, index].Value.ToString();
                
                txtGiaBan.Text = dGVDanhSach[4, index].Value.ToString();
                txtGiaNhap.Text = dGVDanhSach[4, index].Value.ToString();
                for (int i = 0; i < cmbLoai.Items.Count; i++)
                {
                    if (((DTO.LoaiHangHoa)cmbLoai.Items[i]).Ma == dGVDanhSach[2, index].Value.ToString())
                    {
                        cmbLoai.SelectedIndex = i;
                    }
                }
                for (int i = 0; i < cmbNhaCC.Items.Count; i++)
                {
                    if (((DTO.NhaCungCap)cmbNhaCC.Items[i]).MaNCC == dGVDanhSach[8, index].Value.ToString())
                    {
                        cmbNhaCC.SelectedIndex = i;
                    }
                }
                tenHinhAnh = dGVDanhSach[5, index].Value.ToString();
                string path = Directory.GetCurrentDirectory();
                path = Path.GetFullPath(Path.Combine(path, @"..\..\")) + @"\Image\" + @"\"+ tenHinhAnh;
                Image image = null;
                try
                {
                    image = Image.FromFile(path);
                    pBAnhMinhHoa.Image = image;
                    pBAnhMinhHoa.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    pBAnhMinhHoa.Image = null;
                    Utility.Log(ex);
                }
                txtTonToiThieu.Text = dGVDanhSach[11, index].Value.ToString();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            enableControls(true);
            bThem = true;
            enableButton(false);
            

            txtTonToiThieu.Text = "";
            txtGiaBan.Text = "";
            txtGiaNhap.Text = "";
            txtDVT.Text = "";
            txtTenSP.Text = "";
            tenHinhAnh = "";
            pBAnhMinhHoa.Image = null;
        }

        private void btnLayAnh_Click(object sender, EventArgs e)
        {
            oFDLayAnh = new OpenFileDialog();
            // image filters  
            oFDLayAnh.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (oFDLayAnh.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pBAnhMinhHoa.Image = new Bitmap(oFDLayAnh.FileName);
                pBAnhMinhHoa.SizeMode = PictureBoxSizeMode.StretchImage;
                // image file path  
                txtAnhMinhHoa.Text = oFDLayAnh.FileName;
                string[] temp = oFDLayAnh.FileName.Split('\\');
                tenHinhAnh = temp[temp.Length - 1];

                string path = Directory.GetCurrentDirectory();
                try
                {
                    System.IO.File.Copy(oFDLayAnh.FileName, Path.GetFullPath(Path.Combine(path, @"..\..\")) + @"\Image\" + @"\" + tenHinhAnh);
                }
                catch (Exception)
                {

                   // MessageBox.Show("File đã tồn tại");
                }
               
            }
        }
        private void enableButton(bool enable)
        {
            btnThem.Enabled = enable;
            btnXoa.Enabled = enable;

            btnSua.Enabled = enable;

        }
        private void enableControls(bool enable)
        {
            
            txtGiaBan.Enabled = enable;
            txtGiaNhap.Enabled = enable;
            txtDVT.Enabled = enable;
            txtTenSP.Enabled = enable;
            cmbNhaCC.Enabled = enable;
            cmbLoai.Enabled = enable;
            txtTonToiThieu.Enabled = enable;
            btnLayAnh.Enabled = enable;
            btnLuu.Enabled = enable;
            btnHuy.Enabled = enable;
        }
        private void txtGia_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (bThem)
            {
                if (BUS.SanPhamBUS.ThemSanPham(new DTO.SanPham()
                {
                    Ten = txtTenSP.Text,
                    Gia = uint.Parse(txtGiaBan.Text),
                    DonGiaNhap=int.Parse(txtGiaNhap.Text),
                    Loai=((DTO.LoaiHangHoa)cmbLoai.SelectedValue).Ma,
                    TenHinhAnh=tenHinhAnh,
                    DonViTinh = txtDVT.Text,
                    NhaCungCap = ((DTO.NhaCungCap)cmbNhaCC.SelectedValue).MaNCC,
                    SoLuongToiThieu = int.Parse(txtTonToiThieu.Text),

                }))
                {
                    MessageBox.Show("Thêm sản phẩm thành công");
                    bSua = false;
                    enableControls(false);
                    enableButton(true);
                    resetDanhSach();
                    bThem = false;
                }
           
            }
            else if (bSua)
            {
                if (BUS.SanPhamBUS.CapNhatSanPham(new DTO.SanPham()
                {
                    Ma=ma,
                    Ten = txtTenSP.Text,
                    Gia = uint.Parse(txtGiaBan.Text),
                    DonGiaNhap = int.Parse(txtGiaNhap.Text),
                    Loai = ((DTO.LoaiHangHoa)cmbLoai.SelectedValue).Ma,
                    TenHinhAnh = tenHinhAnh,
                    DonViTinh = txtDVT.Text,
                    NhaCungCap = ((DTO.NhaCungCap)cmbNhaCC.SelectedValue).MaNCC,
                    SoLuongToiThieu = int.Parse(txtTonToiThieu.Text),
                }))
                {
                    MessageBox.Show("Sửa sản phẩm thành công");
                    bSua = false;
                    enableControls(false);
                    enableButton(true);
                    resetDanhSach();
                    bThem = false;
                }
             

            }
          
        }

        private void resetDanhSach()
        {
            pageNumber = 1;
            txtPageNumber.Text = "1";
            totalPage = BUS.SanPhamBUS.DemSanPham("", 0, "");
            totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();
            dGVDanhSach.DataSource = BUS.SanPhamBUS.XemSanPhamTable("", 0, "", pageNumber, pageSize);
            AddGridTableStyle();

            bSua = false;
            bThem = false;
            AddGridTableStyle();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (BUS.NguyenLieuBUS.XoaNguyenLieu(ma))
            {
                MessageBox.Show("Xóa sản phẩm thành công");
                resetDanhSach();
            }
            else
            {
                MessageBox.Show("Nguyên liệu nằm trong món ăn");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 
        private void enableButton1(bool enable)
        {
            btnHuy.Enabled = enable;
            btnLuu.Enabled = enable;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            enableControls(false);
            enableButton(true);
       
            bThem = false;
            bSua = false;
        }

       
    }
}
