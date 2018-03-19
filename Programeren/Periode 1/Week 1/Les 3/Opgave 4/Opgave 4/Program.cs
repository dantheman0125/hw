using System;

namespace Opgave_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double km = 0, liter = 0, totalkm = 0, totalliter = 0;
            //double literr = 0;

            for (; ;)
            {
                Console.WriteLine("Hoeveel km heeft u gereden sinds de vorige tankbeurt ");
                km = int.Parse(Console.ReadLine());
                totalkm += km;

                Console.WriteLine("Hoeveel liter heeft u op die tankbeurt getankd ");
                liter = int.Parse(Console.ReadLine());
                totalliter += liter;

                if (liter == 0)
                {
                    double average1 = totalkm / totalliter;
                    double average2 = totalliter * 100 / totalkm;
                    Console.WriteLine("U rijdt 1 op {0} en per 100km verbruikt u {1} Liter", average1,average2);
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}