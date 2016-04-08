using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        Drawer drawer;
        public Form1()
        {
            InitializeComponent();
            drawer = new Drawer(pictureBox);
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 10;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }      

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drawer.prev = e.Location;
                drawer.started = true;
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawer.started)
            {
                drawer.Draw(e.Location);
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            drawer.started = false;
            drawer.LastPoint();
        }

        private void shape_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "pen":
                    drawer.shape = Shape.Pencil;
                    break;
                case "rectangle":
                    drawer.shape = Shape.Rectangle;
                    break;
                case "circle":
                    drawer.shape = Shape.Circle;
                    break;
                case "line":
                    drawer.shape = Shape.Line;
                    break;
            }
        }

        private void color_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            drawer.pen = new Pen(colorDialog1.Color);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //MessageBox.Show(trackBar1.Value + "");
            drawer.pen = new Pen(colorDialog1.Color, trackBar1.Value);
        }
    }
}
