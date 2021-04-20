using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_6_1
{
    class SlowMonitor : IMonitor
    {
        public void Display()
        {
            Console.WriteLine("Displaying stuff very poor...");
        }
    }
}
