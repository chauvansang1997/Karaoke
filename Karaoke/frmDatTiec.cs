using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace Karaoke
{
    public partial class frmDatTiec : Form
    {
        private const int pageSize = 10;
        private int pageNumber;
        private int totalPage;
        private Dictionary<int, List<PhongLayout>> dictionaryLayout;
        private Dictionary<string, List<PhieuDatTiec>> dictionaryDatTiec;
        private List<PhongLayout> listPhongLayout;
        private List<Phong> listAllPhong;
        private List<PhieuDatTiec> listPhieuDatTiec;

        private BindingSource bindingSource = new BindingSource();
        private int indexHienTai;
        private int indexTruoc;
        private Phong phongHienTai;
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
             //   txtTenKhachHang.Text = phongHienTai.GetKhachHang.Ten;
              //  txtSDT.Text = phongHienTai.GetKhachHang.SoDT;
            }
        }

        public frmDatTiec()
        {
            InitializeComponent();
            khoiTao();
        }

        private void khoiTao()
        {
            dTPNgayNhanPhong.Format = DateTimePickerFormat.Custom;
            dTPNgayNhanPhong.CustomFormat = "dd/MM/yyyy  hh:mm:ss";
            pageNumber = 1;
            totalPage = PhongBUS.DemPhong(-1);
            totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();
            indexHienTai = -1;
            dictionaryLayout = new Dictionary<int, List<PhongLayout>>();
            dictionaryDatTiec = new Dictionary<string, List<PhieuDatTiec>>();



            bindingSource.Add(new PhieuDatTiec());
            dGVDatTiec.AllowUserToAddRows = false;
            dGVDatTiec.DataSource = bindingSource;
            bindingSource.RemoveAt(0);
            dGVDatTiec.Columns["Phong"].HeaderText = "Phòng";
            dGVDatTiec.Columns["TenKH"].HeaderText = "Tên khách hàng";
            dGVDatTiec.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            dGVDatTiec.Columns["NgayDat"].HeaderText = "Thời gian đặt";
            dGVDatTiec.Columns["NgayNhan"].HeaderText = "Thời gian nhận";
            //dGVDatTiec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dGVDatTiec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGVDatTiec.Columns["SoHD"].Visible = false;
   
           
            hienThiTatCaPhong();
        }
        private void hienThiTatCaPhong()
        {
            indexHienTai = -1;
            flowPhongLayout.Controls.Clear();
            if (dictionaryLayout.ContainsKey(pageNumber) == false)
            {
                listAllPhong = BUS.PhongBUS.XemPhong(-1, pageSize, pageNumber);
                listPhongLayout = new List<PhongLayout>();
                for (int i = 0; i < listAllPhong.Count; i++)
                {
                    DTO.Phong item = listAllPhong[i];

                    PhongLayout phongLayout = new PhongLayout() { Phong = item, IndexList = i };
                    phongLayout.Ten = item.Ten;
                    phongLayout.Loai = item.TenLoai;
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
                        if (!dictionaryDatTiec.ContainsKey(phongLayout.Phong.Ten)){
                            listPhieuDatTiec = PhieuDatTiecBUS.XemPhieuDatCho(phongLayout.Phong.Ten, 1, totalPage);
                            dictionaryDatTiec.Add(phongLayout.Phong.Ten, listPhieuDatTiec);
                        }
                        else
                        {
                            listPhieuDatTiec = dictionaryDatTiec[phongLayout.Phong.Ten];
                        }

                        bindingSource.DataSource = listPhieuDatTiec;
                   
                        indexTruoc = indexHienTai;
                        if (indexTruoc != -1)
                        {
                            if (listPhongLayout[indexTruoc].Phong.TinhTrang == 0)
                            {
                                listPhongLayout[indexTruoc].BackColor = Color.ForestGreen;
                            }
                            else
                            {
                                listPhongLayout[indexTruoc].BackColor = Color.DarkRed;
                            }
                        }
                        indexHienTai = phongLayout.IndexList;

                        PhongHienTai = phongLayout.Phong;

                        phongLayout.BackColor = Color.Blue;

                        //if (PhongHienTai.TinhTrang == 0)
                        //{
                        //    txtTenKhachHang.ReadOnly = false;
                        //    txtSDT.ReadOnly = false;
                        //}
                        //else
                        //{
                        //    txtTenKhachHang.ReadOnly = true;
                        //    txtSDT.ReadOnly = true;
                        //}
                    });
                    flowPhongLayout.Controls.Add(phongLayout);

                    listPhongLayout.Add(phongLayout);
                }
                dictionaryLayout.Add(pageNumber, listPhongLayout);
            }
            else
            {
                listPhongLayout = dictionaryLayout[pageNumber];
                for (int i = 0; i < listPhongLayout.Count; i++)
                {
                    flowPhongLayout.Controls.Add(listPhongLayout[i]);
                }
            }
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

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
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

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            pageNumber = totalPage;
            txtPageNumber.Text = pageNumber.ToString();
            hienThiTatCaPhong();
        }

        private void dGVDatTiec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ( e.RowIndex > -1)
            {

            }
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            string tenKhachHang = txtTenKhachHang.Text;
            string soDienThoai = txtSDT.Text;
            //ngày nhận phòng
            DateTime dateTimeNhanPhong = dTPNgayNhanPhong.Value;
            string ngayNhanPhong = dateTimeNhanPhong.ToString("dd/MM/yyyy HH:mm");
            //ngày đặt phòng
            DateTime dateTimeDat = DateTime.Now;
            string ngayDatTiec= dateTimeDat.ToString("dd/MM/yyyy HH:mm");
            //ngày kết thúc
            double thoiGianDat = Int32.Parse(txtThoiGianDat.Text);           
            DateTime dateTimeKetThuc = dateTimeNhanPhong.AddHours(thoiGianDat);
            string ngayGioKetThuc = dateTimeKetThuc.ToString("dd/MM/yyyy HH:mm");

            if (BUS.PhieuDatTiecBUS.KiemTraPhieuDatTiec(PhongHienTai.Ten, dateTimeNhanPhong, dateTimeKetThuc))
            {
                string soHoaDon = BUS.PhieuDatTiecBUS.GhiNhanDatTiec(new DTO.KhachHang() { Ten = tenKhachHang, SoDT = soDienThoai },
                                         PhongHienTai.Ten, "NV001", dateTimeNhanPhong, dateTimeDat, dateTimeKetThuc);
                if (soHoaDon != "")
                {
                    MessageBox.Show("Đặt phòng thành công");
                    bindingSource.Add(new PhieuDatTiec() {TenKH= tenKhachHang, SoDienThoai= soDienThoai ,
                        NgayDat = dateTimeDat.ToString("dd/MM/yyyy HH:mm"),
                        NgayNhan= dateTimeNhanPhong.ToString("dd/MM/yyyy HH:mm"),
                        Phong= PhongHienTai.Ten,         
                        SoHD= soHoaDon
                    });
                    frmChonMon chonMon = new frmChonMon(soHoaDon);
                    chonMon.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra!!!");
                }
            }
            else
            {
                MessageBox.Show("Đã có khách hàng khác đặt vào thời gian này. Xin chọn thời gian khác");
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if(dGVDatTiec.CurrentRow != null)
            {
                int index = dGVDatTiec.CurrentRow.Index;
                string soHD = dGVDatTiec[5, index].Value.ToString();
                frmChonMon chonMon = new frmChonMon(soHD);
                chonMon.ShowDialog();
            }
        }


        private void btnHuy_MouseHover(object sender, EventArgs e)
        {
            this.btnHuy.FlatAppearance.BorderSize = 2;
        }

        private void btnXem_MouseHover(object sender, EventArgs e)
        {
            this.btnXem.FlatAppearance.BorderSize = 2;
        }

        private void btnNhanPhong_MouseHover(object sender, EventArgs e)
        {
            this.btnNhanPhong.FlatAppearance.BorderSize = 2;
        }

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            if (dGVDatTiec.CurrentRow != null)
            {
                int index = dGVDatTiec.CurrentRow.Index;
                string soHD = dGVDatTiec[5, index].Value.ToString();
                if (BUS.PhongBUS.NhanPhongDatTruoc(soHD))
                {
                    MessageBox.Show("Nhận phòng thành công");
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra");
                }
            }

        }
    }
}
