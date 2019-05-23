using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class ArrayStack: Stack
    {
        private int top = -1;
        private const int volume = 999;
        private double[] Stacked = new double[volume];

        public override void Push(double value)
        {
            Stacked[++top] = value;
        }

        public override double Pop()
        {
            return Stacked[top--];
        }

        public override string Peek()
        {
            string result = "";
            for (int i = top; i > -1; i--)
            {
                result += Stacked[i] + "\n";
            }
            return result;
        }

        public override bool HasMultipleVar()
        {
            return top >= 1;
        }
    }
}
