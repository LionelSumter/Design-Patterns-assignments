using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_6_2
{
    class FastHardDisk : IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("Storing data very quickly...");
        }
    }
}
