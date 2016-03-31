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
        SolidBrush brush, stars, ship,gun,asteroids;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            brush = new SolidBrush(Color.Blue);
            stars = new SolidBrush(Color.White);
            ship = new SolidBrush(Color.Yellow);
            gun = new SolidBrush(Color.Green);
            asteroids = new SolidBrush(Color.Red);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.FillRectangle(brush,0,0,Width,Height);
            for(int i = 0; i < 5; i++)
            {
                g.FillEllipse(stars,draw_stars(i+1));
                g.FillPolygon(asteroids,draw_asteroids(i+1));
            }
            g.FillPolygon(ship,draw_spaceship(241,227));
            g.FillPolygon(gun,draw_guns(261,257));
        }
        private Point[] draw_asteroids(int n)
        {
            int x = 0, y = 0;
            switch (n)
            {
                case 1:
                    x = 104;
                    y = 269;
                    break;
                case 2:
                    x = 211;
                    y = 123;
                    break;
                case 3:
                    x = 484;
                    y = 121;
                    break;
                case 4:
                    x = 500;
                    y = 334;
                    break;
                case 5:
                    x = 272;
                    y = 481;
                    break;
                default:
                    break;
            }
            Point asteroids_p1 = new Point(x,y);
            Point asteroids_p2 = new Point(x - 10,y - 10);
            Point asteroids_p3 = new Point(x - 20,y - 10);
            Point asteroids_p4 = new Point(x - 10,y - 20);
            Point asteroids_p5 = new Point(x - 20,y - 30);
            Point asteroids_p6 = new Point(x - 10,y - 30);
            Point asteroids_p7 = new Point(x,y - 40);
            Point asteroids_p8 = new Point(x + 10,y - 30);
            Point asteroids_p9 = new Point(x + 20, y - 30);
            Point asteroids_p10 = new Point(x + 10, y - 20);
            Point asteroids_p11 = new Point(x + 20, y - 10);
            Point asteroids_p12 = new Point(x + 10, y - 10);
            Point[] asteroid_points = { asteroids_p1, asteroids_p2, asteroids_p3, asteroids_p4, asteroids_p5, asteroids_p6, asteroids_p7, asteroids_p8, asteroids_p9, asteroids_p10, asteroids_p11, asteroids_p12 };
            return asteroid_points;
        }
        private Point[] draw_guns(int x, int y)
        {
            Point guns_p1 = new Point(x,y);
            Point guns_p2 = new Point(x,y-20);
            Point guns_p3 = new Point(x-5,y-20);
            Point guns_p4 = new Point(x+8,y-40);
            Point guns_p5 = new Point(x+20,y-20);
            Point guns_p6 = new Point(x+16,y-20);
            Point guns_p7 = new Point(x+16,y);
            Point[] guns_points = {guns_p1,guns_p2,guns_p3,guns_p4,guns_p5,guns_p6,guns_p7};
            return guns_points;
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
