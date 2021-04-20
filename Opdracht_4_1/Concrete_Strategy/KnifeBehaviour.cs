using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opdracht_4_1.Strategy;

namespace Opdracht_4_1.Concrete_Strategy
{
    class KnifeBehaviour : IWeaponBehaviour
    {
        public string UseWeapon()
        {
            string weapon = "Cutting with a knife";
            return weapon;
        }
    }
}
