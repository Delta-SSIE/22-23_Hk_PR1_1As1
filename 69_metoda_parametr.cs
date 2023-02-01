namespace _69_metoda_parametr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = NactiCislo();
            int y = NactiCislo();
            int vysledek = Soucet(x, y);
            Vypis("soucet", vysledek, x, y);
        }


        static int NactiCislo()
        {
            Console.WriteLine("Zadejte cislo:");
            int cislo = int.Parse(Console.ReadLine());
            // Hodnotu vracíme pomocí klíčového slova return
            return cislo;
        }
        static int Soucet(int cislo1,int cislo2)
        {
            int soucet = cislo1 + cislo2;
            return soucet;
        }

        static void Vypis(string operace, int vysledek_operace, int a, int b)
        {
            Console.Clear();
            Console.WriteLine($"Výsledkem matematické operace {operace} mezi cisly {a} a {b} je {vysledek_operace}");
        }
    }
}