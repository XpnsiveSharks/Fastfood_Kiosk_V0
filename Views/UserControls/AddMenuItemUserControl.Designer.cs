namespace Fastfood_Kiosk_V0.Views.UserControls
{
    partial class AddMenuItemUserControl
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
            this.AddCategoryLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.AddMenuImagePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.CategoryNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // AddCategoryLabel
            // 
            this.AddCategoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddCategoryLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCategoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.AddCategoryLabel.Location = new System.Drawing.Point(25, 21);
            this.AddCategoryLabel.Margin = new System.Windows.Forms.Padding(2);
            this.AddCategoryLabel.Name = "AddCategoryLabel";
            this.AddCategoryLabel.Size = new System.Drawing.Size(243, 40);
            this.AddCategoryLabel.TabIndex = 2;
            this.AddCategoryLabel.Text = "Add Menu Item";
            // 
            // AddMenuImagePanel
            // 
            this.AddMenuImagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.AddMenuImagePanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.AddMenuImagePanel.BorderRadius = 25;
            this.AddMenuImagePanel.BorderThickness = 2;
            this.AddMenuImagePanel.Location = new System.Drawing.Point(83, 96);
            this.AddMenuImagePanel.Margin = new System.Windows.Forms.Padding(2);
            this.AddMenuImagePanel.Name = "AddMenuImagePanel";
            this.AddMenuImagePanel.Size = new System.Drawing.Size(333, 267);
            this.AddMenuImagePanel.TabIndex = 3;
            // 
            // CategoryNameTextBox
            // 
            this.CategoryNameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.CategoryNameTextBox.BorderRadius = 15;
            this.CategoryNameTextBox.BorderThickness = 2;
            this.CategoryNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CategoryNameTextBox.DefaultText = "";
            this.CategoryNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CategoryNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CategoryNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CategoryNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CategoryNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CategoryNameTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.CategoryNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CategoryNameTextBox.Location = new System.Drawing.Point(517, 96);
            this.CategoryNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            this.CategoryNameTextBox.PasswordChar = '\0';
            this.CategoryNameTextBox.PlaceholderText = "";
            this.CategoryNameTextBox.SelectedText = "";
            this.CategoryNameTextBox.Size = new System.Drawing.Size(333, 33);
            this.CategoryNameTextBox.TabIndex = 4;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "Love",
            "Fun",
            "Life"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(517, 150);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(270, 36);
            this.guna2ComboBox1.TabIndex = 5;
            // 
            // AddMenuItemUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.CategoryNameTextBox);
            this.Controls.Add(this.AddMenuImagePanel);
            this.Controls.Add(this.AddCategoryLabel);
            this.Name = "AddMenuItemUserControl";
            this.Size = new System.Drawing.Size(967, 552);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel AddCategoryLabel;
        private Guna.UI2.WinForms.Guna2Panel AddMenuImagePanel;
        private Guna.UI2.WinForms.Guna2TextBox CategoryNameTextBox;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
    }
}
