namespace Karaoke
{
	partial class frmBaoCaoLuongTong
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
			this.crLuongTong = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.cbThangLuong = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnThucThi = new System.Windows.Forms.Button();
			this.rpLuongTong1 = new Karaoke.rpLuongTong();
			this.lbXemChiTiet = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// crLuongTong
			// 
			this.crLuongTong.ActiveViewIndex = -1;
			this.crLuongTong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.crLuongTong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.crLuongTong.Cursor = System.Windows.Forms.Cursors.Default;
			this.crLuongTong.Location = new System.Drawing.Point(0, 67);
			this.crLuongTong.Name = "crLuongTong";
			this.crLuongTong.Size = new System.Drawing.Size(1034, 632);
			this.crLuongTong.TabIndex = 0;
			this.crLuongTong.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
			// 
			// cbThangLuong
			// 
			this.cbThangLuong.FormattingEnabled = true;
			this.cbThangLuong.Location = new System.Drawing.Point(328, 26);
			this.cbThangLuong.Name = "cbThangLuong";
			this.cbThangLuong.Size = new System.Drawing.Size(121, 21);
			this.cbThangLuong.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(193, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Chọn tháng để xem lương";
			// 
			// btnThucThi
			// 
			this.btnThucThi.Location = new System.Drawing.Point(471, 26);
			this.btnThucThi.Name = "btnThucThi";
			this.btnThucThi.Size = new System.Drawing.Size(75, 23);
			this.btnThucThi.TabIndex = 3;
			this.btnThucThi.Text = "Thực thi";
			this.btnThucThi.UseVisualStyleBackColor = true;
			this.btnThucThi.Click += new System.EventHandler(this.btnThucThi_Click);
			// 
			// lbXemChiTiet
			// 
			this.lbXemChiTiet.AutoSize = true;
			this.lbXemChiTiet.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbXemChiTiet.Location = new System.Drawing.Point(593, 31);
			this.lbXemChiTiet.Name = "lbXemChiTiet";
			this.lbXemChiTiet.Size = new System.Drawing.Size(142, 13);
			this.lbXemChiTiet.TabIndex = 4;
			this.lbXemChiTiet.Text = "Bấm vào đây để xem chi tiết";
			this.lbXemChiTiet.Click += new System.EventHandler(this.lbXemChiTiet_Click);
			// 
			// frmBaoCaoLuongTong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1037, 711);
			this.Controls.Add(this.lbXemChiTiet);
			this.Controls.Add(this.btnThucThi);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbThangLuong);
			this.Controls.Add(this.crLuongTong);
			this.Name = "frmBaoCaoLuongTong";
			this.Text = "frmLuongTong";
			this.Load += new System.EventHandler(this.frmBaoCaoLuongTong_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CrystalDecisions.Windows.Forms.CrystalReportViewer crLuongTong;
		private rpLuongTong rpLuongTong1;
		private System.Windows.Forms.ComboBox cbThangLuong;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnThucThi;
		public System.Windows.Forms.Label lbXemChiTiet;
	}
}