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
using System.IO;
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
        List<string> PlayListList = new List<string>();
        public static List<string> Mp3Array = new List<string>();
        public static List<string> Mp3PlaylistArray = new List<string>();
        List<string> TempArray = new List<string>();
        static string Path = "Playlists/Music.txt";
        int Hours = 0;
        int Minutes = 0;
        int Seconds = 0;
        int AddTime = 0;
        int ScrollTime = 0;
        int a = 0;
        bool CheckPlay = true;
        bool CheckAutoPlay = true;
        bool CheckShuffle = false;
        bool CheckFocusedItem = false;
        bool CheckItems = false;
        bool IsPlaying = false;
        bool FirstPlay = false;
        bool Playing = false;
        public Main()
        {
            InitializeComponent();
            Mp3File.FileName = "";
            InfoArtist.Text = "";
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (FirstPlay)
                {
                    AudioFileReader File = new AudioFileReader(Mp3Array[0]);
                    FileInfo InfoFile = new FileInfo(Mp3Array[0]);
                    Player.Init(File);
                    TagLib.File TagFile = TagLib.File.Create(Mp3Array[0]);
                    if (TagFile.Tag.Title != null)
                    {
                        InfoArtist.Text = TagFile.Tag.FirstPerformer + " - " + TagFile.Tag.Title;
                    }
                    else
                    {
                        string NewInfoFile = InfoFile.Name.Replace(".mp3", "");
                        InfoArtist.Text = NewInfoFile;
                    }
                    Mp3FileReader Mp3Duration = new Mp3FileReader(Mp3Array[a]);
                    TimeSpan Length = Mp3Duration.TotalTime;
                    string StrLength = Length.ToString();
                    int Index = StrLength.LastIndexOf(".");
                    StrLength = StrLength.Substring(0, Index);
                    LabelTime.Text = "00:00:00 / " + StrLength;
                    try
                    {
                        MemoryStream ms = new MemoryStream(TagFile.Tag.Pictures[0].Data.Data);
                        System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
                        CoverBox.BackgroundImage = image;
                    }
                    catch
                    {
                        CoverBox.BackgroundImage = CoverBox.ErrorImage;
                    }
                    Player.Play();
                    MusicTimer.Start();
                    IsPlaying = true;
                    PlayButton.Visible = false;
                    PauseButton.Visible = true;
                    FirstPlay = false;
                }
                if (CheckFocusedItem)
                {
                    if (Playlists.FocusedItem.Text == "Music")
                    {
                        Player.Pause();
                        MusicTimer.Stop();
                        Seconds = 0;
                        Minutes = 0;
                        Hours = 0;
                        AddTime = 0;
                        TimeBar.Maximum = 0;
                        TimeBar.Value = 0;
                        a = MusicListBox.FocusedItem.Index;
                        Mp3FileReader Mp3Duration = new Mp3FileReader(Mp3Array[a]);
                        TimeSpan Length = Mp3Duration.TotalTime;
                        string StrLength = Length.ToString();
                        int Index = StrLength.LastIndexOf(".");
                        StrLength = StrLength.Substring(0, Index);
                        LabelTime.Text = "00:00:00 / " + StrLength;
                        TimeBar.Maximum = 0;
                        TimeBar.Value = 0;
                        AudioFileReader File = new AudioFileReader(Mp3Array[a]);
                        Player.Init(File);
                        TagLib.File TagFile = TagLib.File.Create(Mp3Array[a]);
                        FileInfo InfoFile = new FileInfo(Mp3Array[a]);
                        if (TagFile.Tag.Title != null)
                        {
                            InfoArtist.Text = TagFile.Tag.FirstPerformer + " - " + TagFile.Tag.Title;
                        }
                        else
                        {
                            string NewInfoFile = InfoFile.Name.Replace(".mp3", "");
                            InfoArtist.Text = NewInfoFile;
                        }
                        try
                        {
                            MemoryStream ms = new MemoryStream(TagFile.Tag.Pictures[0].Data.Data);
                            System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
                            CoverBox.BackgroundImage = image;
                        }
                        catch
                        {
                            CoverBox.BackgroundImage = CoverBox.ErrorImage;
                        }
                    } else
                    {
                        Player.Pause();
                        MusicTimer.Stop();
                        Seconds = 0;
                        Minutes = 0;
                        Hours = 0;
                        AddTime = 0;
                        TimeBar.Maximum = 0;
                        TimeBar.Value = 0;
                        a = MusicListBox.FocusedItem.Index;
                        Mp3FileReader Mp3Duration = new Mp3FileReader(Mp3PlaylistArray[a]);
                        TimeSpan Length = Mp3Duration.TotalTime;
                        string StrLength = Length.ToString();
                        int Index = StrLength.LastIndexOf(".");
                        StrLength = StrLength.Substring(0, Index);
                        LabelTime.Text = "00:00:00 / " + StrLength;
                        TimeBar.Maximum = 0;
                        TimeBar.Value = 0;
                        AudioFileReader File = new AudioFileReader(Mp3PlaylistArray[a]);
                        Player.Init(File);
                        TagLib.File TagFile = TagLib.File.Create(Mp3PlaylistArray[a]);
                        FileInfo InfoFile = new FileInfo(Mp3PlaylistArray[a]);
                        if (TagFile.Tag.Title != null)
                        {
                            InfoArtist.Text = TagFile.Tag.FirstPerformer + " - " + TagFile.Tag.Title;
                        }
                        else
                        {
                            string NewInfoFile = InfoFile.Name.Replace(".mp3", "");
                            InfoArtist.Text = NewInfoFile;
                        }
                        try
                        {
                            MemoryStream ms = new MemoryStream(TagFile.Tag.Pictures[0].Data.Data);
                            System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
                            CoverBox.BackgroundImage = image;
                        }
                        catch
                        {
                            CoverBox.BackgroundImage = CoverBox.ErrorImage;
                        }
                    }

                    Player.Play();
                    MusicTimer.Start();
                    CheckFocusedItem = false;
                    IsPlaying = true;
                    Playing = false;
                    PlayButton.Visible = false;
                    PauseButton.Visible = true;
                }
                if (Playing)
                {
                    Player.Play();
                    MusicTimer.Start();
                    IsPlaying = true;
                    Playing = false;
                    PlayButton.Visible = false;
                    PauseButton.Visible = true;
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (IsPlaying)
            {
                Player.Pause();
                MusicTimer.Stop();
                IsPlaying = false;
                Playing = true;
                PlayButton.Visible = true;
                PauseButton.Visible = false;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MusicTimer_Tick(object sender, EventArgs e)
        {
            if (Playlists.FocusedItem.Text == "Music")
            {
                #region HasMusic
                TagLib.File Mp3Duration = TagLib.File.Create(Mp3Array[a]);
                TimeSpan Length = Mp3Duration.Properties.Duration;
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
                TimeBar.Value = Seconds + AddTime + ScrollTime;
                Seconds = Seconds + ScrollTime;
                if (Seconds >= 10)
                {
                    if (Minutes >= 10)
                    {
                        string TotalTime = "0" + Hours.ToString() + ":" + Minutes.ToString() + ":" + Seconds.ToString();
                    }
                    else
                    {
                        string TotalTime = "0" + Hours.ToString() + ":" + "0" + Minutes.ToString() + ":" + Seconds.ToString();
                        LabelTime.Text = TotalTime + " / " + StrLength;
                    }
                }
                else
                {
                    string TotalTime = "0" + Hours.ToString() + ":" + "0" + Minutes.ToString() + ":0" + Seconds.ToString();
                    LabelTime.Text = TotalTime + " / " + StrLength;
                }
                if (TimeBar.Value == MaxTime)
                {
                    try
                    {
                        TagLib.File TagFile = TagLib.File.Create(Mp3Array[a]);
                        MemoryStream ms = new MemoryStream(TagFile.Tag.Pictures[0].Data.Data);
                        System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
                        CoverBox.BackgroundImage = image;
                    }
                    catch
                    {
                        CoverBox.BackgroundImage = CoverBox.ErrorImage;
                    }
                    if (CheckAutoPlay == true)
                    {
                        if (CheckShuffle == true)
                        {
                            Seconds = 0;
                            Minutes = 0;
                            Hours = 0;
                            AddTime = 0;
                            LabelTime.Text = "00:00:00 / 00:00:00";
                            TimeBar.Maximum = 0;
                            TimeBar.Value = 0;
                            MaxTime = 0;
                            Random rnd = new Random();
                            a = rnd.Next(0, Mp3Array.Count());
                            try
                            {
                                TagLib.File TagFile = TagLib.File.Create(Mp3Array[a]);
                                FileInfo InfoFile = new FileInfo(Mp3Array[a]);
                                if (TagFile.Tag.Title != null)
                                {
                                    InfoArtist.Text = TagFile.Tag.FirstPerformer + " - " + TagFile.Tag.Title;
                                }
                                else
                                {
                                    string NewInfoFile = InfoFile.Name.Replace(".mp3", "");
                                    InfoArtist.Text = NewInfoFile;
                                }
                                MemoryStream ms = new MemoryStream(TagFile.Tag.Pictures[0].Data.Data);
                                System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
                                CoverBox.BackgroundImage = image;
                            }
                            catch
                            {
                                CoverBox.BackgroundImage = CoverBox.ErrorImage;
                            }
                            try
                            {
                                AudioFileReader File = new AudioFileReader(Mp3Array[a]);
                                Player.Init(File);
                                Player.Play();
                            }
                            catch
                            {
                                MusicTimer.Stop();
                                Player.Stop();
                            }
                        }
                        else
                        {
                            Seconds = 0;
                            Minutes = 0;
                            Hours = 0;
                            AddTime = 0;
                            LabelTime.Text = "00:00:00 / 00:00:00";
                            TimeBar.Maximum = 0;
                            TimeBar.Value = 0;
                            MaxTime = 0;
                            a++;
                            try
                            {
                                TagLib.File TagFile = TagLib.File.Create(Mp3Array[a]);
                                FileInfo InfoFile = new FileInfo(Mp3Array[a]);
                                if (TagFile.Tag.Title != null)
                                {
                                    InfoArtist.Text = TagFile.Tag.FirstPerformer + " - " + TagFile.Tag.Title;
                                }
                                else
                                {
                                    string NewInfoFile = InfoFile.Name.Replace(".mp3", "");
                                    InfoArtist.Text = NewInfoFile;
                                }
                                MemoryStream ms = new MemoryStream(TagFile.Tag.Pictures[0].Data.Data);
                                System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
                                CoverBox.BackgroundImage = image;
                            }
                            catch
                            {
                                CoverBox.BackgroundImage = CoverBox.ErrorImage;
                            }
                            try
                            {
                                AudioFileReader File = new AudioFileReader(Mp3Array[a]);
                                Player.Init(File);
                                Player.Play();
                            }
                            catch
                            {
                                MusicTimer.Stop();
                                Player.Stop();
                            }
                        }
                    }
                    else
                    {
                        Seconds = 0;
                        Minutes = 0;
                        Hours = 0;
                        AddTime = 0;
                        LabelTime.Text = "00:00:00 / 00:00:00";
                        TimeBar.Maximum = 0;
                        TimeBar.Value = 0;
                        MaxTime = 0;
                        a = 0;
                        MusicTimer.Stop();
                    }
                    #endregion
                }
            }
            else
            {
                #region NoMusic
                TagLib.File Mp3Duration = TagLib.File.Create(Mp3PlaylistArray[a]);
                TimeSpan Length = Mp3Duration.Properties.Duration;
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
                TimeBar.Value = Seconds + AddTime + ScrollTime;
                Seconds = Seconds + ScrollTime;
                if (Seconds >= 10)
                {
                    if (Minutes >= 10)
                    {
                        string TotalTime = "0" + Hours.ToString() + ":" + Minutes.ToString() + ":" + Seconds.ToString();
                    }
                    else
                    {
                        string TotalTime = "0" + Hours.ToString() + ":" + "0" + Minutes.ToString() + ":" + Seconds.ToString();
                        LabelTime.Text = TotalTime + " / " + StrLength;
                    }
                }
                else
                {
                    string TotalTime = "0" + Hours.ToString() + ":" + "0" + Minutes.ToString() + ":0" + Seconds.ToString();
                    LabelTime.Text = TotalTime + " / " + StrLength;
                }
                if (TimeBar.Value == MaxTime)
                {
                    try
                    {
                        TagLib.File TagFile = TagLib.File.Create(Mp3PlaylistArray[a]);
                        MemoryStream ms = new MemoryStream(TagFile.Tag.Pictures[0].Data.Data);
                        System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
                        CoverBox.BackgroundImage = image;
                    }
                    catch
                    {
                        CoverBox.BackgroundImage = CoverBox.ErrorImage;
                    }
                    if (CheckAutoPlay == true)
                    {
                        if (CheckShuffle == true)
                        {
                            Seconds = 0;
                            Minutes = 0;
                            Hours = 0;
                            AddTime = 0;
                            LabelTime.Text = "00:00:00 / 00:00:00";
                            TimeBar.Maximum = 0;
                            TimeBar.Value = 0;
                            MaxTime = 0;
                            Random rnd = new Random();
                            a = rnd.Next(0, Mp3PlaylistArray.Count());
                            if (Playlists.FocusedItem.Text == "Music")
                            {
                                try
                                {
                                    TagLib.File TagFile = TagLib.File.Create(Mp3PlaylistArray[a]);
                                    FileInfo InfoFile = new FileInfo(Mp3PlaylistArray[a]);
                                    if (TagFile.Tag.Title != null)
                                    {
                                        InfoArtist.Text = TagFile.Tag.FirstPerformer + " - " + TagFile.Tag.Title;
                                    }
                                    else
                                    {
                                        string NewInfoFile = InfoFile.Name.Replace(".mp3", "");
                                        InfoArtist.Text = NewInfoFile;
                                    }
                                    MemoryStream ms = new MemoryStream(TagFile.Tag.Pictures[0].Data.Data);
                                    System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
                                    CoverBox.BackgroundImage = image;
                                }
                                catch
                                {
                                    CoverBox.BackgroundImage = CoverBox.ErrorImage;
                                }
                                try
                                {
                                    AudioFileReader File = new AudioFileReader(Mp3PlaylistArray[a]);
                                    Player.Init(File);
                                    Player.Play();
                                }
                                catch
                                {
                                    MusicTimer.Stop();
                                    Player.Stop();
                                }
                            }
                            else
                            {
                                try
                                {
                                    TagLib.File TagFile = TagLib.File.Create(Mp3PlaylistArray[a]);
                                    FileInfo InfoFile = new FileInfo(Mp3PlaylistArray[a]);
                                    if (TagFile.Tag.Title != null)
                                    {
                                        InfoArtist.Text = TagFile.Tag.FirstPerformer + " - " + TagFile.Tag.Title;
                                    }
                                    else
                                    {
                                        string NewInfoFile = InfoFile.Name.Replace(".mp3", "");
                                        InfoArtist.Text = NewInfoFile;
                                    }
                                    MemoryStream ms = new MemoryStream(TagFile.Tag.Pictures[0].Data.Data);
                                    System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
                                    CoverBox.BackgroundImage = image;
                                }
                                catch
                                {
                                    CoverBox.BackgroundImage = CoverBox.ErrorImage;
                                }
                                a = rnd.Next(0, Mp3PlaylistArray.Count());
                                try
                                {
                                    AudioFileReader File = new AudioFileReader(Mp3PlaylistArray[a]);
                                    Player.Init(File);
                                    Player.Play();
                                }
                                catch
                                {
                                    MusicTimer.Stop();
                                    Player.Stop();
                                }
                            }
                        }
                        else
                        {
                            Seconds = 0;
                            Minutes = 0;
                            Hours = 0;
                            AddTime = 0;
                            LabelTime.Text = "00:00:00 / 00:00:00";
                            TimeBar.Maximum = 0;
                            TimeBar.Value = 0;
                            MaxTime = 0;
                            a++;
                            try
                            {
                                TagLib.File TagFile = TagLib.File.Create(Mp3PlaylistArray[a]);
                                FileInfo InfoFile = new FileInfo(Mp3PlaylistArray[a]);
                                if (TagFile.Tag.Title != null)
                                {
                                    InfoArtist.Text = TagFile.Tag.FirstPerformer + " - " + TagFile.Tag.Title;
                                }
                                else
                                {
                                    string NewInfoFile = InfoFile.Name.Replace(".mp3", "");
                                    InfoArtist.Text = NewInfoFile;
                                }
                                MemoryStream ms = new MemoryStream(TagFile.Tag.Pictures[0].Data.Data);
                                System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
                                CoverBox.BackgroundImage = image;
                            }
                            catch
                            {
                                CoverBox.BackgroundImage = CoverBox.ErrorImage;
                            }
                            try
                            {
                                AudioFileReader File = new AudioFileReader(Mp3PlaylistArray[a]);
                                Player.Init(File);
                                Player.Play();
                            }
                            catch
                            {
                                MusicTimer.Stop();
                                Player.Stop();
                            }
                        }
                    }
                    else
                    {
                        Seconds = 0;
                        Minutes = 0;
                        Hours = 0;
                        AddTime = 0;
                        LabelTime.Text = "00:00:00 / 00:00:00";
                        TimeBar.Maximum = 0;
                        TimeBar.Value = 0;
                        MaxTime = 0;
                        a = 0;
                        MusicTimer.Stop();
                    }
                    #endregion
                }
            }
        }

        private void TimeBar_Scroll(object sender, EventArgs e)
        {
            Seconds = Seconds + 1;
        }

        private void MusicListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Playlists.FocusedItem.Text == "Music")
            {
                try
                {
                    TagLib.File TagFile = TagLib.File.Create(Mp3Array[a]);
                    MemoryStream ms = new MemoryStream(TagFile.Tag.Pictures[0].Data.Data);
                    System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
                    CoverBox.BackgroundImage = image;
                }
                catch
                {
                    CoverBox.BackgroundImage = CoverBox.ErrorImage;
                }
                CheckFocusedItem = true;
                FirstPlay = false;
            } else
            {
                try
                {
                    TagLib.File TagFile = TagLib.File.Create(Mp3PlaylistArray[a]);
                    MemoryStream ms = new MemoryStream(TagFile.Tag.Pictures[0].Data.Data);
                    System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
                    CoverBox.BackgroundImage = image;
                }
                catch
                {
                    CoverBox.BackgroundImage = CoverBox.ErrorImage;
                }
                CheckFocusedItem = true;
                FirstPlay = false;
            }

        }

        private void SettingsAddFile_Click(object sender, EventArgs e)
        {
            Mp3File.Title = "Choose a .mp3 file";
            Mp3File.Filter = "Mp3 Files|*.mp3";
            Mp3File.InitialDirectory = "C:/";
            Mp3File.Multiselect = true;
            if (Mp3File.ShowDialog() == DialogResult.OK)
            {
                foreach(ListViewItem Item in Playlists.Items)
                {
                    if (Item.Text == "Music")
                    {
                        Playlists.Items.Remove(Item);
                        break;
                    }
                }
                Mp3PlaylistArray.Remove("Music");
                TextWriter tw = new StreamWriter(Path, true);
                string[] TempMp3Array = Mp3File.FileNames;
                foreach (var Items in TempMp3Array)
                {
                    TempArray.Add(Items);
                }
                if (CheckItems)
                {
                    MusicListBox.Items.Clear();
                }              
                Playlists.Items.Add("Music");
                Mp3PlaylistArray.Add("Music");
                foreach (var Items in TempArray)
                {
                    try
                    {
                        TagLib.File TagFile = TagLib.File.Create(Items);
                        TimeSpan Length = TagFile.Properties.Duration;
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
                        tw.WriteLine(Items);
                        Mp3Array.Add(Items);
                        CheckItems = true;
                        FirstPlay = true;
                        Playing = true;
                    }
                    catch
                    {
                        break;
                    }
                }
                TempArray.Clear();
                tw.Close();
            }
        }

        private void CheckBoxAutoPlay_Click(object sender, EventArgs e)
        {
            if (CheckPlay)
            {
                CheckPlay = true;
            }
            else
            {
                CheckAutoPlay = false;
            }
        }

        private void CheckBoxShuffle_Click(object sender, EventArgs e)
        {
            if (CheckShuffle)
            {
                CheckShuffle = false;
            }
            else
            {
                CheckShuffle = true;
            }
        }

        private void MusicListBox_DoubleClick(object sender, EventArgs e)
        {
            if (Playlists.FocusedItem.Text == "Music")
            {
                Player.Pause();
                MusicTimer.Stop();
                Seconds = 0;
                Minutes = 0;
                Hours = 0;
                AddTime = 0;
                TimeBar.Maximum = 0;
                TimeBar.Value = 0;
                a = MusicListBox.FocusedItem.Index;
                Mp3FileReader Mp3Duration = new Mp3FileReader(Mp3Array[a]);
                TimeSpan Length = Mp3Duration.TotalTime;
                string StrLength = Length.ToString();
                int Index = StrLength.LastIndexOf(".");
                StrLength = StrLength.Substring(0, Index);
                LabelTime.Text = "00:00:00 / " + StrLength;
                TimeBar.Maximum = 0;
                TimeBar.Value = 0;
                AudioFileReader File = new AudioFileReader(Mp3Array[a]);
                Player.Init(File);
                TagLib.File TagFile = TagLib.File.Create(Mp3Array[a]);
                FileInfo InfoFile = new FileInfo(Mp3Array[a]);
                if (TagFile.Tag.Title != null)
                {
                    InfoArtist.Text = TagFile.Tag.FirstPerformer + " - " + TagFile.Tag.Title;
                }
                else
                {
                    string NewInfoFile = InfoFile.Name.Replace(".mp3", "");
                    InfoArtist.Text = NewInfoFile;
                }
                try
                {
                    MemoryStream ms = new MemoryStream(TagFile.Tag.Pictures[0].Data.Data);
                    System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
                    CoverBox.BackgroundImage = image;
                }
                catch
                {
                    CoverBox.BackgroundImage = CoverBox.ErrorImage;
                }
            }
            else
            {
                Player.Pause();
                MusicTimer.Stop();
                Seconds = 0;
                Minutes = 0;
                Hours = 0;
                AddTime = 0;
                TimeBar.Maximum = 0;
                TimeBar.Value = 0;
                a = MusicListBox.FocusedItem.Index;
                Mp3FileReader Mp3Duration = new Mp3FileReader(Mp3PlaylistArray[a]);
                TimeSpan Length = Mp3Duration.TotalTime;
                string StrLength = Length.ToString();
                int Index = StrLength.LastIndexOf(".");
                StrLength = StrLength.Substring(0, Index);
                LabelTime.Text = "00:00:00 / " + StrLength;
                TimeBar.Maximum = 0;
                TimeBar.Value = 0;
                AudioFileReader File = new AudioFileReader(Mp3PlaylistArray[a]);
                Player.Init(File);
                TagLib.File TagFile = TagLib.File.Create(Mp3PlaylistArray[a]);
                FileInfo InfoFile = new FileInfo(Mp3PlaylistArray[a]);
                if (TagFile.Tag.Title != null)
                {
                    InfoArtist.Text = TagFile.Tag.FirstPerformer + " - " + TagFile.Tag.Title;
                }
                else
                {
                    string NewInfoFile = InfoFile.Name.Replace(".mp3", "");
                    InfoArtist.Text = NewInfoFile;
                }
                try
                {
                    MemoryStream ms = new MemoryStream(TagFile.Tag.Pictures[0].Data.Data);
                    System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
                    CoverBox.BackgroundImage = image;
                }
                catch
                {
                    CoverBox.BackgroundImage = CoverBox.ErrorImage;
                }
            }
            Player.Play();
            MusicTimer.Start();
            CheckFocusedItem = false;
            IsPlaying = true;
            Playing = false;
            PlayButton.Visible = false;
            PauseButton.Visible = true;
        }

        private void DeleteButt_Click(object sender, EventArgs e)
        {
            if (CheckFocusedItem)
            {
                int b = MusicListBox.FocusedItem.Index;
                MusicListBox.Items[b].Remove();
                string Item = Mp3Array[b];
                Mp3Array.Remove(Item);
                CheckFocusedItem = false;
            }
        }

        private void ClearListButt_Click(object sender, EventArgs e)
        {
            MusicListBox.Items.Clear();
            Mp3Array.Clear();
        }

        private void newPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlaylistForm Form = new PlaylistForm(this);
            Form.ShowDialog();
        }

        private void Playlists_SelectedIndexChanged(object sender, EventArgs e)
        {
            string line;
            MusicListBox.Items.Clear();
            Mp3PlaylistArray.Clear();
            int a = Playlists.FocusedItem.Index;
            if (a == -1)
            {
                a = 0;
            }
            StreamReader AddFile = new StreamReader("Playlists/" + Playlists.Items[a].Text + ".txt");
            while ((line = AddFile.ReadLine()) != null)
            {
                Mp3PlaylistArray.Add(line);
                TagLib.File TagFile = TagLib.File.Create(line);
                TimeSpan Length = TagFile.Properties.Duration;
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
            AddFile.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string PlaylistItem;
            bool exists = System.IO.Directory.Exists("Playlists");
            if (!exists)
                System.IO.Directory.CreateDirectory("Playlists");

            foreach (var Item in Directory.GetFiles("Playlists/"))
            {
                StreamReader AddFile = new StreamReader("Playlists/Music.txt");
                if (Item == "Playlists/Music.txt")
                {
                    string line = "";
                    while ((line = AddFile.ReadLine()) != null)
                    {
                        Mp3Array.Add(line);
                    }
                }
                PlaylistItem = Item;
                PlaylistItem = PlaylistItem.Replace("Playlists/", "");
                PlaylistItem = PlaylistItem.Replace(".txt", "");
                Playlists.Items.Add(PlaylistItem);
                AddFile.Close();
            }
        }

        private void deletePlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = Playlists.FocusedItem.Index;
            System.IO.File.Delete("Playlists/" + Playlists.Items[a].Text + ".txt");
            Playlists.Items[a].Remove();
        }
    }
}