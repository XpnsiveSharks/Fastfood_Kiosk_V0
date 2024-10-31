using Fastfood_Kiosk_V0.Configurations;
using Fastfood_Kiosk_V0.Models;
using Fastfood_Kiosk_V0.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fastfood_Kiosk_V0.ViewModels
{
    internal class CategoryViewModel
    {
        private readonly ConfigurationLoader _configurationLoader;
        private readonly DatabaseConnection _databaseConnection;
        private readonly CategoryRepository _categoryRepository;
        public CategoryViewModel()
        {
            _configurationLoader = new ConfigurationLoader();
            _databaseConnection = new DatabaseConnection(_configurationLoader.Configuration);
            _categoryRepository = new CategoryRepository(_databaseConnection);
        }

        public void AddingCategory(string categoryName, string categoryImage)
        {
            var newCategory = new Category
            {
                Category_Name = categoryName,
                Category_Image = categoryImage
            };
            _categoryRepository.AddCategory(newCategory);
        }
        public List<Category> LoadAllCategories()
        {
            return _categoryRepository.GetAllCategories();
        }
    }
}
