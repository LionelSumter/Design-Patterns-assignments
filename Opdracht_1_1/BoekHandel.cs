using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1_1
{
    class BoekHandel
    {
        private List<BoekHandelItem> boekhandelitemList;      
        
        public BoekHandel()
        {
            boekhandelitemList = new List<BoekHandelItem>();
        }

        public void VoegToe(BoekHandelItem boekhandelitem)
        {
            boekhandelitemList.Add(boekhandelitem);
        }

        public void PrintOverzicht()
        {
            foreach(BoekHandelItem boekhandelitem in boekhandelitemList)
            {
                Console.WriteLine(boekhandelitem.ToString());
            }                       
        }
    }
}
