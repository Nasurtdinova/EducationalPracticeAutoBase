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

namespace MotorDepot
{
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var user = DataAccess.GetUsers().Where(a => a.Login == tbLogin.Text && a.Password == tbPassword.Password).FirstOrDefault();
            if (user != null)
            {
                MainWindow.CurrentUser = user;
                NavigationService.Navigate(new HomeWindow());
            }
            else
                MessageBox.Show("Неправильный логин или пароль");
        }

        private void btnRegistr_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationPage());
        }
    }
}
