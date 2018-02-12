using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string naam = "Fiona Sariedine";
            char variabel1 = 'C';
            int nummer1 = 123;
            float nummer2 = 1.5f;
            bool status = false;
            int leeftijd = 35;

            float rest = nummer1 % nummer2;

            Console.WriteLine("OPGAVE 1");
            Console.WriteLine("");
            Console.WriteLine(naam + "  " + variabel1);
            Console.WriteLine(nummer1 + "   " + nummer2);
            Console.WriteLine(leeftijd + "  " + status);
            Console.WriteLine(rest);
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("OPGAVE 2");
            Console.WriteLine("");


            string woordA = "Hallo";
            string woordB = "Wereld";
            string spatie = " ";
            string zin = woordA + spatie + woordB;

            Console.WriteLine(zin);
            Console.ReadLine();

            string bla = "bla";
            for (int i = 0; i < 4; i++)
             {
                bla = bla + "bla";
            };
            Console.WriteLine(bla);
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("OPGAVE 3");
            Console.WriteLine("");

            int celsius, fahr;
            Console.WriteLine("Convert Celsius (C) to Fahrenheit (F): ");
            celsius = int.Parse(Console.ReadLine());
            fahr = (celsius * 9) / 5 + 32;
            Console.WriteLine("Temperature in Fahrenheit (F) is : " + fahr);
            Console.ReadLine();

            float celsi, Fahr;
            Console.WriteLine("Convert Fahrenheit (F) to Celsius (C): ");
            Fahr = float.Parse(Console.ReadLine());
            celsi = (Fahr - 32) / 1.8f;
            Console.WriteLine("Temperature in Celsius (C) is : " + celsi);
            Console.ReadLine();

            float Celsius, kelvin;
            Console.WriteLine("Convert Celsius (C) to Kelvin (K): ");
            Celsius = float.Parse(Console.ReadLine());
            kelvin = Celsius + 273.15f;
            Console.WriteLine("Temperature in Kelvin (K) is : " + kelvin);
            Console.ReadLine();

            float Celsi, Kelvin;
            Console.WriteLine("Convert Kelvin (K) to Celsius (C): ");
            Kelvin = float.Parse(Console.ReadLine());
            Celsi = Kelvin - 273.15f;
            Console.WriteLine("Temperature in Celsius (C) is : " + Celsi);
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("OPGAVE 5");
            Console.WriteLine("");

            float eur;
            float usd = 1.2231f;
            float conversion;

            Console.Write("Hoeveel Euro wilt u omrekenen naar USD: ");
            eur = float.Parse(Console.ReadLine());
            conversion = (usd * eur);
            Console.WriteLine(eur + " EUR is gelijk aan $" + conversion + " USD");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("OPGAVE 6");
            Console.WriteLine("");

            String Naam;
            String familie;
            String straat;
            String huisnr;
            String postcode;
            String gemeente;

            Console.Write("Naam: ");
            Naam = Console.ReadLine();
            Console.Write("familie: ");
            familie = Console.ReadLine();
            Console.Write("straat: ");
            straat = Console.ReadLine();
            Console.Write("huisnmr: ");
            huisnr = Console.ReadLine();
            Console.Write("postcode: ");
            postcode = Console.ReadLine();
            Console.Write("gemeente: ");
            gemeente = Console.ReadLine();

            Console.Clear();

            Console.WriteLine(Naam + " " + familie);
            Console.WriteLine(straat + " " + huisnr);
            Console.WriteLine(postcode + "  " + gemeente);
            Console.ReadLine();
        }
    }
}
