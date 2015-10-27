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
            this.VolumeBar = new System.Windows.Forms.TrackBar();
            this.TimeBar = new System.Windows.Forms.TrackBar();
            this.FolderButton = new System.Windows.Forms.Button();
            this.FileButton = new System.Windows.Forms.Button();
            this.InfoTextBox = new System.Windows.Forms.RichTextBox();
            this.PauseButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // VolumeBar
            // 
            this.VolumeBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VolumeBar.Location = new System.Drawing.Point(302, 74);
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.VolumeBar.Size = new System.Drawing.Size(45, 146);
            this.VolumeBar.TabIndex = 13;
            this.VolumeBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // TimeBar
            // 
            this.TimeBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeBar.Location = new System.Drawing.Point(124, 12);
            this.TimeBar.Name = "TimeBar";
            this.TimeBar.Size = new System.Drawing.Size(334, 45);
            this.TimeBar.TabIndex = 12;
            // 
            // FolderButton
            // 
            this.FolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderButton.Location = new System.Drawing.Point(302, 226);
            this.FolderButton.Name = "FolderButton";
            this.FolderButton.Size = new System.Drawing.Size(75, 23);
            this.FolderButton.TabIndex = 11;
            this.FolderButton.Text = "Folder";
            this.FolderButton.UseVisualStyleBackColor = true;
            // 
            // FileButton
            // 
            this.FileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FileButton.Location = new System.Drawing.Point(383, 226);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(75, 23);
            this.FileButton.TabIndex = 10;
            this.FileButton.Text = "File";
            this.FileButton.UseVisualStyleBackColor = true;
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoTextBox.Location = new System.Drawing.Point(12, 74);
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.Size = new System.Drawing.Size(284, 175);
            this.InfoTextBox.TabIndex = 9;
            this.InfoTextBox.Text = "";
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 261);
            this.Controls.Add(this.VolumeBar);
            this.Controls.Add(this.TimeBar);
            this.Controls.Add(this.FolderButton);
            this.Controls.Add(this.FileButton);
            this.Controls.Add(this.InfoTextBox);
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
        private System.Windows.Forms.RichTextBox InfoTextBox;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button PlayButton;

    }
}

