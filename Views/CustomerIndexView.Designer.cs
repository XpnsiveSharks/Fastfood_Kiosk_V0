namespace Fastfood_Kiosk_V0.Views
{
    partial class CustomerIndexView
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
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.ControlBoxPanel = new System.Windows.Forms.Panel();
            this.MinimizeBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MaximizeBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.CloseBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.CategoryFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.displayCategoryUserControl1 = new Fastfood_Kiosk_V0.Views.UserControls.DisplayCategoryUserControl();
            this.displayCategoryUserControl2 = new Fastfood_Kiosk_V0.Views.UserControls.DisplayCategoryUserControl();
            this.guna2GradientPanel1.SuspendLayout();
            this.ControlBoxPanel.SuspendLayout();
            this.CategoryFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.ControlBoxPanel);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(54)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1339, 84);
            this.guna2GradientPanel1.TabIndex = 2;
            // 
            // ControlBoxPanel
            // 
            this.ControlBoxPanel.BackColor = System.Drawing.Color.Transparent;
            this.ControlBoxPanel.Controls.Add(this.MinimizeBox);
            this.ControlBoxPanel.Controls.Add(this.MaximizeBox);
            this.ControlBoxPanel.Controls.Add(this.CloseBox);
            this.ControlBoxPanel.Location = new System.Drawing.Point(1172, 3);
            this.ControlBoxPanel.Name = "ControlBoxPanel";
            this.ControlBoxPanel.Size = new System.Drawing.Size(167, 52);
            this.ControlBoxPanel.TabIndex = 3;
            // 
            // MinimizeBox
            // 
            this.MinimizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeBox.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.MinimizeBox.FillColor = System.Drawing.Color.Transparent;
            this.MinimizeBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.MinimizeBox.Location = new System.Drawing.Point(12, 3);
            this.MinimizeBox.Name = "MinimizeBox";
            this.MinimizeBox.Size = new System.Drawing.Size(45, 46);
            this.MinimizeBox.TabIndex = 2;
            // 
            // MaximizeBox
            // 
            this.MaximizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeBox.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.MaximizeBox.CustomIconSize = 30F;
            this.MaximizeBox.FillColor = System.Drawing.Color.Transparent;
            this.MaximizeBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.MaximizeBox.Location = new System.Drawing.Point(69, 3);
            this.MaximizeBox.Name = "MaximizeBox";
            this.MaximizeBox.PressedColor = System.Drawing.Color.Gold;
            this.MaximizeBox.Size = new System.Drawing.Size(45, 46);
            this.MaximizeBox.TabIndex = 1;
            // 
            // CloseBox
            // 
            this.CloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBox.CustomIconSize = 30F;
            this.CloseBox.FillColor = System.Drawing.Color.Transparent;
            this.CloseBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.CloseBox.Location = new System.Drawing.Point(111, 3);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.PressedColor = System.Drawing.Color.Firebrick;
            this.CloseBox.Size = new System.Drawing.Size(45, 46);
            this.CloseBox.TabIndex = 0;
            // 
            // CategoryFlowLayoutPanel
            // 
            this.CategoryFlowLayoutPanel.AutoScroll = true;
            this.CategoryFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(251)))));
            this.CategoryFlowLayoutPanel.Controls.Add(this.displayCategoryUserControl1);
            this.CategoryFlowLayoutPanel.Controls.Add(this.displayCategoryUserControl2);
            this.CategoryFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.CategoryFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.CategoryFlowLayoutPanel.Location = new System.Drawing.Point(0, 84);
            this.CategoryFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CategoryFlowLayoutPanel.Name = "CategoryFlowLayoutPanel";
            this.CategoryFlowLayoutPanel.Size = new System.Drawing.Size(260, 834);
            this.CategoryFlowLayoutPanel.TabIndex = 2;
            // 
            // displayCategoryUserControl1
            // 
            this.displayCategoryUserControl1.CategoryId = 0;
            this.displayCategoryUserControl1.CategoryImage = null;
            this.displayCategoryUserControl1.CategoryName = "Meal";
            this.displayCategoryUserControl1.Location = new System.Drawing.Point(3, 4);
            this.displayCategoryUserControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.displayCategoryUserControl1.Name = "displayCategoryUserControl1";
            this.displayCategoryUserControl1.Size = new System.Drawing.Size(234, 197);
            this.displayCategoryUserControl1.TabIndex = 0;
            // 
            // displayCategoryUserControl2
            // 
            this.displayCategoryUserControl2.CategoryId = 0;
            this.displayCategoryUserControl2.CategoryImage = null;
            this.displayCategoryUserControl2.CategoryName = "Meal";
            this.displayCategoryUserControl2.Location = new System.Drawing.Point(3, 209);
            this.displayCategoryUserControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.displayCategoryUserControl2.Name = "displayCategoryUserControl2";
            this.displayCategoryUserControl2.Size = new System.Drawing.Size(236, 206);
            this.displayCategoryUserControl2.TabIndex = 1;
            // 
            // CustomerIndexView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1339, 918);
            this.Controls.Add(this.CategoryFlowLayoutPanel);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CustomerIndexView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerIndexView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ControlBoxPanel.ResumeLayout(false);
            this.CategoryFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.FlowLayoutPanel CategoryFlowLayoutPanel;
        private System.Windows.Forms.Panel ControlBoxPanel;
        private Guna.UI2.WinForms.Guna2ControlBox CloseBox;
        private Guna.UI2.WinForms.Guna2ControlBox MaximizeBox;
        private Guna.UI2.WinForms.Guna2ControlBox MinimizeBox;
        private UserControls.DisplayCategoryUserControl displayCategoryUserControl1;
        private UserControls.DisplayCategoryUserControl displayCategoryUserControl2;
    }
}