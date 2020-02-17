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
    public partial class Form1 : Form
    {
        bool IsActive = true;
        double money;
        double counterMoney = 0;
        double winningmoney=0;

        string path = @"C:\Users\anokh\Documents\Visual Studio 2015\Projects\игровой автомат\игровой автомат\Resources\";
        Bitmap[] pictures;

        public Form1(string name, double money)
        {
            pictures = new Bitmap[4] { new Bitmap(@"C:\Users\anokh\Documents\Visual Studio 2015\Projects\игровой автомат\игровой автомат\Resources\1.jpg"), new Bitmap(@"C: \Users\anokh\Documents\Visual Studio 2015\Projects\игровой автомат\игровой автомат\Resources\2.jpg"), new Bitmap(@"C:\Users\anokh\Documents\Visual Studio 2015\Projects\игровой автомат\игровой автомат\Resources\3.jpg"), new Bitmap(@"C:\Users\anokh\Documents\Visual Studio 2015\Projects\игровой автомат\игровой автомат\Resources\4.jpg") };
            InitializeComponent();
            label1.Text = name;
            label2.Text =""+ money;
            this.money = money;
        }
        
        private void pusk_Click(object sender, EventArgs e)
        {
            time.Enabled = true;
            time2.Enabled = true;
            time3.Enabled = true;
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            button1.Enabled = false;
        }
        private void rate_Click(object sender, EventArgs e)
        {
            DoRate(numericUpDown1.Value);
            this.winningmoney = Convert.ToDouble(numericUpDown1.Value);
            if (Convert.ToDouble(label2.Text) <= 0)
            {
                DialogResult result = MessageBox.Show("Иди домой!" + MessageBoxButtons.OK);
                this.Hide();
            }
            button1.Enabled = true;
            button2.Enabled = true;
            
        }

        private void time_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int filename = rand.Next(1, 3);
            pictureBox1.Image = pictures[filename];
        }

        private void time2_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int filename = rand.Next(1, 3);
            pictureBox2.Image = pictures[filename];
        }

        private void time3_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int filename = rand.Next(1, 3);
            pictureBox3.Image = pictures[filename];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Enabled = false;
            timer1.Enabled = false;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time2.Enabled = false;
            timer2.Enabled = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            time3.Enabled = false;
            timer3.Enabled = false;
            winmoney();
            button1.Enabled = false;
        }
        public void DoRate(decimal counter)
        {
            counterMoney = Convert.ToDouble(counter);
            money = money - counterMoney;
            label2.Text = "" + money;
        }
        public void winmoney()
        {
            if ((pictureBox2.Image == pictureBox3.Image) && (pictureBox1.Image == pictureBox2.Image))
            {
                double winningmoney = counterMoney * 5;
                DialogResult result = MessageBox.Show("You win: " + winningmoney + "  " + MessageBoxButtons.OK);
                money = money + winningmoney;
                label2.Text = "" + money;
            }
            else
            if (pictureBox1.Image == pictureBox2.Image)
            {

                double winningmoney = counterMoney * 2;
                DialogResult result = MessageBox.Show("You win: " + winningmoney + "  " + MessageBoxButtons.OK );
                money = money + winningmoney;
                label2.Text = "" + money;
            }
            else
            if (pictureBox2.Image == pictureBox3.Image)
            {
                double winningmoney = counterMoney * 2;
                DialogResult result = MessageBox.Show("You win: " + winningmoney + "   " +MessageBoxButtons.OK );
                money = money + winningmoney;
                label2.Text = "" + money;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
    }

