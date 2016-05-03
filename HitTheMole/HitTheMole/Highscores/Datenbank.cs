using System;
using System.Data;
using System.Data.SQLite;

namespace HitTheMole
{
    class Datenbank
    {
        private static SQLiteConnection SQL_Verbindung;

        /// <summary>
        /// Verbindet sich zur lokalen highscores.db Datei
        /// </summary>
        public static bool Verbinden()
        {
            try
            {
                SQL_Verbindung = new SQLiteConnection("datasource=highscores.db;Version=3;");
                SQL_Verbindung.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Schließt die Verbindung zur lokalen Datenbank
        /// </summary>
        public static void Schließen()
        {
            if (SQL_Verbindung == null) throw new ArgumentNullException("SQL_Verbindung");
            SQL_Verbindung.Close();
            SQL_Verbindung.Dispose();
        }

        /// <summary>
        /// Speichert Werte in die lokale Datenbank
        /// </summary>
        public static void Speichern(string SpielerName, int Welt, int Level, int Highscore)
        {
            if (Konfiguration.SpeichereHighscores)
            {
                SQLiteCommand SQL_Befehl = new SQLiteCommand("INSERT INTO Highscores (SpielerName, Highscore, Welt, Level, Datum) " + 
                                                             "VALUES('" + SpielerName + "', " + Highscore + ", " + Welt + ", " + Level + 
                                                             ", '" + Helper.Datum + "');", SQL_Verbindung);
                SQL_Befehl.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Holt sich die Anzahl der gesamten Einträge
        /// </summary>
        /// <returns></returns>
        public static int EinträgeAnzahl()
        {
            SQLiteCommand SQL_Befehl = new SQLiteCommand("SELECT COUNT(*) FROM Highscores", SQL_Verbindung);
            SQL_Befehl.CommandType = CommandType.Text;
            return Convert.ToInt32(SQL_Befehl.ExecuteScalar());
        }
    }
}
