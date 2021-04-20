using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1_1
{
    class Weekblad : BoekHandelItem
    {
        public string UitGifteDag { get; set; }

        public Weekblad(string UitGifteDag, string Titel, float Prijs, int Aantal) : base(Titel, Prijs, Aantal)
        {
            this.UitGifteDag = UitGifteDag;
        }

        public override string ToString()
        {
            return String.Format("UitgifteDag: {0} \nTitel: {1} \nPrijs: {2} \nAantal: {3} \n", UitGifteDag, Titel, Prijs, Aantal);
        }
    }
}
