using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace HitTheMole
{
    class Helper
    {
        /// <summary>
        /// Versteckt eine Windows Form
        /// </summary>
        public static void VersteckeForm(Form f)
        {
            f.Invoke(new Action(() =>
            {
                f.Hide();
            }));
        }

        /// <summary>
        /// Gibt den Titel für alle Interfaces an
        /// </summary>
        public static string InterfaceTitel
        {
            get
            {
                return "Hit the Mole | © " + DateTime.Now.Year + " Julian";
            }
        }

        /// <summary>
        /// Gibt das gesamte Spiel zurück
        /// </summary>
        public static Assembly HitTheMoleSpiel
        {
            get
            {
                return Assembly.GetExecutingAssembly();
            }
        }

        /// <summary>
        /// Gibt die Hit The Mole Spielversion zurück
        /// z.B. v1.0.0
        /// </summary>
        public static string HitTheMoleSpielVersion
        {
            get
            {
                return "v" + Assembly.GetExecutingAssembly().GetName().Version.ToString().Remove(5);
            }
        }

        /// <summary>
        /// Gibt die .NET Version zurück (Muss >= 4.0 sein)
        /// z.B. v4.0.0.0
        /// </summary>
        public static string DotNetVersion
        {
            get
            {
                return "v" + Assembly.GetExecutingAssembly().GetReferencedAssemblies().Where(x => x.Name == "System.Core").First().Version.ToString();
            }
        }

        /// <summary>
        /// Gibt das aktuelle Datum im folgenden Format zurück:
        /// Feb Fri 27 11:41
        /// </summary>
        public static string Datum
        {
            get
            {
                return DateTime.UtcNow.ToString("MMM ddd d HH:mm");
            }
        }

        /// <summary>
        /// Gibt eine kurze Information zurück
        /// </summary>
        public static string Über
        {
            get
            {
                return "Vollständig programmiert von Julian Goeritz.\nZeilen Code: 5115\nSprache: C# .NET 4.0";
            }
        }

        /// <summary>
        /// Gibt zurück, ob benötigte Dateien existieren
        /// </summary>
        public static bool ExistierenBenötigteDateien
        {
            get
            {
                return (File.Exists("HitTheMole.exe.config") &&
                        File.Exists("highscores.db") &&
                        File.Exists(@"sound\schuss.wav") &&
                        File.Exists(@"dlls\EntityFramework.dll") &&
                        File.Exists(@"dlls\EntityFramework.SqlServer.dll") &&
                        File.Exists(@"dlls\System.Data.SQLite.dll") &&
                        File.Exists(@"dlls\System.Data.SQLite.EF6.dll") &&
                        File.Exists(@"dlls\System.Data.SQLite.Linq.dll") &&
                        File.Exists(@"dlls\x64\SQLite.Interop.dll") &&
                        File.Exists(@"dlls\x86\SQLite.Interop.dll") &&
                        File.Exists(@"dlls\xml\EntityFramework.SqlServer.xml") &&
                        File.Exists(@"dlls\xml\EntityFramework.xml") &&
                        File.Exists(@"dlls\xml\System.Data.SQLite.xml"));
            }
        }
    }
}
