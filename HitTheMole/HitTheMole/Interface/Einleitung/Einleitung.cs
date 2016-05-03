using System;
using System.Drawing;
using System.Windows.Forms;

namespace HitTheMole
{
    public partial class Einleitung : Form
    {
        // Öffentliche Informationen
        public static string Info = "Einleitung";
        public static string Schwierigkeit = "/";
        public static int LöcherAnzahl = 0;
        public static int ZeitBisZumNächstenSpawn = 0;
        public static int GesamtZeit = 0;

        public Einleitung()
        {
            // Initialisere GUI       
            InitializeComponent();
            this.Text = Helper.InterfaceTitel;    
        }

        private void Einleitung_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Willkommen bei Hit the Mole!\nIch hoffe Dir gefällt das Spiel :).", "Willkommen!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
