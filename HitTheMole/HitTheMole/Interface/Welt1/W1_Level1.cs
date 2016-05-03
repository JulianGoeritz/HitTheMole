using System;
using System.Drawing;
using System.Windows.Forms;

namespace HitTheMole
{
    public partial class W1_Level1 : Form
    {
        // Ein Zufallsgenerator für die jeweiligen Löcher
        private Random r = new Random();

        // Variable, welche die Punkte hält
        private int Punkte = 0;

        // Variable, welche hält, ob der Maulwurf getroffen wurde, oder eben nicht
        private bool DarfTreffen = false;

        // Timer für die Spiel-Logik
        private Timer RestZeit = new Timer();
        private Timer MoleSpawner = new Timer();
        private Timer SpamCheck = new Timer();
        private Timer AnimiereOben = new Timer();
        private Timer AnimiereUnten = new Timer();

        // Koordinaten für einzelne Löcher
        private int[] Loch1 = { 69, 194 };
        private int[] Loch2 = { 270, 194 };
        private int[] Loch3 = { 466, 194 };

        // Öffentliche Informationen
        public static string Info = "Welt1 | Level1";
        public static string Schwierigkeit = "Sehr leicht";
        public static int LöcherAnzahl = 3;
        public static int ZeitBisZumNächstenSpawn = 1500; // 1,5 sek
        public static int GesamtZeit = 60; // 60 sek.

        public W1_Level1()
        {
            // Initialisere GUI       
            InitializeComponent();
            this.Cursor = hammer.ErstelleCursor();
            this.Text = Helper.InterfaceTitel;
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            // Intialisere den Restzeit-Timer (x sekunden bis spiel vorbei ist)
            RestZeit.Interval = 1000; 
            RestZeit.Tick += RestZeit_Tick;
            RestZeit.Start();

            // Intialisiere den Spam-Checker (Maustaste unendlich lang drücken = Verboten)
            SpamCheck.Interval = ZeitBisZumNächstenSpawn;
            SpamCheck.Tick += SpamCheck_Tick;
            SpamCheck.Start();

            // Intialisere den Mole-Spawner (Erzeugt Maulwürfe)
            MoleSpawner.Interval = ZeitBisZumNächstenSpawn;
            MoleSpawner.Tick += MoleSpawner_Tick;
            MoleSpawner.Start();

            // Timer für die Animation, wenn der Maulwurf nach oben geht
            AnimiereOben.Interval = 190;
            AnimiereOben.Tick += AnimiereOben_Tick;

            // Timer für die Animation, wenn der Maulwurf nach unten geht
            AnimiereUnten.Interval = 190;
            AnimiereUnten.Tick += AnimiereUnten_Tick;
        }

        /// <summary>
        /// Timer der die gesamte Zeit um 1 Sekunde erniedrigt
        /// </summary>
        private void RestZeit_Tick(object sender, EventArgs e)
        {
            GesamtZeit--;
            if (GesamtZeit == 0)
            {
                Datenbank.Speichern(Konfiguration.SpielerName, 1, 1, Punkte);
                RestZeit.Stop();
                MoleSpawner.Stop();
                SpamCheck.Stop();
                if (Punkte < 20)
                {
                    MessageBox.Show("Du hast dieses Level mit " + Punkte + " Punkten nicht geschafft.", "Zu wenig Hits!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gut! Mit " + Punkte + " Punkten hast du dieses Level geschafft.", "Erfolgreich!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                restzeit.Text = GesamtZeit.ToString();
            }
        }

        /// <summary>
        /// Timer der den Maulwurf nach unten "gleiten" lässt
        /// </summary>
        private void AnimiereUnten_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                mole.Location = new Point(mole.Location.X, mole.Location.Y + 6);

            }
            AnimiereUnten.Stop();
            mole.Visible = false;
        }

        /// <summary>
        /// Timer der den Maulwurf nach oben "gleiten" lässt
        /// </summary>
        private void AnimiereOben_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                mole.Location = new Point(mole.Location.X, mole.Location.Y - 6);

            }
            AnimiereOben.Stop();
        }

        /// <summary>
        /// Timer der es erlaubt, nach x Sekunden wieder treffen zu dürfen
        /// </summary>
        private void SpamCheck_Tick(object sender, EventArgs e)
        {
            DarfTreffen = true;
        }

        /// <summary>
        /// Timer der Maulwürfe spawnt
        /// </summary>
        private void MoleSpawner_Tick(object sender, EventArgs e)
        {
            switch (r.Next(1, 4))
            {
                case 1:
                    mole.Visible = true;
                    mole.Image = mole_back.Image;
                    mole.Location = new Point(Loch1[0], Loch1[1]);
                    AnimiereOben.Start();
                    break;
                case 2:
                    mole.Visible = true;
                    mole.Image = mole_back.Image;
                    mole.Location = new Point(Loch2[0], Loch2[1]);
                    AnimiereOben.Start();
                    break;
                case 3:
                    mole.Visible = true;
                    mole.Image = mole_back.Image;
                    mole.Location = new Point(Loch3[0], Loch3[1]);
                    AnimiereOben.Start();
                    break;
            }
        }

        /// <summary>
        /// Event, welches ausgelöst wird, wenn der Maulwurf angeklickt wird
        /// </summary>
        private void mole_MouseClick(object sender, MouseEventArgs e)
        {
            if (DarfTreffen)
            {
                SoundEngine.SpieleSound(Sound.Schuss);
                mole.Image = tot.Image;
                AnimiereUnten.Start();
                Punkte++;
                punkte.Text = Punkte.ToString();
                DarfTreffen = false;
            }
        }

        private void W1_Level1_MouseClick(object sender, MouseEventArgs e)
        {
            SoundEngine.SpieleSound(Sound.Schuss);
        }

        private void W1_Level1_FormClosing(object sender, FormClosingEventArgs e)
        {
            RestZeit.Stop();
            MoleSpawner.Stop();
            SpamCheck.Stop();
            RestZeit.Tick -= new EventHandler(RestZeit_Tick);
            MoleSpawner.Tick -= new EventHandler(MoleSpawner_Tick);
            SpamCheck.Tick -= new EventHandler(SpamCheck_Tick);
        }

        private void W1_Level1_FormClosed(object sender, FormClosedEventArgs e)
        {
            RestZeit.Dispose();
            RestZeit = null;
            GesamtZeit = 60;
        }
    }
}
