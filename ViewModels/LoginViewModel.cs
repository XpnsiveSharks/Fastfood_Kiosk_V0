using Fastfood_Kiosk_V0.Configurations;
using Fastfood_Kiosk_V0.Models;
using Fastfood_Kiosk_V0.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fastfood_Kiosk_V0.ViewModels
{
    internal class LoginViewModel
    {
        public List<Users> FetchUsers()
        {
            var configurationLoader = new ConfigurationLoader();
            using(var databaseConnection = new DatabaseConnection(configurationLoader.Configuration))
            {
                UsersRepository usersRepository = new UsersRepository(databaseConnection); 
                return usersRepository.GetAllUsers();
            }
        }
        public bool ValidateUser(string username, string password, string user_role)
        { 
            var users = FetchUsers();
            var user = users.FirstOrDefault(u => 
            u.Username.Equals(username) &&
            u.User_Role.Equals(user_role));
            if(user != null ) 
            {
                return VerifyPassword(password, user.Password);
            }
            return false;
        }
        private bool VerifyPassword(string inputPassword, string storedPassword)
        {
            //add password hashing
            return inputPassword == storedPassword;
        }
    }
}
