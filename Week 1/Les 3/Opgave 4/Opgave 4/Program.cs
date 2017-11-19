using System;

namespace Opgave_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double km = 0;
            double liter = 0;
            double kilom = 0;
            double literr = 0;

            for (; ; )
            {
                Console.WriteLine("Hoeveel km heeft u gerenden sinds de vorige tankbeurt ");
                km = int.Parse(Console.ReadLine());
                kilom = kilom + km;

                Console.WriteLine("Hoeveel liter heeft u op die tankbeurt getankd ");
                liter = int.Parse(Console.ReadLine());
                literr = literr + liter;

                if (liter == 0)
                {
                    double average = kilom / literr;
                    double average100 = literr*100/kilom;
                    Console.WriteLine("U rijdt 1 op " + average + " en per 100km verbruikt u " + average100 + " Liter");
                    Console.ReadLine();
                    break;
                }
            }

            /*
            int totaal = int.Parse(Console.ReadLine());
            int[] liter = new int[totaal];
            int[] km = new int[totaal];
            int average = 0;
            int kilom = 0;
            int literr = 0;

            for (int i = 0; i < 999; i++)
            {
                Console.WriteLine("Hoeveel km heeft u gerenden sinds de vorige tankbeurt ", i + 1);
                km[i] = int.Parse(Console.ReadLine());
                kilom = kilom + km[i];

                Console.WriteLine("Hoeveel liter heeft u op die tankbeurt getankd ", i + 1);
                liter[i] = int.Parse(Console.ReadLine());
                literr = literr + liter[i];

                if (liter[i] == 0)
                {

                    average = (kilom / literr);
                    Console.WriteLine("Het gemiddelde is: 1/" + average);
                    Console.ReadLine();
                    break;

                }

            } 
            */
        }
    }
}