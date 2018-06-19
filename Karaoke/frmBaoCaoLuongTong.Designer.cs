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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoLuongTong));
            this.crLuongTong = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cbThangLuong = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThucThi = new System.Windows.Forms.Button();
            this.lbXemChiTiet = new System.Windows.Forms.Label();
            this.rpLuongTong1 = new Karaoke.rpLuongTong();
            this.SuspendLayout();
            // 
            // crLuongTong
            // 
            this.crLuongTong.ActiveViewIndex = -1;
            this.crLuongTong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.crLuongTong.AutoSize = true;
            this.crLuongTong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crLuongTong.Cursor = System.Windows.Forms.Cursors.Default;
            this.crLuongTong.Location = new System.Drawing.Point(0, 71);
            this.crLuongTong.Name = "crLuongTong";
            this.crLuongTong.Size = new System.Drawing.Size(1034, 558);
            this.crLuongTong.TabIndex = 0;
            this.crLuongTong.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // cbThangLuong
            // 
            this.cbThangLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbThangLuong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThangLuong.FormattingEnabled = true;
            this.cbThangLuong.Location = new System.Drawing.Point(391, 22);
            this.cbThangLuong.Name = "cbThangLuong";
            this.cbThangLuong.Size = new System.Drawing.Size(121, 27);
            this.cbThangLuong.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn tháng để xem lương";
            // 
            // btnThucThi
            // 
            this.btnThucThi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThucThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
            this.btnThucThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThucThi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThucThi.ForeColor = System.Drawing.Color.White;
            this.btnThucThi.Location = new System.Drawing.Point(533, 22);
            this.btnThucThi.Name = "btnThucThi";
            this.btnThucThi.Size = new System.Drawing.Size(116, 29);
            this.btnThucThi.TabIndex = 3;
            this.btnThucThi.Text = "Thực thi";
            this.btnThucThi.UseVisualStyleBackColor = false;
            this.btnThucThi.Click += new System.EventHandler(this.btnThucThi_Click);
            // 
            // lbXemChiTiet
            // 
            this.lbXemChiTiet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbXemChiTiet.AutoSize = true;
            this.lbXemChiTiet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbXemChiTiet.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXemChiTiet.Location = new System.Drawing.Point(666, 27);
            this.lbXemChiTiet.Name = "lbXemChiTiet";
            this.lbXemChiTiet.Size = new System.Drawing.Size(92, 19);
            this.lbXemChiTiet.TabIndex = 4;
            this.lbXemChiTiet.Text = "Xem chi tiết";
            this.lbXemChiTiet.Click += new System.EventHandler(this.lbXemChiTiet_Click);
            // 
            // frmBaoCaoLuongTong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 638);
            this.Controls.Add(this.lbXemChiTiet);
            this.Controls.Add(this.btnThucThi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbThangLuong);
            this.Controls.Add(this.crLuongTong);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBaoCaoLuongTong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo tổng lương";
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