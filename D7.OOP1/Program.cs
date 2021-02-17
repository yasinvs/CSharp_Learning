using System;

namespace D7.OOP1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * *** REFERANS TİPLİ DEĞİŞKENLER
             * diziler, class,abstract class,interface...
             * Referans tipli değişkenlerde eğer değer gönderilirse bellekteki adres gideceği için parametre üzerinden değer ataması yapılabilir.
             * *** DEĞER TİPLİ DEĞİŞKENLER
             * int,double,float.....
             * değer tipli değişkenlerde ise değer gönderilirse parametre üzerinden değişiklik sağlanamaz... ref veya out keywordleri parametre başlarına bırakılarak ilgili atama sağlanır.
             */

            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            //case sensitive
            //Stack                         //Heap
            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);




        }
    }
}
