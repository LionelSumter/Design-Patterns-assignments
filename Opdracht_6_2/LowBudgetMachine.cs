using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_6_2
{
    class LowBudgetMachine : IMachineFactory
    {
        public IProcessor MakeProcessor()
        {
            IProcessor processor = new SlowProcessor();
            return processor;
        }

        public IHardDisk MakeHardDisk()
        {
            IHardDisk harddisk = new SlowHardDisk();
            return harddisk;
        }

        public IMonitor MakeMonitor()
        {
            IMonitor monitor = new SlowMonitor();
            return monitor;
        }
    }
}
