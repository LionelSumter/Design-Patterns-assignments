using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1_2
{
    class Superman : IVliegbaar
    {
        public void Opstijgen()
        {
            Console.WriteLine("Superman aan het opstijgen...");
        }

        public void Vliegen()
        {
            for(int x = 0; x < 3; x++)
            {
                Console.WriteLine("Superman aan het vliegen...");
            }            
        }

        public void Landen()
        {
            Console.WriteLine("Superman aan het landen...\n");
        }
    }
}
