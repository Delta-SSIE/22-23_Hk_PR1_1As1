using System;

namespace _19_Interval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej číslo v intervalu <-10 ; 10 >");
            int a = int.Parse(Console.ReadLine());

            if ((a <= -10) || (a >= 10))
            
                Console.WriteLine($"Tvé zadané čílos {a} leží v požadovaném intervalu");
            else
                Console.WriteLine($"Tvé zadané čílos {a} NEleží v požadovaném intervalu");
            

            Console.ReadKey();
        }
    }
}
