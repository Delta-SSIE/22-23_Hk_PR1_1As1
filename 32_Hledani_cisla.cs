using System;
using System.Text;

namespace _32_Hledani_cisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            bool vstup = false;
            Console.WriteLine("Jaké číslo mám otestovat?");
            int hledano = int.Parse(Console.ReadLine());
            //Ošetšení vstupu
            while (!vstup)
            {

                if (hledano >= 0 && hledano <= 9)
                    vstup = true;
                else 
                {
                    Console.WriteLine("Zadej číslo z intervalu 0 - 9!");
                    hledano = int.Parse(Console.ReadLine());
                }
            }

            bool nalezen = false;
            int cislo;
            int pocet=0;

            while (!nalezen)
            {
                cislo = generator.Next(0, 10);
                pocet++;
                Console.Write(" "+cislo+";");
                if (cislo == hledano)
                    nalezen = true;
            }
            Console.WriteLine();
            Console.WriteLine($"Tebou hledané číslo {hledano}, bylo vygenerováno jako {pocet}.");
        }
    }
}
