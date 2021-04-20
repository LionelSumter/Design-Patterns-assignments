using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            BoekHandel boekhandel = new BoekHandel();
            boekhandel.VoegToe(new CD("Gerwin", "Gerwin zingt de sterren van de hemel", 12, 10000000));
            boekhandel.VoegToe(new Weekblad("28 februari 1997", "ICT, daar kan je wat mee", 20.50f, 0));
            boekhandel.VoegToe(new Boek("Sinterklaas", "Het Grote Boek van Sinterklaas", 250, 1));

            boekhandel.PrintOverzicht();

            Console.ReadKey();
        }
    }
}
