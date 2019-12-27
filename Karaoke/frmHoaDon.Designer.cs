using Karaoke.report;

namespace Karaoke
{
	partial class frmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.crBaoCaoLuong = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rpBangLuong1 = new Karaoke.report.rptBangLuongChiTietNhanVien();
            this.SuspendLayout();
            // 
            // crBaoCaoLuong
            // 
            this.crBaoCaoLuong.ActiveViewIndex = -1;
            this.crBaoCaoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.crBaoCaoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crBaoCaoLuong.Cursor = System.Windows.Forms.Cursors.Default;
            this.crBaoCaoLuong.Location = new System.Drawing.Point(26, 0);
            this.crBaoCaoLuong.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.crBaoCaoLuong.Name = "crBaoCaoLuong";
            this.crBaoCaoLuong.Size = new System.Drawing.Size(2072, 1287);
            this.crBaoCaoLuong.TabIndex = 0;
            this.crBaoCaoLuong.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2102, 1292);
            this.Controls.Add(this.crBaoCaoLuong);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmBaoCaoLuong_Load);
            this.ResumeLayout(false);

		}

		#endregion

		private CrystalDecisions.Windows.Forms.CrystalReportViewer crBaoCaoLuong;
		private rptBangLuongChiTietNhanVien rpBangLuong1;
	}
}