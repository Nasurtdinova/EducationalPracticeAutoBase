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
    public partial class DriversPage : Page
    {
        public DriversPage()
        {
            InitializeComponent();
            lvDrivers.ItemsSource = DataAccess.GetRequestDrivers();
        }

        private void btnReserve_Click(object sender, RoutedEventArgs e)
        {
            var a = (sender as Button).DataContext as RequestDriver;
            if (MessageBox.Show("Вы точно хотите забронировать место?","Подтверждение",MessageBoxButton.YesNoCancel) == MessageBoxResult.Yes)
            {
                HistoryClientDriver history = new HistoryClientDriver()
                {
                    IdClient = MainWindow.CurrentUser.Id,
                    IdRequestDriver = a.Id,
                    IdStatus = 1,
                    Data = DateTime.Now,
                };
                DataAccess.SaveHistoryClientDriver(history);
                MessageBox.Show("Мы отправили запрос водителю, ожидайте пока водитель ответит!");
            }
        }
    }
}
