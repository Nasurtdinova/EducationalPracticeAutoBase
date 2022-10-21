using BespokeFusion;
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
    public partial class ReverseVenueWindow : Window
    {
        public HistoryClientDriver CurrentHistory = new HistoryClientDriver();
        public RequestDriver SelectedRequest = new RequestDriver();
        public ReverseVenueWindow(RequestDriver req)
        {
            InitializeComponent();
            tbUser.Text = MainWindow.CurrentUser.FullName;
            if (req != null)
                SelectedRequest = req;
            DataContext = CurrentHistory;
        }

        private void btnReverse_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(tbCount.Text) > SelectedRequest.FreeVenue)
                MaterialMessageBox.Show($"Свободных мест только {SelectedRequest.FreeVenue}");
            else
            {
                if (MessageBox.Show("Вы точно хотите забронировать место?", "Подтверждение", MessageBoxButton.YesNoCancel) == MessageBoxResult.Yes)
                {
                    CurrentHistory.IdClient = MainWindow.CurrentUser.Id;
                    CurrentHistory.IdRequestDriver = SelectedRequest.Id;
                    CurrentHistory.IdStatus = 1;
                    CurrentHistory.Data = DateTime.Now;
                    DataAccess.SaveHistoryClientDriver(CurrentHistory);
                    MaterialMessageBox.Show("Мы отправили запрос водителю, ожидайте пока водитель ответит!");
                }
                Close();
            }
        }
    }
}
