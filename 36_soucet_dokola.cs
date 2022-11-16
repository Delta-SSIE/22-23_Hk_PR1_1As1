using System;

namespace _36_soucet_dokola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soucet = 0;
            int pocet = 0;
            Console.WriteLine("Program od tebe bude chtít zadávat celá čísla dokud jejich součet nebude větší než horní mez.");

            Console.WriteLine("Zadej prosím horni mez");
            int horni_mez;
            while (!int.TryParse(Console.ReadLine(), out horni_mez))
                Console.WriteLine("Neplatný znak, zadejte prosím horní mez jako celé číslo:");
            bool dalsi = true;
            while (dalsi)
            {
                Console.WriteLine("Zadej prosím celé číslo");
                int a;
                while (!int.TryParse(Console.ReadLine(), out a))
                    Console.WriteLine("Neplatný znak, zadejte prosím celé číslo znovu:");
                soucet = soucet+a;
                pocet++;
                if (soucet > horni_mez)
                    dalsi = false;
            }
            Console.WriteLine($"Tvůj celkový součet zadaných {pocet} cifer je {soucet}.");
            Console.ReadKey();
        }
    }
}
