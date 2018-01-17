using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("Opgave 1.1 & 1.2");
                Console.WriteLine("");
                Console.WriteLine("schrijf een woord");
                string word = Console.ReadLine();

                if (word.Length % 2 != 0)
                {
                    Console.WriteLine("De middelste letter van het opgegeven woord is de letter: " + middleChar(word));
                }

                else
                {
                    Console.WriteLine("De middelste letters van het opgegeven woord zijn de letters: " + middleChars(word));
                }

                Console.ReadLine();
                Console.Clear();
                
                Console.WriteLine("Opgave 1.3 t/m 1.5");
                Console.WriteLine("");
                Console.WriteLine("opgeteld van 1 tot 100: " + result1());
                Console.WriteLine(result2());
                Console.WriteLine(result3());
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Opgave 1.6");
                Console.WriteLine("");
                Console.WriteLine("Voer tekst in");
                string txt = Console.ReadLine();
                Console.WriteLine("De opgegeven tekst bevat {0} woorden",wordcounter(txt));
                Console.ReadLine();
                Console.Clear();
            }
        }

        public static string middleChar(string word)
        {

            int wordlenght = word.Length / 2;
            string mid = word.Substring(wordlenght, 1);
            
            return mid;
        }

        public static string middleChars(string word)
        {
            int wordlenght = word.Length / 2 - 1;
            string mid = word.Substring(wordlenght, 2);
            return mid;
        }

        public static double result1()
        {
            double Result=0;

            for (int i = 1;i<101; i++)
            {
                Result += i;
            }
            return Result;
        }
        
        public static string result2()
        {
            double Result = 0;
            Random random = new Random();
            int randomNumber = random.Next(1, 1000);

            for (int i = 1; i < randomNumber; i++)
            {
                Result += i;
            }

            string resulttxt = "opgeteld van 1 tot " + randomNumber + ": " + Result;
            return resulttxt;
        }

        public static string result3()
        {
            double Result = 0;
            String resulttxt = "";
            Random random = new Random();
            int NotInUse = random.Next(1, 1000);
            int randomNumber = random.Next(1, 1000);
            int randomNumber2 = random.Next(1, 1000);

            if (randomNumber < randomNumber2)
            {
                for (int i = randomNumber; i < (randomNumber2+1); i++)
                {
                    Result += i;
                }
                resulttxt = "opgeteld van " + randomNumber + " tot " + randomNumber2 + ": " + Result;
            }
            else if (randomNumber > randomNumber2)
            {
                for (int i = randomNumber2; i < (randomNumber+1); i++)
                {
                    Result += i;
                }
                resulttxt = "opgeteld van " + randomNumber2 + " tot " + randomNumber + ": " + Result;
            }
            else if (randomNumber==randomNumber2)
            {
                int differ=randomNumber/2;
                for (int i =differ; i < (randomNumber2+1); i++){Result += i;}
                resulttxt = "opgeteld van " + differ + " tot " + randomNumber2 + ": " + Result;

            }
            return resulttxt;
        }

        public static int wordcounter(string txt)
        {
            int count = 1;
            for (int i = 1; i < txt.Length; i++)
            {
                if (char.IsWhiteSpace(txt, i-1) == true)
                {
                    count++;
                }
            }
            if (txt == "" || txt == " "|| txt == "  " || txt == "   " || txt == "    " || txt == "     ") { count = 0; }
            return count;
        }
    }
}