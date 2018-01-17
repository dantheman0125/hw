using System;

namespace Opgave__5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random gen = new Random();
            int inzet = 0, winst = 0, dice1, dice2, count = 0, profit = 0;
            for (; ; )
            {
                Console.WriteLine("Hoeveel wilt u inzetten     Min: 5 Max: 100");
                inzet = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                if (inzet >= 5 && inzet <= 100)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        dice1 = gen.Next(1, 7);
                        dice2 = gen.Next(1, 7);
                        Console.WriteLine("Worp {0}:    {1}  {2}", i, dice1, dice2);

                        if (dice1 == 6 && dice2 == 6)
                        {
                            winst += inzet * 50;
                        }
                        else if (dice1 == dice2)
                        {
                            winst += inzet * 10;
                        }
                        else if (dice1 == 6 || dice2 == 6)
                        {
                            count++;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Gelieve een bedrag tussen 5 en 100 invullen");
                    Console.WriteLine("");
                }
                if (count >= 2) {winst += inzet * 2;}
                if (inzet >= 5 && inzet <= 100) {winst -= inzet;}
                if (winst != 0 && (inzet >= 5 && inzet <= 100))
                {
                    Console.WriteLine("Uw winst deze ronde is: {0} Euro", winst);

                    profit += winst;
                    count = 0; winst = 0;

                    Console.WriteLine("");
                    Console.WriteLine("Wilt u doorgaan     ja/nee");
                    string play = (Console.ReadLine());
                    Console.WriteLine("");
                    if (!(play == "j" || play == "J" || play == "ja" || play == "Ja" || play == "JA" || play == "jA"))
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Uw totale winst is: {0} Euro", profit);
            Console.ReadLine();
        }
    }
}