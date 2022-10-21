using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorDepot
{
    public class RequestDrivers : RequestDriver
    {
        // request driver
        public int FreeVenue
        {
            get
            {
                int value = 0;
                foreach (var i in DataAccess.GetHistoriesClientDriver().Where(a => a.IdRequestDriver == Id && a.IdStatus == 3))
                {
                    value += i.CountPeople.Value;
                }
                return CountPeople.Value - value;
            }
        }

        public string VisibilityReverse
        {
            get
            {
                if (MainWindow.CurrentUser.Id == IdUser)
                    return "Collapsed";
                else if (FreeVenue == 0)
                    return "Collapsed";
                else if (DataAccess.GetHistoriesClientDriver().Where(a => a.IdRequestDriver == Id && a.IdClient == MainWindow.CurrentUser.Id && a.IdStatus == 1 && a.IdStatus == 3).Count() != 0)
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
        // history

        //public string VisibilityRevoke
        //{
        //    get
        //    {
        //        if (DateTime.Now <= RequestDriver.Data.Value && IdStatus != 2 && IdStatus != 4)
        //            return "Visibility";
        //        else
        //            return "Collapsed";
        //    }
        //}

        //public string VisibilitySelect
        //{
        //    get
        //    {
        //        if (DateTime.Now <= RequestDriver.Data.Value && IdStatus != 4)
        //            return "Visibility";
        //        else
        //            return "Collapsed";
        //    }
        //}
    }
}
