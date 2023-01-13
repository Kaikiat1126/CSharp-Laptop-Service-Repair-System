using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_UI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            //Application.Run(new MyService());
            //Application.Run(new Register("cus",1));
            //Application.Run(new Profile(1));
            //Application.Run(new ChangeMyServiceRequest());
            //Application.Run(new NewServiceRequestion());
            //Application.Run(new UpdateCustomerServiceStatus());
            //Application.Run(new ViewServiceRequestion());
            //Application.Run(new Income_Report());
            //Application.Run(new ServiceReportOptionPage());
        }
    }
}
