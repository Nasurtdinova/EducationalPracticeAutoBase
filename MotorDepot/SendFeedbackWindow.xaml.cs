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
    public partial class SendFeedbackWindow : Window
    {
        public HistoryClientDriver CurrentHistory = new HistoryClientDriver();
        public SendFeedbackWindow(HistoryClientDriver his)
        {
            InitializeComponent();
            CurrentHistory = his;
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            FeedbackDriver feedback = new FeedbackDriver()
            {
                IdDriver = CurrentHistory.RequestDriver.IdUser,
                IdUser = MainWindow.CurrentUser.Id,
                Feedback = tbFeedback.Text
            };
            DataAccess.SaveFeedback(feedback);
            Close();
        }
    }
}
