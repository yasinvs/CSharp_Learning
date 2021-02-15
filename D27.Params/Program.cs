using System;
using System.Linq;

namespace D27.Params
{
    class Program
    {
        static void Main(string[] args)
        {
            // params komutu ile istediğimiz kadar değer gönderebiliriz.
            // paramsdan sonra ekstra parametre eklemeyiz. Onun yerine paramsdan önce yani soluna eklemek gerek.
            Console.WriteLine(Add(1, 2, 3, 4, 5, 6));
        }
        static int Add(params int[] numbers)
        {
            // sum ile gelen değerleri toplayıp,return ile geriye döndürebiliriz
            // sum için System.Linq using olarak eklenmesi gerek.
            return numbers.Sum();
        }
    }
}
