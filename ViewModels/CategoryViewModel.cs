using Fastfood_Kiosk_V0.Configurations;
using Fastfood_Kiosk_V0.Models;
using Fastfood_Kiosk_V0.Repositories;
using Fastfood_Kiosk_V0.Views;
using Fastfood_Kiosk_V0.Views.UserControls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

internal class CategoryViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;
    private readonly CategoryRepository _categoryRepository;
    private List<DisplayCategoryUserControl> _categoryControls;
    public CategoryViewModel()
    {
        _categoryRepository = new CategoryRepository();
        LoadCategories();
    }
    private string _categoryName; // Backing field

    public string CategoryName
    {
        get => _categoryName; // Return the value of the backing field
        set
        {
            if (_categoryName != value) // Only update if the value has changed
            {
                _categoryName = value;
                OnPropertyChanged(nameof(CategoryName));
            }
        }
    }

    private string _selectedCategoryImagePath;
    public string SelectedCategoryImagePath
    {
        get => _selectedCategoryImagePath;
        set
        {
            _selectedCategoryImagePath = value;
            OnPropertyChanged(nameof(SelectedCategoryImagePath));
            OnPropertyChanged(nameof(SelectedCategoryImage));
        }
    }
    public Image SelectedCategoryImage =>
        !string.IsNullOrEmpty(_selectedCategoryImagePath) ? Image.FromFile(_selectedCategoryImagePath) : null;
    public void AddingCategory()
    {
        var newCategory = new Category
        {
            Category_Name = this.CategoryName,
            Category_Image_File_Path = this.SelectedCategoryImagePath
        };
        CategoryRepository categoryRepository = new CategoryRepository();
        categoryRepository.AddCategory(newCategory);
    }
    // Loading Categories to 
    // A property to hold the category user controls list
    public List<DisplayCategoryUserControl> CategoryControls
    {
        get => _categoryControls;
        private set
        {
            _categoryControls = value;
            OnPropertyChanged(nameof(CategoryControls));
        }
    }
    public void LoadCategories()
    {
        List<Category> categories = _categoryRepository.GetAllCategories();
        List<DisplayCategoryUserControl> controls = new List<DisplayCategoryUserControl>();

        foreach (var category in categories)
        {
            DisplayCategoryUserControl control = new DisplayCategoryUserControl
            {
                CategoryId = category.Category_Id,
                CategoryName = category.Category_Name
            };

            string imagePath = Path.Combine(Application.StartupPath, "Resources", category.Category_Image_File_Path);
            if (File.Exists(imagePath))
            {
                control.CategoryImage = Image.FromFile(imagePath);
            }
            else
            {
                string defaultImagePath = Path.Combine(Application.StartupPath, "Resources", "default_image.jpg");
                control.CategoryImage = Image.FromFile(defaultImagePath);
            }

            controls.Add(control);
        }

        // Assign to property to trigger PropertyChanged event
        CategoryControls = controls;
    }
    protected void OnPropertyChanged(string name)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
   
}
