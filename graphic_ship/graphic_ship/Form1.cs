using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphic_ship
{
    public partial class Form1 : Form
    {
        Graphics g;
        SolidBrush brush, stars, ship,gun;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            brush = new SolidBrush(Color.Blue);
            stars = new SolidBrush(Color.White);
            ship = new SolidBrush(Color.Yellow);
            gun = new SolidBrush(Color.Green);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.FillRectangle(brush,0,0,645,554);
            for(int i = 0; i < 5; i++)
            {
                g.FillEllipse(stars,draw_stars(i+1));
            }
            /*g.FillEllipse(stars,37,101,20,20);
            g.FillEllipse(stars,250,55,20,20);
            g.FillEllipse(stars,495,151,30,30);
            g.FillEllipse(stars,486,366,40,40);
            g.FillEllipse(stars,68,295,45,45);*/
            //Point[] points = {new Point(241,227), new Point(241,287), new Point(271,307), new Point(301,287), new Point(301,227), new Point(271,174) };
            //Point[] guns = { new Point(261, 237), new Point(261, 257), new Point(271,257), new Point(271,287), new Point(291,257), new Point(291,237) };
            g.FillPolygon(ship,draw_spaceship(241,227));
            //g.FillPolygon(gun,guns);
        }

        private Point[] draw_spaceship(int x, int y)
        {
            Point spaceship_p1 = new Point(x, y);
            Point spaceship_p2 = new Point(x, y + 60);
            Point spaceship_p3 = new Point(x + 30, y + 80);
            Point spaceship_p4 = new Point(x + 60, y + 60);
            Point spaceship_p5 = new Point(x + 60, y);
            Point spaceship_p6 = new Point(x + 30, y - 53);
            Point[] spaceships_points = {spaceship_p1,spaceship_p2,spaceship_p3,spaceship_p4,spaceship_p5,spaceship_p6};
            return spaceships_points;
        }
        
        private Rectangle draw_stars(int n)
        {
            int x = 0, y = 0,size = 0;
            switch (n)
            {
                case 1:
                    x = 37;
                    y = 101;
                    size = 20;
                    break;
                case 2:
                    x = 250;
                    y = 55;
                    size = 20;
                    break;
                case 3:
                    x = 495;
                    y = 151;
                    size = 30;
                    break;
                case 4:
                    x = 486;
                    y = 366;
                    size = 40;
                    break;
                case 5:
                    x = 68;
                    y = 295;
                    size = 45;
                    break;
            }
            Rectangle rect = new Rectangle(x,y,size,size);
            return rect;
        }
    }
}
