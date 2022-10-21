using System;

namespace _26_Intervyl_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            Console.WriteLine("Vygeneruji náhodné číslo v intervalu <-20; 20>");
            Console.ReadKey();
            Console.WriteLine("Zadej dolní mez pro generovaní");
            int dolni_g = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej hodni mez pro generovaní");
            int horni_g = int.Parse(Console.ReadLine());
            if (dolni_g > horni_g)
            {
                int pom = dolni_g;
                dolni_g = horni_g;
                horni_g = pom;
            }

            int cislo = generator.Next(dolni_g, horni_g);
            Console.WriteLine($"Vygeneroval jsem číslo {cislo}");
            Console.ReadKey();
            Console.WriteLine("Zadej dolní mez subintervalu");
            int dolni = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej horní mez subintervalu");
            int horni = int.Parse(Console.ReadLine());
            if (dolni > horni)
            {
                int pom = dolni;
                dolni = horni;
                horni = pom;
            }
            if (dolni < dolni_g)
                Console.WriteLine("Zadal jsi španou dolní mez subintervalu - program sposť znova");
            if (horni > horni_g)
                Console.WriteLine("Zadal jsi španou horní mez subintervalu - program sposť znova");
            if (dolni < dolni_g || horni > horni_g)
                Console.WriteLine($"Chyba v zadání - nebudu vyhodnocnovat!");
            else {
                if (cislo >= dolni && cislo <= horni)
                    Console.WriteLine($"Vygenerované číslo {cislo} JE v subintervalu <{dolni}, {horni}>.");
                else
                Console.WriteLine($"Vygenerované číslo {cislo} NENÍ v subintervalu <{dolni}, {horni}>.");
                }
            Console.ReadKey();
        }
    }
}

