namespace ScreenUp.UI
{
    partial class Setup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup));
            this.labTitle = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.TextBox();
            this.labUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.labSCFolder = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.fbdMain = new System.Windows.Forms.FolderBrowserDialog();
            this.txtSCFolder = new System.Windows.Forms.TextBox();
            this.labHotkey = new System.Windows.Forms.Label();
            this.labError = new System.Windows.Forms.Label();
            this.btnBrowseFolder = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnBrowseFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labTitle.Location = new System.Drawing.Point(12, 9);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(91, 37);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "Setup";
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.RoyalBlue;
            this.line.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.line.Location = new System.Drawing.Point(12, 49);
            this.line.Multiline = true;
            this.line.Name = "line";
            this.line.ReadOnly = true;
            this.line.Size = new System.Drawing.Size(460, 2);
            this.line.TabIndex = 1;
            // 
            // labUsername
            // 
            this.labUsername.AutoSize = true;
            this.labUsername.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUsername.ForeColor = System.Drawing.Color.LightBlue;
            this.labUsername.Location = new System.Drawing.Point(14, 54);
            this.labUsername.Name = "labUsername";
            this.labUsername.Size = new System.Drawing.Size(111, 30);
            this.labUsername.TabIndex = 2;
            this.labUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.LightBlue;
            this.txtUsername.Location = new System.Drawing.Point(131, 58);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(341, 26);
            this.txtUsername.TabIndex = 3;
            // 
            // labSCFolder
            // 
            this.labSCFolder.AutoSize = true;
            this.labSCFolder.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSCFolder.ForeColor = System.Drawing.Color.LightBlue;
            this.labSCFolder.Location = new System.Drawing.Point(19, 89);
            this.labSCFolder.Name = "labSCFolder";
            this.labSCFolder.Size = new System.Drawing.Size(106, 30);
            this.labSCFolder.TabIndex = 4;
            this.labSCFolder.Text = "SC Folder:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.LightBlue;
            this.btnSave.Location = new System.Drawing.Point(12, 219);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(460, 30);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // fbdMain
            // 
            this.fbdMain.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // txtSCFolder
            // 
            this.txtSCFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtSCFolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSCFolder.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSCFolder.ForeColor = System.Drawing.Color.LightBlue;
            this.txtSCFolder.Location = new System.Drawing.Point(131, 93);
            this.txtSCFolder.Name = "txtSCFolder";
            this.txtSCFolder.ReadOnly = true;
            this.txtSCFolder.Size = new System.Drawing.Size(309, 26);
            this.txtSCFolder.TabIndex = 8;
            // 
            // labHotkey
            // 
            this.labHotkey.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHotkey.ForeColor = System.Drawing.Color.LightBlue;
            this.labHotkey.Location = new System.Drawing.Point(12, 150);
            this.labHotkey.Name = "labHotkey";
            this.labHotkey.Size = new System.Drawing.Size(460, 52);
            this.labHotkey.TabIndex = 9;
            this.labHotkey.Text = "Screenshot: Ctrl + F5";
            this.labHotkey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labError
            // 
            this.labError.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labError.ForeColor = System.Drawing.Color.Red;
            this.labError.Location = new System.Drawing.Point(12, 122);
            this.labError.Name = "labError";
            this.labError.Size = new System.Drawing.Size(460, 28);
            this.labError.TabIndex = 10;
            this.labError.Text = "Type in a Username and a valid Path!";
            this.labError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labError.Visible = false;
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseFolder.Image = global::ScreenUp.Properties.Resources.open_folder;
            this.btnBrowseFolder.Location = new System.Drawing.Point(446, 93);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(26, 26);
            this.btnBrowseFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBrowseFolder.TabIndex = 11;
            this.btnBrowseFolder.TabStop = false;
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::ScreenUp.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(457, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(15, 15);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 12;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBrowseFolder);
            this.Controls.Add(this.labError);
            this.Controls.Add(this.labHotkey);
            this.Controls.Add(this.txtSCFolder);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labSCFolder);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.labUsername);
            this.Controls.Add(this.line);
            this.Controls.Add(this.labTitle);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.ForeColor = System.Drawing.Color.LightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScreenUp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Setup_FormClosing);
            this.Load += new System.EventHandler(this.SetUpScreenshotFolder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBrowseFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.TextBox line;
        private System.Windows.Forms.Label labUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label labSCFolder;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.FolderBrowserDialog fbdMain;
        private System.Windows.Forms.TextBox txtSCFolder;
        private System.Windows.Forms.Label labHotkey;
        private System.Windows.Forms.Label labError;
        private System.Windows.Forms.PictureBox btnBrowseFolder;
        private System.Windows.Forms.PictureBox btnClose;
    }
}