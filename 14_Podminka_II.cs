using System;

namespace _14_Podminka_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej rok narození");
            int rok = int.Parse(Console.ReadLine());
            int vek = 2022 - rok;
            if (vek < 21)
            {
                if (vek >= 18)
                {
                    Console.WriteLine("V USA si pivo nedáš, ale v ČR ANO :)");
                }
                else
                {
                    Console.WriteLine("Dej si raději nealkoholické pivo");
                }
            }
            else
            {
                Console.WriteLine("Můžeš si dát pivo ale s ROZUMEM");
            }
            Console.ReadKey();
        }
    }
}
