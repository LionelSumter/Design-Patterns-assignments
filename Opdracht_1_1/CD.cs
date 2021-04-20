using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1_1
{
    class CD : BoekHandelItem
    {
        public string Artiest { get; set; }

        public CD(string Artiest, string Titel, float Prijs, int Aantal) : base(Titel, Prijs, Aantal)
        {
            this.Artiest = Artiest;
        }

        public override string ToString()
        {
            return String.Format("Artiest: {0} \nTitel: {1} \nPrijs: {2} \nAantal: {3} \n", Artiest, Titel, Prijs, Aantal);
        }
    }
}
