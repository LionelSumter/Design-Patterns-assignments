using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_6_1
{
    class LowBudgetShop : ComputerShop
    {
        public override IProcessor MakeProcessor()
        {
            IProcessor processor = new SlowProcessor();
            return processor;
        }

        public override IHardDisk MakeHardDisk()
        {
            IHardDisk harddisk = new SlowHardDisk();
            return harddisk;
        }

        public override IMonitor MakeMonitor()
        {
            IMonitor monitor = new SlowMonitor();
            return monitor;
        }        
    }
}
