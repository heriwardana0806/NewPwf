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

namespace UserAccess.View
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public string Guname;
        public Home(string uname)
        {
            InitializeComponent();
            UnameSetter(uname);
            WelcomeMessage.Text = "Welcome Home, " + uname + "!";
        }

        private void SignOut_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Log Out Success!");
            this.Hide();
            MainWindow main = new MainWindow();
            main.Show();
        }

        public void UnameSetter(string uname) {
            Guname = uname;
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Update update = new Update(Guname);
            update.Show();
        }
    }
}
