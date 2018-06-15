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
            this.quảnLýSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhapKhoSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.suaSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoTonKho = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýThiếtBịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaThiếtBịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNguyênLiệuToolStripMenuItem,
            this.quảnLýSảnPhẩmToolStripMenuItem,
            this.quảnLýThiếtBịToolStripMenuItem,
            this.baoCáoToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýNguyênLiệuToolStripMenuItem
            // 
            this.quảnLýNguyênLiệuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhapKho,
            this.suaNguyenLieu});
            this.quảnLýNguyênLiệuToolStripMenuItem.Name = "quảnLýNguyênLiệuToolStripMenuItem";
            this.quảnLýNguyênLiệuToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.quảnLýNguyênLiệuToolStripMenuItem.Text = "&Quản lý nguyên liệu";
            // 
            // nhapKho
            // 
            this.nhapKho.Name = "nhapKho";
            this.nhapKho.Size = new System.Drawing.Size(192, 22);
            this.nhapKho.Text = "Nhập kho";
            this.nhapKho.Click += new System.EventHandler(this.nhapKho_Click);
            // 
            // suaNguyenLieu
            // 
            this.suaNguyenLieu.Name = "suaNguyenLieu";
            this.suaNguyenLieu.Size = new System.Drawing.Size(192, 22);
            this.suaNguyenLieu.Text = "Chỉnh sửa nguyên liệu";
            this.suaNguyenLieu.Click += new System.EventHandler(this.suaNguyenLieu_Click);
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            this.quảnLýSảnPhẩmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhapKhoSanPham,
            this.suaSanPham});
            this.quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            this.quảnLýSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản lý sản phẩm";
            // 
            // nhapKhoSanPham
            // 
            this.nhapKhoSanPham.Name = "nhapKhoSanPham";
            this.nhapKhoSanPham.Size = new System.Drawing.Size(182, 22);
            this.nhapKhoSanPham.Text = "Nhập kho";
            this.nhapKhoSanPham.Click += new System.EventHandler(this.nhapKhoSanPham_Click);
            // 
            // suaSanPham
            // 
            this.suaSanPham.Name = "suaSanPham";
            this.suaSanPham.Size = new System.Drawing.Size(182, 22);
            this.suaSanPham.Text = "Chỉnh sửa sản phẩm";
            this.suaSanPham.Click += new System.EventHandler(this.suaSanPham_Click);
            // 
            // baoCáoToolStripMenuItem
            // 
            this.baoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baoCaoTonKho,
            this.baoCaoDoanhThu});
            this.baoCáoToolStripMenuItem.Name = "baoCáoToolStripMenuItem";
            this.baoCáoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.baoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // baoCaoTonKho
            // 
            this.baoCaoTonKho.Name = "baoCaoTonKho";
            this.baoCaoTonKho.Size = new System.Drawing.Size(174, 22);
            this.baoCaoTonKho.Text = "Báo cáo tồn kho";
            this.baoCaoTonKho.Click += new System.EventHandler(this.baoCaoTonKho_Click);
            // 
            // baoCaoDoanhThu
            // 
            this.baoCaoDoanhThu.Name = "baoCaoDoanhThu";
            this.baoCaoDoanhThu.Size = new System.Drawing.Size(174, 22);
            this.baoCaoDoanhThu.Text = "Báo cáo doanh thu";
            this.baoCaoDoanhThu.Click += new System.EventHandler(this.baoCaoDoanhThu_Click);
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            // 
            // quảnLýThiếtBịToolStripMenuItem
            // 
            this.quảnLýThiếtBịToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpKhoToolStripMenuItem,
            this.chỉnhSửaThiếtBịToolStripMenuItem});
            this.quảnLýThiếtBịToolStripMenuItem.Name = "quảnLýThiếtBịToolStripMenuItem";
            this.quảnLýThiếtBịToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.quảnLýThiếtBịToolStripMenuItem.Text = "Quản lý thiết bị";
            // 
            // nhậpKhoToolStripMenuItem
            // 
            this.nhậpKhoToolStripMenuItem.Name = "nhậpKhoToolStripMenuItem";
            this.nhậpKhoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.nhậpKhoToolStripMenuItem.Text = "Nhập kho";
            // 
            // chỉnhSửaThiếtBịToolStripMenuItem
            // 
            this.chỉnhSửaThiếtBịToolStripMenuItem.Name = "chỉnhSửaThiếtBịToolStripMenuItem";
            this.chỉnhSửaThiếtBịToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.chỉnhSửaThiếtBịToolStripMenuItem.Text = "Chỉnh sửa thiết bị";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(216)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(759, 379);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý Karaoke";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýThiếtBịToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaThiếtBịToolStripMenuItem;
    }
}

