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

            // Lang
            LoadLang();
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

        // Load Lang
        public void LoadLang()
        {
            labTitle.Text = Lang.LabTitle_Settings();
            labSelectScreen.Text = Lang.LabSelectScreen();
            btnSelectScreen.Text = Lang.BtnSelectScreen();
            labReSetup.Text = Lang.LabReSetup();
            btnReSetup.Text = Lang.BtnReSetup();
            labSelectColour.Text = Lang.LabSelectColour();
            btnSelectColour.Text = Lang.BtnSelectColour();
            labLang.Text = Lang.LabLang();

            if (Properties.Settings.Default.Lang == "en")
            {
                btnLang_en.Enabled = false;
                btnLang_de.Enabled = true;
                btnLang_es.Enabled = true;
                btnLang_fr.Enabled = true;
                btnLang_ja.Enabled = true;
            }
            else if (Properties.Settings.Default.Lang == "de")
            {
                btnLang_en.Enabled = true;
                btnLang_de.Enabled = false;
                btnLang_es.Enabled = true;
                btnLang_fr.Enabled = true;
                btnLang_ja.Enabled = true;
            }
            else if (Properties.Settings.Default.Lang == "es")
            {
                btnLang_en.Enabled = true;
                btnLang_de.Enabled = true;
                btnLang_es.Enabled = false;
                btnLang_fr.Enabled = true;
                btnLang_ja.Enabled = true;
            }
            else if (Properties.Settings.Default.Lang == "fr")
            {
                btnLang_en.Enabled = true;
                btnLang_de.Enabled = true;
                btnLang_es.Enabled = true;
                btnLang_fr.Enabled = false;
                btnLang_ja.Enabled = true;
            }
            else if (Properties.Settings.Default.Lang == "ja")
            {
                btnLang_en.Enabled = true;
                btnLang_de.Enabled = true;
                btnLang_es.Enabled = true;
                btnLang_fr.Enabled = true;
                btnLang_ja.Enabled = false;
            }
        }

        private void btnLang_en_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Lang = "en";
            Properties.Settings.Default.Save();

            LoadLang();
        }

        private void btnLang_de_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Lang = "de";
            Properties.Settings.Default.Save();

            LoadLang();
        }

        private void btnLang_es_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Lang = "es";
            Properties.Settings.Default.Save();

            LoadLang();
        }

        private void btnLang_fr_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Lang = "fr";
            Properties.Settings.Default.Save();

            LoadLang();
        }

        private void btnLang_ja_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Lang = "ja";
            Properties.Settings.Default.Save();

            LoadLang();
        }
    }
}
