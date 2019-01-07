namespace Karaoke.GUI_BaoCaoDoanhThu
{
	partial class frmBaoCaoDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoDoanhThu));
            this.crBaoCaoDoanhThu = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.btnThucThi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crBaoCaoDoanhThu
            // 
            this.crBaoCaoDoanhThu.ActiveViewIndex = -1;
            this.crBaoCaoDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crBaoCaoDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crBaoCaoDoanhThu.Cursor = System.Windows.Forms.Cursors.Default;
            this.crBaoCaoDoanhThu.Location = new System.Drawing.Point(0, 80);
            this.crBaoCaoDoanhThu.Name = "crBaoCaoDoanhThu";
            this.crBaoCaoDoanhThu.Size = new System.Drawing.Size(1097, 565);
            this.crBaoCaoDoanhThu.TabIndex = 0;
            this.crBaoCaoDoanhThu.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // cbThang
            // 
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Location = new System.Drawing.Point(383, 32);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(121, 21);
            this.cbThang.TabIndex = 1;
            // 
            // btnThucThi
            // 
            this.btnThucThi.Location = new System.Drawing.Point(534, 32);
            this.btnThucThi.Name = "btnThucThi";
            this.btnThucThi.Size = new System.Drawing.Size(75, 23);
            this.btnThucThi.TabIndex = 2;
            this.btnThucThi.Text = "Thực thi";
            this.btnThucThi.UseVisualStyleBackColor = true;
            this.btnThucThi.Click += new System.EventHandler(this.btnThucThi_Click);
            // 
            // frmBaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 643);
            this.Controls.Add(this.btnThucThi);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.crBaoCaoDoanhThu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBaoCaoDoanhThu";
            this.Text = "Báo cáo doanh thu";
            this.Load += new System.EventHandler(this.frmBaoCaoDoanhThu_Load);
            this.ResumeLayout(false);

		}

		#endregion

		private CrystalDecisions.Windows.Forms.CrystalReportViewer crBaoCaoDoanhThu;
		private System.Windows.Forms.ComboBox cbThang;
		private System.Windows.Forms.Button btnThucThi;
	}
}