using Fastfood_Kiosk_V0.Models;
using Fastfood_Kiosk_V0.ViewModels;
using Fastfood_Kiosk_V0.Views.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood_Kiosk_V0.Views
{
    public partial class AddingCategoryView : Form
    {
        private readonly CategoryViewModel _categoryViewModel;
        public AddingCategoryView()
        {
            InitializeComponent();
            _categoryViewModel = new CategoryViewModel();
            ImageCategoryPictureBox.DataBindings.Add("Image", _categoryViewModel, nameof(_categoryViewModel.SelectedCategoryImage), true, DataSourceUpdateMode.OnPropertyChanged);
            CategoryNameTextBox.DataBindings.Add("Text", _categoryViewModel, nameof(_categoryViewModel.CategoryName), true, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void UploadCategoryImageButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "D:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _categoryViewModel.SelectedCategoryImagePath = openFileDialog.FileName; 
                    MessageBox.Show("File Selected!");
                }
            }
        }
        private void SaveCategoryButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_categoryViewModel.CategoryName))
            {
                MessageBox.Show("Please enter a category name.");
                return;
            }

            if (string.IsNullOrEmpty(_categoryViewModel.SelectedCategoryImagePath))
            {
                MessageBox.Show("Please upload an image.");
                return;
            }

            _categoryViewModel.AddingCategory();
            MessageBox.Show("Category saved successfully!");
        }
        /*private void MenuImageUploadButton_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "D:\\";
                openFileDialog.Filter = "Image Filter|*.jpg;*.jpeg;*.png;*.bmp;";
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedMenuImage = openFileDialog.FileName;
                    MenuImagePictureBox.Image = Image.FromFile(selectedMenuImage);
                    MessageBox.Show("file Selected");
                }
            }
        }
        private void LoadCategoriesInComboBox()
        {
            CategoryViewModel categoryViewModel = new CategoryViewModel();
            List<Category> categories = categoryViewModel.LoadAllCategories();
            CategoryComboBox.DataSource = categories;
            CategoryComboBox.DisplayMember = "Category_Name"; // The property to display
            CategoryComboBox.ValueMember = "Category_Id";      // The property to use as value
        }
        private void SaveMenuButton_Click(object sender, EventArgs e)
        {
            MenuViewModel menuViewModel = new MenuViewModel();

            // Cast the selected item to your Category model
            var selectedCategory = CategoryComboBox.SelectedItem as Category;

            // Check if the selected category is not null
            if (selectedCategory != null)
            {
                int categoryId = selectedCategory.Category_Id; // Access the Category_Id property
                MessageBox.Show(categoryId.ToString());

                string menuName = MenuNameTextBox.Text;
                double menuPrice;
                string menuDescription = DescriptionRichTextBox.Text;

                if (double.TryParse(MenuPriceTextBox.Text, out menuPrice))
                {
                    menuViewModel.AddingMenu(categoryId, menuName, menuPrice, menuDescription, selectedMenuImage);
                    MessageBox.Show("Menu added to database successfully");
                }
                else
                {
                    // Handle the case where the input is not a valid double
                    MessageBox.Show("Please enter a valid number for the price.");
                }
            }
            else
            {
                // Handle the case where no category is selected
                MessageBox.Show("Please select a category.");
            }
        }*/

    }
}
