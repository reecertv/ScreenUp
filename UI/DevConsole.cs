using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenUp.UI
{
    public partial class DevConsole : Form
    {
        public DevConsole()
        {
            InitializeComponent();
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConsoleInput.SetInput(txtInput.Text);
                ConsoleInput.ProofInput();
                txtInput.Clear();
            }
        }

        private void txtInput_DragDrop(object sender, DragEventArgs e)
        {
            string data = (string)e.Data.GetData(DataFormats.Text, false);

            txtInput.Text = data;
        }

        private void txtInput_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            { 
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Reload_Tick(object sender, EventArgs e)
        {
            rtxOutput.Text = Console.log;
        }

        private void DevConsole_Load(object sender, EventArgs e)
        {
            // Theme
            Theme.Color.Line(line);
            Theme.Color.Title(labTitle);

            // Round Corners
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(RoundCorners.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
    }
}
