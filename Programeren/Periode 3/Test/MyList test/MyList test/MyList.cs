using System;
using System.Collections.Generic;
using System.Text;

namespace MyList_test
{
    class MyList<T>
    {
        private T item;
        private MyList<T> next;

        public MyList(T item)
        {
            this.item = item;
            next = null;
        }

        public T GetItem(int index)
        {
            if (index == 0)
            {
                return item;
            }
            else
            {
                return next.GetItem(index - 1);
            }
        }

        public MyList<T> GetNext()
        {
            return next;
        }

        public void Add (int i)
        {
            if (next == null)
            {
                next = new MyList<T>(item);
            }
            else
            {
                next.Add(i);
            }
        }
    }
}