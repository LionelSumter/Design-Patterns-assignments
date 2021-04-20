using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_6_2
{
    class FastProcessor : IProcessor
    {
        public void PerformOperation()
        {
            Console.WriteLine("Performing operation very quickly...");
        }
    }
}
