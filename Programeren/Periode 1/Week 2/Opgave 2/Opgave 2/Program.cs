using System;

namespace Opgave_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int invoer;

            Console.WriteLine("Voer 9 getallen in   (Druk op Enter na elk getal)");
            for (int i =1;i < 10; i++)
            {
                numbers[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Welk van de 9 getallen wilt u weergeven");
            invoer =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(numbers[invoer]);
            Console.ReadLine();
        }
    }
}