using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodPOSSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double friesp = 80.0, burgerp = 150.0, pizzap = 200.0, pastap = 180.0, noodlesp = 120.0, swarmap = 90.0;
        double cokep = 40.0, sprep = 40.0, fantep = 40.0, chocoshakep = 140.0, mintshakep = 100.0, strawshakep = 120.0;
        double friestp, burgertp, pizzatp, pastatp, noodlestp, swarmatp, coketp, spretp, fantetp, chocoshaketp, mintshaketp, strawshaketp, tax, total;


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frenchFries_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
