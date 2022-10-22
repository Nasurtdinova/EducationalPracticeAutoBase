using BespokeFusion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public User CurrentUser = new User();
        public RegistrationPage()
        {
            InitializeComponent();
            comboGender.ItemsSource = DataAccess.GetGenders();
            DataContext = CurrentUser;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorizationPage());           
        }

        private void btnRegistr_Click(object sender, RoutedEventArgs e)
        {
            CurrentUser.Password = tbPassword.Password;
            var results = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
            var context = new ValidationContext(CurrentUser);

            if (!Validator.TryValidateObject(CurrentUser, context, results, true))
            {
                foreach (var error in results)
                    MaterialMessageBox.ShowError(error.ErrorMessage);
            }
            else
            {
                if (DataAccess.IsTrueLogin(tbLogin.Text))
                {
                    DataAccess.SaveUser(CurrentUser);
                    MaterialMessageBox.Show("Вы зарегистрированы!");
                    NavigationService.Navigate(new AuthorizationPage());
                }
                else
                    MaterialMessageBox.ShowError("Такой логин уже существует!");
            }
        }
    }
}
