using System;

namespace Opgave__5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random gen = new Random();
            int gooi1;
            int gooi2;
            int count5 = 0;
            bool win1 = false;
            bool win2 = false;
            int win3 = 0;
            int inzet;
            while (true)
            {
                Console.WriteLine("Hoeveel wilt u inzetten (Maximaal 100 Euro)?");
                win1 = false;
                win2 = false;
                win3 = 0;
                count5 = 0;
                inzet = Convert.ToInt32(Console.ReadLine());
                if ((inzet >= 5) && (inzet <= 100))
                {
                    while (count5 < 3)
                    {
                        gooi1 = gen.Next(1, 7);
                        gooi2 = gen.Next(1, 7);
                        count5++;
                        Console.WriteLine("Worp " + count5 + "; " + gooi1 + " " + gooi2);
                        if ((gooi1 == 6) && (gooi2 == 6))
                        {
                            win1 = true;
                            break;
                        }
                        if (gooi1 == gooi2)
                        {
                            win2 = true;
                        }
                        if ((gooi1 == 6) || (gooi2 == 6))
                        {
                            win3++;
                        }
                    }
                    if (win1)
                    {
                        Console.WriteLine("Je hebt " + inzet * 50 + " euro gewonnen!");
                    }
                    else if (win2)
                    {
                        Console.WriteLine("Je bent " + inzet * 10 + " euro gewonnen!");
                    }
                    else if (win3 >= 2)
                    {
                        Console.WriteLine("Je hebt " + inzet * 2 + " euro gewonnen!");
                    }
                    else
                    {
                        Console.WriteLine("Je hebt helaas niks gewonnen.");
                    }
                }
                else if (inzet < 5)
                {
                    Console.WriteLine("De minimale inzet is 5 Euro.");
                }
                else
                {
                    Console.WriteLine("De maximale inzet is 100 Euro.");
                }
            }
        }
    }
}
