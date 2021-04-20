using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_6_2
{
    class SlowProcessor : IProcessor
    {
        public void PerformOperation()
        {
            Console.WriteLine("Performing operation not so quickly...");
        }
    }
}
