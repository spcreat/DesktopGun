using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ItsAGun
{
    public partial class Bullet : Form
    {
        public int speed = 2;
        public Point origin;
        public Point offset;

        public Bullet(Point startpos)
        {
            InitializeComponent();

            origin = startpos;
        }
    }
}
