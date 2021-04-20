using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3_1.Models
{
    public class Station
    {
        public string _Station { get; set; }
        public string AankomstSpoor { get; set; }
        public DateTime AankomstTijd { get; set; }
        public DateTime VertrekTijd { get; set; }

        public Station(string station, string aankomstSpoor, DateTime aankomstTijd, DateTime vertrekTijd)
        {
            _Station = station;
            AankomstSpoor = aankomstSpoor;
            AankomstTijd = aankomstTijd;
            VertrekTijd = vertrekTijd;
        }
    }
}
