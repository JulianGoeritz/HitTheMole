using System;
using System.Windows.Forms;

namespace HitTheMole
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {          
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.CurrentInputLanguage = InputLanguage.DefaultInputLanguage;
            Application.Run(new Loader());
        }
    }
}
