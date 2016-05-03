using System;
using System.ComponentModel;
using System.Data.SQLite;
using System.Windows.Forms;

namespace HitTheMole
{
    public partial class Highscores : Form
    {
        public Highscores()
        {
            InitializeComponent();
            this.Text = Helper.InterfaceTitel;
            datenbankAnsicht.Sort(datenbankAnsicht.Columns["Highscore"], ListSortDirection.Ascending);
            try
            {
                // Der folgende Code liest mit SQL Syntax Werte aus der Datenbank
                datenbankEinträge.Text = Datenbank.EinträgeAnzahl().ToString() + " gespeicherte Einträge";
                SQLiteConnection conn = new SQLiteConnection("datasource=highscores.db;Version=3;");
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand("SELECT * FROM Highscores", conn);
                using (SQLiteDataReader read = comm.ExecuteReader())
                {
                    while (read.Read())
                    {
                        datenbankAnsicht.Rows.Add(new object[] {
                        read.GetValue(read.GetOrdinal("SpielerName")),
                        read.GetValue(read.GetOrdinal("Highscore")),
                        read.GetValue(read.GetOrdinal("Welt")),
                        read.GetValue(read.GetOrdinal("Level")),
                        read.GetValue(read.GetOrdinal("Datum")),
                    });
                    }
                }
                conn.Close();
                datenbankAnsicht.Update();
                abfrage.ForeColor = System.Drawing.Color.Green;
                abfrage.Text = "highscores.db Abfrage erfolgreich :)!";
            }
            catch
            {
                abfrage.ForeColor = System.Drawing.Color.DarkRed;
                abfrage.Text = "highscores.db Abfrage nicht erfolgreich :(!";
            }
        }

        private void neuLaden_Click(object sender, EventArgs e)
        {
            datenbankAnsicht.Rows.Clear();
            try
            {
                // Der folgende Code liest mit SQL Syntax Werte aus der Datenbank
                datenbankEinträge.Text = Datenbank.EinträgeAnzahl().ToString() + " gespeicherte Einträge";
                SQLiteConnection conn = new SQLiteConnection("datasource=highscores.db;Version=3;");
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand("SELECT * FROM Highscores", conn);
                using (SQLiteDataReader read = comm.ExecuteReader())
                {
                    while (read.Read())
                    {
                        datenbankAnsicht.Rows.Add(new object[] {
                        read.GetValue(read.GetOrdinal("SpielerName")),
                        read.GetValue(read.GetOrdinal("Highscore")),
                        read.GetValue(read.GetOrdinal("Welt")),
                        read.GetValue(read.GetOrdinal("Level")),
                        read.GetValue(read.GetOrdinal("Datum")),
                    });
                    }
                }
                conn.Close();
                datenbankAnsicht.Update();
                abfrage.ForeColor = System.Drawing.Color.Green;
                abfrage.Text = "highscores.db Abfrage erfolgreich :)!";
            }
            catch
            {
                abfrage.ForeColor = System.Drawing.Color.DarkRed;
                abfrage.Text = "highscores.db Abfrage nicht erfolgreich :(!";
            }
        }
    }
}
