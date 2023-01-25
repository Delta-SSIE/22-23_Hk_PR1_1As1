namespace _62_VigenerovaSifra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Zadání vstupu
            Console.Write("Zadejte text k zašifrování: ");
            string vstup = Console.ReadLine();
            Console.Write("Zadejte heslo: ");
            string heslo = Console.ReadLine();
            // Pomocné proměnné
            string vystup = "";
            int poziceA = (int)'a';
            int poziceZ = (int)'z';
            // Iterace všemi znaky
            for (int i = 0; i < vstup.Length; i++)
            {
                /* Výpočet posunu v abecedě podle hesla
                   % je zbytek po celočíselném dělení a je 
                   zde využito pro jednoduché opakování 
                   hesla ve slově */

                int x = (int)heslo[i % heslo.Length] - (poziceA - 1);
                // Ošetření přetečení přes Z
                if ((int)vstup[i] + x > poziceZ)
                {
                    x -= poziceZ - poziceA + 1;
                }
                // Získání znaku výstupu
                char znak = (char)((int)vstup[i] + x);
                // Přidání znaku do výstupu
                vystup += znak;
            }
            Console.WriteLine(vystup);
            Console.ReadKey();
        }
    }
}