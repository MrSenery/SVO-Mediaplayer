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
using CSCore;
using CSCore.Codecs;
using CSCore.CoreAudioAPI;
using CSCore.SoundOut;

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        public IWaveSource soundSource;
        public ISoundOut soundOut;
        bool Played = true;
        public Main()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            soundSource = GetSoundSource();
            soundOut = GetSoundOut();
            soundOut.Initialize(soundSource);
            //if (Played)
            //{
                soundOut.Play();
            //    Played = false;
            //}
            //else
            //{
            //    soundOut.Resume();
            //}
        }
        private ISoundOut GetSoundOut()
        {
            return new WasapiOut();
        }
        private IWaveSource GetSoundSource()
        {
            return CodecFactory.Instance.GetCodec(@"C:/Users/Admin/Desktop/Spit It Out.mp3");
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            soundOut.Stop();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Main_FormClosing(object sender, FormClosedEventArgs e)
        {

        }
    }
}
