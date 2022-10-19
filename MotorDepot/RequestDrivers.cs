using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorDepot
{
    public class RequestDrivers : RequestDriver
    {
        public string VisibilityReverse
        {
            get
            {
                if (MainWindow.CurrentUser.Id == IdUser)
                    return "Collapsed";
                else
                    return "Visibility";
            }
        }

        public string VisibilityEdit
        {
            get
            {
                if (Data.Value < DateTime.Now)
                    return "Collapsed";
                else
                    return "Visibility";
            }
        }

        public virtual ICollection<HistoryClientDriver> HistoryClientDriverAccept
        {
            get
            {
                return DataAccess.GetHistoriesClientDriver().Where(a => a.RequestDriver.IdUser == MainWindow.CurrentUser.Id && a.IdStatus == 3 && a.IdRequestDriver == Id).ToList();
            }
        }
    }
}
