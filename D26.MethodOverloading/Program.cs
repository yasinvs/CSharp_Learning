using System;
using System.Linq;

namespace D26.MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method overloading = birden fazla aynı imza ile ayrı parametreli aynı isimle method oluşturabiliriz.
            Console.WriteLine(Multiply(1,2));
            Console.WriteLine(Multiply(2,2,2));


        }

        static int Multiply(int number1,int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1,int number2,int number3)
        {
            return number1 * number2 * number3;
        }


    }
}
