using System;

namespace _1Tekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tiplerin yazımı zorunludur, nedeni ise type safety yani tip güvenliğinin c# dilinde gelişmiş olmasıdır.

            string categoryLabel = "PC Store";
            int studentNumber = 32000;
            double bankRate = 1.45;
            bool isSystemLoggedIn = false;

            double dollarYesterday = 6.00;
            double dollarToday = 6.10;

            if (dollarYesterday > dollarToday)
            {
                Console.WriteLine("Down button");
            }
            else if (dollarYesterday < dollarToday)
            {
                Console.WriteLine("Up button");
            }
            else
            {
                Console.WriteLine("Not changed button");
            }

            if (isSystemLoggedIn == true)
            {
                Console.WriteLine("User Settings Button");
            }
            else
            {
                Console.WriteLine("Login Button");
            }

            Console.WriteLine(categoryLabel);
        }
    }
}
