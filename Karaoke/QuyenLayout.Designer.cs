namespace Karaoke
{
    partial class QuyenLayout
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTenQuyen = new System.Windows.Forms.Label();
            this.chkQuyen = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbTenQuyen
            // 
            this.lbTenQuyen.AutoSize = true;
            this.lbTenQuyen.Location = new System.Drawing.Point(53, 55);
            this.lbTenQuyen.Name = "lbTenQuyen";
            this.lbTenQuyen.Size = new System.Drawing.Size(51, 20);
            this.lbTenQuyen.TabIndex = 0;
            this.lbTenQuyen.Text = "label1";
            // 
            // chkQuyen
            // 
            this.chkQuyen.AutoSize = true;
            this.chkQuyen.Location = new System.Drawing.Point(231, 54);
            this.chkQuyen.Name = "chkQuyen";
            this.chkQuyen.Size = new System.Drawing.Size(113, 24);
            this.chkQuyen.TabIndex = 1;
            this.chkQuyen.Text = "checkBox1";
            this.chkQuyen.UseVisualStyleBackColor = true;
            // 
            // QuyenLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkQuyen);
            this.Controls.Add(this.lbTenQuyen);
            this.Name = "QuyenLayout";
            this.Size = new System.Drawing.Size(433, 109);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbTenQuyen;
        public System.Windows.Forms.CheckBox chkQuyen;
    }
}
