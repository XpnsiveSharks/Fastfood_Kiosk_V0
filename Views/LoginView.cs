using Fastfood_Kiosk_V0.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood_Kiosk_V0.Views
{
    public partial class LoginView : Form
    {
        private LoginViewModel _loginViewModel;
        public LoginView()
        {
            InitializeComponent();
            _loginViewModel = new LoginViewModel();
            UsernameTextBox.DataBindings.Add("Text", _loginViewModel, nameof(_loginViewModel.UserRole), false, DataSourceUpdateMode.OnPropertyChanged);
            UsernameTextBox.DataBindings.Add("Text", _loginViewModel, nameof(_loginViewModel.User_name), false, DataSourceUpdateMode.OnPropertyChanged);
            UsernameTextBox.DataBindings.Add("SelectedItem", _loginViewModel, nameof(_loginViewModel.Pass_word), false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool loginSuccessful = _loginViewModel.Login();

            if (loginSuccessful)
            {
                MessageBox.Show("Login successful!");
                // Important note
                // add function to proceed to the next view or form
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            string password = PasswordTextBox.Text;
            string hashedPassword = ComputeSha256Hash(password);    

        }

        private string ComputeSha256Hash(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder stringBuilder = new StringBuilder();

                foreach (byte b in bytes)
                {
                    stringBuilder.Append(b.ToString("x2"));
                }

                return stringBuilder.ToString();    
            }


        }
    }
}
