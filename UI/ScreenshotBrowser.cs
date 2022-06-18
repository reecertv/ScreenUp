using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenUp.UI
{
    public partial class ScreenshotBrowser : Form
    {
        public string SelectedFile;
        public string ExportFileName;

        public ScreenshotBrowser()
        {
            InitializeComponent();
        }

        private void ScreenshotBrowser_Load(object sender, EventArgs e)
        {
            // Load Old Size
            try
            {
                this.Size = Properties.Settings.Default.LasteFormSize;
                Console.Write("Old size was loaded!");
            }
            catch
            {
                Console.Write("Old size was not loaded!");
            }

            // TreeView
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
                if (di.Name.Contains(".png") || di.Name.Contains(".jpg") || di.Name.Contains(".jpeg") || di.Name.Contains(".ico") || di.Name.Contains(".irt"))
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
            Console.Write(dir);
            string[] subdirectoryEntries = Directory.GetDirectories(dir);

            foreach (string subdirectory in subdirectoryEntries)
            {
                LoadSubDirs(subdirectory);
            }
        }

        private void treeFolder_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            ExportFileName = ((FileInfo)e.Node.Tag).Name;

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

                    if (di.Name.Contains(".png") || di.Name.Contains(".jpg") || di.Name.Contains(".jpeg") || di.Name.Contains(".ico") || di.Name.Contains(".irt"))
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
                SelectedFile = ((FileInfo)e.Node.Tag).FullName;

                e.Node.SelectedImageIndex = 0;

                if (SelectedFile.Contains(".png") || SelectedFile.Contains(".jpg") || SelectedFile.Contains(".jpeg") || SelectedFile.Contains(".ico"))
                {
                    try
                    {
                        pbImage.Visible = true;
                        pbImage.Image = Image.FromFile(SelectedFile);

                        e.Node.SelectedImageIndex = 0;

                        btnUpload.Visible = true;
                        btnExport.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex.Message);
                    }
                }
                else if (SelectedFile.Contains(".irt"))
                {
                    try
                    {
                        pbImage.Visible = true;

                        byte[] img = File.ReadAllBytes(SelectedFile);
                        MemoryStream ms = new MemoryStream(img);
                        pbImage.Image = Image.FromStream(ms);

                        e.Node.SelectedImageIndex = 0;

                        btnUpload.Visible = true;
                        btnExport.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex.Message);
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
            Properties.Settings.Default.LasteFormSize = this.Size;
            Properties.Settings.Default.Save();

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
                Console.Write(ex.Message);
            }
        }

        private void ScreenshotBrowser_FormClosed(object sender, FormClosedEventArgs e)
        {
            pbImage.Image = null;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Generate.GenerateSCName();

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Export Screenshot";
            sfd.Filter = "Image Files (*.png)|*.png";
            sfd.FileName = ExportFileName.Replace(".irt", "");
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pbImage.Image.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }
    }
}
