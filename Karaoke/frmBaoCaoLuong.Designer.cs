namespace Karaoke
{
	partial class frmBaoCaoLuong
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
			this.crBaoCaoLuong = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.rpBangLuong1 = new Karaoke.rpBangLuongChiTietNhanVien();
			this.cbDanhSachNhanVien = new System.Windows.Forms.ComboBox();
			this.cbThangLuong = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// crBaoCaoLuong
			// 
			this.crBaoCaoLuong.ActiveViewIndex = -1;
			this.crBaoCaoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.crBaoCaoLuong.Cursor = System.Windows.Forms.Cursors.Default;
			this.crBaoCaoLuong.Location = new System.Drawing.Point(13, 72);
			this.crBaoCaoLuong.Name = "crBaoCaoLuong";
			this.crBaoCaoLuong.Size = new System.Drawing.Size(1037, 565);
			this.crBaoCaoLuong.TabIndex = 0;
			// 
			// cbDanhSachNhanVien
			// 
			this.cbDanhSachNhanVien.FormattingEnabled = true;
			this.cbDanhSachNhanVien.Location = new System.Drawing.Point(272, 24);
			this.cbDanhSachNhanVien.Name = "cbDanhSachNhanVien";
			this.cbDanhSachNhanVien.Size = new System.Drawing.Size(121, 21);
			this.cbDanhSachNhanVien.TabIndex = 1;
			// 
			// cbThangLuong
			// 
			this.cbThangLuong.FormattingEnabled = true;
			this.cbThangLuong.Location = new System.Drawing.Point(462, 23);
			this.cbThangLuong.Name = "cbThangLuong";
			this.cbThangLuong.Size = new System.Drawing.Size(121, 21);
			this.cbThangLuong.TabIndex = 2;
			// 
			// frmBaoCaoLuong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1051, 643);
			this.Controls.Add(this.cbThangLuong);
			this.Controls.Add(this.cbDanhSachNhanVien);
			this.Controls.Add(this.crBaoCaoLuong);
			this.Name = "frmBaoCaoLuong";
			this.Text = "frmBaoCaoLuong";
			this.Load += new System.EventHandler(this.frmBaoCaoLuong_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private CrystalDecisions.Windows.Forms.CrystalReportViewer crBaoCaoLuong;
		private rpBangLuongChiTietNhanVien rpBangLuong1;
		private System.Windows.Forms.ComboBox cbDanhSachNhanVien;
		private System.Windows.Forms.ComboBox cbThangLuong;
	}
}