using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_6_2
{
    class SlowHardDisk : IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("Storing data very slowly...");
        }
    }
}
