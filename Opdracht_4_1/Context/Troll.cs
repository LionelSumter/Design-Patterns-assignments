﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opdracht_4_1.Strategy;
using Opdracht_4_1.Concrete_Strategy;

namespace Opdracht_4_1.Context
{
    class Troll : Character
    {
        public Troll()
        {
            Weapon = new AxeBehaviour();
        }
    }
}
