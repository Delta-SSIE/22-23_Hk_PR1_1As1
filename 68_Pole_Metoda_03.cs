namespace _68_Pole_Metoda_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] seznamCisel = ZiskejPole();
            Console.WriteLine("Zadane znamky: ");
            Console.Write("| ");
            for (int i = 0; i < seznamCisel.Length; i++)
            {
                Console.Write("{0} | ", seznamCisel[i]);
            }
            Console.ReadKey();
        }

        static int[] ZiskejPole()
        {
            Console.Write("Velkost pole: ");
            int pocetCisel = Int32.Parse(Console.ReadLine());
            int[] pole_cisel = new int[pocetCisel];

            for (int i = 0; i < pocetCisel; i++)
            {
                Console.Write("{0}. cislo: ", i + 1);
                pole_cisel[i] = int.Parse(Console.ReadLine());
            }
            return pole_cisel;
        }
    }
}