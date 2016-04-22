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
        Pen p;
        bool filling = false;
        public Form1()
        {
            InitializeComponent();
            p = new Pen(Color.Black);
            drawer = new Drawer(pictureBox);
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 10;
            //g = this.CreateGraphics();
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
                if (filling)
                {
                    drawer.fill(e.Location);
                    drawer.g = Graphics.FromImage(drawer.btm);
                    pictureBox.Image = drawer.btm;
                }
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
                case "eraser":
                    drawer.shape = Shape.Eraser;
                    break;
                case "triangle":
                    drawer.shape = Shape.Triangle;
                    break;
                case "romb":
                    drawer.shape = Shape.Romb;
                    break;
                default:
                    break;
            }
        }

        private void color_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            drawer.pen = new Pen(colorDialog1.Color);
            drawer.pen.Width = trackBar1.Value;
            drawer.color = colorDialog1.Color;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //drawer.pen = new Pen(colorDialog1.Color, trackBar1.Value);
            drawer.pen.Width = trackBar1.Value;
            drawer.width += trackBar1.Value;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawer.g.Clear(Color.White);
            pictureBox.Refresh();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                drawer.Open(openFileDialog2.FileName);
            }   
        }
        
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                drawer.Save(saveFileDialog1.FileName);
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            filling = true;
            colorDialog1.ShowDialog();
            drawer.color = colorDialog1.Color;
           
        }
    }
}