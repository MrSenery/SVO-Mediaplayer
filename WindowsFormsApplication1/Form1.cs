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
        static int Count = 100;
        string[] Mp3Array = new string[Count];
        static int i = -1;
        int Hours = 0;
        int Minutes = 0;
        int Seconds = 0;
        int AddTime = 0;
        int a = 0;
        bool CheckPlay = true;
        public Main()
        {
            InitializeComponent();
            Mp3File.FileName = "";
            VolumeBar.TickFrequency = 3;
            VolumeBar.Maximum = 10;
            Player.Volume = 1f;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckPlay == true)
                {
                    Player.Play();
                    MusicTimer.Start();
                    CheckPlay = false;
                }
                else
                {
                    Seconds = 0;
                    Minutes = 0;
                    Hours = 0;
                    AddTime = 0;
                }
            }
            catch (Exception ex)
            {
                
            }

        }
        private void PauseButton_Click(object sender, EventArgs e)
        {
            Player.Pause();
            MusicTimer.Stop();
            CheckPlay = true;
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
            Mp3File.Multiselect = true;
            if (Mp3File.ShowDialog() == DialogResult.OK)
            {
                string[] TempMp3Array = Mp3File.FileNames;
                foreach (var Items in TempMp3Array)
                {
                    i++;
                    Mp3Array[i] = Items;
                    
                }
                foreach (var Items in Mp3Array)
                {
                    try
                    {
                        TagLib.File TagFile = TagLib.File.Create(Items);
                        Mp3FileReader Mp3Duration = new Mp3FileReader(Items);
                        TimeSpan Length = Mp3Duration.TotalTime;
                        string StrLength = Length.ToString();
                        int Index = StrLength.LastIndexOf(".");
                        StrLength = StrLength.Substring(0, Index);
                        ListViewItem item = new ListViewItem();
                        item.Text = TagFile.Tag.Track.ToString();
                        item.SubItems.Add(TagFile.Tag.Title);
                        item.SubItems.Add(TagFile.Tag.FirstPerformer);
                        item.SubItems.Add(TagFile.Tag.Album);
                        item.SubItems.Add(StrLength);
                        MusicListBox.Items.Add(item);
                    }
                    catch
                    {
                        break;
                    }
                    
                }                
            }
        }

        private void VolumeBar_Scroll(object sender, EventArgs e)
        {

        }
        private void VolumeBar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MusicTimer_Tick(object sender, EventArgs e)
        {
            Mp3FileReader Mp3Duration = new Mp3FileReader(Mp3Array[a]);
            TimeSpan Length = Mp3Duration.TotalTime;
            string StrLength = Length.ToString();
            int Index = StrLength.LastIndexOf(".");
            StrLength = StrLength.Substring(0, Index);
            int MaxTime = Length.Seconds + Length.Minutes * 60 + Length.Hours * 60 * 60;
            Seconds++;
            if (Seconds >= 60)
            {
                Seconds = 0;
                Minutes++;
                AddTime = AddTime + 60;
            }
            if (Minutes >= 60)
            {
                Minutes = 0;
                Hours++;
                AddTime = AddTime + 3600;
            }
            TimeBar.Maximum = MaxTime;
            TimeBar.Value = Seconds + AddTime;
            if (Seconds >= 10)
            {
                if (Minutes >= 10)
                {
                    string TotalTime = "0" + Hours.ToString() + ":" + Minutes.ToString() + ":" + Seconds.ToString();
                }
                else
                {
                    string TotalTime = "0" + Hours.ToString() + ":" + "0" + Minutes.ToString() + ":" + Seconds.ToString();
                    LabelTime.Text = TotalTime + "/" + StrLength;
                }
            }
            else
            {
                string TotalTime = "0" + Hours.ToString() + ":" + "0" + Minutes.ToString() + ":0" + Seconds.ToString();
                LabelTime.Text = TotalTime + "/" + StrLength;
            }
            if (TimeBar.Value == MaxTime)
            {
                LabelTime.Text = "00:00:00 / 00:00:00";
                a++;
                TimeBar.Maximum = 0;
                TimeBar.Value = 0;
                MaxTime = 0;
                AudioFileReader File = new AudioFileReader(Mp3Array[a]);
                Player.Init(File);
                Player.Play();
            }
        }

        private void TimeBar_Scroll(object sender, EventArgs e)
        {
            //Player.Pause();
        }

        private void MusicListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            a = MusicListBox.FocusedItem.Index;
            AudioFileReader File = new AudioFileReader(Mp3Array[a]);
            Player.Init(File);
        }

    }
}
