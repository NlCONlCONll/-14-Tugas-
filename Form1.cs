using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14__Tugas
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {

            char char1 = Convert.ToChar(textBox1.Text);
            char char2 = Convert.ToChar(textBox2.Text);
            string input = tBoxInput.Text;
            char[] huruf = new char[78] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', };
            char[] inputArr = input.ToCharArray();
            

            int satu = 0;
            int dua = 0;

            for (int j = 0; j < 25; j++)
            {
                if (char1 == huruf[j])
                {
                    satu = j;
                }
            }
            for (int k = 0; k < 25; k++)
            {
                if (char2 == huruf[k])
                {
                    dua = k;
                }
            }

            int selisih = dua - satu;
            string output = "";
            for (int m = 0; m < inputArr.Length; m++)
            {
                for (int n = 0; n < 25; n++)
                {
                    if(inputArr[m] == huruf[n])
                    {
                        output = output + huruf[n+ 26 + selisih];
                    }
                }
            }
            labelOutput.Text = output;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelOutput_Click(object sender, EventArgs e)
        {
            
        }
    }
}
