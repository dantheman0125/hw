using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les1_Opgave01
{
    public partial class Rente : Form
    {
        Double answer;

        public Rente()
        {
            InitializeComponent();
        }


        private void calcbut_Click(object sender, EventArgs e)
        {
            Answer2.Text = "";
            double bedrag = Convert.ToDouble(bedragbox.Text);
            double rente = Convert.ToDouble(rentebox.Text);
            Answer1.Text = "Na 0 jaar: "+bedrag;
            for(int i = 1; i < 11; i++)
            {
                bedrag = bedrag * (rente * 0.01 + 1);
                Answer2.Text += "Na "+i+" jaar: " +Convert.ToString(bedrag)+System.Environment.NewLine;
            }

        }

        private void Rente_Load(object sender, EventArgs e)
        {

        }
    }
}
