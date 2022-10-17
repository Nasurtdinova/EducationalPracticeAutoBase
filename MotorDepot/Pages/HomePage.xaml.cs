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
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
            frame.Navigate(new SearchDriverPage());
        }

        private void btnPublish_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ComingTripsPage());
        }

        private void btnProfile_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MyProfilePage());
        }

        private void btnIncoming_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new IncomingPage());
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.CurrentUser = null;
            NavigationService.Navigate(new AuthorizationPage());
        }
    }
}
