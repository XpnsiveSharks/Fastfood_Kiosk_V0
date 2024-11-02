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
    internal class UsersRepository : IUsersRepository
    {
        private readonly DatabaseConnection _databaseConnection;
        private readonly ConfigurationLoader _configurationLoader;
        public UsersRepository()
        {
            _configurationLoader = new ConfigurationLoader();
            _databaseConnection = new DatabaseConnection(_configurationLoader.Configuration);
        }
        public List<Users> GetAllUsers()
        {
            try
            {
                using(var connection = _databaseConnection.GetConnection())
                {
                    var query = "SELECT * FROM Users_Table";
                    return connection.Query<Users>(query).ToList();
                }
            }
            catch(SqlException ex)
            {
                throw new Exception("An error occured while accessing database", ex);
            }
        }
    }
}
