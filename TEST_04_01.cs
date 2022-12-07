using System.Net.Security;

namespace TEST_04_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cislo;
            int min;
            int pozice;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Zadání:");
            Console.WriteLine("Program nače počet čísel, která bude uživatel zadávat (ošetřete vstup).");
            Console.WriteLine("Program vyzve uživatele, aby postupně zadával daný počet hodnot.");
            Console.WriteLine("Program vypíše nejmenší zadanou hodnotu a pozici, kdy bylo číslo zadanáno.");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Zdej počet čísel pro vyhodnocení:");
            int pocet = int.Parse(Console.ReadLine());
            if (pocet > 0)
             Console.WriteLine("Zajed 1. číslo:");
            cislo = int.Parse(Console.ReadLine());
            min = cislo;
            pozice = 1;

            for (int i = 2; i <= pocet; i++)
            {
                Console.WriteLine($"Zadej {i}. číslo:");
                cislo = int.Parse(Console.ReadLine());

                if (cislo < min)
                {
                    min = cislo;
                    pozice = i;
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Nejmenší číslo, které bylo zadané je {min} a bylo zadáno jako {pozice}.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}