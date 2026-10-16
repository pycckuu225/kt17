using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        int sec = 0;
        int min = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            if (sec == 60)
            {
                sec = 0;
                min++;
            }

            label1.Text = min.ToString("00");
            label3.Text = sec.ToString("00");
            label2.Visible = sec % 2 == 0;

            if (min < 4)
            {
                pictureBox1.BackgroundImage = Properties.Resources.gif;
            }
            else if (min < 8)
            {
                pictureBox1.BackgroundImage = Properties.Resources._1_13b07b8a;
            }
            else if (min < 15)
            {
                pictureBox1.BackgroundImage = Properties.Resources.IThub_school_6;
            }
            else if (min < 18)
            {
                pictureBox1.BackgroundImage = Properties.Resources._24_main;
            }
            else if (min < 20)
            {
                pictureBox1.BackgroundImage = Properties.Resources.gif__1_;
            }
            else
            {
                pictureBox1.BackgroundImage = Properties.Resources.gif;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Start")
            {
                timer1.Start();
                button1.Text = "Stop";
                button1.BackColor = Color.Red;
            }
            else
            {
                timer1.Stop();
                button1.Text = "Start";
                button1.BackColor = Color.Green;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            button2.Text = "Ускорить";
            button2.BackColor = SystemColors.Control;
        }
    }
}
