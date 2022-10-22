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
    /// <summary>
    /// Логика взаимодействия для ProfileDriverPage.xaml
    /// </summary>
    public partial class ProfileDriverPage : Page
    {
        public ProfileDriverPage(User user)
        {
            InitializeComponent();
            lvFeedBacks.ItemsSource = DataAccess.GetFeedbacks().Where(a => a.IdDriver == user.Id);
            DataContext = user;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
