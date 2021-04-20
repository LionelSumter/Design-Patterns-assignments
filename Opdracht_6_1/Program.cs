using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a shop where they assemble expensive computers
            Console.WriteLine("[shop creating expensive computers]");
            ComputerShop shop1 = new HighBudgetShop();
            shop1.AssembleMachine();

            Console.WriteLine();

            // create a shop where they assemble cheap computers
            Console.WriteLine("[shop creating cheap computers]");
            ComputerShop shop2 = new LowBudgetShop();
            shop2.AssembleMachine();

            Console.ReadKey();
        }
    }
}
