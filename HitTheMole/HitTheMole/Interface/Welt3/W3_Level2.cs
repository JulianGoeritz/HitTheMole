using System;
using System.Drawing;
using System.Windows.Forms;

namespace HitTheMole
{
    public partial class W3_Level2 : Form
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
        private int[] Loch1 = { 66, 350 };
        private int[] Loch2 = { 269, 350 };
        private int[] Loch3 = { 470, 350 };

        private int[] Loch4 = { 66, 187 };
        private int[] Loch5 = { 269, 187 };
        private int[] Loch6 = { 470, 187 };

        private int[] Loch7 = { 66, 41 };
        private int[] Loch8 = { 269, 41 };
        private int[] Loch9 = { 470, 41 };

        // Öffentliche Informationen
        public static string Info = "Welt3 | Level2";
        public static string Schwierigkeit = "Schwerer als Schwer";
        public static int LöcherAnzahl = 9;
        public static int ZeitBisZumNächstenSpawn = 1000; // 1,0 sek
        public static int GesamtZeit = 60; // 60 sek

        public W3_Level2()
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
                Datenbank.Speichern(Konfiguration.SpielerName, 3, 2, Punkte);
                RestZeit.Stop();
                MoleSpawner.Stop();
                SpamCheck.Stop();
                if (Punkte < 45)
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
            switch (r.Next(1, 10))
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
                case 4:
                    mole.Visible = true;
                    mole.Image = mole_back.Image;
                    mole.Location = new Point(Loch4[0], Loch4[1]);
                    AnimiereOben.Start();
                    break;
                case 5:
                    mole.Visible = true;
                    mole.Image = mole_back.Image;
                    mole.Location = new Point(Loch5[0], Loch5[1]);
                    AnimiereOben.Start();
                    break;
                case 6:
                    mole.Visible = true;
                    mole.Image = mole_back.Image;
                    mole.Location = new Point(Loch6[0], Loch6[1]);
                    AnimiereOben.Start();
                    break;
                case 7:
                    mole.Visible = true;
                    mole.Image = mole_back.Image;
                    mole.Location = new Point(Loch7[0], Loch7[1]);
                    AnimiereOben.Start();
                    break;
                case 8:
                    mole.Visible = true;
                    mole.Image = mole_back.Image;
                    mole.Location = new Point(Loch8[0], Loch8[1]);
                    AnimiereOben.Start();
                    break;
                case 9:
                    mole.Visible = true;
                    mole.Image = mole_back.Image;
                    mole.Location = new Point(Loch9[0], Loch9[1]);
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

        private void W3_Level2_FormClosed(object sender, FormClosedEventArgs e)
        {
            RestZeit.Dispose();
            RestZeit = null;
            GesamtZeit = 60;
        }

        private void W3_Level2_FormClosing(object sender, FormClosingEventArgs e)
        {
            RestZeit.Stop();
            MoleSpawner.Stop();
            SpamCheck.Stop();
            RestZeit.Tick -= new EventHandler(RestZeit_Tick);
            MoleSpawner.Tick -= new EventHandler(MoleSpawner_Tick);
            SpamCheck.Tick -= new EventHandler(SpamCheck_Tick);
        }
    }
}
