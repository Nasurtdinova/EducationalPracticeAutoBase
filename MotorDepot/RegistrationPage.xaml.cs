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
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
            comboGender.ItemsSource = DataAccess.GetGenders();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorizationPage());           
        }

        private void btnRegistr_Click(object sender, RoutedEventArgs e)
        {
            User user = new User()
            {
                FullName = tbFullName.Text,
                DayOfBirth = dpDate.SelectedDate,
                Login = tbLogin.Text,
                Password = tbPassword.Password,
                Gender = (comboGender.SelectedItem as Gender).Name,
            };
            DataAccess.SaveUser(user);
            MessageBox.Show("Вы зарегистрированы!");
            NavigationService.Navigate(new AuthorizationPage());
        }
    }
}
