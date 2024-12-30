using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        string option;
        int num1;
        int num2;
        int result;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + b13.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + b16.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + b4.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + b10.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + b5.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void b12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + b12.Text;
        }

        private void b14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + b14.Text;
        }

        private void b8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + b8.Text;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + b9.Text;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + b6.Text;
        }

        private void b2madilo_Click(object sender, EventArgs e)
        {
            option = "%";
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void bdivson_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void bsub_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void badd_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void b18_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(textBox1.Text);
            if (option.Equals("+"))
                result = num1 + num2;
            if (option.Equals("-"))
                result = num1 - num2;
            if (option.Equals("*"))
                result = num1 * num2;
            if (option.Equals("%"))
                result = num1 % num2;
            if (option.Equals("/"))
                result = num1 / num2;
            textBox1.Text = result + "";


        }
    }
}
  