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

namespace Karaoke.GuiMonAn
{
    public partial class frmMonAn : Form
    {

        private bool bSua;
        private bool bThem;
        private DataTable dtNguyenLieu;
        private uint donGia;
        private string tenHinhAnh="";
        public BindingSource bindingSource = new BindingSource();
        public frmMonAn()
        {
            InitializeComponent();
            khoiTao();
        }

        private void khoiTao()
        {
            enableControls(false);
         

            dtNguyenLieu = new DataTable();
            dGVMonAn.DataSource = dtNguyenLieu;

            bindingSource.Add(new NguyenLieuDataSource());
            dGVNguyenLieu.DataSource = bindingSource;
            bindingSource.RemoveAt(0);
            dGVNguyenLieu.Columns["Ten"].HeaderText = "Tên";

            dGVNguyenLieu.Columns["Gia"].HeaderText = "Giá";

            dGVNguyenLieu.Columns["Soluong"].HeaderText = "Số lượng";
          //  dGVNguyenLieu.Columns["Thanhtien"].HeaderText = "Thành tiền";
            dGVNguyenLieu.Columns["DonViTinh"].HeaderText = "Đơn vị tính";

            dGVNguyenLieu.Columns["Ma"].Visible = false;
            dGVNguyenLieu.Columns["Loai"].Visible = false;


            dGVNguyenLieu.Columns["Thanhtien"].Visible = false;
            dGVNguyenLieu.Columns["Gia"].ReadOnly = true;
            dGVNguyenLieu.Columns["Ten"].ReadOnly = true;
            dGVNguyenLieu.Columns["Thanhtien"].ReadOnly = true;
        }
        private void enableButton(bool enable)
        {
            btnThemMonAn.Enabled = enable;
            btnXoaMonAn.Enabled = enable;
            btnSuaMonAn.Enabled = enable;
        }
        private void enableControls(bool enable)
        {

            txtAnhMinhHoa.Enabled = enable;
            pBAnhMinhHoa.Enabled = enable;

            pBAnhMinhHoa.Enabled = enable;
            txtTenMonAn.Enabled = enable;
            cmbLoaiMon.Enabled = enable;
            txtGia.Enabled = enable;
            btnThemNguyenLieu.Enabled = enable;
            btnXoaNguyenLieu.Enabled = enable;
            btnLayAnh.Enabled = enable;
        }
        private void btnThemNguyenLieu_Click(object sender, EventArgs e)
        {

        }

        private void btnThemNguyenLieu_Click_1(object sender, EventArgs e)
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
                // display image in picture box  
                pBAnhMinhHoa.Image = new Bitmap(oFDLayAnh.FileName);
                // image file path  
                txtAnhMinhHoa.Text = oFDLayAnh.FileName;
                string[] temp = oFDLayAnh.FileName.Split('\\');
                tenHinhAnh = temp[temp.Length - 1];
            }
        }

        private void btnThemMonAn_Click(object sender, EventArgs e)
        {
            enableControls(true);
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
            if (dtNguyenLieu.Rows.Count == 0)
            {
                MessageBox.Show("Bạn nhập nguyên liệu cho món ăn!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
                return;
            }
            BUS.MonAnBUS.ThemMonAn(new DTO.MonAn() { Ten = txtTenMonAn.Text, Loai = cmbLoaiMon.Text, Gia = donGia, TenHinhAnh = tenHinhAnh },
                dtNguyenLieu.AsEnumerable().Select(r => r.Field<string>("manl"))
                      .ToList());
            MessageBox.Show("Bạn nhập món ăn thành công", "Thông báo", MessageBoxButtons.OK,
                  MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
            tenHinhAnh = "";
            txtTenMonAn.Text = "";
        }

        private void btnSuaMonAn_Click(object sender, EventArgs e)
        {
            if (dGVMonAn.CurrentCell != null)
            {
                enableControls(true);
                bSua = true;
            }

        
        }

        private void dGVMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            enableControls(false);
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
    }
}
