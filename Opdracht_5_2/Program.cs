using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            PinAutomaat pinAutomaat = new PinAutomaat();

            pinAutomaat.KaartInvoeren();
            pinAutomaat.KaartUitwerpen();
            pinAutomaat.KaartInvoeren();
            pinAutomaat.PincodeInvoeren(1234);
            pinAutomaat.GeldOpvragen(2000);
            pinAutomaat.KaartInvoeren();
            pinAutomaat.PincodeInvoeren(1234);

            Console.ReadKey();
        }
    }
}
