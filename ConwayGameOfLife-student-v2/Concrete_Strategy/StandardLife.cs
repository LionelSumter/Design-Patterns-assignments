using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opdracht_4_2.Strategy;
using Opdracht_4_2.Context;

namespace Opdracht_4_2.Concrete_Strategy
{
    public class StandardLife : ILifeBehaviour
    {
        public bool CellShouldLive(bool livingCell, int neighbourCount)
        {
            // with 3 neighbour cell will live
            if (neighbourCount == 3)
                return true;

            // live cell with 2 neighbours stays alive
            if (livingCell && neighbourCount == 2)
                return true;

            // dead cell
            return false;
        }
    }
}
