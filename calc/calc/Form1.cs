using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double x, y;
        public int a = 0;

        private void zero_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";

            }

            else {
                textBox1.Text += "0";
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            supplyno("1");
        }

        private void supplyno(string no )
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = no;
            }
            else
            {
                textBox1.Text += no;

            }
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Contains(".")){
                textBox1.Text += ".";
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            supplyno("2");
        }

        private void three_Click(object sender, EventArgs e)
        {
            supplyno("3");
        }

        private void four_Click(object sender, EventArgs e)
        {
            supplyno("4");
        }

        private void five_Click(object sender, EventArgs e)
        {
            supplyno("5");
        }

        private void six_Click(object sender, EventArgs e)
        {
            supplyno("6");
        }

        private void seven_Click(object sender, EventArgs e)
        {
            supplyno("7");
        }

        private void eight_Click(object sender, EventArgs e)
        {
            supplyno("8");
        }

        private void nine_Click(object sender, EventArgs e)
        {
            supplyno("9");
        }

        private void plus_Click(object sender, EventArgs e)
        {
            try
            {
                a = 1;
                x = Double.Parse(textBox1.Text);
                textBox1.Clear();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            switch(a){
                case 1:
                y = x + double.Parse(textBox1.Text);
                  textBox1.Text = y.ToString();
                  break;
                case 2:
                  y = x - double.Parse(textBox1.Text);
                  textBox1.Text = y.ToString();
                  break;
                case 3:
                  if (double.Parse(textBox1.Text) == 0)
                  {
                      MessageBox.Show("infinity");
                  }
                  else
                  {
                      y = x / double.Parse(textBox1.Text);
                      textBox1.Text = y.ToString();
                  }
                  break;
                case 4:
                  y = x * double.Parse(textBox1.Text);
                  textBox1.Text = y.ToString();
                  break;
            }
        
        
        }

        private void mul_Click(object sender, EventArgs e)
        {
            try
            {
                a = 4;
                x = Double.Parse(textBox1.Text);
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void div_Click(object sender, EventArgs e)
        {
            try
            {
                a = 3;
                x = Double.Parse(textBox1.Text);
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            try
            {
                a = 2;
                x = Double.Parse(textBox1.Text);
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
