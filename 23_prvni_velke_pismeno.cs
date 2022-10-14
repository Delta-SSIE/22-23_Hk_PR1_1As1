using System;
using System.Linq;

namespace ConsoleApp2
{
    internal class První_velké_pismeno
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej nazev školy");
            string skola = Console.ReadLine();
            skola = char.ToUpper(skola[0]) + skola.Substring(1);
            Console.WriteLine(skola);
            Console.ReadKey();

              
        }
    }
}
