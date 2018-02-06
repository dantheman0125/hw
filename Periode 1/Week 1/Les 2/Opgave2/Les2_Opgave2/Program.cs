using System;

namespace Les2_Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            string taal;
            Console.WriteLine("Welke taal wilt u kiezen?");
            taal = (Console.ReadLine());
            switch (taal)
            {
                case "engels":
                    Console.WriteLine("Tot ziens in het Engels is: Good bye");
                    break;
                case "frans":
                    Console.WriteLine("Tot ziens in het Frans is: Au Revoir");
                    break;
                case "duits":
                    Console.WriteLine("Tot ziens in het Duits is: Auf Wiedersehen");
                    break;
                case "fries":
                    Console.WriteLine("Tot ziens in het Fries is: Oant Sjen!");
                    break;
                case "noors":
                    Console.WriteLine("Tot ziens in het Fries is: ha det bra");
                    break;
                default:
                    Console.WriteLine("Deze vertaling is niet mogelijk");
                    break;
            }
            Console.ReadLine();
        }
    }
}
