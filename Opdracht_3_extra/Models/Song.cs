using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3_extra.Models
{
    public class Song
    {
        public string titel;
        public string artiest;

        // Constructor
        public Song(string titel, string artiest)
        {
            this.titel = titel;
            this.artiest = artiest;
        }        
    }
}
