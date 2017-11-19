using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double leeftijd;
            Console.WriteLine("Welkom bij discotheek Versus");
            Console.WriteLine("Wat is jouw leeftijd?");
            leeftijd = Convert.ToDouble(Console.ReadLine());
            if (leeftijd < 16)
            {
                Console.WriteLine("Helaas! Je moet minimaal 16 jaar zijn om toegang te krijgen tot de Versus");
            }
            else if (leeftijd > 15 && leeftijd < 21)
            {
                Console.WriteLine("Je bent " + leeftijd + " jaar oud. Veel plezier in de Versus");
            }
            else
            {
                Console.WriteLine("Je bent " + leeftijd + " jaar oud. Veel plezier in de Versus.");
                Console.WriteLine("Je krijgt toegang tot onze exclusieve VIP-lounge!");

            }
            Console.ReadLine();

            Console.WriteLine("Hoe groot is de groep?");

            double personen = Convert.ToDouble(Console.ReadLine());

            switch (personen)
            {
                case 3:
                    Console.WriteLine("Een groep van " + personen + " personen krijgt 10% korting.");
                    break;
                case 4:
                    Console.WriteLine("Een groep van " + personen + " personen krijgt 20% korting.");
                    break;
                case 5:
                    Console.WriteLine("Een groep van " + personen + " personen krijgt 50% korting.");
                    break;
                default:
                    if (personen > 5)
                    {
                        Console.WriteLine("Een groep van " + personen + " personen krijgt gratis entree!");
                    }
                    else
                    {
                        Console.WriteLine("Een groep van " + personen + " personen krijgt geen korting.");
                    }
                    break;
            }

            {
                string geslacht, gehuwd;

                {
                    if (leeftijd >= 30)
                    {
                        Console.WriteLine("Wat is uw geslacht?");
                        geslacht = Convert.ToString(Console.ReadLine());
                        if (geslacht == "vrouw")
                        {
                            Console.WriteLine("Bent u gehuwd?");
                            gehuwd = Convert.ToString(Console.ReadLine());
                            if (gehuwd == "nee")
                            {
                                Console.WriteLine("Veel plezier in de Versus: Ladies Night, want u bent " + leeftijd + " jaartjes jong!");
                            }
                        }
                    }


                    Console.ReadLine();

                }
            }
        }
    }
}