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
            this.imgFood = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgFood)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.AutoSize = true;
            this.txtPrice.Location = new System.Drawing.Point(61, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(31, 13);
            this.txtPrice.TabIndex = 0;
            this.txtPrice.Text = "100$";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(24, 78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(32, 13);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Pizza";
            // 
            // imgFood
            // 
            this.imgFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgFood.BackgroundImage = global::Karaoke.Properties.Resources.go_first;
            this.imgFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgFood.Location = new System.Drawing.Point(16, 20);
            this.imgFood.Name = "imgFood";
            this.imgFood.Size = new System.Drawing.Size(65, 55);
            this.imgFood.TabIndex = 1;
            this.imgFood.TabStop = false;
            // 
            // FoodLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.imgFood);
            this.Controls.Add(this.txtPrice);
            this.Name = "FoodLayout";
            this.Size = new System.Drawing.Size(100, 100);
            ((System.ComponentModel.ISupportInitialize)(this.imgFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label txtPrice;
        public System.Windows.Forms.PictureBox imgFood;
        public System.Windows.Forms.Label txtName;
    }
}
