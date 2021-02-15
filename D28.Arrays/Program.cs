using System;

namespace D28.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // array tipe göre hareket eder string tipinde oluşturulan arraye int eklenemez

            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";

            string[] students2 = new[] { "Engin", "Derin", "Salih" };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
