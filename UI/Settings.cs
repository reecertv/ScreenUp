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
        }
    }
}
