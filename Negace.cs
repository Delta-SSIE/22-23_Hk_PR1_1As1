using System;

namespace _18_Negace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej číslo 1  nebo 0");
            int a = int.Parse(Console.ReadLine());

            if ((a == 1) || (a == 0))
            { if (a == 1)
                {
                    a = 0;
                    Console.WriteLine("Negace zadaného čísla je " + a); 
                }
                    
                else
                {
                    a = 1;
                    Console.WriteLine("Negace zadaného čísla je " + a);
                }
            }
            else
                Console.WriteLine("Zadal jsi špatné hodnoty");
            
            Console.ReadKey();
        }
    }
}
