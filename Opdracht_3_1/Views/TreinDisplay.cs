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
using Opdracht_3_1.Models;

namespace Opdracht_3_1.Views
{
    public partial class TreinDisplay : Form, IStationObserver
    {
        ITreinreis treinreis;

        // Constructor
        public TreinDisplay(ITreinreis treinreis)
        {
            InitializeComponent();

            this.treinreis = treinreis;
            

            // Display meldt zich aan als StationObserver
            this.treinreis.AddStationObserver(this);
        }

        public void Update(Station huidigStation)
        { 
            // Update station-informatie
            lbl_huidig_station.Text = huidigStation._Station;
            lbl_spoor.Text = huidigStation.AankomstSpoor;
        }

        private void TreinDisplay_Load(object sender, EventArgs e)
        {
            // nee
        }
    }
}
