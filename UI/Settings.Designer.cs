namespace ScreenUp.UI
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.line = new System.Windows.Forms.TextBox();
            this.labTitle = new System.Windows.Forms.Label();
            this.labSelectScreen = new System.Windows.Forms.Label();
            this.btnSelectScreen = new System.Windows.Forms.Button();
            this.btnReSetup = new System.Windows.Forms.Button();
            this.labReSetup = new System.Windows.Forms.Label();
            this.btnSelectColour = new System.Windows.Forms.Button();
            this.labSelectColour = new System.Windows.Forms.Label();
            this.cd1 = new System.Windows.Forms.ColorDialog();
            this.fd1 = new System.Windows.Forms.FontDialog();
            this.labLang = new System.Windows.Forms.Label();
            this.btnLang_en = new System.Windows.Forms.Button();
            this.imgLang = new System.Windows.Forms.ImageList(this.components);
            this.btnLang_de = new System.Windows.Forms.Button();
            this.btnLang_es = new System.Windows.Forms.Button();
            this.btnLang_ja = new System.Windows.Forms.Button();
            this.btnLang_fr = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.RoyalBlue;
            this.line.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.line.Location = new System.Drawing.Point(12, 49);
            this.line.Multiline = true;
            this.line.Name = "line";
            this.line.ReadOnly = true;
            this.line.Size = new System.Drawing.Size(360, 2);
            this.line.TabIndex = 3;
            // 
            // labTitle
            // 
            this.labTitle.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labTitle.Location = new System.Drawing.Point(12, 9);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(339, 37);
            this.labTitle.TabIndex = 2;
            this.labTitle.Text = "Settings";
            // 
            // labSelectScreen
            // 
            this.labSelectScreen.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSelectScreen.ForeColor = System.Drawing.Color.LightBlue;
            this.labSelectScreen.Location = new System.Drawing.Point(12, 54);
            this.labSelectScreen.Name = "labSelectScreen";
            this.labSelectScreen.Size = new System.Drawing.Size(113, 30);
            this.labSelectScreen.TabIndex = 4;
            this.labSelectScreen.Text = "Screen:";
            this.labSelectScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSelectScreen
            // 
            this.btnSelectScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSelectScreen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSelectScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectScreen.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectScreen.ForeColor = System.Drawing.Color.LightBlue;
            this.btnSelectScreen.Location = new System.Drawing.Point(131, 57);
            this.btnSelectScreen.Name = "btnSelectScreen";
            this.btnSelectScreen.Size = new System.Drawing.Size(241, 30);
            this.btnSelectScreen.TabIndex = 8;
            this.btnSelectScreen.Text = "Select Screen";
            this.btnSelectScreen.UseVisualStyleBackColor = false;
            this.btnSelectScreen.Click += new System.EventHandler(this.btnSelectScreen_Click);
            // 
            // btnReSetup
            // 
            this.btnReSetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnReSetup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnReSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReSetup.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReSetup.ForeColor = System.Drawing.Color.LightBlue;
            this.btnReSetup.Location = new System.Drawing.Point(131, 93);
            this.btnReSetup.Name = "btnReSetup";
            this.btnReSetup.Size = new System.Drawing.Size(241, 30);
            this.btnReSetup.TabIndex = 14;
            this.btnReSetup.Text = "Setup";
            this.btnReSetup.UseVisualStyleBackColor = false;
            this.btnReSetup.Click += new System.EventHandler(this.btnReSetup_Click);
            // 
            // labReSetup
            // 
            this.labReSetup.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labReSetup.ForeColor = System.Drawing.Color.LightBlue;
            this.labReSetup.Location = new System.Drawing.Point(12, 90);
            this.labReSetup.Name = "labReSetup";
            this.labReSetup.Size = new System.Drawing.Size(113, 30);
            this.labReSetup.TabIndex = 15;
            this.labReSetup.Text = "Re-Setup:";
            this.labReSetup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSelectColour
            // 
            this.btnSelectColour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSelectColour.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSelectColour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectColour.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectColour.ForeColor = System.Drawing.Color.LightBlue;
            this.btnSelectColour.Location = new System.Drawing.Point(131, 129);
            this.btnSelectColour.Name = "btnSelectColour";
            this.btnSelectColour.Size = new System.Drawing.Size(241, 30);
            this.btnSelectColour.TabIndex = 16;
            this.btnSelectColour.Text = "Select Color";
            this.btnSelectColour.UseVisualStyleBackColor = false;
            this.btnSelectColour.Click += new System.EventHandler(this.btnSelectColor_Click);
            // 
            // labSelectColour
            // 
            this.labSelectColour.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSelectColour.ForeColor = System.Drawing.Color.LightBlue;
            this.labSelectColour.Location = new System.Drawing.Point(12, 126);
            this.labSelectColour.Name = "labSelectColour";
            this.labSelectColour.Size = new System.Drawing.Size(113, 30);
            this.labSelectColour.TabIndex = 17;
            this.labSelectColour.Text = "Colour:";
            this.labSelectColour.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cd1
            // 
            this.cd1.Color = System.Drawing.Color.RoyalBlue;
            // 
            // fd1
            // 
            this.fd1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // labLang
            // 
            this.labLang.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLang.ForeColor = System.Drawing.Color.LightBlue;
            this.labLang.Location = new System.Drawing.Point(12, 168);
            this.labLang.Name = "labLang";
            this.labLang.Size = new System.Drawing.Size(113, 30);
            this.labLang.TabIndex = 19;
            this.labLang.Text = "Language:";
            this.labLang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLang_en
            // 
            this.btnLang_en.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnLang_en.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLang_en.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnLang_en.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLang_en.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLang_en.ForeColor = System.Drawing.Color.LightBlue;
            this.btnLang_en.ImageIndex = 0;
            this.btnLang_en.ImageList = this.imgLang;
            this.btnLang_en.Location = new System.Drawing.Point(131, 165);
            this.btnLang_en.Name = "btnLang_en";
            this.btnLang_en.Size = new System.Drawing.Size(43, 43);
            this.btnLang_en.TabIndex = 20;
            this.btnLang_en.UseVisualStyleBackColor = false;
            this.btnLang_en.Click += new System.EventHandler(this.btnLang_en_Click);
            // 
            // imgLang
            // 
            this.imgLang.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLang.ImageStream")));
            this.imgLang.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLang.Images.SetKeyName(0, "en_uk.png");
            this.imgLang.Images.SetKeyName(1, "de_de.png");
            this.imgLang.Images.SetKeyName(2, "es_es.png");
            this.imgLang.Images.SetKeyName(3, "fr_fr.png");
            this.imgLang.Images.SetKeyName(4, "ja_jp.png");
            // 
            // btnLang_de
            // 
            this.btnLang_de.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnLang_de.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLang_de.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnLang_de.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLang_de.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLang_de.ForeColor = System.Drawing.Color.LightBlue;
            this.btnLang_de.ImageIndex = 1;
            this.btnLang_de.ImageList = this.imgLang;
            this.btnLang_de.Location = new System.Drawing.Point(180, 165);
            this.btnLang_de.Name = "btnLang_de";
            this.btnLang_de.Size = new System.Drawing.Size(43, 43);
            this.btnLang_de.TabIndex = 21;
            this.btnLang_de.UseVisualStyleBackColor = false;
            this.btnLang_de.Click += new System.EventHandler(this.btnLang_de_Click);
            // 
            // btnLang_es
            // 
            this.btnLang_es.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnLang_es.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLang_es.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnLang_es.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLang_es.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLang_es.ForeColor = System.Drawing.Color.LightBlue;
            this.btnLang_es.ImageIndex = 2;
            this.btnLang_es.ImageList = this.imgLang;
            this.btnLang_es.Location = new System.Drawing.Point(230, 165);
            this.btnLang_es.Name = "btnLang_es";
            this.btnLang_es.Size = new System.Drawing.Size(43, 43);
            this.btnLang_es.TabIndex = 22;
            this.btnLang_es.UseVisualStyleBackColor = false;
            this.btnLang_es.Click += new System.EventHandler(this.btnLang_es_Click);
            // 
            // btnLang_ja
            // 
            this.btnLang_ja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnLang_ja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLang_ja.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnLang_ja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLang_ja.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLang_ja.ForeColor = System.Drawing.Color.LightBlue;
            this.btnLang_ja.ImageIndex = 4;
            this.btnLang_ja.ImageList = this.imgLang;
            this.btnLang_ja.Location = new System.Drawing.Point(329, 165);
            this.btnLang_ja.Name = "btnLang_ja";
            this.btnLang_ja.Size = new System.Drawing.Size(43, 43);
            this.btnLang_ja.TabIndex = 23;
            this.btnLang_ja.UseVisualStyleBackColor = false;
            this.btnLang_ja.Click += new System.EventHandler(this.btnLang_ja_Click);
            // 
            // btnLang_fr
            // 
            this.btnLang_fr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnLang_fr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLang_fr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnLang_fr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLang_fr.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLang_fr.ForeColor = System.Drawing.Color.LightBlue;
            this.btnLang_fr.ImageIndex = 3;
            this.btnLang_fr.ImageList = this.imgLang;
            this.btnLang_fr.Location = new System.Drawing.Point(280, 165);
            this.btnLang_fr.Name = "btnLang_fr";
            this.btnLang_fr.Size = new System.Drawing.Size(43, 43);
            this.btnLang_fr.TabIndex = 24;
            this.btnLang_fr.UseVisualStyleBackColor = false;
            this.btnLang_fr.Click += new System.EventHandler(this.btnLang_fr_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::ScreenUp.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(357, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(15, 15);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 13;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.btnLang_fr);
            this.Controls.Add(this.btnLang_ja);
            this.Controls.Add(this.btnLang_es);
            this.Controls.Add(this.btnLang_de);
            this.Controls.Add(this.btnLang_en);
            this.Controls.Add(this.labLang);
            this.Controls.Add(this.labSelectColour);
            this.Controls.Add(this.btnSelectColour);
            this.Controls.Add(this.labReSetup);
            this.Controls.Add(this.btnReSetup);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSelectScreen);
            this.Controls.Add(this.labSelectScreen);
            this.Controls.Add(this.line);
            this.Controls.Add(this.labTitle);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox line;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Label labSelectScreen;
        private System.Windows.Forms.Button btnSelectScreen;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Button btnReSetup;
        private System.Windows.Forms.Label labReSetup;
        private System.Windows.Forms.Button btnSelectColour;
        private System.Windows.Forms.Label labSelectColour;
        private System.Windows.Forms.ColorDialog cd1;
        private System.Windows.Forms.FontDialog fd1;
        private System.Windows.Forms.Label labLang;
        private System.Windows.Forms.Button btnLang_en;
        private System.Windows.Forms.Button btnLang_de;
        private System.Windows.Forms.Button btnLang_es;
        private System.Windows.Forms.Button btnLang_ja;
        private System.Windows.Forms.Button btnLang_fr;
        private System.Windows.Forms.ImageList imgLang;
    }
}