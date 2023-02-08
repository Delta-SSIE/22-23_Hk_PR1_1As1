namespace _70_metody_hledani_jmena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] uzivatelskaJmena = ZiskejSeznam();// { "jan", "petr", "lucie", "jana" };
            Console.Write("Zadej hledané jméno: ");
            string hledej = Console.ReadLine();
            Vysledek(hledej, uzivatelskaJmena);
            Console.ReadKey();
        }
        static string[] ZiskejSeznam()
        {
            Console.Write("Zadej počet jmen v seznamu: ");
            int pocetJmen = int.Parse(Console.ReadLine());
            string[] seznam_jmen = new string[pocetJmen];
            for (int i = 0; i < pocetJmen; i++)
            {
                Console.Write("{0}. jmeno: ", i + 1);
                seznam_jmen[i] =Console.ReadLine();
                Console.Clear();
            }
            return seznam_jmen;
        }

        static void Vysledek(string hledano, string[] jmena1)
        {
            Console.WriteLine($"Jméno {hledano} {ExistujeJmeno(jmena1, hledano)}.");
        }

        static string ExistujeJmeno(string[] jmena, string hledaneJmeno)
        {
            foreach (string jmeno in jmena)
            {
                if (jmeno.ToLower() == hledaneJmeno.ToLower())
                {
                    return "je v seznamu";
                }
            }
            return "není v seznamu";
        }
    }
}