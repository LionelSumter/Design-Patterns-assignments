using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_5_2.Statussen
{
    class CorrectePinStatus : IPinAutomaatStatus
    {
        private PinAutomaat automaat;

        public CorrectePinStatus(PinAutomaat automaat)
        {
            this.automaat = automaat;
        }

        public void GeldOpvragen(double bedrag)
        {
            Console.WriteLine(bedrag + " uit het automaat gehaald.");
            automaat.BedragInAutomaat = automaat.BedragInAutomaat - bedrag; 
            KaartUitwerpen();
            // ...
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
            Console.WriteLine("Uw pincode is al ingevoerd.");
        }
    }
}
