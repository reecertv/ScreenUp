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
            this.line = new System.Windows.Forms.TextBox();
            this.labTitle = new System.Windows.Forms.Label();
            this.labUsername = new System.Windows.Forms.Label();
            this.btnSelectScreen = new System.Windows.Forms.Button();
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
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labTitle.Location = new System.Drawing.Point(12, 9);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(91, 37);
            this.labTitle.TabIndex = 2;
            this.labTitle.Text = "Setup";
            // 
            // labUsername
            // 
            this.labUsername.AutoSize = true;
            this.labUsername.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUsername.ForeColor = System.Drawing.Color.LightBlue;
            this.labUsername.Location = new System.Drawing.Point(45, 54);
            this.labUsername.Name = "labUsername";
            this.labUsername.Size = new System.Drawing.Size(80, 30);
            this.labUsername.TabIndex = 4;
            this.labUsername.Text = "Screen:";
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
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSelectScreen);
            this.Controls.Add(this.labUsername);
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
        private System.Windows.Forms.Label labUsername;
        private System.Windows.Forms.Button btnSelectScreen;
        private System.Windows.Forms.PictureBox btnClose;
    }
}