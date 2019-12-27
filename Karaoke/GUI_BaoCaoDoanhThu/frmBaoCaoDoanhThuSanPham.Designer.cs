namespace Karaoke.GUI_BaoCaoDoanhThu
{
    partial class frmBaoCaoDoanhThuSanPham
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
            this.crBaoCaoDoanhThu = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crBaoCaoDoanhThu
            // 
            this.crBaoCaoDoanhThu.ActiveViewIndex = -1;
            this.crBaoCaoDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crBaoCaoDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crBaoCaoDoanhThu.Cursor = System.Windows.Forms.Cursors.Default;
            this.crBaoCaoDoanhThu.Location = new System.Drawing.Point(0, 6);
            this.crBaoCaoDoanhThu.Margin = new System.Windows.Forms.Padding(6);
            this.crBaoCaoDoanhThu.Name = "crBaoCaoDoanhThu";
            this.crBaoCaoDoanhThu.Size = new System.Drawing.Size(2192, 1233);
            this.crBaoCaoDoanhThu.TabIndex = 0;
            this.crBaoCaoDoanhThu.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmBaoCaoDoanhThuSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2190, 1237);
            this.Controls.Add(this.crBaoCaoDoanhThu);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmBaoCaoDoanhThuSanPham";
            this.Text = "Báo cáo doanh thu sản phẩm";
            this.Load += new System.EventHandler(this.frmBaoCaoDoanhThuSanPham_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crBaoCaoDoanhThu;
    }
}