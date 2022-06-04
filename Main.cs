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

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            HK.OwnerForm = this;
            HK.HotKeyPressed += new HotKey.HotKeyPressedEventHandler(HK_HotKeyPressed);
            HK.AddHotKey(Keys.F6, HotKey.MODKEY.MOD_CONTROL, "Screenshot");
        }

        private void HK_HotKeyPressed(string ID)
        {
            Form VS = new UI.ViewScreenshot();
            VS.Show();
        }

        
    }


}
