using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Fastfood_Kiosk_V0.Views.UserControls
{
    public partial class DisplayMenuUserControl : UserControl
    {
        public DisplayMenuUserControl()
        {
            InitializeComponent();
            this.Click += MenuPanel_Click;
        }
        public int MenuId { get; set; }
        public string MenuName 
        { 
            get => MenuNameLabel.Text;
            set => MenuNameLabel.Text = value;
        }
        public string MenuPrice 
        { 
            get => MenuPriceLabel.Text; 
            set => MenuPriceLabel.Text = value;
        }
        public string MenuDescription { get; set; }
        public Image MenuImageFilePath 
        {
            get => MenuImagePictureBox.Image;
            set => MenuImagePictureBox.Image = value;
        }
        private void MenuPanel_Click(Object sender, EventArgs e)
        {
            MessageBox.Show($"Menu id is: {MenuId}");
        }
    }
}
