using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IVliegbaar s = new Superman();
            IVliegbaar v = new Vliegtuig();
            MaakVlucht(s);
            MaakVlucht(v);
            Console.ReadLine();
        }

        public static void MaakVlucht(IVliegbaar vliegbaar)
        {
            vliegbaar.Opstijgen();
            vliegbaar.Vliegen();
            vliegbaar.Landen();
        }
    }
}
