using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace игровой_автомат
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            double money = Convert.ToDouble(textBox2.Text);
            Form form = new Form1(name,money);
            form.Show();
            this.Hide();  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void money_Click(object sender, EventArgs e)
        {

        }
    }
}
