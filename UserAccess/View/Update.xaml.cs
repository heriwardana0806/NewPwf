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
    /// Interaction logic for Update.xaml
    /// </summary>
    public partial class Update : Window
    {
        public string Guname;
        public Update(string uname)
        {
            InitializeComponent();
            UnameSetter(uname);
            UsernameTextBox.Text = uname;
        }

        public void UnameSetter(string uname)
        {
            Guname = uname;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Home home = new Home(Guname);
            home.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
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
            else
            {
                string username = UsernameTextBox.Text;
                string password = PasswordTextBox.Password;

                CallUser.ChangePass(username, password);
                this.Hide();
                Home home = new Home(username);
                home.Show();
            }
        }
    }
}
