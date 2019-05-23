using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public abstract class Stack 
    {
        public abstract void Push(double value);
        public abstract double Pop();
        public abstract string Peek();
        public abstract bool HasMultipleVar();
    }
}