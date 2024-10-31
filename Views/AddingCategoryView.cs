using Fastfood_Kiosk_V0.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood_Kiosk_V0.Views
{
    public partial class AddingCategoryView : Form
    {
        public AddingCategoryView()
        {
            InitializeComponent();
        }
        private string selectedCategoryImage;
        private void UploadCategoryImageButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "D:\\";
                openFileDialog.Filter = "Image Filter|*.jpg;*.jpeg;*.png;*.bmp";
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedCategoryImage = openFileDialog.FileName;
                    ImageCategoryPictureBox.Image = Image.FromFile(selectedCategoryImage);
                    MessageBox.Show("File Selected!");
                }
            }
        }
        private void SaveCategoryButton_Click(object sender, EventArgs e)
        {
            string categoryName = CategoryNameTextBox.Text;
            CategoryViewModel categoryViewModel = new CategoryViewModel();
            if(selectedCategoryImage != null)
            {
                categoryViewModel.AddingCategory(categoryName, selectedCategoryImage);
                MessageBox.Show("Category saved succesfully!");
            }
            else
            {
                MessageBox.Show("Please upload an image");
            }
            
        }
    }
}
