using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3_extra.Controllers
{
    public interface IMP3Controller
    {
        void Play();
        void Stop();
        void Next();
        void VolumeUp();
        void VolumeDown();
    }
}
