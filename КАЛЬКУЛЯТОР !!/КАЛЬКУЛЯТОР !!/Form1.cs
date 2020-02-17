using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КАЛЬКУЛЯТОР___
{
    public partial class Form1 : Form
    {
        Calc calculate;
        public Form1()
        {
            InitializeComponent();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            calculate.Save(Convert.ToDouble(textBox2.Text));
            calculate.Clear();
            
        }

        private void minus_Click(object sender, EventArgs e)
        {
            calculate.Save(Convert.ToDouble(textBox2.Text));
            calculate.Clear();
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            calculate.Save(Convert.ToDouble(textBox2.Text));
            calculate.Clear();
        }

        private void devision_Click(object sender, EventArgs e)
        {
            calculate.Save(Convert.ToDouble(textBox2.Text));
            calculate.Clear();
        }

        private void result_Click(object sender, EventArgs e)
        {
            
        }

        private void equally_Click(object sender, EventArgs e)
        {

        }
    }
}
