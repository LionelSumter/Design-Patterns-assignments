using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_6_2
{
    class HighBudgetMachine : IMachineFactory
    {
        public IProcessor MakeProcessor()
        {
            IProcessor processor = new FastProcessor();
            return processor;
        }

        public IHardDisk MakeHardDisk()
        {
            IHardDisk harddisk = new FastHardDisk();
            return harddisk;
        }

        public IMonitor MakeMonitor()
        {
            IMonitor monitor = new FastMonitor();
            return monitor;
        }
    }
}
