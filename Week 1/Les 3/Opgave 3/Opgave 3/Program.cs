using System;

namespace Opgave_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] f_ = new double[10];
            f_[0] = 0;
            f_[1] = 1;
            Console.WriteLine("De rij van Fibonacci");
            Console.WriteLine(f_[0]);
            Console.WriteLine(f_[1]);
            for (int n = 2; n<10; n++)
            {
                f_[n] = f_[n - 1] + f_[n - 2];
                Console.WriteLine(f_[n]);
            }
            Console.ReadLine();
        }
    }
}