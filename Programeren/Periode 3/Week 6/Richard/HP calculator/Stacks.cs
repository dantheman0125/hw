using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

namespace HP_calculator
{
    public abstract class Stack
    {
        public abstract void Push(Double item);
        public abstract Double Pop();
        public abstract bool ContainsTwo();
        public abstract string Show();
    }

    class ArrayStack : Stack
    {
        private double[] array = new double[32];
        private int top = -1;

        public override void Push(double item)
        {
            array[top + 1] = item;
            top++;
        }

        public override double Pop()
        {
            double item = array[top];
            top--;
            return item;
        }

        public override bool ContainsTwo()
        {
            return top >= 1;
        }

        public override string Show()
        {
            string result = "";
            for (int i = top; i != -1; i--)
            {
                result = result + array[i] + Environment.NewLine;
            }
            return result;
        }
    }

    class ListStack : Stack
    {
        private List<double> list = new List<Double>();

        public override void Push(double item)
        {
            list.Add(item);
        }

        public override double Pop()
        {
            double item = list.ElementAt(list.Count() - 1);
            list.RemoveAt(list.Count() - 1);
            return item;
        }

        public override bool ContainsTwo()
        {
            return list.Count() >= 2;
        }

        public override string Show()
        {
            string result = "";
            for (int i = list.Count - 1; i != -1; i--)
            {
                result = result + list[i] + Environment.NewLine;
            }
            return result;
        }
    }

    class MyListStack : Stack
    {
        private string item = "";
        private MyListStack next;

        public MyListStack()
        {
            next = null;
        }

        public MyListStack(Double i)
        {
            item = Convert.ToString(i);
            next = null;
        }

        public override void Push(double i)
        {
            if (item == "")
                item = Convert.ToString(i);
            else if (next == null && empty() == false)
                next = new MyListStack(i);
            else
                next.Push(i);
        }

        public override double Pop()
        {
            if (next != null && next.empty() != true)
                return next.Pop();
            else
            {
                string temp = item;
                item = "";
                return Convert.ToDouble(temp);
            }
        }

        public override bool ContainsTwo()
        {
            return (next != null && next.empty() != true);
        }

        public override string Show()
        {
            string result = "";
            if(next != null && next.empty() != true)
                return result += next.Show() + item + Environment.NewLine;
            else
                return result = item + Environment.NewLine;
        }

        public bool empty()
        {
                return item == "";
        }
    }
}
