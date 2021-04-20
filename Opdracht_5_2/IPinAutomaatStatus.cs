using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_5_2
{
    interface IPinAutomaatStatus
    {
        void KaartInvoeren();
        void PincodeInvoeren(int pincode);
        void GeldOpvragen(double bedrag);
        void KaartUitwerpen();
    }
}
