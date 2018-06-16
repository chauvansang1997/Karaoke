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
			this.khachHangMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.phanCongMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýNguyênLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nhapKho = new System.Windows.Forms.ToolStripMenuItem();
			this.suaNguyenLieu = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nhapKhoSanPham = new System.Windows.Forms.ToolStripMenuItem();
			this.suaSanPham = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýThiếtBịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nhậpKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.chỉnhSửaThiếtBịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.baoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.baoCaoTonKho = new System.Windows.Forms.ToolStripMenuItem();
			this.baoCaoDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
			this.phanCongItem = new System.Windows.Forms.ToolStripMenuItem();
			this.caTrucItem = new System.Windows.Forms.ToolStripMenuItem();
			this.baoCaoLuongMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNguyênLiệuToolStripMenuItem,
            this.quảnLýSảnPhẩmToolStripMenuItem,
            this.quảnLýThiếtBịToolStripMenuItem,
            this.tiếpNhậnKháchHàngToolStripMenuItem,
            this.baoCáoToolStripMenuItem,
            this.nhanVienMenu,
            this.khachHangMenu,
            this.phanCongMenu});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1028, 25);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tiếpNhậnKháchHàngToolStripMenuItem
			// 
			this.tiếpNhậnKháchHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhanDatTiecMenu,
            this.datPhongMenu});
			this.tiếpNhậnKháchHàngToolStripMenuItem.Name = "tiếpNhậnKháchHàngToolStripMenuItem";
			this.tiếpNhậnKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(137, 21);
			this.tiếpNhậnKháchHàngToolStripMenuItem.Text = "Tiếp nhận khách hàng";
			// 
			// nhanDatTiecMenu
			// 
			this.nhanDatTiecMenu.Name = "nhanDatTiecMenu";
			this.nhanDatTiecMenu.Size = new System.Drawing.Size(145, 22);
			this.nhanDatTiecMenu.Text = "Nhận đặt tiệc";
			this.nhanDatTiecMenu.Click += new System.EventHandler(this.nhanDatTiecMenu_Click);
			// 
			// datPhongMenu
			// 
			this.datPhongMenu.Name = "datPhongMenu";
			this.datPhongMenu.Size = new System.Drawing.Size(145, 22);
			this.datPhongMenu.Text = "Đặt phòng";
			this.datPhongMenu.Click += new System.EventHandler(this.datPhongMenu_Click);
			// 
			// nhanVienMenu
			// 
			this.nhanVienMenu.Name = "nhanVienMenu";
			this.nhanVienMenu.Size = new System.Drawing.Size(115, 21);
			this.nhanVienMenu.Text = "Quản lý nhân viên";
			this.nhanVienMenu.Click += new System.EventHandler(this.nhanVienMenu_Click);
			// 
			// khachHangMenu
			// 
			this.khachHangMenu.Name = "khachHangMenu";
			this.khachHangMenu.Size = new System.Drawing.Size(125, 21);
			this.khachHangMenu.Text = "Quản lý khách hàng";
			this.khachHangMenu.Click += new System.EventHandler(this.khachHangMenu_Click);
			// 
			// phanCongMenu
			// 
			this.phanCongMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phanCongItem,
            this.caTrucItem});
			this.phanCongMenu.Name = "phanCongMenu";
			this.phanCongMenu.Size = new System.Drawing.Size(120, 21);
			this.phanCongMenu.Text = "Quản lý phân công";
			// 
			// quảnLýNguyênLiệuToolStripMenuItem
			// 
			this.quảnLýNguyênLiệuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhapKho,
            this.suaNguyenLieu,
            this.nhapMonAnMenu});
            this.quảnLýNguyênLiệuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýNguyênLiệuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýNguyênLiệuToolStripMenuItem.Image")));
            this.quảnLýNguyênLiệuToolStripMenuItem.Name = "quảnLýNguyênLiệuToolStripMenuItem";
            this.quảnLýNguyênLiệuToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.quảnLýNguyênLiệuToolStripMenuItem.Text = "&Quản lý nguyên liệu";
            // 
            // nhapKho
            // 
            this.nhapKho.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhapKho.Image = ((System.Drawing.Image)(resources.GetObject("nhapKho.Image")));
            this.nhapKho.Name = "nhapKho";
            this.nhapKho.Size = new System.Drawing.Size(222, 24);
            this.nhapKho.Text = "Nhập kho";
            this.nhapKho.Click += new System.EventHandler(this.nhapKho_Click);
            // 
            // suaNguyenLieu
            // 
            this.suaNguyenLieu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suaNguyenLieu.Image = ((System.Drawing.Image)(resources.GetObject("suaNguyenLieu.Image")));
            this.suaNguyenLieu.Name = "suaNguyenLieu";
            this.suaNguyenLieu.Size = new System.Drawing.Size(222, 24);
            this.suaNguyenLieu.Text = "Chỉnh sửa nguyên liệu";
            this.suaNguyenLieu.Click += new System.EventHandler(this.suaNguyenLieu_Click);
            // 
            // nhapMonAnMenu
            // 
            this.nhapMonAnMenu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhapMonAnMenu.Name = "nhapMonAnMenu";
            this.nhapMonAnMenu.Size = new System.Drawing.Size(222, 24);
            this.nhapMonAnMenu.Text = "Nhập món ăn";
            this.nhapMonAnMenu.Click += new System.EventHandler(this.nhapMonAnMenu_Click);
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            this.quảnLýSảnPhẩmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhapKhoSanPham,
            this.suaSanPham});
            this.quảnLýSảnPhẩmToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýSảnPhẩmToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýSảnPhẩmToolStripMenuItem.Image")));
            this.quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            this.quảnLýSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản lý sản phẩm";
            // 
            // nhapKhoSanPham
            // 
            this.nhapKhoSanPham.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhapKhoSanPham.Image = ((System.Drawing.Image)(resources.GetObject("nhapKhoSanPham.Image")));
            this.nhapKhoSanPham.Name = "nhapKhoSanPham";
            this.nhapKhoSanPham.Size = new System.Drawing.Size(210, 24);
            this.nhapKhoSanPham.Text = "Nhập kho";
            this.nhapKhoSanPham.Click += new System.EventHandler(this.nhapKhoSanPham_Click);
            // 
            // suaSanPham
            // 
            this.suaSanPham.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suaSanPham.Image = ((System.Drawing.Image)(resources.GetObject("suaSanPham.Image")));
            this.suaSanPham.Name = "suaSanPham";
            this.suaSanPham.Size = new System.Drawing.Size(210, 24);
            this.suaSanPham.Text = "Chỉnh sửa sản phẩm";
            this.suaSanPham.Click += new System.EventHandler(this.suaSanPham_Click);
            // 
            // quảnLýThiếtBịToolStripMenuItem
            // 
            this.quảnLýThiếtBịToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpKhoToolStripMenuItem,
            this.chỉnhSửaThiếtBịToolStripMenuItem});
			this.quảnLýThiếtBịToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quảnLýThiếtBịToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýThiếtBịToolStripMenuItem.Image")));
			this.quảnLýThiếtBịToolStripMenuItem.Name = "quảnLýThiếtBịToolStripMenuItem";
			this.quảnLýThiếtBịToolStripMenuItem.Size = new System.Drawing.Size(124, 21);
			this.quảnLýThiếtBịToolStripMenuItem.Text = "Quản lý thiết bị";
			// 
			// nhậpKhoToolStripMenuItem
			// 
			this.nhậpKhoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nhậpKhoToolStripMenuItem.Image")));
			this.nhậpKhoToolStripMenuItem.Name = "nhậpKhoToolStripMenuItem";
			this.nhậpKhoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.nhậpKhoToolStripMenuItem.Text = "Nhập kho";
			// 
			// chỉnhSửaThiếtBịToolStripMenuItem
			// 
			this.chỉnhSửaThiếtBịToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("chỉnhSửaThiếtBịToolStripMenuItem.Image")));
			this.chỉnhSửaThiếtBịToolStripMenuItem.Name = "chỉnhSửaThiếtBịToolStripMenuItem";
			this.chỉnhSửaThiếtBịToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.chỉnhSửaThiếtBịToolStripMenuItem.Text = "Chỉnh sửa thiết bị";
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
			// phanCongItem
			// 
			this.phanCongItem.Name = "phanCongItem";
			this.phanCongItem.Size = new System.Drawing.Size(180, 22);
			this.phanCongItem.Text = "Phân công";
			this.phanCongItem.Click += new System.EventHandler(this.phanCongItem_Click);
			// 
			// caTrucItem
			// 
			this.caTrucItem.Name = "caTrucItem";
			this.caTrucItem.Size = new System.Drawing.Size(180, 22);
			this.caTrucItem.Text = "Ca trực";
			this.caTrucItem.Click += new System.EventHandler(this.caTrucItem_Click);
			// 
			// baoCaoLuongMenu
			// 
			this.baoCaoLuongMenu.Image = global::Karaoke.Properties.Resources.salary;
			this.baoCaoLuongMenu.Name = "baoCaoLuongMenu";
			this.baoCaoLuongMenu.Size = new System.Drawing.Size(186, 22);
			this.baoCaoLuongMenu.Text = "Báo cáo lương";
			this.baoCaoLuongMenu.Click += new System.EventHandler(this.baoCaoLuongMenu_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(216)))), ((int)(((byte)(233)))));
			this.ClientSize = new System.Drawing.Size(1028, 379);
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
        private System.Windows.Forms.ToolStripMenuItem nhậpKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaThiếtBịToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiếpNhậnKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhanDatTiecMenu;
        private System.Windows.Forms.ToolStripMenuItem datPhongMenu;
        private System.Windows.Forms.ToolStripMenuItem khachHangMenu;
		private System.Windows.Forms.ToolStripMenuItem phanCongMenu;
		private System.Windows.Forms.ToolStripMenuItem phanCongItem;
		private System.Windows.Forms.ToolStripMenuItem caTrucItem;
		private System.Windows.Forms.ToolStripMenuItem baoCaoLuongMenu;
	}
}

