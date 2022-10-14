using System;

namespace _24_Dny_v_tydnu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej číslo dne v týdnu:");
            int cislo = int.Parse(Console.ReadLine());

            string den;

            // zde definuji výběr z více možností

            switch (cislo)
            {
                case 1:
                    den = "Pondělí";
                    break;
                case 2:
                    den = "Úterý";
                    break;
                case 3:
                    den = "Středa";
                    break;
                case 4:
                    den = "Čtvrtek";
                    break;
                case 5:
                    den = "Pátek";
                    break;
                case 6:
                    den = "Sobota";
                    break;
                case 7:
                    den = "Neděle";
                    break;
                default:
                    den = "Zadal jsi nějaký divný den !";
                    break;
            }
            Console.WriteLine($"Zadanému číslu {cislo} dne v týdnu říkáme {den}");
            Console.ReadKey();
        }
    }
}
