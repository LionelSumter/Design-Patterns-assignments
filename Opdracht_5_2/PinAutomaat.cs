using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opdracht_5_2.Statussen;

namespace Opdracht_5_2
{
    class PinAutomaat
    {
        private double bedragInAutomaat;
        private IPinAutomaatStatus correctePinIngevoerd;
        private IPinAutomaatStatus geenGeldAanwezig;
        private IPinAutomaatStatus kaartAanwezig;
        private IPinAutomaatStatus kaartNietAanwezig;

        private IPinAutomaatStatus automaatStatus;
        public double BedragInAutomaat { get; set; }

        public PinAutomaat()
        {
            correctePinIngevoerd = new CorrectePinStatus(this); 
            geenGeldAanwezig = new GeenGeldStatus(this);
            kaartAanwezig = new KaartAanwezigStatus(this);
            kaartNietAanwezig = new GeenKaartStatus(this);

            this.bedragInAutomaat = BedragInAutomaat;

            // Zet het bedrag in het automaat
            ZetBedragInAutomaat();

            // Zet status standaard op kaart-niet-aanwezig
            automaatStatus = kaartNietAanwezig;
        }

        public void KaartInvoeren()
        {
            automaatStatus.KaartInvoeren();
        }

        public void PincodeInvoeren(int pincode) 
        {
            automaatStatus.PincodeInvoeren(pincode);
        }

        public void GeldOpvragen(double bedrag)
        {
            automaatStatus.GeldOpvragen(bedrag);
        }

        public void KaartUitwerpen()
        {
            automaatStatus.KaartUitwerpen();
        }

        public void ZetAutomaatStatus(IPinAutomaatStatus nieuweStatus)
        {
            automaatStatus = nieuweStatus;
        }

        public IPinAutomaatStatus GeefKaartAanwezigStatus()
        {
            Console.WriteLine();
            return kaartAanwezig;
        }

        public IPinAutomaatStatus geefGeenKaartAanwezigStatus()
        {
            Console.WriteLine();
            return kaartNietAanwezig;
        }

        public IPinAutomaatStatus geefCorrectePinStatus()
        {
            Console.WriteLine();
            return correctePinIngevoerd;
        }

        public IPinAutomaatStatus geefGeenGeldStatus()
        {
            Console.WriteLine();
            return geenGeldAanwezig;
        }

        public void ZetBedragInAutomaat()
        {
            BedragInAutomaat = 2000;
        }
    }
}
