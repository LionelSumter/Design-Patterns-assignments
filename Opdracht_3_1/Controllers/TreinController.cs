using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opdracht_3_1.Models;

namespace Opdracht_3_1.Controllers
{
    class TreinController : ITreinController
    {
        private ITreinreis treinreis;

        // Constructor
        public TreinController(ITreinreis treinreis)
        {
            this.treinreis = treinreis;
        }

        ITreinreis ITreinController.treinreis { get { return treinreis; } } // nee


        // 1-op-1 acties aan controlPanel
        public void VolgendStation()
        {
            treinreis.VolgendStation();             
        }
    }
}
