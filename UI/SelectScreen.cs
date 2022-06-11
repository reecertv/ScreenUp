using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenUp.UI
{
    public partial class SelectScreen : Form
    {
        int DetectedScreens = 0;
        string SName1, SName2, SName3, SName4, SName5, SName6;
        Rectangle SBounds1, SBounds2, SBounds3, SBounds4, SBounds5, SBounds6;
        string SWA1, SWA2, SWA3, SWA4, SWA5, SWA6;

        Rectangle BoundsSelectedScreen;

        public SelectScreen()
        {
            InitializeComponent();
        }

        private void SelectScreen_Load(object sender, EventArgs e)
        {
            foreach (var s in Screen.AllScreens)
            {
                DetectedScreens++;

                if (DetectedScreens == 1)
                {
                    btnScreen1.ImageIndex = 1;
                    SBounds1 = s.Bounds;
                }
                else if (DetectedScreens == 2)
                {
                    btnScreen2.ImageIndex = 1;
                    SBounds2 = s.Bounds;
                }
                else if (DetectedScreens == 3)
                {
                    btnScreen3.ImageIndex = 1;
                    SBounds3 = s.Bounds;
                }
                else if (DetectedScreens == 4)
                {
                    btnScreen3.ImageIndex = 1;
                    SBounds4 = s.Bounds;
                }
                else if (DetectedScreens == 5)
                {
                    btnScreen3.ImageIndex = 1;
                    SBounds5 = s.Bounds;
                }
                else if (DetectedScreens == 6)
                {
                    btnScreen3.ImageIndex = 1;
                    SBounds6 = s.Bounds;
                }               
            }

            if (DetectedScreens < 2)
            {
                btnScreen2.Enabled = false;
            }
            if (DetectedScreens < 3)
            {
                btnScreen3.Enabled = false;
            }
            if (DetectedScreens < 4)
            {
                btnScreen4.Enabled = false;
            }
            if (DetectedScreens < 5)
            {
                btnScreen5.Enabled = false;
            }
            if (DetectedScreens < 6)
            {
                btnScreen6.Enabled = false;
            }
        }

        // Left Click
        private void btnScreen1_Click(object sender, EventArgs e)
        {          
            Properties.Settings.Default.BoundsSelectedScreens = SBounds1;
            Properties.Settings.Default.Screen = 1;
            Properties.Settings.Default.Save();

            this.Close();
        }
        private void btnScreen2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BoundsSelectedScreens = SBounds2;
            Properties.Settings.Default.Screen = 2;
            Properties.Settings.Default.Save();

            this.Close();
        }
        private void btnScreen3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BoundsSelectedScreens = SBounds3;
            Properties.Settings.Default.Screen = 3;
            Properties.Settings.Default.Save();

            this.Close();
        }
        private void btnScreen4_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BoundsSelectedScreens = SBounds4;
            Properties.Settings.Default.Screen = 4;
            Properties.Settings.Default.Save();

            this.Close();
        }
        private void btnScreen5_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BoundsSelectedScreens = SBounds5;
            Properties.Settings.Default.Screen = 5;
            Properties.Settings.Default.Save();

            this.Close();
        }
        private void btnScreen6_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BoundsSelectedScreens = SBounds6;
            Properties.Settings.Default.Screen = 6;
            Properties.Settings.Default.Save();

            this.Close();
        }      
    }
}
