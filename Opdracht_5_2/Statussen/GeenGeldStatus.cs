using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_5_2.Statussen
{
    class GeenGeldStatus : IPinAutomaatStatus
    {
        private PinAutomaat automaat;

        public GeenGeldStatus(PinAutomaat automaat)
        {
            this.automaat = automaat;
        }

        public void KaartInvoeren()
        {
            Console.WriteLine("Geen geld aanwezig in automaat");
            KaartUitwerpen();
        }

        public void PincodeInvoeren(int pincode)
        {
            Console.WriteLine("Geen geld aanwezig in automaat");
        }

        public void GeldOpvragen(double bedrag)
        {
            Console.WriteLine("Geen geld aanwezig in automaat");

        }

        public void KaartUitwerpen()
        {
            Console.WriteLine("Uw kaart is uitgeworpen");

        }
    }
}
