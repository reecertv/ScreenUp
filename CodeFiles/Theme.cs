using System.Windows.Forms;

namespace ScreenUp.Theme
{
    public class Color
    {
        public static void Line(TextBox obj)
        {
            obj.BackColor = Properties.Settings.Default.ThemeColor;
        }

        public static void Title(Label obj)
        {
            obj.ForeColor = Properties.Settings.Default.ThemeColor;
        }
    }
}