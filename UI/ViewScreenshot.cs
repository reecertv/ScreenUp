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

        public ViewScreenshot()
        {
            InitializeComponent();
        }

        private void ViewScreenshot_Load(object sender, EventArgs e)
        {
            bounds = Screen.PrimaryScreen.Bounds;
            screenshot = new Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            graph = Graphics.FromImage(screenshot);
            graph.CopyFromScreen(0, 0, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy);
            pbImage.Image = screenshot;

            // SC Name
            string month, day, year;
            int intmonth = Convert.ToInt32(DateTime.Now.Month.ToString());
            int intday = Convert.ToInt32(DateTime.Now.Day.ToString());

            month = DateTime.Now.Month.ToString();
            day = DateTime.Now.Day.ToString();
            year = DateTime.Now.Year.ToString();

            if (intmonth < 10) 
            {
                month = "0" + DateTime.Now.Month.ToString();
            }
            if (intday < 10)
            {
                day = "0" + DateTime.Now.Day.ToString();
            }

            labScreenshotName.Text = "SC-" + year + month + day;

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
            labRes.Text = bounds.Width + "x" + bounds.Height;

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
    }
}
