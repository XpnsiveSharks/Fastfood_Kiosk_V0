using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood_Kiosk_V0.Views.UserControl
{
    public partial class CategoryUserControl : UserControl
    {
        public CategoryUserControl()
        {
            InitializeComponent();
        }
        public int CategoryId { get; set; }
        public Image CategoryImage 
        {
            get => CategoryImagePictureBox.Image;
            set => CategoryImagePictureBox.Image = value;
        }
        public string CategoryName
        {
            get => CategoryImagePictureBox.Text;
            set => CategoryImagePictureBox.Text = value;
        }
    }
}
