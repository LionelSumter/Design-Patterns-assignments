using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2_3
{
    class SimpleMP3Display : IObserver
    {
        private ISubject nummer;
        
        public SimpleMP3Display(ISubject nummer)
        {
            this.nummer = nummer;
            nummer.AddObserver(this);            
        }

        public void Update(Nummer nummer)
        {
            Console.WriteLine("Simple display: " + nummer.artiest + " - '" + nummer.titelNummer + "'");
        }
    }
}
