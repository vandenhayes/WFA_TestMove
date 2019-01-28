using System;
using System.Collections.Generic;
using System.Text;

using System.Globalization;

namespace WFA_TestMove
{
    class statics
    {
        CultureInfo ci = CultureInfo.CurrentCulture;

        public static int programmState = 0;
        public static string pathToData = "K:/IT_Elektronik/Data_Kl";
        public static string myProfession = "";
        public static bool renewList = false;

        public static int KW(DateTime Datum)
        {
            CultureInfo CUI = CultureInfo.CurrentCulture;
            return CUI.Calendar.GetWeekOfYear(Datum, CUI.DateTimeFormat.CalendarWeekRule, CUI.DateTimeFormat.FirstDayOfWeek);
        }
    }
}
