using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace ItsAGun
{
    public partial class GunPart : Form
    {
        public int gunpartID;
        public Point positionOffset;

        public GunPart(int id)
        {
            gunpartID = id;
            InitializeComponent();

            trig1.Visible = false;
            trig2.Visible = false;
            trig3.Visible = false;
            trig4.Visible = false;

            switch (id) // Change properties based on ID
            {
                case 0:
                    Size = new Size(400, 76);
                    positionOffset = new Point(0, 0);
                    ControlBox = true;
                    ShowInTaskbar = true;
                    BackColor = Color.FromArgb(222, 222, 224);
                    break;
                case 1:
                    Size = new Size(114, 60);
                    positionOffset = new Point(68, 78);
                    trig1.Visible = true;
                    trig2.Visible = true;
                    trig3.Visible = true;
                    trig4.Visible = true;
                    BackColor = Color.FromArgb(222,222,224);
                    break;
                case 2:
                    Size = new Size(79, 72);
                    positionOffset = new Point(-20, 78);
                    BackColor = Color.FromArgb(134, 69, 27);
                    break;
                case 3:
                    Size = new Size(79, 72);
                    positionOffset = new Point(-40, 150);
                    BackColor = Color.FromArgb(134, 69, 27);
                    break;
                case 4:
                    Size = new Size(79, 72);
                    positionOffset = new Point(-60, 222);
                    BackColor = Color.FromArgb(134, 69, 27);
                    break;
                default:
                    break;
            }

            Point newPoint = new Point(Program.centralPoint.X + positionOffset.X, Program.centralPoint.Y + positionOffset.Y);
            Location = newPoint; // Position all pieces
        }

        private void GunPart_LocationChanged(object sender, EventArgs e)
        {
            TopMost = true;
            if (gunpartID==0) // If section 0, allow the window to be dragged and move the other windows with it.
            {
                Program.centralPoint = Location;

                foreach (Form form in Program.forms)
                {
                    Point newPoint = new Point(Program.centralPoint.X+positionOffset.X,Program.centralPoint.Y+positionOffset.Y);
                    form.Location = newPoint;
                }
            }
            else // Make these snap back to the central part if moved.
            {
                Point newPoint = new Point(Program.centralPoint.X + positionOffset.X, Program.centralPoint.Y + positionOffset.Y);
                Location = newPoint;
            }
        }

        private void GunPart_FormClosing(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Close all pieces when one piece closes
        }

        private void trig2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(CreateBullet); // Create Bullet
            thread.Start();
        }

        private void CreateBullet() // Create + manage bullet
        {
            Point bulletPos = Program.centralPoint;
            bulletPos.Y += 5;
            bulletPos.X += 400;
            Bullet bullet = new Bullet(bulletPos);
            Debug.WriteLine(bullet.Location.X + " " + DesktopBounds.Width);
            int timer = 500;
            while (timer>0)
            {
                bullet.Show();
                bullet.offset.X += bullet.speed;
                Point newpos = new Point(bullet.origin.X + bullet.offset.X, bullet.origin.Y + bullet.offset.Y);
                bullet.Location = newpos;
                timer--;
            }
        }

        private void trig3_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(CreateBullet); // Create Bullet
            thread.Start();
        }
    }
}
