using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fastfood_Kiosk_V0.Configurations
{
    internal class DatabaseConnection : IDisposable
    {
        private readonly MySqlConnection _connection;
        public DatabaseConnection(IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            _connection = new MySqlConnection(connectionString);
            _connection.Open();
        }
        public MySqlConnection GetConnection()
        {
            return _connection;
        }
        public void Dispose()
        {
            _connection?.Dispose();
        }
    }
}
