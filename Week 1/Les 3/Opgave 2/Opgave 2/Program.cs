using System;
using System.Linq;

namespace Opgave_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double uitkomst=0;


            for (int i = 0; i < 11; i++)
            {
                uitkomst= (Math.Pow(2, i));
            }
            Console.WriteLine("2 tot de macht 10 is: " + uitkomst);
            Console.ReadLine();

        }
    }
}
