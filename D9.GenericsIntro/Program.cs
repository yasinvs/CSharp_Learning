using System;

namespace D9.GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");
            isimler.Add("Ayşe");
            isimler.Add("İlker");
        }
    }
}
