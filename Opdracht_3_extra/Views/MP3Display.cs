using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Opdracht_3_extra.Models;
using Opdracht_3_extra.Controllers;

namespace Opdracht_3_extra
{
    public partial class MP3Display : Form, ISongObserver, IVolumeObserver
    {
        private IMP3Player player;
        private IMP3Controller controller;

        public MP3Display(IMP3Player player, IMP3Controller controller)
        {
            InitializeComponent();

            this.player = player;
            this.controller = controller;

            // Display meldt zich aan als SongObserver en VolumeObserver
            this.player.AddObserver((ISongObserver)this);
            this.player.AddObserver((IVolumeObserver)this);
        }

        public void Update(Song currentSong)
        {
            // Update song-informatie
            if(currentSong == null)
            {
                lbl_song.Text = "Not playing...";
            }

            else
            {
                lbl_song.Text = currentSong.titel + " (" + currentSong.artiest + ")";
            }
        }

        public void Update(int volumeLevel)
        {
            lbl_volume.Text = volumeLevel.ToString();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (player.IsPlaying)
            {
                controller.Stop();
            }

            else
            {
                controller.Play();
            }
        }

        private void btn_nextSong_Click(object sender, EventArgs e)
        {
            controller.Next();
        }

        private void btn_volumeUp_Click(object sender, EventArgs e)
        {
            controller.VolumeUp();
        }

        private void btn_volumeDown_Click(object sender, EventArgs e)
        {           
            controller.VolumeDown();
        }
    }
}
