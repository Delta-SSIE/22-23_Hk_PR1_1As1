using System;

namespace _10_cela_cisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej celé číslo");
            int a = int.Parse(Console.ReadLine()); // hodnotu zadanou v konzili převedu na int a uložím do proměnné a
            Console.WriteLine("Zadej druhé dcelé číslo");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("Výsledek matematické operace " + a + " + " + b + " = " + c);
            Console.ReadKey();
            int e = a - b;
            Console.WriteLine("Výsledek matematické operace {0} - {1} = {2}", a, b, e);
            Console.ReadKey();
            int f = a * b;
            Console.WriteLine($"Výsledek matematické operace {a} * {b} = {f}");
            Console.ReadKey();
            int d = a / b; // celočíselné dělení operace DIV
            Console.WriteLine($"Výsledek matematické operace {a} div {b} = {d}");
            int m = a % b; // zbytek po celočíselném dělení oparace MOD
            Console.WriteLine($"Výsledek matematické operace {a} modulo {b} = {m}");
            Console.ReadKey();        
        }
    }
}
