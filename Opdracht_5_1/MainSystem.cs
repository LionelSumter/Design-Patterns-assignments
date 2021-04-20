using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_5_1
{
    class MainSystem
    {
        Logger Logger;
        public SubSystem sub; 

        public MainSystem()
        {
            sub = new SubSystem();
            Logger = Logger.GetInstance();
        }

        public void DoSomeMainWork()
        {
            Logger.Log("main", "doing some main work         ");
        }
    }
}
