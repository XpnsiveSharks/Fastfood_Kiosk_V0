namespace Fastfood_Kiosk_V0.Views
{
    partial class AddingCategoryView
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
            this.ImageCategoryPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.CategoryNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.UploadCategoryImageButton = new Guna.UI2.WinForms.Guna2Button();
            this.SaveCategoryButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCategoryPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageCategoryPictureBox
            // 
            this.ImageCategoryPictureBox.ImageRotate = 0F;
            this.ImageCategoryPictureBox.Location = new System.Drawing.Point(12, 12);
            this.ImageCategoryPictureBox.Name = "ImageCategoryPictureBox";
            this.ImageCategoryPictureBox.Size = new System.Drawing.Size(329, 241);
            this.ImageCategoryPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageCategoryPictureBox.TabIndex = 0;
            this.ImageCategoryPictureBox.TabStop = false;
            // 
            // CategoryNameTextBox
            // 
            this.CategoryNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CategoryNameTextBox.DefaultText = "";
            this.CategoryNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CategoryNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CategoryNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CategoryNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CategoryNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CategoryNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CategoryNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CategoryNameTextBox.Location = new System.Drawing.Point(12, 260);
            this.CategoryNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            this.CategoryNameTextBox.PasswordChar = '\0';
            this.CategoryNameTextBox.PlaceholderText = "";
            this.CategoryNameTextBox.SelectedText = "";
            this.CategoryNameTextBox.Size = new System.Drawing.Size(329, 42);
            this.CategoryNameTextBox.TabIndex = 1;
            // 
            // UploadCategoryImageButton
            // 
            this.UploadCategoryImageButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UploadCategoryImageButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UploadCategoryImageButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UploadCategoryImageButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UploadCategoryImageButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UploadCategoryImageButton.ForeColor = System.Drawing.Color.White;
            this.UploadCategoryImageButton.Location = new System.Drawing.Point(394, 260);
            this.UploadCategoryImageButton.Name = "UploadCategoryImageButton";
            this.UploadCategoryImageButton.Size = new System.Drawing.Size(210, 42);
            this.UploadCategoryImageButton.TabIndex = 2;
            this.UploadCategoryImageButton.Text = "Upload";
            this.UploadCategoryImageButton.Click += new System.EventHandler(this.UploadCategoryImageButton_Click);
            // 
            // SaveCategoryButton
            // 
            this.SaveCategoryButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveCategoryButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveCategoryButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveCategoryButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveCategoryButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SaveCategoryButton.ForeColor = System.Drawing.Color.White;
            this.SaveCategoryButton.Location = new System.Drawing.Point(231, 337);
            this.SaveCategoryButton.Name = "SaveCategoryButton";
            this.SaveCategoryButton.Size = new System.Drawing.Size(210, 42);
            this.SaveCategoryButton.TabIndex = 3;
            this.SaveCategoryButton.Text = "Save";
            this.SaveCategoryButton.Click += new System.EventHandler(this.SaveCategoryButton_Click);
            // 
            // AddingCategoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveCategoryButton);
            this.Controls.Add(this.UploadCategoryImageButton);
            this.Controls.Add(this.CategoryNameTextBox);
            this.Controls.Add(this.ImageCategoryPictureBox);
            this.Name = "AddingCategoryView";
            this.Text = "AddingCategoryView";
            ((System.ComponentModel.ISupportInitialize)(this.ImageCategoryPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox ImageCategoryPictureBox;
        private Guna.UI2.WinForms.Guna2TextBox CategoryNameTextBox;
        private Guna.UI2.WinForms.Guna2Button UploadCategoryImageButton;
        private Guna.UI2.WinForms.Guna2Button SaveCategoryButton;
    }
}