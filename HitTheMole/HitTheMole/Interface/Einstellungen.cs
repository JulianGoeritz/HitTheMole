using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HitTheMole
{
    public partial class Einstellungen : Form
    {
        public Einstellungen()
        {
            InitializeComponent();
            this.Text = Helper.InterfaceTitel;
            this.dotNetVersion.Text = Helper.DotNetVersion;
            this.spielVer.Text = Helper.HitTheMoleSpielVersion;

            // Lese Konfigurationswerte
            this.nickName.Text = Konfiguration.SpielerName;
            this.musikAnAus.Checked = Konfiguration.Musik;
            this.highscoresJaNein.Checked = Konfiguration.SpeichereHighscores;
        }

        private void Einstellungen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Konfiguration.Speichern(this.nickName.Text, musikAnAus.Checked, highscoresJaNein.Checked);
        }
    }
}
