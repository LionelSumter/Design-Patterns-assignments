using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            IAanvaller panzerTank = new Tank();
            Robot evilRobot = new Robot();

            IAanvaller robotAdapter = new RobotAdapter(evilRobot);

            Console.WriteLine("[De gemene robot]");
            evilRobot.BeweegViaPersoon("Paul");
            evilRobot.LoopNaarVoren();
            evilRobot.BeukMetHanden();
            Console.WriteLine();

            Console.WriteLine("[De Pantzer Tank]");
            panzerTank.KoppelBestuurder("Frank");
            panzerTank.RijNaarVoren();
            panzerTank.GebruikWapen();
            Console.WriteLine();

            Console.WriteLine("[De robot met Adapter]");
            robotAdapter.KoppelBestuurder("Mark");
            robotAdapter.RijNaarVoren();
            robotAdapter.GebruikWapen();
            Console.ReadKey();
        }
    }
}
