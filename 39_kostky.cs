namespace _39_kostky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random(); // vytvářím konstruktor třídy Random se jménem generator
            bool pokracovat = true;
            int hra = 0;
            bool dalsi_hod = true;
            do
            {
                Console.Clear();
                    while (dalsi_hod)
                    {
                    int kostka_a = generator.Next(0, 7);
                    int kostka_b = generator.Next(0, 7);
                    hra++;
                        if (kostka_a == kostka_b)
                        { 
                            Console.WriteLine($"Na první kostce padlo číslo {kostka_a} a na druhé kostce padlo {kostka_b}. Hra je po {hra} hodech ukočena.");
                        //dalsi_hod=false;
                        break;
                        }
                        else
                        {
                            Console.WriteLine($"Padli hodnoty {kostka_a} a {kostka_b}. Stikni libovonou klávesu s jedeme dál.");
                            Console.ReadKey();
                        }
                     }
                //dalsi_hod = true;
             Console.WriteLine("Pro novou hru stiskni a");
              string volba = Console.ReadLine().ToLower();
                if (volba != "a")
                    break;
            } while (pokracovat);

        }
    }
}