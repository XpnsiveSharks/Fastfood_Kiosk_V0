using Fastfood_Kiosk_V0.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood_Kiosk_V0.Views
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginViewModel loginViewModel = new LoginViewModel();

            string username = UsernameTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();
            string user_role = UserRoleComboBox.SelectedItem.ToString();
            bool IsUserValid = loginViewModel.ValidateUser(username, password, user_role);
            if (IsUserValid)
            {
                MessageBox.Show("User Exist");
            }
            else
            {
                MessageBox.Show("User Does'nt Exist");
            }
        }
    }
}
