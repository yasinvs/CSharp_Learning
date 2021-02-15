using System;
using System.Collections;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("ClassMethotDemo");

            Musteri m1 = new Musteri()
            {
                Id = 9000001,
                AdiSoyadi = "Zehra Deneyici",
                Sehir = "İstanbul"
            };

            Musteri m2 = new Musteri()
            {
                Id = 9000002,
                AdiSoyadi = "Caner Deneyici",
                Sehir = "Adana"
            };

            Musteri m3 = new Musteri()
            {
                Id = 9000003,
                AdiSoyadi = "Ben Bilmem",
                Sehir = "Van"
            };

            MusteriManager musteriManager = new MusteriManager();

            //Ekle
            musteriManager.Add(m1);
            musteriManager.Add(m2);
            musteriManager.Add(m3);

            //Listele
            musteriManager.List(m1, m2, m3);

            //Sil
            musteriManager.Delete(m1);
            musteriManager.Delete(m2);
            musteriManager.Delete(m3);

        }
    }
}
