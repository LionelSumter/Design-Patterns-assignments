using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_5_1
{
    class SubSystem
    {
        Logger Logger;

        public SubSystem()
        {
            Logger = Logger.GetInstance();
        }

        public void DoSomeWork()
        {
            Logger.Log("subsysteem", "doing some work        ");   
        }

        public void DoSomeMoreWork()
        {
            Logger.Log("subsysteem", "doing some more work   ");
        }
    }
}
