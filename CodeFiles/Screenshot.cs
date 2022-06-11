using System.Drawing;

namespace ScreenUp
{
    public class Screenshot
    {
        public static Bitmap screenshot;
        public static Graphics graphics;

        public static void TakeScreenshot()
        {
            screenshot = new Bitmap(Properties.Settings.Default.BoundsSelectedScreens.Width, Properties.Settings.Default.BoundsSelectedScreens.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            graphics = Graphics.FromImage(screenshot);
            // Take the screenshot from the upper left corner to the right bottom corner
            graphics.CopyFromScreen(Properties.Settings.Default.BoundsSelectedScreens.X, Properties.Settings.Default.BoundsSelectedScreens.Y, 0, 0, Properties.Settings.Default.BoundsSelectedScreens.Size, CopyPixelOperation.SourceCopy);
        }
    }
}