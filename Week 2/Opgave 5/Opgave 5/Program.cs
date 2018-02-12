using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vul de naam in van de personen");
            string[] names = new string[99];
            int j = 0;
            for (int i = 0; i < 99; i++)
            {
                names[i] = (Console.ReadLine());
                j++;
                if (names[i]=="") { break; }
            }
            j--;
            Console.WriteLine("Er gaan {0} mensen mee",j);
            Console.ReadLine();
        }
    }
}
