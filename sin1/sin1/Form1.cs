using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sin1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            point.Add(new PointF(40,300));
            point.Add(new PointF(40,300));
            InitializeComponent();
            t.Tick += timer1_Tick;
            t.Interval = 500;
            t.Start();
        }
        List<PointF> point = new List<PointF>();
        Timer t = new Timer();
        public static int x = 0;
        public static double y;
        public static float dx = 0, dy = 0;
        Pen pen = new Pen(Color.Blue);

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Black),40,30,40,500);
            e.Graphics.DrawLine(new Pen(Color.Black),0,300,700,300);
            drawingCurve(e);
            using (Font font = new Font("Arial", 9, FontStyle.Bold, GraphicsUnit.Pixel))
            {
                for(int i = 0; i < 16; i++)
                {
                    PointF p = new PointF(40 + i + 30 * i,300);
                    string s = "";
                    if(i == 0)
                    {
                        s = 0 + "";
                    }else if (i == 1)
                    {
                        s = "π";
                    }
                    else
                    {
                        s = i + "π";
                    }
                    e.Graphics.DrawString(s, font, Brushes.Black, p);
                }
                e.Graphics.DrawString("X",font,Brushes.Black,700,500);
                e.Graphics.DrawString("Y",font,Brushes.Black,30,25);
                e.Graphics.DrawString("1",font,Brushes.Black,30,310);
                e.Graphics.DrawString("-1",font,Brushes.Black,30,290);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x++;
            y = Math.Sin(x);
            dx = (float)x * 10 + 40;
            dy = (float)y * 10 + 300;
            point.Add(new PointF(dx,dy));
            if (x < 840)
            {
                this.Refresh();
            }
        }
        private void drawingCurve(PaintEventArgs e)
        {
            e.Graphics.DrawCurve(pen,point.ToArray());
        }
    }
}
