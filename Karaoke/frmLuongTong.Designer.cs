namespace Karaoke
{
	partial class frmLuongTong
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
			this.SuspendLayout();
			// 
			// crLuongTong
			// 
			this.crLuongTong.ActiveViewIndex = -1;
			this.crLuongTong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.crLuongTong.Cursor = System.Windows.Forms.Cursors.Default;
			this.crLuongTong.Location = new System.Drawing.Point(0, 67);
			this.crLuongTong.Name = "crLuongTong";
			this.crLuongTong.Size = new System.Drawing.Size(803, 525);
			this.crLuongTong.TabIndex = 0;
			// 
			// frmLuongTong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 595);
			this.Controls.Add(this.crLuongTong);
			this.Name = "frmLuongTong";
			this.Text = "frmLuongTong";
			this.ResumeLayout(false);

		}

		#endregion

		private CrystalDecisions.Windows.Forms.CrystalReportViewer crLuongTong;
	}
}