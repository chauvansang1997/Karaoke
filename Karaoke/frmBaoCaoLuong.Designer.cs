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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoLuong));
			this.crBaoCaoLuong = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.cbDanhSachNhanVien = new System.Windows.Forms.ComboBox();
			this.cbThangLuong = new System.Windows.Forms.ComboBox();
			this.btnThucThiBCCTL = new System.Windows.Forms.Button();
			this.rpBangLuong1 = new Karaoke.rpBangLuongChiTietNhanVien();
			this.SuspendLayout();
			// 
			// crBaoCaoLuong
			// 
			this.crBaoCaoLuong.ActiveViewIndex = -1;
			this.crBaoCaoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.crBaoCaoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.crBaoCaoLuong.Cursor = System.Windows.Forms.Cursors.Default;
			this.crBaoCaoLuong.Location = new System.Drawing.Point(13, 65);
			this.crBaoCaoLuong.Name = "crBaoCaoLuong";
			this.crBaoCaoLuong.Size = new System.Drawing.Size(1037, 605);
			this.crBaoCaoLuong.TabIndex = 0;
			this.crBaoCaoLuong.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
			// 
			// cbDanhSachNhanVien
			// 
			this.cbDanhSachNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.cbDanhSachNhanVien.FormattingEnabled = true;
			this.cbDanhSachNhanVien.Location = new System.Drawing.Point(272, 24);
			this.cbDanhSachNhanVien.Name = "cbDanhSachNhanVien";
			this.cbDanhSachNhanVien.Size = new System.Drawing.Size(121, 21);
			this.cbDanhSachNhanVien.TabIndex = 1;
			// 
			// cbThangLuong
			// 
			this.cbThangLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.cbThangLuong.FormattingEnabled = true;
			this.cbThangLuong.Location = new System.Drawing.Point(462, 23);
			this.cbThangLuong.Name = "cbThangLuong";
			this.cbThangLuong.Size = new System.Drawing.Size(121, 21);
			this.cbThangLuong.TabIndex = 2;
			// 
			// btnThucThiBCCTL
			// 
			this.btnThucThiBCCTL.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnThucThiBCCTL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
			this.btnThucThiBCCTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThucThiBCCTL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThucThiBCCTL.ForeColor = System.Drawing.Color.White;
			this.btnThucThiBCCTL.Location = new System.Drawing.Point(612, 17);
			this.btnThucThiBCCTL.Name = "btnThucThiBCCTL";
			this.btnThucThiBCCTL.Size = new System.Drawing.Size(92, 29);
			this.btnThucThiBCCTL.TabIndex = 3;
			this.btnThucThiBCCTL.Text = "Thực thi";
			this.btnThucThiBCCTL.UseVisualStyleBackColor = false;
			this.btnThucThiBCCTL.Click += new System.EventHandler(this.btnThucThiBCCTL_Click);
			// 
			// frmBaoCaoLuong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1051, 672);
			this.Controls.Add(this.btnThucThiBCCTL);
			this.Controls.Add(this.cbThangLuong);
			this.Controls.Add(this.cbDanhSachNhanVien);
			this.Controls.Add(this.crBaoCaoLuong);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmBaoCaoLuong";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chi tiết lương";
			this.Load += new System.EventHandler(this.frmBaoCaoLuong_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private CrystalDecisions.Windows.Forms.CrystalReportViewer crBaoCaoLuong;
		private rpBangLuongChiTietNhanVien rpBangLuong1;
		private System.Windows.Forms.ComboBox cbDanhSachNhanVien;
		private System.Windows.Forms.ComboBox cbThangLuong;
		private System.Windows.Forms.Button btnThucThiBCCTL;
	}
}