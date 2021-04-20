using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3_extra.Models
{
    class MP3Player : IMP3Player
    {
        // Members
        private List<Song> playList;

        private Song currentSong;
        private int songIndex = 0;
        private bool isPlaying;
        private int volumeLevel;

        // Lists observers
        private List<ISongObserver> songObservers;
        private List<IVolumeObserver> volumeObservers;

        // Properties
        public Song CurrentSong { get { return currentSong; } }
        public bool IsPlaying { get { return isPlaying; } }
        public int VolumeLevel { get { return volumeLevel; } }

        public MP3Player()
        {
            // Vul playlist
            playList = new List<Song>();
            playList.Add(new Song("Seven Nation Army", "The White Stripes"));
            playList.Add(new Song("Summer", "Calvin Harris"));
            playList.Add(new Song("Castle of Glass", "Linkin Park"));

            // Maak observer lists
            songObservers = new List<ISongObserver>();
            volumeObservers = new List<IVolumeObserver>();
        }

        // Observers
        public void AddObserver(ISongObserver observer)
        {
            songObservers.Add(observer);
        }

        public void AddObserver(IVolumeObserver observer)
        {
            volumeObservers.Add(observer);
        }

        public void RemoveObserver(ISongObserver observer)
        {
            songObservers.Remove(observer);
        }

        public void RemoveObserver(IVolumeObserver observer)
        {
            volumeObservers.Remove(observer);
        }

        private void NotifySongObserver()
        {
            foreach(ISongObserver observer in this.songObservers)
            {
                observer.Update(this.currentSong); // is 'this' nodig?
            }
        }

        private void NotifyVolumeObserver()
        {
            foreach(IVolumeObserver observer in this.volumeObservers)
            {
                observer.Update(this.volumeLevel);
            }
        }

        // Methoden
        public void Play()
        {
            isPlaying = true;
            currentSong = playList[songIndex]; 
            SetVolume(volumeLevel = 10); // Zet volume standaard op 10 bij opstarten
            NotifySongObserver();
        }

        public void Stop()
        {          
            isPlaying = false;
            currentSong = null;
            NotifySongObserver();
        }

        public void Next()
        {     
            // Volgend nummer
            if (isPlaying == true)
            {
                currentSong = playList[songIndex++];
            }   
            
            else currentSong = null;

            // Herhaal lijst
            if (songIndex == 3)
            {
                songIndex = 0;
            }

            NotifySongObserver();
        }

        public void SetVolume(int volumeLevel)
        {
            this.volumeLevel = volumeLevel;
            NotifyVolumeObserver();
        }
    }
}
