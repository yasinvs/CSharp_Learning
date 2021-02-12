using System;

namespace DO2.Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1-5 arasında bir sayı giriniz : ");
            string switchornek = Console.ReadLine();

            switch (switchornek)
            {
                case "1":
                    Console.WriteLine("Girilen sayı 1(Bir)");
                    break;
                case "2":
                    Console.WriteLine("Girilen sayı 2(İki)");
                    break;
                case "3":
                    Console.WriteLine("Girilen sayı 3(Üç)");
                    break;
                case "4":
                    Console.WriteLine("Girilen sayı 4(Dört)");
                    break;
                case "5":
                    Console.WriteLine("Girilen sayı 5(Beş)");
                    break;
                default:
                    Console.WriteLine("Girilen sayı 1-5 aralığı dışındadır.");
                    break;
            }
        }
    }
}
