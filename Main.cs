using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ScreenUp
{
    public partial class Main : Form
    {
        private HotKey HK = new HotKey();
        private HotKey HK2 = new HotKey();
        private HotKey HK3 = new HotKey();

        string month, day, year;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FirstStart == 0)
            {
                Form SU = new UI.Setup();
                SU.Show();                          
            }

            HK.OwnerForm = this;
            HK.HotKeyPressed += new HotKey.HotKeyPressedEventHandler(HK_HotKeyPressed);
            HK.AddHotKey(Keys.F5, HotKey.MODKEY.MOD_CONTROL, "Screenshot");

            HK2.OwnerForm = this;
            HK2.HotKeyPressed += new HotKey.HotKeyPressedEventHandler(HK2_HotKeyPressed);
            HK2.AddHotKey(Keys.F6, HotKey.MODKEY.MOD_CONTROL, "SCBrowser");

            HK3.OwnerForm = this;
            HK3.HotKeyPressed += new HotKey.HotKeyPressedEventHandler(HK3_HotKeyPressed);
            HK3.AddHotKey(Keys.F7, HotKey.MODKEY.MOD_CONTROL, "SilentScreenshot");

            // Date
            month = DateTime.Now.Month.ToString();
            day = DateTime.Now.Day.ToString();
            year = DateTime.Now.Year.ToString();        

            // Reset Counter
            if (Properties.Settings.Default.LastDate != month + day + year)
            {
                Properties.Settings.Default.Counter = 0;
            }

            Properties.Settings.Default.LastDate = month + day + year;
            Properties.Settings.Default.Save();
        }

        private void HK_HotKeyPressed(string ID)
        {
            Form VS = new UI.ViewScreenshot();
            VS.Show();
        }
        private void HK2_HotKeyPressed(string ID)
        {
            Form SB = new UI.ScreenshotBrowser();
            SB.Show();
        }
        private void HK3_HotKeyPressed(string ID)
        {
            Rectangle bounds;
            Bitmap screenshot;
            Graphics graph;

            bounds = Screen.PrimaryScreen.Bounds;
            screenshot = new Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            graph = Graphics.FromImage(screenshot);
            graph.CopyFromScreen(0, 0, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy);

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

            screenshot.Save(Properties.Settings.Default.ScreenshotFolder + "/SC-" + year + month + day + "-" + Properties.Settings.Default.Counter.ToString() + ".png", System.Drawing.Imaging.ImageFormat.Png);

            Properties.Settings.Default.Counter = Properties.Settings.Default.Counter + 1;
            Properties.Settings.Default.Save();
        }
    }
}
