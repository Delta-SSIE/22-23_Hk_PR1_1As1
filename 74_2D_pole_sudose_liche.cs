namespace _74_2D_pole_sudose_liche
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] D2_pole = new int[5, 5]; // definice proměnné 2d pole
            /*
            // naplníme 2D pole lichý řádek 1, sudý řádek 0
            for (int j = 0; j < D2_pole.GetLength(1); j++) // řádek
            {
                for (int i = 0; i < D2_pole.GetLength(0); i++) //sloupec
                {
                    if ((j % 2) == 0 )
                    D2_pole[i, j] = 1;
                    else
                        D2_pole[i, j] = 0;
                }
            }*/

            /*
            // naplníme 2D pole lichý sloupec 1, sudý sloupec 0
            for (int j = 0; j < D2_pole.GetLength(1); j++) // řádek
            {
                for (int i = 0; i < D2_pole.GetLength(0); i++) //sloupec
                {
                    if ((i % 2) == 0)
                        D2_pole[i, j] = 1;
                    else
                        D2_pole[i, j] = 0;
                }
            }*/
            /* int a = 0;
             for (int j = 0; j < D2_pole.GetLength(1); j++) // řádek
             {
                 for (int i = 0; i < D2_pole.GetLength(0); i++) //sloupec
                 {
                     D2_pole[i, j] = a;
                     a++;

                 }
             }
             */
            /* int b = 0;
             for (int i = 0; i < D2_pole.GetLength(0); i++) // řádek
             {
                 for (int j = 0; j < D2_pole.GetLength(1); j++) //sloupec
                 {
                     D2_pole[i, j] = b;
                     b++;

                 }
             }*/

            // Hlavni diagnála 1, zbytek 0
            for (int j = 0; j < D2_pole.GetLength(1); j++) // řádek
            {
                for (int i = 0; i < D2_pole.GetLength(0); i++) //sloupec
                {
                    if (i == j)
                        D2_pole[i, j] = 1;
                    else
                        D2_pole[i, j] = 0;
                }
            }
            

            Vypis_po_radku(D2_pole);

            // POD hlavní diagnálou 1, zbytek 0
            for (int j = 0; j < D2_pole.GetLength(1); j++) // řádek
            {
                for (int i = 0; i < D2_pole.GetLength(0); i++) //sloupec
                {
                    if (i <= j)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        D2_pole[i, j] = 1;
                        Console.Write(D2_pole[i, j]+" ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        D2_pole[i, j] = 0;
                        Console.Write(D2_pole[i, j]+" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            // NAD hlavní diagnálou 1, zbytek 0
            for (int j = 0; j < D2_pole.GetLength(1); j++) // řádek
            {
                for (int i = 0; i < D2_pole.GetLength(0); i++) //sloupec
                {
                    if (j <= i)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        D2_pole[i, j] = 1;
                        Console.Write(D2_pole[i, j] + " ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        D2_pole[i, j] = 0;
                        Console.Write(D2_pole[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            



            // Metoda pro výpis matice
            static void Vypis_po_radku (int [,] pole2d)
            {
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

        }
    }
}