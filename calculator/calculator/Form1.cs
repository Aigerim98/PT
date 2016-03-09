using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace calculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operations = "";
        bool operation_pressed = false;
        string filename = "";
        public Form1()
        {
            InitializeComponent();
        }


        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") ||(operation_pressed))
                textBox1.Clear();

            operation_pressed = false;
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
        }

        private void operation(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operations = b.Text;
            value = Double.Parse(textBox1.Text);
            operation_pressed = true;
            equation.Text = value + " " + operations;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch (operations)
            {
                case "+":
                    textBox1.Text = (value + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (value - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (value * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (value / Double.Parse(textBox1.Text)).ToString();
                    break;
                case "1/x":
                    textBox1.Text = (1 / value).ToString();
                    break;
                case "sqrt(x)":
                    textBox1.Text = (Math.Sqrt(value)).ToString();
                    break;
                case "x^2":
                    textBox1.Text = (value * value).ToString();
                    break; 
                case "%":
                    textBox1.Text = ((value / 100.0)*Double.Parse(textBox1.Text)).ToString();
                    break;
                case "MS":
                    //FileStream fread = new FileStream(@"C:\test\input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

                    filename = "input.txt";
                    FileStream fwrite = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    //StreamReader sr = new StreamReader(fread);
                    StreamWriter sw = new StreamWriter(fwrite);
                    //XmlSerializer xs = new XmlSerializer(GetType());
                    sw.WriteLine(value);
                    //xs.Serialize(fwrite, this);
                    sw.Close();
                    break;
                case "+|-":
                    textBox1.Text = (-(value)).ToString();
                    break;
                default:
                    break;        
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            value = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        { 

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("вы уверены, что хотите выйти?", "Закрытие калькулятора", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
