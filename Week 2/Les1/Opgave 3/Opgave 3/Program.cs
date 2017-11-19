using System;

namespace Opgave_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[11];
            int invoer;

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("Voer een getal {0} in: ", i);
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Alle even getallen worden hieronder weergegeven.");
            invoer = Convert.ToInt32(Console.ReadLine());
                        
            foreach(int item in numbers)
            {
                if (item % 2 && item != 0)
            }

            Console.WriteLine(numbers[invoer]);
            Console.ReadLine();
        }
    }
}
