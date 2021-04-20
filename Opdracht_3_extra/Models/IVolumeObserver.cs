using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3_extra.Models
{
    public interface IVolumeObserver
    {
        void Update(int volumeLevel);
    }
}
