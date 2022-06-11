namespace ScreenUp.UI
{
    partial class ScreenshotBrowser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenshotBrowser));
            this.treeFolder = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // treeFolder
            // 
            this.treeFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.treeFolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeFolder.ForeColor = System.Drawing.Color.LightBlue;
            this.treeFolder.ImageIndex = 0;
            this.treeFolder.ImageList = this.imageList1;
            this.treeFolder.LineColor = System.Drawing.Color.Blue;
            this.treeFolder.Location = new System.Drawing.Point(0, 0);
            this.treeFolder.Name = "treeFolder";
            this.treeFolder.SelectedImageIndex = 0;
            this.treeFolder.Size = new System.Drawing.Size(175, 461);
            this.treeFolder.TabIndex = 0;
            this.treeFolder.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeFolder_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "image.png");
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Image = global::ScreenUp.Properties.Resources.trash_bin;
            this.btnDelete.Location = new System.Drawing.Point(12, 399);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 50);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDelete.TabIndex = 2;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            // 
            // pbImage
            // 
            this.pbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImage.BackColor = System.Drawing.Color.Transparent;
            this.pbImage.Location = new System.Drawing.Point(181, 0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(603, 461);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            // 
            // ScreenshotBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.treeFolder);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.ForeColor = System.Drawing.Color.LightBlue;
            this.Name = "ScreenshotBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScreenUp - Screenshot Browser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ScreenshotBrowser_FormClosed);
            this.Load += new System.EventHandler(this.ScreenshotBrowser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeFolder;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox btnDelete;
    }
}