namespace MediaPlayer
{
    partial class App
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            playlistBox = new ListBox();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            openFolderToolStripMenuItem = new ToolStripMenuItem();
            clearQueueToolStripMenuItem = new ToolStripMenuItem();
            deselectFileToolStripMenuItem = new ToolStripMenuItem();
            revealExplorerToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            toggleAutoplayToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            version010ToolStripMenuItem = new ToolStripMenuItem();
            reportBugsToolStripMenuItem = new ToolStripMenuItem();
            playBtn = new Button();
            pauseBtn = new Button();
            stopBtn = new Button();
            addBtn = new Button();
            removeBtn = new Button();
            durationProgressBar = new ProgressBar();
            locationLabel = new Label();
            durationLabel = new Label();
            deselectBtn = new Button();
            clearPlaylistBtn = new Button();
            muteBtn = new Button();
            rewindBtn = new Button();
            forwardBtn = new Button();
            albumCover = new PictureBox();
            volumeSlider = new TrackBar();
            volumeLabel = new Label();
            songNameLabel = new Label();
            artistLabel = new Label();
            albumLabel = new Label();
            yearLabel = new Label();
            fileLabel = new Label();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)albumCover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)volumeSlider).BeginInit();
            SuspendLayout();
            // 
            // playlistBox
            // 
            playlistBox.FormattingEnabled = true;
            playlistBox.Location = new Point(12, 27);
            playlistBox.Name = "playlistBox";
            playlistBox.Size = new Size(275, 394);
            playlistBox.TabIndex = 0;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, settingsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(900, 24);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, openFolderToolStripMenuItem, clearQueueToolStripMenuItem, deselectFileToolStripMenuItem, revealExplorerToolStripMenuItem, quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += OpenNewFile;
            // 
            // openFolderToolStripMenuItem
            // 
            openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            openFolderToolStripMenuItem.Size = new Size(180, 22);
            openFolderToolStripMenuItem.Text = "Open Folder";
            openFolderToolStripMenuItem.Click += OpenFolder;
            // 
            // clearQueueToolStripMenuItem
            // 
            clearQueueToolStripMenuItem.Name = "clearQueueToolStripMenuItem";
            clearQueueToolStripMenuItem.Size = new Size(180, 22);
            clearQueueToolStripMenuItem.Text = "Clear Queue";
            clearQueueToolStripMenuItem.Click += ClearPlaylist;
            // 
            // deselectFileToolStripMenuItem
            // 
            deselectFileToolStripMenuItem.Name = "deselectFileToolStripMenuItem";
            deselectFileToolStripMenuItem.Size = new Size(180, 22);
            deselectFileToolStripMenuItem.Text = "Deselect File";
            // 
            // revealExplorerToolStripMenuItem
            // 
            revealExplorerToolStripMenuItem.Name = "revealExplorerToolStripMenuItem";
            revealExplorerToolStripMenuItem.Size = new Size(180, 22);
            revealExplorerToolStripMenuItem.Text = "Reveal Explorer";
            revealExplorerToolStripMenuItem.Click += RevealExplorer;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(180, 22);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += ExitApplication;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toggleAutoplayToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // toggleAutoplayToolStripMenuItem
            // 
            toggleAutoplayToolStripMenuItem.Name = "toggleAutoplayToolStripMenuItem";
            toggleAutoplayToolStripMenuItem.Size = new Size(161, 22);
            toggleAutoplayToolStripMenuItem.Text = "Toggle Autoplay";
            toggleAutoplayToolStripMenuItem.Click += ToggleAutoPlay;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { version010ToolStripMenuItem, reportBugsToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // version010ToolStripMenuItem
            // 
            version010ToolStripMenuItem.Name = "version010ToolStripMenuItem";
            version010ToolStripMenuItem.Size = new Size(142, 22);
            version010ToolStripMenuItem.Text = "Version: 0.1.0";
            // 
            // reportBugsToolStripMenuItem
            // 
            reportBugsToolStripMenuItem.Name = "reportBugsToolStripMenuItem";
            reportBugsToolStripMenuItem.Size = new Size(142, 22);
            reportBugsToolStripMenuItem.Text = "Report Bugs";
            reportBugsToolStripMenuItem.Click += ReportBugs;
            // 
            // playBtn
            // 
            playBtn.Cursor = Cursors.Hand;
            playBtn.Location = new Point(312, 289);
            playBtn.Name = "playBtn";
            playBtn.Size = new Size(75, 75);
            playBtn.TabIndex = 2;
            playBtn.Text = "Play";
            playBtn.UseVisualStyleBackColor = true;
            playBtn.Click += PlayButton_Click;
            // 
            // pauseBtn
            // 
            pauseBtn.Cursor = Cursors.Hand;
            pauseBtn.Location = new Point(402, 289);
            pauseBtn.Name = "pauseBtn";
            pauseBtn.Size = new Size(75, 75);
            pauseBtn.TabIndex = 3;
            pauseBtn.Text = "Pause";
            pauseBtn.UseVisualStyleBackColor = true;
            pauseBtn.Click += PauseResume;
            // 
            // stopBtn
            // 
            stopBtn.Cursor = Cursors.Hand;
            stopBtn.Location = new Point(492, 289);
            stopBtn.Name = "stopBtn";
            stopBtn.Size = new Size(75, 75);
            stopBtn.TabIndex = 4;
            stopBtn.Text = "Stop";
            stopBtn.UseVisualStyleBackColor = true;
            stopBtn.Click += StopFile;
            // 
            // addBtn
            // 
            addBtn.Cursor = Cursors.Hand;
            addBtn.Location = new Point(12, 427);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(121, 35);
            addBtn.TabIndex = 5;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += OpenNewFile;
            // 
            // removeBtn
            // 
            removeBtn.Cursor = Cursors.Hand;
            removeBtn.Location = new Point(166, 427);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(121, 35);
            removeBtn.TabIndex = 6;
            removeBtn.Text = "Remove";
            removeBtn.UseVisualStyleBackColor = true;
            removeBtn.Click += RemoveFromPlaylist;
            // 
            // durationProgressBar
            // 
            durationProgressBar.Location = new Point(12, 542);
            durationProgressBar.Name = "durationProgressBar";
            durationProgressBar.Size = new Size(876, 23);
            durationProgressBar.TabIndex = 7;
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new Point(12, 579);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(59, 15);
            locationLabel.TabIndex = 8;
            locationLabel.Text = "Location: ";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new Point(12, 513);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(59, 15);
            durationLabel.TabIndex = 9;
            durationLabel.Text = "Duration: ";
            // 
            // deselectBtn
            // 
            deselectBtn.Cursor = Cursors.Hand;
            deselectBtn.Location = new Point(12, 468);
            deselectBtn.Name = "deselectBtn";
            deselectBtn.Size = new Size(121, 23);
            deselectBtn.TabIndex = 10;
            deselectBtn.Text = "Deselect File";
            deselectBtn.UseVisualStyleBackColor = true;
            deselectBtn.Click += DeselectFile;
            // 
            // clearPlaylistBtn
            // 
            clearPlaylistBtn.Cursor = Cursors.Hand;
            clearPlaylistBtn.Location = new Point(166, 468);
            clearPlaylistBtn.Name = "clearPlaylistBtn";
            clearPlaylistBtn.Size = new Size(121, 23);
            clearPlaylistBtn.TabIndex = 11;
            clearPlaylistBtn.Text = "Clear Queue";
            clearPlaylistBtn.UseVisualStyleBackColor = true;
            clearPlaylistBtn.Click += ClearPlaylist;
            // 
            // muteBtn
            // 
            muteBtn.Cursor = Cursors.Hand;
            muteBtn.Location = new Point(312, 370);
            muteBtn.Name = "muteBtn";
            muteBtn.Size = new Size(75, 50);
            muteBtn.TabIndex = 13;
            muteBtn.Text = "Mute";
            muteBtn.UseVisualStyleBackColor = true;
            muteBtn.Click += MuteUnmute;
            // 
            // rewindBtn
            // 
            rewindBtn.Cursor = Cursors.Hand;
            rewindBtn.Location = new Point(402, 370);
            rewindBtn.Name = "rewindBtn";
            rewindBtn.Size = new Size(75, 50);
            rewindBtn.TabIndex = 14;
            rewindBtn.Text = "Back";
            rewindBtn.UseVisualStyleBackColor = true;
            rewindBtn.Click += GoBack;
            // 
            // forwardBtn
            // 
            forwardBtn.Cursor = Cursors.Hand;
            forwardBtn.Location = new Point(492, 370);
            forwardBtn.Name = "forwardBtn";
            forwardBtn.Size = new Size(75, 50);
            forwardBtn.TabIndex = 15;
            forwardBtn.Text = "Forward";
            forwardBtn.UseVisualStyleBackColor = true;
            forwardBtn.Click += GoForward;
            // 
            // albumCover
            // 
            albumCover.Image = (Image)resources.GetObject("albumCover.Image");
            albumCover.Location = new Point(312, 27);
            albumCover.Name = "albumCover";
            albumCover.Size = new Size(256, 256);
            albumCover.TabIndex = 16;
            albumCover.TabStop = false;
            // 
            // volumeSlider
            // 
            volumeSlider.Cursor = Cursors.Hand;
            volumeSlider.Location = new Point(312, 468);
            volumeSlider.Maximum = 100;
            volumeSlider.Name = "volumeSlider";
            volumeSlider.Size = new Size(256, 45);
            volumeSlider.TabIndex = 17;
            volumeSlider.Value = 50;
            volumeSlider.ValueChanged += SetVolume;
            // 
            // volumeLabel
            // 
            volumeLabel.AutoSize = true;
            volumeLabel.Location = new Point(402, 437);
            volumeLabel.Name = "volumeLabel";
            volumeLabel.Size = new Size(65, 15);
            volumeLabel.TabIndex = 18;
            volumeLabel.Text = "Volume: 50";
            // 
            // songNameLabel
            // 
            songNameLabel.AutoSize = true;
            songNameLabel.Location = new Point(611, 27);
            songNameLabel.Name = "songNameLabel";
            songNameLabel.Size = new Size(37, 15);
            songNameLabel.TabIndex = 19;
            songNameLabel.Text = "Song:";
            // 
            // artistLabel
            // 
            artistLabel.AutoSize = true;
            artistLabel.Location = new Point(611, 70);
            artistLabel.Name = "artistLabel";
            artistLabel.Size = new Size(51, 15);
            artistLabel.TabIndex = 20;
            artistLabel.Text = "Artist(s):";
            // 
            // albumLabel
            // 
            albumLabel.AutoSize = true;
            albumLabel.Location = new Point(611, 113);
            albumLabel.Name = "albumLabel";
            albumLabel.Size = new Size(46, 15);
            albumLabel.TabIndex = 21;
            albumLabel.Text = "Album:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(611, 156);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(32, 15);
            yearLabel.TabIndex = 22;
            yearLabel.Text = "Year:";
            // 
            // fileLabel
            // 
            fileLabel.AutoSize = true;
            fileLabel.Location = new Point(611, 199);
            fileLabel.Name = "fileLabel";
            fileLabel.Size = new Size(28, 15);
            fileLabel.TabIndex = 23;
            fileLabel.Text = "File:";
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 605);
            Controls.Add(fileLabel);
            Controls.Add(yearLabel);
            Controls.Add(albumLabel);
            Controls.Add(artistLabel);
            Controls.Add(songNameLabel);
            Controls.Add(volumeLabel);
            Controls.Add(volumeSlider);
            Controls.Add(albumCover);
            Controls.Add(forwardBtn);
            Controls.Add(rewindBtn);
            Controls.Add(muteBtn);
            Controls.Add(clearPlaylistBtn);
            Controls.Add(deselectBtn);
            Controls.Add(durationLabel);
            Controls.Add(locationLabel);
            Controls.Add(durationProgressBar);
            Controls.Add(removeBtn);
            Controls.Add(addBtn);
            Controls.Add(stopBtn);
            Controls.Add(pauseBtn);
            Controls.Add(playBtn);
            Controls.Add(playlistBox);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "App";
            Text = "Paradise Media Player";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)albumCover).EndInit();
            ((System.ComponentModel.ISupportInitialize)volumeSlider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox playlistBox;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem openFolderToolStripMenuItem;
        private ToolStripMenuItem clearQueueToolStripMenuItem;
        private ToolStripMenuItem revealExplorerToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private Button playBtn;
        private Button pauseBtn;
        private Button stopBtn;
        private Button addBtn;
        private Button removeBtn;
        private ToolStripMenuItem toggleAutoplayToolStripMenuItem;
        private ProgressBar durationProgressBar;
        private Label locationLabel;
        private Label durationLabel;
        private Button deselectBtn;
        private ToolStripMenuItem deselectFileToolStripMenuItem;
        private Button clearPlaylistBtn;
        private Button muteBtn;
        private Button rewindBtn;
        private Button forwardBtn;
        private PictureBox albumCover;
        private TrackBar volumeSlider;
        private Label volumeLabel;
        private Label songNameLabel;
        private Label artistLabel;
        private Label albumLabel;
        private Label yearLabel;
        private Label fileLabel;
        private ToolStripMenuItem version010ToolStripMenuItem;
        private ToolStripMenuItem reportBugsToolStripMenuItem;
    }
}
