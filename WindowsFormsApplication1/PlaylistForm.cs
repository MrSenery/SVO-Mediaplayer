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
    public partial class PlaylistForm : Form
    {
        bool SelectedIndexPlayList1 = false;
        bool SelectedIndexPlayList2 = false;
        List<string> PlayListItems = new List<string>();
        List<string> PlayListItems2 = new List<string>();
        List<string> Playlist = new List<string>();
        private Main Form1;
        public PlaylistForm(Main form)
        {
            Form1 = form;
            InitializeComponent();
        }     
         
        private void PlaylistForm_Load(object sender, EventArgs e)
        {
            PlayListList1.Items.Clear();
            foreach (var Items in Main.Mp3Array)
            {
                try
                {
                    TagLib.File TagFile = TagLib.File.Create(Items);                  
                    ListViewItem item = new ListViewItem();
                    item.Text = TagFile.Tag.Title;
                    item.SubItems.Add(TagFile.Tag.FirstPerformer);
                    PlayListList1.Items.Add(item);
                }
                catch
                {
                    break;
                }
            }
        }

        private void AddPlayButt_Click(object sender, EventArgs e)
        {
            if (SelectedIndexPlayList1)
            {
                int AddUp = 0;
                foreach (var Items in Main.Mp3Array)
                {
                    PlayListItems.Add(Items);
                }
                foreach (int Index in PlayListList1.SelectedIndices)
                {
                    TagLib.File TagFile = TagLib.File.Create(PlayListItems[Index - AddUp]);
                    ListViewItem item = new ListViewItem();
                    item.Text = TagFile.Tag.Title;
                    item.SubItems.Add(TagFile.Tag.FirstPerformer);
                    PlayListList2.Items.Add(item);
                    PlayListList1.Items[Index - AddUp].Remove();
                    string RemoveFromPlay = PlayListItems[Index - AddUp];
                    PlayListItems.Remove(RemoveFromPlay);
                    AddUp = AddUp + 1;
                }
                SelectedIndexPlayList1 = false;
            }
        }

        private void RemovePlayButt_Click(object sender, EventArgs e)
        {
            if (SelectedIndexPlayList2)
            {
                int AddUp = 0;
                foreach (var Items in Main.Mp3Array)
                {
                    PlayListItems2.Add(Items);
                }
                foreach (int Index in PlayListList2.SelectedIndices)
                {
                    TagLib.File TagFile = TagLib.File.Create(PlayListItems2[Index - AddUp]);
                    ListViewItem item = new ListViewItem();
                    item.Text = TagFile.Tag.Title;
                    item.SubItems.Add(TagFile.Tag.FirstPerformer);
                    PlayListList1.Items.Add(item);
                    PlayListList2.Items[Index - AddUp].Remove();
                    string RemoveFromPlay = PlayListItems2[Index - AddUp];
                    PlayListItems2.Remove(RemoveFromPlay);
                    AddUp = AddUp + 1;
                }
                SelectedIndexPlayList2 = false;
            }
        }

        private void CancelPlayButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlayListList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndexPlayList1 = true;
        }

        private void PlayListList2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SelectedIndexPlayList2 = true;
        }

        private void PlayListList1_DoubleClick(object sender, EventArgs e)
        {
            if (SelectedIndexPlayList1)
            {
                foreach (var Items in Main.Mp3Array)
                {
                    PlayListItems.Add(Items);
                }
                int a = PlayListList1.FocusedItem.Index;
                TagLib.File TagFile = TagLib.File.Create(PlayListItems[a]);
                string RemoveFromPlay = PlayListItems[a];
                PlayListItems.Remove(RemoveFromPlay);
                ListViewItem item = new ListViewItem();
                item.Text = TagFile.Tag.Title;
                item.SubItems.Add(TagFile.Tag.FirstPerformer);
                PlayListList2.Items.Add(item);
                PlayListList1.Items[a].Remove();
                SelectedIndexPlayList1 = false;
            }
        }

        private void PlayListList2_DoubleClick(object sender, EventArgs e)
        {
            if (SelectedIndexPlayList2)
            {
                foreach (var Items in Main.Mp3Array)
                {
                    PlayListItems2.Add(Items);
                }
                int a = PlayListList2.FocusedItem.Index;
                TagLib.File TagFile = TagLib.File.Create(PlayListItems2[a]);
                string RemoveFromPlay = PlayListItems2[a];
                PlayListItems2.Remove(RemoveFromPlay);
                ListViewItem item = new ListViewItem();
                item.Text = TagFile.Tag.Title;
                item.SubItems.Add(TagFile.Tag.FirstPerformer);
                PlayListList1.Items.Add(item);
                PlayListList2.Items[a].Remove();
                SelectedIndexPlayList2 = false;
            }
        }

        private void CreatePlayButt_Click(object sender, EventArgs e)
        {
            if (Form1 == null)
                Form1 = new Main();

            bool exists = System.IO.Directory.Exists("Playlists");
            if (!exists)
                System.IO.Directory.CreateDirectory("Playlists");

            string Path = "Playlists/" + NamePlaylist.Text + ".txt";
            TextWriter tw = new StreamWriter(Path, true);
            ListViewItem item = new ListViewItem();
            item.Text = NamePlaylist.Text;
            Form1.Playlists.Items.Add(item);
            int a = 0;
            foreach (ListViewItem Item in PlayListList2.Items)
            {
                foreach (var Mp3Item in Main.Mp3Array)
                {
                    string Items = Item.Text.Replace("ListViewItem: { }", "");
                    a = Mp3Item.LastIndexOf("\\");
                    string Mp3String = Mp3Item.Remove(0, a);
                    if (Mp3String.Contains(Items))
                    {
                        tw.WriteLine(Mp3Item);
                    }
                }
            }
            tw.Close();
            this.Close();
        }
    }
}
