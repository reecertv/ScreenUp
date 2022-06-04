namespace ScreenUp.UI
{
    partial class ViewScreenshot
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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.labScreenshotName = new System.Windows.Forms.Label();
            this.labDate = new System.Windows.Forms.Label();
            this.labUser = new System.Windows.Forms.Label();
            this.BoxTools = new System.Windows.Forms.GroupBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.labRes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.BoxTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(384, 216);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // labScreenshotName
            // 
            this.labScreenshotName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labScreenshotName.AutoSize = true;
            this.labScreenshotName.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labScreenshotName.Location = new System.Drawing.Point(12, 219);
            this.labScreenshotName.Name = "labScreenshotName";
            this.labScreenshotName.Size = new System.Drawing.Size(142, 30);
            this.labScreenshotName.TabIndex = 1;
            this.labScreenshotName.Text = "SC-20220101";
            // 
            // labDate
            // 
            this.labDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labDate.AutoSize = true;
            this.labDate.Location = new System.Drawing.Point(12, 249);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(61, 13);
            this.labDate.TabIndex = 2;
            this.labDate.Text = "01.01.2022";
            // 
            // labUser
            // 
            this.labUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labUser.AutoSize = true;
            this.labUser.Location = new System.Drawing.Point(145, 249);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(61, 13);
            this.labUser.TabIndex = 3;
            this.labUser.Text = "User#2334";
            // 
            // BoxTools
            // 
            this.BoxTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxTools.Controls.Add(this.btnUpload);
            this.BoxTools.Controls.Add(this.btnExport);
            this.BoxTools.Controls.Add(this.btnSave);
            this.BoxTools.Controls.Add(this.btnCopy);
            this.BoxTools.Location = new System.Drawing.Point(12, 265);
            this.BoxTools.Name = "BoxTools";
            this.BoxTools.Size = new System.Drawing.Size(360, 184);
            this.BoxTools.TabIndex = 4;
            this.BoxTools.TabStop = false;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(6, 21);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(168, 35);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(186, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(168, 35);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(6, 62);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(348, 35);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpload.Location = new System.Drawing.Point(6, 145);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(348, 35);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // labRes
            // 
            this.labRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labRes.AutoSize = true;
            this.labRes.Location = new System.Drawing.Point(79, 249);
            this.labRes.Name = "labRes";
            this.labRes.Size = new System.Drawing.Size(60, 13);
            this.labRes.TabIndex = 5;
            this.labRes.Text = "1920x1080";
            // 
            // ViewScreenshot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.labRes);
            this.Controls.Add(this.BoxTools);
            this.Controls.Add(this.labUser);
            this.Controls.Add(this.labDate);
            this.Controls.Add(this.labScreenshotName);
            this.Controls.Add(this.pbImage);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "ViewScreenshot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View";
            this.Load += new System.EventHandler(this.ViewScreenshot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.BoxTools.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label labScreenshotName;
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.Label labUser;
        private System.Windows.Forms.GroupBox BoxTools;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label labRes;
    }
}