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
using System.Windows.Shapes;
using UserAccess.Controller;

namespace UserAccess.View
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UserController CallUser = new UserController();

            if (UsernameTextBox.Text.Length == 0 && PasswordTextBox.Password.Length == 0 && PasswordValidationTextBox.Password.Length == 0)
            {
                UsernameErrorMessage.Text = "You Must Enter Valid Username!";
                PasswordErrorMessage.Text = "You Must Enter Password!";
                ValidationPasswordErrorMessage.Text = "You Must Enter Confirm Password!";
                PasswordValidationTextBox.Focus();
                PasswordTextBox.Focus();
                UsernameTextBox.Focus();
            }
            else if (PasswordTextBox.Password.Length == 0 && UsernameTextBox.Text.Length == 0)
            {
                UsernameErrorMessage.Text = "You Must Enter Valid Username!";
                PasswordErrorMessage.Text = "You Must Enter Password!";
                UsernameTextBox.Focus();
                PasswordTextBox.Focus();
            }
            else if (PasswordTextBox.Password.Length == 0 && PasswordValidationTextBox.Password.Length == 0)
            {
                PasswordErrorMessage.Text = "You Must Enter Password!";
                ValidationPasswordErrorMessage.Text = "You Must Enter Confirm Password!";
                PasswordValidationTextBox.Focus();
                UsernameTextBox.Focus();
            }
            else if (UsernameTextBox.Text.Length == 0 && PasswordValidationTextBox.Password.Length == 0)
            {
                UsernameErrorMessage.Text = "You Must Enter Valid Username!";
                ValidationPasswordErrorMessage.Text = "You Must Enter Confirm Password!";
                PasswordValidationTextBox.Focus();
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
                UsernameTextBox.Focus();
            }
            else if (PasswordValidationTextBox.Password.Length == 0)
            {
                ValidationPasswordErrorMessage.Text = "You Must Enter Confirm Password!";
                PasswordValidationTextBox.Focus();
            }
            else if (PasswordValidationTextBox.Password != PasswordTextBox.Password)
            {
                ValidationPasswordErrorMessage.Text = "Your Password Need to Enter The Same Password!";
                PasswordValidationTextBox.Focus();
            }
            else {
                string username = UsernameTextBox.Text;
                string password = PasswordTextBox.Password;

                CallUser.AddUser(username, password);
                this.Hide();
                MainWindow main = new MainWindow();
                main.Show();
            }



        }
    }
}
