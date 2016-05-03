using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HitTheMole
{
    public partial class Über : Form
    {
        public Über()
        {
            InitializeComponent();
        }

        private void quellcode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/JulianGoeritz/HitTheMole");
        }
    }
}
