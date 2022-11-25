namespace TEST_03_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool pokracovat = true;
            int cislo;
            int pocet_nul = 0;
            int pocet_kl = 0;
            int pocet_za = 0;
            string volba;

           Console.WriteLine("Program od vás bude načítat jednolitvá celá čísla (integer) a bude počítat kolik zadaných honot bylo kladných, kolik záporných a kolik nul");
            Console.WriteLine("Ošetřete, aby uživatel zadával celá čísla");
            Console.WriteLine("Před načtením dalšího čísla se zeptáte, zda chce uživatel pokračovat");
            Console.ReadKey();
            Console.Clear();
            do
            {
                Console.WriteLine("Zadejte číslo:");
                while (!int.TryParse(Console.ReadLine(), out cislo))
                    Console.WriteLine("Neplatné číslo, zadejte prosím znovu:");
                if (cislo == 0)
                    pocet_nul++;
                else
                {
                    if (cislo < 0)
                        pocet_za++;
                    else
                        pocet_kl++;
                }
                Console.WriteLine("Pro pokračovaní stiskni a");
                volba = Console.ReadLine().ToLower();

                if (volba !="a")
                    break;
            } while (pokracovat);

            Console.WriteLine($"Bylo zadáno {pocet_kl} kladných čísel, {pocet_za} záporných čísel a {pocet_nul} nul.");
        }
    }
}