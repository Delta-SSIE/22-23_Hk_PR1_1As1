namespace _52_Pole_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vytvoření pole , jeho naplnění a výpis");
            // vytvoření pole
            int[] moje_pole = new int[10];

            // naplnení pole
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Zadej " + (i + 1)+" hodnotu pro uložemí do pole:");
                moje_pole[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Vypis hodnot pole:");
            // výpis všech hodnot v poli za využití foreach (datovytyp promenna in kolekce
            foreach (int h in moje_pole) // lze použít i for (int i = 0; i < 10; i++)
            {
                Console.Write(h+"; ");
            }
            Console.WriteLine();
            Console.WriteLine();
            // výpis všech hodnot v poli za využití for
            Console.WriteLine("Vypis hodnot pole a jejich pozice:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hodnota pole na "+ (i+1)+". pozici je: " + moje_pole[i]);
            }

                Console.ReadKey();
        }
    }
}