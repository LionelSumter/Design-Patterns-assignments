using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_5_2.Statussen
{
    class KaartAanwezigStatus : IPinAutomaatStatus
    {
        private PinAutomaat automaat;

        public KaartAanwezigStatus(PinAutomaat automaat)
        {
            this.automaat = automaat;
        }

        public void GeldOpvragen(double bedrag)
        {
            Console.WriteLine("Voer eerst uw pincode in.");
        }

        public void KaartInvoeren()
        {
            Console.WriteLine("Uw kaart is al aanwezig.");
        }

        public void KaartUitwerpen()
        {
            Console.WriteLine("Uw kaart is uitgeworpen.");
            automaat.ZetAutomaatStatus(automaat.geefGeenKaartAanwezigStatus());
        }

        public void PincodeInvoeren(int pincode)
        {
            Console.WriteLine("U heeft de correcte pincode ingevoerd");
            automaat.ZetAutomaatStatus(automaat.geefCorrectePinStatus());
        }
    }
}
