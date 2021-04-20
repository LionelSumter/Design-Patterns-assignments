using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_6_2
{
    class ComputerShop
    {
        private IMachineFactory factory;

        public ComputerShop(IMachineFactory factory)
        {
            this.factory = factory;
        }

        public void AssembleMachine()
        {
            factory.MakeProcessor().PerformOperation();
            factory.MakeHardDisk().StoreData();
            factory.MakeMonitor().Display();
        }
    }
}
