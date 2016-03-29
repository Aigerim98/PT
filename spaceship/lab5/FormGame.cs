using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class FormGame : Form
    {
        int rocket_x, rocket_y;
        int rocket_shift_x = 20;        
        int gun_x, gun_y;
        
        private void init()
        {
            rocket_x = rocket.Location.X;
            rocket_y = rocket.Location.Y;
            gun_x = rocket.Location.X;
            gun_y = gun.Location.Y;
        }

        private void FormGame_Shown(object sender, EventArgs e)
        {
            init();
        }

        public FormGame()
        {
            InitializeComponent();
        }

        private void gun_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gun.Location = new Point(gun.Location.X, gun.Location.Y - 30);
            //timer1.Interval = 1;
        }

        private void move_rocket(int x)
        {
            int rx1 = rocket_x + x;
            int rx2 = rx1 + rocket.Width;
            if (rx1 < 0)
            {
                rx1 = 0;
            }
            if (rx2 > 591)
            {
                rx1 = 591-rocket.Width;
            }
            rocket_x = rx1;
            rocket.Location = new Point(rocket_x,rocket_y);
        }

         
        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            switch (key)
            {
                case Keys.Left:
                    move_rocket(-rocket_shift_x);
                    break;
                case Keys.Right:
                    move_rocket(rocket_shift_x);
                    break;
                case Keys.Space:
                    timer1.Start();
                    
                    break;
                default:
                    break;
            }
        }
    }
}
