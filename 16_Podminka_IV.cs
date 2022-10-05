using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hodnota;
            Console.WriteLine("Zadej cele číslo");
            int cislo = int.Parse(Console.ReadLine());
            if (cislo == 0)
              hodnota = "Nula";
            else
            {
                if (cislo > 0)
                  hodnota = "Kladné čislo";
                else
                 hodnota = "Záporné čislo";
            }

            Console.WriteLine(hodnota);
            Console.ReadKey();
        }
    }
}
