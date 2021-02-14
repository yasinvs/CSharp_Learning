using System;

namespace D6.DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,decimal,float,double,bool = değer tip // Eğer başka bir değere bak denilirse ramin stack bölgesinde kopyalama yapar
            //array,class,interface = referans tip // Eğer başka bir değere bak denilirse ramin heap bölgesinde denilen yere bakar ve önceki değerlerini ramden düşürür

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;

        }
    }
}
