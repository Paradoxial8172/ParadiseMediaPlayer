using NAudio.Wave;
using TagLib;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using MediaPlayer.Properties;
using System.Resources;
using System.Timers;

namespace MediaPlayer
{
    public partial class App : Form
    {
        private System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
        // Use this list to store file paths to play.
        private List<string> filePaths = new List<string> { };
        private bool autoPlay = false;
        private bool isMuted = false;
        private bool isPaused = false;
        private WaveOutEvent waveOut;
        private AudioFileReader audioFile;
        private float volume = 0.5f;
        private System.Timers.Timer progressTimer;
        private Dictionary<string, string> fileMetaData;
        private int songIndex = 0;
        public App()
        {
            InitializeComponent();

            durationProgressBar.Minimum = 0;
            durationProgressBar.Step = 1;

            TrackProgress();

        }

        private void TrackProgress()
        {
            progressTimer = new System.Timers.Timer(500); // Update every 500ms
            progressTimer.Elapsed += UpdateProgressBar;
            progressTimer.Start();
        }

        private void UpdateProgressBar(object sender, ElapsedEventArgs e)
        {
            if (waveOut != null && waveOut.PlaybackState == PlaybackState.Playing)
            {
                Invoke(new Action(() =>
                {
                    durationProgressBar.Value = (int)audioFile.CurrentTime.TotalMilliseconds;
                }));
            }
        }

        private Dictionary<string, string> ParseFileData(string filePath)
        {
            // Parse file meta data.
            var tfile = TagLib.File.Create(filePath);
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("name", tfile.Tag.Title ?? Path.GetFileName(filePath));
            data.Add("artist", tfile.Tag.FirstPerformer ?? "N/A");
            data.Add("album", tfile.Tag.Album ?? "N/A");
            data.Add("year", Convert.ToString(tfile.Tag.Year) ?? "N/A");

            return data;
        }

        private void SetFileData()
        {
            // Update data labels.
            songNameLabel.Text = "Song: " + fileMetaData["name"];
            artistLabel.Text = "Artist(s): " + fileMetaData["artist"];
            albumLabel.Text = "Album: " + fileMetaData["album"];
            yearLabel.Text = "Year: " + fileMetaData["year"];
            durationLabel.Text = "Duration: " + null;
            locationLabel.Text = "Location: " + filePaths[playlistBox.SelectedIndex];
            fileLabel.Text = "File: " + Path.GetFileName(filePaths[playlistBox.SelectedIndex]);

            var tfile = TagLib.File.Create(filePaths[playlistBox.SelectedIndex]);

            if (tfile.Tag.Pictures.Length > 0)
            {
                // Extract the album cover.
                var bin = (byte[])(tfile.Tag.Pictures[0].Data.Data);

                using (var ms = new MemoryStream(bin))
                {
                    Image img = Image.FromStream(ms);
                    Bitmap resizedImage = new Bitmap(256, 256);
                    using (Graphics g = Graphics.FromImage(resizedImage))
                    {
                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        g.DrawImage(img, 0, 0, 256, 256);
                    }
                    // Post album cover image.
                    albumCover.Image = resizedImage;
                }
            }
            else
            {
                // If no album cover, use placeholder.
                albumCover.Image = (Image)resources.GetObject("albumCover.Image");
            }
        }

        private void OpenNewFile(object? sender, EventArgs? e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                // Open file explorer, pull selected file.
                fileDialog.Title = "Open Audio File(s)";
                fileDialog.InitialDirectory = "C://";
                fileDialog.Filter = "Audio Files (*.mp3;*.wav;*.ogg)|*.mp3;*.wav;*.ogg|All Files (*.*)|*.*";

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {

                    // Add selected file to file paths list.
                    string filePath = fileDialog.FileName;

                    if (filePaths.Contains(filePath))
                    {
                        // Confirm duplicate file.
                        var result = MessageBox.Show("This song is already in your playlist. Do you want to add it again?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result != DialogResult.Yes)
                        {
                            return;
                        }
                    }

                    filePaths.Add(filePath);
                    // Add name of file to playlist box for selection.
                    string fileName = Path.GetFileName(filePath);
                    playlistBox.Items.Add(fileName);
                }
            }
        }

