using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UserAccess.Controller;
using UserAccess.View;

namespace UserAccess
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            UsernameTextBox.Text = Properties.Settings.Default.Username;
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            UserController CallUser = new UserController();

            if (UsernameTextBox.Text.Length == 0 && PasswordTextBox.Password.Length == 0)
            {
                UsernameErrorMessage.Text = "You Must Enter Valid Username!";
                PasswordErrorMessage.Text = "You Must Enter Password!";
                PasswordTextBox.Focus();
                UsernameTextBox.Focus();
            }
            else if (UsernameTextBox.Text.Length == 0)
            {
                UsernameErrorMessage.Text = "You Must Enter Valid Username!";
                UsernameTextBox.Focus();
            }
            else if (PasswordTextBox.Password.Length == 0)
            {
                PasswordErrorMessage.Text = "You Must Enter Password!";
                PasswordTextBox.Focus();
            }
            else {
                string username = UsernameTextBox.Text;
                string password = PasswordTextBox.Password;

                CallUser.UserLogin(username, password);
                this.Hide();
                Home home = new Home(username);
                home.Show();
            }
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

        private void RememberCheck_Checked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Username = UsernameTextBox.Text;
            Properties.Settings.Default.Save();
        }
    }
}
