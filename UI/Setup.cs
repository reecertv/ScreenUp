using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenUp.UI
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
        }

        private void SetUpScreenshotFolder_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(RoundCorners.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            if (Properties.Settings.Default.FirstStart == 0)
            {
                Properties.Settings.Default.BoundsSelectedScreens = Screen.PrimaryScreen.Bounds;
            }

            // Theme
            Theme.Color.Line(line);
            Theme.Color.Title(labTitle);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtSCFolder.Text == "")
            {
                labError.Visible = true;
            }
            else
            {
                Properties.Settings.Default.User = txtUsername.Text;
                Properties.Settings.Default.FirstStart = 1;
                Properties.Settings.Default.Save();

                // StartUp
                WshShell wshShell = new WshShell();
                IWshRuntimeLibrary.IWshShortcut shortcut;
                string startUpFolderPath =
                  Environment.GetFolderPath(Environment.SpecialFolder.Startup);

                shortcut =
                  wshShell.CreateShortcut(
                    startUpFolderPath + "\\" +
                    Application.ProductName + ".lnk");

                shortcut.TargetPath = Application.ExecutablePath;
                shortcut.WorkingDirectory = Application.StartupPath;
                shortcut.Description = "Launch";
                // shortcut.IconLocation = Application.StartupPath + @"\App.ico";
                shortcut.Save();

                // Desktop
                WshShell wshShell2 = new WshShell();
                IWshRuntimeLibrary.IWshShortcut shortcut2;
                string DesktopFolderPath =
                  Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                shortcut2 =
                  wshShell2.CreateShortcut(
                    DesktopFolderPath + "\\" +
                    Application.ProductName + ".lnk");

                shortcut2.TargetPath = Application.ExecutablePath;
                shortcut2.WorkingDirectory = Application.StartupPath;
                shortcut2.Description = "Launch";
                // shortcut2.IconLocation = Application.StartupPath + @"\App.ico";
                shortcut2.Save();

                this.Hide();
            }          
        }

        private void Setup_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            fbdMain.Description = "Select Folder";

            if (fbdMain.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.ScreenshotFolder = fbdMain.SelectedPath;
                txtSCFolder.Text = fbdMain.SelectedPath;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
