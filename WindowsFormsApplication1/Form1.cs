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
        public Main()
        {
            InitializeComponent();
            Mp3File.FileName = "";
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            try
            {
                AudioFileReader File = new AudioFileReader(Mp3File.FileName);
                Player.Init(File);
                Player.Play();
            }
            catch (Exception ex)
            {
                
            }
        }
        private void PauseButton_Click(object sender, EventArgs e)
        {
            Player.Pause();
            Player.Dispose();
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
                string Name = TagFile.Tag.Title;
                string Artist = TagFile.Tag.FirstPerformer;
                //var Items = MusicListBox.Items;
                //MusicListBox.Items.Add(Name);
                ////ListViewItem Items = new ListViewItem(MusicListBox);
                //MusicListBox.Items.Add(Artist);
                ListViewItem item = new ListViewItem();
                item.Text = Name;
                item.SubItems.Add(Artist);
                MusicListBox.Items.Add(item);
            }
        }
    }
}
