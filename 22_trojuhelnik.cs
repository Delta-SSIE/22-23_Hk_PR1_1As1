using System;

namespace _22_Trojuhelnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte stranu A trojhuleníku ABC");
            string stranaA = Console.ReadLine();
            Console.WriteLine("Zadejte stranu B trojhuleníku ABC");
            string stranaB = Console.ReadLine();
            Console.WriteLine("Zadejte stranu C trojhuleníku ABC");
            string stranaC = Console.ReadLine();

            double strA = double.Parse(stranaA);
            double strB = double.Parse(stranaB);
            double strC = double.Parse(stranaC);

            if (strA + strB > strC == strA + strC > strB && strA + strB > strC == strB + strC > strA && strA + strC > strB == strB + strC > strA)
            {
                Console.WriteLine("Zadaný Trojuhelník je správný");

                if (strA == strB && strB == strC && strA == strC)

                {
                    Console.WriteLine("Trojuhelník je Rovnostraný");
                }

                else if (strA == strB || strB == strC || strA == strC)

                {

                    Console.WriteLine("Zadaný Trojuhelník je Rovnoramený");
                }

                else if (Math.Pow(strC, 2) == Math.Pow(strA, 2) + Math.Pow(strB, 2) || Math.Pow(strB, 2) == Math.Pow(strA, 2) + Math.Pow(strC, 2) || Math.Pow(strA, 2) == Math.Pow(strB, 2) + Math.Pow(strC, 2))

                {

                    Console.WriteLine("Trojuhelník je Pravoúhlý");

                }

                else

                {

                    Console.WriteLine("Trojuhelník je obecný");

                }
            }
            else
                Console.WriteLine("Trojúhelník není správný");
        }
    }
}
