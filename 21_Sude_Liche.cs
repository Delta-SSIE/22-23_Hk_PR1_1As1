using System;

namespace _21_Sude_Liche
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej číslo pro určení sudosti / lichosti:");
            string nacteno = Console.ReadLine();
            int cislo = int.Parse(nacteno);

            // Vydělím 2, zajímá mne zbytek.
            // Když je zbytek 0, je číslo sudé
            if (cislo % 2 == 0)
            {
                Console.WriteLine($"Číslo {cislo} je sudé.");
                //Console.WriteLine("Číslo " + cislo + " je sudé.");
                //Console.WriteLine("Číslo {0} je sudé.", cislo);
            }
            else
            {
                Console.WriteLine($"Číslo {cislo} je liché.");

            }
        }
    }
}
