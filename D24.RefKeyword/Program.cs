using System;

namespace D24.RefKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            //ref keyword direkt olarak değer tipini referans tipi olarak göstererek atama yapar.
            //out keyword ref ile aynı işlemi görür tek farkı set edilmeyen değer tipine de atama yapabilir.
            int number1 = 20;
            int number2 = 100;
            int number3;

            var result = Add3(ref number1, number2, out number3);
            Console.WriteLine(result);
            Console.WriteLine(number1);
            Console.WriteLine(number3);
            Console.ReadLine();
        }

        static int Add3(ref int number1, int number2, out int number3)
        {
            number1 = 30;
            number3 = 10;
            return number1 + number2 + number3;
        }
    }
}
