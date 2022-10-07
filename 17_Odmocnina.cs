using System;

namespace _17_Odmocnina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej nějaké číslo, ze kterého spočítám odmocninu:");
            int a = int.Parse(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("Zadal jsi číslo větší než 0, to znamená, že ho mohu odmocnit!");
                double o = Math.Sqrt(a);
                Console.WriteLine("Odmocnina z čísla " + a + " je " + o);
            }
            else
                Console.WriteLine("Odmocnina ze záporného čísla neexistuje!");
            Console.WriteLine("Děkuji za zadání");
            Console.ReadKey();
        }
    }
}
