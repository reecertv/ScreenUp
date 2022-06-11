using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScreenUp
{
    public class Generate
    {
        public static string SCName;

        public static void GenerateSCName()
        {
            string day,month,year;

            month = DateTime.Now.Month.ToString();
            day = DateTime.Now.Day.ToString();
            year = DateTime.Now.Year.ToString();

            // SC Name
            int intmonth = Convert.ToInt32(DateTime.Now.Month.ToString());
            int intday = Convert.ToInt32(DateTime.Now.Day.ToString());

            if (intmonth < 10)
            {
                month = "0" + DateTime.Now.Month.ToString();
            }
            if (intday < 10)
            {
                day = "0" + DateTime.Now.Day.ToString();
            }

            SCName = "SC-" + year + month + day;
        }
    }
}