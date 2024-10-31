namespace Fastfood_Kiosk_V0.Views.UserControls
{
    partial class DisplayCategoryUserControl
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
            this.CategoryImagePictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.CategoryNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryImagePictureBox
            // 
            this.CategoryImagePictureBox.ImageRotate = 0F;
            this.CategoryImagePictureBox.Location = new System.Drawing.Point(11, 11);
            this.CategoryImagePictureBox.Name = "CategoryImagePictureBox";
            this.CategoryImagePictureBox.Size = new System.Drawing.Size(288, 246);
            this.CategoryImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CategoryImagePictureBox.TabIndex = 0;
            this.CategoryImagePictureBox.TabStop = false;
            // 
            // CategoryNameLabel
            // 
            this.CategoryNameLabel.AutoSize = true;
            this.CategoryNameLabel.Location = new System.Drawing.Point(16, 274);
            this.CategoryNameLabel.Name = "CategoryNameLabel";
            this.CategoryNameLabel.Size = new System.Drawing.Size(44, 16);
            this.CategoryNameLabel.TabIndex = 1;
            this.CategoryNameLabel.Text = "label1";
            // 
            // DisplayCategoryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CategoryNameLabel);
            this.Controls.Add(this.CategoryImagePictureBox);
            this.Name = "DisplayCategoryUserControl";
            this.Size = new System.Drawing.Size(310, 310);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox CategoryImagePictureBox;
        private System.Windows.Forms.Label CategoryNameLabel;
    }
}
