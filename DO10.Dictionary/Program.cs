using System;
using System.Collections.Generic;

namespace DO10.Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictCollections = new Dictionary<string, string>();

            dictCollections.Add("txt", "Text File");
            dictCollections.Add("png", "Image File");
            dictCollections.Add("cs", "C# File");

            foreach (var item in dictCollections)
            {
                Console.WriteLine(item.Key + " = " + item.Value);
            }

            Console.WriteLine("/// /// /// /// /// ///");

            Dictionary<int, string> dictCollections1 = new Dictionary<int, string>();

            dictCollections1.Add(2, "Mehmet Kar");
            dictCollections1.Add(0, "Selam Yiğit");
            dictCollections1.Add(1, "Arkadaş Yiğiti");

            for (int i = 0; i < dictCollections1.Count; i++)
            {
                Console.WriteLine(i + " = " + dictCollections1[i]);
            }

            //Metotlar ve Özellikleri
            bool varlikSorgulamasiKey = dictCollections.ContainsKey("txt");
            Console.WriteLine(varlikSorgulamasiKey ? "Bulundu" : "Bulunamadı");
            bool varlikSorgulamasiValue = dictCollections.ContainsValue("Text File");
            Console.WriteLine(varlikSorgulamasiValue ? "Bulundu" : "Bulunamadı");

            bool silinenDeger = dictCollections.Remove("txt");
            Console.WriteLine(silinenDeger ? "Silindi" : "Silinemedi");

            dictCollections.Clear();



        }
    }
}
