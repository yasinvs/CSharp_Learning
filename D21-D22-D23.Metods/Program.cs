using System;

namespace D21.Metods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();
            Add();

            var result = Add2(20);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added");
        }

        static int Add2(int number1, int number2 = 30)
        {
            return number1 + number2;
        }
    }
}
