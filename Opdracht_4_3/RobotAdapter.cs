using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_4_3
{
    class RobotAdapter : IAanvaller
    {
        private Robot robot;

        public RobotAdapter(Robot robot)
        {
            this.robot = robot;
        }

        public void GebruikWapen()
        {
            robot.BeukMetHanden();
        }

        public void KoppelBestuurder(string bestuurder)
        {
            robot.BeweegViaPersoon(bestuurder); 
        }

        public void RijNaarVoren()
        {
            robot.LoopNaarVoren();
        }

    }
}
