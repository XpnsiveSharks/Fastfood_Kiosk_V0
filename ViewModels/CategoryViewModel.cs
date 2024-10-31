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
        public void AddingCategory(string categoryName, string categoryImage)
        {
            var configurationLoader = new ConfigurationLoader();
            using (var databaseConnection = new DatabaseConnection(configurationLoader.Configuration))
            {
                CategoryRepository category = new CategoryRepository(databaseConnection);
                var newCategory = new Category
                {
                    Category_Name = categoryName,
                    Category_Image = categoryImage
                };
                category.AddCategory(newCategory);
            }
        }
    }
}
