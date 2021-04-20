using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1_3
{
    interface IPotlood
    {
        bool IsScherp { get; } // bepaalt of het potlood nog kan schrijven
        void Schrijf(string boodschap); // schrijft een bepaald aantal karakters vd boodschap
        void NaGeslepen(); // bevat code die het potlood weer "nieuw" maakt
    }
}
