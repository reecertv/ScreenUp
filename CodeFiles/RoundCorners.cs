using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ScreenUp
{
    public class RoundCorners
    {
        public static void Form(Form obj)
        {
            obj.FormBorderStyle = FormBorderStyle.None;

            var DGP = new System.Drawing.Drawing2D.GraphicsPath();
            DGP.StartFigure();
            // top left corner
            DGP.AddArc(new Rectangle(0, 0, 30, 30), 180, 90);
            DGP.AddLine(30, 0, obj.Width - 30, 0);

            // top right corner
            DGP.AddArc(new Rectangle(obj.Width - 30, 0, 30, 30), -90, 90);
            DGP.AddLine(obj.Width, 30, obj.Width, obj.Height - 30);

            // bottom right corner
            DGP.AddArc(new Rectangle(obj.Width - 30, obj.Height - 30, 30, 30), 0, 90);
            DGP.AddLine(obj.Width - 30, obj.Height, 30, obj.Height);

            // bottom left corner
            DGP.AddArc(new Rectangle(0, obj.Height - 30, 30, 30), 90, 90);
            DGP.CloseFigure();

            obj.Region = new Region(DGP);
        }

        public static void Button(Button obj)
        {
            var DGP = new System.Drawing.Drawing2D.GraphicsPath();
            DGP.StartFigure();
            // top left corner
            DGP.AddArc(new Rectangle(0, 0, 30, 30), 180, 90);
            DGP.AddLine(30, 0, obj.Width - 30, 0);

            // top right corner
            DGP.AddArc(new Rectangle(obj.Width - 30, 0, 30, 30), -90, 90);
            DGP.AddLine(obj.Width, 30, obj.Width, obj.Height - 30);

            // bottom right corner
            DGP.AddArc(new Rectangle(obj.Width - 30, obj.Height - 30, 30, 30), 0, 90);
            DGP.AddLine(obj.Width - 30, obj.Height, 30, obj.Height);

            // bottom left corner
            DGP.AddArc(new Rectangle(0, obj.Height - 30, 30, 30), 90, 90);
            DGP.CloseFigure();

            obj.Region = new Region(DGP);
        }

        public static void Input(TextBox obj)
        {
            var DGP = new System.Drawing.Drawing2D.GraphicsPath();
            DGP.StartFigure();
            // top left corner
            DGP.AddArc(new Rectangle(0, 0, 10, 10), 180, 90);
            DGP.AddLine(10, 0, obj.Width - 10, 0);

            // top right corner
            DGP.AddArc(new Rectangle(obj.Width - 10, 0, 10, 10), -90, 90);
            DGP.AddLine(obj.Width, 10, obj.Width, obj.Height - 10);

            // bottom right corner
            DGP.AddArc(new Rectangle(obj.Width - 10, obj.Height - 10, 10, 10), 0, 90);
            DGP.AddLine(obj.Width - 10, obj.Height, 10, obj.Height);

            // bottom left corner
            DGP.AddArc(new Rectangle(0, obj.Height - 10, 10, 10), 90, 90);
            DGP.CloseFigure();

            obj.Region = new Region(DGP);
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
    }
}