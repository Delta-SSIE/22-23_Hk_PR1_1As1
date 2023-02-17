namespace _73_2Dpole_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int[,] D2_pole = new int[5, 5]; // definice proměnné 2d pole

            // naplníme 2D pole náhodnými čísly
           for (int j = 0; j < D2_pole.GetLength(1); j++) // řádek
            {
                for (int i = 0; i < D2_pole.GetLength(0); i++) //sloupec
                {
                    D2_pole[i, j]=generator.Next(0, 10);
                }
            }
          
           // Výpis 2D pole po řádkách
            for (int j = 0; j < D2_pole.GetLength(1); j++) // řádek
            {
                for (int i = 0; i < D2_pole.GetLength(0); i++) //sloupec
                {
                    Console.Write(D2_pole[i, j] + " ");           
                }
                Console.ReadKey();
                Console.WriteLine();
            }
          
            Console.ReadKey();
            Console.WriteLine();
            
            // Výpis 2D pole po sloupích
            for (int i = 0; i < D2_pole.GetLength(0); i++) // sloupec
            {
                for (int j = 0; j < D2_pole.GetLength(1); j++) //řádek
                {
                    Console.SetCursorPosition(i, j+10);
                    Console.WriteLine(D2_pole[i, j] + " ");
                }
                Console.ReadKey();
                Console.WriteLine(" ");
            }


        }
    }
}