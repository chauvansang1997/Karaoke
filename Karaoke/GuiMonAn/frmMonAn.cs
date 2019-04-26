using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karaoke.GuiMonAn
{
    public partial class frmMonAn : Form
    {

        private bool bSua;
        private bool bThem;
        private const int pageSize = 10;
        private int pageNumber;
        private int totalPage;
        private string ma;
        private DataTable dtNguyenLieu;
        private uint donGia;
        private string tenHinhAnh = "";
        public BindingSource bindingSource = new BindingSource();
        private BindingSource bindingSourceMonAn = new BindingSource();
        public frmMonAn()
        {
            InitializeComponent();
            khoiTao();
        }
        private void AddGridTableStyle()
        {
            DataGridViewCellStyle cell = new DataGridViewCellStyle
            {
                BackColor = Color.Bisque,
                //  SelectionBackColor = Color.Teal,
                //   SelectionForeColor = Color.PaleGreen,
            };
            this.dGVMonAn.BackColor = Color.GhostWhite;
            this.dGVMonAn.ForeColor = Color.MidnightBlue;
            this.dGVMonAn.BackgroundColor = Color.GhostWhite;
            this.dGVMonAn.GridColor = Color.RoyalBlue;
            this.dGVMonAn.AlternatingRowsDefaultCellStyle = cell;
            this.dGVMonAn.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            //this.dGVNguyenLieu.ColumnHeadersDefaultCellStyle.ForeColor = Color.Lavender;

            dGVMonAn.EnableHeadersVisualStyles = false;



            this.dGVNguyenLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void khoiTao()
        {
            enableControls(false);

            cmbLoaiMon.DataSource = BUS.MonAnBUS.XemLoaiMon();
            cmbLoaiMon.DisplayMember = "Ten";

            cmbLoaiMonTK.DataSource = BUS.MonAnBUS.XemLoaiMon();
            cmbLoaiMonTK.DisplayMember = "Ten";
            dtNguyenLieu = new DataTable();
            dGVMonAn.DataSource = dtNguyenLieu;

            pageNumber = 1;

            txtPageNumber.Text = "1";
            totalPage = BUS.MonAnBUS.DemMonAn("", "");
            totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();
           
            bindingSourceMonAn.DataSource = BUS.MonAnBUS.XemMonAnDataSource("", 0, pageNumber, pageSize);

            dGVMonAn.DataSource = bindingSourceMonAn;
            AddGridTableStyle();
            dGVMonAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGVMonAn.Columns["Ten"].HeaderText = "Tên";

            dGVMonAn.Columns["Gia"].HeaderText = "Giá";

            dGVMonAn.Columns["TenLoaiHangHoa"].HeaderText = "Loại hàng hóa";


            dGVMonAn.Columns["Ma"].Visible = false;

            dGVMonAn.Columns["MaLoaiHangHoa"].Visible = false;
            dGVMonAn.Columns["AnhMinhHoa"].Visible = false;

            // dGVMonAn.Columns["LoaiHangHoa"].
            bindingSource.Add(new NguyenLieuMADataSource());
            dGVNguyenLieu.DataSource = bindingSource;


            bindingSource.RemoveAt(0);
            dGVNguyenLieu.Columns["Ten"].HeaderText = "Tên";

            dGVNguyenLieu.Columns["Gia"].HeaderText = "Giá";

            dGVNguyenLieu.Columns["Soluong"].HeaderText = "Số lượng";
            //  dGVNguyenLieu.Columns["Thanhtien"].HeaderText = "Thành tiền";
            dGVNguyenLieu.Columns["DonViTinh"].HeaderText = "Đơn vị tính";

            dGVNguyenLieu.Columns["Ma"].Visible = false;
            // dGVNguyenLieu.Columns["Loai"].Visible = false;

            //  dGVNguyenLieu.Columns["AnhMinhHoa"].Visible = false;
            //     dGVNguyenLieu.Columns["Thanhtien"].Visible = false;
            dGVNguyenLieu.Columns["Gia"].ReadOnly = true;
            dGVNguyenLieu.Columns["Ten"].ReadOnly = true;
            //  dGVNguyenLieu.Columns["Thanhtien"].ReadOnly = true;
            bSua = false;
            bThem = false;
         
           
           
        }
        private void resetDanhSach()
        {
            bSua = false;
            bThem = false;
            pageNumber = 1;

            txtPageNumber.Text = "1";
            totalPage = BUS.MonAnBUS.DemMonAn("", "");
            totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();
            bindingSourceMonAn.DataSource = BUS.MonAnBUS.XemMonAnDataSource("", 0, pageNumber, pageSize);
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (cmbLoaiMonTK.SelectedValue != null)
            {

                txtPageNumber.Text = "1";
                totalPage = BUS.MonAnBUS.DemMonAn(txtTenTK.Text, ((LoaiMon)cmbLoaiMonTK.SelectedValue).Ma);
                totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
                txtTotalPage.Text = totalPage.ToString();
                bindingSourceMonAn.DataSource = BUS.MonAnBUS.XemMonAnDataSource(txtTenTK.Text, int.Parse(((LoaiMon)cmbLoaiMonTK.SelectedValue).Ma),
                               pageNumber, pageSize);
            }
            else
            {

                txtPageNumber.Text = "1";
                totalPage = BUS.MonAnBUS.DemMonAn("", "");
                totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
                txtTotalPage.Text = totalPage.ToString();
                bindingSourceMonAn.DataSource = BUS.MonAnBUS.XemMonAnDataSource(txtTenTK.Text, 0,
               pageNumber, pageSize);
            }
        }
        private void enableButton(bool enable)
        {
            btnThemMonAn.Enabled = enable;
            btnXoaMonAn.Enabled = enable;
            btnSuaMonAn.Enabled = enable;

        }
        private void enableControls(bool enable)
        {

            pBAnhMinhHoa.Enabled = enable;
            pBAnhMinhHoa.Enabled = enable;
            txtTenMonAn.Enabled = enable;
            cmbLoaiMon.Enabled = enable;
            txtGia.Enabled = enable;
            btnThemNguyenLieu.Enabled = enable;
            btnLayAnh.Enabled = enable;
            btnLuu.Enabled = enable;
            btnHuy.Enabled = enable;
        }
        private void btnThemNguyenLieu_Click(object sender, EventArgs e)
        {
            frmThemNguyenLieuMonAn nguyenLieuMonAn = new frmThemNguyenLieuMonAn(this);
            nguyenLieuMonAn.ShowDialog();
            //if (dtNguyenLieu.Rows.Count == 0)
            //{
            //    dtNguyenLieu = nguyenLieuMonAn.DtNguyeLieuMonAn.Clone();
            //    // dtNguyenLieu.AcceptChanges();
            //    //return;
            //}
            // bindingSource.Clear();
            int count = nguyenLieuMonAn.bindingSource.Count;
            for (int i = 0; i < count; i++)
            {
                // this.bindingSource.Add(nguyenLieuMonAn.bindingSource[i]);
            }
            //   dGVNguyenLieu.DataSource = bindingSource;
        }

        private void btnLayAnh_Click(object sender, EventArgs e)
        {
            oFDLayAnh = new OpenFileDialog();
            // image filters  
            oFDLayAnh.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (oFDLayAnh.ShowDialog() == DialogResult.OK)
            {


                pBAnhMinhHoa.Image = new Bitmap(oFDLayAnh.FileName);
                pBAnhMinhHoa.SizeMode = PictureBoxSizeMode.StretchImage;
                // image file path  
                string[] temp = oFDLayAnh.FileName.Split('\\');
                tenHinhAnh = temp[temp.Length - 1];
            }
        }

        private void btnThemMonAn_Click(object sender, EventArgs e)
        {
            enableControls(true);
            enableButton(false);
            txtTenMonAn.Text = "";
            txtGia.Text = "";
            tenHinhAnh = "";
            pBAnhMinhHoa.Image = null;
            while (bindingSource.Current != null)
            {
                bindingSource.RemoveCurrent();
            }
           // btnSuaMonAn.Enabled = true;
            bThem = true;
        }
        /// <summary>
        /// Tránh nhập kí tự vào số
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGia_TextChanged(object sender, EventArgs e)
        {
            if (txtGia.Text == "")
            {
                return;
            }
            if (!Utility.IsContainsText(txtGia.Text))
            {
                donGia = Convert.ToUInt32(txtGia.Text);
            }
            else
            {
                txtGia.Text = donGia.ToString();
            }
        }

        private void frmMonAn_Load(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenMonAn.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên món ăn!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
                return;
            }
            if (cmbLoaiMon.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn loại món ăn!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
                return;
            }
            try
            {
                donGia = uint.Parse(txtGia.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn chưa nhập giá !", "Thông báo", MessageBoxButtons.OK,
                 MessageBoxIcon.Error, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
                return;

            }
            if (bindingSource.Count == 0)
            {
                MessageBox.Show("Bạn nhập nguyên liệu cho món ăn!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
                return;
            }
            if (bThem)
            {
                List<string> monan = new List<string>();
                for (int i = 0; i < bindingSource.Count; i++)
                {
                    monan.Add(((NguyenLieuMADataSource)bindingSource[i]).Ma);
                }
                List<string> soluong = new List<string>();
                for (int i = 0; i < bindingSource.Count; i++)
                {
                    soluong.Add(((NguyenLieuMADataSource)bindingSource[i]).SoLuong);
                }
                BUS.MonAnBUS.ThemMonAn(new DTO.MonAn() { Ten = txtTenMonAn.Text, Loai = ((LoaiMon)cmbLoaiMon.SelectedValue).Ma, Gia = donGia, TenHinhAnh = tenHinhAnh },
                   monan,
                   soluong);
                MessageBox.Show("Bạn nhập món ăn thành công", "Thông báo", MessageBoxButtons.OK,
                      MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
            }
            else if(bSua)
            {
                List<string> monan = new List<string>();
                for (int i = 0; i < bindingSource.Count; i++)
                {
                    monan.Add(((NguyenLieuMADataSource)bindingSource[i]).Ma);
                }
                List<string> soluong = new List<string>();
                for (int i = 0; i < bindingSource.Count; i++)
                {
                    soluong.Add(((NguyenLieuMADataSource)bindingSource[i]).SoLuong);
                }
                BUS.MonAnBUS.SuaMonAn(new DTO.MonAn() { Ma=ma,Ten = txtTenMonAn.Text, Loai = ((LoaiMon)cmbLoaiMon.SelectedValue).Ma, Gia = donGia, TenHinhAnh = tenHinhAnh },
                monan,
                soluong);
                MessageBox.Show("Bạn nhập món ăn thành công", "Thông báo", MessageBoxButtons.OK,
                      MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
            }
            enableControls(false);
            //enableButton1(false);
            enableButton(true);
            tenHinhAnh = "";
            txtTenMonAn.Text = "";
            resetDanhSach();
        }

     

        private void enableButton1(bool enable)
        {
            btnHuy.Enabled = enable;
            btnLuu.Enabled = enable;
        }

        private void btnSuaMonAn_Click(object sender, EventArgs e)
        {
            if (dGVMonAn.CurrentCell != null)
            {
                enableControls(true);
                enableButton(false);
               // btnSuaMonAn.Enabled = true;
                bSua = true;
            }


        }

        private void dGVMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGVMonAn.CurrentCell != null)
            {
                pBAnhMinhHoa.Image = null;
                int index = dGVMonAn.CurrentCell.RowIndex;
                MonAnDataSource dataSource = ((MonAnDataSource)bindingSourceMonAn[index]);
                ma = dataSource.Ma;
                List<NguyenLieuMADataSource> nguyenLieuMA = BUS.MonAnBUS.XemNguyenLieuMonAn(dataSource.Ma);
                bindingSource.DataSource = nguyenLieuMA;
            
                tenHinhAnh = dataSource.AnhMinhHoa;
                // display image in picture box  
                string path = Directory.GetCurrentDirectory();
                path = Path.GetFullPath(Path.Combine(path, @"..\..\")) + @"\Image\" + tenHinhAnh;

                txtGia.Text = dataSource.Gia;
                txtTenMonAn.Text = dataSource.Ten;
                for (int i = 0; i < cmbLoaiMon.Items.Count; i++)
                {
                    if(((LoaiMon)cmbLoaiMon.Items[i]).Ma== dataSource.MaLoaiHangHoa)
                    {
                        cmbLoaiMon.SelectedIndex = i;
                        break;
                    }
                }

                Image image = null;
                try
                {
                    image = Image.FromFile(path);
                    pBAnhMinhHoa.Image = image;
                    pBAnhMinhHoa.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception)
                {

                }

            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            enableControls(false);
            //enableButton1(false);
            enableButton(true);
            bThem = false;
            bSua = false;
        }

        private void dGVNguyenLieu_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 2 && e.RowIndex > -1)
                {


                }
            }
            catch (Exception)
            {


            }
        }

        private void btnXoaNguyenLieu_Click(object sender, EventArgs e)
        {
            if (dGVNguyenLieu.CurrentCell != null)
            {

            }
        }

        private void dGVNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGVNguyenLieu.CurrentCell != null)
            {

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
            if (cmbLoaiMonTK.SelectedValue != null)
            {
<<<<<<< HEAD
                bindingSourceMonAn.DataSource = BUS.MonAnBUS.XemMonAnDataSource(txtTenTK.Text, int.Parse(((LoaiHangHoa)cmbLoaiMonTK.SelectedValue).Ma),
=======
                bindingSourceMonAn.DataSource = BUS.MonAnBUS.XemMonAnDataSource(txtTenTK.Text, int.Parse(((DTO.LoaiHangHoa)cmbLoaiMonTK.SelectedValue).Ma),
>>>>>>> 684ccd889c3e5ec955668cac43100cb4812b2990
                               pageNumber, pageSize);
            }
            else
            {
                bindingSourceMonAn.DataSource = BUS.MonAnBUS.XemMonAnDataSource(txtTenTK.Text, 0,
               pageNumber, pageSize);
            }

            //dGVDanhSach.DataSource = BUS.NguyenLieuBUS.TiemKiemNguyenLieu(txtTenNL.Text,
            //    ((DTO.NhaCungCap)cmbNhaCC.SelectedValue).MaNCC, rbSapHet.Checked, pageNumber, pageSize);
        }

      
    }
}
