using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3_extra.Models
{
    public interface IMP3Player
    {
        void Play();
        void Stop();
        void Next();
        void SetVolume(int volumeLevel);

        // Read-only properties
        Song CurrentSong { get; }
        bool IsPlaying { get; }
        int VolumeLevel { get; }

        // Observers aanmelden/afmelden
        void AddObserver(ISongObserver observer);
        void RemoveObserver(ISongObserver observer);
        void AddObserver(IVolumeObserver observer);
        void RemoveObserver(IVolumeObserver observer);
    }
}