        private void OpenFolder(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = folderBrowserDialog.SelectedPath;
                    List<string> retrievedFiles = Directory.GetFiles(folderPath).ToList();
                    List<string> allowedFileFormats = new List<string> { "mp3", "mp2", "wav", "ogg", "aiff", "flac", "aac" };
                    foreach (string file in retrievedFiles)
                    {
                        foreach (string format in allowedFileFormats)
                        {
                            // Check if file format is allowed. If so, add it.
                            if (file.EndsWith("." + format) && !filePaths.Contains(file))
                            {
                                filePaths.Add(file);
                                playlistBox.Items.Add(Path.GetFileName(file));
                            }
                        }
                    }
                    if (filePaths.Count != retrievedFiles.Count)
                    {
                        MessageBox.Show("Looks like some of your files were not supported. Here is a list of supported file types: \n '\"mp3\", \"mp2\", \"wav\", \"ogg\", \"aiff\", \"flac\", \"aac\"'", "Uh oh...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        private void PlayFile()
        {
            // Check if song is already playing. If so, stop the song.
            if (waveOut != null) { waveOut.Dispose(); audioFile.Dispose(); }

            // Play the song, update the song's file data on right hand side.
            waveOut = new WaveOutEvent();
            audioFile = new AudioFileReader(filePaths[playlistBox.SelectedIndex]);
            songIndex = playlistBox.SelectedIndex;
            waveOut.Init(audioFile);
            waveOut.Play();
            waveOut.Volume = volume;
            fileMetaData = ParseFileData(filePaths[playlistBox.SelectedIndex]);
            SetFileData();

            durationProgressBar.Maximum = (int)audioFile.TotalTime.TotalMilliseconds;
        }

        private void StopFile(object sender, EventArgs e)
        {
            // Stop song.
            waveOut.Stop();
        }

        private void OnFileStopped(object sender, StoppedEventArgs e)
        {
            if (playlistBox.SelectedIndex != playlistBox.Items.Count - 1)
            {
                if (playlistBox.SelectedIndex == -1) 
                {
                    playlistBox.SelectedIndex = songIndex;
                }
                playlistBox.SelectedIndex += 1;
                PlayFile();
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (filePaths.Count == 0) { OpenNewFile(null, null); }
            else
            {
                // Check if a song/file is selected.
                if (playlistBox.SelectedIndex != -1)
                {
                    PlayFile();
                }
                else
                {
                    MessageBox.Show("Select or open a new file to play.", "Playback Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void RemoveFromPlaylist(object sender, EventArgs e)
        {
            // Check if a song/file is selected.
            if (playlistBox.SelectedIndex != -1)
            {
                filePaths.RemoveAt(playlistBox.SelectedIndex);
                playlistBox.Items.RemoveAt(playlistBox.SelectedIndex);
            }
        }

        private void DeselectFile(object sender, EventArgs e)
        {
            // Deselect selected song/file.
            playlistBox.SelectedIndex = -1;
        }

        private void ClearPlaylist(object sender, EventArgs e)
        {
            // Have user confirm if they want to clear the entire playlist.
            var result = MessageBox.Show("Are you sure you want to clear the entire playlist?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                playlistBox.Items.Clear();
                filePaths.Clear();
            }
        }

        private void PauseResume(object sender, EventArgs e)
        {
            switch (isPaused)
            {
                case true:
                    // If it is paused.
                    waveOut.Play();
                    isPaused = false;
                    pauseBtn.Text = "Pause";
                    break;
                case false:
                    // If it is currently playing.
                    waveOut.Pause();
                    isPaused = true;
                    pauseBtn.Text = "Resume";
                    break;
            }
        }

        private void MuteUnmute(object sender, EventArgs e)
        {
            switch (isMuted)
            {
                case true:
                    // If it is muted.
                    waveOut.Volume = volume;
                    isMuted = false;
                    muteBtn.Text = "Mute";
                    break;
                case false:
                    // If it is not muted.
                    waveOut.Volume = 0.0f;
                    isMuted = true;
                    muteBtn.Text = "Unmute";
                    break;
            }
        }

        private void ToggleAutoPlay(object sender, EventArgs e)
        {
            switch (autoPlay)
            {
                case true:
                    this.Text = "Paradise Media Player";
                    waveOut.PlaybackStopped += null;
                    autoPlay = false;
                    break;
                case false:
                    if (waveOut is null) { return; }
                    this.Text = "Paradise Media Player - Auto Play ON";
                    waveOut.PlaybackStopped += OnFileStopped;
                    autoPlay = true;
                    break;
            }
        }

        private void SetVolume(object sender, EventArgs e)
        {
            volume = (float)(volumeSlider.Value) / 100;
            waveOut.Volume = volume;
            volumeLabel.Text = $"Volume: {(int)(volume * 100)}";
        }

        private void GoBack(object sender, EventArgs e)
        {
            if (playlistBox.SelectedIndex == 0) { return; }
            if (waveOut is null) { return; }
            playlistBox.SelectedIndex--;
            PlayFile();
        }

        private void GoForward(object sender, EventArgs e)
        {
            if (playlistBox.SelectedIndex == playlistBox.Items.Count - 1) { return; }
            if (waveOut is null) { return; }
            playlistBox.SelectedIndex++;
            PlayFile();
        }

        private void RevealExplorer(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", Path.GetDirectoryName(filePaths[playlistBox.SelectedIndex]));
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return;
            }

        }

        private void ReportBugs(object sender, EventArgs e)
        {
            MessageBox.Show("To report a bug, tweet it out to https://x.com/Paradoxial_YT. Thank you for your help on making Paradise Media Player even better!", "Report a Bug", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExitApplication(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}