using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._2_CalculationWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result = 0.0;
            string opCode ="";
            listBox1.SelectedItem = opCode;
            double firstValue = Convert.ToDouble(this.textBox1.Text);
            double secondValue = Convert.ToDouble(this.textBox2.Text);
            switch (opCode)
            {
                case "+":
                    result = Convert.ToDouble( firstValue+ secondValue);
                    textBox3.Text = Convert.ToString(result);
                    break;
                case "-":
                    result = Convert.ToDouble(firstValue - secondValue);
                    textBox3.Text = Convert.ToString(result);
                    break;
                case "*":
                    result = Convert.ToDouble(firstValue * secondValue);
                    textBox3.Text = Convert.ToString(result);
                    break;
                case "/":
                    result = Convert.ToDouble(firstValue / secondValue);
                    textBox3.Text = Convert.ToString(result);
                    break;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
