using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saaristo_Asg4_Binary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void labelResultsHex_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            radioButtonDecimal.Checked = false;
            radioButtonBoth.Checked = false;
            radioButtonHex.Checked = false;
            listBoxTestValues.SelectedIndex = -1;
            labelResultsDecimal.Text = "";
            labelResultsHex.Text = "";

        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            // labelresultshex.text = Total.ToString("X");
            int total = 0;
            if(checkBox1.Checked == true)
            {
                total = total + 1;
            }
            if (checkBox2.Checked == true)
            {
                total = total + 2;
            }
            if (checkBox3.Checked == true)
            {
                total = total + 4;
            }
            if (checkBox4.Checked == true)
            {
                total = total + 8;
            }
            if (checkBox5.Checked == true)
            {
                total = total + 16;
            }
            if (checkBox6.Checked == true)
            {
                total = total + 32;
            }
            if (checkBox7.Checked == true)
            {
                total = total + 64;
            }
            if (checkBox8.Checked == true)
            {
                total = total + 128;
            }
            if (radioButtonDecimal.Checked == true)
            {
                labelResultsDecimal.Text = total.ToString();
                labelResultsHex.Text = null;
            }
            if (radioButtonHex.Checked == true)
            {
                labelResultsHex.Text = total.ToString("X");
                labelResultsDecimal.Text = null;
            }
            if(radioButtonBoth.Checked == true)
            {
                labelResultsDecimal.Text = total.ToString();
                labelResultsHex.Text = total.ToString("X");
            }
        }

        private void listBoxTestValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            int presetValue = 0;
            if(listBoxTestValues.SelectedIndex > -1)
            {
                presetValue = int.Parse(listBoxTestValues.SelectedItem.ToString());
            }
            switch (presetValue)
            {
                case 1:
                    checkBox1.Checked = true;
                    break;
                case 2:
                    checkBox2.Checked = true;
                    break;
                case 4:
                    checkBox3.Checked = true;
                    break;
                case 8:
                    checkBox4.Checked = true;
                    break;
                case 16:
                    checkBox5.Checked = true;
                    break;
                case 32:
                    checkBox6.Checked = true;
                    break;
                case 64:
                    checkBox7.Checked = true;
                    break;
                case 128:
                    checkBox8.Checked = true;
                    break;
                case 255:
                    checkBox1.Checked = true;
                    checkBox2.Checked = true;
                    checkBox3.Checked = true;
                    checkBox4.Checked = true;
                    checkBox5.Checked = true;
                    checkBox6.Checked = true;
                    checkBox7.Checked = true;
                    checkBox8.Checked = true;
                    break;

            }
        }

        private void radioButtonDecimal_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
