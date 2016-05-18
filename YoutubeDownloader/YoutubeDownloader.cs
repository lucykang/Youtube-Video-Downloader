/*
Application name: Youtube Video Downloader
Last Updated: 2016-04-04
Developer: Hae Yeon Kang (Lucy)
Student #: 200294841
Description: This program will allow user to find a video on the browser and download the video in different resolution.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using YoutubeExtractor;
using System.IO;
using System.Threading.Tasks;

namespace YoutubeDownloader
{
    public partial class YoutubeDownloader : Form
    {
        //Global Variable
        string youTubeURLString;
        IEnumerable<VideoInfo> videoInfos;
        VideoInfo video;
        FileStream fileStream;
        YoutubeDownloaderAboutBox aboutForm = new YoutubeDownloaderAboutBox();

        public YoutubeDownloader()
        {
            InitializeComponent();
        }
        
        private void searchBtn_Click(object sender, EventArgs e)
        {
            youtubeWebBrowser.ScriptErrorsSuppressed = true;
            //navigate to the site entered in the url box
            youtubeWebBrowser.Navigate(addressTextBox.Text);
        }

        private void youtubeWebBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            //as you navigate through website, the address text box will display current url of the page
            addressTextBox.Text = youtubeWebBrowser.Url.OriginalString;
        }

        private void videoQualityComboBox_Click(object sender, EventArgs e)
        {
            // get YouTube URL link
            youTubeURLString = addressTextBox.Text;

            try//try the url from the address text box
            {
                // get all the available video formats
                videoInfos = DownloadUrlResolver.GetDownloadUrls(youTubeURLString);

                // get the info and show them in the selecting box
                foreach (VideoInfo videoInfo in videoInfos)
                {
                    videoQualityComboBox.Items.Add(videoInfo);
                }
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("The link on the address box is not valid. \nPlease enter valid address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            //getting the video depending on the quality that user choose
            video = videoInfos.ElementAt(videoQualityComboBox.SelectedIndex);

            //when browse button is clicked, it will show browser dialog and save the result from the dialog
            DialogResult saveDialogResult;

            // Initialize File Dialog
            youtubeSaveFileDialog.Title = "Save a Youtube video";
            youtubeSaveFileDialog.FileName = video.Title + " " + video.Resolution + video.VideoExtension;
            youtubeSaveFileDialog.Filter = "MP4 (*.mp4)|*.mp4|Flash (*.flash)|*.flash|WebM (*.webm)|*.webm";
            youtubeSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            youtubeSaveFileDialog.CheckFileExists = false;
            youtubeSaveFileDialog.AddExtension = true;
            
            //if the result was not cancel button, write the path from the dialog into the path textbox 
            saveDialogResult = youtubeSaveFileDialog.ShowDialog();

            //if the user didn't click cancel button, initialise a new FileStream object
            if (saveDialogResult != DialogResult.Cancel)
            {
                fileStream = new FileStream(Path.GetFullPath(youtubeSaveFileDialog.FileName), FileMode.OpenOrCreate);
            }

            //show the save location on the save location field by getting the path of the file.
            saveLocationTextBox.Text = Path.GetFullPath(youtubeSaveFileDialog.FileName);
        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            // Decipher the video if it has a decrypted signature
            if (video.RequiresDecryption)
                DownloadUrlResolver.DecryptDownloadUrl(video);

            // Initiate a new VideoDownloader object, passing the VideoInfo object and save path
            VideoDownloader videoDownloader = new VideoDownloader(video, saveLocationTextBox.Text);
            
            // Register the ProgressChanged event and print the current progress
            videoDownloader.DownloadProgressChanged += (VideoInfo, args) => downloadProgressBar.Increment((int)args.ProgressPercentage);


            try //try and execute the downloader
            {
            //close the connection with fileStream
            if (fileStream != null)
                fileStream.Close();

            // Execute the video downloader
            videoDownloader.Execute();

            //if it was successful, show a message
            MessageBox.Show("Your video download is completed!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) //if there was a error, show a message to the user
            {
              MessageBox.Show("There was an error while downloading.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exit when exit button is clicked
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //when about menu is clicked, display about form
            aboutForm.ShowDialog();
        }
    }
}
