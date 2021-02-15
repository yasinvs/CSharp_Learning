using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri m)
        {
            Console.WriteLine("Müşteri sisteme eklendi... {0}", m.AdiSoyadi);
        }

        public void List(params Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri Id : " + musteri.Id);
                Console.WriteLine("Müşteri Adı Soyadı : " + musteri.AdiSoyadi);
                Console.WriteLine("Müşterinin yaşadığı şehir : " + musteri.Sehir);
            }
        }

        public void Delete(Musteri m)
        {
            Console.WriteLine("Müşteri sistemden silindi... {0}", m.AdiSoyadi);
        }
    }
}
