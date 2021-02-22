using System;

namespace DO1.TernaryOperatoru
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Ternary if-else ile benzerlik göstersede c# dilindeki tek 3 işlem alan operatördür.
             * Girilen sayıdaki koşulumuz 7
             * eğer doğru bilinirse ? soru işareti sonrası çalışsın,
             * yanlış ise : iki nokta üstüste olan çalışsın
             * ? soru işareti defaulttur. 
             */


            Console.Write("1-10 arasında sayı giriniz : ");
            int girilenSayi = int.Parse(Console.ReadLine());
            string gosterilenCevap = "";

            gosterilenCevap += girilenSayi == 7 ? "Tebrikler doğru bildiniz" : "Yanlış bildiniz";
            Console.WriteLine(gosterilenCevap);
            Console.WriteLine(girilenSayi == 7 ? "Tebrikler doğru bildiniz" : "Yanlış bildiniz");
        }
    }
}
