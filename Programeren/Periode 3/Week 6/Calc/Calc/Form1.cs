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
        Stack main = new ListStack();


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
            TBinput.Text += "1";
        }

        private void B2_Click(object sender, EventArgs e)
        {
            TBinput.Text += "2";
        }

        private void B3_Click(object sender, EventArgs e)
        {
            TBinput.Text += "3";
        }

        private void B4_Click(object sender, EventArgs e)
        {
            TBinput.Text += "4";
        }

        private void B5_Click(object sender, EventArgs e)
        {
            TBinput.Text += "5";
        }

        private void B6_Click(object sender, EventArgs e)
        {
            TBinput.Text += "6";
        }

        private void B7_Click(object sender, EventArgs e)
        {
            TBinput.Text += "7";
        }

        private void B8_Click(object sender, EventArgs e)
        {
            TBinput.Text += "8";
        }

        private void B9_Click(object sender, EventArgs e)
        {
            TBinput.Text += "9";
        }

        private void B0_Click(object sender, EventArgs e)
        {
            if (TBinput.Text != "0")
            {
                TBinput.Text += "0";
            }
        }

        private void Bminus_Click(object sender, EventArgs e)
        {
            if (TBinput.Text == "")
                TBinput.Text = "-";
            else if (TBinput.Text == "-")
                TBinput.Text = "";
        }

        private void Bdot_Click(object sender, EventArgs e)
        {
            if (TBinput.Text == "")
                TBinput.Text ="0.";
            else if (TBinput.Text.Contains(".")){ }
            else
                TBinput.Text += ".";
        }

        private void Bplus_Click(object sender, EventArgs e)
        {
            Calc("+");
        }

        private void Bmin_Click(object sender, EventArgs e)
        {
            Calc("-");
        }

        private void Bmultiply_Click(object sender, EventArgs e)
        {
            Calc("*");
        }

        private void Bdevide_Click(object sender, EventArgs e)
        {
            Calc("/");
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
            string input = TBinput.Text;
            //om een crash te voorkomen een if-statement, vanwege de out of bounds
            if (input.Length > 0)
            {
                input = input.Remove(input.Length - 1);
            }
            else if(input.Length == 0) { input = string.Empty; }
            TBinput.Text = input;
        }

        private void Bpush_Click(object sender, EventArgs e)
        {
            main.Push(Convert.ToDouble(TBinput.Text));
            TBinput.Text = string.Empty;
            StackBox.Text = main.Peek();
        }

        private void Calc(string opperator)
        {
            if (main.HasMultipleVar())
            {
                double num1 = main.Pop(), num2 = main.Pop();
                switch (opperator)
                {
                    case "+":
                        main.Push(num2 + num1);
                        break;
                    case "-":
                        main.Push(num2 - num1);
                        break;
                    case "*":
                        main.Push(num2 * num1);
                        break;
                    case "/":
                        if (num1 != 0)
                            main.Push(num2 / num1);
                        else
                            main.Push(0);
                        break;
                }
                StackBox.Text = main.Peek();
            }
        }

        private void RBarray_CheckedChanged(object sender, EventArgs e)
        {
            CleanUp();
        }

        private void RBlist_CheckedChanged(object sender, EventArgs e)
        {
            CleanUp();
        }

        private void RBmylist_CheckedChanged(object sender, EventArgs e)
        {
            CleanUp();
        }

        private int Checker()
        {
            if (RBarray.Checked)
                return 1;
            else if (RBlist.Checked)
                return 2;
            else if (RBmylist.Checked)
                return 3;
            else
                TBinput.Text = "How did you do this?";
                return 4;
        }

        private void CleanUp()
        {
            StackBox.Clear();
            switch (Checker())
            {
                case 1:
                    main = new ArrayStack();
                    //Destroy ListStack();
                    //Destroy MyListStack();
                    break;
                case 2:
                    //Destroy ArrayStack();
                    main = new ListStack();
                    //Destroy MyListStack();
                    break;
                case 3:
                    //Destroy ArrayStack();
                    //Destroy ListStack();
                    main = new MyListStack();
                    break;
            }
        }
    }
}