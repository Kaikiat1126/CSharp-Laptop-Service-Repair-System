using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_UI
{
    class SerRepGenerator
    {
        public string TargetMonth;
        public int TargetYear;
        public int MonthNum;
        public string ServiceType;

        public SerRepGenerator(string month, string sertype, string year)
        {
            TargetMonth = month;
            ServiceType = sertype;
            TargetYear = Convert.ToInt32(year);
        }

        public int MonthDigitaliser()
        {
            MonthNum = 0;
            //Date Array
            string[] MonthRepo = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "Disember" };
            int count;
            for (count = 1; count < 13; count++)
            {
                if (TargetMonth == MonthRepo[count - 1])
                {
                    MonthNum = count;
                    break;
                }
            }
            return MonthNum;
        }

        public string query(int NumericMonth, int year)
        {
            return $"SELECT OrderID, Username, ServiceType, OrderDate, ServiceStatus, ServiceFee from CustomerOrder where MONTH(OrderDate) = '{NumericMonth}' AND YEAR(OrderDate) = '{TargetYear}' AND ServiceCondition <> 'Cancelled'";

        }
        public string query(int NumericMonth, string ServiceType, int year)
        {
            return $"SELECT OrderID, Username, ServiceType, OrderDate, ServiceStatus, ServiceFee from CustomerOrder where MONTH(OrderDate) = '{NumericMonth}' AND YEAR(OrderDate) = '{TargetYear}' AND ServiceType = '{ServiceType}'  AND ServiceCondition <> 'Cancelled'";
        }

    }
}
