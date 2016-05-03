using System;
using System.Drawing;
using System.Windows.Forms;

namespace HitTheMole
{
    public partial class SpielMenü : Form
    {
        public SpielMenü()
        {
            // Intialisere GUI
            InitializeComponent();           
        }

        /// <summary>
        /// Starten des Spiels durch Klicken des "Starten" Buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startenBtn_Click(object sender, EventArgs e)
        {
            Helper.VersteckeForm(this);
            SpielAuswahl s = new SpielAuswahl(Konfiguration.SpielerName, Konfiguration.Musik, Konfiguration.SpeichereHighscores);
            s.ShowDialog();
        }

        /// <summary>
        /// Beenden der Anwendung durch das Klicken des "Beenden" Button
        /// </summary>
        private void beendenBtn_Click(object sender, EventArgs e)
        {
            Beende();
        }

        /// <summary>
        /// Beenden der Anwendung durch das Klicken des roten X
        /// </summary>
        private void SpielMenü_FormClosing(object sender, FormClosingEventArgs e)
        {
            Beende();
        }

        /// <summary>
        /// Schließt das Programm
        /// </summary>
        public void Beende()
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Zeigt das "Über" Menü an
        /// </summary>
        private void überToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Über über = new Über();
            über.ShowDialog();
        }

        /// <summary>
        /// Zeigt das "Highscores" Menü an
        /// </summary>
        private void highscoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Highscores highscores = new Highscores();
            highscores.ShowDialog();
        }

        /// <summary>
        /// Zeigt das "Einstellungen" Menü an
        /// </summary>
        private void einstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Einstellungen einstellungen = new Einstellungen();
            einstellungen.ShowDialog();
        }
    }
}
