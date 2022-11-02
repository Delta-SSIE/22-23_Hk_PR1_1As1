using System;

namespace _29_Hra_v_kostky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int vyhraPC = 0;
            int vyhraHrac = 0;
            string report;
            Console.WriteLine("Vítej ve hře Hra v kostky");
            Console.WriteLine("Zadej počet vítězství");
            int pocet = int.Parse(Console.ReadLine());
            Console.WriteLine("Hru začneš stiskem ENTER)");
            Console.ReadKey();
            do
            {
                int hodPC = generator.Next(1, 7);
                Console.WriteLine($"PC hodil {hodPC}");
                Console.WriteLine("Hoď si (stiskni ENTER)");
                Console.ReadKey();
                int hodHrac = generator.Next(1, 7);
                Console.WriteLine($"Ty jsi hodil {hodHrac}");
                if (hodPC == hodHrac)
                    Console.WriteLine("Oba jste hodily stejně, hrajeme znova");
                else
                {
                    if (hodHrac > hodPC)
                    {
                        vyhraHrac++;
                        Console.WriteLine($"Vyhrál jsi tuto hru. Aktuální skóre je: Hrac {vyhraHrac} : {vyhraPC} PC.");
                    }
                    else
                    {
                        vyhraPC++;
                        Console.WriteLine($"Tuto hru vyhrál PC. Aktuální skóre je: Hrac {vyhraHrac} : {vyhraPC} PC.");
                    }
                }
                Console.ReadKey();
                Console.Clear();
            }
            while (vyhraHrac < pocet && vyhraPC < pocet);
            if (vyhraPC > vyhraHrac)
                report = "Hru vyhrál PC";
            else
                report = "Hru jsi vyhrál ty";
            Console.WriteLine($"Výledek hry je {vyhraHrac}:{vyhraPC}. {report}");
            Console.ReadKey();
        }
    }
}
