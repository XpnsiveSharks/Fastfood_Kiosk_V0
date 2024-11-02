using Fastfood_Kiosk_V0.Repositories;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Fastfood_Kiosk_V0.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _username;
        public string User_name
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged(nameof(User_name));
            }
        }

        private string _password;
        public string Pass_word
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Pass_word));
            }
        }
        private string _user_role;
        public string UserRole
        {
            get => _user_role;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(UserRole));
            }
        }
        public bool Login()
        {
            UsersRepository usersRepository = new UsersRepository();
            var users = usersRepository.GetAllUsers();
            var user = users.FirstOrDefault(u => 
            u.Username.Equals(_username) &&
            u.User_Role.Equals(_user_role));
            if (user == null)
            {
                return VerifyPassword(_password , user.Password);
            }
            return false;
        }
        private bool VerifyPassword(string inputPassword, string storedPassword)
        {
            //Important Note
            //add password hashing
            return inputPassword == storedPassword;
        }
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
