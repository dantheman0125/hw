using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HP_calculator
{
    public partial class Form1 : Form
    {
        Label[] labelarray = new Label[2];
        Stack main = new ListStack();

        public Form1()
        {          
            formlayout();                     
        }

        void formlayout()
        {
            int i = 0;

            this.ClientSize = new System.Drawing.Size(275, 350);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.KeyPreview = true;
            this.KeyPress += Key_Press;
            this.Text = "Calculatorski";

            Button[] buttonarray = new Button[18];
            int bsize = 53, fmax = 230, fieldx = 12, fieldy = 67;
            string[] buttontext = new string[16] { "7", "4", "1", "(-)", "8", "5", "2", "0", "9", "6", "3", ".", "/", "*", "-", "+" };          

            for (int w = 0; w < 4; w++)
            {
                for (int l = 0; l < 4; l++)
                {
                    buttonarray[i] = new Button();
                    buttonarray[i].Size = new Size(bsize, bsize);
                    buttonarray[i].Name = "button" + (i + 1);
                    buttonarray[i].Text = buttontext[i];
                    buttonarray[i].Font = new Font("Microsoft Sans Serif", 20);
                    buttonarray[i].MouseClick += button_Click;
                    buttonarray[i].Location = new Point(fieldx + w * (bsize + (fmax - 4 * bsize) / 3), fieldy + l * (bsize + (fmax - 4 * bsize) / 3));
                    buttonarray[i].TabStop = false;
                    Controls.Add(buttonarray[i]);
                    i++;
                }
            }

            buttonarray[16] = new Button();
            buttonarray[16].Location = new Point(248, 12);
            buttonarray[16].Name = "button17";
            buttonarray[16].Size = new System.Drawing.Size(21, 21);
            buttonarray[16].Text = ">";
            buttonarray[16].Click += button_Click;
            Controls.Add(buttonarray[16]);

            buttonarray[17] = new Button();
            buttonarray[17].Location = new System.Drawing.Point(248, 35);
            buttonarray[17].Name = "button18";
            buttonarray[17].Size = new System.Drawing.Size(21, 21);
            buttonarray[17].Text = "<";
            buttonarray[17].Click += button_Click;
            Controls.Add(buttonarray[17]);

            //Label[] labelarray = new Label[2];

            labelarray[0] = new Label();
            labelarray[0].Size = new Size(230, 44);
            labelarray[0].Name = "label1";
            labelarray[0].Text = "";
            labelarray[0].Font = new Font("Microsoft Sans Serif", 26);
            labelarray[0].Location = new Point(12, 12);
            labelarray[0].BorderStyle = BorderStyle.FixedSingle;
            labelarray[0].BackColor = System.Drawing.Color.Black;
            labelarray[0].ForeColor = System.Drawing.Color.Goldenrod;
            labelarray[0].TextAlign = System.Drawing.ContentAlignment.BottomRight;

            Controls.Add(labelarray[0]);

            labelarray[1] = new Label();
            labelarray[1].Size = new Size(200, 280);
            labelarray[1].Name = "label2";
            labelarray[1].Text = "";
            labelarray[1].Font = new Font("Microsoft Sans Serif", 10);
            labelarray[1].Location = new Point(300, 12);
            labelarray[1].BackColor = System.Drawing.Color.Gray;
            labelarray[1].BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(labelarray[1]);

            RadioButton[] radioarray = new RadioButton[3];

            radioarray[0] = new RadioButton();
            radioarray[0].Text = "ArrayStack";
            radioarray[0].Location = new Point(520, 12);
            radioarray[0].CheckedChanged += stackselect;
            Controls.Add(radioarray[0]);

            radioarray[1] = new RadioButton();
            radioarray[1].Text = "ListStack";
            radioarray[1].Location = new Point(520, 32);
            radioarray[1].Checked = true;
            radioarray[1].CheckedChanged += stackselect;
            Controls.Add(radioarray[1]);

            radioarray[2] = new RadioButton();
            radioarray[2].Text = "MyListStack";
            radioarray[2].Location = new Point(520, 52);
            radioarray[2].CheckedChanged += stackselect;
            Controls.Add(radioarray[2]);

            CheckBox checkbox = new CheckBox();
            checkbox.Text = "Show Stack";
            checkbox.Location = new Point(12, 320);
            checkbox.CheckedChanged += stackshow;
            Controls.Add(checkbox);
        }

        private void button_Click(object sender, EventArgs e)
        {
            String key = (sender as Button).Text;
            String current = labelarray[0].Text;

            if (int.TryParse((sender as Button).Text, out int i))
                labelarray[0].Text = current + i;

            else if (key == "." && current != "" && !(current.Contains(".")))
                labelarray[0].Text = current + ",";

            else if (key == "(-)" && (current != "" && current != "-"))
            {
                if (!(current.Contains("-")))
                    labelarray[0].Text = "-" + current;
                else
                    labelarray[0].Text = current.Trim('-');
            }

            else if (key == ">" && (current != "" && current != "-"))
            {
                main.Push(Convert.ToDouble(current));
                labelarray[0].Text = "";
                labelarray[1].Text = main.Show();
            }

            else if (key == "<" && (current != "" && current != "-"))
                labelarray[0].Text = current.Remove(current.Length - 1);

            else if (main.ContainsTwo() && (key == "+" || key == "/" || key == "*" || key == "-"))
            {
                Double value1 = main.Pop(), value2 = main.Pop();
                switch(key)
                {
                    case "+":
                        main.Push(value2 + value1);
                        break;
                    case "-":
                        main.Push(value2 - value1);
                        break;
                    case "/":
                        main.Push(value2 / value1);
                        break;
                    case "*":
                        main.Push(value2 * value1);
                        break;
                    default:
                        break;
                }
                labelarray[1].Text = main.Show();
            }
        }

        private void Key_Press(object sender, KeyPressEventArgs e)
        {
            String key = e.KeyChar.ToString();
            int key2 = e.KeyChar;
            String current = labelarray[0].Text;

            if (int.TryParse(key, out int i))
                labelarray[0].Text = current + e.KeyChar.ToString();
            
            else if(key == "." && current != "" && !(current.Contains(".")))
                labelarray[0].Text = current + ",";

            else if(key2 == (char)Keys.Enter && current != "" && current != "-")
            {
                main.Push(Convert.ToDouble(current));
                labelarray[0].Text = "";
                labelarray[1].Text = main.Show();
            }

            else if (key2 == (char)Keys.Back && current != "")
                labelarray[0].Text = current.Remove(current.Length - 1);

            else if (main.ContainsTwo() && (key == "+" || key == "/" || key == "*" || key == "-"))
            {
                Double value1 = main.Pop(), value2 = main.Pop();
                switch (key)
                {
                    case "+":
                        main.Push(value2 + value1);
                        break;
                    case "-":
                        main.Push(value2 - value1);
                        break;
                    case "/":
                        main.Push(value2 / value1);
                        break;
                    case "*":
                        main.Push(value2 * value1);
                        break;
                    default:
                        break;
                }
                labelarray[1].Text = main.Show();
            }
        }

        private void stackselect(object sender, EventArgs e)
        {
            main = null;

            if ((sender as RadioButton).Checked == true && (sender as RadioButton).Text == "ArrayStack")             
                main = new ArrayStack();
            else if ((sender as RadioButton).Checked == true && (sender as RadioButton).Text == "ListStack")
                main = new ListStack();
            else if ((sender as RadioButton).Checked == true && (sender as RadioButton).Text == "MyListStack")
                main = new MyListStack();
            labelarray[1].Text = "";
        }
        
        private void stackshow(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked == true)
                this.ClientSize = new System.Drawing.Size(620, 350);
            else
                this.ClientSize = new System.Drawing.Size(275, 350);
        }
    }
}