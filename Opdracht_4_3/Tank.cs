using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_4_3
{
    class Tank : IAanvaller
    {
        Random generator = new Random();

        public void GebruikWapen()
        {
            int rndGetal = generator.Next(1, 10);
            Console.WriteLine("Tank veroorzaakt " + rndGetal + " schade");
        }

        public void KoppelBestuurder(string bestuurder)
        {
            Console.WriteLine(bestuurder + " bestuurt de tank");
        }

        public void RijNaarVoren()
        {
            int rndGetal = generator.Next(1, 10);
            Console.WriteLine("Tank beweegt " + rndGetal + " posities naar voren");
        }
    }
}
