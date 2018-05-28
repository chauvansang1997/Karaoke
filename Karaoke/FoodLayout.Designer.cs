namespace Karaoke
{
    partial class FoodLayout
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
            this.txtPrice = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imgFood = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgFood)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.AutoSize = true;
            this.txtPrice.Location = new System.Drawing.Point(64, 110);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(43, 13);
            this.txtPrice.TabIndex = 0;
            this.txtPrice.Text = "100000";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(3, 110);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(36, 13);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Donut";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "VNĐ";
            // 
            // imgFood
            // 
            this.imgFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgFood.BackgroundImage = global::Karaoke.Properties.Resources.donut__1_;
            this.imgFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgFood.Location = new System.Drawing.Point(3, 3);
            this.imgFood.Name = "imgFood";
            this.imgFood.Size = new System.Drawing.Size(140, 101);
            this.imgFood.TabIndex = 1;
            this.imgFood.TabStop = false;
            // 
            // FoodLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.imgFood);
            this.Controls.Add(this.txtPrice);
            this.Name = "FoodLayout";
            this.Size = new System.Drawing.Size(146, 129);
            ((System.ComponentModel.ISupportInitialize)(this.imgFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label txtPrice;
        public System.Windows.Forms.PictureBox imgFood;
        public System.Windows.Forms.Label txtName;
        public System.Windows.Forms.Label label1;
    }
}
