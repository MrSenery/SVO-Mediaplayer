namespace SandersMediaplayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
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
            this.LabelTime = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SettingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsAddFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsAddFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewPlayListMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditPlaylistMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckBoxShuffle = new System.Windows.Forms.CheckBox();
            this.CheckBoxAutoPlay = new System.Windows.Forms.CheckBox();
            this.CoverBox = new System.Windows.Forms.PictureBox();
            this.InfoArtist = new System.Windows.Forms.TextBox();
            this.DeleteButt = new System.Windows.Forms.Button();
            this.ClearListButt = new System.Windows.Forms.Button();
            this.NamePlaylist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Playlists = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.TimeBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoverBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeBar
            // 
            this.TimeBar.Enabled = false;
            this.TimeBar.Location = new System.Drawing.Point(0, 142);
            this.TimeBar.Name = "TimeBar";
            this.TimeBar.Size = new System.Drawing.Size(307, 45);
            this.TimeBar.TabIndex = 12;
            this.TimeBar.TickFrequency = 5;
            this.TimeBar.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(12, 30);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(50, 50);
            this.PauseButton.TabIndex = 8;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Visible = false;
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
            this.MusicListBox.FullRowSelect = true;
            this.MusicListBox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.MusicListBox.Location = new System.Drawing.Point(312, 30);
            this.MusicListBox.MultiSelect = false;
            this.MusicListBox.Name = "MusicListBox";
            this.MusicListBox.Size = new System.Drawing.Size(434, 286);
            this.MusicListBox.TabIndex = 14;
            this.MusicListBox.UseCompatibleStateImageBehavior = false;
            this.MusicListBox.View = System.Windows.Forms.View.Details;
            this.MusicListBox.SelectedIndexChanged += new System.EventHandler(this.MusicListBox_SelectedIndexChanged);
            this.MusicListBox.DoubleClick += new System.EventHandler(this.MusicListBox_DoubleClick);
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
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Location = new System.Drawing.Point(9, 116);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(102, 13);
            this.LabelTime.TabIndex = 16;
            this.LabelTime.Text = "00:00:00 / 00:00:00";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsMenu,
            this.playlistToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SettingsMenu
            // 
            this.SettingsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsAddFile,
            this.SettingsAddFolder});
            this.SettingsMenu.Name = "SettingsMenu";
            this.SettingsMenu.Size = new System.Drawing.Size(50, 20);
            this.SettingsMenu.Text = "Menu";
            // 
            // SettingsAddFile
            // 
            this.SettingsAddFile.Name = "SettingsAddFile";
            this.SettingsAddFile.Size = new System.Drawing.Size(132, 22);
            this.SettingsAddFile.Text = "Add File";
            this.SettingsAddFile.Click += new System.EventHandler(this.SettingsAddFile_Click);
            // 
            // SettingsAddFolder
            // 
            this.SettingsAddFolder.Name = "SettingsAddFolder";
            this.SettingsAddFolder.Size = new System.Drawing.Size(132, 22);
            this.SettingsAddFolder.Text = "Add Folder";
            // 
            // playlistToolStripMenuItem
            // 
            this.playlistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewPlayListMenu,
            this.EditPlaylistMenu,
            this.deletePlaylistToolStripMenuItem});
            this.playlistToolStripMenuItem.Name = "playlistToolStripMenuItem";
            this.playlistToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.playlistToolStripMenuItem.Text = "Playlist";
            // 
            // NewPlayListMenu
            // 
            this.NewPlayListMenu.Name = "NewPlayListMenu";
            this.NewPlayListMenu.Size = new System.Drawing.Size(147, 22);
            this.NewPlayListMenu.Text = "New Playlist";
            this.NewPlayListMenu.Click += new System.EventHandler(this.newPlaylistToolStripMenuItem_Click);
            // 
            // EditPlaylistMenu
            // 
            this.EditPlaylistMenu.Name = "EditPlaylistMenu";
            this.EditPlaylistMenu.Size = new System.Drawing.Size(147, 22);
            this.EditPlaylistMenu.Text = "Edit Playlist";
            // 
            // deletePlaylistToolStripMenuItem
            // 
            this.deletePlaylistToolStripMenuItem.Name = "deletePlaylistToolStripMenuItem";
            this.deletePlaylistToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.deletePlaylistToolStripMenuItem.Text = "Delete Playlist";
            this.deletePlaylistToolStripMenuItem.Click += new System.EventHandler(this.deletePlaylistToolStripMenuItem_Click);
            // 
            // CheckBoxShuffle
            // 
            this.CheckBoxShuffle.AutoSize = true;
            this.CheckBoxShuffle.Location = new System.Drawing.Point(68, 40);
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
            this.CheckBoxAutoPlay.Location = new System.Drawing.Point(68, 63);
            this.CheckBoxAutoPlay.Name = "CheckBoxAutoPlay";
            this.CheckBoxAutoPlay.Size = new System.Drawing.Size(70, 17);
            this.CheckBoxAutoPlay.TabIndex = 19;
            this.CheckBoxAutoPlay.Text = "Auto play";
            this.CheckBoxAutoPlay.UseVisualStyleBackColor = true;
            this.CheckBoxAutoPlay.Click += new System.EventHandler(this.CheckBoxAutoPlay_Click);
            // 
            // CoverBox
            // 
            this.CoverBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CoverBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CoverBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("CoverBox.ErrorImage")));
            this.CoverBox.Location = new System.Drawing.Point(203, 26);
            this.CoverBox.Name = "CoverBox";
            this.CoverBox.Size = new System.Drawing.Size(104, 105);
            this.CoverBox.TabIndex = 21;
            this.CoverBox.TabStop = false;
            // 
            // InfoArtist
            // 
            this.InfoArtist.BackColor = System.Drawing.SystemColors.Control;
            this.InfoArtist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InfoArtist.Location = new System.Drawing.Point(13, 131);
            this.InfoArtist.Name = "InfoArtist";
            this.InfoArtist.Size = new System.Drawing.Size(294, 13);
            this.InfoArtist.TabIndex = 22;
            this.InfoArtist.Text = "Text";
            this.InfoArtist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeleteButt
            // 
            this.DeleteButt.Location = new System.Drawing.Point(12, 86);
            this.DeleteButt.Name = "DeleteButt";
            this.DeleteButt.Size = new System.Drawing.Size(64, 23);
            this.DeleteButt.TabIndex = 23;
            this.DeleteButt.Text = "Delete";
            this.DeleteButt.UseVisualStyleBackColor = true;
            this.DeleteButt.Click += new System.EventHandler(this.DeleteButt_Click);
            // 
            // ClearListButt
            // 
            this.ClearListButt.Location = new System.Drawing.Point(82, 86);
            this.ClearListButt.Name = "ClearListButt";
            this.ClearListButt.Size = new System.Drawing.Size(64, 23);
            this.ClearListButt.TabIndex = 24;
            this.ClearListButt.Text = "Clear List";
            this.ClearListButt.UseVisualStyleBackColor = true;
            this.ClearListButt.Click += new System.EventHandler(this.ClearListButt_Click);
            // 
            // NamePlaylist
            // 
            this.NamePlaylist.Text = "Playlists";
            this.NamePlaylist.Width = 271;
            // 
            // Playlists
            // 
            this.Playlists.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NamePlaylist});
            this.Playlists.FullRowSelect = true;
            this.Playlists.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Playlists.Location = new System.Drawing.Point(12, 166);
            this.Playlists.Name = "Playlists";
            this.Playlists.Size = new System.Drawing.Size(294, 150);
            this.Playlists.TabIndex = 25;
            this.Playlists.UseCompatibleStateImageBehavior = false;
            this.Playlists.View = System.Windows.Forms.View.Details;
            this.Playlists.SelectedIndexChanged += new System.EventHandler(this.Playlists_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 328);
            this.Controls.Add(this.Playlists);
            this.Controls.Add(this.ClearListButt);
            this.Controls.Add(this.DeleteButt);
            this.Controls.Add(this.InfoArtist);
            this.Controls.Add(this.CoverBox);
            this.Controls.Add(this.CheckBoxAutoPlay);
            this.Controls.Add(this.CheckBoxShuffle);
            this.Controls.Add(this.LabelTime);
            this.Controls.Add(this.MusicListBox);
            this.Controls.Add(this.TimeBar);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TimeBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoverBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar TimeBar;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Timer MusicTimer;
        private System.Windows.Forms.ColumnHeader TrackCol;
        private System.Windows.Forms.ColumnHeader NameCol;
        private System.Windows.Forms.ColumnHeader AlbumCol;
        private System.Windows.Forms.ColumnHeader ArtistCol;
        private System.Windows.Forms.ColumnHeader LengthCol;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenu;
        private System.Windows.Forms.ToolStripMenuItem SettingsAddFile;
        private System.Windows.Forms.ToolStripMenuItem SettingsAddFolder;
        private System.Windows.Forms.CheckBox CheckBoxShuffle;
        private System.Windows.Forms.CheckBox CheckBoxAutoPlay;
        private System.Windows.Forms.PictureBox CoverBox;
        private System.Windows.Forms.TextBox InfoArtist;
        private System.Windows.Forms.Button DeleteButt;
        private System.Windows.Forms.Button ClearListButt;
        private System.Windows.Forms.ToolStripMenuItem playlistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewPlayListMenu;
        private System.Windows.Forms.ToolStripMenuItem EditPlaylistMenu;
        public System.Windows.Forms.ListView MusicListBox;
        private System.Windows.Forms.ColumnHeader NamePlaylist;
        public System.Windows.Forms.ListView Playlists;
        private System.Windows.Forms.ToolStripMenuItem deletePlaylistToolStripMenuItem;
    }
}

