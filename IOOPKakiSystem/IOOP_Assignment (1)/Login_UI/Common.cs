using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_UI
{
    class Common
    {
        //change 10 to OR00010
        public static string GetIDStr(int numID)
        {
            return "OR" + numID.ToString().PadLeft(5, '0');
        }

        //change OR00010 to 10
        public static int GetIDNum(string strID)
        {
            return int.Parse(strID.Substring(2, 5));
        }
    }
}
