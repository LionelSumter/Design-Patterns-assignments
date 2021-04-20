using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_6_2
{
    interface IMachineFactory
    {
        IProcessor MakeProcessor();
        IHardDisk MakeHardDisk();
        IMonitor MakeMonitor();
    }
}
