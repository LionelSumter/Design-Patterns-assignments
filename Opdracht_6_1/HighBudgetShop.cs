using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_6_1
{
    class HighBudgetShop : ComputerShop
    {
        public override IProcessor MakeProcessor()
        {
            IProcessor processor = new FastProcessor();
            return processor;
        }

        public override IHardDisk MakeHardDisk()
        {
            IHardDisk harddisk = new FastHardDisk();
            return harddisk;
        }

        public override IMonitor MakeMonitor()
        {
            IMonitor monitor = new FastMonitor();
            return monitor;
        }

        
    }
}
