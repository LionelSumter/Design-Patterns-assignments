using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_5_2.Statussen
{
    class GeenKaartStatus : IPinAutomaatStatus
    {
        private PinAutomaat automaat;

        public GeenKaartStatus(PinAutomaat automaat)
        {
            this.automaat = automaat;
        }

        public void GeldOpvragen(double bedrag)
        {
            Console.WriteLine("U moet eerst een kaart invoeren om geld op te kunnen vragen.");
        }

        public void KaartInvoeren()
        {
            if (automaat.BedragInAutomaat <= 0)
            {
                Console.WriteLine("Geen geld aanwezig in automaat.");
                KaartUitwerpen();
            }
            else
            {
                Console.WriteLine("Geef uw pincode a.u.b. (kaart ingevoerd)");
                automaat.ZetAutomaatStatus(automaat.GeefKaartAanwezigStatus());
            }
        }

        public void KaartUitwerpen()
        {
            if (automaat.BedragInAutomaat <= 0)
            {
                Console.WriteLine("Uw kaart is uitgeworpen");
                automaat.ZetAutomaatStatus(automaat.geefGeenGeldStatus());
            }
            else Console.WriteLine("U heeft geen kaart ingevoerd.");
        }

        public void PincodeInvoeren(int pincode)
        {
            Console.WriteLine("U moet eerst een kaart invoeren om uw pincode in te kunnen voeren.");
        }
    }
}
