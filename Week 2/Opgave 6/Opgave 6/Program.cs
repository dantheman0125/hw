using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] temp = new int[4, 7] { { 15, 1, 2, 0, 20, 5, 7 }, { 6, 3, 0, 8, 9, 15, 7 }, { 2, 3, 5, 7, 8, 9, 10 }, { 11, 13, 16, 13, 15, 11, 7 } };
            int totaal = 0, ave = 0, count = 0;
            Console.WriteLine("Maand: April");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    totaal += temp[i, j];
                }
                ave = totaal / 7;
                totaal = 0;
                count++;
                Console.WriteLine("De gemiddelde temperatuur van week {0} is: {1}", count, ave);
            }
            Console.ReadLine();
        }
    }
}