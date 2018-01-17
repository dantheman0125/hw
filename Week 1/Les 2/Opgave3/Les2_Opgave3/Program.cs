using System;

namespace Les2_Opgave3
{
    class Program
    {
        static void Main(string[] args)
        {
            string sex;
            double L, M, P;
            Console.WriteLine("Wat is uw geslacht?  (M/V)");
            sex = Console.ReadLine();
            if (sex == "man" || sex == "Man" || sex == "m" || sex == "M")
            {
                Console.WriteLine("wat is uw lengte?    (in cm)");
                L = Convert.ToDouble(Console.ReadLine());
                M = Math.Round((L - 100) * 0.9);
                Console.WriteLine("uw ideale gewicht is: " + M + "kg");
                Console.ReadLine();
            }
            else if (sex == "vrouw" || sex == "Vrouw" || sex == "v" || sex == "V")
            {
                Console.WriteLine("Wat is uw lengte?    (in cm)");
                L = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Wat is uw Polsomtrek?    (in cm)");
                P = Convert.ToDouble(Console.ReadLine());
                M = Math.Round((L + 4 * P - 100) / 2);
                Console.WriteLine("uw ideale gewicht is: " + M + "kg");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Gelieve man of vrouw invullen");
                Console.ReadLine();
            }
        }
    }
}
