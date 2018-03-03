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
            int k = 1;
            Console.WriteLine("hoeveel mensen zitten er in de klas?");
            k = int.Parse(Console.ReadLine());

            Console.WriteLine("vul de naam in van de personen");
            string[] names = new string[k];

            for (int i = 0; i < k; i++)
            {
                names[i] = (Console.ReadLine());
                if (names[i]=="") { break; }
            }
            Console.ReadLine();
        }
    }
}
