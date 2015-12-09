namespace SandersMediaplayer
{
    partial class PlaylistForm
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
            this.AddPlayButt = new System.Windows.Forms.Button();
            this.RemovePlayButt = new System.Windows.Forms.Button();
            this.PlayListList2 = new System.Windows.Forms.ListView();
            this.AddedNamePlay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddedArtistPlay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlayListList1 = new System.Windows.Forms.ListView();
            this.PlayListName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlayListArtist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreatePlayButt = new System.Windows.Forms.Button();
            this.CancelPlayButt = new System.Windows.Forms.Button();
            this.LabelNamePlaylist = new System.Windows.Forms.Label();
            this.NamePlaylist = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddPlayButt
            // 
            this.AddPlayButt.Location = new System.Drawing.Point(227, 123);
            this.AddPlayButt.Name = "AddPlayButt";
            this.AddPlayButt.Size = new System.Drawing.Size(75, 23);
            this.AddPlayButt.TabIndex = 0;
            this.AddPlayButt.Text = "Add ->";
            this.AddPlayButt.UseVisualStyleBackColor = true;
            this.AddPlayButt.Click += new System.EventHandler(this.AddPlayButt_Click);
            // 
            // RemovePlayButt
            // 
            this.RemovePlayButt.Location = new System.Drawing.Point(227, 158);
            this.RemovePlayButt.Name = "RemovePlayButt";
            this.RemovePlayButt.Size = new System.Drawing.Size(75, 23);
            this.RemovePlayButt.TabIndex = 1;
            this.RemovePlayButt.Text = "<- Remove";
            this.RemovePlayButt.UseVisualStyleBackColor = true;
            this.RemovePlayButt.Click += new System.EventHandler(this.RemovePlayButt_Click);
            // 
            // PlayListList2
            // 
            this.PlayListList2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AddedNamePlay,
            this.AddedArtistPlay});
            this.PlayListList2.FullRowSelect = true;
            this.PlayListList2.Location = new System.Drawing.Point(308, 12);
            this.PlayListList2.Name = "PlayListList2";
            this.PlayListList2.Size = new System.Drawing.Size(210, 300);
            this.PlayListList2.TabIndex = 2;
            this.PlayListList2.UseCompatibleStateImageBehavior = false;
            this.PlayListList2.View = System.Windows.Forms.View.Details;
            this.PlayListList2.SelectedIndexChanged += new System.EventHandler(this.PlayListList2_SelectedIndexChanged_1);
            this.PlayListList2.DoubleClick += new System.EventHandler(this.PlayListList2_DoubleClick);
            // 
            // AddedNamePlay
            // 
            this.AddedNamePlay.Text = "Name";
            this.AddedNamePlay.Width = 100;
            // 
            // AddedArtistPlay
            // 
            this.AddedArtistPlay.Text = "Artist";
            this.AddedArtistPlay.Width = 89;
            // 
            // PlayListList1
            // 
            this.PlayListList1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PlayListName,
            this.PlayListArtist});
            this.PlayListList1.FullRowSelect = true;
            this.PlayListList1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.PlayListList1.Location = new System.Drawing.Point(12, 12);
            this.PlayListList1.Name = "PlayListList1";
            this.PlayListList1.Size = new System.Drawing.Size(210, 300);
            this.PlayListList1.TabIndex = 3;
            this.PlayListList1.UseCompatibleStateImageBehavior = false;
            this.PlayListList1.View = System.Windows.Forms.View.Details;
            this.PlayListList1.SelectedIndexChanged += new System.EventHandler(this.PlayListList1_SelectedIndexChanged);
            this.PlayListList1.DoubleClick += new System.EventHandler(this.PlayListList1_DoubleClick);
            // 
            // PlayListName
            // 
            this.PlayListName.Text = "Name";
            this.PlayListName.Width = 100;
            // 
            // PlayListArtist
            // 
            this.PlayListArtist.Text = "Artist";
            this.PlayListArtist.Width = 89;
            // 
            // CreatePlayButt
            // 
            this.CreatePlayButt.Location = new System.Drawing.Point(362, 320);
            this.CreatePlayButt.Name = "CreatePlayButt";
            this.CreatePlayButt.Size = new System.Drawing.Size(75, 23);
            this.CreatePlayButt.TabIndex = 4;
            this.CreatePlayButt.Text = "Create";
            this.CreatePlayButt.UseVisualStyleBackColor = true;
            this.CreatePlayButt.Click += new System.EventHandler(this.CreatePlayButt_Click);
            // 
            // CancelPlayButt
            // 
            this.CancelPlayButt.Location = new System.Drawing.Point(443, 320);
            this.CancelPlayButt.Name = "CancelPlayButt";
            this.CancelPlayButt.Size = new System.Drawing.Size(75, 23);
            this.CancelPlayButt.TabIndex = 5;
            this.CancelPlayButt.Text = "Cancel";
            this.CancelPlayButt.UseVisualStyleBackColor = true;
            this.CancelPlayButt.Click += new System.EventHandler(this.CancelPlayButt_Click);
            // 
            // LabelNamePlaylist
            // 
            this.LabelNamePlaylist.AutoSize = true;
            this.LabelNamePlaylist.Location = new System.Drawing.Point(14, 325);
            this.LabelNamePlaylist.Name = "LabelNamePlaylist";
            this.LabelNamePlaylist.Size = new System.Drawing.Size(73, 13);
            this.LabelNamePlaylist.TabIndex = 7;
            this.LabelNamePlaylist.Text = "Name Playlist:";
            // 
            // NamePlaylist
            // 
            this.NamePlaylist.Location = new System.Drawing.Point(93, 323);
            this.NamePlaylist.Name = "NamePlaylist";
            this.NamePlaylist.Size = new System.Drawing.Size(263, 20);
            this.NamePlaylist.TabIndex = 8;
            // 
            // PlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 352);
            this.Controls.Add(this.NamePlaylist);
            this.Controls.Add(this.LabelNamePlaylist);
            this.Controls.Add(this.CancelPlayButt);
            this.Controls.Add(this.CreatePlayButt);
            this.Controls.Add(this.PlayListList1);
            this.Controls.Add(this.PlayListList2);
            this.Controls.Add(this.RemovePlayButt);
            this.Controls.Add(this.AddPlayButt);
            this.Name = "PlaylistForm";
            this.Text = "Create Playlist";
            this.Load += new System.EventHandler(this.PlaylistForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddPlayButt;
        private System.Windows.Forms.Button RemovePlayButt;
        private System.Windows.Forms.ColumnHeader AddedNamePlay;
        private System.Windows.Forms.ColumnHeader AddedArtistPlay;
        private System.Windows.Forms.ColumnHeader PlayListName;
        private System.Windows.Forms.ColumnHeader PlayListArtist;
        private System.Windows.Forms.Button CancelPlayButt;
        public System.Windows.Forms.ListView PlayListList2;
        public System.Windows.Forms.ListView PlayListList1;
        private System.Windows.Forms.Label LabelNamePlaylist;
        private System.Windows.Forms.Button CreatePlayButt;
        private System.Windows.Forms.TextBox NamePlaylist;
    }
}