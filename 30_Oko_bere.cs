using System;

namespace _30_Oko_bere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int soucet_hrac = 0;
            int soucet_pc = 0;
            int karta;
            int karta_pc;
            int rozdil_hrac;
            int rozdil_pc;

            bool hra = true;
            string volba;

            while (hra)
            {
                karta = generator.Next(7, 12);
                Console.WriteLine($"Vyháhl sis kartu s hodnotou {karta}");
                soucet_hrac = soucet_hrac + karta;
                Console.WriteLine($"Tvuj aktuální součet karet v ruce je {soucet_hrac}");
                karta_pc = generator.Next(7, 12);
                soucet_pc = soucet_pc + karta_pc;
                Console.WriteLine("Chceš hrát dál? a/n");
                volba = Console.ReadLine();

                if (volba != "a")
                    hra = false;
            }
            rozdil_hrac = Math.Abs(21 - soucet_hrac);
            rozdil_pc = Math.Abs(21 - soucet_pc);
           
            if (rozdil_pc == rozdil_hrac)
                Console.WriteLine($"Je to remíra");
            else
            {
                if (rozdil_hrac < rozdil_pc)
                {
                    Console.WriteLine($"Od 21 jsi {rozdil_hrac} a PC je {rozdil_pc}.");
                    Console.WriteLine($"Vyhrál jsi ty!");
                }
                else
                {
                    Console.WriteLine($"Od 21 jsi {rozdil_hrac} a PC je {rozdil_pc}.");
                    Console.WriteLine($"Vyhrál PC!");
                }
            }
            Console.ReadKey();
        }
       
    }
}
