using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Opdracht_3_extra.Models; // Geen input van user, dus alleen models om output the showen (geen controllers)

namespace Opdracht_3_extra.Views
{
    public partial class VolumeDisplay : Form, IVolumeObserver
    {
        IMP3Player player;

        public VolumeDisplay(IMP3Player player)
        {
            InitializeComponent();

            this.player = player;
            this.player.AddObserver(this);
        }

        private void VolumeDisplay_Load(object sender, EventArgs e)
        {
            // initialiseer progressbar
            pb_volume.Minimum = 0;
            pb_volume.Maximum = 40;
            pb_volume.Value = player.VolumeLevel;
            lbl_volume.Text = player.VolumeLevel.ToString();
        }

        public void Update(int volumeLevel)
        {
            pb_volume.Value = volumeLevel;
            lbl_volume.Text = volumeLevel.ToString();
        }
    }
}
