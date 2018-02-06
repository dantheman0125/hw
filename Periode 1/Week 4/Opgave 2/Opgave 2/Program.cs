using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst;
            //2.6 deze loop heeft de errors verholpen
            for (; ; )
            {
                Console.WriteLine("Voer tekst in:");
                tekst = Console.ReadLine();
                if (tekst.Length < 3)
                {
                    Console.WriteLine("De tekst moet minimaal 3 karakters bevatten");
                    Console.ReadLine();
                }
                else{ break; }
            }
            DerdeLetter(tekst);
            Console.ReadLine();
        }

        public static void DerdeLetter (string tekst)
        {
            //2.1
            string thirdletter = tekst.Substring(2, 1);
            Console.WriteLine("De derde letter van het ingevoerde woord is: " + thirdletter);

            //2.2 Zonder Console WriteLine is het niet mogelijk als je een void gebruikt.

            //2.3
            string LetterN = "n";
            Console.WriteLine(LetterN);

            //2.4 Er wordt een error veroorzaakt, omdat er naar de derde letter wordt gezocht, maar die is er niet.
            //2.5 Waar welke waarde.
        }
    }
}