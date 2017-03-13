using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Brain brain = new Brain();
        int k = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Num(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox1.Text += btn.Text;
        }

        private void Op(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            k++;
            brain.n1 = double.Parse(textBox1.Text);
            textBox1.Text = "";

            if (btn.Text.Equals("+") && k == 2)
            {
                k = 0;
                brain.n2 = double.Parse(textBox1.Text);
                textBox1.Text = brain.Plus().ToString();
            }
              
        }
    }
}
