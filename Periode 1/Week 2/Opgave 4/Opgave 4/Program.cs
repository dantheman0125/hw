using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int[] b = new int[5];
            int[] c = new int[5];
            Random gen = new Random();
            for(; ; )
            {
                int j = 0;
                for (int i = 0; i < 5; i++)
                {
                    a[i] = gen.Next(0, 10);
                    b[i] = gen.Next(0, 10);
                    c[i] = a[i] + b[i];
                    j++;
                    Console.WriteLine("Som {0}: {1} + {2} = {3}", j, a[i], b[i], c[i]);
                }
                Console.ReadLine();

            }
        }
    }
}
