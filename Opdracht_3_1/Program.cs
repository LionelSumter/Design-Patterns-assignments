using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Opdracht_3_1.Models;
using Opdracht_3_1.Controllers;
using Opdracht_3_1.Views;
using System.Drawing;

namespace Opdracht_3_1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ITreinreis treinreis = new Treinreis();
            ITreinController controller = new TreinController(treinreis);
      
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Bepaal startlocatie van panels
            Control_Panel panel1 = new Control_Panel(controller);
            panel1.StartPosition = FormStartPosition.Manual;
            panel1.Location = new Point(100, 100);
            TreinDisplay panel2 = new TreinDisplay(treinreis);
            panel2.StartPosition = FormStartPosition.Manual;
            panel2.Location = new Point(450, 100);

            // Run applicatie 
            Application.Run(new MultiForm(panel1, panel2)); // Klasse MultiForm zorgt ervoor dat er meerdere schermen tegelijk geopent kunnen worden
        }
    }
}
