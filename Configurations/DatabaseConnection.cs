using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;

namespace Fastfood_Kiosk_V0.Configurations
{
    internal class DatabaseConnection : IDisposable
    {
        private readonly string _connectionString;

        public DatabaseConnection(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void Dispose()
        {
            
        }

        public MySqlConnection GetConnection()
        {
            var connection = new MySqlConnection(_connectionString);
            connection.Open(); 
            return connection;
        }


    }
}
