using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using NAudio;
using NAudio.Wave;
using TagLib;

namespace WindowsFormsApplication1
{

    public partial class Main : Form
    {
        IWavePlayer Player = new WaveOut();
        OpenFileDialog Mp3File = new OpenFileDialog();
        List<string> Items = new List<string>();
        private NAudio.Wave.DirectSoundOut output = null;
        public Main()
        {
            InitializeComponent();
            Mp3File.FileName = "";
            Player.Volume = 0f;
            VolumeBar.TickFrequency = 33;
            VolumeBar.Maximum = 100;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            try
            {
                output = new NAudio.Wave.DirectSoundOut();
                Player.Play();
                MusicTimer.Start();

            }
            catch (Exception ex)
            {
                
            }
        }
        private void PauseButton_Click(object sender, EventArgs e)
        {
            Player.Pause();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            Mp3File.Title = "Choose a .mp3 file";
            Mp3File.Filter = "Mp3 Files|*.mp3";
            Mp3File.InitialDirectory = "C:/";
            if (Mp3File.ShowDialog() == DialogResult.OK)
            {
                TagLib.File TagFile = TagLib.File.Create(Mp3File.FileName);
                Mp3FileReader Mp3Duration = new Mp3FileReader(Mp3File.FileName);
                string Name = TagFile.Tag.Title;
                string Artist = TagFile.Tag.FirstPerformer;
                string Album = TagFile.Tag.Album;
                uint TrackNumber = TagFile.Tag.Track;
                string StrTrack = TrackNumber.ToString();
                TimeSpan Length = Mp3Duration.TotalTime;
                string StrLength = Length.ToString();
                int Index = StrLength.LastIndexOf(".");
                StrLength = StrLength.Substring(0, Index);
                ListViewItem item = new ListViewItem();
                item.Text = StrTrack;
                item.SubItems.Add(Name);
                item.SubItems.Add(Artist);
                item.SubItems.Add(Album);
                item.SubItems.Add(StrLength);
                MusicListBox.Items.Add(item);
                AudioFileReader File = new AudioFileReader(Mp3File.FileName);
                Player.Init(File);
            }
        }

        private void VolumeBar_Scroll(object sender, EventArgs e)
        {

        }

        private void VolumeBar_ValueChanged(object sender, EventArgs e)
        {
            Scroll.Text = VolumeBar.Value + "%";
            int VolValue = VolumeBar.Value + 1;
            if (VolumeBar.Value < VolValue)
            {
                Player.Volume -= 0.01f;
            }
            else
            {
                Player.Volume += 0.01f;
            }
        }
    }
}
