using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opdracht_4_1.Concrete_Strategy;

namespace Opdracht_4_1.Context
{
    class Queen : Character
    {
        public Queen()
        {
            Weapon = new KnifeBehaviour();
        }
    }
}
