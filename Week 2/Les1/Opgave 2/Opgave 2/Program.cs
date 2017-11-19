using System;

namespace Opgave_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int invoer;
            
            for (int i =1;i < 10; i++)
            {
                Console.WriteLine("Voer een getal {0} in: ", i);
                numbers[i]=Convert.ToInt32(Console.ReadLine());
                
            }
            Console.WriteLine("Welk getal wilt u weergeven?");
            invoer=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(numbers[invoer]);
            Console.ReadLine();
        }

    }
}
