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
        private readonly DatabaseConnection databaseConnection;
        public CategoryRepository(DatabaseConnection databaseConnection)
        {
            this.databaseConnection = databaseConnection;
        }
        public void AddCategory(Category category)
        {
            try
            {
                using (var connection = databaseConnection.GetConnection())
                {
                    var insertQuery = "INSERT INTO menu_category_table (Category_Name, Category_Image) VALUES (@Category_Name, @Category_Image)";
                    connection.Execute(insertQuery, new
                    {
                        Category_Name = category.Category_Name,
                        Category_Image = category.Category_Image
                    });
                }
            }
            catch(SqlException ex) 
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }
    }
}
