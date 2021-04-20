using System;
using System.Drawing;
using System.Windows.Forms;
using Opdracht_4_2.Concrete_Strategy;
using Opdracht_4_2.Strategy;
using Opdracht_4_2.Context;

namespace Opdracht_4_2.Context
{
    public partial class Form1 : Form
    {
        private ConwayGameOfLife game;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // create a game
            game = new ConwayGameOfLife();
            cb_ChangeLife.Appearance = Appearance.Button;

            // bij start toont hij standardlife
            game.Behaviour = new StandardLife();     
            

            // start the timer
            timer1.Enabled = true;

            this.DoubleBuffered = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            game.Draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            game.Evolve();
            this.Refresh();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.game.Reset();
        }

        private void cb_ChangeLife_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_ChangeLife.Checked)
            {
                game.Behaviour = new HighLife();
            }

            else
            {
                game.Behaviour = new StandardLife();                
            }
        }
    }
}