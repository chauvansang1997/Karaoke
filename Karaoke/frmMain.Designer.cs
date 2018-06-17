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
			this.quảnLýNguyênLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nhapKho = new System.Windows.Forms.ToolStripMenuItem();
			this.suaNguyenLieu = new System.Windows.Forms.ToolStripMenuItem();
			this.nhapMonAnMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nhapKhoSanPham = new System.Windows.Forms.ToolStripMenuItem();
			this.suaSanPham = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýThiếtBịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nhapkhoThietBi = new System.Windows.Forms.ToolStripMenuItem();
			this.chinhSuaTietBi = new System.Windows.Forms.ToolStripMenuItem();
			this.tiếpNhậnKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nhanDatTiecMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.datPhongMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.baoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.baoCaoTonKho = new System.Windows.Forms.ToolStripMenuItem();
			this.baoCaoDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
			this.baoCaoLuongMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.nhanVienMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.phanCongMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.caTrucMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.nhanViemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.khachHangMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.nhaCungCapMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNguyênLiệuToolStripMenuItem,
            this.quảnLýSảnPhẩmToolStripMenuItem,
            this.quảnLýThiếtBịToolStripMenuItem,
            this.tiếpNhậnKháchHàngToolStripMenuItem,
            this.baoCáoToolStripMenuItem,
            this.nhanVienMenu,
            this.khachHangMenu,
            this.nhaCungCapMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýNguyênLiệuToolStripMenuItem
            // 
            this.quảnLýNguyênLiệuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhapKho,
            this.suaNguyenLieu,
            this.nhapMonAnMenu});
			this.quảnLýNguyênLiệuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quảnLýNguyênLiệuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýNguyênLiệuToolStripMenuItem.Image")));
			this.quảnLýNguyênLiệuToolStripMenuItem.Name = "quảnLýNguyênLiệuToolStripMenuItem";
			this.quảnLýNguyênLiệuToolStripMenuItem.Size = new System.Drawing.Size(150, 21);
			this.quảnLýNguyênLiệuToolStripMenuItem.Text = "&Quản lý nguyên liệu";
			// 
			// nhapKho
			// 
			this.nhapKho.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nhapKho.Image = ((System.Drawing.Image)(resources.GetObject("nhapKho.Image")));
			this.nhapKho.Name = "nhapKho";
			this.nhapKho.Size = new System.Drawing.Size(221, 24);
			this.nhapKho.Text = "Nhập kho";
			this.nhapKho.Click += new System.EventHandler(this.nhapKho_Click);
			// 
			// suaNguyenLieu
			// 
			this.suaNguyenLieu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.suaNguyenLieu.Image = ((System.Drawing.Image)(resources.GetObject("suaNguyenLieu.Image")));
			this.suaNguyenLieu.Name = "suaNguyenLieu";
			this.suaNguyenLieu.Size = new System.Drawing.Size(221, 24);
			this.suaNguyenLieu.Text = "Chỉnh sửa nguyên liệu";
			this.suaNguyenLieu.Click += new System.EventHandler(this.suaNguyenLieu_Click);
			// 
			// nhapMonAnMenu
			// 
			this.nhapMonAnMenu.Name = "nhapMonAnMenu";
			this.nhapMonAnMenu.Size = new System.Drawing.Size(221, 24);
			this.nhapMonAnMenu.Text = "Nhập món ăn";
			this.nhapMonAnMenu.Click += new System.EventHandler(this.nhapMonAnMenu_Click);
			// 
			// quảnLýSảnPhẩmToolStripMenuItem
			// 
			this.quảnLýSảnPhẩmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhapKhoSanPham,
            this.suaSanPham});
			this.quảnLýSảnPhẩmToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quảnLýSảnPhẩmToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýSảnPhẩmToolStripMenuItem.Image")));
			this.quảnLýSảnPhẩmToolStripMenuItem.Name = "quanLySanPhamMenu";
			this.quảnLýSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(141, 21);
			this.quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản lý sản phẩm";
			// 
			// nhapKhoSanPham
			// 
			this.nhapKhoSanPham.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nhapKhoSanPham.Image = ((System.Drawing.Image)(resources.GetObject("nhapKhoSanPham.Image")));
			this.nhapKhoSanPham.Name = "nhapKhoSanPham";
			this.nhapKhoSanPham.Size = new System.Drawing.Size(209, 24);
			this.nhapKhoSanPham.Text = "Nhập kho";
			this.nhapKhoSanPham.Click += new System.EventHandler(this.nhapKhoSanPham_Click);
			// 
			// suaSanPham
			// 
			this.suaSanPham.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.suaSanPham.Image = ((System.Drawing.Image)(resources.GetObject("suaSanPham.Image")));
			this.suaSanPham.Name = "suaSanPham";
			this.suaSanPham.Size = new System.Drawing.Size(209, 24);
			this.suaSanPham.Text = "Chỉnh sửa sản phẩm";
			this.suaSanPham.Click += new System.EventHandler(this.suaSanPham_Click);
			// 
			// quảnLýThiếtBịToolStripMenuItem
			// 
			this.quảnLýThiếtBịToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhapkhoThietBi,
            this.chinhSuaTietBi});
			this.quảnLýThiếtBịToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quảnLýThiếtBịToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýThiếtBịToolStripMenuItem.Image")));
			this.quảnLýThiếtBịToolStripMenuItem.Name = "quảnLýThiếtBịToolStripMenuItem";
			this.quảnLýThiếtBịToolStripMenuItem.Size = new System.Drawing.Size(124, 21);
			this.quảnLýThiếtBịToolStripMenuItem.Text = "Quản lý thiết bị";
			// 
			// nhapkhoThietBi
			// 
			this.nhapkhoThietBi.Image = ((System.Drawing.Image)(resources.GetObject("nhapkhoThietBi.Image")));
			this.nhapkhoThietBi.Name = "nhapkhoThietBi";
			this.nhapkhoThietBi.Size = new System.Drawing.Size(177, 22);
			this.nhapkhoThietBi.Text = "Nhập kho";
			this.nhapkhoThietBi.Click += new System.EventHandler(this.nhapkhoThietBi_Click);
			// 
			// chinhSuaTietBi
			// 
			this.chinhSuaTietBi.Image = ((System.Drawing.Image)(resources.GetObject("chinhSuaTietBi.Image")));
			this.chinhSuaTietBi.Name = "chinhSuaTietBi";
			this.chinhSuaTietBi.Size = new System.Drawing.Size(177, 22);
			this.chinhSuaTietBi.Text = "Chỉnh sửa thiết bị";
			this.chinhSuaTietBi.Click += new System.EventHandler(this.chinhSuaTietBi_Click);
			// 
			// tiếpNhậnKháchHàngToolStripMenuItem
			// 
			this.tiếpNhậnKháchHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhanDatTiecMenu,
            this.datPhongMenu});
			this.tiếpNhậnKháchHàngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tiếpNhậnKháchHàngToolStripMenuItem.Name = "tiếpNhậnKháchHàngToolStripMenuItem";
			this.tiếpNhậnKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(147, 21);
			this.tiếpNhậnKháchHàngToolStripMenuItem.Text = "Tiếp nhận khách hàng";
			// 
			// nhanDatTiecMenu
			// 
			this.nhanDatTiecMenu.Name = "nhanDatTiecMenu";
			this.nhanDatTiecMenu.Size = new System.Drawing.Size(154, 22);
			this.nhanDatTiecMenu.Text = "Nhận đặt tiệc";
			this.nhanDatTiecMenu.Click += new System.EventHandler(this.nhanDatTiecMenu_Click);
			// 
			// datPhongMenu
			// 
			this.datPhongMenu.Name = "datPhongMenu";
			this.datPhongMenu.Size = new System.Drawing.Size(154, 22);
			this.datPhongMenu.Text = "Đặt phòng";
			this.datPhongMenu.Click += new System.EventHandler(this.datPhongMenu_Click);
			// 
			// baoCáoToolStripMenuItem
			// 
			this.baoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baoCaoTonKho,
            this.baoCaoDoanhThu,
            this.baoCaoLuongMenu});
			this.baoCáoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.baoCáoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("baoCáoToolStripMenuItem.Image")));
			this.baoCáoToolStripMenuItem.Name = "baoCáoToolStripMenuItem";
			this.baoCáoToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
			this.baoCáoToolStripMenuItem.Text = "Báo cáo";
			// 
			// baoCaoTonKho
			// 
			this.baoCaoTonKho.Name = "baoCaoTonKho";
			this.baoCaoTonKho.Size = new System.Drawing.Size(186, 22);
			this.baoCaoTonKho.Text = "Báo cáo tồn kho";
			this.baoCaoTonKho.Click += new System.EventHandler(this.baoCaoTonKho_Click);
			// 
			// baoCaoDoanhThu
			// 
			this.baoCaoDoanhThu.Name = "baoCaoDoanhThu";
			this.baoCaoDoanhThu.Size = new System.Drawing.Size(186, 22);
			this.baoCaoDoanhThu.Text = "Báo cáo doanh thu";
			this.baoCaoDoanhThu.Click += new System.EventHandler(this.baoCaoDoanhThu_Click);
			// 
			// baoCaoLuongMenu
			// 
			this.baoCaoLuongMenu.Image = global::Karaoke.Properties.Resources.salary;
			this.baoCaoLuongMenu.Name = "baoCaoLuongMenu";
			this.baoCaoLuongMenu.Size = new System.Drawing.Size(186, 22);
			this.baoCaoLuongMenu.Text = "Báo cáo lương";
			this.baoCaoLuongMenu.Click += new System.EventHandler(this.baoCaoLuongMenu_Click);
			// 
			// nhanVienMenu
			// 
			this.nhanVienMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhanViemMenuItem,
            this.phanCongMenu,
            this.caTrucMenu});
			this.nhanVienMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nhanVienMenu.Name = "nhanVienMenu";
			this.nhanVienMenu.Size = new System.Drawing.Size(123, 21);
			this.nhanVienMenu.Text = "Quản lý nhân viên";
			// 
			// phanCongMenu
			// 
			this.phanCongMenu.Name = "phanCongMenu";
			this.phanCongMenu.Size = new System.Drawing.Size(180, 22);
			this.phanCongMenu.Text = "Phân công";
			this.phanCongMenu.Click += new System.EventHandler(this.phanCongMenu_Click_1);
			// 
			// caTrucMenu
			// 
			this.caTrucMenu.Name = "caTrucMenu";
			this.caTrucMenu.Size = new System.Drawing.Size(180, 22);
			this.caTrucMenu.Text = "Ca trực";
			this.caTrucMenu.Click += new System.EventHandler(this.caTrucMenu_Click);
			// 
			// nhanViemMenuItem
			// 
			this.nhanViemMenuItem.Name = "nhanViemMenuItem";
			this.nhanViemMenuItem.Size = new System.Drawing.Size(180, 22);
			this.nhanViemMenuItem.Text = "Nhân viên";
			this.nhanViemMenuItem.Click += new System.EventHandler(this.nhanViemMenuItem_Click);
			// 
			// khachHangMenu
			// 
			this.khachHangMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.khachHangMenu.Name = "khachHangMenu";
			this.khachHangMenu.Size = new System.Drawing.Size(134, 21);
			this.khachHangMenu.Text = "Quản lý khách hàng";
			this.khachHangMenu.Click += new System.EventHandler(this.khachHangMenu_Click);
			// 
			// nhaCungCapMenu
			// 
			this.nhaCungCapMenu.Name = "nhaCungCapMenu";
			this.nhaCungCapMenu.Size = new System.Drawing.Size(146, 21);
			this.nhaCungCapMenu.Text = "Quản lý nhà cung cấp";
			this.nhaCungCapMenu.Click += new System.EventHandler(this.nhaCungCapMenu_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(216)))), ((int)(((byte)(233)))));
			this.ClientSize = new System.Drawing.Size(1064, 379);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hệ thống quản lý Karaoke";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNguyênLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhapKho;
        private System.Windows.Forms.ToolStripMenuItem suaNguyenLieu;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhapKhoSanPham;
        private System.Windows.Forms.ToolStripMenuItem suaSanPham;
        private System.Windows.Forms.ToolStripMenuItem baoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baoCaoTonKho;
        private System.Windows.Forms.ToolStripMenuItem baoCaoDoanhThu;
        private System.Windows.Forms.ToolStripMenuItem nhanVienMenu;
        private System.Windows.Forms.ToolStripMenuItem quảnLýThiếtBịToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhapkhoThietBi;
        private System.Windows.Forms.ToolStripMenuItem chinhSuaTietBi;
        private System.Windows.Forms.ToolStripMenuItem tiếpNhậnKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhanDatTiecMenu;
        private System.Windows.Forms.ToolStripMenuItem datPhongMenu;
        private System.Windows.Forms.ToolStripMenuItem khachHangMenu;
		private System.Windows.Forms.ToolStripMenuItem baoCaoLuongMenu;
        private System.Windows.Forms.ToolStripMenuItem nhapMonAnMenu;
        private System.Windows.Forms.ToolStripMenuItem nhaCungCapMenu;
		private System.Windows.Forms.ToolStripMenuItem phanCongMenu;
		private System.Windows.Forms.ToolStripMenuItem caTrucMenu;
		private System.Windows.Forms.ToolStripMenuItem nhanViemMenuItem;
	}
}

