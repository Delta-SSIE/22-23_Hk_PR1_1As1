namespace ConsoleApp114
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int velikost = Nacteni_Velikost();
            List<int> List = new List<int>();
            List = Generace_Cisel(velikost);
            Vypis(List);

            while (true)
            {
                string operace = Operace();
                switch (operace)
                {
                    case "+":
                        Hodnota_Pridani(List);
                        Vypis(List);

                        break;
                    case "-":
                        Hodnota_Odstraneni(List);
                        Vypis(List);

                        break;
                    case "i":
                        Hodnota_Odstraneni_Index(List);

                        Vypis(List);
                        break;
                    default:
                        Console.WriteLine("Nepltana hodnota: ");
                        break;

                }

                bool pokracovat = Pokracovani();
                if (pokracovat)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }

        }
        static int Nacteni_Velikost()
        {
            Console.WriteLine("Zadejte velikost listu:");
            int velikost;
            while (!int.TryParse(Console.ReadLine(), out velikost))
            {
                Console.WriteLine("Neplatna hodnota");
                Console.WriteLine("Zadejte velikost listu:");

            }
            return velikost;
        }
        static List<int> Generace_Cisel(int velikost)
        {
            List<int> list = new List<int>();
            Random random = new Random();
            for (int i = 0; i < velikost; i++)
            {
                list.Add(random.Next(-10, 11));
            }
            return list;

        }
        static void Vypis(List<int> list)
        {
            foreach (int prvek in list)
            {
                Console.Write(prvek + " ");
            }
            Console.WriteLine();
        }

        static void Hodnota_Pridani(List<int> list)
        {
            Console.WriteLine("Jakou hodnotu chcete pridat");
            int honotaPridani;
            while (!int.TryParse(Console.ReadLine(), out honotaPridani))
            {
                Console.WriteLine("Neplatna hodnota");
                Console.WriteLine("Jakou hodnotu chcete pridat");
            }
            list.Add(honotaPridani);
        }
        static void Hodnota_Odstraneni(List<int> list)
        {
            Console.WriteLine("Jakou hodnotu chcete odstranit");
            int honotaPridani;
            while (!int.TryParse(Console.ReadLine(), out honotaPridani))
            {
                Console.WriteLine("Neplatna hodnota");
                Console.WriteLine("Jakou hodnotu chcete odstranit");
            }
            list.Remove(honotaPridani);
        }
        static void Hodnota_Odstraneni_Index(List<int> list)
        {
            Console.WriteLine("Zadejte index hodnoty, kterou chcete odstranit");
            int honotaPridani;
            while (!int.TryParse(Console.ReadLine(), out honotaPridani))
            {
                Console.WriteLine("Neplatna hodnota");
                Console.WriteLine("Zadejte index hodnoty, kterou chcete odstranit");
            }
            list.RemoveAt(honotaPridani);
        }
        static string Operace()
        {
            Console.WriteLine("Jakou operaci chcete proves");
            Console.WriteLine("Pridat +, odstranit, -, podle indexu i");
            string operace = (Console.ReadLine().ToLower());
            return operace;
        }
        static bool Pokracovani()
        {
            Console.WriteLine("Chcete pokracovat A/N");
            string pokracovat = Console.ReadLine().ToLower();
            if (pokracovat.ToLower() == "a")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}