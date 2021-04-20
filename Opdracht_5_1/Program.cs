using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_5_1
{
    class Program
    {
        // Static = lose van een klasse instantie
        static void Main(string[] args)
        {
            Logger Logger = Logger.GetInstance();
            MainSystem mainsysteem = new MainSystem();

            Logger.Log("main", "start                        ");

            mainsysteem.DoSomeMainWork();
            mainsysteem.sub.DoSomeWork();
            mainsysteem.sub.DoSomeMoreWork();

            Logger.Log("Main", "Finishing                    ");

            Console.ReadKey();
        }
    }
}
