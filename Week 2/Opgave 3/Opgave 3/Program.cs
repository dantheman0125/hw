using System;

namespace Opgave_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            Console.WriteLine("Voer 10 getallen in   (Druk op Enter na elk getal)");

            for (int i = 0; i < 10; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("");
            Console.WriteLine("Alle even getallen worden hieronder weergegeven.");
            for (int j=0;j<10;j++)
            {
                if (numbers[j] % 2 == 0)
                {
                    Console.WriteLine( numbers[j]);
                }
            }
            Console.ReadLine();
        }
    }
}
