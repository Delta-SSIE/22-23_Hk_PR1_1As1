using System;

namespace _22_Od_max_k_min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej číslo A");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej číslo B");
            int b = int.Parse(Console.ReadLine());
            if ( a > b)
                {
                int p = a;
                a = b;
                b = p;
            }
            Console.WriteLine("Zadej číslo C");
            int c = int.Parse(Console.ReadLine());
            if (b > c)
                {
                int p = c;
                c = b;
                b = p;
                }
            if (a > b)
                {
                int p = a;
                a = b;
                b = p;
            }
            
            Console.WriteLine($"Platí, že {c} < {b} < {a}");
            Console.ReadKey();
        }
    }
}
