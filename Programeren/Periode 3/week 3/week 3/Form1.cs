using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week_3
{
    public partial class Form : System.Windows.Forms.Form
    {
        private int input;
        private string txt;


        public Form()
        {
            InitializeComponent();
        }

        public bool Check()
        {
            bool Check = int.TryParse(inputtxt.Text, out input);
            return Check;
        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            if (Check())
            {

            }
            else
            {
                txt = inputtxt.Text;
                Stack<string> stack = new Stack<string>();
            }
        }

        private void PopBut_Click(object sender, EventArgs e)
        {

        }
    }
}