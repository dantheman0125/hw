using System;

namespace MyList_test
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>(3);
            list.Add(-2);
            list.Add(42);
            list.Add(0);

            //vraag het eerste item op
            int a = list.GetItem(0);
            //vraag het derde item op
            int b = list.GetItem(2);


            Console.WriteLine(a);
            Console.WriteLine(b);
            try
            {
                int c = list.GetItem(42);
                Console.WriteLine(c);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("index out of bounds");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error! ");
            }

            Console.ReadLine();
        }
    }
}