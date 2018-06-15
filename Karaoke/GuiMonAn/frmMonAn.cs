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
        private DataTable dtNguyenLieu;
        private uint donGia;
        private string tenHinhAnh="";
        public frmMonAn()
        {
            InitializeComponent();
            khoiTao();
        }

        private void khoiTao()
        {
            dtNguyenLieu = new DataTable();
            dGVMonAn.DataSource = dtNguyenLieu;
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
            BUS.MonAnBUS.ThemMonAn(new DTO.MonAn() { Ten =txtTenMonAn.Text, Loai = cmbLoaiMon.Text, Gia = donGia,TenHinhAnh = tenHinhAnh },
                dtNguyenLieu.AsEnumerable().Select(r => r.Field<string>("manl"))
                      .ToList());
            MessageBox.Show("Bạn nhập món ăn thành công", "Thông báo", MessageBoxButtons.OK,
                  MessageBoxIcon.Error, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
            tenHinhAnh = "";
            txtTenMonAn.Text = "";
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

        
    }
}
