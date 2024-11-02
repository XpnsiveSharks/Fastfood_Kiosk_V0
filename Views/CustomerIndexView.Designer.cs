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
            this.CategoryFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // CategoryFlowLayoutPanel
            // 
            this.CategoryFlowLayoutPanel.AutoScroll = true;
            this.CategoryFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.CategoryFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.CategoryFlowLayoutPanel.Name = "CategoryFlowLayoutPanel";
            this.CategoryFlowLayoutPanel.Size = new System.Drawing.Size(313, 734);
            this.CategoryFlowLayoutPanel.TabIndex = 0;
            // 
            // MenuFlowLayoutPanel
            // 
            this.MenuFlowLayoutPanel.Location = new System.Drawing.Point(319, 68);
            this.MenuFlowLayoutPanel.Name = "MenuFlowLayoutPanel";
            this.MenuFlowLayoutPanel.Size = new System.Drawing.Size(866, 666);
            this.MenuFlowLayoutPanel.TabIndex = 1;
            // 
            // CustomerIndexView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 734);
            this.Controls.Add(this.MenuFlowLayoutPanel);
            this.Controls.Add(this.CategoryFlowLayoutPanel);
            this.Name = "CustomerIndexView";
            this.Text = "CustomerIndexView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel CategoryFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel MenuFlowLayoutPanel;
    }
}