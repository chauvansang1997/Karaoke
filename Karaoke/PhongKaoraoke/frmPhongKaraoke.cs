using DTO;
using Karaoke.GuiMonAn;
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
    public partial class frmPhongKaraoke : Form
    {
        private List<PhongLayout> listLayout;
        private const int pageSize = 1;
        private int pageNumber;
        private int totalPage;
        private List<Phong> listPhong;
        private Dictionary<int, List<PhongLayout>> dictionaryAllLayout;
        private Dictionary<int, List<Phong>> dictionaryAllPhong;
        private List<PhongLayout> listPhongLayout;
        private List<Phong> listAllPhong;

        private Dictionary<int, List<FoodLayout>> dictionaryAvailableLayout;
        private Dictionary<int, List<MonAn>> dictionaryAvailablePhong;
        private Dictionary<int, List<FoodLayout>> dictionaryUnAvailableLayout;
        private Dictionary<int, List<MonAn>> dictionaryUnAvailablePhong;

        private Phong phongHienTai;
        private PhongLayout layoutHienTai;
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
                txtTenKhachHang.Text = phongHienTai.GetKhachHang.Ten;
                txtSDT.Text = phongHienTai.GetKhachHang.SoDT;
            }
        }



        public frmPhongKaraoke()
        {
            InitializeComponent();
            khoiTao();
        }
        public void khoiTao()
        {
            totalPage = BUS.PhongBUS.DemPhong("");
            txtTotalPage.Text = totalPage.ToString();
            dictionaryAllLayout = new Dictionary<int, List<PhongLayout>>();
            dictionaryAllPhong = new Dictionary<int, List<Phong>>();

            dictionaryAvailableLayout = new Dictionary<int, List<FoodLayout>>();
            dictionaryAvailablePhong = new Dictionary<int, List<MonAn>>();

            dictionaryUnAvailableLayout = new Dictionary<int, List<FoodLayout>>();
            dictionaryUnAvailablePhong = new Dictionary<int, List<MonAn>>();
            pageNumber = 1;
            txtPageNumber.Text = "1";
            hienThiTatCaPhong();
        }
        private void hienThiTatCaPhong()
        {

            if (dictionaryAllPhong.ContainsKey(pageNumber) == false)
            {
                dictionaryAllPhong.Add(pageNumber, BUS.PhongBUS.XemPhong("", pageSize, pageNumber));

            }
            flowPhongLayout.Controls.Clear();

            listAllPhong = dictionaryAllPhong[pageNumber];
            if (dictionaryAllLayout.ContainsKey(pageNumber) == false)
            {
                listPhongLayout = new List<PhongLayout>();
                for (int i = 0; i < listAllPhong.Count; i++)
                {
                    DTO.Phong item = listAllPhong[i];

                    PhongLayout phongLayout = new PhongLayout() { Phong=item};
                    if (item.TinhTrang == 0)
                    {
                        phongLayout.BackColor = Color.ForestGreen;
                    }
                    else
                    {
                        phongLayout.BackColor = Color.DarkRed;
                    }

                    phongLayout.setClick((sender, e) =>
                    {
                        PhongHienTai = phongLayout.Phong;
                        phongLayout.BackColor = Color.Blue;
                        layoutHienTai = phongLayout;
                        if (PhongHienTai.TinhTrang == 0)
                        {
                            txtTenKhachHang.ReadOnly = false;
                            txtSDT.ReadOnly = false;
                        }
                        else
                        {
                            txtTenKhachHang.ReadOnly = true;
                            txtSDT.ReadOnly = true;
                        }
                    });
                    flowPhongLayout.Controls.Add(phongLayout);

                    listPhongLayout.Add(phongLayout);
                }
                dictionaryAllLayout.Add(pageNumber, listPhongLayout);

            }
            else
            {
                listPhongLayout = dictionaryAllLayout[pageNumber];
                for (int i = 0; i < listPhongLayout.Count; i++)
                {
                    flowPhongLayout.Controls.Add(listPhongLayout[i]);
                }
            }
        }


        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đặt phòng không?", "Xác nhận", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                if (BUS.PhongBUS.GhiNhanDatPhong(new KhachHang(){Ten=txtTenKhachHang.Text,SoDT=txtSDT.Text}, PhongHienTai.Ten, "NV001"))
                {
                    MessageBox.Show("Đặt phòng thành công");
                    layoutHienTai.BackColor = Color.DarkRed;
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra. Hãy báo cho nhà cung cấp phần mềm để biết thêm chi tiết");
                }
            }
            else if (result == DialogResult.No)
            {
                //...
            }
            else
            {
                //...
            }
        }

        private void frmPhongKaraoke_Load(object sender, EventArgs e)
        {

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
            hienThiTatCaPhong();
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
            hienThiTatCaPhong();
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();
            hienThiTatCaPhong();
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            pageNumber = totalPage;
            txtPageNumber.Text = pageNumber.ToString();
            hienThiTatCaPhong();
        }
    }
}
