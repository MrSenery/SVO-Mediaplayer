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
            this.FolderButton = new System.Windows.Forms.Button();
            this.FileButton = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // VolumeBar
            // 
            this.VolumeBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VolumeBar.LargeChange = 0;
            this.VolumeBar.Location = new System.Drawing.Point(424, 63);
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.VolumeBar.Size = new System.Drawing.Size(45, 128);
            this.VolumeBar.TabIndex = 13;
            this.VolumeBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.VolumeBar.Scroll += new System.EventHandler(this.VolumeBar_Scroll);
            this.VolumeBar.ValueChanged += new System.EventHandler(this.VolumeBar_ValueChanged);
            // 
            // TimeBar
            // 
            this.TimeBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeBar.Location = new System.Drawing.Point(124, 12);
            this.TimeBar.Name = "TimeBar";
            this.TimeBar.Size = new System.Drawing.Size(375, 45);
            this.TimeBar.TabIndex = 12;
            this.TimeBar.TickFrequency = 5;
            this.TimeBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TimeBar.Scroll += new System.EventHandler(this.TimeBar_Scroll);
            // 
            // FolderButton
            // 
            this.FolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderButton.Location = new System.Drawing.Point(424, 197);
            this.FolderButton.Name = "FolderButton";
            this.FolderButton.Size = new System.Drawing.Size(75, 23);
            this.FolderButton.TabIndex = 11;
            this.FolderButton.Text = "Folder";
            this.FolderButton.UseVisualStyleBackColor = true;
            // 
            // FileButton
            // 
            this.FileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FileButton.Location = new System.Drawing.Point(424, 226);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(75, 23);
            this.FileButton.TabIndex = 10;
            this.FileButton.Text = "File";
            this.FileButton.UseVisualStyleBackColor = true;
            this.FileButton.Click += new System.EventHandler(this.FileButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(68, 12);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(50, 50);
            this.PauseButton.TabIndex = 8;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(12, 12);
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
            this.MusicListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MusicListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TrackCol,
            this.NameCol,
            this.AlbumCol,
            this.ArtistCol,
            this.LengthCol});
            this.MusicListBox.Location = new System.Drawing.Point(12, 74);
            this.MusicListBox.MultiSelect = false;
            this.MusicListBox.Name = "MusicListBox";
            this.MusicListBox.Size = new System.Drawing.Size(406, 175);
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
            this.Scroll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Scroll.AutoSize = true;
            this.Scroll.Cursor = System.Windows.Forms.Cursors.Default;
            this.Scroll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Scroll.Location = new System.Drawing.Point(475, 169);
            this.Scroll.Name = "Scroll";
            this.Scroll.Size = new System.Drawing.Size(21, 13);
            this.Scroll.TabIndex = 15;
            this.Scroll.Text = "0%";
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Location = new System.Drawing.Point(135, 49);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(49, 13);
            this.LabelTime.TabIndex = 16;
            this.LabelTime.Text = "00:00:00";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 261);
            this.Controls.Add(this.LabelTime);
            this.Controls.Add(this.Scroll);
            this.Controls.Add(this.MusicListBox);
            this.Controls.Add(this.VolumeBar);
            this.Controls.Add(this.TimeBar);
            this.Controls.Add(this.FolderButton);
            this.Controls.Add(this.FileButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.PlayButton);
            this.Name = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar VolumeBar;
        private System.Windows.Forms.TrackBar TimeBar;
        private System.Windows.Forms.Button FolderButton;
        private System.Windows.Forms.Button FileButton;
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

    }
}

