using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opdracht_3_extra.Models;

namespace Opdracht_3_extra.Controllers
{
    class MP3Controller : IMP3Controller
    {
        private IMP3Player player;

        // Constructor
        public MP3Controller(IMP3Player player)
        {
            this.player = player;
        }

        // 1-op-1 acties aan player
        public void Play()
        {
            player.Play();
        }

        public void Stop()
        {
            player.Stop();
        }

        public void Next()
        {
            player.Next();
        }

        // aangepaste acties aan player
        public void VolumeUp()
        {
            int volumeLevel = player.VolumeLevel;
            player.SetVolume(++volumeLevel);
        }

        public void VolumeDown()
        {
            int volumeLevel = player.VolumeLevel;
            player.SetVolume(--volumeLevel);
        }
    }
}
