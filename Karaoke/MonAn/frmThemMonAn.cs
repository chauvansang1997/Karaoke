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

namespace Karaoke.MonAn
{
    public partial class frmThemMonAn : Form
    {
        private DataTable dtNguyenLieu;
        private uint donGia;
        public frmThemMonAn()
        {
            InitializeComponent();
            khoiTao();
        }

        private void khoiTao()
        {
            dtNguyenLieu = new DataTable();
            dGVNguyenLieu.DataSource = dtNguyenLieu;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenMonaAn.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên món ăn!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
                return;
            }
            if (cmbLoaiMonAn.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn loại món ăn!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
                return;
            }
            try
            {
                donGia = uint.Parse(txtDonGia.Text);
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
            BUS.MonAnBUS.ThemMonAn(new DTO.MonAn() { TenMonAn = txtTenMonaAn.Text, LoaiMonAn = cmbLoaiMonAn.Text, Gia=donGia },
                dtNguyenLieu.AsEnumerable().Select(r => r.Field<string>("manl"))
                      .ToList());
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
            }
        }

        private void frmThemMonAn_Load(object sender, EventArgs e)
        {

        }

        private void btnThemNguyenLieu_Click(object sender, EventArgs e)
        {
            frmThemNguyenLieuMonAn nguyenLieuMonAn = new frmThemNguyenLieuMonAn(dtNguyenLieu);
            nguyenLieuMonAn.ShowDialog();
            if (dtNguyenLieu.Rows.Count == 0)
            {
                dtNguyenLieu = nguyenLieuMonAn.DtNguyeLieuMonAn.Clone();
                // dtNguyenLieu.AcceptChanges();
                //return;
            }
            foreach (DataRow dr in nguyenLieuMonAn.DtNguyeLieuMonAn.Rows)
            {
                dtNguyenLieu.Rows.Add(dr.ItemArray);
            }
            dGVNguyenLieu.DataSource = dtNguyenLieu;
        }
        /// <summary>
        /// Tránh nhập kí tự vào số
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGia.Text == "")
            {
                return;
            }
            if (!Utility.IsContainsText(txtDonGia.Text))
            {
                donGia = Convert.ToUInt32(txtDonGia.Text);
            }
            else
            {
                txtDonGia.Text = donGia.ToString();
            }
        }
    }
}
