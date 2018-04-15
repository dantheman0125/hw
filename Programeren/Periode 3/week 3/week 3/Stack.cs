using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3
{
    class Stack<T>
    {
        private T item;
        private Stack<T> next;

        public Stack (T item)
        {
            this.item = item;
            next = null;
        }

        public void push (T item)
        {
            if (next.IsEmpty())
            {
                next = new Stack<T>(item);
            }
            else
            {
                next.push(item);
            }
        }

        public T Pop()
        {
            T Item;
            if (next.IsEmpty())
            {
                Item = item;
                item = default(T);
                return Item; 
            }
            else
            {
                return next.Pop();
            }
        }

        public bool IsEmpty()
        {
            bool check = false;
            if ( item == null)
            {
                check=true;
            }
            return check;
        }
    }
}