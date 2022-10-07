using System;

namespace _19_Interval
{
    internal class Interval
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej číslo v intervalu <-10 ; -5 > nebo <30; 40>");
            int a = int.Parse(Console.ReadLine());

            if (((a >= -10) && (a <= -5)) || ((a >= 30) && (a<=40)))
            
                Console.WriteLine($"Tvé zadané číslo {a} leží v požadovaném intervalu");
            else
                Console.WriteLine($"Tvé zadané číslo {a} NEleží v požadovaném intervalu");
            

            Console.ReadKey();
        }
    }
}
