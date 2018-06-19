using DTO;
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
    public partial class frmChuyenPhong : Form
    {
        private Dictionary<int, List<PhongLayout>> dictionaryAvailableLayout;
        private List<PhongLayout> listPhongLayout;
        private List<Phong> listAllPhong;

        private const int pageSize = 10;
        private int pageNumber;
        private int totalPage;

        private Phong phongHienTai;
        private int indexHienTai;
        private int indexTruoc;

        string maPhongHienTai;
        public Phong PhongHienTai
        {
            get
            {
                return phongHienTai;
            }
            set
            {
                phongHienTai = value;
                txtTenPhong.Text = phongHienTai.Ten;
                txtGia.Text = phongHienTai.Gia.ToString();
                txtLoaiPhong.Text = phongHienTai.TenLoai;

            }
        }
        public frmChuyenPhong(string maPhongHienTai)
        {
            this.maPhongHienTai = maPhongHienTai;
            InitializeComponent();
            khoiTao();
        }

        private void khoiTao()
        {
            dictionaryAvailableLayout = new Dictionary<int, List<PhongLayout>>();
            listAllPhong = new List<Phong>();
            totalPage = Utility.TinhKichThuocTrang(BUS.PhongBUS.DemPhong(0), pageSize);
            txtTotalPage.Text = totalPage.ToString();
            pageNumber = 1;
            txtPageNumber.Text = "1";
            indexHienTai = -1;
            hienThiDanhSachPhong();
        }

        private void hienThiDanhSachPhong()
        {
            indexHienTai = -1;
            flowPhongLayout.Controls.Clear();
            if (dictionaryAvailableLayout.ContainsKey(pageNumber) == false)
            {
                listAllPhong = BUS.PhongBUS.XemPhong(0, pageSize, pageNumber);
                listPhongLayout = new List<PhongLayout>();
                for (int i = 0; i < listAllPhong.Count; i++)
                {
                    DTO.Phong item = listAllPhong[i];

                    PhongLayout phongLayout = new PhongLayout() { Phong = item, IndexList = i };
                    phongLayout.Ten = item.Ten;

                    phongLayout.BackColor = Color.ForestGreen;

                    phongLayout.setClick((sender, e) =>
                    {
                        indexTruoc = indexHienTai;
                        if (indexTruoc != -1)
                        {
                            listPhongLayout[indexTruoc].BackColor = Color.ForestGreen;
                        }
                        indexHienTai = phongLayout.IndexList;

                        PhongHienTai = phongLayout.Phong;

                        phongLayout.BackColor = Color.Blue;


                    });
                    flowPhongLayout.Controls.Add(phongLayout);

                    listPhongLayout.Add(phongLayout);
                }
                dictionaryAvailableLayout.Add(pageNumber, listPhongLayout);
            }
            else
            {
                listPhongLayout = dictionaryAvailableLayout[pageNumber];
                for (int i = 0; i < listPhongLayout.Count; i++)
                {
                    flowPhongLayout.Controls.Add(listPhongLayout[i]);
                }
            }
        }
        private void btnLuu_MouseHover(object sender, EventArgs e)
        {
            this.btnChuyen.FlatAppearance.BorderSize = 2;
        }

        private void btnThoat_MouseHover(object sender, EventArgs e)
        {
            this.btnThoat.FlatAppearance.BorderSize = 2;
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            if (PhongHienTai != null)
            {
                if (BUS.PhongBUS.ChuyenPhong(this.maPhongHienTai, PhongHienTai.Ten))
                {
                    MessageBox.Show("Chuyển phòng thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra");
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn phòng trước");
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

            hienThiDanhSachPhong();
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
            hienThiDanhSachPhong();
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();
            hienThiDanhSachPhong();

        }


        private void btnLastPage_Click(object sender, EventArgs e)
        {
            pageNumber = totalPage;
            txtPageNumber.Text = pageNumber.ToString();
            hienThiDanhSachPhong();
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
            hienThiDanhSachPhong();
        }

    }
}
