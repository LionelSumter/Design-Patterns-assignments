using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Opdracht_3_extra.Views;
using Opdracht_3_extra.Models;
using Opdracht_3_extra.Controllers;

namespace Opdracht_3_extra
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IMP3Player player = new MP3Player();
            IMP3Controller controller = new MP3Controller(player);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MultiFormContext(new MP3Display(player, controller), new VolumeDisplay(player)));
        }
    }
}
