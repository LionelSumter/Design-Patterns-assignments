using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_4_3
{
    class Robot
    {
        Random generator = new Random();

        public void BeukMetHanden()
        {
            int rndGetal = generator.Next(1, 10);
            Console.WriteLine("Robot veroorzaakt " + rndGetal + " schade met zijn handen");
        }

        public void BeweegViaPersoon(string bestuurder)
        {
            Console.WriteLine("Robot beweegt via " + bestuurder);
        }

        public void LoopNaarVoren()
        {
            int rndGetal = generator.Next(1, 10);
            Console.WriteLine("Robot loopt " + rndGetal + " posities naar voren");
        }
    }
}
