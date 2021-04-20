using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2_3
{
    class MP3Player : ISubject
    {
        // Properties
        public Nummer HuidigNummer { get; private set; }

        public List<Nummer> nummers = new List<Nummer>();
        Random rndNummer = new Random();

        private List<IObserver> nummerObservers = new List<IObserver>();

        public MP3Player()
        {
            Nummer nummer1 = new Nummer("Pink Floyd", "Wish You Were Here", "<03:12>");
            Nummer nummer2 = new Nummer("Bruno Mars", "Billionaire", "<03:33>");
            Nummer nummer3 = new Nummer("Led Zeppelin", "Dazed and Confused", "<04:00>");
            nummers.Add(nummer1);
            nummers.Add(nummer2);
            nummers.Add(nummer3);
        }

        public void NummerGewijzigd()
        {
            HuidigNummer = nummers[rndNummer.Next(0, nummers.Count)];

            NotifyObservers();
            Console.WriteLine();
        }

        public void AddObserver(IObserver observer)
        {
            nummerObservers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            nummerObservers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in this.nummerObservers)
            {
                observer.Update(HuidigNummer);
            }
        }
    }
}
