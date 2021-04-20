using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1_3
{
    class Potlood : IPotlood
    {
        private int maxTeSchrijven; // aantal te schrijven karakters v/e geslepen potlood
        private int geschrevenKarakters; // aantal reeds geschreven karakters

        public Potlood(int maxTeSchrijven)
        {
            this.maxTeSchrijven = maxTeSchrijven;
            geschrevenKarakters = 0;
        }

        public bool IsScherp
        {
            get { return (geschrevenKarakters < maxTeSchrijven); }
        }

        public void Schrijf(string boodschap)
        {
            foreach (char karakter in boodschap)
            // for(geschrevenKarakters = 0; geschrevenKarakters < boodschap.Length; geschrevenKarakters++)
            {
                if (IsScherp)
                {
                    // Console.Write(boodschap[geschrevenKarakters]); // [...] = positie binnen list
                    Console.Write(karakter); // [...] = positie binnen list
                    geschrevenKarakters++;
                }
                else
                {
                    Console.Write("#");
                }
            }
        }

        public void NaGeslepen()
        {
            geschrevenKarakters = 0;
        }
    }
}
