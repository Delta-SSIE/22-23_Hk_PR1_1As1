namespace _58_Median
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Odchylka od mediánu
            Console.WriteLine("Zadej počet čísel: ");
            int pocet = int.Parse(Console.ReadLine());
            int[] cisla = new int[pocet];
            for (int i = 0; i < pocet; i++)
            {
                Console.Write("Zadej {0}. číslo: ", i + 1);
                cisla[i] = int.Parse(Console.ReadLine());
            }
            // Zjednodušený medián
            int[] cisla2 = new int[cisla.Length];

            for (int i = 0; i < cisla.Length; i++)
            {
                cisla2[i] = cisla[i];
            }
            Array.Sort(cisla2);
            Console.WriteLine("\nSeřazené pole:");
            for (int i = 0; i < cisla2.Length; i++)
            {
                Console.Write(cisla2[i] + " | ");
            }
            float median = cisla2[cisla2.Length / 2];
            Console.WriteLine();
            Console.WriteLine("\nMedina je: " + median);
            Console.ReadKey();
            foreach (int i in cisla)
            {
                Console.WriteLine("\n{0} se od mediánu odchyluje o {1}", i, i - median);
            }
            Console.ReadKey();
        }
    }
}