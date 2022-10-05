using System;

namespace _15_Podmínka_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string obrazec;
            Console.WriteLine("Zadej strabu obrazce a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Zadej druhou stranu obrazce");
            double b = double.Parse(Console.ReadLine());
            // hezká varianta
            /*
            if (a == b)
            {
                obrazec = "čtverce";
            }
            else
            {
                obrazec = "obdelníku";
            }
            double obsah = a * b;
            double obvod = 2 * (a + b);
            Console.WriteLine($"Obsah {obrazec} je {obsah} a obvod {obrazec} je {obvod} ");*/

            // Pracná varianta

            if (a == b)
            {
                double obsah = a * a;
                double obvod = 4 * a;
                Console.WriteLine($"Obsah čtverce je {obsah} a obvod čtvrece je {obvod} ");
            }
            else
            {
                double obsah = a * b;
                double obvod = 2 * (a + b);
                Console.WriteLine($"Obsah obdélníku je {obsah} a obvod obdélníku je {obvod} ");
            }
            Console.ReadKey();
        }
    }
}
