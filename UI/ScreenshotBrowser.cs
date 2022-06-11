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
    public partial class ScreenshotBrowser : Form
    {
        public string CodeFile;

        public ScreenshotBrowser()
        {
            InitializeComponent();
        }

        private void ScreenshotBrowser_Load(object sender, EventArgs e)
        {
            string folder = Properties.Settings.Default.ScreenshotFolder;

            treeFolder.Nodes.Clear();

            foreach (var item in Directory.GetDirectories(folder))
            {
                DirectoryInfo di = new DirectoryInfo(item);
                var node = treeFolder.Nodes.Add(di.Name, di.Name, 0);
                node.Tag = di;
            }

            foreach (var item in Directory.GetFiles(folder))
            {
                FileInfo di = new FileInfo(item);
                if (di.Name.Contains(".png") || di.Name.Contains(".jpg") || di.Name.Contains(".jpeg") || di.Name.Contains(".ico") || di.Name.Contains(".sus"))
                {
                    var node = treeFolder.Nodes.Add(di.Name, di.Name, 0);
                    node.Tag = di;
                }
                else
                {
                    var node = treeFolder.Nodes.Add(di.Name, di.Name, 0);
                    node.Tag = di;
                }
            }
        }

        private void LoadSubDirs(string dir)
        {
            Console.WriteLine(dir);
            string[] subdirectoryEntries = Directory.GetDirectories(dir);

            foreach (string subdirectory in subdirectoryEntries)
            {
                LoadSubDirs(subdirectory);
            }

        }

        private void treeFolder_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag == null)
            {
                //return
            }
            else if (e.Node.Tag.GetType() == typeof(DirectoryInfo))
            {
                // folder
                e.Node.Nodes.Clear();
                foreach (var item in Directory.GetDirectories(((DirectoryInfo)e.Node.Tag).FullName))
                {
                    DirectoryInfo di = new DirectoryInfo(item);
                    var node = e.Node.Nodes.Add(di.Name, di.Name, 0);
                    node.Tag = di;
                }

                foreach (var item in Directory.GetFiles(((DirectoryInfo)e.Node.Tag).FullName))
                {
                    FileInfo di = new FileInfo(item);


                    if (di.Name.Contains(".png") || di.Name.Contains(".jpg") || di.Name.Contains(".jpeg") || di.Name.Contains(".ico") || di.Name.Contains(".sus"))
                    {
                        var node = e.Node.Nodes.Add(di.Name, di.Name, 0);
                        node.Tag = di;
                    }
                    else
                    {
                        var node = e.Node.Nodes.Add(di.Name, di.Name, 0);
                        node.Tag = di;
                    }
                }
            }
            else
            {
                // openfile
                CodeFile = ((FileInfo)e.Node.Tag).FullName;

                e.Node.SelectedImageIndex = 0;

                if (CodeFile.Contains(".png") || CodeFile.Contains(".jpg") || CodeFile.Contains(".jpeg") || CodeFile.Contains(".ico") || CodeFile.Contains(".sus"))
                {
                    try
                    {
                        pbImage.Visible = true;
                        pbImage.Image = Image.FromFile(CodeFile);

                        e.Node.SelectedImageIndex = 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    pbImage.Visible = false;
                }
            }
        }

        // Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (pbImage.Image != null)
                {
                    pbImage.Image.Dispose();
                }

                string path = Properties.Settings.Default.ScreenshotFolder;
                string[] files = Directory.GetFiles(path);

                foreach (string file in files)
                {
                    File.Delete(file);
                }

                Main.RefreshForm(this);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.Size = new Size(75, 75); 
        }
        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.Size = new Size(50, 50);
        }

        private void ScreenshotBrowser_FormClosed(object sender, FormClosedEventArgs e)
        {
            pbImage.Image = null;
        }
    }
}
