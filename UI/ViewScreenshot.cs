using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenUp.UI
{
    public partial class ViewScreenshot : Form
    {
        Rectangle bounds;
        Bitmap screenshot;
        Graphics graph;

        string month, day, year;

        public ViewScreenshot()
        {
            InitializeComponent();
        }

        private void ViewScreenshot_Load(object sender, EventArgs e)
        {
            Screenshot.TakeScreenshot();
       
            pbImage.Image = Screenshot.screenshot;

            // SC Name
            Generate.GenerateSCName();

            labScreenshotName.Text = Generate.SCName;

            // Date
            string scname = labScreenshotName.Text;
            int i = 0;

            StringBuilder buildY = new StringBuilder();
            StringBuilder buildM = new StringBuilder();
            StringBuilder buildD = new StringBuilder();

            foreach (char c in scname)
            {
                i = i + 1;

                if (i == 4 || i == 5 || i == 6 || i == 7)
                {
                    buildY.Append(c);
                }
                else if (i == 8 || i == 9 )
                {
                    buildM.Append(c);
                }
                else if (i == 10 || i == 11)
                {
                    buildD.Append(c);
                }
            }

            labDate.Text = buildM.ToString() + "." + buildD.ToString() + "." + buildY.ToString();

            // Res
            labRes.Text = Properties.Settings.Default.BoundsSelectedScreens.Width + "x" + Properties.Settings.Default.BoundsSelectedScreens.Height;

            // Round Corners
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(RoundCorners.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            // Discord
            DiscordRPC.Initialize();
        }

        private void ViewScreenshot_FormClosing(object sender, FormClosingEventArgs e)
        {
            DiscordRPC.Deinitialize();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(pbImage.Image);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            btnUpload = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DiscordRPC.Deinitialize();
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Export Screenshot";
            sfd.Filter = "Image Files (*.png)|*.png";
            sfd.FileName = labScreenshotName.Text;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pbImage.Image.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Generate.GenerateSCName();

            Rectangle bounds;
            Bitmap screenshot;
            Graphics graph;

            bounds = Screen.PrimaryScreen.Bounds;
            screenshot = new Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            graph = Graphics.FromImage(screenshot);
            graph.CopyFromScreen(0, 0, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy);

            screenshot.Save(Properties.Settings.Default.ScreenshotFolder + "/" + Generate.SCName + "-" + Properties.Settings.Default.Counter.ToString() + ".png", System.Drawing.Imaging.ImageFormat.Png);

            Properties.Settings.Default.Counter++;
            Properties.Settings.Default.Save();
        }
    }
}
