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
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryImagePictureBox)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoryImagePictureBox
            // 
            this.CategoryImagePictureBox.BorderRadius = 25;
            this.CategoryImagePictureBox.ImageRotate = 0F;
            this.CategoryImagePictureBox.Location = new System.Drawing.Point(20, 10);
            this.CategoryImagePictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CategoryImagePictureBox.Name = "CategoryImagePictureBox";
            this.CategoryImagePictureBox.Size = new System.Drawing.Size(126, 120);
            this.CategoryImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CategoryImagePictureBox.TabIndex = 0;
            this.CategoryImagePictureBox.TabStop = false;
            // 
            // CategoryNameLabel
            // 
            this.CategoryNameLabel.AutoSize = true;
            this.CategoryNameLabel.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.CategoryNameLabel.Location = new System.Drawing.Point(35, 133);
            this.CategoryNameLabel.Name = "CategoryNameLabel";
            this.CategoryNameLabel.Size = new System.Drawing.Size(95, 38);
            this.CategoryNameLabel.TabIndex = 1;
            this.CategoryNameLabel.Text = "Meal";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.guna2GradientPanel1.BorderRadius = 25;
            this.guna2GradientPanel1.BorderThickness = 2;
            this.guna2GradientPanel1.Controls.Add(this.CategoryNameLabel);
            this.guna2GradientPanel1.Controls.Add(this.CategoryImagePictureBox);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(34, 3);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(166, 178);
            this.guna2GradientPanel1.TabIndex = 2;
            // 
            // DisplayCategoryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2GradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DisplayCategoryUserControl";
            this.Size = new System.Drawing.Size(236, 190);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryImagePictureBox)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox CategoryImagePictureBox;
        private System.Windows.Forms.Label CategoryNameLabel;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
    }
}
