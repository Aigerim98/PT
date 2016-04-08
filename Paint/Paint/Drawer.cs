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
    public enum Shape {Pencil,Rectangle,Circle,Triangle,Line };
    class Drawer
    {
        private Graphics g;
        private Bitmap btm;
        private PictureBox box;
        public GraphicsPath path;

        public Shape shape;
        public Pen pen;
        public bool started = false;
        public Point prev;

        public Drawer(PictureBox b)
        {
            this.box = b;
            btm = new Bitmap(box.Width,box.Height);
            g = Graphics.FromImage(btm);
            box.Image = btm;
            pen = new Pen(Color.Black);
            box.Paint += Picture_Paint;
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
                g.DrawPath(pen,path);
            }
        }
        public void Draw(Point current)
        {
            path = new GraphicsPath();
            int width = Math.Abs(prev.X - current.X);
            int height = Math.Abs(prev.Y - current.Y);
            int point_x = prev.X;
            int point_y = prev.Y;
            if (current.X < prev.X)
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
                    break;
                case Shape.Circle:
                    path.AddEllipse(new Rectangle(point_x,point_y,width,height));
                    break;
                case Shape.Line:
                    path.AddLine(prev,current);
                    break;
                default:
                    break;
            }
            box.Refresh();
        }
    }
}
