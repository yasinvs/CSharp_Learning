using System;
using System.Collections.Generic;

namespace D8.Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Diziler olanla çalışır ekstra ekleme yapılamaz...
            //Stack(RAM)       Heap(RAM)
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            ////Böyle yapılırsa diziye ekleme yapılmaz aksine bellekte yeni adresleme yapılarak eski değerler silinir ve yeni dizi adresi boş bir şekilde belleğe tanımlanarak, işlem sağlanır. Böyle eski değerlere de ulaşılamaz.
            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);


            List<string> isimler2 = new List<string> { "Engin","Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);


        }
    }
}
