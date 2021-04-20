using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a shop where they assemble expensive computers
            Console.WriteLine("[shop creating expensive computers]");
            IMachineFactory factory1 = new HighBudgetMachine();
            ComputerShop shop1 = new ComputerShop(factory1);
            shop1.AssembleMachine();

            Console.WriteLine();

            // create a shop where they assemble cheap computers
            Console.WriteLine("[shop creating cheap computers]");
            IMachineFactory factory2 = new LowBudgetMachine();
            ComputerShop shop2 = new ComputerShop(factory2);
            shop2.AssembleMachine();

            Console.ReadKey();
        }
    }
}
