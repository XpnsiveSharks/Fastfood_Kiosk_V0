namespace Fastfood_Kiosk_V0.Views.UserControls
{
    partial class DisplayMenuUserControl
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
            this.MenuPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.MenuPriceLabel = new System.Windows.Forms.Label();
            this.MenuNameLabel = new System.Windows.Forms.Label();
            this.MenuImagePictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.MenuPriceLabel);
            this.MenuPanel.Controls.Add(this.MenuNameLabel);
            this.MenuPanel.Controls.Add(this.MenuImagePictureBox);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(315, 320);
            this.MenuPanel.TabIndex = 0;
            // 
            // MenuPriceLabel
            // 
            this.MenuPriceLabel.AutoSize = true;
            this.MenuPriceLabel.Location = new System.Drawing.Point(10, 293);
            this.MenuPriceLabel.Name = "MenuPriceLabel";
            this.MenuPriceLabel.Size = new System.Drawing.Size(44, 16);
            this.MenuPriceLabel.TabIndex = 2;
            this.MenuPriceLabel.Text = "label2";
            // 
            // MenuNameLabel
            // 
            this.MenuNameLabel.AutoSize = true;
            this.MenuNameLabel.Location = new System.Drawing.Point(10, 256);
            this.MenuNameLabel.Name = "MenuNameLabel";
            this.MenuNameLabel.Size = new System.Drawing.Size(44, 16);
            this.MenuNameLabel.TabIndex = 1;
            this.MenuNameLabel.Text = "label1";
            // 
            // MenuImagePictureBox
            // 
            this.MenuImagePictureBox.ImageRotate = 0F;
            this.MenuImagePictureBox.Location = new System.Drawing.Point(3, 3);
            this.MenuImagePictureBox.Name = "MenuImagePictureBox";
            this.MenuImagePictureBox.Size = new System.Drawing.Size(309, 245);
            this.MenuImagePictureBox.TabIndex = 0;
            this.MenuImagePictureBox.TabStop = false;
            // 
            // DisplayMenuUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MenuPanel);
            this.Name = "DisplayMenuUserControl";
            this.Size = new System.Drawing.Size(315, 320);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuImagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel MenuPanel;
        private System.Windows.Forms.Label MenuPriceLabel;
        private System.Windows.Forms.Label MenuNameLabel;
        private Guna.UI2.WinForms.Guna2PictureBox MenuImagePictureBox;
    }
}
