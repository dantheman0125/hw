using System;
using System.Linq;

namespace Opgave_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double getal = 2;
            for (int i = 1; i < 10; i++)
            {
                getal *= 2;
            }
            Console.WriteLine(getal);
            Console.ReadLine();
        }
    }
}
