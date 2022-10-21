using System;
using System.Threading;

namespace _27_while_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Random generatror = new Random();
            Console.WriteLine("Zadej dolní mez intervalu pro generování čísla");
            int dolni_g = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej horní mez intervalu pro generování čísla");
            int horni_g = int.Parse(Console.ReadLine());

            while (horni_g <= dolni_g) // dokud uživatel nezadá horní mez pro generování větší než dolní budu jej stále otravovat :)
            {
                Console.WriteLine("Zadej znova horní mez intervalu pro generování čísla");
                horni_g = int.Parse(Console.ReadLine());
            }

            int cislo = generatror.Next(dolni_g, horni_g + 1);
            Console.WriteLine($"Náhodně vygenerované číslo z intervalu <{dolni_g}, {horni_g}> je {cislo}.");
            Console.ReadKey();
            */
            Random generatror = new Random();
            int horni_g;

            Console.WriteLine("Zadej dolní mez intervalu pro generování čísla");
            int dolni_g = int.Parse(Console.ReadLine());

            int pokus = 0;

            do
            {
                if (pokus != 0)
                {
                    Console.WriteLine("Zadej znova horní mez intervalu pro generování čísla");
                    horni_g = int.Parse(Console.ReadLine());
                    pokus++;
                }
                else
                {
                    Console.WriteLine("Zadej horní mez intervalu pro generování čísla");
                    horni_g = int.Parse(Console.ReadLine());
                    pokus++;
                }
            }
            while (horni_g <= dolni_g); // dokud uživatel nezadá horní mez pro generování větší než dolní budu jej stále otravovat :)
            if (pokus > 1)
                Console.WriteLine($"Konečně jsi se trefil, ale trvalo ti to {pokus} pokusů");

                int cislo = generatror.Next(dolni_g, horni_g + 1);
            Console.WriteLine($"Náhodně vygenerované číslo z intervalu <{dolni_g}, {horni_g}> je {cislo}.");
            Console.ReadKey();

        }
    }
}
