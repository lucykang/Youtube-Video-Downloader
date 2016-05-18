namespace YoutubeDownloader
{
    partial class SplashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.youtubeTimer = new System.Windows.Forms.Timer(this.components);
            this.developerLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.youtubeDownloaderPictureBox = new System.Windows.Forms.PictureBox();
            this.lastUpdatedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.youtubeDownloaderPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // youtubeTimer
            // 
            this.youtubeTimer.Enabled = true;
            this.youtubeTimer.Interval = 4000;
            this.youtubeTimer.Tick += new System.EventHandler(this.youtubeTimer_Tick);
            // 
            // developerLabel
            // 
            this.developerLabel.AutoSize = true;
            this.developerLabel.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.developerLabel.Location = new System.Drawing.Point(113, 274);
            this.developerLabel.Name = "developerLabel";
            this.developerLabel.Size = new System.Drawing.Size(172, 15);
            this.developerLabel.TabIndex = 1;
            this.developerLabel.Text = "Developer: Lucy Kang";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::YoutubeDownloader.Properties.Resources.yd;
            this.pictureBox1.Location = new System.Drawing.Point(68, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // youtubeDownloaderPictureBox
            // 
            this.youtubeDownloaderPictureBox.Image = global::YoutubeDownloader.Properties.Resources.youtube_icon;
            this.youtubeDownloaderPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("youtubeDownloaderPictureBox.InitialImage")));
            this.youtubeDownloaderPictureBox.Location = new System.Drawing.Point(111, 22);
            this.youtubeDownloaderPictureBox.Name = "youtubeDownloaderPictureBox";
            this.youtubeDownloaderPictureBox.Size = new System.Drawing.Size(226, 184);
            this.youtubeDownloaderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.youtubeDownloaderPictureBox.TabIndex = 0;
            this.youtubeDownloaderPictureBox.TabStop = false;
            // 
            // lastUpdatedLabel
            // 
            this.lastUpdatedLabel.AutoSize = true;
            this.lastUpdatedLabel.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lastUpdatedLabel.Location = new System.Drawing.Point(113, 293);
            this.lastUpdatedLabel.Name = "lastUpdatedLabel";
            this.lastUpdatedLabel.Size = new System.Drawing.Size(206, 15);
            this.lastUpdatedLabel.TabIndex = 3;
            this.lastUpdatedLabel.Text = "Last updated: 2016-04-04";
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(442, 327);
            this.ControlBox = false;
            this.Controls.Add(this.lastUpdatedLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.developerLabel);
            this.Controls.Add(this.youtubeDownloaderPictureBox);
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.youtubeDownloaderPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer youtubeTimer;
        private System.Windows.Forms.PictureBox youtubeDownloaderPictureBox;
        private System.Windows.Forms.Label developerLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lastUpdatedLabel;
    }
}