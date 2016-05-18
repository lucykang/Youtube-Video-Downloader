namespace YoutubeDownloader
{
    partial class YoutubeDownloader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoutubeDownloader));
            this.youtubeWebBrowser = new System.Windows.Forms.WebBrowser();
            this.youtubeMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.videoQualityLabel = new System.Windows.Forms.Label();
            this.saveLocationLabel = new System.Windows.Forms.Label();
            this.videoQualityComboBox = new System.Windows.Forms.ComboBox();
            this.saveLocationTextBox = new System.Windows.Forms.TextBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.downloadProgressBar = new System.Windows.Forms.ProgressBar();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.youtubeSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.youtubeMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // youtubeWebBrowser
            // 
            this.youtubeWebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.youtubeWebBrowser.Location = new System.Drawing.Point(12, 62);
            this.youtubeWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.youtubeWebBrowser.Name = "youtubeWebBrowser";
            this.youtubeWebBrowser.Size = new System.Drawing.Size(703, 255);
            this.youtubeWebBrowser.TabIndex = 0;
            this.youtubeWebBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.youtubeWebBrowser_Navigated);
            // 
            // youtubeMenuStrip
            // 
            this.youtubeMenuStrip.BackColor = System.Drawing.SystemColors.MenuBar;
            this.youtubeMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.youtubeMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.youtubeMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.youtubeMenuStrip.Name = "youtubeMenuStrip";
            this.youtubeMenuStrip.Size = new System.Drawing.Size(727, 28);
            this.youtubeMenuStrip.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTextBox.Location = new System.Drawing.Point(12, 31);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(622, 25);
            this.addressTextBox.TabIndex = 0;
            this.addressTextBox.Text = "www.youtube.com";
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.BackColor = System.Drawing.Color.Red;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchBtn.Location = new System.Drawing.Point(640, 30);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 26);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // videoQualityLabel
            // 
            this.videoQualityLabel.AutoSize = true;
            this.videoQualityLabel.Location = new System.Drawing.Point(18, 326);
            this.videoQualityLabel.Name = "videoQualityLabel";
            this.videoQualityLabel.Size = new System.Drawing.Size(104, 15);
            this.videoQualityLabel.TabIndex = 5;
            this.videoQualityLabel.Text = "Video Quality: ";
            // 
            // saveLocationLabel
            // 
            this.saveLocationLabel.AutoSize = true;
            this.saveLocationLabel.Location = new System.Drawing.Point(19, 380);
            this.saveLocationLabel.Name = "saveLocationLabel";
            this.saveLocationLabel.Size = new System.Drawing.Size(113, 15);
            this.saveLocationLabel.TabIndex = 6;
            this.saveLocationLabel.Text = "Save Location: ";
            // 
            // videoQualityComboBox
            // 
            this.videoQualityComboBox.FormattingEnabled = true;
            this.videoQualityComboBox.Location = new System.Drawing.Point(17, 344);
            this.videoQualityComboBox.Name = "videoQualityComboBox";
            this.videoQualityComboBox.Size = new System.Drawing.Size(489, 23);
            this.videoQualityComboBox.TabIndex = 2;
            this.videoQualityComboBox.Click += new System.EventHandler(this.videoQualityComboBox_Click);
            // 
            // saveLocationTextBox
            // 
            this.saveLocationTextBox.Location = new System.Drawing.Point(18, 399);
            this.saveLocationTextBox.Name = "saveLocationTextBox";
            this.saveLocationTextBox.Size = new System.Drawing.Size(405, 25);
            this.saveLocationTextBox.TabIndex = 3;
            // 
            // browseBtn
            // 
            this.browseBtn.BackColor = System.Drawing.Color.Red;
            this.browseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.browseBtn.Location = new System.Drawing.Point(431, 399);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 25);
            this.browseBtn.TabIndex = 4;
            this.browseBtn.Text = "&Browse";
            this.browseBtn.UseVisualStyleBackColor = false;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // downloadProgressBar
            // 
            this.downloadProgressBar.Location = new System.Drawing.Point(529, 408);
            this.downloadProgressBar.Name = "downloadProgressBar";
            this.downloadProgressBar.Size = new System.Drawing.Size(185, 13);
            this.downloadProgressBar.TabIndex = 10;
            // 
            // downloadBtn
            // 
            this.downloadBtn.BackColor = System.Drawing.Color.Red;
            this.downloadBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.downloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadBtn.ForeColor = System.Drawing.Color.Snow;
            this.downloadBtn.Location = new System.Drawing.Point(529, 333);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(185, 51);
            this.downloadBtn.TabIndex = 5;
            this.downloadBtn.Text = "&Download Now";
            this.downloadBtn.UseVisualStyleBackColor = false;
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // youtubeSaveFileDialog
            // 
            this.youtubeSaveFileDialog.RestoreDirectory = true;
            // 
            // YoutubeDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(727, 447);
            this.Controls.Add(this.downloadBtn);
            this.Controls.Add(this.downloadProgressBar);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.saveLocationTextBox);
            this.Controls.Add(this.videoQualityComboBox);
            this.Controls.Add(this.saveLocationLabel);
            this.Controls.Add(this.videoQualityLabel);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.youtubeWebBrowser);
            this.Controls.Add(this.youtubeMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.youtubeMenuStrip;
            this.Name = "YoutubeDownloader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Youtube Downloader";
            this.youtubeMenuStrip.ResumeLayout(false);
            this.youtubeMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser youtubeWebBrowser;
        private System.Windows.Forms.MenuStrip youtubeMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label videoQualityLabel;
        private System.Windows.Forms.Label saveLocationLabel;
        private System.Windows.Forms.ComboBox videoQualityComboBox;
        private System.Windows.Forms.TextBox saveLocationTextBox;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.ProgressBar downloadProgressBar;
        private System.Windows.Forms.Button downloadBtn;
        private System.Windows.Forms.SaveFileDialog youtubeSaveFileDialog;
    }
}

