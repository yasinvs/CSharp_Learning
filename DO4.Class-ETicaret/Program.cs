using System;

namespace DO4.Class_ETicaret
{
    class Program
    {
        static void Main(string[] args)
        {
            Urunler urun1 = new Urunler();
            urun1.UrunAdi = "Duracell 10'lu Paket";
            urun1.Satici = "Duracell";
            urun1.KargoBedavaMi = false;
            urun1.SatisOrani = 10000;
            urun1.Ucret = 33;

            Urunler urun2 = new Urunler();
            urun2.UrunAdi = "Logitech M170";
            urun2.Satici = "Logitech";
            urun2.KargoBedavaMi = true;
            urun2.SatisOrani = 100;
            urun2.Ucret = 90;

            Urunler urun3 = new Urunler();
            urun3.UrunAdi = "Kaspersky Internet Security 2020";
            urun3.Satici = "Kaspersky";
            urun3.KargoBedavaMi = true;
            urun3.SatisOrani = 10;
            urun3.Ucret = 59.59f;

            Urunler[] urunler = new Urunler[] { urun1, urun2, urun3 };

            Console.WriteLine("FOR DONGUSU BASLADI!");
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine("Ürün Adı : " + urunler[i].UrunAdi);
                Console.WriteLine("Satıcı : " + urunler[i].Satici);
                Console.WriteLine(urunler[i].KargoBedavaMi ? "Kargo Durumu : Ücretsiz" : "Kargo Durumu : Ücretli");
                Console.WriteLine("Satış Oranı : " + urunler[i].SatisOrani);
                Console.WriteLine("Ücret : " + urunler[i].Ucret);
            }
            Console.WriteLine("FOR DONGUSU BITTI");

            Console.WriteLine("FOREACH DONGUSU BASLADI");
            foreach (var urun in urunler)
            {
                Console.WriteLine("Ürün Adı : " + urun.UrunAdi);
                Console.WriteLine("Satıcı : " + urun.Satici);
                Console.WriteLine(urun.KargoBedavaMi ? "Kargo Durumu : Ücretsiz" : "Kargo Durumu : Ücretli");
                Console.WriteLine("Satış Oranı : " + urun.SatisOrani);
                Console.WriteLine("Ücret : " + urun.Ucret);
            }
            Console.WriteLine("FOREACH DONGUSU BITTI");

            Console.WriteLine("WHILE DONGUSU BASLADI");
            int count = 0;
            while (count < urunler.Length)
            {
                Console.WriteLine("Ürün Adı : " + urunler[count].UrunAdi);
                Console.WriteLine("Satıcı : " + urunler[count].Satici);
                Console.WriteLine(urunler[count].KargoBedavaMi ? "Kargo Durumu : Ücretsiz" : "Kargo Durumu : Ücretli");
                Console.WriteLine("Satış Oranı : " + urunler[count].SatisOrani);
                Console.WriteLine("Ücret : " + urunler[count].Ucret);
                count++;
            }
            Console.WriteLine("WHILE DONGUSU BITTI");
        }
    }

    class Urunler
    {
        public string UrunAdi { get; set; }
        public string Satici { get; set; }
        public bool KargoBedavaMi { get; set; }
        public int SatisOrani { get; set; }
        public float Ucret { get; set; }
    }
}
