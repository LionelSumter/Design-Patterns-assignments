using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1_1
{
    class BoekHandelItem
    {
        public string Titel { get; set; }
        public float Prijs { get; set; }
        public int Aantal { get; set; }

        public BoekHandelItem(string Titel, float Prijs, int Aantal)
        {
            this.Titel = Titel;
            this.Prijs = Prijs;
            this.Aantal = Aantal;
        }

    }
}
