using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class FormKalkulator : Form
    {
        public FormKalkulator()
        {
            InitializeComponent();
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (nol == 1 )
            {

            }
        }
        public static int nol = 0;
        private void btn_0_Click(object sender, EventArgs e)
        {
            nol = 1;
            textBoxOutput.Text += "0";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (textBoxOutput.Text != "0")
            {
                textBoxOutput.Text += "1";
            }
            else
            {
                textBoxOutput.Text = "1";
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += "9";
        }
    }
}
