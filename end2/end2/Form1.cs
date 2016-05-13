using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace end2
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen p;
        int x = 0, y = 0, w = 30, h = 30;
        int dx = 10, dy = 10;
        Timer t;
        SolidBrush b;
        private void move_object_Tick(object sender, EventArgs e)
        {
            if (x + w > Width)
            {
                dx = -10;
                b = new SolidBrush(Color.Red);
            }
            else if (x < 0)
            {
                dx = 10;
                b = new SolidBrush(Color.Blue);
            }
            if (y + h > Height)
            {
                dy = -10;
                b = new SolidBrush(Color.Yellow);
            }
            else if (y < 0)
            {
                dy = 10;
                b = new SolidBrush(Color.Green);
            }
            x += dx;
            y += dy;
            Refresh();
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //g.DrawEllipse(p,x,y,w,h); 
            g.FillEllipse(b,x,y,w,h);
        }

        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            p = new Pen(Color.Black);
            b = new SolidBrush(Color.Red);
            t = new Timer();
            t.Tick += new EventHandler(move_object_Tick);
            t.Start();
        }
    }
}
