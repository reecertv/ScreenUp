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
using IWshRuntimeLibrary;

namespace ScreenUp
{
    public partial class Main : Form
    {
        private HotKey HK = new HotKey();
        private HotKey HK2 = new HotKey();
        private HotKey HK3 = new HotKey();
        private HotKey HK4 = new HotKey();

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

            try
            {
                HK.RemoveHotKey("Screenshot");
                HK2.RemoveHotKey("SCBrowser");
                HK3.RemoveHotKey("SilentScreenshot");
                HK4.RemoveHotKey("Settings");
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            
            HK.OwnerForm = this;
            HK.HotKeyPressed += new HotKey.HotKeyPressedEventHandler(HK_HotKeyPressed);
            HK.AddHotKey(Keys.F5, HotKey.MODKEY.MOD_CONTROL, "Screenshot");

            HK2.OwnerForm = this;
            HK2.HotKeyPressed += new HotKey.HotKeyPressedEventHandler(HK2_HotKeyPressed);
            HK2.AddHotKey(Keys.F7, HotKey.MODKEY.MOD_CONTROL, "SCBrowser");

            HK3.OwnerForm = this;
            HK3.HotKeyPressed += new HotKey.HotKeyPressedEventHandler(HK3_HotKeyPressed);
            HK3.AddHotKey(Keys.F6, HotKey.MODKEY.MOD_CONTROL, "SilentScreenshot");

            HK4.OwnerForm = this;
            HK4.HotKeyPressed += new HotKey.HotKeyPressedEventHandler(HK4_HotKeyPressed);
            HK4.AddHotKey(Keys.F8, HotKey.MODKEY.MOD_CONTROL, "Settings");

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

            // Dev
            Console.Write("Loading to " + Environment.MachineName + " was successful");

            //Form C = new UI.DevConsole();
            //C.Show();
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
            Generate.GenerateSCName();

            Screenshot.TakeScreenshot();

            Screenshot.screenshot.Save(Properties.Settings.Default.ScreenshotFolder + "/" + Generate.SCName + "-" + Properties.Settings.Default.Counter.ToString() + ".irt", System.Drawing.Imaging.ImageFormat.Png);

            Properties.Settings.Default.Counter++;
            Properties.Settings.Default.Save();
        }

        private void HK4_HotKeyPressed(string ID)
        {
            Form ST = new UI.Settings();
            ST.Show();
        }

        public static void RefreshForm(Form Form)
        {
            Form obj = new UI.ScreenshotBrowser();

            Form.Close();
            obj.Show();
        }
    }
}
