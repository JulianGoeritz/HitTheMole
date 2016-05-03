using System;
using System.Drawing;
using System.Threading;
using System.IO;
using System.Windows.Forms;
using System.Reflection;

namespace HitTheMole
{
    public partial class Loader : Form
    {
        private Thread LadeThread { get; set; }

        /// <summary>
        /// Ladekonstruktor
        /// </summary>
        public Loader()
        {
            // Initialisere GUI
            InitializeComponent();
            this.statusTxt.Parent = this;

            // Setze Hintergrundfarben         R    G    B
            Color DunkelGrau = Color.FromArgb(105, 105, 105);
            this.BackColor = DunkelGrau;
            this.TransparencyKey = DunkelGrau;

            // Starte Thread
            statusTxt.Text = "Starte Ladevorgang..";
            new Thread(new ThreadStart(Laden)).Start();
        }

        /// <summary>
        /// Ladevorgang
        /// </summary>
        private void Laden()
        {
            try
            {
                // Dateien, z.B. die Konfigurationsdatei nach Existenz prüfen
                SetzeStatusText("Prüfe Dateien..");
                UpdateProgressBar(50);
                if (!Helper.ExistierenBenötigteDateien)
                {
                    MessageBox.Show("Konnte wichtige Datei(en) nicht finden!", "Fataler Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }

                // Mit Datenbank verbinden
                Thread.Sleep(850);
                SetzeStatusText("Verbinde mit Datenbank..");
                UpdateProgressBar(40);
                Thread.Sleep(1350);
                if (!Datenbank.Verbinden())
                {
                    MessageBox.Show("Datenbankverbindung fehlgeschlagen.", "Fataler Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }

                // Spiel starten
                Thread.Sleep(850);
                SetzeStatusText("Starte Menü..");
                UpdateProgressBar(10);
                Thread.Sleep(500);
                Helper.VersteckeForm(this);
                SpielMenü menü = new SpielMenü();
                menü.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fataler Fehler während des Ladevorgangs: " + ex, "Fataler Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Setzt den Text des Status Labels
        /// </summary>
        public void SetzeStatusText(string text)
        {
            if (this.IsHandleCreated)
            {
                this.Invoke(new Action(() =>
                {
                    statusTxt.Text = text;
                }));
            }
        }

        /// <summary>
        /// Updatet den Fortschritt der Progressbar
        /// </summary>
        public void UpdateProgressBar(int prozent)
        {
            if (this.IsHandleCreated)
            {
                this.Invoke(new Action(() =>
                {
                progress.Step = prozent;
                progress.PerformStep();
                }));
            }
        }
    }
}
