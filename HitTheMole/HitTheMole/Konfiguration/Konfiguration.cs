using System;
using System.Configuration;
using System.Windows.Forms;

namespace HitTheMole
{
    class Konfiguration
    {
        /// <summary>
        /// Holt sich einen Wert aus der Konfiguration
        /// </summary>
        public static string HoleWert(string k)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(Helper.HitTheMoleSpiel.Location);
            return configuration.AppSettings.Settings[k].Value;
        }

        /// <summary>
        /// Setzt einen Wert in die Konfiguration
        /// </summary>
        public static void SetzeWert(string k, string v)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(Helper.HitTheMoleSpiel.Location);
            configuration.AppSettings.Settings[k].Value = v;
            configuration.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }

        /// <summary>
        /// Speichert Konfigurationswerte
        /// </summary>
        public static void Speichern(string nickName, bool musikAnAus, bool highscoresJaNein)
        {
            SetzeWert("SpielerName", nickName);
            SetzeWert("Musik", musikAnAus ? "ja" : "nein");
            SetzeWert("HighscoresSpeichern", highscoresJaNein ? "ja" : "nein");
        }

        /// <summary>
        /// Gibt den Spielernamen zurück
        /// </summary>
        public static string SpielerName
        {
            get
            {
                return HoleWert("SpielerName");
            }
        }

        /// <summary>
        /// Gibt zurück, ob Musik an/aus sein soll
        /// </summary>
        public static bool Musik
        {
            get
            {
                return (HoleWert("Musik") == "ja") ? true : false;
            }
        }

        /// <summary>
        /// Gibt zurück, ob Highscores gespeichert werden sollen
        /// </summary>
        public static bool SpeichereHighscores
        {
            get
            {
                return (HoleWert("HighscoresSpeichern") == "ja") ? true : false;
            }
        }
    }
}
