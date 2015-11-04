namespace WindowsFormsApplication1
{
    partial class Main
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
            this.VolumeBar = new System.Windows.Forms.TrackBar();
            this.TimeBar = new System.Windows.Forms.TrackBar();
            this.PauseButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.MusicTimer = new System.Windows.Forms.Timer(this.components);
            this.MusicListBox = new System.Windows.Forms.ListView();
            this.TrackCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AlbumCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ArtistCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LengthCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Scroll = new System.Windows.Forms.Label();
            this.LabelTime = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SettingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsAddFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsAddFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsNewPlaylist = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsImportPlayList = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderButton = new System.Windows.Forms.Button();
            this.CheckBoxShuffle = new System.Windows.Forms.CheckBox();
            this.CheckBoxAutoPlay = new System.Windows.Forms.CheckBox();
            this.LabelInfoArtist = new System.Windows.Forms.Label();
            this.LabelLyrics = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VolumeBar
            // 
            this.VolumeBar.LargeChange = 0;
            this.VolumeBar.Location = new System.Drawing.Point(441, 81);
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.VolumeBar.Size = new System.Drawing.Size(45, 204);
            this.VolumeBar.TabIndex = 13;
            this.VolumeBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.VolumeBar.Scroll += new System.EventHandler(this.VolumeBar_Scroll);
            this.VolumeBar.ValueChanged += new System.EventHandler(this.VolumeBar_ValueChanged);
            // 
            // TimeBar
            // 
            this.TimeBar.Location = new System.Drawing.Point(124, 35);
            this.TimeBar.Name = "TimeBar";
            this.TimeBar.Size = new System.Drawing.Size(392, 45);
            this.TimeBar.TabIndex = 12;
            this.TimeBar.TickFrequency = 5;
            this.TimeBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TimeBar.Scroll += new System.EventHandler(this.TimeBar_Scroll);
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(68, 30);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(50, 50);
            this.PauseButton.TabIndex = 8;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(12, 30);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(50, 50);
            this.PlayButton.TabIndex = 7;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // MusicTimer
            // 
            this.MusicTimer.Interval = 1000;
            this.MusicTimer.Tick += new System.EventHandler(this.MusicTimer_Tick);
            // 
            // MusicListBox
            // 
            this.MusicListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TrackCol,
            this.NameCol,
            this.AlbumCol,
            this.ArtistCol,
            this.LengthCol});
            this.MusicListBox.Location = new System.Drawing.Point(12, 88);
            this.MusicListBox.MultiSelect = false;
            this.MusicListBox.Name = "MusicListBox";
            this.MusicListBox.Size = new System.Drawing.Size(423, 204);
            this.MusicListBox.TabIndex = 14;
            this.MusicListBox.UseCompatibleStateImageBehavior = false;
            this.MusicListBox.View = System.Windows.Forms.View.Details;
            this.MusicListBox.SelectedIndexChanged += new System.EventHandler(this.MusicListBox_SelectedIndexChanged);
            // 
            // TrackCol
            // 
            this.TrackCol.Text = "Track";
            this.TrackCol.Width = 40;
            // 
            // NameCol
            // 
            this.NameCol.Text = "Name";
            this.NameCol.Width = 120;
            // 
            // AlbumCol
            // 
            this.AlbumCol.Text = "Album";
            this.AlbumCol.Width = 80;
            // 
            // ArtistCol
            // 
            this.ArtistCol.Text = "Artist";
            this.ArtistCol.Width = 100;
            // 
            // LengthCol
            // 
            this.LengthCol.Text = "Length";
            // 
            // Scroll
            // 
            this.Scroll.AutoSize = true;
            this.Scroll.Cursor = System.Windows.Forms.Cursors.Default;
            this.Scroll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Scroll.Location = new System.Drawing.Point(451, 282);
            this.Scroll.Name = "Scroll";
            this.Scroll.Size = new System.Drawing.Size(21, 13);
            this.Scroll.TabIndex = 15;
            this.Scroll.Text = "0%";
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Location = new System.Drawing.Point(135, 67);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(102, 13);
            this.LabelTime.TabIndex = 16;
            this.LabelTime.Text = "00:00:00 / 00:00:00";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(610, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SettingsMenu
            // 
            this.SettingsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsAddFile,
            this.SettingsAddFolder,
            this.SettingsNewPlaylist,
            this.SettingsImportPlayList});
            this.SettingsMenu.Name = "SettingsMenu";
            this.SettingsMenu.Size = new System.Drawing.Size(61, 20);
            this.SettingsMenu.Text = "Settings";
            // 
            // SettingsAddFile
            // 
            this.SettingsAddFile.Name = "SettingsAddFile";
            this.SettingsAddFile.Size = new System.Drawing.Size(150, 22);
            this.SettingsAddFile.Text = "Add File";
            this.SettingsAddFile.Click += new System.EventHandler(this.SettingsAddFile_Click);
            // 
            // SettingsAddFolder
            // 
            this.SettingsAddFolder.Name = "SettingsAddFolder";
            this.SettingsAddFolder.Size = new System.Drawing.Size(150, 22);
            this.SettingsAddFolder.Text = "Add Folder";
            // 
            // SettingsNewPlaylist
            // 
            this.SettingsNewPlaylist.Name = "SettingsNewPlaylist";
            this.SettingsNewPlaylist.Size = new System.Drawing.Size(150, 22);
            this.SettingsNewPlaylist.Text = "New Playlist";
            // 
            // SettingsImportPlayList
            // 
            this.SettingsImportPlayList.Name = "SettingsImportPlayList";
            this.SettingsImportPlayList.Size = new System.Drawing.Size(150, 22);
            this.SettingsImportPlayList.Text = "Import Playlist";
            // 
            // FolderButton
            // 
            this.FolderButton.Location = new System.Drawing.Point(523, 269);
            this.FolderButton.Name = "FolderButton";
            this.FolderButton.Size = new System.Drawing.Size(75, 23);
            this.FolderButton.TabIndex = 11;
            this.FolderButton.Text = "Folder";
            this.FolderButton.UseVisualStyleBackColor = true;
            // 
            // CheckBoxShuffle
            // 
            this.CheckBoxShuffle.AutoSize = true;
            this.CheckBoxShuffle.Location = new System.Drawing.Point(539, 30);
            this.CheckBoxShuffle.Name = "CheckBoxShuffle";
            this.CheckBoxShuffle.Size = new System.Drawing.Size(59, 17);
            this.CheckBoxShuffle.TabIndex = 18;
            this.CheckBoxShuffle.Text = "Shuffle";
            this.CheckBoxShuffle.UseVisualStyleBackColor = true;
            this.CheckBoxShuffle.Click += new System.EventHandler(this.CheckBoxShuffle_Click);
            // 
            // CheckBoxAutoPlay
            // 
            this.CheckBoxAutoPlay.AutoSize = true;
            this.CheckBoxAutoPlay.Checked = true;
            this.CheckBoxAutoPlay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxAutoPlay.Location = new System.Drawing.Point(539, 53);
            this.CheckBoxAutoPlay.Name = "CheckBoxAutoPlay";
            this.CheckBoxAutoPlay.Size = new System.Drawing.Size(70, 17);
            this.CheckBoxAutoPlay.TabIndex = 19;
            this.CheckBoxAutoPlay.Text = "Auto play";
            this.CheckBoxAutoPlay.UseVisualStyleBackColor = true;
            this.CheckBoxAutoPlay.Click += new System.EventHandler(this.CheckBoxAutoPlay_Click);
            // 
            // LabelInfoArtist
            // 
            this.LabelInfoArtist.AutoSize = true;
            this.LabelInfoArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInfoArtist.Location = new System.Drawing.Point(274, 24);
            this.LabelInfoArtist.Name = "LabelInfoArtist";
            this.LabelInfoArtist.Size = new System.Drawing.Size(0, 12);
            this.LabelInfoArtist.TabIndex = 20;
            this.LabelInfoArtist.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelLyrics
            // 
            this.LabelLyrics.AutoSize = true;
            this.LabelLyrics.Location = new System.Drawing.Point(492, 88);
            this.LabelLyrics.Name = "LabelLyrics";
            this.LabelLyrics.Size = new System.Drawing.Size(0, 13);
            this.LabelLyrics.TabIndex = 21;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 304);
            this.Controls.Add(this.LabelLyrics);
            this.Controls.Add(this.LabelInfoArtist);
            this.Controls.Add(this.CheckBoxAutoPlay);
            this.Controls.Add(this.CheckBoxShuffle);
            this.Controls.Add(this.LabelTime);
            this.Controls.Add(this.Scroll);
            this.Controls.Add(this.MusicListBox);
            this.Controls.Add(this.VolumeBar);
            this.Controls.Add(this.TimeBar);
            this.Controls.Add(this.FolderButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar VolumeBar;
        private System.Windows.Forms.TrackBar TimeBar;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Timer MusicTimer;
        private System.Windows.Forms.ListView MusicListBox;
        private System.Windows.Forms.ColumnHeader TrackCol;
        private System.Windows.Forms.ColumnHeader NameCol;
        private System.Windows.Forms.ColumnHeader AlbumCol;
        private System.Windows.Forms.ColumnHeader ArtistCol;
        private System.Windows.Forms.ColumnHeader LengthCol;
        private System.Windows.Forms.Label Scroll;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenu;
        private System.Windows.Forms.ToolStripMenuItem SettingsAddFile;
        private System.Windows.Forms.ToolStripMenuItem SettingsAddFolder;
        private System.Windows.Forms.ToolStripMenuItem SettingsNewPlaylist;
        private System.Windows.Forms.ToolStripMenuItem SettingsImportPlayList;
        private System.Windows.Forms.Button FolderButton;
        private System.Windows.Forms.CheckBox CheckBoxShuffle;
        private System.Windows.Forms.CheckBox CheckBoxAutoPlay;
        private System.Windows.Forms.Label LabelInfoArtist;
        private System.Windows.Forms.Label LabelLyrics;

    }
}

