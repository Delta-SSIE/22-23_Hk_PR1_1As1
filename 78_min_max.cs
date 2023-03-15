using System.Reflection.Emit;

namespace _78_min_max
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vítej v programu - hlednání min a max v matici\n");
            int radek = vloz_hodnotu("velikost čtvercové matice:");
            int[,] pole_2D_A = napln_matici(radek);
            Vypis_matici(pole_2D_A, "Vygenerovaná matice A");
            int min_2D = min(pole_2D_A);
            min_pocet(pole_2D_A, min_2D);
            int max_2D = max(pole_2D_A);
            max_pocet(pole_2D_A, max_2D);
        }


        static int vloz_hodnotu(string text)
        {
            int cislo;
            Console.WriteLine($"\nZadej {text}");
            while (!int.TryParse(Console.ReadLine(), out cislo))
            {
                Console.WriteLine("\nMá to být číslo.");
            }
            return cislo;
        }

        static int[,] napln_matici(int r)
        {
            Random generator = new Random();
            int[,] pole = new int[r, r];
            for (int j = 0; j < pole.GetLength(1); j++) // řádek
            {
                for (int i = 0; i < pole.GetLength(0); i++) //sloupec
                {
                    pole[i, j] = generator.Next(0, 10);
                }
            }
            return pole;
        }

        static void Vypis_matici(int[,] pole2d, string text)
        {
            Console.WriteLine("\n" + text + "\n");
            for (int j = 0; j < pole2d.GetLength(1); j++)
            {
                for (int i = 0; i < pole2d.GetLength(0); i++)
                {
                    Console.Write(pole2d[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static int min(int[,] pole)
        {
            int min = pole[0, 0];
            for (int j = 0; j < pole.GetLength(1); j++) // řádek
            {
                for (int i = 0; i < pole.GetLength(0); i++) //sloupec
                {
                    if (pole[i, j] < min)
                    min = pole[i, j];
                }
            }
            Console.WriteLine($"Minimum v matici je {min}");
            return min;
        }

        static void min_pocet(int[,] pole2d, int min2)
        {
            int min_pocet = 0;    
            for (int j = 0; j < pole2d.GetLength(1); j++)
            {
                for (int i = 0; i < pole2d.GetLength(0); i++)
                {
                    if (pole2d[i, j] == min2)
                        min_pocet++;
                }

            }
            Console.WriteLine($"Minimální hodnota {min2} se v matici nachází {min_pocet}");
        }

        static int max(int[,] pole)
        {
            int max = pole[0, 0];
            for (int j = 0; j < pole.GetLength(1); j++) // řádek
            {
                for (int i = 0; i < pole.GetLength(0); i++) //sloupec
                {
                    if (pole[i, j] > max)
                        max = pole[i, j];
                }
            }
            Console.WriteLine($"Minimum v matici je {max}");
            return max;
        }
        static void max_pocet(int[,] pole2d, int max2)
        {
            int max_pocet = 0;
            for (int j = 0; j < pole2d.GetLength(1); j++)
            {
                for (int i = 0; i < pole2d.GetLength(0); i++)
                {
                    if (pole2d[i, j] == max2)
                        max_pocet++;
                }

            }
            Console.WriteLine($"Minimální hodnota {max2} se v matici nachází {max_pocet}");
        }
    }
}