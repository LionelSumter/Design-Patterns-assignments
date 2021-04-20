using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2_3
{
    public class Nummer
    {
        public string artiest { get; set; }
        public string titelNummer { get; set; }
        public string playTime { get; set; }

        public Nummer(string artiest, string titelNummer, string playTime)
        {
            this.artiest = artiest;
            this.titelNummer = titelNummer;
            this.playTime = playTime;
        }
    }
}
