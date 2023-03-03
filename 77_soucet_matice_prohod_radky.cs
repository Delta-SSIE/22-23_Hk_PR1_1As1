namespace _77_soucet_matice_prohod_radky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vítej v programu - součet matic\n");
            int radek = vloz_hodnotu("velikost čtvercové matice:");
            int[,] pole_2D_A = napln_matici(radek);
            Vypis_matici(pole_2D_A, "Vygenerovaná matice A");
            int r_prohod_a = vloz_hodnotu("1. řadek pro prohozeni")-1;
            int r_prohod_b = vloz_hodnotu("2. řadek pro prohozeni")-1;
            int[,] pole_2D_B = prohod_radky(pole_2D_A, r_prohod_a, r_prohod_b);
            Vypis_matici(pole_2D_B, "Matice B s prohozenými řádky");
            Console.ReadKey();
            Console.Clear();
            Vypis_matici(pole_2D_A, "Vygenerovaná matice A");
            int s_prohod_a = vloz_hodnotu("1. sloupec pro prohozeni") - 1;
            int s_prohod_b = vloz_hodnotu("2. sloupec pro prohozeni") - 1;
            int[,] pole_2D_C = prohod_sloupce(pole_2D_A, s_prohod_a, s_prohod_b);
            Vypis_matici(pole_2D_C, "Matice C s prohozenými sloupci");

            Console.ReadKey();
            Console.Clear();
            Vypis_matici(pole_2D_B, "Matice B s prohozenými řádky");
            Vypis_matici(pole_2D_C, "Matice C s prohozenými sloupci");

            int[,] pole_2D_soucet = secti_matice(pole_2D_B, pole_2D_C);
            Vypis_matici(pole_2D_soucet, "Součet matic B + C");
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
            Console.WriteLine("\n"+text+"\n");
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

        static int[,] prohod_radky(int[,] pole2d, int ra, int rb)
        {
            int[,] pole2d_b = new int[pole2d.GetLength(0), pole2d.GetLength(1)];

            Array.Copy(pole2d, pole2d_b, pole2d.Length);
                    for (int i = 0; i < pole2d_b.GetLength(0); i++) //sloupec
                    {
                    int pomocna = pole2d_b[i, ra];
                    pole2d_b[i, ra] = pole2d_b[i, rb];
                    pole2d_b[i, rb] = pomocna;
                    }
                return pole2d_b;
        }

        static int[,] prohod_sloupce(int[,] pole2d, int sa, int sb)
        {
            int[,] pole2d_c = new int[pole2d.GetLength(0), pole2d.GetLength(1)];

            Array.Copy(pole2d, pole2d_c, pole2d.Length);
            for (int j = 0; j < pole2d_c.GetLength(1); j++) 
            {
                int pomocna = pole2d_c[sa, j];
                pole2d_c[sa, j] = pole2d_c[sb, j];
                pole2d_c[sb, j] = pomocna;
            }
            return pole2d_c;
        }

        static int[,] secti_matice(int[,] mat_a, int[,] mat_b)
        {
            int[,] pole = new int[mat_a.GetLength(0), mat_a.GetLength(1)];
            for (int j = 0; j < pole.GetLength(1); j++) // řádek
            {
                for (int i = 0; i < pole.GetLength(0); i++) //sloupec
                {
                    pole[i, j] = mat_a[i, j] + mat_b[i, j];
                }
            }
            return pole;
        }
    }
}