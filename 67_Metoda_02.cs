namespace _67_Metoda_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = NactiCislo();
            Console.WriteLine("Metoda načetla číslo: " + x);
            int y = NactiCislo();
            Console.WriteLine("Metoda načetla druhé číslo: " + y);
            Console.ReadKey();
        }

        static int NactiCislo()
        {
            int cislo;
            Console.WriteLine("Zadej číslo.");
            while (!int.TryParse(Console.ReadLine(), out cislo))
            {
                Console.WriteLine("Má to být číslo.");
            }
           /* int cislo = int.Parse(Console.ReadLine());*/
            return cislo;  // Vracíme hodnotu pomocá klíčového slova RETURN

        }     
            
    }
}