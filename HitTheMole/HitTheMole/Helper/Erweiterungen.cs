using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HitTheMole
{
    static class Erweiterungen
    {
        /// <summary>
        /// Speichert Informationen über Windows Icons
        /// </summary>
        public struct IconInfo
        {
            public bool fIcon;
            public int xHotspot;
            public int yHotspot;
            public IntPtr hbmMask;
            public IntPtr hbmColor;
        }

        // Ruft dynamisch GetIconInfo auf
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetIconInfo(IntPtr hIcon, ref IconInfo pIconInfo);

        // Ruft dynamisch CreateIconIndirect auf
        [DllImport("user32.dll")]
        public static extern IntPtr CreateIconIndirect(ref IconInfo icon);

        /// <summary>
        /// Erstellt aus einer BitMap einen Cursor
        /// </summary>
        public static Cursor ErstelleCursor(this PictureBox p)
        {
            IntPtr ptr = new Bitmap(p.Image).GetHicon();
            IconInfo tmp = new IconInfo();
            GetIconInfo(ptr, ref tmp);
            tmp.xHotspot = 5;
            tmp.yHotspot = 5;
            tmp.fIcon = false;
            ptr = CreateIconIndirect(ref tmp);
            return new Cursor(ptr);
        }

        /// <summary>
        /// Gibt zurück, ob sich die Maus über dem Maulwurf befindet
        /// </summary>
        public static bool MausÜberMaulwurf(this PictureBox maulwurf)
        {
            if (maulwurf == null)
                throw new ArgumentNullException("maulwurf");
            Point pt = maulwurf.PointToClient(Control.MousePosition);
            return (pt.X >= 0 && pt.Y >= 0 && pt.X <= maulwurf.Width && pt.Y <= maulwurf.Height);
        }
    }
}
