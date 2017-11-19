using System;

namespace Opgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            int total = 0;
            for (int i = 0;i < 3; i++)
            {
                Console.WriteLine("Vul de getal in die u bij elkaar wilt op tellen?");
                numbers[i]= Convert.ToInt32(Console.ReadLine());
            }
            foreach (int getal in numbers)
            {
                total += getal;
            }
            Console.WriteLine("De som is: " + total);

            Console.ReadLine();
        }
    }
}
