using Dapper;
using Fastfood_Kiosk_V0.Configurations;
using Fastfood_Kiosk_V0.Models;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Fastfood_Kiosk_V0.Repositories
{
    internal class MenuRepository : IMenuRepository
    {
        private readonly DatabaseConnection _databaseConnection;
        private readonly ConfigurationLoader _configurationLoader;
        public MenuRepository()
        {
            _configurationLoader = new ConfigurationLoader();
            _databaseConnection = new DatabaseConnection(_configurationLoader.Configuration);
        }
        

        public List<Menu> GetMenuList()
        {
            try
            {
                using(var connection = _databaseConnection.GetConnection())
                {
                    return connection.Query<Menu>("SELECT * FROM menu_table").ToList();
                }
            }
            catch(SqlException ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }
        public void AddMenu(ItemMenu menu)
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var insertQuery = "INSERT INTO menu_table (Category_Id, Menu_Name, Menu_Price, Description, Menu_Image_File_Path) VALUES (@Category_Id, @Menu_Name, @Menu_Price, @Description, @Menu_Image_File_Path)";
                    connection.Execute(insertQuery, new
                    {
                        Category_Id = menu.Category_Id,
                        Menu_Name = menu.Menu_Name,
                        Menu_Price = menu.Menu_Price,
                        Description = menu.Description,
                        Menu_Image_File_Path = menu.Menu_Image_File_Path

                    });
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }
    }
}
