using System;

namespace _25_Genrator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random(); // vytvářím konstruktor třídy Random se jménem generator
            Console.WriteLine("Náhodně vygeneruji číslo z intervalu <-5, 5 >");
            int a = generator.Next(-5, 6); // definuji rozsah (od, do), kde do již nepatří do intervalu
            Console.WriteLine($"Náhodně jsem vygeneroval číslo {a}");
            Console.ReadKey();

            if (a >= 0)
                Console.WriteLine($"Vygenerované číslo {a} je kladné");
            else
                Console.WriteLine($"Vygenerované číslo {a} je záporné");

            Console.ReadKey();
        }
    }
}
