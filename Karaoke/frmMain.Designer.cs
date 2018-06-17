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
            this.tiếpNhậnKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanDatTiecMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.datPhongMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanVienMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhânCôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phanCongMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.caTrucMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.khachHangMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.nhaCungCapMenu = new System.Windows.Forms.ToolStripMenuItem();
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
            this.baoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoTonKho = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoLuongMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNguyênLiệuToolStripMenuItem,
            this.quảnLýSảnPhẩmToolStripMenuItem,
            this.quảnLýThiếtBịToolStripMenuItem,
            this.tiếpNhậnKháchHàngToolStripMenuItem,
            this.baoCáoToolStripMenuItem,
            this.nhanVienMenu,
            this.khachHangMenu,
            this.nhaCungCapMenu});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // tiếpNhậnKháchHàngToolStripMenuItem
            // 
            this.tiếpNhậnKháchHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhanDatTiecMenu,
            this.datPhongMenu});
            resources.ApplyResources(this.tiếpNhậnKháchHàngToolStripMenuItem, "tiếpNhậnKháchHàngToolStripMenuItem");
            this.tiếpNhậnKháchHàngToolStripMenuItem.Name = "tiếpNhậnKháchHàngToolStripMenuItem";
            // 
            // nhanDatTiecMenu
            // 
            this.nhanDatTiecMenu.Name = "nhanDatTiecMenu";
            resources.ApplyResources(this.nhanDatTiecMenu, "nhanDatTiecMenu");
            this.nhanDatTiecMenu.Click += new System.EventHandler(this.nhanDatTiecMenu_Click);
            // 
            // datPhongMenu
            // 
            this.datPhongMenu.Name = "datPhongMenu";
            resources.ApplyResources(this.datPhongMenu, "datPhongMenu");
            this.datPhongMenu.Click += new System.EventHandler(this.datPhongMenu_Click);
            // 
            // nhanVienMenu
            // 
            this.nhanVienMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýPhânCôngToolStripMenuItem});
            resources.ApplyResources(this.nhanVienMenu, "nhanVienMenu");
            this.nhanVienMenu.Name = "nhanVienMenu";
            // 
            // quảnLýPhânCôngToolStripMenuItem
            // 
            this.quảnLýPhânCôngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phanCongMenu,
            this.caTrucMenu});
            this.quảnLýPhânCôngToolStripMenuItem.Name = "quảnLýPhânCôngToolStripMenuItem";
            resources.ApplyResources(this.quảnLýPhânCôngToolStripMenuItem, "quảnLýPhânCôngToolStripMenuItem");
            // 
            // phanCongMenu
            // 
            this.phanCongMenu.Name = "phanCongMenu";
            resources.ApplyResources(this.phanCongMenu, "phanCongMenu");
            this.phanCongMenu.Click += new System.EventHandler(this.phanCongMenu_Click);
            // 
            // caTrucMenu
            // 
            this.caTrucMenu.Name = "caTrucMenu";
            resources.ApplyResources(this.caTrucMenu, "caTrucMenu");
            this.caTrucMenu.Click += new System.EventHandler(this.caTrucItem_Click);
            // 
            // khachHangMenu
            // 
            resources.ApplyResources(this.khachHangMenu, "khachHangMenu");
            this.khachHangMenu.Name = "khachHangMenu";
            this.khachHangMenu.Click += new System.EventHandler(this.khachHangMenu_Click);
            // 
            // nhaCungCapMenu
            // 
            this.nhaCungCapMenu.Name = "nhaCungCapMenu";
            resources.ApplyResources(this.nhaCungCapMenu, "nhaCungCapMenu");
            this.nhaCungCapMenu.Click += new System.EventHandler(this.nhaCungCapMenu_Click);
            // 
            // quảnLýNguyênLiệuToolStripMenuItem
            // 
            this.quảnLýNguyênLiệuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhapKho,
            this.suaNguyenLieu,
            this.nhapMonAnMenu});
            resources.ApplyResources(this.quảnLýNguyênLiệuToolStripMenuItem, "quảnLýNguyênLiệuToolStripMenuItem");
            this.quảnLýNguyênLiệuToolStripMenuItem.Name = "quảnLýNguyênLiệuToolStripMenuItem";
            // 
            // nhapKho
            // 
            resources.ApplyResources(this.nhapKho, "nhapKho");
            this.nhapKho.Name = "nhapKho";
            this.nhapKho.Click += new System.EventHandler(this.nhapKho_Click);
            // 
            // suaNguyenLieu
            // 
            resources.ApplyResources(this.suaNguyenLieu, "suaNguyenLieu");
            this.suaNguyenLieu.Name = "suaNguyenLieu";
            this.suaNguyenLieu.Click += new System.EventHandler(this.suaNguyenLieu_Click);
            // 
            // nhapMonAnMenu
            // 
            this.nhapMonAnMenu.Name = "nhapMonAnMenu";
            resources.ApplyResources(this.nhapMonAnMenu, "nhapMonAnMenu");
            this.nhapMonAnMenu.Click += new System.EventHandler(this.nhapMonAnMenu_Click);
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            this.quảnLýSảnPhẩmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhapKhoSanPham,
            this.suaSanPham});
            resources.ApplyResources(this.quảnLýSảnPhẩmToolStripMenuItem, "quảnLýSảnPhẩmToolStripMenuItem");
            this.quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            // 
            // nhapKhoSanPham
            // 
            resources.ApplyResources(this.nhapKhoSanPham, "nhapKhoSanPham");
            this.nhapKhoSanPham.Name = "nhapKhoSanPham";
            this.nhapKhoSanPham.Click += new System.EventHandler(this.nhapKhoSanPham_Click);
            // 
            // suaSanPham
            // 
            resources.ApplyResources(this.suaSanPham, "suaSanPham");
            this.suaSanPham.Name = "suaSanPham";
            this.suaSanPham.Click += new System.EventHandler(this.suaSanPham_Click);
            // 
            // quảnLýThiếtBịToolStripMenuItem
            // 
            this.quảnLýThiếtBịToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhapkhoThietBi,
            this.chinhSuaTietBi});
            resources.ApplyResources(this.quảnLýThiếtBịToolStripMenuItem, "quảnLýThiếtBịToolStripMenuItem");
            this.quảnLýThiếtBịToolStripMenuItem.Name = "quảnLýThiếtBịToolStripMenuItem";
            // 
            // nhapkhoThietBi
            // 
            resources.ApplyResources(this.nhapkhoThietBi, "nhapkhoThietBi");
            this.nhapkhoThietBi.Name = "nhapkhoThietBi";
            this.nhapkhoThietBi.Click += new System.EventHandler(this.nhapkhoThietBi_Click);
            // 
            // chinhSuaTietBi
            // 
            resources.ApplyResources(this.chinhSuaTietBi, "chinhSuaTietBi");
            this.chinhSuaTietBi.Name = "chinhSuaTietBi";
            this.chinhSuaTietBi.Click += new System.EventHandler(this.chinhSuaTietBi_Click);
            // 
            // baoCáoToolStripMenuItem
            // 
            this.baoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baoCaoTonKho,
            this.baoCaoDoanhThu,
            this.baoCaoLuongMenu});
            resources.ApplyResources(this.baoCáoToolStripMenuItem, "baoCáoToolStripMenuItem");
            this.baoCáoToolStripMenuItem.Name = "baoCáoToolStripMenuItem";
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
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(216)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
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
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhânCôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phanCongMenu;
        private System.Windows.Forms.ToolStripMenuItem caTrucMenu;
        private System.Windows.Forms.ToolStripMenuItem nhaCungCapMenu;
    }
}

