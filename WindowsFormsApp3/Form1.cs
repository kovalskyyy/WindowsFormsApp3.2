using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private int los;
        private int nrPR;
        private int liczba;
        private int nrPR_min = -1;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            if (radioButton1.Checked)
                los = rand.Next(0, 1000);
            else if (radioButton2.Checked)
                los = rand.Next(0, 100);
            else
                los = rand.Next(0, 10);

            nrPR = 1;
            textBox1.Text = "1";
            textBox2.Clear();
            button1.Enabled = false;
            panel1.BackColor = Control.DefaultBackColor;

        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            textBox1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            liczba = int.Parse(textBox2.Text);



            if (textBox2.Text == los.ToString())
            {
                panel1.BackColor = Color.FromArgb(255, 255, 0);

                if (nrPR_min == -1 || nrPR_min > nrPR)
                {
                    nrPR_min = nrPR;
                    label3.Text = nrPR_min.ToString();
                }
            }
            else
            {
                textBox1.Text = nrPR.ToString();
                nrPR++;
            }



            if (liczba > los)
            {
                label1.Text = "Mniej";
            }
            else if (liczba < los)
            {
                label1.Text = "Więcej";
            }
            else
            {
                label1.Text = "Trafione";
            }



        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                button1.Enabled = true;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                button1.Enabled = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                button1.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = checkBox1.Checked;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
