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

        public static List<int> input = new List<int>();
        private void btn_0_Click(object sender, EventArgs e)
        {
            if (textBoxOutput.Text != "0")
            {
                textBoxOutput.Text += "0";
            }
            else
            {
                textBoxOutput.Text = "0";
            }
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
            if (textBoxOutput.Text != "0")
            {
                textBoxOutput.Text += "2";
            }
            else
            {
                textBoxOutput.Text = "2";
            }
        }


        private void btn_3_Click(object sender, EventArgs e)
        {
            if (textBoxOutput.Text != "0")
            {
                textBoxOutput.Text += "3";
            }
            else
            {
                textBoxOutput.Text = "3";
            }
        }
        private void btn_4_Click(object sender, EventArgs e)
        {
             if (textBoxOutput.Text != "0")
             {
                 textBoxOutput.Text += "4";
             }
             else
             {
                 textBoxOutput.Text = "4";
             }
            
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (textBoxOutput.Text != "0")
            {
                textBoxOutput.Text += "5";
            }
            else
            {
                textBoxOutput.Text = "5";
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (textBoxOutput.Text != "0")
            {
                textBoxOutput.Text += "6";
            }
            else
            {
                textBoxOutput.Text = "6";
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (textBoxOutput.Text != "0")
            {
                textBoxOutput.Text += "7";
            }
            else
            {
                textBoxOutput.Text = "7";
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (textBoxOutput.Text != "0")
            {
                textBoxOutput.Text += "8";
            }
            else
            {
                textBoxOutput.Text = "8";
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (textBoxOutput.Text != "0")
            {
                textBoxOutput.Text += "9";
            }
            else
            {
                textBoxOutput.Text = "9";
            }
        }

        private void btn_koma_Click(object sender, EventArgs e)
        {
            if (textBoxOutput.Text != "0")
            {
                textBoxOutput.Text += ",";
            }
        }

        private void btn_plusminus_Click(object sender, EventArgs e)
        {

        }

        private void btn_persen_Click(object sender, EventArgs e)
        {
            input.Add(Convert.ToInt32(textBoxOutput.Text));
        }

        private void btn_akar_Click(object sender, EventArgs e)
        {
            input.Add(Convert.ToInt32(textBoxOutput.Text));
        }

        private void btn_pangkat_Click(object sender, EventArgs e)
        {
            input.Add(Convert.ToInt32(textBoxOutput.Text));
        }

        private void btn_pecahan_Click(object sender, EventArgs e)
        {
            input.Add(Convert.ToInt32(textBoxOutput.Text));
        }

        private void btn_bagi_Click(object sender, EventArgs e)
        {
            input.Add(Convert.ToInt32(textBoxOutput.Text));
        }

        private void btn_kali_Click(object sender, EventArgs e)
        {
            input.Add(Convert.ToInt32(textBoxOutput.Text));
        }

        private void btn_kurang_Click(object sender, EventArgs e)
        {
            input.Add(Convert.ToInt32(textBoxOutput.Text));
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            input.Add(Convert.ToInt32(textBoxOutput.Text));
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (textBoxOutput.Text.Length > 0)
            {
                textBoxOutput.Text = textBoxOutput.Text.Remove(textBoxOutput.Text.Length - 1, 1);
            }
            if (textBoxOutput.Text == "")
            {
                textBoxOutput.Text = "0";
            }
        }
    }
}
