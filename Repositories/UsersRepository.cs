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
        private readonly DatabaseConnection databaseConnection;
        public UsersRepository(DatabaseConnection databaseConnection)
        {
            this.databaseConnection = databaseConnection;
        }
        public List<Users> GetAllUsers()
        {
            try
            {
                using(var connection = databaseConnection.GetConnection())
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
