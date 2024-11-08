using Dapper;
using Fastfood_Kiosk_V0.Configurations;
using Fastfood_Kiosk_V0.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fastfood_Kiosk_V0.Repositories
{
    internal class CategoryRepository : ICategoryRepository
    {
        private readonly DatabaseConnection _databaseConnection;
        private readonly ConfigurationLoader _configurationLoader;
        public CategoryRepository()
        {
            _configurationLoader = new ConfigurationLoader();
            _databaseConnection = new DatabaseConnection(_configurationLoader.Configuration);
        }
        public void AddCategory(Category category)
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var insertQuery = "INSERT INTO menu_category_table (Category_Name, Category_Image_File_Path) VALUES (@Category_Name, @Category_Image_File_Path)";
                    connection.Execute(insertQuery, new
                    {
                        Category_Name = category.Category_Name,
                        Category_Image_File_Path = category.Category_Image_File_Path
                    });
                }
            }             catch(SqlException ex) 
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }

        public List<Category> GetAllCategories()
        {
            try
            {

                using (var connection = _databaseConnection.GetConnection())
                {
                    return connection.Query<Category>("SELECT * FROM menu_category_table").ToList();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }

        public int GetCategoryId()
        {
            throw new NotImplementedException();
        }
    }
}
