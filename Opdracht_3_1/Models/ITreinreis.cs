using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3_1.Models
{
    public interface ITreinreis
    {        
        void VolgendStation();

        // Observers aanmelden/afmelden
        void AddStationObserver(IStationObserver observer);
        void RemoveStationObserver(IStationObserver observer);
    }
}
