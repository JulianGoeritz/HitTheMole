using System;
using System.Windows.Forms;

namespace HitTheMole
{
    public partial class SpielAuswahl : Form
    {
        private string SpielerName = "";
        private bool Musik;
        private bool Speichern;
    
        public SpielAuswahl(string spielername, bool musik, bool speichern)
        {
            InitializeComponent();
            this.SpielerName = spielername;
            this.Musik = musik;
            this.Speichern = speichern;
            this.Text = Helper.InterfaceTitel;
            this.willkommen.Text = "Willkommen bei der Spielauswahl, " + SpielerName + "!";
        }

        private void einleitung_Click(object sender, EventArgs e)
        {
            Einleitung el = new Einleitung();
            el.ShowDialog();
        }

        private void welt1_1_Click(object sender, EventArgs e)
        {
            W1_Level1 w1_l1 = new W1_Level1();
            w1_l1.ShowDialog();
        }

        private void welt1_2_Click(object sender, EventArgs e)
        {
            W1_Level2 w1_l2 = new W1_Level2();
            w1_l2.ShowDialog();
        }

        private void welt1_3_Click(object sender, EventArgs e)
        {
            W1_Level3 w1_l3 = new W1_Level3();
            w1_l3.ShowDialog();
        }

        private void welt2_1_Click(object sender, EventArgs e)
        {
            W2_Level1 w2_l1 = new W2_Level1();
            w2_l1.ShowDialog();
        }

        private void welt2_2_Click(object sender, EventArgs e)
        {
            W2_Level2 w2_l2 = new W2_Level2();
            w2_l2.ShowDialog();
        }

        private void welt2_3_Click(object sender, EventArgs e)
        {
            W2_Level3 w2_l3 = new W2_Level3();
            w2_l3.ShowDialog();
        }

        private void welt3_1_Click(object sender, EventArgs e)
        {
            W3_Level1 w3_l1 = new W3_Level1();
            w3_l1.ShowDialog();
        }

        private void welt3_2_Click(object sender, EventArgs e)
        {
            W3_Level2 w3_l2 = new W3_Level2();
            w3_l2.ShowDialog();
        }

        private void welt3_3_Click(object sender, EventArgs e)
        {
            W3_Level3 w3_l3 = new W3_Level3();
            w3_l3.ShowDialog();
        }

        private void zurück_Click(object sender, EventArgs e)
        {
            Helper.VersteckeForm(this);
            SpielMenü m = new SpielMenü();
            m.ShowDialog();
        }
    }
}
