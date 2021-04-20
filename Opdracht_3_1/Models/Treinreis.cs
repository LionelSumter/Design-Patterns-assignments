using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3_1.Models
{
    class Treinreis : ITreinreis
    {
        // Members
        private List<Station> stations;
        private int huidigStation;

        // Lists observers
        private List<IStationObserver> stationsObserver;  
                
        // Constructor
        public Treinreis()
        {
            // Vul lijst stations
            stations = new List<Station>();
            stations.Add(new Station("Amsterdam Centraal", "Spoor 7a", new DateTime(2017, 12, 01, 15, 35, 00), new DateTime(2017, 12, 01, 15, 36, 00)));
            stations.Add(new Station("Amsterdam Sloterdijk", "Spoor 2", new DateTime(2017, 12, 01, 12, 57, 00), new DateTime(2017, 12, 01, 12, 58, 00)));
            stations.Add(new Station("Hoorn", "Spoor 1", new DateTime(2017, 11, 21, 16, 13, 00), new DateTime(2017, 11, 21, 16, 14, 00)));
            stations.Add(new Station("Hoorn Kersenboogerd", "Spoor 2", new DateTime(2017, 11, 21, 16, 25, 00), new DateTime(2017, 11, 21, 16, 26, 00)));
            stations.Add(new Station("Hoogkarspel", "Spoor 1", new DateTime(2017, 11, 21, 16, 35, 00), new DateTime(2017, 11, 21, 16, 36, 00)));
            stations.Add(new Station("Bovenkarspel-Grootebroek", "Spoor 1", new DateTime(2017, 11, 21, 16, 40, 00), new DateTime(2017, 11, 21, 16, 41, 00)));

            // Maak observer list
            stationsObserver = new List<IStationObserver>();

            // Begin bij eerste station
            huidigStation = 0;
        }

        // Observers
        public void AddStationObserver(IStationObserver observer)
        {
            stationsObserver.Add(observer);
            observer.Update(stations[huidigStation]);
        }

        public void RemoveStationObserver(IStationObserver observer)
        {
            stationsObserver.Remove(observer);
        }

        private void NotifyStationObserver()
        {
            foreach (IStationObserver observer in this.stationsObserver)
            {
                observer.Update(stations[huidigStation]);
            }
        }

        // Methoden
        public void VolgendStation()
        {
            huidigStation++; // Error bij laatste station

            NotifyStationObserver();
        }
    }
}
