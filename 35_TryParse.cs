using System;

namespace _35_TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej reální číslo: ");

            double cislo;
            while (!double.TryParse(Console.ReadLine(), out cislo))
            {
                Console.WriteLine("Má to být číslo.");
            }

            Console.WriteLine($"Zadal jsi {cislo}.");

            Console.WriteLine("Zadej celé číslo: ");

            int cislo2;
            while (!int.TryParse(Console.ReadLine(), out cislo2))
            {
                Console.WriteLine("Má to být celé číslo.");
            }
            Console.WriteLine($"Zadal jsi {cislo2}.");
        }
    }
}
