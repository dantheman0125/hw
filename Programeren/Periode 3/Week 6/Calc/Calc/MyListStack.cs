using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class MyListStack : Stack
    {
        private string item = "";
        private MyListStack next;

        public MyListStack()
        {
            next = null;
        }

        public MyListStack(double value)
        {
            item += value;
            next = null;
        }

        public override void Push(double value)
        {
            if (item == "")
                item += value;
            else if (next == null && !empty()) 
                next = new MyListStack(value);
            else
                next.Push(value);
        }

        public override double Pop()
        {
            if (next != null && !empty())
                return next.Pop();
            else
            {
                double temp = Convert.ToDouble(item);
                item = "";
                return temp;
            }
        }

        public override string Peek()
        {
            string result = "";
            if (next != null && !next.empty())
                return result += next.Peek() + item + "\n";
            else
                return result = item + "\n";
        }

        public override bool HasMultipleVar()
        {
            return next != null && !next.empty();
        }

        private bool empty()
        {
            return item == "";
        }
    }
}
