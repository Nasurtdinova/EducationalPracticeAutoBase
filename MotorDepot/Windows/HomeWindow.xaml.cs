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

namespace MotorDepot
{
    /// <summary>
    /// Логика взаимодействия для HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Page
    {
        public HomeWindow()
        {
            InitializeComponent();
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //DragMove();
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            MoveCursorMenu(index);

            switch (index)
            {
                case 0:
                    GridPrincipal.Navigate(new SearchDriverPage());
                    break;
                case 1:
                    GridPrincipal.Navigate(new ComingTripsPage());
                    break;
                case 2:
                    GridPrincipal.Navigate(new IncomingPage());
                    break;
                case 3:
                    GridPrincipal.Navigate(new MyProfilePage());
                    break;
                case 4:
                    MotorDepotWindow.CurrentUser = null;
                    RequestDriver.StringReverse = String.Empty;
                    NavigationService.Navigate(new AuthorizationPage());
                    break;
                default:
                    break;
            }
        }

        private void MoveCursorMenu(int index)
        {
            TrainsitionigContentSlide.OnApplyTemplate();
            GridCursor.Margin = new Thickness(0, (200 + (60 * index)), 0, 0);
        }
    }
}
