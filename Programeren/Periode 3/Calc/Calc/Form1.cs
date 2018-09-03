using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        char operation;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TBinput.Text = string.Empty;
        }

        private void B1_Click(object sender, EventArgs e)
        {
            TBinput.Text = input += "1";
        }

        private void B2_Click(object sender, EventArgs e)
        {
            TBinput.Text = input += "2";
        }

        private void B3_Click(object sender, EventArgs e)
        {
            TBinput.Text = input += "3";
        }

        private void B4_Click(object sender, EventArgs e)
        {
            TBinput.Text = input += "4";
        }

        private void B5_Click(object sender, EventArgs e)
        {
            TBinput.Text = input += "5";
        }

        private void B6_Click(object sender, EventArgs e)
        {
            TBinput.Text = input += "6";
        }

        private void B7_Click(object sender, EventArgs e)
        {
            TBinput.Text = input += "7";
        }

        private void B8_Click(object sender, EventArgs e)
        {
            TBinput.Text = input += "8";
        }

        private void B9_Click(object sender, EventArgs e)
        {
            TBinput.Text = input += "9";
        }

        private void B0_Click(object sender, EventArgs e)
        {
            if (input != "0")
            {
                TBinput.Text = input += "0";
            }
        }

        private void Bminus_Click(object sender, EventArgs e)
        {
            if (input == string.Empty)
            {
                TBinput.Text = input = "-";
            }
            else if ( input == "-")
            {
                TBinput.Text = input = string.Empty;
            }
        }

        private void Bdot_Click(object sender, EventArgs e)
        {
            if (input == string.Empty)
            {
                TBinput.Text = input = "0.";
            }
            else if (input.Contains("."))
            { }
            else
            {
                TBinput.Text = input += ".";
            }
        }

        private void Bplus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void Bmin_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void Bmultiply_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void Bdevide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        /// <summary>
        /// De visible staat gelijk aan de CBview.checked. 
        /// Dit kan aangezien de Checked gelijk staat als een Boolean.
        /// Dus als CBview = false, visible = false.
        /// en andersom natuurlijk. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CBview_CheckedChanged(object sender, EventArgs e)
        {
            StackBox.Visible = CBview.Checked;
            RBarray.Visible = CBview.Checked;
            RBlist.Visible = CBview.Checked;
            RBmylist.Visible = CBview.Checked;
        }

        private void Bbackspace_Click(object sender, EventArgs e)
        {
            TBinput.Text = "";
            //om een crash te voorkomen, vanwege out of bounds.
            if(input.Length > 0)
            {
                input = input.Remove(input.Length - 1);
            }
            else if(input.Length == 0) { input = string.Empty; }
            TBinput.Text = input;
        }

        private void Bpush_Click(object sender, EventArgs e)
        {
            TBinput.Text = input = string.Empty;
            string operand1 = string.Empty;
        }

        private void BCalc_Click(object sender, EventArgs e)
        {
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(input, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                TBinput.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                TBinput.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                TBinput.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    TBinput.Text = result.ToString();
                }
                else
                {
                    TBinput.Text = "Math Error!";
                }
            }
            input = string.Empty;
            operand1 = string.Empty;
            result = 0.0;
        }
    }
}