using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public enum Shape {Pencil,Rectangle,Circle,Triangle,Line,Eraser, Brush,Romb};
    class Drawer
    {
        public Graphics g;
        public Bitmap btm;
        private PictureBox box;
        public GraphicsPath path;
        public Shape shape;
        public Pen pen;
        public bool started = false;
        public Point prev;
        public Color color = Color.Black;
        public Queue<Point> q = new Queue<Point>();
        public bool[,] used = new bool[542, 465];
        public int width = 1;
        
        public Drawer(PictureBox b)
        {
            this.box = b;
            pen = new Pen(Color.Black);
            box.Paint += Picture_Paint;
            Open("");
        }

        public void fill(Point cur)
        {
            Color clicked_color = btm.GetPixel(cur.X, cur.X);
            checkNeighbors(cur.X, cur.Y, clicked_color);
            while (q.Count > 0)
            {
                Point p = q.Dequeue();
                checkNeighbors(p.X + 1, p.Y, clicked_color);
                checkNeighbors(p.X, p.Y + 1, clicked_color);
                checkNeighbors(p.X - 1, p.Y, clicked_color);
                checkNeighbors(p.X, p.Y - 1, clicked_color);
            }
            box.Refresh();
        }
        public void checkNeighbors(int x, int y, Color clicked_color)
        {
            if (x > 0 && y > 0 && x < box.Width && y < box.Height)
            {
                if (used[x, y] == false && btm.GetPixel(x, y) == clicked_color)
                {
                    used[x, y] = true;
                    q.Enqueue(new Point(x, y));
                    btm.SetPixel(x, y, color);
                }
            }
        }
        public void Open(string filename)
        {
            if (filename == "")
            {
                btm = new Bitmap(box.Width, box.Height);
            }
            else
            {
                btm = new Bitmap(filename);
            }
            g = Graphics.FromImage(btm);
            box.Image = btm;
        }
        public void Picture_Paint(object sender, PaintEventArgs e)
        {
            if (path != null)
            {
                e.Graphics.DrawPath(pen,path);
            }
        }
        public void LastPoint()
        {
            if (path != null)
            {
                g.DrawPath(pen, path);
                path = null;
            }
        }
        public void Save(string filename)
        {
            btm.Save(filename);
        }
        public void Draw(Point current)
        {
            path = new GraphicsPath();
            int width = Math.Abs(prev.X - current.X);
            int height = Math.Abs(prev.Y - current.Y);
            int point_x = prev.X;
            int point_y = prev.Y;
            if(current.X < prev.X)
            {
                point_x = current.X;
            }
            if (current.Y < prev.Y)
            {
                point_y = current.Y;
            }
            switch (shape)
            {
                case Shape.Pencil:
                    g.DrawLine(pen,prev,current);
                    prev = current;
                    break;
                case Shape.Rectangle:
                    path.AddRectangle(new Rectangle(point_x,point_y,width,height));
                    break;
                case Shape.Triangle:
                    Point p1 = new Point(), p2 = new Point(), p3 = new Point();
                    /*p1.X = prev.X;
                    p1.Y = prev.Y;
                    p2.X = (prev.X + current.X) / 2;
                    p2.Y = Math.Abs(prev.Y - current.Y);
                    p3.X = current.X;
                    p3.Y = current.Y;*/
                    p1.X = prev.X;
                    p1.Y = prev.Y;
                    p2.X = current.X;
                    p2.Y = current.Y;      
                    p3.X = current.X - 2 * (current.X - prev.X);
                    p3.Y = current.Y;
                    Point[] triangle = {p1,p2,p3};
                    path.AddPolygon(triangle);
                    break;
                case Shape.Circle:
                    path.AddEllipse(new Rectangle(point_x,point_y,width,height));
                    break;
                case Shape.Line:
                    path.AddLine(prev,current);
                    break;
                case Shape.Eraser:
                    Rectangle eraser = new Rectangle(prev.X-10,prev.Y-10,width,width);
                    g.FillRectangle(new SolidBrush(Color.White), eraser);
                    prev = current;
                    break;
                case Shape.Romb:
                    Point a1 = new Point(), a2 = new Point(), a3 = new Point(), a4 = new Point();
                    /*a1.X = prev.X;
                    a1.Y = prev.Y;
                    a2.X = current.X;
                    a2.Y = current.Y;
                    a3.X = prev.X;
                    a3.Y = 2 * (prev.Y + current.Y);
                    a4.X = current.X - 2 * (current.X - prev.X);
                    a4.Y = current.Y;*/
                    if (Math.Abs(a2.X - a1.X) == Math.Abs(a3.X - a4.X) && Math.Abs(a2.X - a3.X) == Math.Abs(a4.X - a1.X) && Math.Abs(a4.Y - a2.Y) == Math.Abs(a1.X - a3.X))
                    {
                        a1.X = prev.X;
                        a1.Y = prev.Y / 2;
                        a2.X = (prev.X + current.X) / 2;
                        a4.X = (prev.X + current.X) / 2;
                        a3.X = current.X;

                        if (a2.Y > a4.Y)
                        {
                            a2.Y = prev.Y;
                        }
                        a3.Y = prev.Y / 2;
                        a4.Y = current.Y;
                    }
                    /*a1.X = prev.X;
                    a1.Y = prev.Y;
                    a2.X = current.X;
                    a2.Y = current.Y;
                    a3.X = prev.X;
                    a3.Y = current.Y - prev.Y;
                    a4.X = current.X;
                    a4.Y = current.Y + prev.X;*/
                    Point[] r = {a1,a2,a3,a4 };
                    path.AddPolygon(r);
                    break;
                default:
                    break;
            }
            box.Refresh();
        }        
    }
}
