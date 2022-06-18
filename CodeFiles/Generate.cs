using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScreenUp
{
    public class Generate
    {
        public static string SCName;
        public static string TimeStamp;

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

        public static void GenerateTimeStamp()
        {
            string hour, minute, second;

            hour = DateTime.Now.Hour.ToString();
            minute = DateTime.Now.Minute.ToString();
            second = DateTime.Now.Second.ToString();

            // SC Name
            int inthour = Convert.ToInt32(DateTime.Now.Hour.ToString());
            int intminute = Convert.ToInt32(DateTime.Now.Minute.ToString());
            int intsecond = Convert.ToInt32(DateTime.Now.Second.ToString());

            if (inthour < 10)
            {
                hour = "0" + DateTime.Now.Hour.ToString();
            }
            if (intminute < 10)
            {
                minute = "0" + DateTime.Now.Minute.ToString();
            }
            if (intsecond < 10)
            {
                second = "0" + DateTime.Now.Second.ToString();
            }

            TimeStamp = "[" + hour + ":" + minute + ":" + second + "] ";
        }
    }
}