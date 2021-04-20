using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opdracht_4_1.Strategy;

namespace Opdracht_4_1.Concrete_Strategy
{
    class SwordBehaviour : IWeaponBehaviour
    {
        public string UseWeapon()
        {
            string weapon = "Swinging a sword";
            return weapon; 
        }
    }
}
