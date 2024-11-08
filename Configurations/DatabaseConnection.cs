using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace Fastfood_Kiosk_V0.Configurations
{
    internal class DatabaseConnection
    {
        private readonly string _connectionString;

        public DatabaseConnection(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }
    }
}
