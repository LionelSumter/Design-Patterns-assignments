using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opdracht_4_2.Strategy;

namespace Opdracht_4_2.Concrete_Strategy
{
    public class HighLife : ILifeBehaviour
    {
        public bool CellShouldLive(bool livingCell, int neighbourCount)
        {
            // with 3 OR 6 neighbour cell will live
            if (neighbourCount == 3 || neighbourCount == 2 || neighbourCount == 6 || neighbourCount == 4 || neighbourCount == 5)
                return true;

            // live cell with 2 neighbours stays alive
            if (livingCell && neighbourCount == 2)
                return true;

            // dead cell
            return false;
        }
    }
}
