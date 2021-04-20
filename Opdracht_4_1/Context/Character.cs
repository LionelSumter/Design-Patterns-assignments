using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opdracht_4_1.Strategy;
using Opdracht_4_1.Concrete_Strategy;

namespace Opdracht_4_1.Context
{
    abstract class Character
    {
        private IWeaponBehaviour weapon;

        // Properties (publieke manier om een value te zetten)
        public IWeaponBehaviour Weapon
        {
            get { return weapon; }
            set { weapon = value; } // Hierdoor is .ToString() in program en concrete strategy niet nodig
        }

        // Constructor
        public Character()
        {
        //    this.weapon = Weapon;
        }

        // Methode Fight zorgt voor een regel tekst
        public void Fight()
        {
            Console.WriteLine(weapon.UseWeapon());            
        }
    }
}
