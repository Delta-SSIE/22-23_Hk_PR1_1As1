﻿namespace _42_for_for_nasobilka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    Console.Write(i * j + " ");
                }
                Console.WriteLine();
            }*/
             // Výstup má n-řádků a 10 sloupců
            Console.WriteLine("Zadej hodní mez násoblky:");
            int horni = int.Parse(Console.ReadLine());
            for (int i = 1; i < horni+1; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    Console.Write(i * j + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            // Výstup má 10-řádků a n sloupců
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < horni+1; j++)
                {
                    Console.Write(i * j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}