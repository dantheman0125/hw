using System;
using System.Linq;

namespace Opgave1v2
{
    class Program
    {
        static void Main(string[] args)
        {
            double getal=0, max=0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Voer een getal in");
                getal = Convert.ToDouble(Console.ReadLine());
                if (max<getal)
                {
                    max = getal;
                }
            }
            Console.WriteLine("het hoogste getal is: "+max);
            Console.ReadLine();
        }
    }
}