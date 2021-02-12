using System;

namespace DO3.While
{
    class Program
    {
        static void Main(string[] args)
        {
            int whilesayi = 1;
            string soldansaga = "";
            while (whilesayi <= 20)
            {
                Console.WriteLine(whilesayi);
                soldansaga += whilesayi + " ";
                whilesayi++;
            }
            Console.WriteLine(soldansaga);
        }
    }
}
