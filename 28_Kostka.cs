using System;

namespace _28_Kostka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random kostka = new Random();

            int cislo;
            int pocet = 0;
            Console.WriteLine("Program určí po kolika hodech padne na kostce číslo 6");

            do
            {
                Console.Clear();
                Console.WriteLine("Mezerníkem pokračuješ ve hře");
                Console.ReadKey();
                cislo = kostka.Next(1, 7);
                pocet++;
            } while (cislo !=6);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Hodnota 6 padla po {pocet} pokusech.");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
