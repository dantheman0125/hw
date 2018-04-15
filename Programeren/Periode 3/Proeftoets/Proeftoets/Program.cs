using System;

namespace Proeftoets
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();
            for (; ; )
            {
                int txt = int.Parse(Console.ReadLine());
                Console.WriteLine(prog.Pi(txt));
            }

        }

        public double Pi(int n)
        {
            double deler = (n * 2.0) * ((n * 2) + 1) * ((n * 2) + 2);

            if (n == 1)
                return 4.0 / deler;
            else
                if (n % 2 == 0)
                return Pi(n - 1) - (4.0 / deler);
        else
            return Pi(n - 1) + (4.0 / deler);

        }
    }
}
