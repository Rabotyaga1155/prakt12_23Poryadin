using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prakt11_12_zad2
{
    public partial class Form1 : Form
    {
        Vektor vektor = new Vektor();

        public Form1()
        {
            InitializeComponent();

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x1 = 0, x2 = 0, x3 = 0;

                vektor.firstv1 = Int32.Parse(textBox1.Text);
                vektor.firstv2 = Int32.Parse(textBox2.Text);
                vektor.firstv3 = Int32.Parse(textBox3.Text);
                vektor.secondv1 = Int32.Parse(textBox4.Text);
                vektor.secondv2 = Int32.Parse(textBox5.Text);
                vektor.secondv3 = Int32.Parse(textBox6.Text);
                if (vektor.firstv1 <= 0 || vektor.firstv2 <= 0 || vektor.firstv3 <= 0 || vektor.secondv1 <= 0 || vektor.secondv2 <= 0 || vektor.secondv3 <= 0)
                {
                    MessageBox.Show("Неверный ввод");
                }
                else
                x1 = vektor.summa1();
                x2 = vektor.summa2();
                x3 = vektor.summa3();
                textBox7.Text = x1.ToString();
                textBox8.Text = x2.ToString();
                textBox9.Text = x3.ToString();
            }
            catch { MessageBox.Show("Неверный ввод"); }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int z1 = 0, z2 = 0, z3 = 0;
            try
            {
                vektor.firstv1 = Int32.Parse(textBox1.Text);
                vektor.firstv2 = Int32.Parse(textBox2.Text);
                vektor.firstv3 = Int32.Parse(textBox3.Text);
                vektor.secondv1 = Int32.Parse(textBox4.Text);
                vektor.secondv2 = Int32.Parse(textBox5.Text);
                vektor.secondv3 = Int32.Parse(textBox6.Text);
                if (vektor.firstv1 <= 0 || vektor.firstv2 <= 0 || vektor.firstv3 <= 0 || vektor.secondv1 <= 0 || vektor.secondv2 <= 0 || vektor.secondv3 <= 0)
                {
                    MessageBox.Show("Неверный ввод");
                }
                else
                    z1 = vektor.minus1();
                z2 = vektor.minus2();
                z3 = vektor.minus3();
                textBox7.Text = z1.ToString();
                textBox8.Text = z2.ToString();
                textBox9.Text = z3.ToString();
            }
            catch { MessageBox.Show("Неверный ввод"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int c1 = 0, c2 = 0;

                vektor.firstv1 = Int32.Parse(textBox1.Text);
                vektor.firstv2 = Int32.Parse(textBox2.Text);
                vektor.firstv3 = Int32.Parse(textBox3.Text);
                vektor.secondv1 = Int32.Parse(textBox4.Text);
                vektor.secondv2 = Int32.Parse(textBox5.Text);
                vektor.secondv3 = Int32.Parse(textBox6.Text);
                if (vektor.firstv1 <= 0 || vektor.firstv2 <= 0 || vektor.firstv3 <= 0 || vektor.secondv1 <= 0 || vektor.secondv2 <= 0 || vektor.secondv3 <= 0)
                {
                    MessageBox.Show("Неверный ввод");
                }
                else
                    c1 = vektor.dlina1();
                c2 = vektor.dlina2();
                textBox10.Text = c1.ToString();
                textBox11.Text = c2.ToString();
            }
            catch { MessageBox.Show("Неверный ввод"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int c1 = 0;

                vektor.firstv1 = Int32.Parse(textBox1.Text);
                vektor.firstv2 = Int32.Parse(textBox2.Text);
                vektor.firstv3 = Int32.Parse(textBox3.Text);
                vektor.secondv1 = Int32.Parse(textBox4.Text);
                vektor.secondv2 = Int32.Parse(textBox5.Text);
                vektor.secondv3 = Int32.Parse(textBox6.Text);
                if (vektor.firstv1 <= 0 || vektor.firstv2 <= 0 || vektor.firstv3 <= 0 || vektor.secondv1 <= 0 || vektor.secondv2 <= 0 || vektor.secondv3 <= 0)
                {
                    MessageBox.Show("Неверный ввод");
                }
                else
                    c1 = vektor.ygol();
                textBox12.Text = c1.ToString();
            }
            catch { MessageBox.Show("Неверный ввод"); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int c1 = 0;

                vektor.firstv1 = Int32.Parse(textBox1.Text);
                vektor.firstv2 = Int32.Parse(textBox2.Text);
                vektor.firstv3 = Int32.Parse(textBox3.Text);
                vektor.secondv1 = Int32.Parse(textBox4.Text);
                vektor.secondv2 = Int32.Parse(textBox5.Text);
                vektor.secondv3 = Int32.Parse(textBox6.Text);
                if (vektor.firstv1 <= 0 || vektor.firstv2 <= 0 || vektor.firstv3 <= 0 || vektor.secondv1 <= 0 || vektor.secondv2 <= 0 || vektor.secondv3 <= 0)
                {
                    MessageBox.Show("Неверный ввод");
                }
                else
                    c1 = vektor.scal9r();
                textBox13.Text = c1.ToString();
            }
            catch { MessageBox.Show("Неверный ввод"); }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
