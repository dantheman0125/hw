using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class ListStack : Stack
    {
        private List<double> Stacked = new List<double>();

        public override void Push(double value)
        {
            Stacked.Add(value);
        }

        public override double Pop()
        {
            double temp = Stacked.Last();
            Stacked.RemoveAt(Stacked.Count()-1);
            return temp;
        }

        public override string Peek()
        {
            string result = "";
            foreach (double item in Stacked){
                result += item + "\n";
            }
            return result;
        }

        public override bool HasMultipleVar()
        {
            return Stacked.Count() >= 2;
        }
    }
}