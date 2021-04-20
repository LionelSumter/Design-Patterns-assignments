using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Opdracht_3_1.Controllers;
using Opdracht_3_1.Views;
using Opdracht_3_1.Models;

namespace Opdracht_3_1
{
    public partial class Control_Panel : Form
    {
        private ITreinController controller;
        

        public Control_Panel(ITreinController controller)
        {
            InitializeComponent();

            this.controller = controller;
        }

        private void btn_Volgend_Station_Click(object sender, EventArgs e)
        {
            controller.VolgendStation();
        }

        private void brn_Nieuwe_Display_Click(object sender, EventArgs e)
        {
            // Open nieuwe display
            //ITreinreis treinreis = new Treinreis();
                       
            TreinDisplay display = new TreinDisplay(controller.treinreis); 
            display.Show();
            display.Location = new Point(450, 300);
        }

        private void btn_LaatsteStation_Click(object sender, EventArgs e)
        {
            // Zorg dat de list omgekeerd wordt
        }
    }
}
