using System;
using System.Media;

namespace HitTheMole
{
    class SoundEngine
    {
        private static SoundPlayer SoundAbspieler;

        /// <summary>
        /// Spielt einen Sound ab
        /// </summary>
        public static void SpieleSound(Sound s)
        {
            if (Konfiguration.Musik)
            {
                SoundAbspieler = new SoundPlayer();
                switch (s)
                {
                    case Sound.Schuss:
                        SoundAbspieler.SoundLocation = @"sound\schuss.wav";
                        SoundAbspieler.Play();
                        break;
                }
            }
        }
    }
}
