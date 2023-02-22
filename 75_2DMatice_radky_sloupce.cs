namespace _75_2DMatice_radky_sloupce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            Console.WriteLine("Kolik má pole řádků");
            int radek = int.Parse(Console.ReadLine());

            Console.WriteLine("Kolik má pole sloupců");
            int sloupec = int.Parse(Console.ReadLine());

            int[,] D2_pole = new int[sloupec, radek]; // definice proměnné 2d pole
            int[,] D2_pole2 = new int[sloupec, radek]; //pomocné pole pro nulové řadky
            int[,] D2_pole3 = new int[sloupec, radek]; // pomocné pole pro nulové sloupce


            // naplníme 2D pole náhodnými čísly
            for (int j = 0; j < D2_pole.GetLength(1); j++) // řádek
            {
                for (int i = 0; i < D2_pole.GetLength(0); i++) //sloupec
                {
                    D2_pole[i, j] = generator.Next(0, 10);
                }
            }
            Vypis_matici(D2_pole);
            
            Array.Copy(D2_pole, D2_pole2, D2_pole.Length); // kopírování pole

            Console.WriteLine("Kolikátý řádek chceš nulový?");
            int radek_nul = int.Parse(Console.ReadLine());
            radek_nul--;

            for (int i = 0; i < D2_pole2.GetLength(0); i++) //sloupec
            {
                D2_pole2[i, radek_nul] = 0;
            }

            Vypis_matici(D2_pole2);




           Array.Copy(D2_pole, D2_pole3, D2_pole.Length);


            Console.WriteLine("Kolikátý sloupec chceš nulový?");
            int sloupec_nul = int.Parse(Console.ReadLine());
            sloupec_nul--;

            for (int j = 0; j < D2_pole3.GetLength(1); j++) //řádek
            {
                D2_pole3[sloupec_nul, j] = 0;
            }

            Vypis_matici(D2_pole3);


            // výpis matice
            static void Vypis_matici(int[,] pole2d)
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