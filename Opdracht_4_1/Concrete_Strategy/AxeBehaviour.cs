using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opdracht_4_1.Strategy;

namespace Opdracht_4_1.Concrete_Strategy
{
    class AxeBehaviour : IWeaponBehaviour
    {
        public string UseWeapon()
        {
            string weapon = "Chopping with an axe";
            return weapon;
        }
    }
}
