namespace Karaoke
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhapKhoSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.chinhSuaSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNguyênLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhapKhoNguyenLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.chinhSuaNguyenLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýThiếtBịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhapKhoThietBi = new System.Windows.Forms.ToolStripMenuItem();
            this.chinhSuaThietBi = new System.Windows.Forms.ToolStripMenuItem();
            this.sửDụngThiếtBịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMónĂnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.datPhongMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.xemLịchSửĐặtPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoTonKho = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoLuongMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanViemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phanCongMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.caTrucMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyLoaiKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyThongTinKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.nhaCungCap = new System.Windows.Forms.ToolStripMenuItem();
            this.khuyenMai = new System.Windows.Forms.ToolStripMenuItem();
            this.phong = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyThongTinPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyLoaiPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.phanQuyen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hangHoa,
            this.khachHang,
            this.baoCao,
            this.nhanVien,
            this.thanhVien,
            this.nhaCungCap,
            this.khuyenMai,
            this.phong,
            this.phanQuyen});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // hangHoa
            // 
            this.hangHoa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýSảnPhẩmToolStripMenuItem,
            this.quảnLýNguyênLiệuToolStripMenuItem,
            this.quảnLýThiếtBịToolStripMenuItem,
            this.quảnLýMónĂnToolStripMenuItem});
            resources.ApplyResources(this.hangHoa, "hangHoa");
            this.hangHoa.Name = "hangHoa";
            this.hangHoa.Tag = "6";
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            this.quảnLýSảnPhẩmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhapKhoSanPham,
            this.chinhSuaSanPham});
            this.quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            resources.ApplyResources(this.quảnLýSảnPhẩmToolStripMenuItem, "quảnLýSảnPhẩmToolStripMenuItem");
            // 
            // nhapKhoSanPham
            // 
            this.nhapKhoSanPham.Name = "nhapKhoSanPham";
            resources.ApplyResources(this.nhapKhoSanPham, "nhapKhoSanPham");
            this.nhapKhoSanPham.Click += new System.EventHandler(this.nhapKhoSanPham_Click);
            // 
            // chinhSuaSanPham
            // 
            this.chinhSuaSanPham.Name = "chinhSuaSanPham";
            resources.ApplyResources(this.chinhSuaSanPham, "chinhSuaSanPham");
            this.chinhSuaSanPham.Click += new System.EventHandler(this.suaSanPham_Click);
            // 
            // quảnLýNguyênLiệuToolStripMenuItem
            // 
            this.quảnLýNguyênLiệuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhapKhoNguyenLieu,
            this.chinhSuaNguyenLieu});
            this.quảnLýNguyênLiệuToolStripMenuItem.Name = "quảnLýNguyênLiệuToolStripMenuItem";
            resources.ApplyResources(this.quảnLýNguyênLiệuToolStripMenuItem, "quảnLýNguyênLiệuToolStripMenuItem");
            // 
            // nhapKhoNguyenLieu
            // 
            this.nhapKhoNguyenLieu.Name = "nhapKhoNguyenLieu";
            resources.ApplyResources(this.nhapKhoNguyenLieu, "nhapKhoNguyenLieu");
            this.nhapKhoNguyenLieu.Click += new System.EventHandler(this.NhapKhoNguyenLieuMenu_Click);
            // 
            // chinhSuaNguyenLieu
            // 
            this.chinhSuaNguyenLieu.Name = "chinhSuaNguyenLieu";
            resources.ApplyResources(this.chinhSuaNguyenLieu, "chinhSuaNguyenLieu");
            this.chinhSuaNguyenLieu.Click += new System.EventHandler(this.suaNguyenLieu_Click);
            // 
            // quảnLýThiếtBịToolStripMenuItem
            // 
            this.quảnLýThiếtBịToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhapKhoThietBi,
            this.chinhSuaThietBi,
            this.sửDụngThiếtBịToolStripMenuItem});
            this.quảnLýThiếtBịToolStripMenuItem.Name = "quảnLýThiếtBịToolStripMenuItem";
            resources.ApplyResources(this.quảnLýThiếtBịToolStripMenuItem, "quảnLýThiếtBịToolStripMenuItem");
            // 
            // nhapKhoThietBi
            // 
            this.nhapKhoThietBi.Name = "nhapKhoThietBi";
            resources.ApplyResources(this.nhapKhoThietBi, "nhapKhoThietBi");
            this.nhapKhoThietBi.Click += new System.EventHandler(this.nhapkhoThietBi_Click);
            // 
            // chinhSuaThietBi
            // 
            this.chinhSuaThietBi.Name = "chinhSuaThietBi";
            resources.ApplyResources(this.chinhSuaThietBi, "chinhSuaThietBi");
            this.chinhSuaThietBi.Click += new System.EventHandler(this.ChinhSuaKhoThietBiMenu_Click);
            // 
            // sửDụngThiếtBịToolStripMenuItem
            // 
            this.sửDụngThiếtBịToolStripMenuItem.Name = "sửDụngThiếtBịToolStripMenuItem";
            resources.ApplyResources(this.sửDụngThiếtBịToolStripMenuItem, "sửDụngThiếtBịToolStripMenuItem");
            this.sửDụngThiếtBịToolStripMenuItem.Click += new System.EventHandler(this.sửDụngThiếtBịToolStripMenuItem_Click);
            // 
            // quảnLýMónĂnToolStripMenuItem
            // 
            this.quảnLýMónĂnToolStripMenuItem.Name = "quảnLýMónĂnToolStripMenuItem";
            resources.ApplyResources(this.quảnLýMónĂnToolStripMenuItem, "quảnLýMónĂnToolStripMenuItem");
            this.quảnLýMónĂnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýMónĂnToolStripMenuItem_Click);
            // 
            // khachHang
            // 
            this.khachHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datPhongMenu,
            this.xemLịchSửĐặtPhòngToolStripMenuItem});
            resources.ApplyResources(this.khachHang, "khachHang");
            this.khachHang.Name = "khachHang";
            this.khachHang.Tag = "1";
            // 
            // datPhongMenu
            // 
            this.datPhongMenu.Name = "datPhongMenu";
            resources.ApplyResources(this.datPhongMenu, "datPhongMenu");
            this.datPhongMenu.Click += new System.EventHandler(this.datPhongMenu_Click);
            // 
            // xemLịchSửĐặtPhòngToolStripMenuItem
            // 
            this.xemLịchSửĐặtPhòngToolStripMenuItem.Name = "xemLịchSửĐặtPhòngToolStripMenuItem";
            resources.ApplyResources(this.xemLịchSửĐặtPhòngToolStripMenuItem, "xemLịchSửĐặtPhòngToolStripMenuItem");
            this.xemLịchSửĐặtPhòngToolStripMenuItem.Click += new System.EventHandler(this.xemLịchSửĐặtPhòngToolStripMenuItem_Click);
            // 
            // baoCao
            // 
            this.baoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baoCaoTonKho,
            this.baoCaoDoanhThu,
            this.baoCaoLuongMenu});
            resources.ApplyResources(this.baoCao, "baoCao");
            this.baoCao.Name = "baoCao";
            this.baoCao.Tag = "7";
            // 
            // baoCaoTonKho
            // 
            this.baoCaoTonKho.Name = "baoCaoTonKho";
            resources.ApplyResources(this.baoCaoTonKho, "baoCaoTonKho");
            this.baoCaoTonKho.Click += new System.EventHandler(this.baoCaoTonKho_Click);
            // 
            // baoCaoDoanhThu
            // 
            this.baoCaoDoanhThu.Name = "baoCaoDoanhThu";
            resources.ApplyResources(this.baoCaoDoanhThu, "baoCaoDoanhThu");
            this.baoCaoDoanhThu.Click += new System.EventHandler(this.baoCaoDoanhThu_Click);
            // 
            // baoCaoLuongMenu
            // 
            this.baoCaoLuongMenu.Image = global::Karaoke.Properties.Resources.salary;
            this.baoCaoLuongMenu.Name = "baoCaoLuongMenu";
            resources.ApplyResources(this.baoCaoLuongMenu, "baoCaoLuongMenu");
            this.baoCaoLuongMenu.Click += new System.EventHandler(this.baoCaoLuongMenu_Click);
            // 
            // nhanVien
            // 
            this.nhanVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhanViemMenuItem,
            this.phanCongMenu,
            this.caTrucMenu});
            resources.ApplyResources(this.nhanVien, "nhanVien");
            this.nhanVien.Name = "nhanVien";
            this.nhanVien.Tag = "4";
            // 
            // nhanViemMenuItem
            // 
            this.nhanViemMenuItem.Name = "nhanViemMenuItem";
            resources.ApplyResources(this.nhanViemMenuItem, "nhanViemMenuItem");
            this.nhanViemMenuItem.Click += new System.EventHandler(this.nhanViemMenuItem_Click);
            // 
            // phanCongMenu
            // 
            this.phanCongMenu.Name = "phanCongMenu";
            resources.ApplyResources(this.phanCongMenu, "phanCongMenu");
            this.phanCongMenu.Click += new System.EventHandler(this.phanCongMenu_Click_1);
            // 
            // caTrucMenu
            // 
            this.caTrucMenu.Name = "caTrucMenu";
            resources.ApplyResources(this.caTrucMenu, "caTrucMenu");
            this.caTrucMenu.Click += new System.EventHandler(this.caTrucMenu_Click);
            // 
            // thanhVien
            // 
            this.thanhVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyLoaiKhachHang,
            this.quanLyThongTinKhachHang});
            resources.ApplyResources(this.thanhVien, "thanhVien");
            this.thanhVien.Name = "thanhVien";
            this.thanhVien.Tag = "3";
            // 
            // quanLyLoaiKhachHang
            // 
            this.quanLyLoaiKhachHang.Name = "quanLyLoaiKhachHang";
            resources.ApplyResources(this.quanLyLoaiKhachHang, "quanLyLoaiKhachHang");
            this.quanLyLoaiKhachHang.Click += new System.EventHandler(this.quanLyLoaiKhachHang_Click);
            // 
            // quanLyThongTinKhachHang
            // 
            this.quanLyThongTinKhachHang.Name = "quanLyThongTinKhachHang";
            resources.ApplyResources(this.quanLyThongTinKhachHang, "quanLyThongTinKhachHang");
            this.quanLyThongTinKhachHang.Click += new System.EventHandler(this.khachHangMenu_Click);
            // 
            // nhaCungCap
            // 
            resources.ApplyResources(this.nhaCungCap, "nhaCungCap");
            this.nhaCungCap.Name = "nhaCungCap";
            this.nhaCungCap.Tag = "9";
            this.nhaCungCap.Click += new System.EventHandler(this.nhaCungCapMenu_Click);
            // 
            // khuyenMai
            // 
            resources.ApplyResources(this.khuyenMai, "khuyenMai");
            this.khuyenMai.Name = "khuyenMai";
            this.khuyenMai.Tag = "5";
            this.khuyenMai.Click += new System.EventHandler(this.quanLyKhuyenMaiMenu_Click);
            // 
            // phong
            // 
            this.phong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyThongTinPhong,
            this.quanLyLoaiPhong});
            resources.ApplyResources(this.phong, "phong");
            this.phong.Name = "phong";
            this.phong.Tag = "2";
            // 
            // quanLyThongTinPhong
            // 
            this.quanLyThongTinPhong.Name = "quanLyThongTinPhong";
            resources.ApplyResources(this.quanLyThongTinPhong, "quanLyThongTinPhong");
            this.quanLyThongTinPhong.Click += new System.EventHandler(this.quanLyThongTinPhong_Click);
            // 
            // quanLyLoaiPhong
            // 
            this.quanLyLoaiPhong.Name = "quanLyLoaiPhong";
            resources.ApplyResources(this.quanLyLoaiPhong, "quanLyLoaiPhong");
            this.quanLyLoaiPhong.Click += new System.EventHandler(this.quanLyLoaiPhong_Click);
            // 
            // phanQuyen
            // 
            resources.ApplyResources(this.phanQuyen, "phanQuyen");
            this.phanQuyen.Name = "phanQuyen";
            this.phanQuyen.Tag = "8";
            this.phanQuyen.Click += new System.EventHandler(this.phânQuyềnToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(216)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem baoCao;
        private System.Windows.Forms.ToolStripMenuItem baoCaoTonKho;
        private System.Windows.Forms.ToolStripMenuItem baoCaoDoanhThu;
        private System.Windows.Forms.ToolStripMenuItem nhanVien;
        private System.Windows.Forms.ToolStripMenuItem khachHang;
        private System.Windows.Forms.ToolStripMenuItem datPhongMenu;
        private System.Windows.Forms.ToolStripMenuItem thanhVien;
		private System.Windows.Forms.ToolStripMenuItem baoCaoLuongMenu;
        private System.Windows.Forms.ToolStripMenuItem nhaCungCap;
		private System.Windows.Forms.ToolStripMenuItem phanCongMenu;
		private System.Windows.Forms.ToolStripMenuItem caTrucMenu;
		private System.Windows.Forms.ToolStripMenuItem nhanViemMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hangHoa;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNguyênLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýThiếtBịToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhapKhoSanPham;
        private System.Windows.Forms.ToolStripMenuItem chinhSuaSanPham;
        private System.Windows.Forms.ToolStripMenuItem nhapKhoNguyenLieu;
        private System.Windows.Forms.ToolStripMenuItem chinhSuaNguyenLieu;
        private System.Windows.Forms.ToolStripMenuItem nhapKhoThietBi;
        private System.Windows.Forms.ToolStripMenuItem chinhSuaThietBi;
        private System.Windows.Forms.ToolStripMenuItem xemLịchSửĐặtPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khuyenMai;
        private System.Windows.Forms.ToolStripMenuItem sửDụngThiếtBịToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phong;
        private System.Windows.Forms.ToolStripMenuItem quanLyThongTinPhong;
        private System.Windows.Forms.ToolStripMenuItem quanLyLoaiPhong;
        private System.Windows.Forms.ToolStripMenuItem quanLyLoaiKhachHang;
        private System.Windows.Forms.ToolStripMenuItem quanLyThongTinKhachHang;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMónĂnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phanQuyen;
    }
}

