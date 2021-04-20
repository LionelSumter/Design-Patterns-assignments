using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_6_1
{
    abstract class ComputerShop
    {
        public void AssembleMachine()
        {
            MakeProcessor().PerformOperation();
            MakeHardDisk().StoreData();
            MakeMonitor().Display();
        }

        // Factory method: Maak onderdelen aan met virtuele/abstracte methoden:
        public abstract IProcessor MakeProcessor();
        public abstract IHardDisk MakeHardDisk();
        public abstract IMonitor MakeMonitor();
    }
}
