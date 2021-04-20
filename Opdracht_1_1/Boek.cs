using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1_1
{
    class Boek : BoekHandelItem
    {
        public string Auteur { get; set; }

        public Boek(string Auteur, string Titel, float Prijs, int Aantal) : base(Titel, Prijs, Aantal)
        {
            this.Auteur = Auteur;
        }

        public override string ToString()
        {
            return String.Format("Auteur: {0} \nTitel: {1} \nPrijs: {2} \n Aantal: {3}\n", Auteur, Titel, Prijs, Aantal);
        }
    }
}
