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
        Double memory_num = 0;
        string mem = "";
        Double memory = 0;
        Double memory_sum = 0;
        string special_op = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (operation_pressed))
                textBox1.Clear();

            operation_pressed = false;//позволяет вводить две или более цифр
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;//отлавливание цифр
        }

        private void operation(object sender, EventArgs e)
        {               
            Button b = (Button)sender;
            operations = b.Text;
            value = Double.Parse(textBox1.Text);
            operation_pressed = true;//позволяет стереть первое число
            equation.Text = value + " " + operations;
        }

        private void button17_Click(object sender, EventArgs e)//кнопка СЕ
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
                case "sqrt(x)":
                    textBox1.Text = (Math.Sqrt(value)).ToString();
                    break;
                case "x^n":
                    double pow = 1;
                    for (int i = 1; i <= Double.Parse(textBox1.Text); i++)
                    {
                        pow *= value;
                    }
                    textBox1.Text = (pow).ToString();
                    break;
                default:
                    break;        
            }
        }

        private void button18_Click(object sender, EventArgs e)//кнопка С
        {
            textBox1.Clear();
            equation.Text = "";
            value = 0;
            textBox1.Text = "0";
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
            DialogResult dr = MessageBox.Show("Вы уверены, что хотите выйти?", "Закрытие калькулятора", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
        private void memory_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            else 
                textBox1.Text = "0";
        }

        private void memory_op(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            mem = b.Text;
            memory = Double.Parse(textBox1.Text);
            switch (mem)
            {
                case "MS":
                    memory_num = memory;
                    memory_text.Text = (memory).ToString();
                    break;
                case "M+":
                    memory_sum = Double.Parse(textBox1.Text);
                    memory_text.Text = (Double.Parse(memory_text.Text) + memory_sum).ToString();
                    break;
                case "MR":
                    textBox1.Text = memory_text.Text;
                    break;
                case "MC":
                    memory_text.Text = " ";
                    break;
                default:
                    break;
            }
        }

        private void special_operation(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            special_op = b.Text;
            value = Double.Parse(textBox1.Text);
            switch (special_op)
            {
                case "1/x":
                    textBox1.Text = (1 / value).ToString();
                    break;
                case "x^2":
                    textBox1.Text = (value * value).ToString();
                    break;
                case "%":
                    textBox1.Text = ((value / 100.0) * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "+|-":
                    textBox1.Text = (-(value)).ToString();
                    break;
                case "n!":
                    int result = 1;
                    for (int i = 1; i <= value; i++)
                    {
                        result *= i;
                    }
                    textBox1.Text = (result).ToString();
                    break;
                /*case "x^n":
                    textBox1.Text = Math.Pow(value, Double.Parse(textBox1.Text)).ToString();
                    break;*/
                default:
                    break;
            }
        }

        private void dot(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
            }
            else return;
        }
    }
}
