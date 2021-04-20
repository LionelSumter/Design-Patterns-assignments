using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1_2
{
    class Vliegtuig : IVliegbaar
    {
        public void Opstijgen()
        {
            Console.WriteLine("Vliegtuig aan het opstijgen...");
        }

        public void Vliegen()
        {
            for (int x = 0; x < 3; x++)
            {
                Console.WriteLine("Vliegtuig aan het vliegen...");
            }

        }

        public void Landen()
        {
            Console.WriteLine("Vliegtuig aan het landen...\n");
        }
    }
}
