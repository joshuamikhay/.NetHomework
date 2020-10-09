using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._2_CountingWinForm
{
    

    public partial class Form1 : Form
    {
        double result = 0.0;
        string opCode = "";

        public Form1()
        {
            InitializeComponent();
        }

        public double countingOperation(double a, double b)
        {
            opCode = textBox4.Text;
            switch(opCode)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / b;
                    break;
            }
            return Convert.ToDouble(result);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double firstValue = Double.Parse(this.textBox1.Text);
            double secondValue = Double.Parse(this.textBox2.Text);
            countingOperation(firstValue, secondValue);
            textBox3.Text = Convert.ToString(result);
        }
    }
}
