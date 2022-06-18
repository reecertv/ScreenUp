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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnSelectScreen_Click(object sender, EventArgs e)
        {
            Form SeS = new UI.SelectScreen();
            SeS.Show();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            // Round Corners
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(RoundCorners.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            // Theme
            Theme.Color.Line(line);
            Theme.Color.Title(labTitle);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReSetup_Click(object sender, EventArgs e)
        {
            Form SU = new UI.Setup();
            SU.Show();
        }

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            if (cd1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.ThemeColor = cd1.Color;
                Properties.Settings.Default.Save();
            }
        }
    }
}
