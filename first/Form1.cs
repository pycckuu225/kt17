using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали товар");
                return;
            }

            if (textBox3.Text == "")
            {
                MessageBox.Show("Вы не ввели количество товара");
                return;
            }

            listBox1.Items.Add(comboBox1.SelectedItem + " — количество: " + textBox3.Text);
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали товар для удаления");
                return;
            }

            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Заполните оба поля");
                return;
            }

            comboBox1.Items.Add(textBox1.Text + " ; " + textBox2.Text + " р.");
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
