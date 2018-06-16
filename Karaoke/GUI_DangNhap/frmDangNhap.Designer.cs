namespace Karaoke.GUI_DangNhap
{
	partial class frmDangNhap
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.txtMatKhau = new System.Windows.Forms.TextBox();
			this.txtTenDangNhap = new System.Windows.Forms.TextBox();
			this.lblMatKhau = new System.Windows.Forms.Label();
			this.lblTenTK = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(-26, -17);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(204, 297);
			this.panel1.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Vni 13 Annabelle", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(37, 131);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 29);
			this.label1.TabIndex = 9;
			this.label1.Text = "Đăng nhập";
			// 
			// txtMatKhau
			// 
			this.txtMatKhau.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMatKhau.Location = new System.Drawing.Point(188, 170);
			this.txtMatKhau.Margin = new System.Windows.Forms.Padding(2);
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.PasswordChar = '●';
			this.txtMatKhau.Size = new System.Drawing.Size(269, 27);
			this.txtMatKhau.TabIndex = 12;
			// 
			// txtTenDangNhap
			// 
			this.txtTenDangNhap.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenDangNhap.Location = new System.Drawing.Point(188, 67);
			this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(2);
			this.txtTenDangNhap.Name = "txtTenDangNhap";
			this.txtTenDangNhap.Size = new System.Drawing.Size(269, 27);
			this.txtTenDangNhap.TabIndex = 11;
			// 
			// lblMatKhau
			// 
			this.lblMatKhau.AutoSize = true;
			this.lblMatKhau.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMatKhau.Location = new System.Drawing.Point(188, 137);
			this.lblMatKhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblMatKhau.Name = "lblMatKhau";
			this.lblMatKhau.Size = new System.Drawing.Size(79, 19);
			this.lblMatKhau.TabIndex = 10;
			this.lblMatKhau.Text = "Mật khẩu:";
			// 
			// lblTenTK
			// 
			this.lblTenTK.AutoSize = true;
			this.lblTenTK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTenTK.Location = new System.Drawing.Point(188, 35);
			this.lblTenTK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblTenTK.Name = "lblTenTK";
			this.lblTenTK.Size = new System.Drawing.Size(122, 19);
			this.lblTenTK.TabIndex = 9;
			this.lblTenTK.Text = "Tên đăng nhập:";
			// 
			// btnOK
			// 
			this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
			this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOK.ForeColor = System.Drawing.Color.White;
			this.btnOK.Location = new System.Drawing.Point(270, 233);
			this.btnOK.Margin = new System.Windows.Forms.Padding(2);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(100, 36);
			this.btnOK.TabIndex = 8;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = false;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// frmDangNhap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(460, 284);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txtMatKhau);
			this.Controls.Add(this.txtTenDangNhap);
			this.Controls.Add(this.lblMatKhau);
			this.Controls.Add(this.lblTenTK);
			this.Controls.Add(this.btnOK);
			this.Name = "frmDangNhap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmDangNhap";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMatKhau;
		private System.Windows.Forms.TextBox txtTenDangNhap;
		private System.Windows.Forms.Label lblMatKhau;
		private System.Windows.Forms.Label lblTenTK;
		private System.Windows.Forms.Button btnOK;
	}
}